// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateOrderUpdateResponseBody extends TeaModel {
    // message
    @NameInMap("message")
    public String message;

    // status
    @NameInMap("status")
    public Integer status;

    public static ValidateOrderUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ValidateOrderUpdateResponseBody self = new ValidateOrderUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public ValidateOrderUpdateResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public ValidateOrderUpdateResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
