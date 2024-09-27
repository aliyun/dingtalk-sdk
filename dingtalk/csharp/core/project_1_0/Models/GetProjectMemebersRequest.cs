// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetProjectMemebersRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60a2187eb72xxxxxxx</para>
        /// </summary>
        [NameInMap("projectRoleId")]
        [Validation(Required=false)]
        public string ProjectRoleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60a2187eb72xxxxxxx,60a2187eb72xxxxxxx</para>
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

    }

}
