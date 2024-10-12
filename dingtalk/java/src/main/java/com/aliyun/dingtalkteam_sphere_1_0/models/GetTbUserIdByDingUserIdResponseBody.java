// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetTbUserIdByDingUserIdResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<GetTbUserIdByDingUserIdResponseBodyResult> result;

    public static GetTbUserIdByDingUserIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTbUserIdByDingUserIdResponseBody self = new GetTbUserIdByDingUserIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTbUserIdByDingUserIdResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetTbUserIdByDingUserIdResponseBody setResult(java.util.List<GetTbUserIdByDingUserIdResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetTbUserIdByDingUserIdResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetTbUserIdByDingUserIdResponseBodyResult extends TeaModel {
        @NameInMap("dingtalkUserId")
        public String dingtalkUserId;

        @NameInMap("tbUserId")
        public String tbUserId;

        public static GetTbUserIdByDingUserIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetTbUserIdByDingUserIdResponseBodyResult self = new GetTbUserIdByDingUserIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetTbUserIdByDingUserIdResponseBodyResult setDingtalkUserId(String dingtalkUserId) {
            this.dingtalkUserId = dingtalkUserId;
            return this;
        }
        public String getDingtalkUserId() {
            return this.dingtalkUserId;
        }

        public GetTbUserIdByDingUserIdResponseBodyResult setTbUserId(String tbUserId) {
            this.tbUserId = tbUserId;
            return this;
        }
        public String getTbUserId() {
            return this.tbUserId;
        }

    }

}
