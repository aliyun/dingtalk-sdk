// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditSalesRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditSalesRequestData Data { get; set; }
        public class EditSalesRequestData : TeaModel {
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

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("xsh_customerid")]
            [Validation(Required=false)]
            public string XshCustomerid { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("xsh_date")]
            [Validation(Required=false)]
            public string XshDate { get; set; }

            [NameInMap("xsh_expdate")]
            [Validation(Required=false)]
            public string XshExpdate { get; set; }

            [NameInMap("xsh_expmoney")]
            [Validation(Required=false)]
            public string XshExpmoney { get; set; }

            [NameInMap("xsh_from")]
            [Validation(Required=false)]
            public string XshFrom { get; set; }

            [NameInMap("xsh_knx")]
            [Validation(Required=false)]
            public string XshKnx { get; set; }

            [NameInMap("xsh_lianxi")]
            [Validation(Required=false)]
            public string XshLianxi { get; set; }

            [NameInMap("xsh_lxrid")]
            [Validation(Required=false)]
            public string XshLxrid { get; set; }

            [NameInMap("xsh_moneynote")]
            [Validation(Required=false)]
            public string XshMoneynote { get; set; }

            [NameInMap("xsh_number")]
            [Validation(Required=false)]
            public string XshNumber { get; set; }

            [NameInMap("xsh_phase")]
            [Validation(Required=false)]
            public string XshPhase { get; set; }

            [NameInMap("xsh_phasenote")]
            [Validation(Required=false)]
            public string XshPhasenote { get; set; }

            [NameInMap("xsh_preside")]
            [Validation(Required=false)]
            public string XshPreside { get; set; }

            [NameInMap("xsh_provider")]
            [Validation(Required=false)]
            public string XshProvider { get; set; }

            [NameInMap("xsh_require")]
            [Validation(Required=false)]
            public string XshRequire { get; set; }

            [NameInMap("xsh_state")]
            [Validation(Required=false)]
            public string XshState { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("xsh_title")]
            [Validation(Required=false)]
            public string XshTitle { get; set; }

            [NameInMap("xsh_type")]
            [Validation(Required=false)]
            public string XshType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>158</para>
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
