// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateOrderBuyResponseBody extends TeaModel {
    // message
    @NameInMap("message")
    public String message;

    // status
    @NameInMap("status")
    public Integer status;

    public static ValidateOrderBuyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ValidateOrderBuyResponseBody self = new ValidateOrderBuyResponseBody();
        return TeaModel.build(map, self);
    }

    public ValidateOrderBuyResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public ValidateOrderBuyResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
