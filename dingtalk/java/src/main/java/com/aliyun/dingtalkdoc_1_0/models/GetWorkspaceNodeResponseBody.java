// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetWorkspaceNodeResponseBody extends TeaModel {
    // 节点信息
    @NameInMap("nodeBO")
    public java.util.Map<String, ?> nodeBO;

    // 节点所属团队空间信息
    @NameInMap("workspaceBO")
    public java.util.Map<String, ?> workspaceBO;

    // 是否有权限
    @NameInMap("hasPermission")
    public Boolean hasPermission;

    public static GetWorkspaceNodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetWorkspaceNodeResponseBody self = new GetWorkspaceNodeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetWorkspaceNodeResponseBody setNodeBO(java.util.Map<String, ?> nodeBO) {
        this.nodeBO = nodeBO;
        return this;
    }
    public java.util.Map<String, ?> getNodeBO() {
        return this.nodeBO;
    }

    public GetWorkspaceNodeResponseBody setWorkspaceBO(java.util.Map<String, ?> workspaceBO) {
        this.workspaceBO = workspaceBO;
        return this;
    }
    public java.util.Map<String, ?> getWorkspaceBO() {
        return this.workspaceBO;
    }

    public GetWorkspaceNodeResponseBody setHasPermission(Boolean hasPermission) {
        this.hasPermission = hasPermission;
        return this;
    }
    public Boolean getHasPermission() {
        return this.hasPermission;
    }

}
