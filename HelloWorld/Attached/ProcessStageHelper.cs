using HelloWorld.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HelloWorld.Attached
{
    public class ProcessStageHelper : DependencyObject
    {
        public static readonly DependencyProperty
            ProcessCompletionProperty = DependencyProperty.RegisterAttached("ProcessCompletion", typeof(double), typeof(ProcessStageHelper), new PropertyMetadata(0.0, OnProcessCompletionChanged));
        
        public static double GetProcessCompletion(DependencyObject obj)
        {
            return (double)obj.GetValue(ProcessCompletionProperty);
        }

        public static void SetProcessCompletion(DependencyObject obj, double value)
        {
            obj.SetValue(ProcessCompletionProperty, value);
        }

        private static readonly DependencyPropertyKey ProcessStagePropertyKey =
            DependencyProperty.RegisterAttachedReadOnly("ProcessStage", typeof(ProcessStage), typeof(ProcessStageHelper), new PropertyMetadata(ProcessStage.Stage1));

        private static readonly DependencyProperty ProcessStageProperty = ProcessStagePropertyKey.DependencyProperty;

        public static ProcessStage GetProcessStage(DependencyObject obj)
        {
            return (ProcessStage)obj.GetValue(ProcessStageProperty); 
        }

        private static void OnProcessCompletionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            double progress = (double)e.NewValue;
            //ProgressBar bar = (d as ProgressBar).TemplatedParent as ProgressBar;
            TextBlock textBlock = d as TextBlock;

            if (progress >= 0 && progress < 20)
            {
                textBlock.SetValue(ProcessStagePropertyKey, ProcessStage.Stage1);
            } else if (progress >= 20 && progress < 40)
            {
                textBlock.SetValue(ProcessStagePropertyKey, ProcessStage.Stage2);
            } else if (progress >= 40 && progress < 60)
            {
                textBlock.SetValue(ProcessStagePropertyKey, ProcessStage.Stage3);
            } else if (progress >= 60 && progress < 80)
            {
                textBlock.SetValue(ProcessStagePropertyKey, ProcessStage.Stage4);
            } else if (progress >= 80 && progress <= 100)
                {
                textBlock.SetValue(ProcessStagePropertyKey, ProcessStage.Stage5);
            }
        }
    }
}
