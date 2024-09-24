// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class GetFormDataByIDResponseBody : TeaModel {
        [NameInMap("formData")]
        [Validation(Required=false)]
        public Dictionary<string, object> FormData { get; set; }

        [NameInMap("formInstId")]
        [Validation(Required=false)]
        public string FormInstId { get; set; }

        [NameInMap("modifiedTimeGMT")]
        [Validation(Required=false)]
        public string ModifiedTimeGMT { get; set; }

        [NameInMap("originator")]
        [Validation(Required=false)]
        public GetFormDataByIDResponseBodyOriginator Originator { get; set; }
        public class GetFormDataByIDResponseBodyOriginator : TeaModel {
            [NameInMap("departmentName")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public GetFormDataByIDResponseBodyOriginatorName Name { get; set; }
            public class GetFormDataByIDResponseBodyOriginatorName : TeaModel {
                [NameInMap("nameInChinese")]
                [Validation(Required=false)]
                public string NameInChinese { get; set; }

                [NameInMap("nameInEnglish")]
                [Validation(Required=false)]
                public string NameInEnglish { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
