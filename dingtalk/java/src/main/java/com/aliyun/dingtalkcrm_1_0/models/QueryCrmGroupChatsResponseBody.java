// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmGroupChatsResponseBody extends TeaModel {
    /**
     * <p>是否还有下一页</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>下一页的游标</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>数据列表</p>
     */
    @NameInMap("resultList")
    public java.util.List<QueryCrmGroupChatsResponseBodyResultList> resultList;

    /**
     * <p>总条数，queryDsl入参为空时才会返回</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    public static QueryCrmGroupChatsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCrmGroupChatsResponseBody self = new QueryCrmGroupChatsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCrmGroupChatsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryCrmGroupChatsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryCrmGroupChatsResponseBody setResultList(java.util.List<QueryCrmGroupChatsResponseBodyResultList> resultList) {
        this.resultList = resultList;
        return this;
    }
    public java.util.List<QueryCrmGroupChatsResponseBodyResultList> getResultList() {
        return this.resultList;
    }

    public QueryCrmGroupChatsResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class QueryCrmGroupChatsResponseBodyResultList extends TeaModel {
        /**
         * <p>创建时间(时间戳)</p>
         */
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        /**
         * <p>客户群成员数</p>
         */
        @NameInMap("memberCount")
        public Integer memberCount;

        /**
         * <p>客户群名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>客户群openConversationId</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <p>群组openGroupSetId</p>
         */
        @NameInMap("openGroupSetId")
        public String openGroupSetId;

        /**
         * <p>群主userId</p>
         */
        @NameInMap("ownerUserId")
        public String ownerUserId;

        /**
         * <p>群主userName</p>
         */
        @NameInMap("ownerUserName")
        public String ownerUserName;

        public static QueryCrmGroupChatsResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            QueryCrmGroupChatsResponseBodyResultList self = new QueryCrmGroupChatsResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public QueryCrmGroupChatsResponseBodyResultList setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryCrmGroupChatsResponseBodyResultList setMemberCount(Integer memberCount) {
            this.memberCount = memberCount;
            return this;
        }
        public Integer getMemberCount() {
            return this.memberCount;
        }

        public QueryCrmGroupChatsResponseBodyResultList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryCrmGroupChatsResponseBodyResultList setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public QueryCrmGroupChatsResponseBodyResultList setOpenGroupSetId(String openGroupSetId) {
            this.openGroupSetId = openGroupSetId;
            return this;
        }
        public String getOpenGroupSetId() {
            return this.openGroupSetId;
        }

        public QueryCrmGroupChatsResponseBodyResultList setOwnerUserId(String ownerUserId) {
            this.ownerUserId = ownerUserId;
            return this;
        }
        public String getOwnerUserId() {
            return this.ownerUserId;
        }

        public QueryCrmGroupChatsResponseBodyResultList setOwnerUserName(String ownerUserName) {
            this.ownerUserName = ownerUserName;
            return this;
        }
        public String getOwnerUserName() {
            return this.ownerUserName;
        }

    }

}
