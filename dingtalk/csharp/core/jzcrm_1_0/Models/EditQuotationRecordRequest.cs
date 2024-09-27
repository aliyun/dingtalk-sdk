// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditQuotationRecordRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditQuotationRecordRequestData Data { get; set; }
        public class EditQuotationRecordRequestData : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("bj_bjren")]
            [Validation(Required=false)]
            public string BjBjren { get; set; }

            [NameInMap("bj_bzremark")]
            [Validation(Required=false)]
            public string BjBzremark { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("bj_customerid")]
            [Validation(Required=false)]
            public string BjCustomerid { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("bj_date")]
            [Validation(Required=false)]
            public string BjDate { get; set; }

            [NameInMap("bj_fjmoney")]
            [Validation(Required=false)]
            public string BjFjmoney { get; set; }

            [NameInMap("bj_fjmoneylx")]
            [Validation(Required=false)]
            public string BjFjmoneylx { get; set; }

            [NameInMap("bj_fkremark")]
            [Validation(Required=false)]
            public string BjFkremark { get; set; }

            [NameInMap("bj_jfremark")]
            [Validation(Required=false)]
            public string BjJfremark { get; set; }

            [NameInMap("bj_jshren")]
            [Validation(Required=false)]
            public string BjJshren { get; set; }

            [NameInMap("bj_kjmoney")]
            [Validation(Required=false)]
            public string BjKjmoney { get; set; }

            [NameInMap("bj_lianxi")]
            [Validation(Required=false)]
            public string BjLianxi { get; set; }

            [NameInMap("bj_moneyzhekou")]
            [Validation(Required=false)]
            public string BjMoneyzhekou { get; set; }

            [NameInMap("bj_number")]
            [Validation(Required=false)]
            public string BjNumber { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("bj_price")]
            [Validation(Required=false)]
            public string BjPrice { get; set; }

            [NameInMap("bj_remark")]
            [Validation(Required=false)]
            public string BjRemark { get; set; }

            [NameInMap("bj_state")]
            [Validation(Required=false)]
            public string BjState { get; set; }

            [NameInMap("bj_title")]
            [Validation(Required=false)]
            public string BjTitle { get; set; }

            [NameInMap("bj_xshid")]
            [Validation(Required=false)]
            public string BjXshid { get; set; }

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

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>161</para>
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
