// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateInteractiveCardRequest extends TeaModel {
    @NameInMap("cardData")
    public UpdateInteractiveCardRequestCardData cardData;

    @NameInMap("cardOptions")
    public UpdateInteractiveCardRequestCardOptions cardOptions;

    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    @NameInMap("userIdType")
    public Integer userIdType;

    public static UpdateInteractiveCardRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInteractiveCardRequest self = new UpdateInteractiveCardRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInteractiveCardRequest setCardData(UpdateInteractiveCardRequestCardData cardData) {
        this.cardData = cardData;
        return this;
    }
    public UpdateInteractiveCardRequestCardData getCardData() {
        return this.cardData;
    }

    public UpdateInteractiveCardRequest setCardOptions(UpdateInteractiveCardRequestCardOptions cardOptions) {
        this.cardOptions = cardOptions;
        return this;
    }
    public UpdateInteractiveCardRequestCardOptions getCardOptions() {
        return this.cardOptions;
    }

    public UpdateInteractiveCardRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public UpdateInteractiveCardRequest setPrivateData(java.util.Map<String, PrivateDataValue> privateData) {
        this.privateData = privateData;
        return this;
    }
    public java.util.Map<String, PrivateDataValue> getPrivateData() {
        return this.privateData;
    }

    public UpdateInteractiveCardRequest setUserIdType(Integer userIdType) {
        this.userIdType = userIdType;
        return this;
    }
    public Integer getUserIdType() {
        return this.userIdType;
    }

    public static class UpdateInteractiveCardRequestCardData extends TeaModel {
        @NameInMap("cardMediaIdParamMap")
        public java.util.Map<String, String> cardMediaIdParamMap;

        @NameInMap("cardParamMap")
        public java.util.Map<String, String> cardParamMap;

        public static UpdateInteractiveCardRequestCardData build(java.util.Map<String, ?> map) throws Exception {
            UpdateInteractiveCardRequestCardData self = new UpdateInteractiveCardRequestCardData();
            return TeaModel.build(map, self);
        }

        public UpdateInteractiveCardRequestCardData setCardMediaIdParamMap(java.util.Map<String, String> cardMediaIdParamMap) {
            this.cardMediaIdParamMap = cardMediaIdParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardMediaIdParamMap() {
            return this.cardMediaIdParamMap;
        }

        public UpdateInteractiveCardRequestCardData setCardParamMap(java.util.Map<String, String> cardParamMap) {
            this.cardParamMap = cardParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardParamMap() {
            return this.cardParamMap;
        }

    }

    public static class UpdateInteractiveCardRequestCardOptions extends TeaModel {
        @NameInMap("updateCardDataByKey")
        public Boolean updateCardDataByKey;

        @NameInMap("updatePrivateDataByKey")
        public Boolean updatePrivateDataByKey;

        public static UpdateInteractiveCardRequestCardOptions build(java.util.Map<String, ?> map) throws Exception {
            UpdateInteractiveCardRequestCardOptions self = new UpdateInteractiveCardRequestCardOptions();
            return TeaModel.build(map, self);
        }

        public UpdateInteractiveCardRequestCardOptions setUpdateCardDataByKey(Boolean updateCardDataByKey) {
            this.updateCardDataByKey = updateCardDataByKey;
            return this;
        }
        public Boolean getUpdateCardDataByKey() {
            return this.updateCardDataByKey;
        }

        public UpdateInteractiveCardRequestCardOptions setUpdatePrivateDataByKey(Boolean updatePrivateDataByKey) {
            this.updatePrivateDataByKey = updatePrivateDataByKey;
            return this;
        }
        public Boolean getUpdatePrivateDataByKey() {
            return this.updatePrivateDataByKey;
        }

    }

}
