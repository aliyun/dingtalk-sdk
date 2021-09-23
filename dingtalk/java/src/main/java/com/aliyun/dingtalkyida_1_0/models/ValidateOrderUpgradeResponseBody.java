// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateOrderUpgradeResponseBody extends TeaModel {
    // message
    @NameInMap("message")
    public String message;

    // status
    @NameInMap("status")
    public Integer status;

    public static ValidateOrderUpgradeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ValidateOrderUpgradeResponseBody self = new ValidateOrderUpgradeResponseBody();
        return TeaModel.build(map, self);
    }

    public ValidateOrderUpgradeResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public ValidateOrderUpgradeResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
