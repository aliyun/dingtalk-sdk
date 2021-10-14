// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListEventsViewRequest : TeaModel {
        /// <summary>
        /// 查询返回结果数
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 查询翻页token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 查询截止时间
        /// </summary>
        [NameInMap("timeMax")]
        [Validation(Required=false)]
        public string TimeMax { get; set; }

        /// <summary>
        /// 查询开始时间
        /// </summary>
        [NameInMap("timeMin")]
        [Validation(Required=false)]
        public string TimeMin { get; set; }

    }

}
