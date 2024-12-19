// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SendLivePluginUserActionMsgRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("liveId")
    public String liveId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pluginEffectsMessage")
    public SendLivePluginUserActionMsgRequestPluginEffectsMessage pluginEffectsMessage;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pluginId")
    public String pluginId;

    public static SendLivePluginUserActionMsgRequest build(java.util.Map<String, ?> map) throws Exception {
        SendLivePluginUserActionMsgRequest self = new SendLivePluginUserActionMsgRequest();
        return TeaModel.build(map, self);
    }

    public SendLivePluginUserActionMsgRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public SendLivePluginUserActionMsgRequest setPluginEffectsMessage(SendLivePluginUserActionMsgRequestPluginEffectsMessage pluginEffectsMessage) {
        this.pluginEffectsMessage = pluginEffectsMessage;
        return this;
    }
    public SendLivePluginUserActionMsgRequestPluginEffectsMessage getPluginEffectsMessage() {
        return this.pluginEffectsMessage;
    }

    public SendLivePluginUserActionMsgRequest setPluginId(String pluginId) {
        this.pluginId = pluginId;
        return this;
    }
    public String getPluginId() {
        return this.pluginId;
    }

    public static class SendLivePluginUserActionMsgRequestPluginEffectsMessage extends TeaModel {
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

        public static SendLivePluginUserActionMsgRequestPluginEffectsMessage build(java.util.Map<String, ?> map) throws Exception {
            SendLivePluginUserActionMsgRequestPluginEffectsMessage self = new SendLivePluginUserActionMsgRequestPluginEffectsMessage();
            return TeaModel.build(map, self);
        }

        public SendLivePluginUserActionMsgRequestPluginEffectsMessage setCount(Long count) {
            this.count = count;
            return this;
        }
        public Long getCount() {
            return this.count;
        }

        public SendLivePluginUserActionMsgRequestPluginEffectsMessage setLottieFileUrl(String lottieFileUrl) {
            this.lottieFileUrl = lottieFileUrl;
            return this;
        }
        public String getLottieFileUrl() {
            return this.lottieFileUrl;
        }

        public SendLivePluginUserActionMsgRequestPluginEffectsMessage setMsgIconUrl(String msgIconUrl) {
            this.msgIconUrl = msgIconUrl;
            return this;
        }
        public String getMsgIconUrl() {
            return this.msgIconUrl;
        }

        public SendLivePluginUserActionMsgRequestPluginEffectsMessage setMsgText(String msgText) {
            this.msgText = msgText;
            return this;
        }
        public String getMsgText() {
            return this.msgText;
        }

        public SendLivePluginUserActionMsgRequestPluginEffectsMessage setPluginSubId(String pluginSubId) {
            this.pluginSubId = pluginSubId;
            return this;
        }
        public String getPluginSubId() {
            return this.pluginSubId;
        }

        public SendLivePluginUserActionMsgRequestPluginEffectsMessage setSenderUnionId(String senderUnionId) {
            this.senderUnionId = senderUnionId;
            return this;
        }
        public String getSenderUnionId() {
            return this.senderUnionId;
        }

    }

}
