﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WrapperClass;
using OxyPlot;

namespace Quantization_Tool
{
     public partial class Form1 : Form
    {
        private PlotModel Points_Plot = new PlotModel();
        private OxyPlot.Series.ScatterSeries Points_Data = new OxyPlot.Series.ScatterSeries();

        private PlotModel ScaleTime_Plot = new PlotModel();
        private OxyPlot.Series.LineSeries ScaleTime_MinScale = new OxyPlot.Series.LineSeries();
        private OxyPlot.Series.LineSeries ScaleTime_Min_NonVacScale = new OxyPlot.Series.LineSeries();
        private OxyPlot.Series.LineSeries ScaleTime_Max_NonVacScale = new OxyPlot.Series.LineSeries();
        private OxyPlot.Series.LineSeries ScaleTime_MaxScale = new OxyPlot.Series.LineSeries();

        private PlotModel MassScale_Plot = new PlotModel();
        private OxyPlot.Series.ScatterSeries[] MassScale_Data;
        private OxyPlot.Series.LineSeries NonVacScale_Boundary_Max_Mass = new OxyPlot.Series.LineSeries();
        private OxyPlot.Series.LineSeries NonVacScale_Boundary_Min_Mass = new OxyPlot.Series.LineSeries();

        private PlotModel EnergyScale_Laplacian_Plot = new PlotModel();
        private OxyPlot.Series.ScatterSeries[] EnergyScale_Laplacian_Data;
        private OxyPlot.Series.LineSeries NonVacScale_Boundary_Max_Laplacian = new OxyPlot.Series.LineSeries();
        private OxyPlot.Series.LineSeries NonVacScale_Boundary_Min_Laplacian = new OxyPlot.Series.LineSeries();

        private PlotModel EnergyScale_Plot = new PlotModel();
        private OxyPlot.Series.ScatterSeries[] EnergyScale_Data;
        private OxyPlot.Series.LineSeries NonVacScale_Boundary_Max = new OxyPlot.Series.LineSeries();
        private OxyPlot.Series.LineSeries NonVacScale_Boundary_Min = new OxyPlot.Series.LineSeries();

        private PlotModel EnergyScale_Commutator_Plot = new PlotModel();
        private OxyPlot.Series.ScatterSeries[] EnergyScale_Commutator_Data;
        private OxyPlot.Series.LineSeries NonVacScale_Boundary_Max_Commutator = new OxyPlot.Series.LineSeries();
        private OxyPlot.Series.LineSeries NonVacScale_Boundary_Min_Commutator = new OxyPlot.Series.LineSeries();

        private PlotModel EnergyScale_Laplacian_HeatMap_Plot = new PlotModel();
        private OxyPlot.Series.HeatMapSeries EnergyScale_Laplacian_HeatMap = new OxyPlot.Series.HeatMapSeries();
        private double[,] EnergyScale_Laplacian_HeatMap_Data;
        private double energy_laplacian_variable;

        private PlotModel EnergyScale_Commutator_HeatMap_Plot = new PlotModel();
        private OxyPlot.Series.HeatMapSeries EnergyScale_Commutator_HeatMap = new OxyPlot.Series.HeatMapSeries();
        private double[,] EnergyScale_Commutator_HeatMap_Data;
        private double energy_commutator_variable;

        private PlotModel EnergyScale_HeatMap_Plot = new PlotModel();
        private OxyPlot.Series.HeatMapSeries EnergyScale_HeatMap = new OxyPlot.Series.HeatMapSeries();
        private double[,] EnergyScale_HeatMap_Data;
        private double energy_variable;

        private PlotModel MassScale_HeatMap_Plot = new PlotModel();
        private OxyPlot.Series.HeatMapSeries MassScale_HeatMap = new OxyPlot.Series.HeatMapSeries();
        private double[,] MassScale_HeatMap_Data;
        private double mass_variable;

        private double Max_HeatMap_4plot;
        private double Max_HeatMap_4plot1;
        private double Max_Commutator_Energy;
        private double Min_Energy;

        private Simulation Sim_Variables;
        private State_Variables Initial_State;
        private State_Variables State;
        private Output_Variables output_Variables;
        private bool Eigenvectors_flag;

        private void Initialize_PointsPlot(PlotModel points_plot, Simulation sim_variables)
        {
            //points_plot.PlotAreaBorderThickness = new OxyThickness(2.0);
            points_plot.PlotMargins = new OxyThickness(0.0);
            points_plot.Title = "Points";
            points_plot.TitleFontWeight = 5;

            OxyPlot.Axes.LinearAxis x = new OxyPlot.Axes.LinearAxis();
            //x.Maximum = 1.0 * sim_variables.Coordinate_Range[0];
            //x.Minimum = -1.0 * sim_variables.Coordinate_Range[0];
            x.PositionAtZeroCrossing = true;
            x.Position = OxyPlot.Axes.AxisPosition.Bottom;
            x.TickStyle = OxyPlot.Axes.TickStyle.Crossing;
            points_plot.Axes.Add(x);

            OxyPlot.Axes.LinearAxis y = new OxyPlot.Axes.LinearAxis();
            //y.Maximum = 1.0 * sim_variables.Coordinate_Range[1];
            //y.Minimum = -1.0 * sim_variables.Coordinate_Range[1];
            y.PositionAtZeroCrossing = true;
            y.TickStyle = OxyPlot.Axes.TickStyle.Crossing;
            points_plot.Axes.Add(y);            
        }
        private void Initialize_ScaleTimePlot(PlotModel scaletime_plot, Simulation sim_variables)
        {
            //scaletime_plot.PlotAreaBorderThickness = new OxyThickness(0.0);
            scaletime_plot.PlotMargins = new OxyThickness(8.0);
            scaletime_plot.Title = "Scale vs Time";
            scaletime_plot.TitleFontWeight = 5;

            OxyPlot.Axes.LinearAxis x = new OxyPlot.Axes.LinearAxis();
            //x.Maximum = Sim_Variables.Time_Range;
            //x.Minimum = 0.0;
            x.PositionAtZeroCrossing = false;
            x.Position = OxyPlot.Axes.AxisPosition.Bottom;
            //x.MajorGridlineStyle = LineStyle.Solid;
            //x.MinorGridlineStyle = LineStyle.Dot;
            x.AxislineThickness = 0.5;
            x.AxislineColor = OxyColors.Black;
            x.TickStyle = OxyPlot.Axes.TickStyle.Crossing;
            x.AxisTickToLabelDistance = 0.0;
            x.FontSize = 8.0;
            scaletime_plot.Axes.Add(x);

            OxyPlot.Axes.LinearAxis y = new OxyPlot.Axes.LinearAxis();
            y.Minimum = 0.0;
            y.PositionAtZeroCrossing = true;
            y.MajorGridlineStyle = LineStyle.Solid;
            y.MinorGridlineStyle = LineStyle.Dot;
            y.AxislineThickness = 0.5;
            y.AxislineColor = OxyColors.Black;
            y.TickStyle = OxyPlot.Axes.TickStyle.Crossing;
            y.AxisTickToLabelDistance = 0.0;
            y.FontSize = 8.0;
            scaletime_plot.Axes.Add(y);
        }

        private void Initialize_EnergyScalePlot_Base(PlotModel energyscale_plot, OxyPlot.Series.ScatterSeries[] energyscale_data, OxyPlot.Series.LineSeries boundary_max, OxyPlot.Series.LineSeries boundary_min, Simulation sim_variables, State_Variables state)
        {
            //scaletime_plot.PlotAreaBorderThickness = new OxyThickness(0.0);
            energyscale_plot.PlotMargins = new OxyThickness(8.0);
            energyscale_plot.TitleFontWeight = 5;

            OxyPlot.Axes.LinearAxis x = new OxyPlot.Axes.LinearAxis();
            x.Maximum = State.Num_ScaleBins + 2;
            x.Minimum = 0.0;
            x.PositionAtZeroCrossing = true;
            x.Position = OxyPlot.Axes.AxisPosition.Bottom;
            x.AxislineThickness = 0.5;
            x.AxislineColor = OxyColors.Black;
            x.TickStyle = OxyPlot.Axes.TickStyle.Crossing;
            x.AxisTickToLabelDistance = 0.0;
            x.FontSize = 8.0;
            energyscale_plot.Axes.Add(x);

            OxyPlot.Axes.LinearAxis y = new OxyPlot.Axes.LinearAxis();
            y.PositionAtZeroCrossing = true;
            y.MajorGridlineStyle = LineStyle.Solid;
            y.MinorGridlineStyle = LineStyle.Dot;
            y.AxislineThickness = 0.5;
            y.AxislineColor = OxyColors.Black;
            y.TickStyle = OxyPlot.Axes.TickStyle.Crossing;
            y.AxisTickToLabelDistance = 0.0;
            y.FontSize = 8.0; 
            energyscale_plot.Axes.Add(y);

            boundary_max.Color = OxyColors.Red;
            boundary_min.Color = OxyColors.Red;
            boundary_max.StrokeThickness = 1;
            boundary_min.StrokeThickness = 1;
            //energyscale_plot.Series.Add(boundary_max);
            //energyscale_plot.Series.Add(boundary_min);
            for (int i = 0; i < (state.Num_ScaleBins + 2); i++)
            {
                energyscale_data[i] = new OxyPlot.Series.ScatterSeries();
                energyscale_data[i].MarkerType = MarkerType.Square;
                energyscale_data[i].MarkerSize = 1;
                energyscale_data[i].MarkerFill = OxyColors.Black;

                energyscale_plot.Series.Add(energyscale_data[i]);
            }

        }
        private void Initialize_MassScalePlot(PlotModel energyscale_plot, OxyPlot.Series.ScatterSeries[] energyscale_data, OxyPlot.Series.LineSeries boundary_max, OxyPlot.Series.LineSeries boundary_min, Simulation sim_variables, State_Variables state)
        {
            Initialize_EnergyScalePlot_Base(energyscale_plot, energyscale_data, boundary_max, boundary_min, sim_variables, state);
            energyscale_plot.Title = "Mass vs Scale";
            energyscale_plot.Axes[1].Maximum = State.Num_Points;
            energyscale_plot.Axes[1].Minimum = 0.0;
        }
        private void Initialize_EnergyScalePlot(PlotModel energyscale_plot, OxyPlot.Series.ScatterSeries[] energyscale_data, OxyPlot.Series.LineSeries boundary_max, OxyPlot.Series.LineSeries boundary_min, Simulation sim_variables, State_Variables state)
        {
            Initialize_EnergyScalePlot_Base(energyscale_plot, energyscale_data, boundary_max, boundary_min, sim_variables, state);
            energyscale_plot.Title = "Energy vs Scale";
            energyscale_plot.Axes[1].Maximum = State.Num_Points;
            energyscale_plot.Axes[1].Minimum = 0;
        }
        private void Initialize_LaplacianEnergyScalePlot(PlotModel energyscale_plot, OxyPlot.Series.ScatterSeries[] energyscale_data, OxyPlot.Series.LineSeries boundary_max, OxyPlot.Series.LineSeries boundary_min, Simulation sim_variables, State_Variables state)
        {
            Initialize_EnergyScalePlot_Base(energyscale_plot, energyscale_data, boundary_max, boundary_min, sim_variables, state);
            energyscale_plot.Title = "Wave Energy vs Scale";
            energyscale_plot.Axes[1].Maximum = State.Num_Points;
            energyscale_plot.Axes[1].Minimum = 0.0;
        }
        private void Initialize_CommutatorEnergyScalePlot(PlotModel energyscale_plot, OxyPlot.Series.ScatterSeries[] energyscale_data, OxyPlot.Series.LineSeries boundary_max, OxyPlot.Series.LineSeries boundary_min, Simulation sim_variables, State_Variables state)
        {
            Initialize_EnergyScalePlot_Base(energyscale_plot, energyscale_data, boundary_max, boundary_min, sim_variables, state);
            energyscale_plot.Title = "Commutator Energy vs Scale";
            energyscale_plot.Axes[1].Maximum = State.Num_Points;
            energyscale_plot.Axes[1].Minimum = -State.Num_Points;
        }

        private void Initialize_EnergyScaleHeatMap(PlotModel energyscale_heatmap_plot, OxyPlot.Series.HeatMapSeries energyscale_heatmap, State_Variables state)
        {
            //scaletime_plot.PlotAreaBorderThickness = new OxyThickness(0.0);
            energyscale_heatmap_plot.PlotMargins = new OxyThickness(0.0);
            energyscale_heatmap_plot.TitleFontWeight = 5;

            OxyPlot.Axes.LinearColorAxis xy = new OxyPlot.Axes.LinearColorAxis();
            xy.Palette = OxyPalettes.Jet(500);
            //xy.HighColor = OxyColors.Gray;
            //xy.LowColor = OxyColors.Black;
            //xy.Position = OxyPlot.Axes.AxisPosition.Right;
            energyscale_heatmap_plot.Axes.Add(xy);

            energyscale_heatmap.Interpolate = true;
            energyscale_heatmap.RenderMethod = OxyPlot.Series.HeatMapRenderMethod.Bitmap;
            energyscale_heatmap_plot.Series.Add(energyscale_heatmap);

            energyscale_heatmap.X0 = 0.0;
            energyscale_heatmap.X1 = state.Num_ScaleBins;
        }

        private int TimeLimit_4plot;
        private int SimTime_Counter;
        private ManualResetEvent MRE;
        private Thread Sim_Thread;
        private bool _RunButton_State;
        public bool RunButton_State
        {
            get { return _RunButton_State; }
            set { _RunButton_State = value; }
        }

        public Form1()
        {
            InitializeComponent();

            // Initialize Values
            Random rand = new Random();
            int _Num_Points = 10;
            int _Dimension = 5;
            Eigenvectors_flag = false;

            State = new State_Variables(_Num_Points, _Dimension);
            Initial_State = new State_Variables(State.Num_Points, State.Dimension);

            Max_HeatMap_4plot = 100.0;
            Max_HeatMap_4plot1 = 20.0;
            Max_Commutator_Energy = State.Num_Points;
            Min_Energy = 0;

            TimeLimit_4plot = 200;
            SimTime_Counter = 0;
            RunButton_State = false;
            Sim_Variables = new Simulation(State.Dimension);
            for (int i_d = 0; i_d < _Dimension; i_d++)
            {
                Sim_Variables.Coordinate_Range[i_d] = 10.0;
                Sim_Variables.Speed_Range[i_d] = 2.0;
            }

            Sim_Variables.Time_Range = 5.0;

            // This:
            Sim_Variables.dt = 0.01;
            //Sim_Variables.Num_TimeSteps = 100;
            // Or, 
            // Choose one and find the other : 
            // Num_Time_Bins = (uint)(Time_Range / dt);
            // dt = (double)(Time_Range / Num_Time_Bins);

            State.Mass_Ratio_Max = 10.0; // Default (should be > 1)            
            for (uint i_p = 0; i_p < State.Num_Points; i_p++)
            {
                // This:
                State.Mass_Ratios[i_p] = 1.0;
                // Or, 
                // Ask Mass_Ratio_Max (should be > 1) :
                //State.Mass_Ratios[i_p] = (State.Mass_Ratio_Max - 1.0) * rand.NextDouble() + 1.0;
                // Or,
                // Ask all the Mass Ratios!
            }

            double Hubble = 0;
            for (uint i_p = 0; i_p < State.Num_Points; i_p++)
            {
                for (uint i_d = 0; i_d < State.Dimension; i_d++)
                {
                    State.Positions[i_p][i_d] = Sim_Variables.Coordinate_Range[i_d] * (rand.NextDouble() - 0.5);
                    State.Velocities[i_p][i_d] = Sim_Variables.Speed_Range[i_d] * (rand.NextDouble() - 0.5);
                    //State.Velocities[i_p][i_d] = Hubble * State.Positions[i_p][i_d];

                    Initial_State.Positions[i_p][i_d] = State.Positions[i_p][i_d];
                    Initial_State.Velocities[i_p][i_d] = State.Velocities[i_p][i_d];
                }
            }

            output_Variables = new Output_Variables(State);

            // Choosing Force function ??
            // Probably have a choice between major force functions: Gravitation, Spring, Lenard-Jones, Hard (or Stiky) Balls, ..

            //
            
            topMiddle_plotView.Model = Points_Plot;
            Initialize_PointsPlot(Points_Plot, Sim_Variables);
            Points_Data.MarkerType = MarkerType.Circle;
            Points_Data.MarkerSize = 3;
            Points_Data.MarkerFill = OxyColors.Black;

            for (uint i_p = 0; i_p < State.Num_Points; i_p++)
            {
                if (State.Dimension == 1)
                    Points_Data.Points.Add(new OxyPlot.Series.ScatterPoint(State.Positions[i_p][0], 0));
                else
                    Points_Data.Points.Add(new OxyPlot.Series.ScatterPoint(State.Positions[i_p][0], State.Positions[i_p][1]));
            }
            Points_Plot.Series.Add(Points_Data);

            bottomMiddle_plotView.Model = ScaleTime_Plot;
            Initialize_ScaleTimePlot(ScaleTime_Plot, Sim_Variables);
            ScaleTime_MinScale.Color = OxyColors.Red;
            ScaleTime_Min_NonVacScale.Color = OxyColors.Black;
            ScaleTime_Max_NonVacScale.Color = OxyColors.Black;
            ScaleTime_MaxScale.Color = OxyColors.Blue;

            ScaleTime_Plot.Series.Add(ScaleTime_MinScale);
            ScaleTime_Plot.Series.Add(ScaleTime_Min_NonVacScale);
            ScaleTime_Plot.Series.Add(ScaleTime_Max_NonVacScale);
            ScaleTime_Plot.Series.Add(ScaleTime_MaxScale);

            topRight_plotView.Model = EnergyScale_Laplacian_Plot;
            EnergyScale_Laplacian_Data = new OxyPlot.Series.ScatterSeries[State.Num_ScaleBins + 2];
            Initialize_LaplacianEnergyScalePlot(EnergyScale_Laplacian_Plot, EnergyScale_Laplacian_Data, NonVacScale_Boundary_Max_Laplacian, NonVacScale_Boundary_Min_Laplacian, Sim_Variables, State);
            bottomRight_plotView.Model = EnergyScale_Commutator_Plot;
            EnergyScale_Commutator_Data = new OxyPlot.Series.ScatterSeries[State.Num_ScaleBins + 2];
            Initialize_CommutatorEnergyScalePlot(EnergyScale_Commutator_Plot, EnergyScale_Commutator_Data, NonVacScale_Boundary_Max_Commutator, NonVacScale_Boundary_Min_Commutator, Sim_Variables, State);
            topLeft_plotView.Model = MassScale_Plot;
            MassScale_Data = new OxyPlot.Series.ScatterSeries[State.Num_ScaleBins + 2];
            Initialize_MassScalePlot(MassScale_Plot, MassScale_Data, NonVacScale_Boundary_Max_Mass, NonVacScale_Boundary_Min_Mass, Sim_Variables, State);
            bottomLeft_plotView.Model = EnergyScale_Plot;
            EnergyScale_Data = new OxyPlot.Series.ScatterSeries[State.Num_ScaleBins + 2];
            Initialize_EnergyScalePlot(EnergyScale_Plot, EnergyScale_Data, NonVacScale_Boundary_Max, NonVacScale_Boundary_Min, Sim_Variables, State);

            plot_plotView.Model = EnergyScale_Commutator_HeatMap_Plot;
            //bottomRight_plotView.Model = EnergyScale_Commutator_HeatMap_Plot;
            Initialize_EnergyScaleHeatMap(EnergyScale_Commutator_HeatMap_Plot, EnergyScale_Commutator_HeatMap, State);
            EnergyScale_Commutator_HeatMap_Plot.Title = "Commutator Energy vs Scale";
            EnergyScale_Commutator_HeatMap.Y0 = -State.Num_EnergyBins;
            EnergyScale_Commutator_HeatMap.Y1 = State.Num_EnergyBins;

            //topRight_plotView.Model = EnergyScale_Laplacian_HeatMap_Plot;
            Initialize_EnergyScaleHeatMap(EnergyScale_Laplacian_HeatMap_Plot, EnergyScale_Laplacian_HeatMap, State);
            EnergyScale_Laplacian_HeatMap_Plot.Title = "Laplacian Energy vs Scale";
            EnergyScale_Laplacian_HeatMap.Y0 = 0.0;
            EnergyScale_Laplacian_HeatMap.Y1 = State.Num_EnergyBins;

            //plot_plotView.Model = EnergyScale_HeatMap_Plot;
            //bottomLeft_plotView.Model = EnergyScale_HeatMap_Plot;
            Initialize_EnergyScaleHeatMap(EnergyScale_HeatMap_Plot, EnergyScale_HeatMap, State);
            EnergyScale_HeatMap_Plot.Title = "Energy vs Scale";
            EnergyScale_HeatMap.Y0 = 0.0;
            EnergyScale_HeatMap.Y1 = State.Num_EnergyBins;

            //topLeft_plotView.Model = MassScale_HeatMap_Plot;
            Initialize_EnergyScaleHeatMap(MassScale_HeatMap_Plot, MassScale_HeatMap, State);
            MassScale_HeatMap_Plot.Title = "Mass vs Scale";
            MassScale_HeatMap.Y0 = 0.0;
            MassScale_HeatMap.Y1 = State.Num_EnergyBins;

            // Threading
            MRE = new ManualResetEvent(false);
            Sim_Thread = new Thread(Run_Simulation);
            Sim_Thread.IsBackground = true;
            // Running the Thread
            Sim_Thread.Start();


        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            RunButton_State = !RunButton_State;
            if (RunButton_State)
            {
                button_Run.Text = "Stop";
                MRE.Set();
            }
            else
            {
                button_Run.Text = "Run";
                //Thread.Sleep(2000);
                MRE.Reset();
            }

        }

        private void Run_Simulation()
        {
            while (true)
            {
                MRE.WaitOne();

                // Timing:
                //var watch = System.Diagnostics.Stopwatch.StartNew();

                if (double.IsNaN(output_Variables.Laplacian_Energy[0][0]))
                {
                    int x = 0;
                }
                else
                {
                    output_Variables = Sim_Variables.Evolve(State, Eigenvectors_flag);
                }

                SimTime_Counter++;
                if (SimTime_Counter > TimeLimit_4plot)
                {
                    ScaleTime_MinScale.Points.RemoveAt(0);
                    ScaleTime_Min_NonVacScale.Points.RemoveAt(0);
                    ScaleTime_Max_NonVacScale.Points.RemoveAt(0);
                    ScaleTime_MaxScale.Points.RemoveAt(0);
                }
                ScaleTime_MinScale.Points.Add(new OxyPlot.DataPoint(SimTime_Counter, output_Variables.Min_Scale));
                ScaleTime_Min_NonVacScale.Points.Add(new OxyPlot.DataPoint(SimTime_Counter, output_Variables.Min_NonVacScale));
                ScaleTime_Max_NonVacScale.Points.Add(new OxyPlot.DataPoint(SimTime_Counter, output_Variables.Max_NonVacScale));
                ScaleTime_MaxScale.Points.Add(new OxyPlot.DataPoint(SimTime_Counter, output_Variables.Max_Scale));

                Points_Data.Points.Clear();

                NonVacScale_Boundary_Min_Laplacian.Points.Clear();
                NonVacScale_Boundary_Max_Laplacian.Points.Clear();
                NonVacScale_Boundary_Min_Laplacian.Points.Add(new OxyPlot.DataPoint((output_Variables.Min_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, 0));
                NonVacScale_Boundary_Min_Laplacian.Points.Add(new OxyPlot.DataPoint((output_Variables.Min_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, State.Num_Points));
                NonVacScale_Boundary_Max_Laplacian.Points.Add(new OxyPlot.DataPoint((output_Variables.Max_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, 0));
                NonVacScale_Boundary_Max_Laplacian.Points.Add(new OxyPlot.DataPoint((output_Variables.Max_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, State.Num_Points));

                NonVacScale_Boundary_Min_Commutator.Points.Clear();
                NonVacScale_Boundary_Max_Commutator.Points.Clear();
                NonVacScale_Boundary_Min_Commutator.Points.Add(new OxyPlot.DataPoint((output_Variables.Min_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, -Max_Commutator_Energy));
                NonVacScale_Boundary_Min_Commutator.Points.Add(new OxyPlot.DataPoint((output_Variables.Min_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, Max_Commutator_Energy));
                NonVacScale_Boundary_Max_Commutator.Points.Add(new OxyPlot.DataPoint((output_Variables.Max_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, -Max_Commutator_Energy));
                NonVacScale_Boundary_Max_Commutator.Points.Add(new OxyPlot.DataPoint((output_Variables.Max_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, Max_Commutator_Energy));

                NonVacScale_Boundary_Min.Points.Clear();
                NonVacScale_Boundary_Max.Points.Clear();
                NonVacScale_Boundary_Min.Points.Add(new OxyPlot.DataPoint((output_Variables.Min_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, Min_Energy));
                NonVacScale_Boundary_Min.Points.Add(new OxyPlot.DataPoint((output_Variables.Min_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, State.Num_Points));
                NonVacScale_Boundary_Max.Points.Add(new OxyPlot.DataPoint((output_Variables.Max_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, Min_Energy));
                NonVacScale_Boundary_Max.Points.Add(new OxyPlot.DataPoint((output_Variables.Max_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, State.Num_Points));

                NonVacScale_Boundary_Min_Mass.Points.Clear();
                NonVacScale_Boundary_Max_Mass.Points.Clear();
                NonVacScale_Boundary_Min_Mass.Points.Add(new OxyPlot.DataPoint((output_Variables.Min_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, 0));
                NonVacScale_Boundary_Min_Mass.Points.Add(new OxyPlot.DataPoint((output_Variables.Min_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, State.Num_Points));
                NonVacScale_Boundary_Max_Mass.Points.Add(new OxyPlot.DataPoint((output_Variables.Max_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, 0));
                NonVacScale_Boundary_Max_Mass.Points.Add(new OxyPlot.DataPoint((output_Variables.Max_NonVacScale / output_Variables.Max_Scale) * State.Num_ScaleBins, State.Num_Points));

                for (uint i_p = 0; i_p < State.Num_Points; i_p++)
                {
                    if (State.Dimension == 1)
                        Points_Data.Points.Add(new OxyPlot.Series.ScatterPoint(State.Positions[i_p][0], 0));
                    else
                        Points_Data.Points.Add(new OxyPlot.Series.ScatterPoint(State.Positions[i_p][0], State.Positions[i_p][1]));

                    EnergyScale_Laplacian_Data[i_p].Points.Clear();
                    EnergyScale_Commutator_Data[i_p].Points.Clear();
                    EnergyScale_Data[i_p].Points.Clear();
                    MassScale_Data[i_p].Points.Clear();
                    for (uint i_s = 0; i_s < (State.Num_ScaleBins + 2); i_s++)
                    {   
                        if (i_p > 0)
                            EnergyScale_Laplacian_Data[i_p].Points.Add(new OxyPlot.Series.ScatterPoint(i_s, output_Variables.Laplacian_Energy[i_s][i_p]));
                        EnergyScale_Commutator_Data[i_p].Points.Add(new OxyPlot.Series.ScatterPoint(i_s, output_Variables.Commutator_Energy[i_s][i_p]));
                        EnergyScale_Data[i_p].Points.Add(new OxyPlot.Series.ScatterPoint(i_s, output_Variables.Energy_Vector[i_s][i_p]));
                        MassScale_Data[i_p].Points.Add(new OxyPlot.Series.ScatterPoint(i_s, output_Variables.Mass_Vector[i_s][i_p]));

                        if (output_Variables.Commutator_Energy[i_s][i_p] > Max_Commutator_Energy)
                            Max_Commutator_Energy = output_Variables.Commutator_Energy[i_s][i_p];

                        if (output_Variables.Energy_Vector[i_s][i_p] < Min_Energy)
                            Min_Energy = output_Variables.Energy_Vector[i_s][i_p];
                    }
                }
                EnergyScale_Commutator_Plot.Axes[1].Maximum = Max_Commutator_Energy;
                EnergyScale_Commutator_Plot.Axes[1].Minimum = -Max_Commutator_Energy;
                EnergyScale_Plot.Axes[1].Minimum = Min_Energy;

                // Laplacian Energy Levels
                EnergyScale_Laplacian_HeatMap_Data = new double[State.Num_ScaleBins + 2, State.Num_EnergyBins + 1];
                for (uint i_e = 0; i_e < (State.Num_EnergyBins + 1); i_e++)
                {
                    energy_laplacian_variable = (double)(i_e * State.Num_Points) / (double)State.Num_EnergyBins;
                    for (uint i_s = 0; i_s < (State.Num_ScaleBins + 2); i_s++)
                    {
                        EnergyScale_Laplacian_HeatMap_Data[i_s, i_e] = 0.0;
                        for (uint i_p = 0; i_p < State.Num_Points; i_p++)
                        {
                            EnergyScale_Laplacian_HeatMap_Data[i_s, i_e] += -Math.Log(Math.Abs(energy_laplacian_variable - output_Variables.Laplacian_Energy[i_s][i_p]));
                        }

                        if (EnergyScale_Laplacian_HeatMap_Data[i_s, i_e] > Max_HeatMap_4plot)
                            EnergyScale_Laplacian_HeatMap_Data[i_s, i_e] = Max_HeatMap_4plot;
                    }
                }
                EnergyScale_Laplacian_HeatMap.Data = EnergyScale_Laplacian_HeatMap_Data;

                // Commutator Energy Levels
                EnergyScale_Commutator_HeatMap_Data = new double[State.Num_ScaleBins + 2, State.Num_EnergyBins + 1];
                for (uint i_e = 0; i_e < (State.Num_EnergyBins + 1); i_e++)
                {
                    energy_commutator_variable = (double)(i_e * Max_Commutator_Energy * 2) / (double)State.Num_EnergyBins - Max_Commutator_Energy;
                    for (uint i_s = 0; i_s < (State.Num_ScaleBins + 2); i_s++)
                    {
                        EnergyScale_Commutator_HeatMap_Data[i_s, i_e] = 0.0;
                        for (uint i_p = 0; i_p < State.Num_Points; i_p++)
                        {
                            EnergyScale_Commutator_HeatMap_Data[i_s, i_e] += -Math.Log(Math.Abs(energy_commutator_variable - output_Variables.Commutator_Energy[i_s][i_p]));
                        }

                        if (EnergyScale_Commutator_HeatMap_Data[i_s, i_e] > Max_HeatMap_4plot)
                            EnergyScale_Commutator_HeatMap_Data[i_s, i_e] = Max_HeatMap_4plot;
                    }
                }
                EnergyScale_Commutator_HeatMap.Data = EnergyScale_Commutator_HeatMap_Data;

                // Energy Levels
                EnergyScale_HeatMap_Data = new double[State.Num_ScaleBins + 2, State.Num_EnergyBins + 1];
                for (uint i_e = 0; i_e < (State.Num_EnergyBins + 1); i_e++)
                {
                    energy_variable = (double)(i_e * (State.Num_Points - Min_Energy)) / (double)State.Num_EnergyBins + Min_Energy;
                    for (uint i_s = 0; i_s < (State.Num_ScaleBins + 2); i_s++)
                    {
                        EnergyScale_HeatMap_Data[i_s, i_e] = 0.0;
                        for (uint i_p = 0; i_p < State.Num_Points; i_p++)
                        {
                            EnergyScale_HeatMap_Data[i_s, i_e] += -Math.Log(Math.Abs(energy_variable - output_Variables.Energy_Vector[i_s][i_p]));
                        }

                        if (EnergyScale_HeatMap_Data[i_s, i_e] > Max_HeatMap_4plot1)
                            EnergyScale_HeatMap_Data[i_s, i_e] = Max_HeatMap_4plot1;
                    }
                }
                EnergyScale_HeatMap.Data = EnergyScale_HeatMap_Data;

                // Mass Levels
                MassScale_HeatMap_Data = new double[State.Num_ScaleBins + 2, State.Num_EnergyBins + 1];
                for (uint i_e = 0; i_e < (State.Num_EnergyBins + 1); i_e++)
                {
                    mass_variable = (double)(i_e * State.Num_Points) / (double)State.Num_EnergyBins;
                    for (uint i_s = 0; i_s < (State.Num_ScaleBins + 2); i_s++)
                    {
                        MassScale_HeatMap_Data[i_s, i_e] = 0.0;
                        for (uint i_p = 0; i_p < State.Num_Points; i_p++)
                        {
                            MassScale_HeatMap_Data[i_s, i_e] += -Math.Log(Math.Abs(mass_variable - output_Variables.Mass_Vector[i_s][i_p]));
                        }

                        //if (double.IsInfinity(MassScale_HeatMap_Data[i_s, i_e]))
                        //{
                        //    MassScale_HeatMap_Data[i_s, i_e] = double.NaN;
                        //}

                        if (MassScale_HeatMap_Data[i_s, i_e] > Max_HeatMap_4plot)
                            MassScale_HeatMap_Data[i_s, i_e] = Max_HeatMap_4plot;
                    }
                }
                MassScale_HeatMap.Data = MassScale_HeatMap_Data;

                ScaleTime_Plot.InvalidatePlot(true);
                Points_Plot.InvalidatePlot(true);

                EnergyScale_Laplacian_Plot.InvalidatePlot(true);
                EnergyScale_Commutator_Plot.InvalidatePlot(true);
                EnergyScale_Plot.InvalidatePlot(true);
                MassScale_Plot.InvalidatePlot(true);

                EnergyScale_Laplacian_HeatMap_Plot.InvalidatePlot(true);
                EnergyScale_Commutator_HeatMap_Plot.InvalidatePlot(true);
                EnergyScale_HeatMap_Plot.InvalidatePlot(true);
                MassScale_HeatMap_Plot.InvalidatePlot(true);

                //watch.Stop();
                //var elapsed = watch.ElapsedMilliseconds/1000.0;
            }
        }
    }

    class State_Variables
    {
        public int Num_Points, Dimension, Number_Pairs;
        public int Num_ScaleBins;
        public int Num_EnergyBins;

        public double Mass_Ratio_Max;
        public double[] Mass_Ratios;

        public double[][] Positions, Velocities;

        public State_Variables(int num_points, int dimension, int num_scalebins) : this(num_points, dimension)
        {
            Num_ScaleBins = num_scalebins;
        }

        public State_Variables(int num_points, int dimension)
        {
            Num_Points = num_points;
            Dimension = dimension;
            Number_Pairs = num_points * (num_points - 1) / 2;
            Num_ScaleBins = 2 * num_points * num_points;
            Num_EnergyBins = num_points * 100;

            Mass_Ratios = new double[num_points];
            Positions = new double[num_points][];
            Velocities = new double[num_points][];
            for (uint i = 0; i < num_points; i++)
            {
                Positions[i] = new double[dimension];
                Velocities[i] = new double[dimension];
            }
        }

    }
    class Output_Variables
    {
        public double Min_Scale;
        public double Min_NonVacScale;
        public double Max_NonVacScale;
        public double Max_Scale;

        public double[] Scale_Ladder_Original;
        public double[] Scale_Ladder_Dual;
        public bool[][] Dendogram_Original;
        public bool[][] Dendogram_Dual;

        public double[][] Laplacian_Energy;
        public double[][] Commutator_Energy;
        public double[][] Mass_Vector;
        public double[][] Energy_Vector;
        public double[][,] Orthonormal_Transformation;

        public Output_Variables(State_Variables state)
        {
            Scale_Ladder_Original = new double[state.Num_Points];
            Scale_Ladder_Dual = new double[state.Num_Points];
            Dendogram_Original = new bool[state.Num_Points][];
            Dendogram_Dual = new bool[state.Num_Points][];
            for (int i = 0; i < state.Num_Points; i++)
            {
                Dendogram_Original[i] = new bool[state.Num_Points];
                Dendogram_Dual[i] = new bool[state.Num_Points];
            }
            Laplacian_Energy = new double[state.Num_ScaleBins + 2][];
            Commutator_Energy = new double[state.Num_ScaleBins + 2][];
            Mass_Vector = new double[state.Num_ScaleBins + 2][];
            Energy_Vector = new double[state.Num_ScaleBins + 2][];
            Orthonormal_Transformation = new double[state.Num_ScaleBins + 2][,];
            for (int i=0; i < (state.Num_ScaleBins + 2); i++)
            {
                Laplacian_Energy[i] = new double[state.Num_Points];
                Commutator_Energy[i] = new double[state.Num_Points];
                Mass_Vector[i] = new double[state.Num_Points];
                Energy_Vector[i] = new double[state.Num_Points];
                Orthonormal_Transformation[i] = new double[state.Num_Points, state.Num_Points];
            }
        }
    }
    class Simulation
    {
        public double Time_Range, dt = 0.05; //Default
        private int Num_TimeSteps = 1;

        public double[] Coordinate_Range, Speed_Range;

        Output_Variables Out;
        WrapperClass.Quantization Q;

        public Simulation(int dimension)
        {
            Coordinate_Range = new double[dimension];
            Speed_Range = new double[dimension];
        }

        public Output_Variables Evolve(State_Variables state, bool eigenvectors_flag)
        {
            Out = new Output_Variables(state);
            // Fixing the pointer handles 
            GCHandle[] handle_Positions = new GCHandle[state.Num_Points];
            GCHandle[] handle_Velocities = new GCHandle[state.Num_Points];
            for (uint i_p = 0; i_p < state.Num_Points; i_p++)
            {
                handle_Positions[i_p] = GCHandle.Alloc(state.Positions[i_p], GCHandleType.Pinned);
                handle_Velocities[i_p] = GCHandle.Alloc(state.Velocities[i_p], GCHandleType.Pinned);
            }
            //
            unsafe
            {
                double*[] _positions = new double*[state.Num_Points];
                double*[] _velocities = new double*[state.Num_Points];

                for (uint i_p = 0; i_p < state.Num_Points; i_p++)
                {
                    _positions[i_p] = (double*)handle_Positions[i_p].AddrOfPinnedObject().ToPointer();
                    _velocities[i_p] = (double*)handle_Velocities[i_p].AddrOfPinnedObject().ToPointer();
                }
                fixed (double** p = &_positions[0], v = &_velocities[0])
                {
                    fixed (double* m = &state.Mass_Ratios[0])
                    {
                        // Un-managed Code!
                        Q = new Quantization(p, v, m, state.Num_Points, state.Dimension, dt, state.Num_ScaleBins, eigenvectors_flag, false);
                    }
                }

                for (uint i_s = 0; i_s < (state.Num_ScaleBins + 2); i_s++)
                {
                    for (uint i_p = 0; i_p < state.Num_Points; i_p++)
                    {
                        Out.Laplacian_Energy[i_s][i_p] = Q.Laplacian_Energy[i_s][i_p];
                        Out.Commutator_Energy[i_s][i_p] = Q.Commutator_Energy[i_s][i_p];
                        Out.Mass_Vector[i_s][i_p] = Q.Mass_Vector[i_s][i_p];
                        Out.Energy_Vector[i_s][i_p] = Q.Energy_Vector[i_s][i_p];

                        if (eigenvectors_flag)
                        {
                            for (uint j_p = 0; j_p < state.Num_Points; j_p++)
                            {
                                Out.Orthonormal_Transformation[i_s][i_p, j_p] = Q.Orthonormal_Transformation[i_s][i_p][j_p];
                            }
                        }
                    }
                }

                for (uint i_p = 0; i_p < state.Num_Points; i_p++)
                {
                    Out.Scale_Ladder_Original[i_p] = Q.Scale_Ladder_Original[i_p];
                    Out.Scale_Ladder_Dual[i_p] = Q.Scale_Ladder_Dual[i_p];
                    for (uint j_p = 0; j_p < state.Num_Points; j_p++)
                    {
                        Out.Dendogram_Original[i_p][j_p] = Q.Dendogram_Original[i_p][j_p];
                        Out.Dendogram_Dual[i_p][j_p] = Q.Dendogram_Dual[i_p][j_p];
                    }
                }
            }
            // Releasing the pointer handles 
            for (uint i_p = 0; i_p < state.Num_Points; i_p++)
            {
                handle_Positions[i_p].Free();
                handle_Velocities[i_p].Free();
            }
            //
            Out.Min_Scale = Q.Min_Scale;
            Out.Max_Scale = Q.Max_Scale;
            Out.Min_NonVacScale = Q.Min_NonVacScale;
            Out.Max_NonVacScale = Q.Max_NonVacScale;

            return Out;
        }

    }

}
