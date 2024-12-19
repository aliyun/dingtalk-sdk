// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class AddLiveInteractionPluginShrinkRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("liveId")
    public String liveId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pluginInfo")
    public String pluginInfoShrink;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static AddLiveInteractionPluginShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        AddLiveInteractionPluginShrinkRequest self = new AddLiveInteractionPluginShrinkRequest();
        return TeaModel.build(map, self);
    }

    public AddLiveInteractionPluginShrinkRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public AddLiveInteractionPluginShrinkRequest setPluginInfoShrink(String pluginInfoShrink) {
        this.pluginInfoShrink = pluginInfoShrink;
        return this;
    }
    public String getPluginInfoShrink() {
        return this.pluginInfoShrink;
    }

    public AddLiveInteractionPluginShrinkRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
