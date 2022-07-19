// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetRecycleItemResponseBody : TeaModel {
        /// <summary>
        /// 回收项信息
        /// </summary>
        [NameInMap("item")]
        [Validation(Required=false)]
        public GetRecycleItemResponseBodyItem Item { get; set; }
        public class GetRecycleItemResponseBodyItem : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("operatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }
            [NameInMap("operatorTime")]
            [Validation(Required=false)]
            public string OperatorTime { get; set; }
            [NameInMap("originalName")]
            [Validation(Required=false)]
            public string OriginalName { get; set; }
            [NameInMap("originalPath")]
            [Validation(Required=false)]
            public string OriginalPath { get; set; }
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

    }

}
