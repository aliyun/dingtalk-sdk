// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class MoveStudentResponseBody extends TeaModel {
    // success
    @NameInMap("success")
    public Boolean success;

    public static MoveStudentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MoveStudentResponseBody self = new MoveStudentResponseBody();
        return TeaModel.build(map, self);
    }

    public MoveStudentResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
