// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetWorkspaceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("withPermissionRole")
    public Boolean withPermissionRole;

    public static GetWorkspaceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetWorkspaceRequest self = new GetWorkspaceRequest();
        return TeaModel.build(map, self);
    }

    public GetWorkspaceRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public GetWorkspaceRequest setWithPermissionRole(Boolean withPermissionRole) {
        this.withPermissionRole = withPermissionRole;
        return this;
    }
    public Boolean getWithPermissionRole() {
        return this.withPermissionRole;
    }

}
