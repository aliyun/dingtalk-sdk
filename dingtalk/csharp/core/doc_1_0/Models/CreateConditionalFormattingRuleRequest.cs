// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class CreateConditionalFormattingRuleRequest : TeaModel {
        /// <summary>
        /// 设定当前配置的规则的单元格样式
        /// </summary>
        [NameInMap("cellStyle")]
        [Validation(Required=false)]
        public CreateConditionalFormattingRuleRequestCellStyle CellStyle { get; set; }
        public class CreateConditionalFormattingRuleRequestCellStyle : TeaModel {
            /// <summary>
            /// 背景色，使用十六进制颜色表示法，如#ff0000
            /// </summary>
            [NameInMap("backgroundColor")]
            [Validation(Required=false)]
            public string BackgroundColor { get; set; }

        }

        /// <summary>
        /// 重复值规则
        /// </summary>
        [NameInMap("duplicateCondition")]
        [Validation(Required=false)]
        public CreateConditionalFormattingRuleRequestDuplicateCondition DuplicateCondition { get; set; }
        public class CreateConditionalFormattingRuleRequestDuplicateCondition : TeaModel {
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

        }

        /// <summary>
        /// 条件格式生效的区域。
        /// </summary>
        [NameInMap("ranges")]
        [Validation(Required=false)]
        public List<string> Ranges { get; set; }

        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
