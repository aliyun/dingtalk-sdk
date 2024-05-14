// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ListFollowerResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public ListFollowerResponseBodyResult result;

    public static ListFollowerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListFollowerResponseBody self = new ListFollowerResponseBody();
        return TeaModel.build(map, self);
    }

    public ListFollowerResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public ListFollowerResponseBody setResult(ListFollowerResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListFollowerResponseBodyResult getResult() {
        return this.result;
    }

    public static class ListFollowerResponseBodyResultUserList extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("timestamp")
        public Long timestamp;

        @NameInMap("userId")
        public String userId;

        public static ListFollowerResponseBodyResultUserList build(java.util.Map<String, ?> map) throws Exception {
            ListFollowerResponseBodyResultUserList self = new ListFollowerResponseBodyResultUserList();
            return TeaModel.build(map, self);
        }

        public ListFollowerResponseBodyResultUserList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListFollowerResponseBodyResultUserList setTimestamp(Long timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public Long getTimestamp() {
            return this.timestamp;
        }

        public ListFollowerResponseBodyResultUserList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListFollowerResponseBodyResult extends TeaModel {
        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("userList")
        public java.util.List<ListFollowerResponseBodyResultUserList> userList;

        public static ListFollowerResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListFollowerResponseBodyResult self = new ListFollowerResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListFollowerResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public ListFollowerResponseBodyResult setUserList(java.util.List<ListFollowerResponseBodyResultUserList> userList) {
            this.userList = userList;
            return this;
        }
        public java.util.List<ListFollowerResponseBodyResultUserList> getUserList() {
            return this.userList;
        }

    }

}
