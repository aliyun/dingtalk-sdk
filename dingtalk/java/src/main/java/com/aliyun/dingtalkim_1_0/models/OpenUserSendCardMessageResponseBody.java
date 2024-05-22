// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenUserSendCardMessageResponseBody extends TeaModel {
    @NameInMap("result")
    public OpenUserSendCardMessageResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static OpenUserSendCardMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenUserSendCardMessageResponseBody self = new OpenUserSendCardMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenUserSendCardMessageResponseBody setResult(OpenUserSendCardMessageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public OpenUserSendCardMessageResponseBodyResult getResult() {
        return this.result;
    }

    public OpenUserSendCardMessageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class OpenUserSendCardMessageResponseBodyResult extends TeaModel {
        @NameInMap("openTaskId")
        public String openTaskId;

        public static OpenUserSendCardMessageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            OpenUserSendCardMessageResponseBodyResult self = new OpenUserSendCardMessageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public OpenUserSendCardMessageResponseBodyResult setOpenTaskId(String openTaskId) {
            this.openTaskId = openTaskId;
            return this;
        }
        public String getOpenTaskId() {
            return this.openTaskId;
        }

    }

}
