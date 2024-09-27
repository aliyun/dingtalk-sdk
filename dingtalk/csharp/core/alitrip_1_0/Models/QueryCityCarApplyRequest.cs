// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class QueryCityCarApplyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>corpx</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-03-18 20:26:56</para>
        /// </summary>
        [NameInMap("createdEndAt")]
        [Validation(Required=false)]
        public string CreatedEndAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-03-18 20:26:56</para>
        /// </summary>
        [NameInMap("createdStartAt")]
        [Validation(Required=false)]
        public string CreatedStartAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>apply1</para>
        /// </summary>
        [NameInMap("thirdPartApplyId")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
