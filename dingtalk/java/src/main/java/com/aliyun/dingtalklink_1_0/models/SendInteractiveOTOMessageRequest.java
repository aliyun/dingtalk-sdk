// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class SendInteractiveOTOMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
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
        @NameInMap("callbackUrl")
        public String callbackUrl;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("cardBizId")
        public String cardBizId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("cardData")
        public String cardData;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("cardTemplateId")
        public String cardTemplateId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("userId")
        public String userId;

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
