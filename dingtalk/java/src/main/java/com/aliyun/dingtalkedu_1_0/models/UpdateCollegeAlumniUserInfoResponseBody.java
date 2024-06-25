// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeAlumniUserInfoResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateCollegeAlumniUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeAlumniUserInfoResponseBody self = new UpdateCollegeAlumniUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeAlumniUserInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
