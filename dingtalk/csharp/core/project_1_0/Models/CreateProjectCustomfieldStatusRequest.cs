// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateProjectCustomfieldStatusRequest : TeaModel {
        [NameInMap("customFieldId")]
        [Validation(Required=false)]
        public string CustomFieldId { get; set; }

        [NameInMap("customFieldInstanceId")]
        [Validation(Required=false)]
        public string CustomFieldInstanceId { get; set; }

        [NameInMap("customFieldName")]
        [Validation(Required=false)]
        public string CustomFieldName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public List<CreateProjectCustomfieldStatusRequestValue> Value { get; set; }
        public class CreateProjectCustomfieldStatusRequestValue : TeaModel {
            [NameInMap("customFieldValueId")]
            [Validation(Required=false)]
            public string CustomFieldValueId { get; set; }

            [NameInMap("metaString")]
            [Validation(Required=false)]
            public string MetaString { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
