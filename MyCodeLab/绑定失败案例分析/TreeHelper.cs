using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;

namespace 绑定失败案例分析
{
    public static class TreeHelper
    {
       public static string getTree(FrameworkElement container)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("********Logical Tree********");
            getLogicalChildren(container, sb, 0);
            sb.AppendLine();

            sb.AppendLine("********Visual Tree********");
            getVisualChildren(container, sb, 0);
            sb.AppendLine();

            return sb.ToString();
        }

        private static void appendLine(FrameworkElement frameworkElement, StringBuilder sb, int num)
        {
            sb.Append("".PadLeft(num));

            string name = $"({frameworkElement.GetType().Name})";
            name += $"({frameworkElement.Name})";
            name += $" [{(frameworkElement.DataContext ?? new object()).GetType().Name}]";

            sb.AppendLine($"{num}.{name}");
        }

        private static void getLogicalChildren(FrameworkElement container, StringBuilder sb, int num)
        {
            appendLine(container, sb, num);
            foreach (var child in LogicalTreeHelper.GetChildren(container))
            {
                FrameworkElement frameworkElement = child as FrameworkElement;
                if (frameworkElement != null)
                {
                    getLogicalChildren(frameworkElement, sb, num + 1);
                }
            }
        }

        private static void getVisualChildren(FrameworkElement container, StringBuilder sb, int num)
        {
            appendLine(container, sb, num);
            int count = VisualTreeHelper.GetChildrenCount(container);
            for (int i = 0; i < count; i++)
            {
                FrameworkElement frameworkElement = VisualTreeHelper.GetChild(container, i) as FrameworkElement;
                if (frameworkElement != null)
                {
                    getVisualChildren(frameworkElement, sb, num + 1);
                }
            }
        }
    }
}
