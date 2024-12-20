// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class AddLiveInteractionPluginRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("anchorJumpUrl")
    public String anchorJumpUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pluginIconUrl")
    public String pluginIconUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pluginName")
    public String pluginName;

    @NameInMap("pluginNameEn")
    public String pluginNameEn;

    /**
     * <p>This parameter is required.</p>
     */
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
    @NameInMap("unionId")
    public String unionId;

    public static AddLiveInteractionPluginRequest build(java.util.Map<String, ?> map) throws Exception {
        AddLiveInteractionPluginRequest self = new AddLiveInteractionPluginRequest();
        return TeaModel.build(map, self);
    }

    public AddLiveInteractionPluginRequest setAnchorJumpUrl(String anchorJumpUrl) {
        this.anchorJumpUrl = anchorJumpUrl;
        return this;
    }
    public String getAnchorJumpUrl() {
        return this.anchorJumpUrl;
    }

    public AddLiveInteractionPluginRequest setPluginIconUrl(String pluginIconUrl) {
        this.pluginIconUrl = pluginIconUrl;
        return this;
    }
    public String getPluginIconUrl() {
        return this.pluginIconUrl;
    }

    public AddLiveInteractionPluginRequest setPluginName(String pluginName) {
        this.pluginName = pluginName;
        return this;
    }
    public String getPluginName() {
        return this.pluginName;
    }

    public AddLiveInteractionPluginRequest setPluginNameEn(String pluginNameEn) {
        this.pluginNameEn = pluginNameEn;
        return this;
    }
    public String getPluginNameEn() {
        return this.pluginNameEn;
    }

    public AddLiveInteractionPluginRequest setViewerJumpUrl(String viewerJumpUrl) {
        this.viewerJumpUrl = viewerJumpUrl;
        return this;
    }
    public String getViewerJumpUrl() {
        return this.viewerJumpUrl;
    }

    public AddLiveInteractionPluginRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public AddLiveInteractionPluginRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
