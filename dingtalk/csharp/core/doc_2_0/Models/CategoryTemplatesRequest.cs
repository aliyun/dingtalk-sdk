// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CategoryTemplatesRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public CategoryTemplatesRequestOption Option { get; set; }
        public class CategoryTemplatesRequestOption : TeaModel {
            [NameInMap("categoryStatus")]
            [Validation(Required=false)]
            public int? CategoryStatus { get; set; }

            [NameInMap("templateStatus")]
            [Validation(Required=false)]
            public int? TemplateStatus { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("param")]
        [Validation(Required=false)]
        public CategoryTemplatesRequestParam Param { get; set; }
        public class CategoryTemplatesRequestParam : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("categoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
