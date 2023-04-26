// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchGetWorkspaceDocsRequest extends TeaModel {
    @NameInMap("nodeIds")
    public java.util.List<String> nodeIds;

    @NameInMap("operatorId")
    public String operatorId;

    public static BatchGetWorkspaceDocsRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchGetWorkspaceDocsRequest self = new BatchGetWorkspaceDocsRequest();
        return TeaModel.build(map, self);
    }

    public BatchGetWorkspaceDocsRequest setNodeIds(java.util.List<String> nodeIds) {
        this.nodeIds = nodeIds;
        return this;
    }
    public java.util.List<String> getNodeIds() {
        return this.nodeIds;
    }

    public BatchGetWorkspaceDocsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
