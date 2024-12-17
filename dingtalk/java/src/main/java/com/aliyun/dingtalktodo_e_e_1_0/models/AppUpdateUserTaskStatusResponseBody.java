// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppUpdateUserTaskStatusResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AppUpdateUserTaskStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AppUpdateUserTaskStatusResponseBody self = new AppUpdateUserTaskStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public AppUpdateUserTaskStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
