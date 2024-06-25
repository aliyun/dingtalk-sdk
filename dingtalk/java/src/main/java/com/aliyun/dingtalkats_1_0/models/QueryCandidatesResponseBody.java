// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class QueryCandidatesResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryCandidatesResponseBodyList> list;

    /**
     * <strong>example:</strong>
     * <p>xxxxxx</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryCandidatesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCandidatesResponseBody self = new QueryCandidatesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCandidatesResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryCandidatesResponseBody setList(java.util.List<QueryCandidatesResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryCandidatesResponseBodyList> getList() {
        return this.list;
    }

    public QueryCandidatesResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryCandidatesResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryCandidatesResponseBodyList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>64167133e3394c6b9959eexxxxxxxxxx</p>
         */
        @NameInMap("candidateId")
        public String candidateId;

        /**
         * <strong>example:</strong>
         * <p>ding2c0158xxxxxxxxxx</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>1701014400000</p>
         */
        @NameInMap("entryDate")
        public Integer entryDate;

        /**
         * <strong>example:</strong>
         * <p>013224566462xxxxxxxxxx</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryCandidatesResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryCandidatesResponseBodyList self = new QueryCandidatesResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryCandidatesResponseBodyList setCandidateId(String candidateId) {
            this.candidateId = candidateId;
            return this;
        }
        public String getCandidateId() {
            return this.candidateId;
        }

        public QueryCandidatesResponseBodyList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryCandidatesResponseBodyList setEntryDate(Integer entryDate) {
            this.entryDate = entryDate;
            return this;
        }
        public Integer getEntryDate() {
            return this.entryDate;
        }

        public QueryCandidatesResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
