// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SendLiveInteractionPluginEffectsMsgRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("count")
    public Long count;

    @NameInMap("lottieFileUrl")
    public String lottieFileUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("msgIconUrl")
    public String msgIconUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("msgText")
    public String msgText;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pluginSubId")
    public String pluginSubId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("senderUnionId")
    public String senderUnionId;

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

    public static SendLiveInteractionPluginEffectsMsgRequest build(java.util.Map<String, ?> map) throws Exception {
        SendLiveInteractionPluginEffectsMsgRequest self = new SendLiveInteractionPluginEffectsMsgRequest();
        return TeaModel.build(map, self);
    }

    public SendLiveInteractionPluginEffectsMsgRequest setCount(Long count) {
        this.count = count;
        return this;
    }
    public Long getCount() {
        return this.count;
    }

    public SendLiveInteractionPluginEffectsMsgRequest setLottieFileUrl(String lottieFileUrl) {
        this.lottieFileUrl = lottieFileUrl;
        return this;
    }
    public String getLottieFileUrl() {
        return this.lottieFileUrl;
    }

    public SendLiveInteractionPluginEffectsMsgRequest setMsgIconUrl(String msgIconUrl) {
        this.msgIconUrl = msgIconUrl;
        return this;
    }
    public String getMsgIconUrl() {
        return this.msgIconUrl;
    }

    public SendLiveInteractionPluginEffectsMsgRequest setMsgText(String msgText) {
        this.msgText = msgText;
        return this;
    }
    public String getMsgText() {
        return this.msgText;
    }

    public SendLiveInteractionPluginEffectsMsgRequest setPluginSubId(String pluginSubId) {
        this.pluginSubId = pluginSubId;
        return this;
    }
    public String getPluginSubId() {
        return this.pluginSubId;
    }

    public SendLiveInteractionPluginEffectsMsgRequest setSenderUnionId(String senderUnionId) {
        this.senderUnionId = senderUnionId;
        return this;
    }
    public String getSenderUnionId() {
        return this.senderUnionId;
    }

    public SendLiveInteractionPluginEffectsMsgRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public SendLiveInteractionPluginEffectsMsgRequest setPluginId(String pluginId) {
        this.pluginId = pluginId;
        return this;
    }
    public String getPluginId() {
        return this.pluginId;
    }

}
