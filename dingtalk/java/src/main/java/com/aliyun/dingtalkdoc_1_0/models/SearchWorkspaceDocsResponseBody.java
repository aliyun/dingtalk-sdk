// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SearchWorkspaceDocsResponseBody extends TeaModel {
    @NameInMap("docs")
    public java.util.List<SearchWorkspaceDocsResponseBodyDocs> docs;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public String nextToken;

    public static SearchWorkspaceDocsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchWorkspaceDocsResponseBody self = new SearchWorkspaceDocsResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchWorkspaceDocsResponseBody setDocs(java.util.List<SearchWorkspaceDocsResponseBodyDocs> docs) {
        this.docs = docs;
        return this;
    }
    public java.util.List<SearchWorkspaceDocsResponseBodyDocs> getDocs() {
        return this.docs;
    }

    public SearchWorkspaceDocsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public SearchWorkspaceDocsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class SearchWorkspaceDocsResponseBodyDocsNodeBO extends TeaModel {
        @NameInMap("docType")
        public String docType;

        @NameInMap("lastEditTime")
        public Long lastEditTime;

        @NameInMap("name")
        public String name;

        @NameInMap("nodeId")
        public String nodeId;

        @NameInMap("originName")
        public String originName;

        @NameInMap("url")
        public String url;

        public static SearchWorkspaceDocsResponseBodyDocsNodeBO build(java.util.Map<String, ?> map) throws Exception {
            SearchWorkspaceDocsResponseBodyDocsNodeBO self = new SearchWorkspaceDocsResponseBodyDocsNodeBO();
            return TeaModel.build(map, self);
        }

        public SearchWorkspaceDocsResponseBodyDocsNodeBO setDocType(String docType) {
            this.docType = docType;
            return this;
        }
        public String getDocType() {
            return this.docType;
        }

        public SearchWorkspaceDocsResponseBodyDocsNodeBO setLastEditTime(Long lastEditTime) {
            this.lastEditTime = lastEditTime;
            return this;
        }
        public Long getLastEditTime() {
            return this.lastEditTime;
        }

        public SearchWorkspaceDocsResponseBodyDocsNodeBO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchWorkspaceDocsResponseBodyDocsNodeBO setNodeId(String nodeId) {
            this.nodeId = nodeId;
            return this;
        }
        public String getNodeId() {
            return this.nodeId;
        }

        public SearchWorkspaceDocsResponseBodyDocsNodeBO setOriginName(String originName) {
            this.originName = originName;
            return this;
        }
        public String getOriginName() {
            return this.originName;
        }

        public SearchWorkspaceDocsResponseBodyDocsNodeBO setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class SearchWorkspaceDocsResponseBodyDocsWorkspaceBO extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("workspaceId")
        public String workspaceId;

        public static SearchWorkspaceDocsResponseBodyDocsWorkspaceBO build(java.util.Map<String, ?> map) throws Exception {
            SearchWorkspaceDocsResponseBodyDocsWorkspaceBO self = new SearchWorkspaceDocsResponseBodyDocsWorkspaceBO();
            return TeaModel.build(map, self);
        }

        public SearchWorkspaceDocsResponseBodyDocsWorkspaceBO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchWorkspaceDocsResponseBodyDocsWorkspaceBO setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

    public static class SearchWorkspaceDocsResponseBodyDocs extends TeaModel {
        @NameInMap("nodeBO")
        public SearchWorkspaceDocsResponseBodyDocsNodeBO nodeBO;

        @NameInMap("workspaceBO")
        public SearchWorkspaceDocsResponseBodyDocsWorkspaceBO workspaceBO;

        public static SearchWorkspaceDocsResponseBodyDocs build(java.util.Map<String, ?> map) throws Exception {
            SearchWorkspaceDocsResponseBodyDocs self = new SearchWorkspaceDocsResponseBodyDocs();
            return TeaModel.build(map, self);
        }

        public SearchWorkspaceDocsResponseBodyDocs setNodeBO(SearchWorkspaceDocsResponseBodyDocsNodeBO nodeBO) {
            this.nodeBO = nodeBO;
            return this;
        }
        public SearchWorkspaceDocsResponseBodyDocsNodeBO getNodeBO() {
            return this.nodeBO;
        }

        public SearchWorkspaceDocsResponseBodyDocs setWorkspaceBO(SearchWorkspaceDocsResponseBodyDocsWorkspaceBO workspaceBO) {
            this.workspaceBO = workspaceBO;
            return this;
        }
        public SearchWorkspaceDocsResponseBodyDocsWorkspaceBO getWorkspaceBO() {
            return this.workspaceBO;
        }

    }

}
