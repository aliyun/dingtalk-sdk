// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class UpdateLiveInteractionPluginResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateLiveInteractionPluginResponseBodyResult result;

    public static UpdateLiveInteractionPluginResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateLiveInteractionPluginResponseBody self = new UpdateLiveInteractionPluginResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateLiveInteractionPluginResponseBody setResult(UpdateLiveInteractionPluginResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateLiveInteractionPluginResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateLiveInteractionPluginResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static UpdateLiveInteractionPluginResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateLiveInteractionPluginResponseBodyResult self = new UpdateLiveInteractionPluginResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateLiveInteractionPluginResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
