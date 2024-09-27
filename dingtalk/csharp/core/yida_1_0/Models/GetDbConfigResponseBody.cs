// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetDbConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;dbName&quot;:&quot;yida_exclusive_pg_db&quot;,&quot;exclusiveType&quot;:&quot;DATABASE&quot;,&quot;maxActive&quot;:1600,&quot;minIdle&quot;:160,&quot;password&quot;:&quot;xxx&quot;,&quot;sharding&quot;:true,&quot;type&quot;:&quot;POSTGRES&quot;,&quot;url&quot;:&quot;pgm-bp17c85t9363an74194040.pg.rds.aliyuncs.com:0000&quot;,&quot;username&quot;:&quot;yida_xxx&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding5d17e3add038d44535c2f4657eb6378f</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-02-23T14:46Z</para>
        /// </summary>
        [NameInMap("createTimeGMT")]
        [Validation(Required=false)]
        public string CreateTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>092824253426603595</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding5d17e3add038d44535c2f4657eb6378f</para>
        /// </summary>
        [NameInMap("exclusive")]
        [Validation(Required=false)]
        public string Exclusive { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>600001</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-08-15T10:37Z</para>
        /// </summary>
        [NameInMap("modifiedTimeGMT")]
        [Validation(Required=false)]
        public string ModifiedTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5014533041684350</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DATABASE</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
