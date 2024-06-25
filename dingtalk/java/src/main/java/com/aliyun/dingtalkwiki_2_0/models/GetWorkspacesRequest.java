// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetWorkspacesRequest extends TeaModel {
    @NameInMap("option")
    public GetWorkspacesRequestOption option;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("workspaceIds")
    public java.util.List<String> workspaceIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static GetWorkspacesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetWorkspacesRequest self = new GetWorkspacesRequest();
        return TeaModel.build(map, self);
    }

    public GetWorkspacesRequest setOption(GetWorkspacesRequestOption option) {
        this.option = option;
        return this;
    }
    public GetWorkspacesRequestOption getOption() {
        return this.option;
    }

    public GetWorkspacesRequest setWorkspaceIds(java.util.List<String> workspaceIds) {
        this.workspaceIds = workspaceIds;
        return this;
    }
    public java.util.List<String> getWorkspaceIds() {
        return this.workspaceIds;
    }

    public GetWorkspacesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class GetWorkspacesRequestOption extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("withPermissionRole")
        public Boolean withPermissionRole;

        public static GetWorkspacesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            GetWorkspacesRequestOption self = new GetWorkspacesRequestOption();
            return TeaModel.build(map, self);
        }

        public GetWorkspacesRequestOption setWithPermissionRole(Boolean withPermissionRole) {
            this.withPermissionRole = withPermissionRole;
            return this;
        }
        public Boolean getWithPermissionRole() {
            return this.withPermissionRole;
        }

    }

}
