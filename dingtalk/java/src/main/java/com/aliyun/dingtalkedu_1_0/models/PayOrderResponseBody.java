// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PayOrderResponseBody extends TeaModel {
    // 返回结果
    @NameInMap("success")
    public Boolean success;

    public static PayOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PayOrderResponseBody self = new PayOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public PayOrderResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
