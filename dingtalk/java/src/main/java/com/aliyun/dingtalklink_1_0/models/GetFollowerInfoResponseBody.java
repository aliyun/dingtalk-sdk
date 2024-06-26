// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetFollowerInfoResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
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
        /**
         * <strong>example:</strong>
         * <p>小钉</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>1661918406748</p>
         */
        @NameInMap("timestamp")
        public String timestamp;

        /**
         * <strong>example:</strong>
         * <p>userId</p>
         */
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
