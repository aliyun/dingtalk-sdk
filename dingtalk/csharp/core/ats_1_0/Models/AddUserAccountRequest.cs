// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class AddUserAccountRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ddats</para>
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例昵称xxx</para>
        /// </summary>
        [NameInMap("channelAccountName")]
        [Validation(Required=false)]
        public string ChannelAccountName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6FSe51616SOdd394d6</para>
        /// </summary>
        [NameInMap("channelUserIdentify")]
        [Validation(Required=false)]
        public string ChannelUserIdentify { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16600010001</para>
        /// </summary>
        [NameInMap("phoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding123456789</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1676451039</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
