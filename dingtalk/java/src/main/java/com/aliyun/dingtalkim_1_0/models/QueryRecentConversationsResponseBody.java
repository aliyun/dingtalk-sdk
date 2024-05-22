// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryRecentConversationsResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryRecentConversationsResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryRecentConversationsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRecentConversationsResponseBody self = new QueryRecentConversationsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRecentConversationsResponseBody setResult(QueryRecentConversationsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryRecentConversationsResponseBodyResult getResult() {
        return this.result;
    }

    public QueryRecentConversationsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryRecentConversationsResponseBodyResultConversationList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("conversationType")
        public Integer conversationType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("memberCount")
        public String memberCount;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("nickName")
        public String nickName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryRecentConversationsResponseBodyResultConversationList build(java.util.Map<String, ?> map) throws Exception {
            QueryRecentConversationsResponseBodyResultConversationList self = new QueryRecentConversationsResponseBodyResultConversationList();
            return TeaModel.build(map, self);
        }

        public QueryRecentConversationsResponseBodyResultConversationList setConversationType(Integer conversationType) {
            this.conversationType = conversationType;
            return this;
        }
        public Integer getConversationType() {
            return this.conversationType;
        }

        public QueryRecentConversationsResponseBodyResultConversationList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public QueryRecentConversationsResponseBodyResultConversationList setMemberCount(String memberCount) {
            this.memberCount = memberCount;
            return this;
        }
        public String getMemberCount() {
            return this.memberCount;
        }

        public QueryRecentConversationsResponseBodyResultConversationList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryRecentConversationsResponseBodyResultConversationList setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public QueryRecentConversationsResponseBodyResultConversationList setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public QueryRecentConversationsResponseBodyResultConversationList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public QueryRecentConversationsResponseBodyResultConversationList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryRecentConversationsResponseBodyResult extends TeaModel {
        @NameInMap("conversationList")
        public java.util.List<QueryRecentConversationsResponseBodyResultConversationList> conversationList;

        public static QueryRecentConversationsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryRecentConversationsResponseBodyResult self = new QueryRecentConversationsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryRecentConversationsResponseBodyResult setConversationList(java.util.List<QueryRecentConversationsResponseBodyResultConversationList> conversationList) {
            this.conversationList = conversationList;
            return this;
        }
        public java.util.List<QueryRecentConversationsResponseBodyResultConversationList> getConversationList() {
            return this.conversationList;
        }

    }

}
