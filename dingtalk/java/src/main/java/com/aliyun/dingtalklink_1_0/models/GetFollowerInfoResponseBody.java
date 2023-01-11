// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetFollowerInfoResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>响应结果</p>
     */
    @NameInMap("result")
    public GetFollowerInfoResponseBodyResult result;

    public static GetFollowerInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFollowerInfoResponseBody self = new GetFollowerInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFollowerInfoResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetFollowerInfoResponseBody setResult(GetFollowerInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetFollowerInfoResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetFollowerInfoResponseBodyResultUser extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("timestamp")
        public String timestamp;

        @NameInMap("userId")
        public String userId;

        public static GetFollowerInfoResponseBodyResultUser build(java.util.Map<String, ?> map) throws Exception {
            GetFollowerInfoResponseBodyResultUser self = new GetFollowerInfoResponseBodyResultUser();
            return TeaModel.build(map, self);
        }

        public GetFollowerInfoResponseBodyResultUser setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetFollowerInfoResponseBodyResultUser setTimestamp(String timestamp) {
            this.timestamp = timestamp;
            return this;
        }
        public String getTimestamp() {
            return this.timestamp;
        }

        public GetFollowerInfoResponseBodyResultUser setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetFollowerInfoResponseBodyResult extends TeaModel {
        @NameInMap("user")
        public GetFollowerInfoResponseBodyResultUser user;

        public static GetFollowerInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFollowerInfoResponseBodyResult self = new GetFollowerInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFollowerInfoResponseBodyResult setUser(GetFollowerInfoResponseBodyResultUser user) {
            this.user = user;
            return this;
        }
        public GetFollowerInfoResponseBodyResultUser getUser() {
            return this.user;
        }

    }

}
