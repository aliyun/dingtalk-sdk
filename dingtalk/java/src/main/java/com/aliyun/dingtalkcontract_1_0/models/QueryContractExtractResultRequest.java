// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractExtractResultRequest extends TeaModel {
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

    public static QueryContractExtractResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryContractExtractResultRequest self = new QueryContractExtractResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryContractExtractResultRequest setExtractTaskId(String extractTaskId) {
        this.extractTaskId = extractTaskId;
        return this;
    }
    public String getExtractTaskId() {
        return this.extractTaskId;
    }

    public QueryContractExtractResultRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
