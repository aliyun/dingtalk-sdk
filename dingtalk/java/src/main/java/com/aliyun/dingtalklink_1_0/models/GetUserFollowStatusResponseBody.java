// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetUserFollowStatusResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
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
