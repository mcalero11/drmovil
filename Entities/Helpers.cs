using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public static class Helpers
    {
        public enum TaskStatus{
            InReview, // #1273eb
            Rejected, // #ec3a3b
            InProgress,// #1273eb
            Completed, // #49d295
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
