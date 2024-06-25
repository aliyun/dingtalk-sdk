// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryJobRanksResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryJobRanksResponseBodyList> list;

    @NameInMap("nextToken")
    public Long nextToken;

    public static QueryJobRanksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryJobRanksResponseBody self = new QueryJobRanksResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryJobRanksResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryJobRanksResponseBody setList(java.util.List<QueryJobRanksResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryJobRanksResponseBodyList> getList() {
        return this.list;
    }

    public QueryJobRanksResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class QueryJobRanksResponseBodyList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>30</p>
         */
        @NameInMap("maxJobGrade")
        public Integer maxJobGrade;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("minJobGrade")
        public Integer minJobGrade;

        @NameInMap("rankCategoryId")
        public String rankCategoryId;

        @NameInMap("rankCode")
        public String rankCode;

        @NameInMap("rankDescription")
        public String rankDescription;

        @NameInMap("rankId")
        public String rankId;

        @NameInMap("rankName")
        public String rankName;

        public static QueryJobRanksResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryJobRanksResponseBodyList self = new QueryJobRanksResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryJobRanksResponseBodyList setMaxJobGrade(Integer maxJobGrade) {
            this.maxJobGrade = maxJobGrade;
            return this;
        }
        public Integer getMaxJobGrade() {
            return this.maxJobGrade;
        }

        public QueryJobRanksResponseBodyList setMinJobGrade(Integer minJobGrade) {
            this.minJobGrade = minJobGrade;
            return this;
        }
        public Integer getMinJobGrade() {
            return this.minJobGrade;
        }

        public QueryJobRanksResponseBodyList setRankCategoryId(String rankCategoryId) {
            this.rankCategoryId = rankCategoryId;
            return this;
        }
        public String getRankCategoryId() {
            return this.rankCategoryId;
        }

        public QueryJobRanksResponseBodyList setRankCode(String rankCode) {
            this.rankCode = rankCode;
            return this;
        }
        public String getRankCode() {
            return this.rankCode;
        }

        public QueryJobRanksResponseBodyList setRankDescription(String rankDescription) {
            this.rankDescription = rankDescription;
            return this;
        }
        public String getRankDescription() {
            return this.rankDescription;
        }

        public QueryJobRanksResponseBodyList setRankId(String rankId) {
            this.rankId = rankId;
            return this;
        }
        public String getRankId() {
            return this.rankId;
        }

        public QueryJobRanksResponseBodyList setRankName(String rankName) {
            this.rankName = rankName;
            return this;
        }
        public String getRankName() {
            return this.rankName;
        }

    }

}
