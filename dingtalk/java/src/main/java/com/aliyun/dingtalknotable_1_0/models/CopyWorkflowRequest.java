// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class CopyWorkflowRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("flowId")
    public String flowId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("flowVersionId")
    public String flowVersionId;

    @NameInMap("isSystem")
    public Boolean isSystem;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sourceBaseId")
    public String sourceBaseId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static CopyWorkflowRequest build(java.util.Map<String, ?> map) throws Exception {
        CopyWorkflowRequest self = new CopyWorkflowRequest();
        return TeaModel.build(map, self);
    }

    public CopyWorkflowRequest setFlowId(String flowId) {
        this.flowId = flowId;
        return this;
    }
    public String getFlowId() {
        return this.flowId;
    }

    public CopyWorkflowRequest setFlowVersionId(String flowVersionId) {
        this.flowVersionId = flowVersionId;
        return this;
    }
    public String getFlowVersionId() {
        return this.flowVersionId;
    }

    public CopyWorkflowRequest setIsSystem(Boolean isSystem) {
        this.isSystem = isSystem;
        return this;
    }
    public Boolean getIsSystem() {
        return this.isSystem;
    }

    public CopyWorkflowRequest setSourceBaseId(String sourceBaseId) {
        this.sourceBaseId = sourceBaseId;
        return this;
    }
    public String getSourceBaseId() {
        return this.sourceBaseId;
    }

    public CopyWorkflowRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
