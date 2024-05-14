// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class CallbackRegiesterResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public CallbackRegiesterResponseBodyResult result;

    public static CallbackRegiesterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CallbackRegiesterResponseBody self = new CallbackRegiesterResponseBody();
        return TeaModel.build(map, self);
    }

    public CallbackRegiesterResponseBody setResult(CallbackRegiesterResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CallbackRegiesterResponseBodyResult getResult() {
        return this.result;
    }

    public static class CallbackRegiesterResponseBodyResult extends TeaModel {
        @NameInMap("apiSecret")
        public String apiSecret;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("callbackUrl")
        public String callbackUrl;

        public static CallbackRegiesterResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CallbackRegiesterResponseBodyResult self = new CallbackRegiesterResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CallbackRegiesterResponseBodyResult setApiSecret(String apiSecret) {
            this.apiSecret = apiSecret;
            return this;
        }
        public String getApiSecret() {
            return this.apiSecret;
        }

        public CallbackRegiesterResponseBodyResult setCallbackUrl(String callbackUrl) {
            this.callbackUrl = callbackUrl;
            return this;
        }
        public String getCallbackUrl() {
            return this.callbackUrl;
        }

    }

}
