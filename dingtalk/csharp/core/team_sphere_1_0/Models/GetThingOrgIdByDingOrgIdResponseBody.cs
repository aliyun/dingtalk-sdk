// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class GetThingOrgIdByDingOrgIdResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetThingOrgIdByDingOrgIdResponseBodyResult Result { get; set; }
        public class GetThingOrgIdByDingOrgIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50c32afae8cf1439xxxx</para>
            /// </summary>
            [NameInMap("tbOrganizationId")]
            [Validation(Required=false)]
            public string TbOrganizationId { get; set; }

        }

    }

}
