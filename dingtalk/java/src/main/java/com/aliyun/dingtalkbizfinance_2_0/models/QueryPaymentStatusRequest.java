// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentStatusRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ABC</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    /**
     * <strong>example:</strong>
     * <p>20241102231</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <strong>example:</strong>
     * <p>504323</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryPaymentStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentStatusRequest self = new QueryPaymentStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryPaymentStatusRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public QueryPaymentStatusRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public QueryPaymentStatusRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
