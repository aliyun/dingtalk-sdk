// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class DeleteInnerAppRequest : TeaModel {
        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("opUnionId")]
        [Validation(Required=false)]
        public string OpUnionId { get; set; }

        /// <summary>
        /// 合作空间corpId
        /// </summary>
        [NameInMap("ecologicalCorpId")]
        [Validation(Required=false)]
        public string EcologicalCorpId { get; set; }

    }

}
