// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class UpdateInstanceRequest : TeaModel {
        [NameInMap("externalBizId")]
        [Validation(Required=false)]
        public string ExternalBizId { get; set; }

        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        [NameInMap("formDataList")]
        [Validation(Required=false)]
        public string FormDataList { get; set; }

        [NameInMap("openDataInstanceId")]
        [Validation(Required=false)]
        public string OpenDataInstanceId { get; set; }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("operatorUnionId")]
        [Validation(Required=false)]
        public string OperatorUnionId { get; set; }

        [NameInMap("ownerUnionId")]
        [Validation(Required=false)]
        public string OwnerUnionId { get; set; }

    }

}
