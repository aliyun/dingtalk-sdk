// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendRobotInteractiveCardRequest extends TeaModel {
    @NameInMap("RequestId")
    public String requestId;

    @NameInMap("dingAccessTokenType")
    public String dingAccessTokenType;

    @NameInMap("dingClientId")
    public String dingClientId;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOpenAppId")
    public String dingOpenAppId;

    @NameInMap("dingUid")
    public Long dingUid;

    // 卡片搭建平台模板ID
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    // 【openConversationId & singleChatReceiver 二选一必填】接收卡片的加密群ID，特指多人群会话（非单聊）
    @NameInMap("openConversationId")
    public String openConversationId;

    // 【openConversationId & singleChatReceiver 二选一必填】单聊会话接受者json串
    @NameInMap("singleChatReceiver")
    public String singleChatReceiver;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
    @NameInMap("cardBizId")
    public String cardBizId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    // 机器人代码，群模板机器人网页有机器人ID；企业内部机器人为机器人appKey，企业三方机器人有robotCode
    @NameInMap("robotCode")
    public String robotCode;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // 卡片模板-文本内容参数（卡片json结构体）
    @NameInMap("cardData")
    public String cardData;

    @NameInMap("dingOauthAppId")
    public Long dingOauthAppId;

    // 互动卡片发送选项
    @NameInMap("sendOptions")
    public SendRobotInteractiveCardRequestSendOptions sendOptions;

    public static SendRobotInteractiveCardRequest build(java.util.Map<String, ?> map) throws Exception {
        SendRobotInteractiveCardRequest self = new SendRobotInteractiveCardRequest();
        return TeaModel.build(map, self);
    }

    public SendRobotInteractiveCardRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SendRobotInteractiveCardRequest setDingAccessTokenType(String dingAccessTokenType) {
        this.dingAccessTokenType = dingAccessTokenType;
        return this;
    }
    public String getDingAccessTokenType() {
        return this.dingAccessTokenType;
    }

    public SendRobotInteractiveCardRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public SendRobotInteractiveCardRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public SendRobotInteractiveCardRequest setDingOpenAppId(String dingOpenAppId) {
        this.dingOpenAppId = dingOpenAppId;
        return this;
    }
    public String getDingOpenAppId() {
        return this.dingOpenAppId;
    }

    public SendRobotInteractiveCardRequest setDingUid(Long dingUid) {
        this.dingUid = dingUid;
        return this;
    }
    public Long getDingUid() {
        return this.dingUid;
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

    public SendRobotInteractiveCardRequest setSingleChatReceiver(String singleChatReceiver) {
        this.singleChatReceiver = singleChatReceiver;
        return this;
    }
    public String getSingleChatReceiver() {
        return this.singleChatReceiver;
    }

    public SendRobotInteractiveCardRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public SendRobotInteractiveCardRequest setCardBizId(String cardBizId) {
        this.cardBizId = cardBizId;
        return this;
    }
    public String getCardBizId() {
        return this.cardBizId;
    }

    public SendRobotInteractiveCardRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public SendRobotInteractiveCardRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public SendRobotInteractiveCardRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public SendRobotInteractiveCardRequest setCardData(String cardData) {
        this.cardData = cardData;
        return this;
    }
    public String getCardData() {
        return this.cardData;
    }

    public SendRobotInteractiveCardRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

    public SendRobotInteractiveCardRequest setSendOptions(SendRobotInteractiveCardRequestSendOptions sendOptions) {
        this.sendOptions = sendOptions;
        return this;
    }
    public SendRobotInteractiveCardRequestSendOptions getSendOptions() {
        return this.sendOptions;
    }

    public static class SendRobotInteractiveCardRequestSendOptions extends TeaModel {
        // 消息@人，JSON格式：[{"nickName":"张三","userId":"userId0001"},{"nickName":"李四","unionId":"unionId001"}]
        @NameInMap("atUserListJson")
        public String atUserListJson;

        // 是否@所有人
        @NameInMap("atAll")
        public Boolean atAll;

        // 消息仅部分人可见的接收人列表【可空：为空则群所有人可见】，JSON格式：[{"userId":"userId0001"},{"unionId":"unionId001"}]
        @NameInMap("receiverListJson")
        public String receiverListJson;

        // 卡片特殊属性json串
        @NameInMap("cardPropertyJson")
        public String cardPropertyJson;

        public static SendRobotInteractiveCardRequestSendOptions build(java.util.Map<String, ?> map) throws Exception {
            SendRobotInteractiveCardRequestSendOptions self = new SendRobotInteractiveCardRequestSendOptions();
            return TeaModel.build(map, self);
        }

        public SendRobotInteractiveCardRequestSendOptions setAtUserListJson(String atUserListJson) {
            this.atUserListJson = atUserListJson;
            return this;
        }
        public String getAtUserListJson() {
            return this.atUserListJson;
        }

        public SendRobotInteractiveCardRequestSendOptions setAtAll(Boolean atAll) {
            this.atAll = atAll;
            return this;
        }
        public Boolean getAtAll() {
            return this.atAll;
        }

        public SendRobotInteractiveCardRequestSendOptions setReceiverListJson(String receiverListJson) {
            this.receiverListJson = receiverListJson;
            return this;
        }
        public String getReceiverListJson() {
            return this.receiverListJson;
        }

        public SendRobotInteractiveCardRequestSendOptions setCardPropertyJson(String cardPropertyJson) {
            this.cardPropertyJson = cardPropertyJson;
            return this;
        }
        public String getCardPropertyJson() {
            return this.cardPropertyJson;
        }

    }

}
