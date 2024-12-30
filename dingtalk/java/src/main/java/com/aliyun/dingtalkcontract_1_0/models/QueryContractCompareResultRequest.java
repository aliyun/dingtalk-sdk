// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractCompareResultRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("compareTaskId")
    public String compareTaskId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("requestId")
    public String requestId;

    public static QueryContractCompareResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryContractCompareResultRequest self = new QueryContractCompareResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryContractCompareResultRequest setCompareTaskId(String compareTaskId) {
        this.compareTaskId = compareTaskId;
        return this;
    }
    public String getCompareTaskId() {
        return this.compareTaskId;
    }

    public QueryContractCompareResultRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
