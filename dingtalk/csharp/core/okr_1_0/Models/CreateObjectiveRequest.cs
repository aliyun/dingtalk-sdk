// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class CreateObjectiveRequest : TeaModel {
        /// <summary>
        /// content
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public Stream Content { get; set; }

        /// <summary>
        /// periodId
        /// </summary>
        [NameInMap("periodId")]
        [Validation(Required=false)]
        public Stream PeriodId { get; set; }

        /// <summary>
        /// prevPosition
        /// </summary>
        [NameInMap("prevPosition")]
        [Validation(Required=false)]
        public Stream PrevPosition { get; set; }

        /// <summary>
        /// userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
