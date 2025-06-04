// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractAppsTermsExtractResultRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("extractTaskId")
    public String extractTaskId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryContractAppsTermsExtractResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryContractAppsTermsExtractResultRequest self = new QueryContractAppsTermsExtractResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryContractAppsTermsExtractResultRequest setExtractTaskId(String extractTaskId) {
        this.extractTaskId = extractTaskId;
        return this;
    }
    public String getExtractTaskId() {
        return this.extractTaskId;
    }

    public QueryContractAppsTermsExtractResultRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryContractAppsTermsExtractResultRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
