// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class UpdateInstalledRobotRequest : TeaModel {
        /// <summary>
        /// 机器人的简要描述。
        /// </summary>
        [NameInMap("brief")]
        [Validation(Required=false)]
        public string Brief { get; set; }

        /// <summary>
        /// 机器人的详细描述。
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 机器人图标的mediaId。
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// 机器人的名称。
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 机器人的robotCode。
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// 更新名字或头像时是否更新群里已添加机器人的名字或头像。
        /// 0-不更新群里机器人名字或头像
        /// 1-更新群里机器人名字或头像
        /// </summary>
        [NameInMap("updateType")]
        [Validation(Required=false)]
        public int? UpdateType { get; set; }

    }

}
