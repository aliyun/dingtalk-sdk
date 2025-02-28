// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCollectionOrderResponseBody extends TeaModel {
    @NameInMap("amount")
    public String amount;

    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("remark")
    public String remark;

    @NameInMap("status")
    public String status;

    public static QueryCollectionOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCollectionOrderResponseBody self = new QueryCollectionOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCollectionOrderResponseBody setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public QueryCollectionOrderResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public QueryCollectionOrderResponseBody setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public QueryCollectionOrderResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
