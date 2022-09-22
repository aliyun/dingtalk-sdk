// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRecentEditDocsResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    // 查询结果
    @NameInMap("recentList")
    public java.util.List<GetRecentEditDocsResponseBodyRecentList> recentList;

    public static GetRecentEditDocsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRecentEditDocsResponseBody self = new GetRecentEditDocsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRecentEditDocsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetRecentEditDocsResponseBody setRecentList(java.util.List<GetRecentEditDocsResponseBodyRecentList> recentList) {
        this.recentList = recentList;
        return this;
    }
    public java.util.List<GetRecentEditDocsResponseBodyRecentList> getRecentList() {
        return this.recentList;
    }

    public static class GetRecentEditDocsResponseBodyRecentListNodeBO extends TeaModel {
        // 创建时间
        @NameInMap("createTime")
        public Long createTime;

        // 节点类型
        @NameInMap("docType")
        public String docType;

        // 是否被删除
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        // 内容的最后编辑时间
        @NameInMap("lastEditTime")
        public Long lastEditTime;

        // 文档Id
        @NameInMap("nodeId")
        public String nodeId;

        // 文档名称
        @NameInMap("nodeName")
        public String nodeName;

        // 文档更新时间，包括重命名、移动、内容编辑等操作都会刷新更新时间
        @NameInMap("updateTime")
        public Long updateTime;

        // 文档打开url
        @NameInMap("url")
        public String url;

        public static GetRecentEditDocsResponseBodyRecentListNodeBO build(java.util.Map<String, ?> map) throws Exception {
            GetRecentEditDocsResponseBodyRecentListNodeBO self = new GetRecentEditDocsResponseBodyRecentListNodeBO();
            return TeaModel.build(map, self);
        }

        public GetRecentEditDocsResponseBodyRecentListNodeBO setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public GetRecentEditDocsResponseBodyRecentListNodeBO setDocType(String docType) {
            this.docType = docType;
            return this;
        }
        public String getDocType() {
            return this.docType;
        }

        public GetRecentEditDocsResponseBodyRecentListNodeBO setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public GetRecentEditDocsResponseBodyRecentListNodeBO setLastEditTime(Long lastEditTime) {
            this.lastEditTime = lastEditTime;
            return this;
        }
        public Long getLastEditTime() {
            return this.lastEditTime;
        }

        public GetRecentEditDocsResponseBodyRecentListNodeBO setNodeId(String nodeId) {
            this.nodeId = nodeId;
            return this;
        }
        public String getNodeId() {
            return this.nodeId;
        }

        public GetRecentEditDocsResponseBodyRecentListNodeBO setNodeName(String nodeName) {
            this.nodeName = nodeName;
            return this;
        }
        public String getNodeName() {
            return this.nodeName;
        }

        public GetRecentEditDocsResponseBodyRecentListNodeBO setUpdateTime(Long updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public Long getUpdateTime() {
            return this.updateTime;
        }

        public GetRecentEditDocsResponseBodyRecentListNodeBO setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class GetRecentEditDocsResponseBodyRecentListWorkspaceBO extends TeaModel {
        // 知识库打开url。
        @NameInMap("url")
        public String url;

        // 知识库id。
        @NameInMap("workspaceId")
        public String workspaceId;

        // 知识库名称。
        @NameInMap("workspaceName")
        public String workspaceName;

        public static GetRecentEditDocsResponseBodyRecentListWorkspaceBO build(java.util.Map<String, ?> map) throws Exception {
            GetRecentEditDocsResponseBodyRecentListWorkspaceBO self = new GetRecentEditDocsResponseBodyRecentListWorkspaceBO();
            return TeaModel.build(map, self);
        }

        public GetRecentEditDocsResponseBodyRecentListWorkspaceBO setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetRecentEditDocsResponseBodyRecentListWorkspaceBO setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

        public GetRecentEditDocsResponseBodyRecentListWorkspaceBO setWorkspaceName(String workspaceName) {
            this.workspaceName = workspaceName;
            return this;
        }
        public String getWorkspaceName() {
            return this.workspaceName;
        }

    }

    public static class GetRecentEditDocsResponseBodyRecentList extends TeaModel {
        // 文档信息
        @NameInMap("nodeBO")
        public GetRecentEditDocsResponseBodyRecentListNodeBO nodeBO;

        // 知识库信息。
        @NameInMap("workspaceBO")
        public GetRecentEditDocsResponseBodyRecentListWorkspaceBO workspaceBO;

        public static GetRecentEditDocsResponseBodyRecentList build(java.util.Map<String, ?> map) throws Exception {
            GetRecentEditDocsResponseBodyRecentList self = new GetRecentEditDocsResponseBodyRecentList();
            return TeaModel.build(map, self);
        }

        public GetRecentEditDocsResponseBodyRecentList setNodeBO(GetRecentEditDocsResponseBodyRecentListNodeBO nodeBO) {
            this.nodeBO = nodeBO;
            return this;
        }
        public GetRecentEditDocsResponseBodyRecentListNodeBO getNodeBO() {
            return this.nodeBO;
        }

        public GetRecentEditDocsResponseBodyRecentList setWorkspaceBO(GetRecentEditDocsResponseBodyRecentListWorkspaceBO workspaceBO) {
            this.workspaceBO = workspaceBO;
            return this;
        }
        public GetRecentEditDocsResponseBodyRecentListWorkspaceBO getWorkspaceBO() {
            return this.workspaceBO;
        }

    }

}
