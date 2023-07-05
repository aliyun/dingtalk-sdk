// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkblackboard_1_0.models;

import com.aliyun.tea.*;

public class QueryBlackboardReadUnReadResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("users")
    public java.util.List<QueryBlackboardReadUnReadResponseBodyUsers> users;

    public static QueryBlackboardReadUnReadResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBlackboardReadUnReadResponseBody self = new QueryBlackboardReadUnReadResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBlackboardReadUnReadResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryBlackboardReadUnReadResponseBody setUsers(java.util.List<QueryBlackboardReadUnReadResponseBodyUsers> users) {
        this.users = users;
        return this;
    }
    public java.util.List<QueryBlackboardReadUnReadResponseBodyUsers> getUsers() {
        return this.users;
    }

    public static class QueryBlackboardReadUnReadResponseBodyUsers extends TeaModel {
        @NameInMap("read")
        public String read;

        @NameInMap("readTimestamp")
        public Long readTimestamp;

        @NameInMap("userId")
        public String userId;

        public static QueryBlackboardReadUnReadResponseBodyUsers build(java.util.Map<String, ?> map) throws Exception {
            QueryBlackboardReadUnReadResponseBodyUsers self = new QueryBlackboardReadUnReadResponseBodyUsers();
            return TeaModel.build(map, self);
        }

        public QueryBlackboardReadUnReadResponseBodyUsers setRead(String read) {
            this.read = read;
            return this;
        }
        public String getRead() {
            return this.read;
        }

        public QueryBlackboardReadUnReadResponseBodyUsers setReadTimestamp(Long readTimestamp) {
            this.readTimestamp = readTimestamp;
            return this;
        }
        public Long getReadTimestamp() {
            return this.readTimestamp;
        }

        public QueryBlackboardReadUnReadResponseBodyUsers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
