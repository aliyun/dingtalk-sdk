// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoccupationauth_1_0.models;

import com.aliyun.tea.*;

public class CheckUserTasksStatusResponseBody extends TeaModel {
    @NameInMap("status")
    public Boolean status;

    public static CheckUserTasksStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckUserTasksStatusResponseBody self = new CheckUserTasksStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckUserTasksStatusResponseBody setStatus(Boolean status) {
        this.status = status;
        return this;
    }
    public Boolean getStatus() {
        return this.status;
    }

}
