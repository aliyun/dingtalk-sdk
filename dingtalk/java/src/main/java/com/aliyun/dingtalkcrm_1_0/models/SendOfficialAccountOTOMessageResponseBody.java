// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SendOfficialAccountOTOMessageResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public SendOfficialAccountOTOMessageResponseBodyResult result;

    public static SendOfficialAccountOTOMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendOfficialAccountOTOMessageResponseBody self = new SendOfficialAccountOTOMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendOfficialAccountOTOMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SendOfficialAccountOTOMessageResponseBody setResult(SendOfficialAccountOTOMessageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SendOfficialAccountOTOMessageResponseBodyResult getResult() {
        return this.result;
    }

    public static class SendOfficialAccountOTOMessageResponseBodyResult extends TeaModel {
        @NameInMap("openPushId")
        public String openPushId;

        public static SendOfficialAccountOTOMessageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SendOfficialAccountOTOMessageResponseBodyResult self = new SendOfficialAccountOTOMessageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SendOfficialAccountOTOMessageResponseBodyResult setOpenPushId(String openPushId) {
            this.openPushId = openPushId;
            return this;
        }
        public String getOpenPushId() {
            return this.openPushId;
        }

    }

}
