// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class RegisterCallbackResponseBody extends TeaModel {
    @NameInMap("result")
    public RegisterCallbackResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static RegisterCallbackResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RegisterCallbackResponseBody self = new RegisterCallbackResponseBody();
        return TeaModel.build(map, self);
    }

    public RegisterCallbackResponseBody setResult(RegisterCallbackResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public RegisterCallbackResponseBodyResult getResult() {
        return this.result;
    }

    public RegisterCallbackResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class RegisterCallbackResponseBodyResult extends TeaModel {
        /**
         * <p>api 签名密钥</p>
         */
        @NameInMap("apiSecret")
        public String apiSecret;

        /**
         * <p>ISV 接受动态卡片点击的回调地址</p>
         */
        @NameInMap("callbackUrl")
        public String callbackUrl;

        public static RegisterCallbackResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            RegisterCallbackResponseBodyResult self = new RegisterCallbackResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public RegisterCallbackResponseBodyResult setApiSecret(String apiSecret) {
            this.apiSecret = apiSecret;
            return this;
        }
        public String getApiSecret() {
            return this.apiSecret;
        }

        public RegisterCallbackResponseBodyResult setCallbackUrl(String callbackUrl) {
            this.callbackUrl = callbackUrl;
            return this;
        }
        public String getCallbackUrl() {
            return this.callbackUrl;
        }

    }

}
