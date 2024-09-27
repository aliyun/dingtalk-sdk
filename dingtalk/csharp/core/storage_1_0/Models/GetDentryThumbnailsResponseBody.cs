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
            /// <summary>
            /// <b>Example:</b>
            /// <para>dentry_id</para>
            /// </summary>
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>permissionDenied</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>space_id</para>
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("thumbnail")]
            [Validation(Required=false)]
            public GetDentryThumbnailsResponseBodyResultItemsThumbnail Thumbnail { get; set; }
            public class GetDentryThumbnailsResponseBodyResultItemsThumbnail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>url</para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

        }

    }

}
