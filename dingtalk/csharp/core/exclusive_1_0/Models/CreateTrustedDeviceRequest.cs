// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class CreateTrustedDeviceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CV11z5d2bdbb2260d1576000b4a9955fa</para>
        /// </summary>
        [NameInMap("did")]
        [Validation(Required=false)]
        public string Did { get; set; }

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
        /// <para>Mac</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65224157501039784</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
