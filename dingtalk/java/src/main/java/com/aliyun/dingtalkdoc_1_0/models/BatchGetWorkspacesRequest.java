// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchGetWorkspacesRequest extends TeaModel {
    // 是否查询最近访问文档
    @NameInMap("includeRecent")
    public Boolean includeRecent;

    // 操作用户unionId
    @NameInMap("operatorId")
    public String operatorId;

    // 待查询空间Id
    @NameInMap("workspaceIds")
    public java.util.List<String> workspaceIds;

    public static BatchGetWorkspacesRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchGetWorkspacesRequest self = new BatchGetWorkspacesRequest();
        return TeaModel.build(map, self);
    }

    public BatchGetWorkspacesRequest setIncludeRecent(Boolean includeRecent) {
        this.includeRecent = includeRecent;
        return this;
    }
    public Boolean getIncludeRecent() {
        return this.includeRecent;
    }

    public BatchGetWorkspacesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public BatchGetWorkspacesRequest setWorkspaceIds(java.util.List<String> workspaceIds) {
        this.workspaceIds = workspaceIds;
        return this;
    }
    public java.util.List<String> getWorkspaceIds() {
        return this.workspaceIds;
    }

}
