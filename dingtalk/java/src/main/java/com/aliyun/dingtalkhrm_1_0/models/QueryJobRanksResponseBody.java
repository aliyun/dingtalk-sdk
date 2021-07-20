// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryJobRanksResponseBody extends TeaModel {
    // 表示当前调用返回读取到的位置，空代表数据已经读取完毕
    @NameInMap("nextToken")
    public Long nextToken;

    // 是否有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 职级列表
    @NameInMap("list")
    public java.util.List<QueryJobRanksResponseBodyList> list;

    public static QueryJobRanksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryJobRanksResponseBody self = new QueryJobRanksResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryJobRanksResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
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

    public static class QueryJobRanksResponseBodyList extends TeaModel {
        // 职级ID
        @NameInMap("rankId")
        public String rankId;

        // 职级序列ID
        @NameInMap("rankCategoryId")
        public String rankCategoryId;

        // 职级编码
        @NameInMap("rankCode")
        public String rankCode;

        // 职级名称
        @NameInMap("rankName")
        public String rankName;

        // 最小等级
        @NameInMap("minJobGrade")
        public Integer minJobGrade;

        // 最大等级
        @NameInMap("maxJobGrade")
        public Integer maxJobGrade;

        // 职级描述
        @NameInMap("rankDescription")
        public String rankDescription;

        public static QueryJobRanksResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryJobRanksResponseBodyList self = new QueryJobRanksResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryJobRanksResponseBodyList setRankId(String rankId) {
            this.rankId = rankId;
            return this;
        }
        public String getRankId() {
            return this.rankId;
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

        public QueryJobRanksResponseBodyList setRankName(String rankName) {
            this.rankName = rankName;
            return this;
        }
        public String getRankName() {
            return this.rankName;
        }

        public QueryJobRanksResponseBodyList setMinJobGrade(Integer minJobGrade) {
            this.minJobGrade = minJobGrade;
            return this;
        }
        public Integer getMinJobGrade() {
            return this.minJobGrade;
        }

        public QueryJobRanksResponseBodyList setMaxJobGrade(Integer maxJobGrade) {
            this.maxJobGrade = maxJobGrade;
            return this;
        }
        public Integer getMaxJobGrade() {
            return this.maxJobGrade;
        }

        public QueryJobRanksResponseBodyList setRankDescription(String rankDescription) {
            this.rankDescription = rankDescription;
            return this;
        }
        public String getRankDescription() {
            return this.rankDescription;
        }

    }

}
