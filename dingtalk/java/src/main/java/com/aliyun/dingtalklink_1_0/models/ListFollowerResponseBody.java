// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ListFollowerResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("requestId")
    public String requestId;

    // 响应结果
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
        // 关注者昵称
        @NameInMap("name")
        public String name;

        // 关注时间 
        @NameInMap("timestamp")
        public Long timestamp;

        // 关注者userId，可用于消息推送等场景。
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
        // 下一页查询位置
        // 当此返回值为空时，则说明全部数据查询完成。
        // 当此返回值不为空时，可以将此值设置为下一次查询的参数。
        @NameInMap("nextToken")
        public String nextToken;

        // 用户列表
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
