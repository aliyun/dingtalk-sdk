// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditInvoiceRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditInvoiceRequestData Data { get; set; }
        public class EditInvoiceRequestData : TeaModel {
            [NameInMap("child_mx")]
            [Validation(Required=false)]
            public string ChildMx { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            [NameInMap("fh_address")]
            [Validation(Required=false)]
            public string FhAddress { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fh_customerid")]
            [Validation(Required=false)]
            public string FhCustomerid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fh_date")]
            [Validation(Required=false)]
            public string FhDate { get; set; }

            [NameInMap("fh_email")]
            [Validation(Required=false)]
            public string FhEmail { get; set; }

            [NameInMap("fh_handset")]
            [Validation(Required=false)]
            public string FhHandset { get; set; }

            [NameInMap("fh_htorder")]
            [Validation(Required=false)]
            public string FhHtorder { get; set; }

            [NameInMap("fh_jianshu")]
            [Validation(Required=false)]
            public string FhJianshu { get; set; }

            [NameInMap("fh_kg")]
            [Validation(Required=false)]
            public string FhKg { get; set; }

            [NameInMap("fh_linkman")]
            [Validation(Required=false)]
            public string FhLinkman { get; set; }

            [NameInMap("fh_lxrid")]
            [Validation(Required=false)]
            public string FhLxrid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fh_mode")]
            [Validation(Required=false)]
            public string FhMode { get; set; }

            [NameInMap("fh_msn")]
            [Validation(Required=false)]
            public string FhMsn { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fh_number")]
            [Validation(Required=false)]
            public string FhNumber { get; set; }

            [NameInMap("fh_post")]
            [Validation(Required=false)]
            public string FhPost { get; set; }

            [NameInMap("fh_preside")]
            [Validation(Required=false)]
            public string FhPreside { get; set; }

            [NameInMap("fh_remark")]
            [Validation(Required=false)]
            public string FhRemark { get; set; }

            [NameInMap("fh_shipper")]
            [Validation(Required=false)]
            public string FhShipper { get; set; }

            [NameInMap("fh_state")]
            [Validation(Required=false)]
            public string FhState { get; set; }

            [NameInMap("fh_tel")]
            [Validation(Required=false)]
            public string FhTel { get; set; }

            [NameInMap("fh_title")]
            [Validation(Required=false)]
            public string FhTitle { get; set; }

            [NameInMap("fh_yunfei")]
            [Validation(Required=false)]
            public string FhYunfei { get; set; }

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
