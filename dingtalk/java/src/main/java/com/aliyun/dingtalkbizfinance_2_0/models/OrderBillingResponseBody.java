// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class OrderBillingResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static OrderBillingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OrderBillingResponseBody self = new OrderBillingResponseBody();
        return TeaModel.build(map, self);
    }

    public OrderBillingResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
