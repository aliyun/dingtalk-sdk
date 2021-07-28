// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class GetCandidateByPhoneNumberResponseBody : TeaModel {
        /// <summary>
        /// 候选人标识
        /// </summary>
        [NameInMap("candidateId")]
        [Validation(Required=false)]
        public string CandidateId { get; set; }

        /// <summary>
        /// 候选人姓名
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
