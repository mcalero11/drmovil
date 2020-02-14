using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Data.MockService
{
    public class TaskMock : IMockServices<Task>
    {
        public List<Task> GetList()
        {
            return new List<Task> {
                new Task {
                     Correlative = 001,
                     DeviceType = "Android",
                     Diagnostic = "Teléfono mojado",
                     Status = (int)Entities.Helpers.TaskStatus.InReview,
                     PublicShare = true,
                     StoreId = 1,
                     UserId = 1,
                     ServiceId = 1,
                },
                new Task {
                     Correlative = 002,
                     DeviceType = "Android",
                     Diagnostic = "Liberar AT&T",
                     Status = (int)Entities.Helpers.TaskStatus.InProgress,
                     PublicShare = true,
                     StoreId = 1,
                     UserId = 1,
                     ServiceId = 2,
                },
                new Task {
                     Correlative = 003,
                     DeviceType = "Iphone",
                     Diagnostic = "Activar T-Mobile",
                     Status = (int)Entities.Helpers.TaskStatus.Rejected,
                     PublicShare = true,
                     StoreId = 1,
                     UserId = 1,
                     ServiceId = 4,
                },

            };
        }
    }
}
