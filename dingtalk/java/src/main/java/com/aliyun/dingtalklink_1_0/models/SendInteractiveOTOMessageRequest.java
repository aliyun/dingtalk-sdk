// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class SendInteractiveOTOMessageRequest extends TeaModel {
    /**
     * <p>消息详情</p>
     */
    @NameInMap("detail")
    public SendInteractiveOTOMessageRequestDetail detail;

    public static SendInteractiveOTOMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendInteractiveOTOMessageRequest self = new SendInteractiveOTOMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendInteractiveOTOMessageRequest setDetail(SendInteractiveOTOMessageRequestDetail detail) {
        this.detail = detail;
        return this;
    }
    public SendInteractiveOTOMessageRequestDetail getDetail() {
        return this.detail;
    }

    public static class SendInteractiveOTOMessageRequestDetail extends TeaModel {
        /**
         * <p>卡片回调的URL地址，不传此参数则无回调。</p>
         * <p>回调URL暂不支持query参数。</p>
         */
        @NameInMap("callbackUrl")
        public String callbackUrl;

        /**
         * <p>唯一标识一张卡片的ID，卡片幂等ID，可用于后续卡片更新。</p>
         * <p>> 该参数由开发者传入，确保唯一。</p>
         */
        @NameInMap("cardBizId")
        public String cardBizId;

        /**
         * <p>卡片模板内容参数，JsonObject结构型。</p>
         * <p>卡片数据结构需要与卡片搭建平台上定义的参数结构一致。</p>
         */
        @NameInMap("cardData")
        public String cardData;

        /**
         * <p>卡片搭建平台模板ID，详情可查阅 [创建消息模板](https://open.dingtalk.com/document/group/create-message-template) 。</p>
         */
        @NameInMap("cardTemplateId")
        public String cardTemplateId;

        /**
         * <p>消息接收人id</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>卡片模板userId差异用户参数，json结构体。</p>
         * <p>用户对应的数据结构需要与卡片搭建平台上定义的参数结构一致。</p>
         * <br>
         */
        @NameInMap("userIdPrivateDataMap")
        public String userIdPrivateDataMap;

        public static SendInteractiveOTOMessageRequestDetail build(java.util.Map<String, ?> map) throws Exception {
            SendInteractiveOTOMessageRequestDetail self = new SendInteractiveOTOMessageRequestDetail();
            return TeaModel.build(map, self);
        }

        public SendInteractiveOTOMessageRequestDetail setCallbackUrl(String callbackUrl) {
            this.callbackUrl = callbackUrl;
            return this;
        }
        public String getCallbackUrl() {
            return this.callbackUrl;
        }

        public SendInteractiveOTOMessageRequestDetail setCardBizId(String cardBizId) {
            this.cardBizId = cardBizId;
            return this;
        }
        public String getCardBizId() {
            return this.cardBizId;
        }

        public SendInteractiveOTOMessageRequestDetail setCardData(String cardData) {
            this.cardData = cardData;
            return this;
        }
        public String getCardData() {
            return this.cardData;
        }

        public SendInteractiveOTOMessageRequestDetail setCardTemplateId(String cardTemplateId) {
            this.cardTemplateId = cardTemplateId;
            return this;
        }
        public String getCardTemplateId() {
            return this.cardTemplateId;
        }

        public SendInteractiveOTOMessageRequestDetail setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public SendInteractiveOTOMessageRequestDetail setUserIdPrivateDataMap(String userIdPrivateDataMap) {
            this.userIdPrivateDataMap = userIdPrivateDataMap;
            return this;
        }
        public String getUserIdPrivateDataMap() {
            return this.userIdPrivateDataMap;
        }

    }

}
