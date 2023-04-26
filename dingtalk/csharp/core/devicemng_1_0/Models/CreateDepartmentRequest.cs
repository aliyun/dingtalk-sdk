// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class CreateDepartmentRequest : TeaModel {
        [NameInMap("authInfo")]
        [Validation(Required=false)]
        public string AuthInfo { get; set; }

        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("bizExt")]
        [Validation(Required=false)]
        public string BizExt { get; set; }

        [NameInMap("departmentName")]
        [Validation(Required=false)]
        public string DepartmentName { get; set; }

        [NameInMap("departmentType")]
        [Validation(Required=false)]
        public string DepartmentType { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("systemUrl")]
        [Validation(Required=false)]
        public string SystemUrl { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
