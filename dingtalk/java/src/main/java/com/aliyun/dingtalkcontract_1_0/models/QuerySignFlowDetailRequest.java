// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QuerySignFlowDetailRequest extends TeaModel {
    @NameInMap("bizFlowId")
    public String bizFlowId;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("signFlowId")
    public String signFlowId;

    public static QuerySignFlowDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySignFlowDetailRequest self = new QuerySignFlowDetailRequest();
        return TeaModel.build(map, self);
    }

    public QuerySignFlowDetailRequest setBizFlowId(String bizFlowId) {
        this.bizFlowId = bizFlowId;
        return this;
    }
    public String getBizFlowId() {
        return this.bizFlowId;
    }

    public QuerySignFlowDetailRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QuerySignFlowDetailRequest setSignFlowId(String signFlowId) {
        this.signFlowId = signFlowId;
        return this;
    }
    public String getSignFlowId() {
        return this.signFlowId;
    }

}
