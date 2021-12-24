// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmGroupChatsResponseBody extends TeaModel {
    // 数据列表
    @NameInMap("resultList")
    public java.util.List<QueryCrmGroupChatsResponseBodyResultList> resultList;

    // 是否还有下一页
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 下一页的游标
    @NameInMap("nextToken")
    public String nextToken;

    // 总条数，queryDsl入参为空时才会返回
    @NameInMap("totalCount")
    public Integer totalCount;

    public static QueryCrmGroupChatsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCrmGroupChatsResponseBody self = new QueryCrmGroupChatsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCrmGroupChatsResponseBody setResultList(java.util.List<QueryCrmGroupChatsResponseBodyResultList> resultList) {
        this.resultList = resultList;
        return this;
    }
    public java.util.List<QueryCrmGroupChatsResponseBodyResultList> getResultList() {
        return this.resultList;
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

    public QueryCrmGroupChatsResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class QueryCrmGroupChatsResponseBodyResultList extends TeaModel {
        // 客户群chatId
        @NameInMap("chatId")
        public String chatId;

        // 客户群openConversationId
        @NameInMap("openConversationId")
        public String openConversationId;

        // 群组openGroupSetId
        @NameInMap("openGroupSetId")
        public String openGroupSetId;

        // 群主userId
        @NameInMap("ownerUserId")
        public String ownerUserId;

        // 群主userName
        @NameInMap("ownerUserName")
        public String ownerUserName;

        // 客户群名
        @NameInMap("name")
        public String name;

        // 客户群成员数
        @NameInMap("memberCount")
        public Integer memberCount;

        // 创建时间(时间戳)
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        public static QueryCrmGroupChatsResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            QueryCrmGroupChatsResponseBodyResultList self = new QueryCrmGroupChatsResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public QueryCrmGroupChatsResponseBodyResultList setChatId(String chatId) {
            this.chatId = chatId;
            return this;
        }
        public String getChatId() {
            return this.chatId;
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

        public QueryCrmGroupChatsResponseBodyResultList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryCrmGroupChatsResponseBodyResultList setMemberCount(Integer memberCount) {
            this.memberCount = memberCount;
            return this;
        }
        public Integer getMemberCount() {
            return this.memberCount;
        }

        public QueryCrmGroupChatsResponseBodyResultList setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

    }

}
