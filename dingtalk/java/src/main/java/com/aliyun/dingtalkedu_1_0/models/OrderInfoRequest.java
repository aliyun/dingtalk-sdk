// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class OrderInfoRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>80930501630545566xx</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    public static OrderInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        OrderInfoRequest self = new OrderInfoRequest();
        return TeaModel.build(map, self);
    }

    public OrderInfoRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

}
