// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SearchRequest extends TeaModel {
    // 节点搜索请求，和空间搜索请求二选一必填。
    @NameInMap("dentryRequest")
    public SearchRequestDentryRequest dentryRequest;

    //  搜索关键词。
    @NameInMap("keyword")
    public String keyword;

    // 操作人unionId。
    @NameInMap("operatorId")
    public String operatorId;

    // 空间搜索请求，和节点搜索请求二选一必填。
    @NameInMap("spaceRequest")
    public SearchRequestSpaceRequest spaceRequest;

    public static SearchRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchRequest self = new SearchRequest();
        return TeaModel.build(map, self);
    }

    public SearchRequest setDentryRequest(SearchRequestDentryRequest dentryRequest) {
        this.dentryRequest = dentryRequest;
        return this;
    }
    public SearchRequestDentryRequest getDentryRequest() {
        return this.dentryRequest;
    }

    public SearchRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public SearchRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public SearchRequest setSpaceRequest(SearchRequestSpaceRequest spaceRequest) {
        this.spaceRequest = spaceRequest;
        return this;
    }
    public SearchRequestSpaceRequest getSpaceRequest() {
        return this.spaceRequest;
    }

    public static class SearchRequestDentryRequest extends TeaModel {
        // 每页最大条目数，最大值50。
        @NameInMap("maxResults")
        public Integer maxResults;

        // 分页游标。如果是首次调用，可不传；如果非首次调用，该参数传上次调用时返回的nextToken。
        @NameInMap("nextToken")
        public String nextToken;

        // 搜索指定的文件类型。支持的类型有：1-文档；2-表格；3-脑图；4-演示；5-白板。
        @NameInMap("searchFileType")
        public Integer searchFileType;

        // 知识库id，在指定的知识库中搜索。
        @NameInMap("spaceId")
        public String spaceId;

        public static SearchRequestDentryRequest build(java.util.Map<String, ?> map) throws Exception {
            SearchRequestDentryRequest self = new SearchRequestDentryRequest();
            return TeaModel.build(map, self);
        }

        public SearchRequestDentryRequest setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public SearchRequestDentryRequest setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public SearchRequestDentryRequest setSearchFileType(Integer searchFileType) {
            this.searchFileType = searchFileType;
            return this;
        }
        public Integer getSearchFileType() {
            return this.searchFileType;
        }

        public SearchRequestDentryRequest setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

    public static class SearchRequestSpaceRequest extends TeaModel {
        // 每页最大条目数，最大值50。
        @NameInMap("maxResults")
        public Integer maxResults;

        // 分页游标。如果是首次调用，可不传；如果非首次调用，该参数传上次调用时返回的nextToken。
        @NameInMap("nextToken")
        public String nextToken;

        public static SearchRequestSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
            SearchRequestSpaceRequest self = new SearchRequestSpaceRequest();
            return TeaModel.build(map, self);
        }

        public SearchRequestSpaceRequest setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public SearchRequestSpaceRequest setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
