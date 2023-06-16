// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SearchRequest extends TeaModel {
    @NameInMap("dentryRequest")
    public SearchRequestDentryRequest dentryRequest;

    @NameInMap("keyword")
    public String keyword;

    @NameInMap("operatorId")
    public String operatorId;

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
        @NameInMap("end")
        public Long end;

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
        @NameInMap("maxResults")
        public Integer maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("searchField")
        public Integer searchField;

        @NameInMap("searchFileType")
        public Integer searchFileType;

        @NameInMap("spaceId")
        public String spaceId;

        @NameInMap("spaceIds")
        public java.util.List<String> spaceIds;

        @NameInMap("summaryLength")
        public Integer summaryLength;

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

        public SearchRequestDentryRequest setSpaceIds(java.util.List<String> spaceIds) {
            this.spaceIds = spaceIds;
            return this;
        }
        public java.util.List<String> getSpaceIds() {
            return this.spaceIds;
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
        @NameInMap("maxResults")
        public Integer maxResults;

        @NameInMap("nextToken")
        public String nextToken;

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
