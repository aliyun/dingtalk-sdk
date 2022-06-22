// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusListCampusGroupResponseBody : TeaModel {
        /// <summary>
        /// 返回项目组
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<CampusListCampusGroupResponseBodyResult> Result { get; set; }
        public class CampusListCampusGroupResponseBodyResult : TeaModel {
            /// <summary>
            /// 扩展信息
            /// </summary>
            [NameInMap("extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            /// <summary>
            /// 项目组ID
            /// </summary>
            [NameInMap("groupDeptId")]
            [Validation(Required=false)]
            public long? GroupDeptId { get; set; }

            /// <summary>
            /// 项目组名称
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

    }

}
