// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class AddAppToWorkBenchGroupRequest : TeaModel {
        /// <summary>
        /// 工作台分组id
        /// </summary>
        [NameInMap("componentId")]
        [Validation(Required=false)]
        public string ComponentId { get; set; }

        /// <summary>
        /// 关联组织corpId
        /// </summary>
        [NameInMap("ecologicalCorpId")]
        [Validation(Required=false)]
        public string EcologicalCorpId { get; set; }

        /// <summary>
        /// 创建人unionId
        /// </summary>
        [NameInMap("opUnionId")]
        [Validation(Required=false)]
        public string OpUnionId { get; set; }

    }

}
