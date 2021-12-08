// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateUniversityStudentRequest : TeaModel {
        /// <summary>
        /// 班级id
        /// </summary>
        [NameInMap("classId")]
        [Validation(Required=false)]
        public long? ClassId { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [NameInMap("identityNumber")]
        [Validation(Required=false)]
        public string IdentityNumber { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        [NameInMap("studentNumber")]
        [Validation(Required=false)]
        public string StudentNumber { get; set; }

        /// <summary>
        /// opUserId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
