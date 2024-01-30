using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace QuanLyQuayThuoc.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class PhieuDatMua : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public PhieuDatMua(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _MaPhieu;
        [XafDisplayName("Mã phiếu mua")]
        public string MaPhieu
        {
            get { return _MaPhieu; }
            set { SetPropertyValue<string>(nameof(MaPhieu), ref _MaPhieu, value); }
        }

        private DateTime _NgayDatMua;
        [XafDisplayName("Ngày đặt mua")]
        public DateTime NgayDatMua
        {
            get { return _NgayDatMua; }
            set { SetPropertyValue<DateTime>(nameof(NgayDatMua), ref _NgayDatMua, value); }
        }

        private NhaCungCap _MaNCC;
        [Association]
        public NhaCungCap MaNCC
        {
            get { return _MaNCC; }
            set { SetPropertyValue<NhaCungCap>(nameof(MaNCC), ref _MaNCC, value); }
        }


    }
}