// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class TiktokWebhookProcessResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("omniChannelTiktokWebhookRsp")
    public TiktokWebhookProcessResponseBodyOmniChannelTiktokWebhookRsp omniChannelTiktokWebhookRsp;

    @NameInMap("success")
    public String success;

    public static TiktokWebhookProcessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TiktokWebhookProcessResponseBody self = new TiktokWebhookProcessResponseBody();
        return TeaModel.build(map, self);
    }

    public TiktokWebhookProcessResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public TiktokWebhookProcessResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public TiktokWebhookProcessResponseBody setOmniChannelTiktokWebhookRsp(TiktokWebhookProcessResponseBodyOmniChannelTiktokWebhookRsp omniChannelTiktokWebhookRsp) {
        this.omniChannelTiktokWebhookRsp = omniChannelTiktokWebhookRsp;
        return this;
    }
    public TiktokWebhookProcessResponseBodyOmniChannelTiktokWebhookRsp getOmniChannelTiktokWebhookRsp() {
        return this.omniChannelTiktokWebhookRsp;
    }

    public TiktokWebhookProcessResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class TiktokWebhookProcessResponseBodyOmniChannelTiktokWebhookRsp extends TeaModel {
        @NameInMap("code")
        public String code;

        public static TiktokWebhookProcessResponseBodyOmniChannelTiktokWebhookRsp build(java.util.Map<String, ?> map) throws Exception {
            TiktokWebhookProcessResponseBodyOmniChannelTiktokWebhookRsp self = new TiktokWebhookProcessResponseBodyOmniChannelTiktokWebhookRsp();
            return TeaModel.build(map, self);
        }

        public TiktokWebhookProcessResponseBodyOmniChannelTiktokWebhookRsp setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

    }

}
