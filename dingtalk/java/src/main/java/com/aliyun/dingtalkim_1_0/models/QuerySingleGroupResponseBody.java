// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QuerySingleGroupResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversations")
    public java.util.List<QuerySingleGroupResponseBodyOpenConversations> openConversations;

    public static QuerySingleGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySingleGroupResponseBody self = new QuerySingleGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySingleGroupResponseBody setOpenConversations(java.util.List<QuerySingleGroupResponseBodyOpenConversations> openConversations) {
        this.openConversations = openConversations;
        return this;
    }
    public java.util.List<QuerySingleGroupResponseBodyOpenConversations> getOpenConversations() {
        return this.openConversations;
    }

    public static class QuerySingleGroupResponseBodyOpenConversations extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("appUserId")
        public String appUserId;

        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QuerySingleGroupResponseBodyOpenConversations build(java.util.Map<String, ?> map) throws Exception {
            QuerySingleGroupResponseBodyOpenConversations self = new QuerySingleGroupResponseBodyOpenConversations();
            return TeaModel.build(map, self);
        }

        public QuerySingleGroupResponseBodyOpenConversations setAppUserId(String appUserId) {
            this.appUserId = appUserId;
            return this;
        }
        public String getAppUserId() {
            return this.appUserId;
        }

        public QuerySingleGroupResponseBodyOpenConversations setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public QuerySingleGroupResponseBodyOpenConversations setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
