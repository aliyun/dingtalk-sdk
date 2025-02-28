// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCollectionInfoListRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>SUCCESS</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("status")
    public String status;

    public static QueryCollectionInfoListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCollectionInfoListRequest self = new QueryCollectionInfoListRequest();
        return TeaModel.build(map, self);
    }

    public QueryCollectionInfoListRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
