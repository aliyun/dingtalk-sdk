// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCollegeContactUserResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateCollegeContactUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCollegeContactUserResponseBody self = new UpdateCollegeContactUserResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCollegeContactUserResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
