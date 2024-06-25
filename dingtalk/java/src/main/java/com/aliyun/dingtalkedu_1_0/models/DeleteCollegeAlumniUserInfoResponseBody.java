// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteCollegeAlumniUserInfoResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteCollegeAlumniUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteCollegeAlumniUserInfoResponseBody self = new DeleteCollegeAlumniUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteCollegeAlumniUserInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
