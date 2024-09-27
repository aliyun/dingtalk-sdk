// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkactivity_1_0.Models
{
    public class CreateActivityRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public CreateActivityRequestDetail Detail { get; set; }
        public class CreateActivityRequestDetail : TeaModel {
            [NameInMap("address")]
            [Validation(Required=false)]
            public CreateActivityRequestDetailAddress Address { get; set; }
            public class CreateActivityRequestDetailAddress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>重庆市重庆市</para>
                /// </summary>
                [NameInMap("district")]
                [Validation(Required=false)]
                public string District { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>29.533939</para>
                /// </summary>
                [NameInMap("lat")]
                [Validation(Required=false)]
                public string Lat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>106.561853</para>
                /// </summary>
                [NameInMap("lng")]
                [Validation(Required=false)]
                public string Lng { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>国际会议展览中心</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>@mediaId</para>
            /// </summary>
            [NameInMap("bannerMediaId")]
            [Validation(Required=false)]
            public string BannerMediaId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2OGnTRTcoH6OQ0209168</para>
            /// </summary>
            [NameInMap("foreignId")]
            [Validation(Required=false)]
            public string ForeignId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IT</para>
            /// </summary>
            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CTO</para>
            /// </summary>
            [NameInMap("roleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdx</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>钉峰会</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.dingtalk.com/">https://www.dingtalk.com/</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
