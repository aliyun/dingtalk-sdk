// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetGroupActiveInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cidV3xxxrSuxxxxxxnB8o8gJw==</para>
        /// </summary>
        [NameInMap("dingGroupId")]
        [Validation(Required=false)]
        public string DingGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public long? GroupType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20200305</para>
        /// </summary>
        [NameInMap("statDate")]
        [Validation(Required=false)]
        public string StatDate { get; set; }

    }

}
