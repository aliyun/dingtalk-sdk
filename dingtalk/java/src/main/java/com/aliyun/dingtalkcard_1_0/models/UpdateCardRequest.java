// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class UpdateCardRequest extends TeaModel {
    @NameInMap("cardData")
    public UpdateCardRequestCardData cardData;

    @NameInMap("cardUpdateOptions")
    public UpdateCardRequestCardUpdateOptions cardUpdateOptions;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    @NameInMap("userIdType")
    public Integer userIdType;

    public static UpdateCardRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCardRequest self = new UpdateCardRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCardRequest setCardData(UpdateCardRequestCardData cardData) {
        this.cardData = cardData;
        return this;
    }
    public UpdateCardRequestCardData getCardData() {
        return this.cardData;
    }

    public UpdateCardRequest setCardUpdateOptions(UpdateCardRequestCardUpdateOptions cardUpdateOptions) {
        this.cardUpdateOptions = cardUpdateOptions;
        return this;
    }
    public UpdateCardRequestCardUpdateOptions getCardUpdateOptions() {
        return this.cardUpdateOptions;
    }

    public UpdateCardRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public UpdateCardRequest setPrivateData(java.util.Map<String, PrivateDataValue> privateData) {
        this.privateData = privateData;
        return this;
    }
    public java.util.Map<String, PrivateDataValue> getPrivateData() {
        return this.privateData;
    }

    public UpdateCardRequest setUserIdType(Integer userIdType) {
        this.userIdType = userIdType;
        return this;
    }
    public Integer getUserIdType() {
        return this.userIdType;
    }

    public static class UpdateCardRequestCardData extends TeaModel {
        @NameInMap("cardParamMap")
        public java.util.Map<String, String> cardParamMap;

        public static UpdateCardRequestCardData build(java.util.Map<String, ?> map) throws Exception {
            UpdateCardRequestCardData self = new UpdateCardRequestCardData();
            return TeaModel.build(map, self);
        }

        public UpdateCardRequestCardData setCardParamMap(java.util.Map<String, String> cardParamMap) {
            this.cardParamMap = cardParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardParamMap() {
            return this.cardParamMap;
        }

    }

    public static class UpdateCardRequestCardUpdateOptions extends TeaModel {
        @NameInMap("updateCardDataByKey")
        public Boolean updateCardDataByKey;

        @NameInMap("updatePrivateDataByKey")
        public Boolean updatePrivateDataByKey;

        public static UpdateCardRequestCardUpdateOptions build(java.util.Map<String, ?> map) throws Exception {
            UpdateCardRequestCardUpdateOptions self = new UpdateCardRequestCardUpdateOptions();
            return TeaModel.build(map, self);
        }

        public UpdateCardRequestCardUpdateOptions setUpdateCardDataByKey(Boolean updateCardDataByKey) {
            this.updateCardDataByKey = updateCardDataByKey;
            return this;
        }
        public Boolean getUpdateCardDataByKey() {
            return this.updateCardDataByKey;
        }

        public UpdateCardRequestCardUpdateOptions setUpdatePrivateDataByKey(Boolean updatePrivateDataByKey) {
            this.updatePrivateDataByKey = updatePrivateDataByKey;
            return this;
        }
        public Boolean getUpdatePrivateDataByKey() {
            return this.updatePrivateDataByKey;
        }

    }

}
