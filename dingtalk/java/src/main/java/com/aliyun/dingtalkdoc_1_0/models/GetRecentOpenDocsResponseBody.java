// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRecentOpenDocsResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    // 查询结果
    @NameInMap("recentList")
    public java.util.List<GetRecentOpenDocsResponseBodyRecentList> recentList;

    public static GetRecentOpenDocsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRecentOpenDocsResponseBody self = new GetRecentOpenDocsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRecentOpenDocsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetRecentOpenDocsResponseBody setRecentList(java.util.List<GetRecentOpenDocsResponseBodyRecentList> recentList) {
        this.recentList = recentList;
        return this;
    }
    public java.util.List<GetRecentOpenDocsResponseBodyRecentList> getRecentList() {
        return this.recentList;
    }

    public static class GetRecentOpenDocsResponseBodyRecentListNodeBO extends TeaModel {
        // 创建时间
        @NameInMap("createTime")
        public Long createTime;

        // 节点类型
        @NameInMap("docType")
        public String docType;

        // 是否被删除
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        // 最后编辑时间
        @NameInMap("lastOpenTime")
        public Long lastOpenTime;

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

        public static GetRecentOpenDocsResponseBodyRecentListNodeBO build(java.util.Map<String, ?> map) throws Exception {
            GetRecentOpenDocsResponseBodyRecentListNodeBO self = new GetRecentOpenDocsResponseBodyRecentListNodeBO();
            return TeaModel.build(map, self);
        }

        public GetRecentOpenDocsResponseBodyRecentListNodeBO setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public GetRecentOpenDocsResponseBodyRecentListNodeBO setDocType(String docType) {
            this.docType = docType;
            return this;
        }
        public String getDocType() {
            return this.docType;
        }

        public GetRecentOpenDocsResponseBodyRecentListNodeBO setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public GetRecentOpenDocsResponseBodyRecentListNodeBO setLastOpenTime(Long lastOpenTime) {
            this.lastOpenTime = lastOpenTime;
            return this;
        }
        public Long getLastOpenTime() {
            return this.lastOpenTime;
        }

        public GetRecentOpenDocsResponseBodyRecentListNodeBO setNodeId(String nodeId) {
            this.nodeId = nodeId;
            return this;
        }
        public String getNodeId() {
            return this.nodeId;
        }

        public GetRecentOpenDocsResponseBodyRecentListNodeBO setNodeName(String nodeName) {
            this.nodeName = nodeName;
            return this;
        }
        public String getNodeName() {
            return this.nodeName;
        }

        public GetRecentOpenDocsResponseBodyRecentListNodeBO setUpdateTime(Long updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public Long getUpdateTime() {
            return this.updateTime;
        }

        public GetRecentOpenDocsResponseBodyRecentListNodeBO setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class GetRecentOpenDocsResponseBodyRecentListWorkspaceBO extends TeaModel {
        // 知识库打开url。
        @NameInMap("url")
        public String url;

        // 知识库id。
        @NameInMap("workspaceId")
        public String workspaceId;

        // 知识库名称。
        @NameInMap("workspaceName")
        public String workspaceName;

        public static GetRecentOpenDocsResponseBodyRecentListWorkspaceBO build(java.util.Map<String, ?> map) throws Exception {
            GetRecentOpenDocsResponseBodyRecentListWorkspaceBO self = new GetRecentOpenDocsResponseBodyRecentListWorkspaceBO();
            return TeaModel.build(map, self);
        }

        public GetRecentOpenDocsResponseBodyRecentListWorkspaceBO setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetRecentOpenDocsResponseBodyRecentListWorkspaceBO setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

        public GetRecentOpenDocsResponseBodyRecentListWorkspaceBO setWorkspaceName(String workspaceName) {
            this.workspaceName = workspaceName;
            return this;
        }
        public String getWorkspaceName() {
            return this.workspaceName;
        }

    }

    public static class GetRecentOpenDocsResponseBodyRecentList extends TeaModel {
        // 文档信息
        @NameInMap("nodeBO")
        public GetRecentOpenDocsResponseBodyRecentListNodeBO nodeBO;

        // 知识库信息。
        @NameInMap("workspaceBO")
        public GetRecentOpenDocsResponseBodyRecentListWorkspaceBO workspaceBO;

        public static GetRecentOpenDocsResponseBodyRecentList build(java.util.Map<String, ?> map) throws Exception {
            GetRecentOpenDocsResponseBodyRecentList self = new GetRecentOpenDocsResponseBodyRecentList();
            return TeaModel.build(map, self);
        }

        public GetRecentOpenDocsResponseBodyRecentList setNodeBO(GetRecentOpenDocsResponseBodyRecentListNodeBO nodeBO) {
            this.nodeBO = nodeBO;
            return this;
        }
        public GetRecentOpenDocsResponseBodyRecentListNodeBO getNodeBO() {
            return this.nodeBO;
        }

        public GetRecentOpenDocsResponseBodyRecentList setWorkspaceBO(GetRecentOpenDocsResponseBodyRecentListWorkspaceBO workspaceBO) {
            this.workspaceBO = workspaceBO;
            return this;
        }
        public GetRecentOpenDocsResponseBodyRecentListWorkspaceBO getWorkspaceBO() {
            return this.workspaceBO;
        }

    }

}
