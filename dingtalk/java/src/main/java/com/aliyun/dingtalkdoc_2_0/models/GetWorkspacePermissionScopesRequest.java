// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetWorkspacePermissionScopesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static GetWorkspacePermissionScopesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetWorkspacePermissionScopesRequest self = new GetWorkspacePermissionScopesRequest();
        return TeaModel.build(map, self);
    }

    public GetWorkspacePermissionScopesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
