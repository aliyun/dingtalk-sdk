// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SearchWorkspaceDocsResponseBody extends TeaModel {
    // 是否还有可搜索内容
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("loadMoreId")
    public String loadMoreId;

    @NameInMap("docs")
    public java.util.List<SearchWorkspaceDocsResponseBodyDocs> docs;

    public static SearchWorkspaceDocsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchWorkspaceDocsResponseBody self = new SearchWorkspaceDocsResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchWorkspaceDocsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public SearchWorkspaceDocsResponseBody setLoadMoreId(String loadMoreId) {
        this.loadMoreId = loadMoreId;
        return this;
    }
    public String getLoadMoreId() {
        return this.loadMoreId;
    }

    public SearchWorkspaceDocsResponseBody setDocs(java.util.List<SearchWorkspaceDocsResponseBodyDocs> docs) {
        this.docs = docs;
        return this;
    }
    public java.util.List<SearchWorkspaceDocsResponseBodyDocs> getDocs() {
        return this.docs;
    }

    public static class SearchWorkspaceDocsResponseBodyDocsNodeBO extends TeaModel {
        // 节点名称
        @NameInMap("name")
        public String name;

        // 节点Id
        @NameInMap("nodeId")
        public String nodeId;

        // 节点打开url
        @NameInMap("url")
        public String url;

        // 最近编辑时间
        @NameInMap("lastEditTime")
        public Long lastEditTime;

        public static SearchWorkspaceDocsResponseBodyDocsNodeBO build(java.util.Map<String, ?> map) throws Exception {
            SearchWorkspaceDocsResponseBodyDocsNodeBO self = new SearchWorkspaceDocsResponseBodyDocsNodeBO();
            return TeaModel.build(map, self);
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

        public SearchWorkspaceDocsResponseBodyDocsNodeBO setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public SearchWorkspaceDocsResponseBodyDocsNodeBO setLastEditTime(Long lastEditTime) {
            this.lastEditTime = lastEditTime;
            return this;
        }
        public Long getLastEditTime() {
            return this.lastEditTime;
        }

    }

    public static class SearchWorkspaceDocsResponseBodyDocsWorkspaceBO extends TeaModel {
        // 团队空间Id
        @NameInMap("workspaceId")
        public String workspaceId;

        // 团队空间名称
        @NameInMap("name")
        public String name;

        public static SearchWorkspaceDocsResponseBodyDocsWorkspaceBO build(java.util.Map<String, ?> map) throws Exception {
            SearchWorkspaceDocsResponseBodyDocsWorkspaceBO self = new SearchWorkspaceDocsResponseBodyDocsWorkspaceBO();
            return TeaModel.build(map, self);
        }

        public SearchWorkspaceDocsResponseBodyDocsWorkspaceBO setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

        public SearchWorkspaceDocsResponseBodyDocsWorkspaceBO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
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
