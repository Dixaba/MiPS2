﻿namespace MiPS2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Avgqueue1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Wb1 = new System.Windows.Forms.NumericUpDown();
            this.Wa1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.El1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.El1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BorderWidth = 0;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.ItemColumnSpacing = 10;
            legend1.MaximumAutoSize = 20F;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 155);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.Green;
            series1.Legend = "Legend1";
            series1.Name = "Каналов занято";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Длина очереди";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(825, 317);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(839, 501);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(831, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Одна";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Avgqueue1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.T1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.C1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Wb1);
            this.panel1.Controls.Add(this.Wa1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.El1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 146);
            this.panel1.TabIndex = 1;
            // 
            // Avgqueue1
            // 
            this.Avgqueue1.AutoSize = true;
            this.Avgqueue1.Location = new System.Drawing.Point(590, 5);
            this.Avgqueue1.Name = "Avgqueue1";
            this.Avgqueue1.Size = new System.Drawing.Size(127, 13);
            this.Avgqueue1.TabIndex = 12;
            this.Avgqueue1.Text = "Средняя длина очереди";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(825, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // T1
            // 
            this.T1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.T1.Location = new System.Drawing.Point(496, 81);
            this.T1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.T1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(67, 20);
            this.T1.TabIndex = 10;
            this.T1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Максимальное время моделирования";
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(207, 81);
            this.C1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(66, 20);
            this.C1.TabIndex = 8;
            this.C1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество каналов обслуживания";
            // 
            // Wb1
            // 
            this.Wb1.DecimalPlaces = 6;
            this.Wb1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Wb1.Location = new System.Drawing.Point(207, 55);
            this.Wb1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.Wb1.Name = "Wb1";
            this.Wb1.Size = new System.Drawing.Size(66, 20);
            this.Wb1.TabIndex = 6;
            this.Wb1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Wa1
            // 
            this.Wa1.DecimalPlaces = 6;
            this.Wa1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Wa1.Location = new System.Drawing.Point(207, 29);
            this.Wa1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.Wa1.Name = "Wa1";
            this.Wa1.Size = new System.Drawing.Size(66, 20);
            this.Wa1.TabIndex = 5;
            this.Wa1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Распределение Вейбулла, β";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Экспоненциальное распределение, λ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Распределение Вейбулла, α";
            // 
            // El1
            // 
            this.El1.DecimalPlaces = 6;
            this.El1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.El1.Location = new System.Drawing.Point(207, 3);
            this.El1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.El1.Name = "El1";
            this.El1.Size = new System.Drawing.Size(66, 20);
            this.El1.TabIndex = 0;
            this.El1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(831, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Много";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(825, 469);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 501);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "МиПС2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.El1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown El1;
        private System.Windows.Forms.NumericUpDown C1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Wb1;
        private System.Windows.Forms.NumericUpDown Wa1;
        private System.Windows.Forms.NumericUpDown T1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Avgqueue1;
    }
}

