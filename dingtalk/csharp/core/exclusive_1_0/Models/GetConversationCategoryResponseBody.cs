// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetConversationCategoryResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetConversationCategoryResponseBodyResult> Result { get; set; }
        public class GetConversationCategoryResponseBodyResult : TeaModel {
            [NameInMap("categoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            [NameInMap("categoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("children")]
            [Validation(Required=false)]
            public List<GetConversationCategoryResponseBodyResultChildren> Children { get; set; }
            public class GetConversationCategoryResponseBodyResultChildren : TeaModel {
                [NameInMap("categoryId")]
                [Validation(Required=false)]
                public long? CategoryId { get; set; }

                [NameInMap("categoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public int? LevelNum { get; set; }

                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

            }

            [NameInMap("levelNum")]
            [Validation(Required=false)]
            public int? LevelNum { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
