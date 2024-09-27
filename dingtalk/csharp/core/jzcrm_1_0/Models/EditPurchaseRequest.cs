// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditPurchaseRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditPurchaseRequestData Data { get; set; }
        public class EditPurchaseRequestData : TeaModel {
            [NameInMap("cg_fjmoney")]
            [Validation(Required=false)]
            public string CgFjmoney { get; set; }

            [NameInMap("cg_fjmoneylx")]
            [Validation(Required=false)]
            public string CgFjmoneylx { get; set; }

            [NameInMap("cg_kjmoney")]
            [Validation(Required=false)]
            public string CgKjmoney { get; set; }

            [NameInMap("cg_moneyzhekou")]
            [Validation(Required=false)]
            public string CgMoneyzhekou { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("cg_zxstate")]
            [Validation(Required=false)]
            public string CgZxstate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("cgdate")]
            [Validation(Required=false)]
            public string Cgdate { get; set; }

            [NameInMap("cgname")]
            [Validation(Required=false)]
            public string Cgname { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("cgno")]
            [Validation(Required=false)]
            public string Cgno { get; set; }

            [NameInMap("cgremark")]
            [Validation(Required=false)]
            public string Cgremark { get; set; }

            [NameInMap("cgtype")]
            [Validation(Required=false)]
            public string Cgtype { get; set; }

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

            [NameInMap("empid")]
            [Validation(Required=false)]
            public string Empid { get; set; }

            [NameInMap("gys_lxrid")]
            [Validation(Required=false)]
            public string GysLxrid { get; set; }

            [NameInMap("gys_lxrinfo")]
            [Validation(Required=false)]
            public string GysLxrinfo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("gysid")]
            [Validation(Required=false)]
            public string Gysid { get; set; }

            [NameInMap("gysjingban")]
            [Validation(Required=false)]
            public string Gysjingban { get; set; }

            [NameInMap("order_htid")]
            [Validation(Required=false)]
            public string OrderHtid { get; set; }

            [NameInMap("order_khid")]
            [Validation(Required=false)]
            public string OrderKhid { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("summoney")]
            [Validation(Required=false)]
            public string Summoney { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>153</para>
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
