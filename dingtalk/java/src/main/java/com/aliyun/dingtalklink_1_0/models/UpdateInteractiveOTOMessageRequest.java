// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class UpdateInteractiveOTOMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("detail")
    public UpdateInteractiveOTOMessageRequestDetail detail;

    public static UpdateInteractiveOTOMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInteractiveOTOMessageRequest self = new UpdateInteractiveOTOMessageRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInteractiveOTOMessageRequest setDetail(UpdateInteractiveOTOMessageRequestDetail detail) {
        this.detail = detail;
        return this;
    }
    public UpdateInteractiveOTOMessageRequestDetail getDetail() {
        return this.detail;
    }

    public static class UpdateInteractiveOTOMessageRequestDetailUpdateOptions extends TeaModel {
        @NameInMap("updateCardDataByKey")
        public Boolean updateCardDataByKey;

        @NameInMap("updatePrivateDataByKey")
        public Boolean updatePrivateDataByKey;

        public static UpdateInteractiveOTOMessageRequestDetailUpdateOptions build(java.util.Map<String, ?> map) throws Exception {
            UpdateInteractiveOTOMessageRequestDetailUpdateOptions self = new UpdateInteractiveOTOMessageRequestDetailUpdateOptions();
            return TeaModel.build(map, self);
        }

        public UpdateInteractiveOTOMessageRequestDetailUpdateOptions setUpdateCardDataByKey(Boolean updateCardDataByKey) {
            this.updateCardDataByKey = updateCardDataByKey;
            return this;
        }
        public Boolean getUpdateCardDataByKey() {
            return this.updateCardDataByKey;
        }

        public UpdateInteractiveOTOMessageRequestDetailUpdateOptions setUpdatePrivateDataByKey(Boolean updatePrivateDataByKey) {
            this.updatePrivateDataByKey = updatePrivateDataByKey;
            return this;
        }
        public Boolean getUpdatePrivateDataByKey() {
            return this.updatePrivateDataByKey;
        }

    }

    public static class UpdateInteractiveOTOMessageRequestDetail extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("cardBizId")
        public String cardBizId;

        @NameInMap("cardData")
        public String cardData;

        @NameInMap("updateOptions")
        public UpdateInteractiveOTOMessageRequestDetailUpdateOptions updateOptions;

        @NameInMap("userIdPrivateDataMap")
        public String userIdPrivateDataMap;

        public static UpdateInteractiveOTOMessageRequestDetail build(java.util.Map<String, ?> map) throws Exception {
            UpdateInteractiveOTOMessageRequestDetail self = new UpdateInteractiveOTOMessageRequestDetail();
            return TeaModel.build(map, self);
        }

        public UpdateInteractiveOTOMessageRequestDetail setCardBizId(String cardBizId) {
            this.cardBizId = cardBizId;
            return this;
        }
        public String getCardBizId() {
            return this.cardBizId;
        }

        public UpdateInteractiveOTOMessageRequestDetail setCardData(String cardData) {
            this.cardData = cardData;
            return this;
        }
        public String getCardData() {
            return this.cardData;
        }

        public UpdateInteractiveOTOMessageRequestDetail setUpdateOptions(UpdateInteractiveOTOMessageRequestDetailUpdateOptions updateOptions) {
            this.updateOptions = updateOptions;
            return this;
        }
        public UpdateInteractiveOTOMessageRequestDetailUpdateOptions getUpdateOptions() {
            return this.updateOptions;
        }

        public UpdateInteractiveOTOMessageRequestDetail setUserIdPrivateDataMap(String userIdPrivateDataMap) {
            this.userIdPrivateDataMap = userIdPrivateDataMap;
            return this;
        }
        public String getUserIdPrivateDataMap() {
            return this.userIdPrivateDataMap;
        }

    }

}
