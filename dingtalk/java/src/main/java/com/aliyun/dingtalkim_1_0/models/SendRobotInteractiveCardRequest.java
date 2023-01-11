// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendRobotInteractiveCardRequest extends TeaModel {
    /**
     * <p>可交互卡片回调的url【可空：不填写无需回调】</p>
     */
    @NameInMap("callbackUrl")
    public String callbackUrl;

    /**
     * <p>唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】</p>
     */
    @NameInMap("cardBizId")
    public String cardBizId;

    /**
     * <p>卡片模板-文本内容参数（卡片json结构体）</p>
     */
    @NameInMap("cardData")
    public String cardData;

    /**
     * <p>卡片搭建平台模板ID</p>
     */
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    /**
     * <p>【openConversationId & singleChatReceiver 二选一必填】接收卡片的加密群ID，特指多人群会话（非单聊）</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>是否开启卡片纯拉模式</p>
     */
    @NameInMap("pullStrategy")
    public Boolean pullStrategy;

    /**
     * <p>机器人代码，群模板机器人网页有机器人ID；企业内部机器人为机器人appKey，企业三方机器人有robotCode</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    /**
     * <p>互动卡片发送选项</p>
     */
    @NameInMap("sendOptions")
    public SendRobotInteractiveCardRequestSendOptions sendOptions;

    /**
     * <p>【openConversationId & singleChatReceiver 二选一必填】单聊会话接受者json串</p>
     */
    @NameInMap("singleChatReceiver")
    public String singleChatReceiver;

    /**
     * <p>卡片模板-userId差异用户参数（json结构体）</p>
     */
    @NameInMap("unionIdPrivateDataMap")
    public String unionIdPrivateDataMap;

    /**
     * <p>卡片模板-userId差异用户参数（json结构体）</p>
     */
    @NameInMap("userIdPrivateDataMap")
    public String userIdPrivateDataMap;

    public static SendRobotInteractiveCardRequest build(java.util.Map<String, ?> map) throws Exception {
        SendRobotInteractiveCardRequest self = new SendRobotInteractiveCardRequest();
        return TeaModel.build(map, self);
    }

    public SendRobotInteractiveCardRequest setCallbackUrl(String callbackUrl) {
        this.callbackUrl = callbackUrl;
        return this;
    }
    public String getCallbackUrl() {
        return this.callbackUrl;
    }

    public SendRobotInteractiveCardRequest setCardBizId(String cardBizId) {
        this.cardBizId = cardBizId;
        return this;
    }
    public String getCardBizId() {
        return this.cardBizId;
    }

    public SendRobotInteractiveCardRequest setCardData(String cardData) {
        this.cardData = cardData;
        return this;
    }
    public String getCardData() {
        return this.cardData;
    }

    public SendRobotInteractiveCardRequest setCardTemplateId(String cardTemplateId) {
        this.cardTemplateId = cardTemplateId;
        return this;
    }
    public String getCardTemplateId() {
        return this.cardTemplateId;
    }

    public SendRobotInteractiveCardRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendRobotInteractiveCardRequest setPullStrategy(Boolean pullStrategy) {
        this.pullStrategy = pullStrategy;
        return this;
    }
    public Boolean getPullStrategy() {
        return this.pullStrategy;
    }

    public SendRobotInteractiveCardRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public SendRobotInteractiveCardRequest setSendOptions(SendRobotInteractiveCardRequestSendOptions sendOptions) {
        this.sendOptions = sendOptions;
        return this;
    }
    public SendRobotInteractiveCardRequestSendOptions getSendOptions() {
        return this.sendOptions;
    }

    public SendRobotInteractiveCardRequest setSingleChatReceiver(String singleChatReceiver) {
        this.singleChatReceiver = singleChatReceiver;
        return this;
    }
    public String getSingleChatReceiver() {
        return this.singleChatReceiver;
    }

    public SendRobotInteractiveCardRequest setUnionIdPrivateDataMap(String unionIdPrivateDataMap) {
        this.unionIdPrivateDataMap = unionIdPrivateDataMap;
        return this;
    }
    public String getUnionIdPrivateDataMap() {
        return this.unionIdPrivateDataMap;
    }

    public SendRobotInteractiveCardRequest setUserIdPrivateDataMap(String userIdPrivateDataMap) {
        this.userIdPrivateDataMap = userIdPrivateDataMap;
        return this;
    }
    public String getUserIdPrivateDataMap() {
        return this.userIdPrivateDataMap;
    }

    public static class SendRobotInteractiveCardRequestSendOptions extends TeaModel {
        /**
         * <p>是否@所有人</p>
         */
        @NameInMap("atAll")
        public Boolean atAll;

        /**
         * <p>消息@人，JSON格式：[{"nickName":"张三","userId":"userId0001"},{"nickName":"李四","unionId":"unionId001"}]</p>
         */
        @NameInMap("atUserListJson")
        public String atUserListJson;

        /**
         * <p>卡片特殊属性json串</p>
         */
        @NameInMap("cardPropertyJson")
        public String cardPropertyJson;

        /**
         * <p>消息仅部分人可见的接收人列表【可空：为空则群所有人可见】，JSON格式：[{"userId":"userId0001"},{"unionId":"unionId001"}]</p>
         */
        @NameInMap("receiverListJson")
        public String receiverListJson;

        public static SendRobotInteractiveCardRequestSendOptions build(java.util.Map<String, ?> map) throws Exception {
            SendRobotInteractiveCardRequestSendOptions self = new SendRobotInteractiveCardRequestSendOptions();
            return TeaModel.build(map, self);
        }

        public SendRobotInteractiveCardRequestSendOptions setAtAll(Boolean atAll) {
            this.atAll = atAll;
            return this;
        }
        public Boolean getAtAll() {
            return this.atAll;
        }

        public SendRobotInteractiveCardRequestSendOptions setAtUserListJson(String atUserListJson) {
            this.atUserListJson = atUserListJson;
            return this;
        }
        public String getAtUserListJson() {
            return this.atUserListJson;
        }

        public SendRobotInteractiveCardRequestSendOptions setCardPropertyJson(String cardPropertyJson) {
            this.cardPropertyJson = cardPropertyJson;
            return this;
        }
        public String getCardPropertyJson() {
            return this.cardPropertyJson;
        }

        public SendRobotInteractiveCardRequestSendOptions setReceiverListJson(String receiverListJson) {
            this.receiverListJson = receiverListJson;
            return this;
        }
        public String getReceiverListJson() {
            return this.receiverListJson;
        }

    }

}
