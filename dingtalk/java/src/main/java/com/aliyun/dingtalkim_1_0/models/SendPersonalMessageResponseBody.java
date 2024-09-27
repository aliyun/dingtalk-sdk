// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendPersonalMessageResponseBody extends TeaModel {
    @NameInMap("result")
    public SendPersonalMessageResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static SendPersonalMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendPersonalMessageResponseBody self = new SendPersonalMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendPersonalMessageResponseBody setResult(SendPersonalMessageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SendPersonalMessageResponseBodyResult getResult() {
        return this.result;
    }

    public SendPersonalMessageResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class SendPersonalMessageResponseBodyResult extends TeaModel {
        @NameInMap("openTaskId")
        public String openTaskId;

        public static SendPersonalMessageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SendPersonalMessageResponseBodyResult self = new SendPersonalMessageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SendPersonalMessageResponseBodyResult setOpenTaskId(String openTaskId) {
            this.openTaskId = openTaskId;
            return this;
        }
        public String getOpenTaskId() {
            return this.openTaskId;
        }

    }

}
