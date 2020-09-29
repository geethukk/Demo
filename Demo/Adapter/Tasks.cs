using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;
namespace Demo.Adapter
{
    public class Tasks
    {
        public string mWeekNumber { get; set; }
        public string mWeekDate { get; set; }
        public string mStoreName { get; set; }
        public string mStoreAddress { get; set; }
        public string mCodingType { get; set; }
        public string mTaskstate { get; set; }

    }
    public class TaskDetails
    {
        static Tasks[] listTasks =
        {
            new Tasks() {mWeekNumber = "wk35", mWeekDate = "08-09",mStoreName="34492783/NEW RANDOLPH STORE 0045",mStoreAddress="630 3RD ST WEST, RANDOLPH AFB, TX, 78150",mCodingType="Item Coding",mTaskstate="Not Started"},
            new Tasks() {mWeekNumber = "wk35", mWeekDate = "08-09",mStoreName="24492783/NEW RANDOLPH STORE 0045",mStoreAddress="530 3RD ST WEST, RANDOLPH AFB, TX, 78150",mCodingType="Item Coding",mTaskstate="Not Started"},
            new Tasks() {mWeekNumber = "wk36", mWeekDate = "08-09",mStoreName="14492783/NEW RANDOLPH STORE 0045",mStoreAddress="430 3RD ST WEST, RANDOLPH AFB, TX, 78150",mCodingType="Item Coding",mTaskstate="In Progress"},
            new Tasks() {mWeekNumber = "wk35", mWeekDate = "08-09",mStoreName="34492783/NEW RANDOLPH STORE 0045",mStoreAddress="630 3RD ST WEST, RANDOLPH AFB, TX, 78150",mCodingType="Item Coding",mTaskstate="Not Started"},
            new Tasks() {mWeekNumber = "wk35", mWeekDate = "08-09",mStoreName="34492783/NEW RANDOLPH STORE 0045",mStoreAddress="630 3RD ST WEST, RANDOLPH AFB, TX, 78150",mCodingType="Item Coding",mTaskstate="Not Started"},
            new Tasks() {mWeekNumber = "wk35", mWeekDate = "08-09",mStoreName="34492783/NEW RANDOLPH STORE 0045",mStoreAddress="630 3RD ST WEST, RANDOLPH AFB, TX, 78150",mCodingType="Item Coding",mTaskstate="Not Started"}
           
        };
        private Tasks[] tasks;
        Random random;
        public TaskDetails()
        {
            this.tasks = listTasks;
            random = new Random();
        }
        public int taskCount
        {
            get
            {
                return tasks.Length;
            }
        }
        public Tasks this[int i]
        {
            get { return tasks[i]; }
        }
    }
    public class TaskViewHolder : RecyclerView.ViewHolder
    {
        public TextView textViewWeekNumber { get; set; }
        public TextView textViewWeekDate { get; set; }
        public TextView textViewStoreName { get; set; }

        public TextView textViewStoreAddress { get; set; }

        public TextView textViewCodingType { get; set; }
        public Button buttonStartAudit { get; set; }

        public TaskViewHolder(View itemview, Action<int> listener) : base(itemview)
        {
            textViewWeekNumber = itemview.FindViewById<TextView>(Resource.Id.textViewWeekNumber);
            textViewWeekDate = itemview.FindViewById<TextView>(Resource.Id.textViewWeekDate);
            textViewStoreName = itemview.FindViewById<TextView>(Resource.Id.textViewStoreName);
            textViewStoreAddress = itemview.FindViewById<TextView>(Resource.Id.textViewStoreAddress);
            textViewCodingType = itemview.FindViewById<TextView>(Resource.Id.textViewCodingType);
            buttonStartAudit = itemview.FindViewById<Button>(Resource.Id.buttonStartAudit);

            // itemview.Click += (sender, e) => listener(Position);
        }
    }
}