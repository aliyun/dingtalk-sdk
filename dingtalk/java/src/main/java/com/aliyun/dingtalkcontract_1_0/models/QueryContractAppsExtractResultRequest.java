// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractAppsExtractResultRequest extends TeaModel {
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

    public static QueryContractAppsExtractResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryContractAppsExtractResultRequest self = new QueryContractAppsExtractResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryContractAppsExtractResultRequest setExtractTaskId(String extractTaskId) {
        this.extractTaskId = extractTaskId;
        return this;
    }
    public String getExtractTaskId() {
        return this.extractTaskId;
    }

    public QueryContractAppsExtractResultRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryContractAppsExtractResultRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
