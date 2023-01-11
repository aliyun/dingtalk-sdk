// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryJobRanksResponseBody extends TeaModel {
    /**
     * <p>是否有更多数据</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>职级列表</p>
     */
    @NameInMap("list")
    public java.util.List<QueryJobRanksResponseBodyList> list;

    /**
     * <p>表示当前调用返回读取到的位置，空代表数据已经读取完毕</p>
     */
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
         * <p>最大等级</p>
         */
        @NameInMap("maxJobGrade")
        public Integer maxJobGrade;

        /**
         * <p>最小等级</p>
         */
        @NameInMap("minJobGrade")
        public Integer minJobGrade;

        /**
         * <p>职级序列ID</p>
         */
        @NameInMap("rankCategoryId")
        public String rankCategoryId;

        /**
         * <p>职级编码</p>
         */
        @NameInMap("rankCode")
        public String rankCode;

        /**
         * <p>职级描述</p>
         */
        @NameInMap("rankDescription")
        public String rankDescription;

        /**
         * <p>职级ID</p>
         */
        @NameInMap("rankId")
        public String rankId;

        /**
         * <p>职级名称</p>
         */
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
