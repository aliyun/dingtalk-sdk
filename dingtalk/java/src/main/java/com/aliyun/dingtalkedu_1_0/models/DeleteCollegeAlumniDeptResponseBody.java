// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteCollegeAlumniDeptResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteCollegeAlumniDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteCollegeAlumniDeptResponseBody self = new DeleteCollegeAlumniDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteCollegeAlumniDeptResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
