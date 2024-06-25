// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SearchDentriesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>keyword</p>
     */
    @NameInMap("keyword")
    public String keyword;

    @NameInMap("option")
    public SearchDentriesRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static SearchDentriesRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchDentriesRequest self = new SearchDentriesRequest();
        return TeaModel.build(map, self);
    }

    public SearchDentriesRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public SearchDentriesRequest setOption(SearchDentriesRequestOption option) {
        this.option = option;
        return this;
    }
    public SearchDentriesRequestOption getOption() {
        return this.option;
    }

    public SearchDentriesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class SearchDentriesRequestOptionCreateTimeRange extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>end_time</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <strong>example:</strong>
         * <p>start_time</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        public static SearchDentriesRequestOptionCreateTimeRange build(java.util.Map<String, ?> map) throws Exception {
            SearchDentriesRequestOptionCreateTimeRange self = new SearchDentriesRequestOptionCreateTimeRange();
            return TeaModel.build(map, self);
        }

        public SearchDentriesRequestOptionCreateTimeRange setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public SearchDentriesRequestOptionCreateTimeRange setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

    }

    public static class SearchDentriesRequestOptionVisitTimeRange extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>end_time</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <strong>example:</strong>
         * <p>start_time</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        public static SearchDentriesRequestOptionVisitTimeRange build(java.util.Map<String, ?> map) throws Exception {
            SearchDentriesRequestOptionVisitTimeRange self = new SearchDentriesRequestOptionVisitTimeRange();
            return TeaModel.build(map, self);
        }

        public SearchDentriesRequestOptionVisitTimeRange setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public SearchDentriesRequestOptionVisitTimeRange setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

    }

    public static class SearchDentriesRequestOption extends TeaModel {
        @NameInMap("createTimeRange")
        public SearchDentriesRequestOptionCreateTimeRange createTimeRange;

        @NameInMap("creatorIds")
        public java.util.List<String> creatorIds;

        @NameInMap("dentryCategories")
        public java.util.List<String> dentryCategories;

        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("maxResults")
        public Integer maxResults;

        @NameInMap("modifierIds")
        public java.util.List<String> modifierIds;

        /**
         * <strong>example:</strong>
         * <p>next_token</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("visitTimeRange")
        public SearchDentriesRequestOptionVisitTimeRange visitTimeRange;

        public static SearchDentriesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            SearchDentriesRequestOption self = new SearchDentriesRequestOption();
            return TeaModel.build(map, self);
        }

        public SearchDentriesRequestOption setCreateTimeRange(SearchDentriesRequestOptionCreateTimeRange createTimeRange) {
            this.createTimeRange = createTimeRange;
            return this;
        }
        public SearchDentriesRequestOptionCreateTimeRange getCreateTimeRange() {
            return this.createTimeRange;
        }

        public SearchDentriesRequestOption setCreatorIds(java.util.List<String> creatorIds) {
            this.creatorIds = creatorIds;
            return this;
        }
        public java.util.List<String> getCreatorIds() {
            return this.creatorIds;
        }

        public SearchDentriesRequestOption setDentryCategories(java.util.List<String> dentryCategories) {
            this.dentryCategories = dentryCategories;
            return this;
        }
        public java.util.List<String> getDentryCategories() {
            return this.dentryCategories;
        }

        public SearchDentriesRequestOption setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public SearchDentriesRequestOption setModifierIds(java.util.List<String> modifierIds) {
            this.modifierIds = modifierIds;
            return this;
        }
        public java.util.List<String> getModifierIds() {
            return this.modifierIds;
        }

        public SearchDentriesRequestOption setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public SearchDentriesRequestOption setVisitTimeRange(SearchDentriesRequestOptionVisitTimeRange visitTimeRange) {
            this.visitTimeRange = visitTimeRange;
            return this;
        }
        public SearchDentriesRequestOptionVisitTimeRange getVisitTimeRange() {
            return this.visitTimeRange;
        }

    }

}
