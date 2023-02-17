// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryCorpUserStatisticResponseBody extends TeaModel {
    /**
     * <p>是否还有更多数据</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryCorpUserStatisticResponseBodyList> list;

    /**
     * <p>下一游标</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>总数</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryCorpUserStatisticResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpUserStatisticResponseBody self = new QueryCorpUserStatisticResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCorpUserStatisticResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryCorpUserStatisticResponseBody setList(java.util.List<QueryCorpUserStatisticResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryCorpUserStatisticResponseBodyList> getList() {
        return this.list;
    }

    public QueryCorpUserStatisticResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryCorpUserStatisticResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryCorpUserStatisticResponseBodyList extends TeaModel {
        /**
         * <p>用户头像</p>
         */
        @NameInMap("avatarUrl")
        public String avatarUrl;

        /**
         * <p>用户名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>收下数</p>
         */
        @NameInMap("receiveCnt")
        public Long receiveCnt;

        /**
         * <p>发送数</p>
         */
        @NameInMap("sendCnt")
        public Long sendCnt;

        /**
         * <p>用户id</p>
         * <br>
         */
        @NameInMap("unionId")
        public String unionId;

        public static QueryCorpUserStatisticResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryCorpUserStatisticResponseBodyList self = new QueryCorpUserStatisticResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryCorpUserStatisticResponseBodyList setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public QueryCorpUserStatisticResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryCorpUserStatisticResponseBodyList setReceiveCnt(Long receiveCnt) {
            this.receiveCnt = receiveCnt;
            return this;
        }
        public Long getReceiveCnt() {
            return this.receiveCnt;
        }

        public QueryCorpUserStatisticResponseBodyList setSendCnt(Long sendCnt) {
            this.sendCnt = sendCnt;
            return this;
        }
        public Long getSendCnt() {
            return this.sendCnt;
        }

        public QueryCorpUserStatisticResponseBodyList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
