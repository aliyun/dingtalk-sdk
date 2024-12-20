// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class UpdateLiveInteractionPluginRequest extends TeaModel {
    @NameInMap("anchorJumpUrl")
    public String anchorJumpUrl;

    @NameInMap("pluginIconUrl")
    public String pluginIconUrl;

    @NameInMap("pluginName")
    public String pluginName;

    @NameInMap("pluginNameEn")
    public String pluginNameEn;

    @NameInMap("viewerJumpUrl")
    public String viewerJumpUrl;

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
    @NameInMap("unionId")
    public String unionId;

    public static UpdateLiveInteractionPluginRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateLiveInteractionPluginRequest self = new UpdateLiveInteractionPluginRequest();
        return TeaModel.build(map, self);
    }

    public UpdateLiveInteractionPluginRequest setAnchorJumpUrl(String anchorJumpUrl) {
        this.anchorJumpUrl = anchorJumpUrl;
        return this;
    }
    public String getAnchorJumpUrl() {
        return this.anchorJumpUrl;
    }

    public UpdateLiveInteractionPluginRequest setPluginIconUrl(String pluginIconUrl) {
        this.pluginIconUrl = pluginIconUrl;
        return this;
    }
    public String getPluginIconUrl() {
        return this.pluginIconUrl;
    }

    public UpdateLiveInteractionPluginRequest setPluginName(String pluginName) {
        this.pluginName = pluginName;
        return this;
    }
    public String getPluginName() {
        return this.pluginName;
    }

    public UpdateLiveInteractionPluginRequest setPluginNameEn(String pluginNameEn) {
        this.pluginNameEn = pluginNameEn;
        return this;
    }
    public String getPluginNameEn() {
        return this.pluginNameEn;
    }

    public UpdateLiveInteractionPluginRequest setViewerJumpUrl(String viewerJumpUrl) {
        this.viewerJumpUrl = viewerJumpUrl;
        return this;
    }
    public String getViewerJumpUrl() {
        return this.viewerJumpUrl;
    }

    public UpdateLiveInteractionPluginRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public UpdateLiveInteractionPluginRequest setPluginId(String pluginId) {
        this.pluginId = pluginId;
        return this;
    }
    public String getPluginId() {
        return this.pluginId;
    }

    public UpdateLiveInteractionPluginRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
