// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ExpireCommodityResponseBody extends TeaModel {
    // message
    @NameInMap("message")
    public String message;

    // success
    @NameInMap("success")
    public Boolean success;

    public static ExpireCommodityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExpireCommodityResponseBody self = new ExpireCommodityResponseBody();
        return TeaModel.build(map, self);
    }

    public ExpireCommodityResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public ExpireCommodityResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
