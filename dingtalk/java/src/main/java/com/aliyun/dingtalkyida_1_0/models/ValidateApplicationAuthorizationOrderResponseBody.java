// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateApplicationAuthorizationOrderResponseBody extends TeaModel {
    @NameInMap("message")
    public String message;

    @NameInMap("status")
    public Integer status;

    public static ValidateApplicationAuthorizationOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ValidateApplicationAuthorizationOrderResponseBody self = new ValidateApplicationAuthorizationOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public ValidateApplicationAuthorizationOrderResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public ValidateApplicationAuthorizationOrderResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
