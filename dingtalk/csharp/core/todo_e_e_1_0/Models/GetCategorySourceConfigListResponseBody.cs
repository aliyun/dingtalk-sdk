// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_e_e_1_0.Models
{
    public class GetCategorySourceConfigListResponseBody : TeaModel {
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<GetCategorySourceConfigListResponseBodyConfigs> Configs { get; set; }
        public class GetCategorySourceConfigListResponseBodyConfigs : TeaModel {
            [NameInMap("bizCategoryId")]
            [Validation(Required=false)]
            public string BizCategoryId { get; set; }

            [NameInMap("bizCategoryName")]
            [Validation(Required=false)]
            public string BizCategoryName { get; set; }

            [NameInMap("configId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
