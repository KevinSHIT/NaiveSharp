using NaiveSharp.Model;

namespace NaiveSharp.ConstText
{
    public static class Msg
    {
        public const string RUNNING_UNDER_BGD = "Hi there! Naive# is still running under background!";
        
        public const string ASK_CHANGES_NEED_APP_RESTART = 
            "Reopening Naive# is required to apply changes.\n" +
            "Do you want to reopen Naive# immediately?";

        public const string CHOOSE_NULL_ITEM = "Please choose a valid item through left list control!";

        public const string RUN_SUCCESS = "NaiveProxy runs successfully!";

        public const string STOP_SUCCESS = "NaiveProxy stopped successfully!";
        
        public const string NODE_SAVE_SUCCESS = "Node information saved.";

        public const string ASK_GROUP_DELETE_CONFIRM =
            "The nodes which belongs to the group you selected will all be deleted. Continue?";

        public const string NODE_SELECTED_NOT_VALID = "Please select a valid node!";

        public const string NAIVEPROXY_IS_RUNNING = "NaiveProxy is running.";
        
        public static class Title
        {
            public const string INFO = "Info";
            public const string WARNING = "Warning";
            public const string ERROR = "Error";
            public const string TIP = "Naive# Tip";
        }
        
    }
}
