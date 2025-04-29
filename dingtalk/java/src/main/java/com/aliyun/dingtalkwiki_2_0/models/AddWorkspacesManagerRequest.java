// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class AddWorkspacesManagerRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>[1]</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>workspace_id</p>
     */
    @NameInMap("workspaceId")
    public String workspaceId;

    public static AddWorkspacesManagerRequest build(java.util.Map<String, ?> map) throws Exception {
        AddWorkspacesManagerRequest self = new AddWorkspacesManagerRequest();
        return TeaModel.build(map, self);
    }

    public AddWorkspacesManagerRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

    public AddWorkspacesManagerRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public AddWorkspacesManagerRequest setWorkspaceId(String workspaceId) {
        this.workspaceId = workspaceId;
        return this;
    }
    public String getWorkspaceId() {
        return this.workspaceId;
    }

}
