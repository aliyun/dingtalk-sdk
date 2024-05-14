// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditCustomerRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditCustomerRequestData Data { get; set; }
        public class EditCustomerRequestData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            [NameInMap("kh_address")]
            [Validation(Required=false)]
            public string KhAddress { get; set; }

            [NameInMap("kh_appellation")]
            [Validation(Required=false)]
            public string KhAppellation { get; set; }

            [NameInMap("kh_befontof")]
            [Validation(Required=false)]
            public string KhBefontof { get; set; }

            [NameInMap("kh_billinfo")]
            [Validation(Required=false)]
            public string KhBillinfo { get; set; }

            [NameInMap("kh_city")]
            [Validation(Required=false)]
            public string KhCity { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("kh_class")]
            [Validation(Required=false)]
            public string KhClass { get; set; }

            [NameInMap("kh_coaddress")]
            [Validation(Required=false)]
            public string KhCoaddress { get; set; }

            [NameInMap("kh_contype")]
            [Validation(Required=false)]
            public string KhContype { get; set; }

            [NameInMap("kh_country")]
            [Validation(Required=false)]
            public string KhCountry { get; set; }

            [NameInMap("kh_creditgrade")]
            [Validation(Required=false)]
            public string KhCreditgrade { get; set; }

            [NameInMap("kh_ctnumber")]
            [Validation(Required=false)]
            public string KhCtnumber { get; set; }

            [NameInMap("kh_cttype")]
            [Validation(Required=false)]
            public string KhCttype { get; set; }

            [NameInMap("kh_department")]
            [Validation(Required=false)]
            public string KhDepartment { get; set; }

            [NameInMap("kh_dingtalk")]
            [Validation(Required=false)]
            public string KhDingtalk { get; set; }

            [NameInMap("kh_email")]
            [Validation(Required=false)]
            public string KhEmail { get; set; }

            [NameInMap("kh_employees")]
            [Validation(Required=false)]
            public string KhEmployees { get; set; }

            [NameInMap("kh_fax")]
            [Validation(Required=false)]
            public string KhFax { get; set; }

            [NameInMap("kh_from")]
            [Validation(Required=false)]
            public string KhFrom { get; set; }

            [NameInMap("kh_handset")]
            [Validation(Required=false)]
            public string KhHandset { get; set; }

            [NameInMap("kh_headship")]
            [Validation(Required=false)]
            public string KhHeadship { get; set; }

            [NameInMap("kh_hotfl")]
            [Validation(Required=false)]
            public string KhHotfl { get; set; }

            [NameInMap("kh_hotlevel")]
            [Validation(Required=false)]
            public string KhHotlevel { get; set; }

            [NameInMap("kh_hotmemo")]
            [Validation(Required=false)]
            public string KhHotmemo { get; set; }

            [NameInMap("kh_hottype")]
            [Validation(Required=false)]
            public string KhHottype { get; set; }

            [NameInMap("kh_industry")]
            [Validation(Required=false)]
            public string KhIndustry { get; set; }

            [NameInMap("kh_info")]
            [Validation(Required=false)]
            public string KhInfo { get; set; }

            [NameInMap("kh_jibie")]
            [Validation(Required=false)]
            public string KhJibie { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("kh_name")]
            [Validation(Required=false)]
            public string KhName { get; set; }

            [NameInMap("kh_pkhid")]
            [Validation(Required=false)]
            public string KhPkhid { get; set; }

            [NameInMap("kh_preside")]
            [Validation(Required=false)]
            public string KhPreside { get; set; }

            [NameInMap("kh_province")]
            [Validation(Required=false)]
            public string KhProvince { get; set; }

            [NameInMap("kh_pst")]
            [Validation(Required=false)]
            public string KhPst { get; set; }

            [NameInMap("kh_qq")]
            [Validation(Required=false)]
            public string KhQq { get; set; }

            [NameInMap("kh_ralagrade")]
            [Validation(Required=false)]
            public string KhRalagrade { get; set; }

            [NameInMap("kh_remark")]
            [Validation(Required=false)]
            public string KhRemark { get; set; }

            [NameInMap("kh_sex")]
            [Validation(Required=false)]
            public string KhSex { get; set; }

            [NameInMap("kh_shortname")]
            [Validation(Required=false)]
            public string KhShortname { get; set; }

            [NameInMap("kh_skype")]
            [Validation(Required=false)]
            public string KhSkype { get; set; }

            [NameInMap("kh_sn")]
            [Validation(Required=false)]
            public string KhSn { get; set; }

            [NameInMap("kh_status")]
            [Validation(Required=false)]
            public string KhStatus { get; set; }

            [NameInMap("kh_tel")]
            [Validation(Required=false)]
            public string KhTel { get; set; }

            [NameInMap("kh_type")]
            [Validation(Required=false)]
            public string KhType { get; set; }

            [NameInMap("kh_valrating")]
            [Validation(Required=false)]
            public string KhValrating { get; set; }

            [NameInMap("kh_wangwang")]
            [Validation(Required=false)]
            public string KhWangwang { get; set; }

            [NameInMap("kh_web")]
            [Validation(Required=false)]
            public string KhWeb { get; set; }

            [NameInMap("kh_weixin")]
            [Validation(Required=false)]
            public string KhWeixin { get; set; }

            [NameInMap("kh_worktel")]
            [Validation(Required=false)]
            public string KhWorktel { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public long? Datatype { get; set; }

        [NameInMap("msgid")]
        [Validation(Required=false)]
        public long? Msgid { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("stamp")]
        [Validation(Required=false)]
        public long? Stamp { get; set; }

    }

}
