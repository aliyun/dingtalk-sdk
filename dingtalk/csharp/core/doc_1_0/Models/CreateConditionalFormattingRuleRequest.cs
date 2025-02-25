// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class CreateConditionalFormattingRuleRequest : TeaModel {
        [NameInMap("cellStyle")]
        [Validation(Required=false)]
        public CreateConditionalFormattingRuleRequestCellStyle CellStyle { get; set; }
        public class CreateConditionalFormattingRuleRequestCellStyle : TeaModel {
            [NameInMap("backgroundColor")]
            [Validation(Required=false)]
            public string BackgroundColor { get; set; }

        }

        [NameInMap("duplicateCondition")]
        [Validation(Required=false)]
        public CreateConditionalFormattingRuleRequestDuplicateCondition DuplicateCondition { get; set; }
        public class CreateConditionalFormattingRuleRequestDuplicateCondition : TeaModel {
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

        }

        [NameInMap("numberCondition")]
        [Validation(Required=false)]
        public CreateConditionalFormattingRuleRequestNumberCondition NumberCondition { get; set; }
        public class CreateConditionalFormattingRuleRequestNumberCondition : TeaModel {
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("value1")]
            [Validation(Required=false)]
            public object Value1 { get; set; }

            [NameInMap("value2")]
            [Validation(Required=false)]
            public object Value2 { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ranges")]
        [Validation(Required=false)]
        public List<string> Ranges { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ppgAQuHfOoNVpJiStDwWCEgiEiE</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
