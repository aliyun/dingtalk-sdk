// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeUserEmpTypeResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateCollegeUserEmpTypeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeUserEmpTypeResponseBody self = new UpdateCollegeUserEmpTypeResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeUserEmpTypeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
