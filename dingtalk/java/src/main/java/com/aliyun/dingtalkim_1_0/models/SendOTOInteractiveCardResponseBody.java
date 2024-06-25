// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendOTOInteractiveCardResponseBody extends TeaModel {
    @NameInMap("result")
    public SendOTOInteractiveCardResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SendOTOInteractiveCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendOTOInteractiveCardResponseBody self = new SendOTOInteractiveCardResponseBody();
        return TeaModel.build(map, self);
    }

    public SendOTOInteractiveCardResponseBody setResult(SendOTOInteractiveCardResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SendOTOInteractiveCardResponseBodyResult getResult() {
        return this.result;
    }

    public SendOTOInteractiveCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SendOTOInteractiveCardResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>xxxxxx</p>
         */
        @NameInMap("processQueryKey")
        public String processQueryKey;

        public static SendOTOInteractiveCardResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SendOTOInteractiveCardResponseBodyResult self = new SendOTOInteractiveCardResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SendOTOInteractiveCardResponseBodyResult setProcessQueryKey(String processQueryKey) {
            this.processQueryKey = processQueryKey;
            return this;
        }
        public String getProcessQueryKey() {
            return this.processQueryKey;
        }

    }

}
