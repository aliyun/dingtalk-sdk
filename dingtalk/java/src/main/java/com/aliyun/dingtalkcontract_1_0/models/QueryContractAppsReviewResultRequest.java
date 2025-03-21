// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractAppsReviewResultRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("reviewTaskId")
    public String reviewTaskId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryContractAppsReviewResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryContractAppsReviewResultRequest self = new QueryContractAppsReviewResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryContractAppsReviewResultRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryContractAppsReviewResultRequest setReviewTaskId(String reviewTaskId) {
        this.reviewTaskId = reviewTaskId;
        return this;
    }
    public String getReviewTaskId() {
        return this.reviewTaskId;
    }

    public QueryContractAppsReviewResultRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
