// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkactivity_1_0.Models
{
    public class ListActivityResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListActivityResponseBodyList> List { get; set; }
        public class ListActivityResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5tL2HIQiQiOARCZ6xWAPHA02091683513</para>
            /// </summary>
            [NameInMap("activityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>@mediaId</para>
            /// </summary>
            [NameInMap("bannerMediaId")]
            [Validation(Required=false)]
            public string BannerMediaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1683515695000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20230613_001</para>
            /// </summary>
            [NameInMap("foreignId")]
            [Validation(Required=false)]
            public string ForeignId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1683514695000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AIGC研讨会</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1686633306552</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
