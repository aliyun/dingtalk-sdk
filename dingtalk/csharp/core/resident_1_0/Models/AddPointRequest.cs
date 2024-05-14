// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class AddPointRequest : TeaModel {
        [NameInMap("actionTime")]
        [Validation(Required=false)]
        public long? ActionTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("isCircle")]
        [Validation(Required=false)]
        public bool? IsCircle { get; set; }

        [NameInMap("ruleCode")]
        [Validation(Required=false)]
        public string RuleCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("score")]
        [Validation(Required=false)]
        public int? Score { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
