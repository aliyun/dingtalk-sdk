// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateApplicationAuthorizationServiceOrderResponseBody extends TeaModel {
    // message
    @NameInMap("message")
    public String message;

    // status
    @NameInMap("status")
    public Integer status;

    public static ValidateApplicationAuthorizationServiceOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ValidateApplicationAuthorizationServiceOrderResponseBody self = new ValidateApplicationAuthorizationServiceOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public ValidateApplicationAuthorizationServiceOrderResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public ValidateApplicationAuthorizationServiceOrderResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
