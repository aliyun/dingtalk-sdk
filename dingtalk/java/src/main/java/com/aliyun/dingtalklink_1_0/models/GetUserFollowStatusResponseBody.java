// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetUserFollowStatusResponseBody extends TeaModel {
    /**
     * <p>响应结果</p>
     */
    @NameInMap("result")
    public GetUserFollowStatusResponseBodyResult result;

    public static GetUserFollowStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserFollowStatusResponseBody self = new GetUserFollowStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserFollowStatusResponseBody setResult(GetUserFollowStatusResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetUserFollowStatusResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetUserFollowStatusResponseBodyResult extends TeaModel {
        /**
         * <p>用户关注服务窗的状态:</p>
         * <p>FOLLOWED：已关注。</p>
         * <p>UNFOLLOW：未关注。</p>
         */
        @NameInMap("status")
        public String status;

        public static GetUserFollowStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetUserFollowStatusResponseBodyResult self = new GetUserFollowStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetUserFollowStatusResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
