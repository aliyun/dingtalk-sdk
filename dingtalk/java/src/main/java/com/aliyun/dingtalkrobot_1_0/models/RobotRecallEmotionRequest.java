// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotRecallEmotionRequest extends TeaModel {
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
    public RobotRecallEmotionRequestTextEmotion textEmotion;

    public static RobotRecallEmotionRequest build(java.util.Map<String, ?> map) throws Exception {
        RobotRecallEmotionRequest self = new RobotRecallEmotionRequest();
        return TeaModel.build(map, self);
    }

    public RobotRecallEmotionRequest setEmotionName(String emotionName) {
        this.emotionName = emotionName;
        return this;
    }
    public String getEmotionName() {
        return this.emotionName;
    }

    public RobotRecallEmotionRequest setEmotionType(Integer emotionType) {
        this.emotionType = emotionType;
        return this;
    }
    public Integer getEmotionType() {
        return this.emotionType;
    }

    public RobotRecallEmotionRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public RobotRecallEmotionRequest setOpenMsgId(String openMsgId) {
        this.openMsgId = openMsgId;
        return this;
    }
    public String getOpenMsgId() {
        return this.openMsgId;
    }

    public RobotRecallEmotionRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public RobotRecallEmotionRequest setTextEmotion(RobotRecallEmotionRequestTextEmotion textEmotion) {
        this.textEmotion = textEmotion;
        return this;
    }
    public RobotRecallEmotionRequestTextEmotion getTextEmotion() {
        return this.textEmotion;
    }

    public static class RobotRecallEmotionRequestTextEmotion extends TeaModel {
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

        public static RobotRecallEmotionRequestTextEmotion build(java.util.Map<String, ?> map) throws Exception {
            RobotRecallEmotionRequestTextEmotion self = new RobotRecallEmotionRequestTextEmotion();
            return TeaModel.build(map, self);
        }

        public RobotRecallEmotionRequestTextEmotion setBackgroundId(String backgroundId) {
            this.backgroundId = backgroundId;
            return this;
        }
        public String getBackgroundId() {
            return this.backgroundId;
        }

        public RobotRecallEmotionRequestTextEmotion setEmotionId(String emotionId) {
            this.emotionId = emotionId;
            return this;
        }
        public String getEmotionId() {
            return this.emotionId;
        }

        public RobotRecallEmotionRequestTextEmotion setEmotionName(String emotionName) {
            this.emotionName = emotionName;
            return this;
        }
        public String getEmotionName() {
            return this.emotionName;
        }

        public RobotRecallEmotionRequestTextEmotion setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

}
