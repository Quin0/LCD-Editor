using Caliburn.Micro;
using EditorLCD.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using EditorLCD.Views;

namespace EditorLCD.ViewModels
{
    internal class ShellViewModel : Screen
    {

        private ObservableCollection<Models.Shape> lines;
        public ObservableCollection<Models.Shape> Lines
        {
            get
            {
                return lines;
            }
            set
            {
                lines = value;
                NotifyOfPropertyChange(() => Lines);
            }
        }

        private double canvasWidth;

        public double CanvasWidth
        {
            get { return canvasWidth; }
            set
            {
                canvasWidth = value;
                NotifyOfPropertyChange(() => CanvasWidth);
            }
        }

        private double canvasHeight;

        public double CanvasHeight
        {
            get { return canvasHeight; }
            set
            {
                canvasHeight = value;
                NotifyOfPropertyChange(() => CanvasHeight);
            }
        }

        protected override void OnViewReady(object view)
        {
            base.OnViewReady(view);

            CanvasWidth = 750;
            CanvasHeight = 500;

            Lines = CreateGrid(20, 20);
        }

        private ObservableCollection<Models.Shape> CreateGrid(int rows, int colums)
        {
            ObservableCollection<Models.Shape> tmp = new ObservableCollection<Models.Shape>();
            double columWidth = CanvasWidth / colums;
            double lastRow = columWidth * rows;
            CanvasHeight = lastRow;
            for (int i = 0; i < colums + 1; i++)
            {
                tmp.Add(new Models.Shape(columWidth * i + 0.15, 0 + 0.15, columWidth, columWidth));
            }

            for (int i = 0; i < rows + 1; i++)
            {
                tmp.Add(new Models.Shape(0 + 0.15, columWidth * i + 0.15, columWidth, columWidth));
            }
            return tmp;
        }

        public void ChangeColor(Rectangle sender)
        {
            SolidColorBrush color = new SolidColorBrush(Colors.Red);
            sender.Fill = color;
            sender.Stroke = color;
        }

    }
}
