// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditSalesRequest : TeaModel {
        /// <summary>
        /// 编辑数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditSalesRequestData Data { get; set; }
        public class EditSalesRequestData : TeaModel {
            /// <summary>
            /// 创建人
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            /// <summary>
            /// 对应客户
            /// </summary>
            [NameInMap("xsh_customerid")]
            [Validation(Required=false)]
            public string XshCustomerid { get; set; }

            /// <summary>
            /// 发现时间
            /// </summary>
            [NameInMap("xsh_date")]
            [Validation(Required=false)]
            public string XshDate { get; set; }

            /// <summary>
            /// 预计签单日
            /// </summary>
            [NameInMap("xsh_expdate")]
            [Validation(Required=false)]
            public string XshExpdate { get; set; }

            /// <summary>
            /// 预期金额
            /// </summary>
            [NameInMap("xsh_expmoney")]
            [Validation(Required=false)]
            public string XshExpmoney { get; set; }

            /// <summary>
            /// 来源
            /// </summary>
            [NameInMap("xsh_from")]
            [Validation(Required=false)]
            public string XshFrom { get; set; }

            /// <summary>
            /// 可能性
            /// </summary>
            [NameInMap("xsh_knx")]
            [Validation(Required=false)]
            public string XshKnx { get; set; }

            /// <summary>
            /// 联系方式
            /// </summary>
            [NameInMap("xsh_lianxi")]
            [Validation(Required=false)]
            public string XshLianxi { get; set; }

            /// <summary>
            /// 联系人
            /// </summary>
            [NameInMap("xsh_lxrid")]
            [Validation(Required=false)]
            public string XshLxrid { get; set; }

            /// <summary>
            /// 外币备注
            /// </summary>
            [NameInMap("xsh_moneynote")]
            [Validation(Required=false)]
            public string XshMoneynote { get; set; }

            /// <summary>
            /// 机会编号
            /// </summary>
            [NameInMap("xsh_number")]
            [Validation(Required=false)]
            public string XshNumber { get; set; }

            /// <summary>
            /// 阶段
            /// </summary>
            [NameInMap("xsh_phase")]
            [Validation(Required=false)]
            public string XshPhase { get; set; }

            /// <summary>
            /// 阶段备注
            /// </summary>
            [NameInMap("xsh_phasenote")]
            [Validation(Required=false)]
            public string XshPhasenote { get; set; }

            /// <summary>
            /// 所有者
            /// </summary>
            [NameInMap("xsh_preside")]
            [Validation(Required=false)]
            public string XshPreside { get; set; }

            /// <summary>
            /// 提供人
            /// </summary>
            [NameInMap("xsh_provider")]
            [Validation(Required=false)]
            public string XshProvider { get; set; }

            /// <summary>
            /// 客户需求
            /// </summary>
            [NameInMap("xsh_require")]
            [Validation(Required=false)]
            public string XshRequire { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("xsh_state")]
            [Validation(Required=false)]
            public string XshState { get; set; }

            /// <summary>
            /// 主题
            /// </summary>
            [NameInMap("xsh_title")]
            [Validation(Required=false)]
            public string XshTitle { get; set; }

            /// <summary>
            /// 类型
            /// </summary>
            [NameInMap("xsh_type")]
            [Validation(Required=false)]
            public string XshType { get; set; }

        }

        /// <summary>
        /// 数据类型，固定填写158
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public long? Datatype { get; set; }

        /// <summary>
        /// 数据id，不填或者填0为新增数据
        /// </summary>
        [NameInMap("msgid")]
        [Validation(Required=false)]
        public long? Msgid { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [NameInMap("stamp")]
        [Validation(Required=false)]
        public long? Stamp { get; set; }

    }

}
