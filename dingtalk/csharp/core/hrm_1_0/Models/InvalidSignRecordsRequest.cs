// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class InvalidSignRecordsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("invalidUserId")]
        [Validation(Required=false)]
        public string InvalidUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("signRecordIds")]
        [Validation(Required=false)]
        public List<string> SignRecordIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>作废测试</para>
        /// </summary>
        [NameInMap("statusRemark")]
        [Validation(Required=false)]
        public string StatusRemark { get; set; }

    }

}
