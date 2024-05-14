// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkactivity_1_0.Models
{
    public class CreateActivityRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public CreateActivityRequestDetail Detail { get; set; }
        public class CreateActivityRequestDetail : TeaModel {
            [NameInMap("address")]
            [Validation(Required=false)]
            public CreateActivityRequestDetailAddress Address { get; set; }
            public class CreateActivityRequestDetailAddress : TeaModel {
                [NameInMap("district")]
                [Validation(Required=false)]
                public string District { get; set; }

                [NameInMap("lat")]
                [Validation(Required=false)]
                public string Lat { get; set; }

                [NameInMap("lng")]
                [Validation(Required=false)]
                public string Lng { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("bannerMediaId")]
            [Validation(Required=false)]
            public string BannerMediaId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("foreignId")]
            [Validation(Required=false)]
            public string ForeignId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
