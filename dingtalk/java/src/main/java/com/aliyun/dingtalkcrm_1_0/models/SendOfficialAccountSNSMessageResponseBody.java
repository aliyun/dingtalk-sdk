// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SendOfficialAccountSNSMessageResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("requestId")
    public String requestId;

    // 推送结果
    @NameInMap("result")
    public SendOfficialAccountSNSMessageResponseBodyResult result;

    public static SendOfficialAccountSNSMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendOfficialAccountSNSMessageResponseBody self = new SendOfficialAccountSNSMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendOfficialAccountSNSMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SendOfficialAccountSNSMessageResponseBody setResult(SendOfficialAccountSNSMessageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SendOfficialAccountSNSMessageResponseBodyResult getResult() {
        return this.result;
    }

    public static class SendOfficialAccountSNSMessageResponseBodyResult extends TeaModel {
        // 推送ID
        @NameInMap("openPushId")
        public String openPushId;

        public static SendOfficialAccountSNSMessageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountSNSMessageResponseBodyResult self = new SendOfficialAccountSNSMessageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountSNSMessageResponseBodyResult setOpenPushId(String openPushId) {
            this.openPushId = openPushId;
            return this;
        }
        public String getOpenPushId() {
            return this.openPushId;
        }

    }

}
