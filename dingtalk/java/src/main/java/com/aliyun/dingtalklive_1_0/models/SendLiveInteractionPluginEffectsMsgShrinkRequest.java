// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SendLiveInteractionPluginEffectsMsgShrinkRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("liveId")
    public String liveId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pluginEffectsMessage")
    public String pluginEffectsMessageShrink;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pluginId")
    public String pluginId;

    public static SendLiveInteractionPluginEffectsMsgShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        SendLiveInteractionPluginEffectsMsgShrinkRequest self = new SendLiveInteractionPluginEffectsMsgShrinkRequest();
        return TeaModel.build(map, self);
    }

    public SendLiveInteractionPluginEffectsMsgShrinkRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public SendLiveInteractionPluginEffectsMsgShrinkRequest setPluginEffectsMessageShrink(String pluginEffectsMessageShrink) {
        this.pluginEffectsMessageShrink = pluginEffectsMessageShrink;
        return this;
    }
    public String getPluginEffectsMessageShrink() {
        return this.pluginEffectsMessageShrink;
    }

    public SendLiveInteractionPluginEffectsMsgShrinkRequest setPluginId(String pluginId) {
        this.pluginId = pluginId;
        return this;
    }
    public String getPluginId() {
        return this.pluginId;
    }

}
