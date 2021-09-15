// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendTemplateInteractiveCardRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    // 卡片内容模板ID，响应模板目前有：TuWenCard01、TuWenCard02、TuWenCard03、TuWenCard04 4种
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    // 接收卡片的加密群ID
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    // 机器人代码，群模板机器人网页有机器人ID；企业内部机器人为机器人appKey，企业三方机器人有robotCode
    @NameInMap("robotCode")
    public String robotCode;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // 可控制卡片回调的url【可空：不填写无需回调】
    @NameInMap("callbackUrl")
    public String callbackUrl;

    // 卡片模板-文本内容参数（卡片json结构体）
    @NameInMap("cardData")
    public String cardData;

    @NameInMap("dingOauthAppId")
    public Long dingOauthAppId;

    // 互动卡片发送选项
    @NameInMap("sendOptions")
    public SendTemplateInteractiveCardRequestSendOptions sendOptions;

    public static SendTemplateInteractiveCardRequest build(java.util.Map<String, ?> map) throws Exception {
        SendTemplateInteractiveCardRequest self = new SendTemplateInteractiveCardRequest();
        return TeaModel.build(map, self);
    }

    public SendTemplateInteractiveCardRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public SendTemplateInteractiveCardRequest setCardTemplateId(String cardTemplateId) {
        this.cardTemplateId = cardTemplateId;
        return this;
    }
    public String getCardTemplateId() {
        return this.cardTemplateId;
    }

    public SendTemplateInteractiveCardRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendTemplateInteractiveCardRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public SendTemplateInteractiveCardRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public SendTemplateInteractiveCardRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public SendTemplateInteractiveCardRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public SendTemplateInteractiveCardRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public SendTemplateInteractiveCardRequest setCallbackUrl(String callbackUrl) {
        this.callbackUrl = callbackUrl;
        return this;
    }
    public String getCallbackUrl() {
        return this.callbackUrl;
    }

    public SendTemplateInteractiveCardRequest setCardData(String cardData) {
        this.cardData = cardData;
        return this;
    }
    public String getCardData() {
        return this.cardData;
    }

    public SendTemplateInteractiveCardRequest setDingOauthAppId(Long dingOauthAppId) {
        this.dingOauthAppId = dingOauthAppId;
        return this;
    }
    public Long getDingOauthAppId() {
        return this.dingOauthAppId;
    }

    public SendTemplateInteractiveCardRequest setSendOptions(SendTemplateInteractiveCardRequestSendOptions sendOptions) {
        this.sendOptions = sendOptions;
        return this;
    }
    public SendTemplateInteractiveCardRequestSendOptions getSendOptions() {
        return this.sendOptions;
    }

    public static class SendTemplateInteractiveCardRequestSendOptions extends TeaModel {
        // 消息@人，JSON格式：[{"nickName":"张三","userId":"userId0001"},{"nickName":"李四","unionId":"unionId001"}]
        @NameInMap("atUserListJson")
        public String atUserListJson;

        // 消息仅部分人可见的接收人列表【可空：为空则群所有人可见】，JSON格式：[{"userId":"userId0001"},{"unionId":"unionId001"}]
        @NameInMap("receiverListJson")
        public String receiverListJson;

        public static SendTemplateInteractiveCardRequestSendOptions build(java.util.Map<String, ?> map) throws Exception {
            SendTemplateInteractiveCardRequestSendOptions self = new SendTemplateInteractiveCardRequestSendOptions();
            return TeaModel.build(map, self);
        }

        public SendTemplateInteractiveCardRequestSendOptions setAtUserListJson(String atUserListJson) {
            this.atUserListJson = atUserListJson;
            return this;
        }
        public String getAtUserListJson() {
            return this.atUserListJson;
        }

        public SendTemplateInteractiveCardRequestSendOptions setReceiverListJson(String receiverListJson) {
            this.receiverListJson = receiverListJson;
            return this;
        }
        public String getReceiverListJson() {
            return this.receiverListJson;
        }

    }

}
