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
    [System.ComponentModel.DisplayName("Nhà cung cấp")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class NhaCungCap : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public NhaCungCap(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _MaNCC;
        [XafDisplayName("Mã NCC")]
        public string MaNCC
        {
            get { return _MaNCC; }
            set { SetPropertyValue<string>(nameof(MaNCC), ref _MaNCC, value); }
        }

        private string _TenNCC;
        [XafDisplayName("Tên Nhà cung cấp")]
        public string TenNCC
        {
            get { return _TenNCC; }
            set { SetPropertyValue<string>(nameof(TenNCC), ref _TenNCC, value); }
        }

        private string _DC;
        [XafDisplayName("Địa chỉ")]
        public string DC
        {
            get { return _DC; }
            set { SetPropertyValue<string>(nameof(DC), ref _DC, value); }
        }

        private string _SDT;
        [XafDisplayName("Số điện thoại")]
        public string SDT
        {
            get { return _SDT; }
            set { SetPropertyValue<string>(nameof(SDT), ref _SDT, value); }
        }

        [Association]
        public XPCollection<PhieuDatMua> MaNCC
        {
            get { return GetCollection<PhieuDatMua>(nameof(MaNCC)); }
        }

    }
}