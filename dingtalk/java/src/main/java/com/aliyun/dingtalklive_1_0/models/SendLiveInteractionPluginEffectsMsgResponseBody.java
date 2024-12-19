// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SendLiveInteractionPluginEffectsMsgResponseBody extends TeaModel {
    @NameInMap("result")
    public SendLiveInteractionPluginEffectsMsgResponseBodyResult result;

    public static SendLiveInteractionPluginEffectsMsgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendLiveInteractionPluginEffectsMsgResponseBody self = new SendLiveInteractionPluginEffectsMsgResponseBody();
        return TeaModel.build(map, self);
    }

    public SendLiveInteractionPluginEffectsMsgResponseBody setResult(SendLiveInteractionPluginEffectsMsgResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SendLiveInteractionPluginEffectsMsgResponseBodyResult getResult() {
        return this.result;
    }

    public static class SendLiveInteractionPluginEffectsMsgResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static SendLiveInteractionPluginEffectsMsgResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SendLiveInteractionPluginEffectsMsgResponseBodyResult self = new SendLiveInteractionPluginEffectsMsgResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SendLiveInteractionPluginEffectsMsgResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
