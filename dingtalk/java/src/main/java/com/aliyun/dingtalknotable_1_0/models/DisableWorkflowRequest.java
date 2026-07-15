// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class DisableWorkflowRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static DisableWorkflowRequest build(java.util.Map<String, ?> map) throws Exception {
        DisableWorkflowRequest self = new DisableWorkflowRequest();
        return TeaModel.build(map, self);
    }

    public DisableWorkflowRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
