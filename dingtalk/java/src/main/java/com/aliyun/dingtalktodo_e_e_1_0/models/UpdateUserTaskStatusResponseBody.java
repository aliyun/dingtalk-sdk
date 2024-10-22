// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class UpdateUserTaskStatusResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateUserTaskStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateUserTaskStatusResponseBody self = new UpdateUserTaskStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateUserTaskStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
