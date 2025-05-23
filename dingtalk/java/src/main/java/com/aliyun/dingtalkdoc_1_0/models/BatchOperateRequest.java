// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchOperateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>requests</p>
     */
    @NameInMap("requests")
    public java.util.List<?> requests;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static BatchOperateRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchOperateRequest self = new BatchOperateRequest();
        return TeaModel.build(map, self);
    }

    public BatchOperateRequest setRequests(java.util.List<?> requests) {
        this.requests = requests;
        return this;
    }
    public java.util.List<?> getRequests() {
        return this.requests;
    }

    public BatchOperateRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
