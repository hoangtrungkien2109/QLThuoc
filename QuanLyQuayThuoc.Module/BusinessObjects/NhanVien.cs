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
    [System.ComponentModel.DisplayName("Nhân viên")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class NhanVien : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public NhanVien(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _MaNV;
        [XafDisplayName("Mã NV")]
        public string MaNV
        {
            get { return _MaNV; }
            set { SetPropertyValue<string>(nameof(MaNV), ref _MaNV, value); }
        }

        private string _TenNV;
        [XafDisplayName("Tên Nhân viên")]
        public string TenNV
        {
            get { return _TenNV; }
            set { SetPropertyValue<string>(nameof(TenNV), ref _TenNV, value); }
        }

        private string _Diachi;
        [XafDisplayName("Địa chỉ")]
        public string Diachi
        {
            get { return _Diachi; }
            set { SetPropertyValue<string>(nameof(Diachi), ref _Diachi, value); }
        }

        private string _GT;
        [XafDisplayName("Giới tính")]
        public string GT
        {
            get { return _GT; }
            set { SetPropertyValue<string>(nameof(GT), ref _GT, value); }
        }

        private DateTime _NgaySinh;
        [XafDisplayName("Ngày sinh")]
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { SetPropertyValue<DateTime>(nameof(NgaySinh), ref _NgaySinh, value); }
        }

        private string _sdt;
        [XafDisplayName("Số điện thoại")]
        public string sdt
        {
            get { return _sdt; }
            set { SetPropertyValue<string>(nameof(sdt), ref _sdt, value); }
        }

    }
}
