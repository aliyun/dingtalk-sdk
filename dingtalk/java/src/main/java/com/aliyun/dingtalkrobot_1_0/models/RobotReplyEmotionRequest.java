// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotReplyEmotionRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>OK</p>
     */
    @NameInMap("emotionName")
    public String emotionName;

    @NameInMap("emotionType")
    public Integer emotionType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxx</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>msgxxxx</p>
     */
    @NameInMap("openMsgId")
    public String openMsgId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>213123</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    @NameInMap("textEmotion")
    public RobotReplyEmotionRequestTextEmotion textEmotion;

    public static RobotReplyEmotionRequest build(java.util.Map<String, ?> map) throws Exception {
        RobotReplyEmotionRequest self = new RobotReplyEmotionRequest();
        return TeaModel.build(map, self);
    }

    public RobotReplyEmotionRequest setEmotionName(String emotionName) {
        this.emotionName = emotionName;
        return this;
    }
    public String getEmotionName() {
        return this.emotionName;
    }

    public RobotReplyEmotionRequest setEmotionType(Integer emotionType) {
        this.emotionType = emotionType;
        return this;
    }
    public Integer getEmotionType() {
        return this.emotionType;
    }

    public RobotReplyEmotionRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public RobotReplyEmotionRequest setOpenMsgId(String openMsgId) {
        this.openMsgId = openMsgId;
        return this;
    }
    public String getOpenMsgId() {
        return this.openMsgId;
    }

    public RobotReplyEmotionRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public RobotReplyEmotionRequest setTextEmotion(RobotReplyEmotionRequestTextEmotion textEmotion) {
        this.textEmotion = textEmotion;
        return this;
    }
    public RobotReplyEmotionRequestTextEmotion getTextEmotion() {
        return this.textEmotion;
    }

    public static class RobotReplyEmotionRequestTextEmotion extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>im_bg_1</p>
         */
        @NameInMap("backgroundId")
        public String backgroundId;

        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
        @NameInMap("emotionId")
        public String emotionId;

        /**
         * <strong>example:</strong>
         * <p>OK</p>
         */
        @NameInMap("emotionName")
        public String emotionName;

        /**
         * <strong>example:</strong>
         * <p>OK</p>
         */
        @NameInMap("text")
        public String text;

        public static RobotReplyEmotionRequestTextEmotion build(java.util.Map<String, ?> map) throws Exception {
            RobotReplyEmotionRequestTextEmotion self = new RobotReplyEmotionRequestTextEmotion();
            return TeaModel.build(map, self);
        }

        public RobotReplyEmotionRequestTextEmotion setBackgroundId(String backgroundId) {
            this.backgroundId = backgroundId;
            return this;
        }
        public String getBackgroundId() {
            return this.backgroundId;
        }

        public RobotReplyEmotionRequestTextEmotion setEmotionId(String emotionId) {
            this.emotionId = emotionId;
            return this;
        }
        public String getEmotionId() {
            return this.emotionId;
        }

        public RobotReplyEmotionRequestTextEmotion setEmotionName(String emotionName) {
            this.emotionName = emotionName;
            return this;
        }
        public String getEmotionName() {
            return this.emotionName;
        }

        public RobotReplyEmotionRequestTextEmotion setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

}
