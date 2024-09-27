// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class CreateCloudFeedRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/tfs/TB1A7cBtYr1gK0jSZR0XXbP8XXa-750-422.png">https://img.alicdn.com/tfs/TB1A7cBtYr1gK0jSZR0XXbP8XXa-750-422.png</a></para>
        /// </summary>
        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这是一场云导播课程</para>
        /// </summary>
        [NameInMap("intro")]
        [Validation(Required=false)]
        public string Intro { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615260061000</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>课程一</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>214675</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http/https:/xxx.mp4</para>
        /// </summary>
        [NameInMap("videoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

    }

}
