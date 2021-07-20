// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryPositionsResponseBody extends TeaModel {
    // 表示当前调用返回读取到的位置，空代表数据已经读取完毕
    @NameInMap("nextToken")
    public Long nextToken;

    // 是否有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 职位列表
    @NameInMap("list")
    public java.util.List<QueryPositionsResponseBodyList> list;

    public static QueryPositionsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPositionsResponseBody self = new QueryPositionsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPositionsResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
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

    public static class QueryPositionsResponseBodyList extends TeaModel {
        // 职位ID
        @NameInMap("positionId")
        public String positionId;

        // 职位名称
        @NameInMap("positionName")
        public String positionName;

        // 职位类别ID
        @NameInMap("positionCategoryId")
        public String positionCategoryId;

        // 所属职务ID
        @NameInMap("jobId")
        public String jobId;

        // 职位描述
        @NameInMap("positionDes")
        public String positionDes;

        // 职位对应职级列表
        @NameInMap("rankIdList")
        public java.util.List<String> rankIdList;

        // 职位状态-0，启用；1，停用
        @NameInMap("status")
        public Integer status;

        public static QueryPositionsResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryPositionsResponseBodyList self = new QueryPositionsResponseBodyList();
            return TeaModel.build(map, self);
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

        public QueryPositionsResponseBodyList setPositionCategoryId(String positionCategoryId) {
            this.positionCategoryId = positionCategoryId;
            return this;
        }
        public String getPositionCategoryId() {
            return this.positionCategoryId;
        }

        public QueryPositionsResponseBodyList setJobId(String jobId) {
            this.jobId = jobId;
            return this;
        }
        public String getJobId() {
            return this.jobId;
        }

        public QueryPositionsResponseBodyList setPositionDes(String positionDes) {
            this.positionDes = positionDes;
            return this;
        }
        public String getPositionDes() {
            return this.positionDes;
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
