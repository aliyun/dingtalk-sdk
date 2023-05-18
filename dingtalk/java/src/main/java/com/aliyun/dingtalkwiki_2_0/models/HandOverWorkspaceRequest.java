// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class HandOverWorkspaceRequest extends TeaModel {
    @NameInMap("sourceOwnerId")
    public String sourceOwnerId;

    @NameInMap("targetOwnerId")
    public String targetOwnerId;

    @NameInMap("workspaceId")
    public String workspaceId;

    @NameInMap("operatorId")
    public String operatorId;

    public static HandOverWorkspaceRequest build(java.util.Map<String, ?> map) throws Exception {
        HandOverWorkspaceRequest self = new HandOverWorkspaceRequest();
        return TeaModel.build(map, self);
    }

    public HandOverWorkspaceRequest setSourceOwnerId(String sourceOwnerId) {
        this.sourceOwnerId = sourceOwnerId;
        return this;
    }
    public String getSourceOwnerId() {
        return this.sourceOwnerId;
    }

    public HandOverWorkspaceRequest setTargetOwnerId(String targetOwnerId) {
        this.targetOwnerId = targetOwnerId;
        return this;
    }
    public String getTargetOwnerId() {
        return this.targetOwnerId;
    }

    public HandOverWorkspaceRequest setWorkspaceId(String workspaceId) {
        this.workspaceId = workspaceId;
        return this;
    }
    public String getWorkspaceId() {
        return this.workspaceId;
    }

    public HandOverWorkspaceRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
