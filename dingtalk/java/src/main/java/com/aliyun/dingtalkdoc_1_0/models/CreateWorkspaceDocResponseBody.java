// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateWorkspaceDocResponseBody extends TeaModel {
    // 文档docKey
    @NameInMap("docKey")
    public String docKey;

    // 文档Id
    @NameInMap("nodeId")
    public String nodeId;

    // 文档打开url
    @NameInMap("url")
    public String url;

    // 知识库id。
    @NameInMap("workspaceId")
    public String workspaceId;

    public static CreateWorkspaceDocResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateWorkspaceDocResponseBody self = new CreateWorkspaceDocResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateWorkspaceDocResponseBody setDocKey(String docKey) {
        this.docKey = docKey;
        return this;
    }
    public String getDocKey() {
        return this.docKey;
    }

    public CreateWorkspaceDocResponseBody setNodeId(String nodeId) {
        this.nodeId = nodeId;
        return this;
    }
    public String getNodeId() {
        return this.nodeId;
    }

    public CreateWorkspaceDocResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public CreateWorkspaceDocResponseBody setWorkspaceId(String workspaceId) {
        this.workspaceId = workspaceId;
        return this;
    }
    public String getWorkspaceId() {
        return this.workspaceId;
    }

}
