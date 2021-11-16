// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchGetWorkspaceDocsRequest extends TeaModel {
    // 操作用户unionId
    @NameInMap("operatorId")
    public String operatorId;

    // 查询节点Id
    @NameInMap("nodeIds")
    public java.util.List<String> nodeIds;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingAccessTokenType")
    public String dingAccessTokenType;

    @NameInMap("dingUid")
    public Long dingUid;

    public static BatchGetWorkspaceDocsRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchGetWorkspaceDocsRequest self = new BatchGetWorkspaceDocsRequest();
        return TeaModel.build(map, self);
    }

    public BatchGetWorkspaceDocsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public BatchGetWorkspaceDocsRequest setNodeIds(java.util.List<String> nodeIds) {
        this.nodeIds = nodeIds;
        return this;
    }
    public java.util.List<String> getNodeIds() {
        return this.nodeIds;
    }

    public BatchGetWorkspaceDocsRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public BatchGetWorkspaceDocsRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public BatchGetWorkspaceDocsRequest setDingAccessTokenType(String dingAccessTokenType) {
        this.dingAccessTokenType = dingAccessTokenType;
        return this;
    }
    public String getDingAccessTokenType() {
        return this.dingAccessTokenType;
    }

    public BatchGetWorkspaceDocsRequest setDingUid(Long dingUid) {
        this.dingUid = dingUid;
        return this;
    }
    public Long getDingUid() {
        return this.dingUid;
    }

}
