// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class ListAllBizCategoryResponseBody : TeaModel {
        [NameInMap("bizCategories")]
        [Validation(Required=false)]
        public List<ListAllBizCategoryResponseBodyBizCategories> BizCategories { get; set; }
        public class ListAllBizCategoryResponseBodyBizCategories : TeaModel {
            [NameInMap("bizCategoryId")]
            [Validation(Required=false)]
            public string BizCategoryId { get; set; }

            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
