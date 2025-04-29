// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateStudentResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateStudentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateStudentResponseBody self = new UpdateStudentResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateStudentResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
