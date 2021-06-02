// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditSalesRequest : TeaModel {
        /// <summary>
        /// 数据类型，固定填写158
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public long? Datatype { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [NameInMap("stamp")]
        [Validation(Required=false)]
        public long? Stamp { get; set; }

        /// <summary>
        /// 数据id，不填或者填0为新增数据
        /// </summary>
        [NameInMap("msgid")]
        [Validation(Required=false)]
        public long? Msgid { get; set; }

        /// <summary>
        /// 编辑数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditSalesRequestData Data { get; set; }
        public class EditSalesRequestData : TeaModel {
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }
            [NameInMap("xsh_customerid")]
            [Validation(Required=false)]
            public string XshCustomerid { get; set; }
            [NameInMap("xsh_title")]
            [Validation(Required=false)]
            public string XshTitle { get; set; }
            [NameInMap("xsh_date")]
            [Validation(Required=false)]
            public string XshDate { get; set; }
            [NameInMap("xsh_number")]
            [Validation(Required=false)]
            public string XshNumber { get; set; }
            [NameInMap("xsh_lxrid")]
            [Validation(Required=false)]
            public string XshLxrid { get; set; }
            [NameInMap("xsh_lianxi")]
            [Validation(Required=false)]
            public string XshLianxi { get; set; }
            [NameInMap("xsh_type")]
            [Validation(Required=false)]
            public string XshType { get; set; }
            [NameInMap("xsh_from")]
            [Validation(Required=false)]
            public string XshFrom { get; set; }
            [NameInMap("xsh_preside")]
            [Validation(Required=false)]
            public string XshPreside { get; set; }
            [NameInMap("xsh_provider")]
            [Validation(Required=false)]
            public string XshProvider { get; set; }
            [NameInMap("xsh_require")]
            [Validation(Required=false)]
            public string XshRequire { get; set; }
            [NameInMap("xsh_expdate")]
            [Validation(Required=false)]
            public string XshExpdate { get; set; }
            [NameInMap("xsh_expmoney")]
            [Validation(Required=false)]
            public string XshExpmoney { get; set; }
            [NameInMap("xsh_moneynote")]
            [Validation(Required=false)]
            public string XshMoneynote { get; set; }
            [NameInMap("xsh_phase")]
            [Validation(Required=false)]
            public string XshPhase { get; set; }
            [NameInMap("xsh_knx")]
            [Validation(Required=false)]
            public string XshKnx { get; set; }
            [NameInMap("xsh_state")]
            [Validation(Required=false)]
            public string XshState { get; set; }
            [NameInMap("xsh_phasenote")]
            [Validation(Required=false)]
            public string XshPhasenote { get; set; }
        };

    }

}
