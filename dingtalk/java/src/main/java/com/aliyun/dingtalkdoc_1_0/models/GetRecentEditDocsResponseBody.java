// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRecentEditDocsResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

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
        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("docType")
        public String docType;

        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("lastEditTime")
        public Long lastEditTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("nodeId")
        public String nodeId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("nodeName")
        public String nodeName;

        @NameInMap("updateTime")
        public Long updateTime;

        /**
         * <p>This parameter is required.</p>
         */
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
        @NameInMap("url")
        public String url;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workspaceId")
        public String workspaceId;

        /**
         * <p>This parameter is required.</p>
         */
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("nodeBO")
        public GetRecentEditDocsResponseBodyRecentListNodeBO nodeBO;

        /**
         * <p>This parameter is required.</p>
         */
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
