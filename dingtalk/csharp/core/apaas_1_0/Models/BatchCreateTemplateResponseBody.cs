// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0.Models
{
    public class BatchCreateTemplateResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("createResultList")]
        [Validation(Required=false)]
        public List<BatchCreateTemplateResponseBodyCreateResultList> CreateResultList { get; set; }
        public class BatchCreateTemplateResponseBodyCreateResultList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("templateKey")]
            [Validation(Required=false)]
            public string TemplateKey { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
