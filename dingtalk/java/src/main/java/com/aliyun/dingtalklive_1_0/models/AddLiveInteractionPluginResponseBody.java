// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class AddLiveInteractionPluginResponseBody extends TeaModel {
    @NameInMap("result")
    public AddLiveInteractionPluginResponseBodyResult result;

    public static AddLiveInteractionPluginResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddLiveInteractionPluginResponseBody self = new AddLiveInteractionPluginResponseBody();
        return TeaModel.build(map, self);
    }

    public AddLiveInteractionPluginResponseBody setResult(AddLiveInteractionPluginResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddLiveInteractionPluginResponseBodyResult getResult() {
        return this.result;
    }

    public static class AddLiveInteractionPluginResponseBodyResult extends TeaModel {
        @NameInMap("pluginId")
        public String pluginId;

        public static AddLiveInteractionPluginResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddLiveInteractionPluginResponseBodyResult self = new AddLiveInteractionPluginResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddLiveInteractionPluginResponseBodyResult setPluginId(String pluginId) {
            this.pluginId = pluginId;
            return this;
        }
        public String getPluginId() {
            return this.pluginId;
        }

    }

}
