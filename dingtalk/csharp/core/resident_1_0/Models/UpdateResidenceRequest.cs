// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class UpdateResidenceRequest : TeaModel {
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        [NameInMap("departmentName")]
        [Validation(Required=false)]
        public string DepartmentName { get; set; }

        [NameInMap("destitute")]
        [Validation(Required=false)]
        public bool? Destitute { get; set; }

        [NameInMap("grid")]
        [Validation(Required=false)]
        public string Grid { get; set; }

        [NameInMap("homeTel")]
        [Validation(Required=false)]
        public string HomeTel { get; set; }

        [NameInMap("managerUserId")]
        [Validation(Required=false)]
        public string ManagerUserId { get; set; }

        [NameInMap("parentDepartmentId")]
        [Validation(Required=false)]
        public long? ParentDepartmentId { get; set; }

    }

}
