// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditExchangeRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditExchangeRequestData Data { get; set; }
        public class EditExchangeRequestData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;child_mx&quot;:[{&quot;产品ID&quot;:&quot;1&quot;,&quot;数量&quot;:&quot;10&quot;,&quot;明细备注&quot;:&quot;包含的测试产品&quot;,&quot;序列号-换入&quot;:&quot;• in1001• in1002...无则不传递&quot;,&quot;批次号-换入&quot;:&quot;• in2001 (10)• in2002 (20)...无则不传递&quot;,&quot;序列号-换出&quot;:&quot;• out1001• out1002...无则不传递&quot;,&quot;批次号-换出&quot;:&quot;• out2001 (10)• out2002 (20)...无则不传递&quot;}]</para>
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

            [NameInMap("hh_customerid")]
            [Validation(Required=false)]
            public string HhCustomerid { get; set; }

            [NameInMap("hh_date")]
            [Validation(Required=false)]
            public string HhDate { get; set; }

            [NameInMap("hh_inempid")]
            [Validation(Required=false)]
            public string HhInempid { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("hh_inlibid")]
            [Validation(Required=false)]
            public string HhInlibid { get; set; }

            [NameInMap("hh_intime")]
            [Validation(Required=false)]
            public string HhIntime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("hh_number")]
            [Validation(Required=false)]
            public string HhNumber { get; set; }

            [NameInMap("hh_orderid")]
            [Validation(Required=false)]
            public string HhOrderid { get; set; }

            [NameInMap("hh_outempid")]
            [Validation(Required=false)]
            public string HhOutempid { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("hh_outlibid")]
            [Validation(Required=false)]
            public string HhOutlibid { get; set; }

            [NameInMap("hh_outtime")]
            [Validation(Required=false)]
            public string HhOuttime { get; set; }

            [NameInMap("hh_remark")]
            [Validation(Required=false)]
            public string HhRemark { get; set; }

            [NameInMap("hh_state")]
            [Validation(Required=false)]
            public string HhState { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("hh_title")]
            [Validation(Required=false)]
            public string HhTitle { get; set; }

            [NameInMap("hh_type")]
            [Validation(Required=false)]
            public string HhType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>228</para>
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
