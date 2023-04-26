// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateApplicationServiceOrderUpgradeResponseBody extends TeaModel {
    @NameInMap("message")
    public String message;

    @NameInMap("status")
    public Integer status;

    public static ValidateApplicationServiceOrderUpgradeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ValidateApplicationServiceOrderUpgradeResponseBody self = new ValidateApplicationServiceOrderUpgradeResponseBody();
        return TeaModel.build(map, self);
    }

    public ValidateApplicationServiceOrderUpgradeResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public ValidateApplicationServiceOrderUpgradeResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
