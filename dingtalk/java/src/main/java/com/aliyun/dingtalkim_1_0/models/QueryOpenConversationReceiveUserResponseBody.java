// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryOpenConversationReceiveUserResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryOpenConversationReceiveUserResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryOpenConversationReceiveUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOpenConversationReceiveUserResponseBody self = new QueryOpenConversationReceiveUserResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOpenConversationReceiveUserResponseBody setResult(QueryOpenConversationReceiveUserResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryOpenConversationReceiveUserResponseBodyResult getResult() {
        return this.result;
    }

    public QueryOpenConversationReceiveUserResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryOpenConversationReceiveUserResponseBodyResultReceiveUser extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("icon")
        public String icon;

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
        @NameInMap("userId")
        public String userId;

        public static QueryOpenConversationReceiveUserResponseBodyResultReceiveUser build(java.util.Map<String, ?> map) throws Exception {
            QueryOpenConversationReceiveUserResponseBodyResultReceiveUser self = new QueryOpenConversationReceiveUserResponseBodyResultReceiveUser();
            return TeaModel.build(map, self);
        }

        public QueryOpenConversationReceiveUserResponseBodyResultReceiveUser setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public QueryOpenConversationReceiveUserResponseBodyResultReceiveUser setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryOpenConversationReceiveUserResponseBodyResultReceiveUser setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public QueryOpenConversationReceiveUserResponseBodyResultReceiveUser setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryOpenConversationReceiveUserResponseBodyResult extends TeaModel {
        @NameInMap("receiveUser")
        public QueryOpenConversationReceiveUserResponseBodyResultReceiveUser receiveUser;

        public static QueryOpenConversationReceiveUserResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryOpenConversationReceiveUserResponseBodyResult self = new QueryOpenConversationReceiveUserResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryOpenConversationReceiveUserResponseBodyResult setReceiveUser(QueryOpenConversationReceiveUserResponseBodyResultReceiveUser receiveUser) {
            this.receiveUser = receiveUser;
            return this;
        }
        public QueryOpenConversationReceiveUserResponseBodyResultReceiveUser getReceiveUser() {
            return this.receiveUser;
        }

    }

}
