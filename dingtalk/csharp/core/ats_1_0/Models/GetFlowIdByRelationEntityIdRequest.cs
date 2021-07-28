// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class GetFlowIdByRelationEntityIdRequest : TeaModel {
        /// <summary>
        /// 业务标识
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 招聘流程关联实体
        /// </summary>
        [NameInMap("relationEntity")]
        [Validation(Required=false)]
        public string RelationEntity { get; set; }

        /// <summary>
        /// 招聘流程关联实体标识
        /// </summary>
        [NameInMap("relationEntityId")]
        [Validation(Required=false)]
        public string RelationEntityId { get; set; }

    }

}
