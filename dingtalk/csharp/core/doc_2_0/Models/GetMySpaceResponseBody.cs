// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class GetMySpaceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-01-01T10:00:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-01-01T10:00:00Z</para>
        /// </summary>
        [NameInMap("modifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1L</para>
        /// </summary>
        [NameInMap("quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>space_id</para>
        /// </summary>
        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>space_name</para>
        /// </summary>
        [NameInMap("spaceName")]
        [Validation(Required=false)]
        public string SpaceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>personal|org|custom|unknown</para>
        /// </summary>
        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1L</para>
        /// </summary>
        [NameInMap("usedQuota")]
        [Validation(Required=false)]
        public long? UsedQuota { get; set; }

    }

}
