// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetDentryThumbnailsResponseBody : TeaModel {
        [NameInMap("resultItems")]
        [Validation(Required=false)]
        public List<GetDentryThumbnailsResponseBodyResultItems> ResultItems { get; set; }
        public class GetDentryThumbnailsResponseBodyResultItems : TeaModel {
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("thumbnail")]
            [Validation(Required=false)]
            public GetDentryThumbnailsResponseBodyResultItemsThumbnail Thumbnail { get; set; }
            public class GetDentryThumbnailsResponseBodyResultItemsThumbnail : TeaModel {
                [NameInMap("height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

        }

    }

}
