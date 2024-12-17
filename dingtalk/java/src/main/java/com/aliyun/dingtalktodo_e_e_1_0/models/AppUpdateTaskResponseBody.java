// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppUpdateTaskResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AppUpdateTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AppUpdateTaskResponseBody self = new AppUpdateTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public AppUpdateTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
