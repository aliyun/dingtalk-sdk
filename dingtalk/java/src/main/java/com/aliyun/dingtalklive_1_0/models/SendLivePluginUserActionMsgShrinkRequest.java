// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SendLivePluginUserActionMsgShrinkRequest extends TeaModel {
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

    public static SendLivePluginUserActionMsgShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        SendLivePluginUserActionMsgShrinkRequest self = new SendLivePluginUserActionMsgShrinkRequest();
        return TeaModel.build(map, self);
    }

    public SendLivePluginUserActionMsgShrinkRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public SendLivePluginUserActionMsgShrinkRequest setPluginEffectsMessageShrink(String pluginEffectsMessageShrink) {
        this.pluginEffectsMessageShrink = pluginEffectsMessageShrink;
        return this;
    }
    public String getPluginEffectsMessageShrink() {
        return this.pluginEffectsMessageShrink;
    }

    public SendLivePluginUserActionMsgShrinkRequest setPluginId(String pluginId) {
        this.pluginId = pluginId;
        return this;
    }
    public String getPluginId() {
        return this.pluginId;
    }

}
