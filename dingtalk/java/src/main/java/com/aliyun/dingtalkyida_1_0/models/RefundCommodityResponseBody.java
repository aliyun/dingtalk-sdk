// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RefundCommodityResponseBody extends TeaModel {
    /**
     * <p>message</p>
     */
    @NameInMap("message")
    public String message;

    /**
     * <p>success</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static RefundCommodityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RefundCommodityResponseBody self = new RefundCommodityResponseBody();
        return TeaModel.build(map, self);
    }

    public RefundCommodityResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public RefundCommodityResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
