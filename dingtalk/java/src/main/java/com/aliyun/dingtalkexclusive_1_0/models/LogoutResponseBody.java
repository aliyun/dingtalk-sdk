// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class LogoutResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static LogoutResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LogoutResponseBody self = new LogoutResponseBody();
        return TeaModel.build(map, self);
    }

    public LogoutResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
