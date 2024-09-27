// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class CreateRuleRequest : TeaModel {
        [NameInMap("customPlan")]
        [Validation(Required=false)]
        public CreateRuleRequestCustomPlan CustomPlan { get; set; }
        public class CreateRuleRequestCustomPlan : TeaModel {
            [NameInMap("currentCategoryList")]
            [Validation(Required=false)]
            public List<string> CurrentCategoryList { get; set; }

            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("planName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            [NameInMap("unSelectCategoryList")]
            [Validation(Required=false)]
            public List<string> UnSelectCategoryList { get; set; }

            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
