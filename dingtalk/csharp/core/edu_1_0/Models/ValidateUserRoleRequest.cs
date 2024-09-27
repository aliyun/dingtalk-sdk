// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class ValidateUserRoleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1677600000000</para>
        /// </summary>
        [NameInMap("timeThreshold")]
        [Validation(Required=false)]
        public long? TimeThreshold { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VYn5fYjORJMi</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
