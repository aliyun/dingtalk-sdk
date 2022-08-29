// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class SendAgentOTOMessageResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("requestId")
    public String requestId;

    // 推送结果
    @NameInMap("result")
    public SendAgentOTOMessageResponseBodyResult result;

    public static SendAgentOTOMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendAgentOTOMessageResponseBody self = new SendAgentOTOMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendAgentOTOMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SendAgentOTOMessageResponseBody setResult(SendAgentOTOMessageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SendAgentOTOMessageResponseBodyResult getResult() {
        return this.result;
    }

    public static class SendAgentOTOMessageResponseBodyResult extends TeaModel {
        // 推送ID
        @NameInMap("openPushId")
        public String openPushId;

        public static SendAgentOTOMessageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SendAgentOTOMessageResponseBodyResult self = new SendAgentOTOMessageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SendAgentOTOMessageResponseBodyResult setOpenPushId(String openPushId) {
            this.openPushId = openPushId;
            return this;
        }
        public String getOpenPushId() {
            return this.openPushId;
        }

    }

}
