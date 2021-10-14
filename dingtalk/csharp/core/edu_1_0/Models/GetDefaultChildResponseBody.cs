// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetDefaultChildResponseBody : TeaModel {
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        [NameInMap("bindStudents")]
        [Validation(Required=false)]
        public List<GetDefaultChildResponseBodyBindStudents> BindStudents { get; set; }
        public class GetDefaultChildResponseBodyBindStudents : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("staffId")]
            [Validation(Required=false)]
            public string StaffId { get; set; }

            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            [NameInMap("period")]
            [Validation(Required=false)]
            public string Period { get; set; }

        }

        [NameInMap("grade")]
        [Validation(Required=false)]
        public int? Grade { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("nick")]
        [Validation(Required=false)]
        public string Nick { get; set; }

        [NameInMap("period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
