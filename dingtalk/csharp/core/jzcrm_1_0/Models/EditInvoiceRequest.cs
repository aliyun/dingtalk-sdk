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
            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;child_mx&quot;:[{&quot;产品ID&quot;:&quot;1&quot;,&quot;数量&quot;:&quot;10&quot;,&quot;单价&quot;:&quot;58.5&quot;,&quot;总价&quot;:&quot;585&quot;,&quot;明细备注&quot;:&quot;包含的测试产品&quot;}]</para>
            /// </summary>
            [NameInMap("child_mx")]
            [Validation(Required=false)]
            public string ChildMx { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            [NameInMap("fh_address")]
            [Validation(Required=false)]
            public string FhAddress { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fh_customerid")]
            [Validation(Required=false)]
            public string FhCustomerid { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fh_mode")]
            [Validation(Required=false)]
            public string FhMode { get; set; }

            [NameInMap("fh_msn")]
            [Validation(Required=false)]
            public string FhMsn { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>169</para>
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public long? Datatype { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("msgid")]
        [Validation(Required=false)]
        public long? Msgid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1621822122</para>
        /// </summary>
        [NameInMap("stamp")]
        [Validation(Required=false)]
        public long? Stamp { get; set; }

    }

}
