// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QuerySchoolUserFaceResponseBody : TeaModel {
        /// <summary>
        /// 组织id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 是否还有下一页
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 用户人脸列表
        /// </summary>
        [NameInMap("userFaceList")]
        [Validation(Required=false)]
        public List<QuerySchoolUserFaceResponseBodyUserFaceList> UserFaceList { get; set; }
        public class QuerySchoolUserFaceResponseBodyUserFaceList : TeaModel {
            /// <summary>
            /// 人脸id
            /// </summary>
            [NameInMap("faceId")]
            [Validation(Required=false)]
            public string FaceId { get; set; }

            /// <summary>
            /// 员工名字
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 员工状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// 员工id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
