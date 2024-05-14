// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetDentryRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public GetDentryRequestOption Option { get; set; }
        public class GetDentryRequestOption : TeaModel {
            [NameInMap("appIdsForAppProperties")]
            [Validation(Required=false)]
            public List<string> AppIdsForAppProperties { get; set; }

            [NameInMap("withThumbnail")]
            [Validation(Required=false)]
            public bool? WithThumbnail { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
