// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class SendTopBoxInteractiveOTOMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("detail")
    public SendTopBoxInteractiveOTOMessageRequestDetail detail;

    public static SendTopBoxInteractiveOTOMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendTopBoxInteractiveOTOMessageRequest self = new SendTopBoxInteractiveOTOMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendTopBoxInteractiveOTOMessageRequest setDetail(SendTopBoxInteractiveOTOMessageRequestDetail detail) {
        this.detail = detail;
        return this;
    }
    public SendTopBoxInteractiveOTOMessageRequestDetail getDetail() {
        return this.detail;
    }

    public static class SendTopBoxInteractiveOTOMessageRequestDetailCardData extends TeaModel {
        @NameInMap("cardMediaIdParamMap")
        public java.util.Map<String, ?> cardMediaIdParamMap;

        @NameInMap("cardParamMap")
        public java.util.Map<String, ?> cardParamMap;

        public static SendTopBoxInteractiveOTOMessageRequestDetailCardData build(java.util.Map<String, ?> map) throws Exception {
            SendTopBoxInteractiveOTOMessageRequestDetailCardData self = new SendTopBoxInteractiveOTOMessageRequestDetailCardData();
            return TeaModel.build(map, self);
        }

        public SendTopBoxInteractiveOTOMessageRequestDetailCardData setCardMediaIdParamMap(java.util.Map<String, ?> cardMediaIdParamMap) {
            this.cardMediaIdParamMap = cardMediaIdParamMap;
            return this;
        }
        public java.util.Map<String, ?> getCardMediaIdParamMap() {
            return this.cardMediaIdParamMap;
        }

        public SendTopBoxInteractiveOTOMessageRequestDetailCardData setCardParamMap(java.util.Map<String, ?> cardParamMap) {
            this.cardParamMap = cardParamMap;
            return this;
        }
        public java.util.Map<String, ?> getCardParamMap() {
            return this.cardParamMap;
        }

    }

    public static class SendTopBoxInteractiveOTOMessageRequestDetail extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="https://www.youurl.com/callback/card">https://www.youurl.com/callback/card</a></p>
         */
        @NameInMap("callbackUrl")
        public String callbackUrl;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>service-card-20220824-001</p>
         */
        @NameInMap("cardBizId")
        public String cardBizId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("cardData")
        public SendTopBoxInteractiveOTOMessageRequestDetailCardData cardData;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>3erkfi-42b0-4c83-bc56-ffhssde43</p>
         */
        @NameInMap("cardTemplateId")
        public String cardTemplateId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("expiredTime")
        public Long expiredTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>user001</p>
         */
        @NameInMap("userId")
        public String userId;

        @NameInMap("userIdPrivateDataMap")
        public java.util.Map<String, DetailUserIdPrivateDataMapValue> userIdPrivateDataMap;

        public static SendTopBoxInteractiveOTOMessageRequestDetail build(java.util.Map<String, ?> map) throws Exception {
            SendTopBoxInteractiveOTOMessageRequestDetail self = new SendTopBoxInteractiveOTOMessageRequestDetail();
            return TeaModel.build(map, self);
        }

        public SendTopBoxInteractiveOTOMessageRequestDetail setCallbackUrl(String callbackUrl) {
            this.callbackUrl = callbackUrl;
            return this;
        }
        public String getCallbackUrl() {
            return this.callbackUrl;
        }

        public SendTopBoxInteractiveOTOMessageRequestDetail setCardBizId(String cardBizId) {
            this.cardBizId = cardBizId;
            return this;
        }
        public String getCardBizId() {
            return this.cardBizId;
        }

        public SendTopBoxInteractiveOTOMessageRequestDetail setCardData(SendTopBoxInteractiveOTOMessageRequestDetailCardData cardData) {
            this.cardData = cardData;
            return this;
        }
        public SendTopBoxInteractiveOTOMessageRequestDetailCardData getCardData() {
            return this.cardData;
        }

        public SendTopBoxInteractiveOTOMessageRequestDetail setCardTemplateId(String cardTemplateId) {
            this.cardTemplateId = cardTemplateId;
            return this;
        }
        public String getCardTemplateId() {
            return this.cardTemplateId;
        }

        public SendTopBoxInteractiveOTOMessageRequestDetail setExpiredTime(Long expiredTime) {
            this.expiredTime = expiredTime;
            return this;
        }
        public Long getExpiredTime() {
            return this.expiredTime;
        }

        public SendTopBoxInteractiveOTOMessageRequestDetail setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public SendTopBoxInteractiveOTOMessageRequestDetail setUserIdPrivateDataMap(java.util.Map<String, DetailUserIdPrivateDataMapValue> userIdPrivateDataMap) {
            this.userIdPrivateDataMap = userIdPrivateDataMap;
            return this;
        }
        public java.util.Map<String, DetailUserIdPrivateDataMapValue> getUserIdPrivateDataMap() {
            return this.userIdPrivateDataMap;
        }

    }

}
