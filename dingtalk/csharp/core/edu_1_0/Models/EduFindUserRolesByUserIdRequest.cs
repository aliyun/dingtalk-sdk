// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class EduFindUserRolesByUserIdRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>666666</para>
        /// </summary>
        [NameInMap("classId")]
        [Validation(Required=false)]
        public long? ClassId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding123456</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("hasOrgRole")]
        [Validation(Required=false)]
        public bool? HasOrgRole { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
