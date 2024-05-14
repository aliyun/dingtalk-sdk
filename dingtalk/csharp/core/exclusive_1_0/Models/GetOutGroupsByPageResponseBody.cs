// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetOutGroupsByPageResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("responseBody")]
        [Validation(Required=false)]
        public GetOutGroupsByPageResponseBodyResponseBody ResponseBody { get; set; }
        public class GetOutGroupsByPageResponseBodyResponseBody : TeaModel {
            [NameInMap("groupList")]
            [Validation(Required=false)]
            public List<GetOutGroupsByPageResponseBodyResponseBodyGroupList> GroupList { get; set; }
            public class GetOutGroupsByPageResponseBodyResponseBodyGroupList : TeaModel {
                [NameInMap("openConversationId")]
                [Validation(Required=false)]
                public string OpenConversationId { get; set; }

            }

            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

    }

}
