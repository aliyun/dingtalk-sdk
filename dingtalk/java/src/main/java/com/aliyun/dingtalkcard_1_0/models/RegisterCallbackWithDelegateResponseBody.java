// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class RegisterCallbackWithDelegateResponseBody extends TeaModel {
    @NameInMap("result")
    public RegisterCallbackWithDelegateResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static RegisterCallbackWithDelegateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RegisterCallbackWithDelegateResponseBody self = new RegisterCallbackWithDelegateResponseBody();
        return TeaModel.build(map, self);
    }

    public RegisterCallbackWithDelegateResponseBody setResult(RegisterCallbackWithDelegateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public RegisterCallbackWithDelegateResponseBodyResult getResult() {
        return this.result;
    }

    public RegisterCallbackWithDelegateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class RegisterCallbackWithDelegateResponseBodyResult extends TeaModel {
        @NameInMap("apiSecret")
        public String apiSecret;

        @NameInMap("callbackUrl")
        public String callbackUrl;

        public static RegisterCallbackWithDelegateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            RegisterCallbackWithDelegateResponseBodyResult self = new RegisterCallbackWithDelegateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public RegisterCallbackWithDelegateResponseBodyResult setApiSecret(String apiSecret) {
            this.apiSecret = apiSecret;
            return this;
        }
        public String getApiSecret() {
            return this.apiSecret;
        }

        public RegisterCallbackWithDelegateResponseBodyResult setCallbackUrl(String callbackUrl) {
            this.callbackUrl = callbackUrl;
            return this;
        }
        public String getCallbackUrl() {
            return this.callbackUrl;
        }

    }

}
