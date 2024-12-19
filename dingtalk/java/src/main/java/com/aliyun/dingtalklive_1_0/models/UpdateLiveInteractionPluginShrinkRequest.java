// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class UpdateLiveInteractionPluginShrinkRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("liveId")
    public String liveId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pluginId")
    public String pluginId;

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

    public static UpdateLiveInteractionPluginShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateLiveInteractionPluginShrinkRequest self = new UpdateLiveInteractionPluginShrinkRequest();
        return TeaModel.build(map, self);
    }

    public UpdateLiveInteractionPluginShrinkRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public UpdateLiveInteractionPluginShrinkRequest setPluginId(String pluginId) {
        this.pluginId = pluginId;
        return this;
    }
    public String getPluginId() {
        return this.pluginId;
    }

    public UpdateLiveInteractionPluginShrinkRequest setPluginInfoShrink(String pluginInfoShrink) {
        this.pluginInfoShrink = pluginInfoShrink;
        return this;
    }
    public String getPluginInfoShrink() {
        return this.pluginInfoShrink;
    }

    public UpdateLiveInteractionPluginShrinkRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
