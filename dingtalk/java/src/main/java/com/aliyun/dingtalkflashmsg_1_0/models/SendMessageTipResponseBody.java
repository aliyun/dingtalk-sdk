// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class SendMessageTipResponseBody extends TeaModel {
    @NameInMap("result")
    public SendMessageTipResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SendMessageTipResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendMessageTipResponseBody self = new SendMessageTipResponseBody();
        return TeaModel.build(map, self);
    }

    public SendMessageTipResponseBody setResult(SendMessageTipResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SendMessageTipResponseBodyResult getResult() {
        return this.result;
    }

    public SendMessageTipResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SendMessageTipResponseBodyResult extends TeaModel {
        @NameInMap("bizId")
        public String bizId;

        @NameInMap("cardInstanceId")
        public String cardInstanceId;

        public static SendMessageTipResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SendMessageTipResponseBodyResult self = new SendMessageTipResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SendMessageTipResponseBodyResult setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public SendMessageTipResponseBodyResult setCardInstanceId(String cardInstanceId) {
            this.cardInstanceId = cardInstanceId;
            return this;
        }
        public String getCardInstanceId() {
            return this.cardInstanceId;
        }

    }

}
