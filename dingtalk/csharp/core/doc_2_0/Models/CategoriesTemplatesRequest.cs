// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CategoriesTemplatesRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public CategoriesTemplatesRequestOption Option { get; set; }
        public class CategoriesTemplatesRequestOption : TeaModel {
            [NameInMap("categoryStatus")]
            [Validation(Required=false)]
            public int? CategoryStatus { get; set; }

            [NameInMap("queryPlatform")]
            [Validation(Required=false)]
            public string QueryPlatform { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("templateStatus")]
            [Validation(Required=false)]
            public int? TemplateStatus { get; set; }

        }

        [NameInMap("param")]
        [Validation(Required=false)]
        public CategoriesTemplatesRequestParam Param { get; set; }
        public class CategoriesTemplatesRequestParam : TeaModel {
            [NameInMap("categoryIds")]
            [Validation(Required=false)]
            public List<string> CategoryIds { get; set; }

        }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
