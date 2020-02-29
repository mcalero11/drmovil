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
                     AdditionalComments = "",
                     Status = (int)Entities.Helpers.TaskStatus.InReview,
                     PublicShare = true,
                     StoreId = 1,
                     UserId = 1,
                     ServiceId = 1,
                     ModelId = 1,
                     CreatedAt = DateTime.Now,
                     
                },
                new Task {
                     Correlative = 002,
                     DeviceType = "Android",
                     Diagnostic = "Liberar AT&T",
                     AdditionalComments = "",
                     Status = (int)Entities.Helpers.TaskStatus.InProgress,
                     PublicShare = true,
                     StoreId = 1,
                     UserId = 1,
                     ServiceId = 2,
                     ModelId = 2,
                     CreatedAt = DateTime.Now,
                },
                new Task {
                     Correlative = 003,
                     DeviceType = "Iphone",
                     Diagnostic = "Activar T-Mobile. You can't put the resources into the ViewCell directly. " +
                     "But you don't need to stash them away somewhere else up the chain and try to reach them in " +
                     "a complicated way. Just put the resources into the actual visual view where you use them. In the " +
                     "XAML of the OP, the actual contents of the ViewCell are wrapped inside a Grid.",
                     AdditionalComments = "",
                     Status = (int)Entities.Helpers.TaskStatus.Rejected,
                     PublicShare = true,
                     StoreId = 2,
                     UserId = 1,
                     ServiceId = 4,
                     ModelId = 5,
                     CreatedAt = DateTime.Now,
                },

            };
        }
    }
}
