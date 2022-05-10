// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class QueryAcrossCloudStroageConfigsRequest : TeaModel {
        /// <summary>
        /// 云厂商类型
        /// </summary>
        [NameInMap("targetCloudType")]
        [Validation(Required=false)]
        public int? TargetCloudType { get; set; }

        /// <summary>
        /// 企业的corpId
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

    }

}
