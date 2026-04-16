// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class FilterViewsCriteriaValue : TeaModel {
        [NameInMap("filterType")]
        [Validation(Required=false)]
        public string FilterType { get; set; }

        [NameInMap("visibleValues")]
        [Validation(Required=false)]
        public List<string> VisibleValues { get; set; }

        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<FilterViewsCriteriaValueConditions> Conditions { get; set; }
        public class FilterViewsCriteriaValueConditions : TeaModel {
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("conditionOperator")]
        [Validation(Required=false)]
        public string ConditionOperator { get; set; }

        [NameInMap("backgroundColor")]
        [Validation(Required=false)]
        public string BackgroundColor { get; set; }

        [NameInMap("fontColor")]
        [Validation(Required=false)]
        public string FontColor { get; set; }

    }

}
