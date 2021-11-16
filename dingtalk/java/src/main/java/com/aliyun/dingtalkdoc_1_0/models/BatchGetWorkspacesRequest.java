// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchGetWorkspacesRequest extends TeaModel {
    // 操作用户unionId
    @NameInMap("operatorId")
    public String operatorId;

    // 是否查询最近访问文档
    @NameInMap("includeRecent")
    public Boolean includeRecent;

    // 待查询空间Id
    @NameInMap("workspaceIds")
    public java.util.List<String> workspaceIds;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingUid")
    public Long dingUid;

    @NameInMap("dingAccessTokenType")
    public String dingAccessTokenType;

    public static BatchGetWorkspacesRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchGetWorkspacesRequest self = new BatchGetWorkspacesRequest();
        return TeaModel.build(map, self);
    }

    public BatchGetWorkspacesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public BatchGetWorkspacesRequest setIncludeRecent(Boolean includeRecent) {
        this.includeRecent = includeRecent;
        return this;
    }
    public Boolean getIncludeRecent() {
        return this.includeRecent;
    }

    public BatchGetWorkspacesRequest setWorkspaceIds(java.util.List<String> workspaceIds) {
        this.workspaceIds = workspaceIds;
        return this;
    }
    public java.util.List<String> getWorkspaceIds() {
        return this.workspaceIds;
    }

    public BatchGetWorkspacesRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public BatchGetWorkspacesRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public BatchGetWorkspacesRequest setDingUid(Long dingUid) {
        this.dingUid = dingUid;
        return this;
    }
    public Long getDingUid() {
        return this.dingUid;
    }

    public BatchGetWorkspacesRequest setDingAccessTokenType(String dingAccessTokenType) {
        this.dingAccessTokenType = dingAccessTokenType;
        return this;
    }
    public String getDingAccessTokenType() {
        return this.dingAccessTokenType;
    }

}
