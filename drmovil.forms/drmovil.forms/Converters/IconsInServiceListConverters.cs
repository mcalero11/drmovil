using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace drmovil.forms.Converters
{
    public class InReviewIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (Entities.Helpers.TaskStatus)value;
            if (status == Entities.Helpers.TaskStatus.InReview)
            {
                return "waiting_icon.png";
            }
            return "disable_waiting_icon.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class RejectedIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (Entities.Helpers.TaskStatus)value;
            if (status == Entities.Helpers.TaskStatus.Rejected)
            {
                return "rejected_icon.png";
            }
            return "disable_rejected_icon.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class InProgressIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (Entities.Helpers.TaskStatus)value;
            if (status == Entities.Helpers.TaskStatus.InProgress)
            {
                return "waiting_icon.png";
            }
            return "disable_waiting_icon.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class CompletedIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (Entities.Helpers.TaskStatus)value;
            if (status == Entities.Helpers.TaskStatus.Completed)
            {
                return "completed_icon.png";
            }
            return "disable_completed_icon.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class StatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (Entities.Helpers.TaskStatus)value;
            string statusName = "None";
            switch (status)
            {
                case Entities.Helpers.TaskStatus.InReview:
                    statusName = "En Revisión";
                    break;
                case Entities.Helpers.TaskStatus.Rejected:
                    statusName = "Rechazado";
                    break;
                case Entities.Helpers.TaskStatus.InProgress:
                    statusName = "En Progreso";
                    break;
                case Entities.Helpers.TaskStatus.Completed:
                    statusName = "Completado";
                    break;
            }
            
            return statusName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class CopyIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isPublicShare = (bool)value;
            if (isPublicShare)
            {
                return "copy_button.png";
            }
            return "disable_copy_button.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
