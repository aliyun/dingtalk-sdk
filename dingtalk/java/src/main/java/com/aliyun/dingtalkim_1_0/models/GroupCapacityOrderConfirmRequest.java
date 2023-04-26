// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupCapacityOrderConfirmRequest extends TeaModel {
    @NameInMap("operator")
    public String operator;

    @NameInMap("orderId")
    public String orderId;

    public static GroupCapacityOrderConfirmRequest build(java.util.Map<String, ?> map) throws Exception {
        GroupCapacityOrderConfirmRequest self = new GroupCapacityOrderConfirmRequest();
        return TeaModel.build(map, self);
    }

    public GroupCapacityOrderConfirmRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public GroupCapacityOrderConfirmRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

}
