// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteStudentResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteStudentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteStudentResponseBody self = new DeleteStudentResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteStudentResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
