// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class UpdateInstalledRobotRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>钉钉的助手机器人</para>
        /// </summary>
        [NameInMap("brief")]
        [Validation(Required=false)]
        public string Brief { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>钉钉的助手机器人的详细描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>@IAfnkdsanfnkljn</para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>钉钉助手</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("updateType")]
        [Validation(Required=false)]
        public int? UpdateType { get; set; }

    }

}
