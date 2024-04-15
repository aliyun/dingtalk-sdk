// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class PreviewPublishedProcessRequest : TeaModel {
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        [NameInMap("formDataJson")]
        [Validation(Required=false)]
        public string FormDataJson { get; set; }

        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
