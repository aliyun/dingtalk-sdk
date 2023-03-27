// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SearchRequest extends TeaModel {
    /**
     * <p>节点搜索请求，和空间搜索请求二选一必填。</p>
     */
    @NameInMap("dentryRequest")
    public SearchRequestDentryRequest dentryRequest;

    /**
     * <p> 搜索关键词。</p>
     */
    @NameInMap("keyword")
    public String keyword;

    /**
     * <p>操作人unionId。</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <p>空间搜索请求，和节点搜索请求二选一必填。</p>
     */
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

    public static class SearchRequestDentryRequestVisitTimeRange extends TeaModel {
        /**
         * <p>结束时间戳（ms）。</p>
         */
        @NameInMap("end")
        public Long end;

        /**
         * <p>起始时间戳（ms）。</p>
         */
        @NameInMap("start")
        public Long start;

        public static SearchRequestDentryRequestVisitTimeRange build(java.util.Map<String, ?> map) throws Exception {
            SearchRequestDentryRequestVisitTimeRange self = new SearchRequestDentryRequestVisitTimeRange();
            return TeaModel.build(map, self);
        }

        public SearchRequestDentryRequestVisitTimeRange setEnd(Long end) {
            this.end = end;
            return this;
        }
        public Long getEnd() {
            return this.end;
        }

        public SearchRequestDentryRequestVisitTimeRange setStart(Long start) {
            this.start = start;
            return this;
        }
        public Long getStart() {
            return this.start;
        }

    }

    public static class SearchRequestDentryRequest extends TeaModel {
        /**
         * <p>每页最大条目数，最大值50。</p>
         */
        @NameInMap("maxResults")
        public Integer maxResults;

        /**
         * <p>分页游标。如果是首次调用，可不传；如果非首次调用，该参数传上次调用时返回的nextToken。</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        /**
         * <p>搜索的字段。支持的有：1-标题和内容；2-标题、内容和评论；3-标题和评论；4-标题；5-内容；6-评论。</p>
         */
        @NameInMap("searchField")
        public Integer searchField;

        /**
         * <p>搜索指定的文件类型。支持的类型有：1-文档；2-表格；3-脑图；4-演示；5-白板。</p>
         */
        @NameInMap("searchFileType")
        public Integer searchFileType;

        /**
         * <p>知识库id，在指定的知识库中搜索。</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <p>文档内容命中了搜索关键词的时候，需要返回的文档摘要长度。</p>
         */
        @NameInMap("summaryLength")
        public Integer summaryLength;

        /**
         * <p>文档访问时间的范围。</p>
         */
        @NameInMap("visitTimeRange")
        public SearchRequestDentryRequestVisitTimeRange visitTimeRange;

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

        public SearchRequestDentryRequest setSearchField(Integer searchField) {
            this.searchField = searchField;
            return this;
        }
        public Integer getSearchField() {
            return this.searchField;
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

        public SearchRequestDentryRequest setSummaryLength(Integer summaryLength) {
            this.summaryLength = summaryLength;
            return this;
        }
        public Integer getSummaryLength() {
            return this.summaryLength;
        }

        public SearchRequestDentryRequest setVisitTimeRange(SearchRequestDentryRequestVisitTimeRange visitTimeRange) {
            this.visitTimeRange = visitTimeRange;
            return this;
        }
        public SearchRequestDentryRequestVisitTimeRange getVisitTimeRange() {
            return this.visitTimeRange;
        }

    }

    public static class SearchRequestSpaceRequest extends TeaModel {
        /**
         * <p>每页最大条目数，最大值50。</p>
         */
        @NameInMap("maxResults")
        public Integer maxResults;

        /**
         * <p>分页游标。如果是首次调用，可不传；如果非首次调用，该参数传上次调用时返回的nextToken。</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        /**
         * <p>同时请求知识小组信息</p>
         */
        @NameInMap("withTeamInfo")
        public Boolean withTeamInfo;

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

        public SearchRequestSpaceRequest setWithTeamInfo(Boolean withTeamInfo) {
            this.withTeamInfo = withTeamInfo;
            return this;
        }
        public Boolean getWithTeamInfo() {
            return this.withTeamInfo;
        }

    }

}
