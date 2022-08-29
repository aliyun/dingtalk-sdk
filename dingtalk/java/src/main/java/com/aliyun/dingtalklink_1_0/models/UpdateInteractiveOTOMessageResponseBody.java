// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class UpdateInteractiveOTOMessageResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("requestId")
    public String requestId;

    // 推送结果
    @NameInMap("result")
    public UpdateInteractiveOTOMessageResponseBodyResult result;

    public static UpdateInteractiveOTOMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInteractiveOTOMessageResponseBody self = new UpdateInteractiveOTOMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInteractiveOTOMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public UpdateInteractiveOTOMessageResponseBody setResult(UpdateInteractiveOTOMessageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateInteractiveOTOMessageResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateInteractiveOTOMessageResponseBodyResult extends TeaModel {
        // 推送ID
        @NameInMap("openPushId")
        public String openPushId;

        public static UpdateInteractiveOTOMessageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateInteractiveOTOMessageResponseBodyResult self = new UpdateInteractiveOTOMessageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateInteractiveOTOMessageResponseBodyResult setOpenPushId(String openPushId) {
            this.openPushId = openPushId;
            return this;
        }
        public String getOpenPushId() {
            return this.openPushId;
        }

    }

}
