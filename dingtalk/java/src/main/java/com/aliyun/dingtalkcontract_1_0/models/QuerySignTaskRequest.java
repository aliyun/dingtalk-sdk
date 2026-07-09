// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QuerySignTaskRequest extends TeaModel {
    @NameInMap("bizFlowId")
    public String bizFlowId;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("signFlowId")
    public String signFlowId;

    public static QuerySignTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySignTaskRequest self = new QuerySignTaskRequest();
        return TeaModel.build(map, self);
    }

    public QuerySignTaskRequest setBizFlowId(String bizFlowId) {
        this.bizFlowId = bizFlowId;
        return this;
    }
    public String getBizFlowId() {
        return this.bizFlowId;
    }

    public QuerySignTaskRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QuerySignTaskRequest setSignFlowId(String signFlowId) {
        this.signFlowId = signFlowId;
        return this;
    }
    public String getSignFlowId() {
        return this.signFlowId;
    }

}
