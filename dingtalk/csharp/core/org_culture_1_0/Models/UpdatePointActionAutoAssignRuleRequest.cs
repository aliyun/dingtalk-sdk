// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class UpdatePointActionAutoAssignRuleRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("updatePointRuleRequestDTOList")]
        [Validation(Required=false)]
        public List<UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList> UpdatePointRuleRequestDTOList { get; set; }
        public class UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("awardScore")]
            [Validation(Required=false)]
            public long? AwardScore { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dayLimitTimes")]
            [Validation(Required=false)]
            public long? DayLimitTimes { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
