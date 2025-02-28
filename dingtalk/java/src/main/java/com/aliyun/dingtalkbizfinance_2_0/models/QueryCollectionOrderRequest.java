// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCollectionOrderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>a</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    public static QueryCollectionOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCollectionOrderRequest self = new QueryCollectionOrderRequest();
        return TeaModel.build(map, self);
    }

    public QueryCollectionOrderRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
