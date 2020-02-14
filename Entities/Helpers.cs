using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public static class Helpers
    {
        public enum TaskStatus{
            InReview,
            Rejected,
            InProgress,
            Completed,
        };

        public enum Roles
        {
            Admin,
            Seller,
            Technician,
        };
        public enum ActionSyncEnum
        {
            Create,
            Update,
            Delete
        }

        public enum ApiVersion
        {
            V1 = 1,
        }
    }
}
