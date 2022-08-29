// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class SendInteractiveOTOMessageResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("requestId")
    public String requestId;

    // 推送结果
    @NameInMap("result")
    public SendInteractiveOTOMessageResponseBodyResult result;

    public static SendInteractiveOTOMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendInteractiveOTOMessageResponseBody self = new SendInteractiveOTOMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendInteractiveOTOMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SendInteractiveOTOMessageResponseBody setResult(SendInteractiveOTOMessageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SendInteractiveOTOMessageResponseBodyResult getResult() {
        return this.result;
    }

    public static class SendInteractiveOTOMessageResponseBodyResult extends TeaModel {
        // 推送ID
        @NameInMap("openPushId")
        public String openPushId;

        public static SendInteractiveOTOMessageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SendInteractiveOTOMessageResponseBodyResult self = new SendInteractiveOTOMessageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SendInteractiveOTOMessageResponseBodyResult setOpenPushId(String openPushId) {
            this.openPushId = openPushId;
            return this;
        }
        public String getOpenPushId() {
            return this.openPushId;
        }

    }

}
