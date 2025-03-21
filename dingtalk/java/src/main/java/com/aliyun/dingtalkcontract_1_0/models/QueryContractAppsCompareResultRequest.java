// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractAppsCompareResultRequest extends TeaModel {
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

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static QueryContractAppsCompareResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryContractAppsCompareResultRequest self = new QueryContractAppsCompareResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryContractAppsCompareResultRequest setCompareTaskId(String compareTaskId) {
        this.compareTaskId = compareTaskId;
        return this;
    }
    public String getCompareTaskId() {
        return this.compareTaskId;
    }

    public QueryContractAppsCompareResultRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryContractAppsCompareResultRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
