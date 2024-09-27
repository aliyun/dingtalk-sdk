// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListPunchScheduleByConditionWithPagingRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2aa6736c715944329xxxxxxxxd38be41</para>
        /// </summary>
        [NameInMap("bizInstanceId")]
        [Validation(Required=false)]
        public string BizInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-03-13</para>
        /// </summary>
        [NameInMap("scheduleDateEnd")]
        [Validation(Required=false)]
        public string ScheduleDateEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-03-13</para>
        /// </summary>
        [NameInMap("scheduleDateStart")]
        [Validation(Required=false)]
        public string ScheduleDateStart { get; set; }

        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
