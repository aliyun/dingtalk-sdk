// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditOrderRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditOrderRequestData Data { get; set; }
        public class EditOrderRequestData : TeaModel {
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

            [NameInMap("fahuoaddressid")]
            [Validation(Required=false)]
            public string Fahuoaddressid { get; set; }

            [NameInMap("ht_begindate")]
            [Validation(Required=false)]
            public string HtBegindate { get; set; }

            [NameInMap("ht_contract")]
            [Validation(Required=false)]
            public string HtContract { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ht_customerid")]
            [Validation(Required=false)]
            public string HtCustomerid { get; set; }

            [NameInMap("ht_cusub")]
            [Validation(Required=false)]
            public string HtCusub { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ht_date")]
            [Validation(Required=false)]
            public string HtDate { get; set; }

            [NameInMap("ht_deliplace")]
            [Validation(Required=false)]
            public string HtDeliplace { get; set; }

            [NameInMap("ht_enddate")]
            [Validation(Required=false)]
            public string HtEnddate { get; set; }

            [NameInMap("ht_fjmoney")]
            [Validation(Required=false)]
            public string HtFjmoney { get; set; }

            [NameInMap("ht_fjmoneylx")]
            [Validation(Required=false)]
            public string HtFjmoneylx { get; set; }

            [NameInMap("ht_kjmoney")]
            [Validation(Required=false)]
            public string HtKjmoney { get; set; }

            [NameInMap("ht_lxrid")]
            [Validation(Required=false)]
            public string HtLxrid { get; set; }

            [NameInMap("ht_lxrinfo")]
            [Validation(Required=false)]
            public string HtLxrinfo { get; set; }

            [NameInMap("ht_moneyzhekou")]
            [Validation(Required=false)]
            public string HtMoneyzhekou { get; set; }

            [NameInMap("ht_number")]
            [Validation(Required=false)]
            public string HtNumber { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ht_order")]
            [Validation(Required=false)]
            public string HtOrder { get; set; }

            [NameInMap("ht_paymode")]
            [Validation(Required=false)]
            public string HtPaymode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ht_preside")]
            [Validation(Required=false)]
            public string HtPreside { get; set; }

            [NameInMap("ht_remark")]
            [Validation(Required=false)]
            public string HtRemark { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ht_state")]
            [Validation(Required=false)]
            public string HtState { get; set; }

            [NameInMap("ht_summemo")]
            [Validation(Required=false)]
            public string HtSummemo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ht_summoney")]
            [Validation(Required=false)]
            public string HtSummoney { get; set; }

            [NameInMap("ht_title")]
            [Validation(Required=false)]
            public string HtTitle { get; set; }

            [NameInMap("ht_type")]
            [Validation(Required=false)]
            public string HtType { get; set; }

            [NameInMap("ht_wesub")]
            [Validation(Required=false)]
            public string HtWesub { get; set; }

            [NameInMap("ht_wuliutype")]
            [Validation(Required=false)]
            public string HtWuliutype { get; set; }

            [NameInMap("ht_xshid")]
            [Validation(Required=false)]
            public string HtXshid { get; set; }

            [NameInMap("ht_yunfeimoney")]
            [Validation(Required=false)]
            public string HtYunfeimoney { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
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
