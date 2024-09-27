// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class CreateCooperateOrgRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("industryCode")]
        [Validation(Required=false)]
        public long? IndustryCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mediaId</para>
        /// </summary>
        [NameInMap("logoMediaId")]
        [Validation(Required=false)]
        public string LogoMediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试联盟</para>
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

    }

}
