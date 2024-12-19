// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class DelLiveInteractionPluginResponseBody extends TeaModel {
    @NameInMap("result")
    public DelLiveInteractionPluginResponseBodyResult result;

    public static DelLiveInteractionPluginResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DelLiveInteractionPluginResponseBody self = new DelLiveInteractionPluginResponseBody();
        return TeaModel.build(map, self);
    }

    public DelLiveInteractionPluginResponseBody setResult(DelLiveInteractionPluginResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DelLiveInteractionPluginResponseBodyResult getResult() {
        return this.result;
    }

    public static class DelLiveInteractionPluginResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static DelLiveInteractionPluginResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DelLiveInteractionPluginResponseBodyResult self = new DelLiveInteractionPluginResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DelLiveInteractionPluginResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
