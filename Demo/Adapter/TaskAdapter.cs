using Android.Content.Res;
using Android.Support.V7.Widget;
using Android.Views;
using System;
namespace Demo.Adapter
{
    public class TaskAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;
        public TaskDetails mTaskDetails;
        public TaskAdapter(TaskDetails taskDetails)
        {
            mTaskDetails = taskDetails;
        }
        public override int ItemCount
        {
            get { return mTaskDetails.taskCount; }
        }
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            TaskViewHolder vh = holder as TaskViewHolder;
            vh.textViewWeekNumber.Text = mTaskDetails[position].mWeekNumber;
            vh.textViewCodingType.Text = mTaskDetails[position].mCodingType;
            vh.textViewStoreAddress.Text = mTaskDetails[position].mStoreAddress;
            vh.textViewStoreName.Text = mTaskDetails[position].mStoreName;
            vh.textViewWeekDate.Text = mTaskDetails[position].mWeekDate;
            vh.buttonStartAudit.Visibility = mTaskDetails[position].mTaskstate.Equals("Not Started") ?ViewStates.Visible: ViewStates.Gone;
        }
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.taskcard, parent, false);
            TaskViewHolder vh = new TaskViewHolder(itemView, OnClick);
            return vh;
        }
        private void OnClick(int obj)
        {
            if (ItemClick != null)
                ItemClick(this, obj);
        }
    }
}