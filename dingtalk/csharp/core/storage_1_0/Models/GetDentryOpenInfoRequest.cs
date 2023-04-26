// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetDentryOpenInfoRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public GetDentryOpenInfoRequestOption Option { get; set; }
        public class GetDentryOpenInfoRequestOption : TeaModel {
            [NameInMap("checkLogin")]
            [Validation(Required=false)]
            public bool? CheckLogin { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

            [NameInMap("waterMark")]
            [Validation(Required=false)]
            public bool? WaterMark { get; set; }

        }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
