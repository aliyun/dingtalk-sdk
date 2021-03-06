// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class UpdateTodoTypeConfigRequest : TeaModel {
        /// <summary>
        /// 卡片类型（取值为：1-标准卡片，2-自定义卡片）
        /// </summary>
        [NameInMap("cardType")]
        [Validation(Required=false)]
        public int? CardType { get; set; }

        /// <summary>
        /// 卡片类型icon，用于在待办列表展示
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// 待办卡片类型描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 详情页链接在PC端的打开方式，取值为：「PC_SLIDE」-PC端侧边栏打开，「PC_BROWSER」-浏览器打开
        /// </summary>
        [NameInMap("pcDetailUrlOpenMode")]
        [Validation(Required=false)]
        public string PcDetailUrlOpenMode { get; set; }

        /// <summary>
        /// 待办卡片内容区表单自定义字段配置
        /// </summary>
        [NameInMap("contentFieldList")]
        [Validation(Required=false)]
        public List<UpdateTodoTypeConfigRequestContentFieldList> ContentFieldList { get; set; }
        public class UpdateTodoTypeConfigRequestContentFieldList : TeaModel {
            /// <summary>
            /// 字段唯一标识
            /// </summary>
            [NameInMap("fieldKey")]
            [Validation(Required=false)]
            public string FieldKey { get; set; }

            /// <summary>
            /// 字段类型（取值为：text-文本，url-链接）
            /// </summary>
            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            /// <summary>
            /// 字段显示名称(需支持国际化)
            /// </summary>
            [NameInMap("nameI18n")]
            [Validation(Required=false)]
            public Dictionary<string, object> NameI18n { get; set; }

        }

        /// <summary>
        /// 待办卡片操作区按钮配置
        /// </summary>
        [NameInMap("actionList")]
        [Validation(Required=false)]
        public List<UpdateTodoTypeConfigRequestActionList> ActionList { get; set; }
        public class UpdateTodoTypeConfigRequestActionList : TeaModel {
            /// <summary>
            /// 操作按钮的唯一标识
            /// </summary>
            [NameInMap("actionKey")]
            [Validation(Required=false)]
            public string ActionKey { get; set; }

            /// <summary>
            /// 按钮样式类型（101：蓝色线型主按钮样式，例如「同意」，102：黑色线型副按钮样式，例如「拒绝」）
            /// </summary>
            [NameInMap("buttonStyleType")]
            [Validation(Required=false)]
            public int? ButtonStyleType { get; set; }

            /// <summary>
            /// 按钮类型（1：有操作的，2：直接跳转）
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            /// <summary>
            /// 按钮类型为直接跳转时，对应的跳转url
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// 按钮操作的显示名称（需支持国际化）
            /// </summary>
            [NameInMap("nameI18n")]
            [Validation(Required=false)]
            public Dictionary<string, object> NameI18n { get; set; }

        }

        /// <summary>
        /// 当前操作者id，需传用户的unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
