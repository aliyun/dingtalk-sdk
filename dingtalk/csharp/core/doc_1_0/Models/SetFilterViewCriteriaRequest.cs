// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class SetFilterViewCriteriaRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("column")]
        [Validation(Required=false)]
        public long? Column { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("filterCriteria")]
        [Validation(Required=false)]
        public SetFilterViewCriteriaRequestFilterCriteria FilterCriteria { get; set; }
        public class SetFilterViewCriteriaRequestFilterCriteria : TeaModel {
            [NameInMap("backgroundColor")]
            [Validation(Required=false)]
            public string BackgroundColor { get; set; }

            [NameInMap("conditionOperator")]
            [Validation(Required=false)]
            public string ConditionOperator { get; set; }

            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<SetFilterViewCriteriaRequestFilterCriteriaConditions> Conditions { get; set; }
            public class SetFilterViewCriteriaRequestFilterCriteriaConditions : TeaModel {
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("filterType")]
            [Validation(Required=false)]
            public string FilterType { get; set; }

            [NameInMap("fontColor")]
            [Validation(Required=false)]
            public string FontColor { get; set; }

            [NameInMap("visibleValues")]
            [Validation(Required=false)]
            public List<string> VisibleValues { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
