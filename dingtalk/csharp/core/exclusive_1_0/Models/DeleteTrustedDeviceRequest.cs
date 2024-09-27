// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class DeleteTrustedDeviceRequest : TeaModel {
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("kickOff")]
        [Validation(Required=false)]
        public bool? KickOff { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>88:92:5a:1f:e8:24</para>
        /// </summary>
        [NameInMap("macAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0119194439361061403</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
