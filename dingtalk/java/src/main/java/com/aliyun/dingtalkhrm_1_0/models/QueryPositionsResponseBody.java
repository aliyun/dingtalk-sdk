// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryPositionsResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryPositionsResponseBodyList> list;

    @NameInMap("nextToken")
    public Long nextToken;

    public static QueryPositionsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPositionsResponseBody self = new QueryPositionsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPositionsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryPositionsResponseBody setList(java.util.List<QueryPositionsResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryPositionsResponseBodyList> getList() {
        return this.list;
    }

    public QueryPositionsResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public static class QueryPositionsResponseBodyList extends TeaModel {
        @NameInMap("jobId")
        public String jobId;

        @NameInMap("positionCategoryId")
        public String positionCategoryId;

        @NameInMap("positionDes")
        public String positionDes;

        /**
         * <strong>example:</strong>
         * <p>ac67286db74c48e28d787173ccc1a111</p>
         */
        @NameInMap("positionId")
        public String positionId;

        @NameInMap("positionName")
        public String positionName;

        @NameInMap("rankIdList")
        public java.util.List<String> rankIdList;

        @NameInMap("status")
        public Integer status;

        public static QueryPositionsResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryPositionsResponseBodyList self = new QueryPositionsResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryPositionsResponseBodyList setJobId(String jobId) {
            this.jobId = jobId;
            return this;
        }
        public String getJobId() {
            return this.jobId;
        }

        public QueryPositionsResponseBodyList setPositionCategoryId(String positionCategoryId) {
            this.positionCategoryId = positionCategoryId;
            return this;
        }
        public String getPositionCategoryId() {
            return this.positionCategoryId;
        }

        public QueryPositionsResponseBodyList setPositionDes(String positionDes) {
            this.positionDes = positionDes;
            return this;
        }
        public String getPositionDes() {
            return this.positionDes;
        }

        public QueryPositionsResponseBodyList setPositionId(String positionId) {
            this.positionId = positionId;
            return this;
        }
        public String getPositionId() {
            return this.positionId;
        }

        public QueryPositionsResponseBodyList setPositionName(String positionName) {
            this.positionName = positionName;
            return this;
        }
        public String getPositionName() {
            return this.positionName;
        }

        public QueryPositionsResponseBodyList setRankIdList(java.util.List<String> rankIdList) {
            this.rankIdList = rankIdList;
            return this;
        }
        public java.util.List<String> getRankIdList() {
            return this.rankIdList;
        }

        public QueryPositionsResponseBodyList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

}
