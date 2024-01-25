// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class UpdateCardWithDelegateRequest extends TeaModel {
    @NameInMap("cardData")
    public UpdateCardWithDelegateRequestCardData cardData;

    @NameInMap("cardUpdateOptions")
    public UpdateCardWithDelegateRequestCardUpdateOptions cardUpdateOptions;

    @NameInMap("outTrackId")
    public String outTrackId;

    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    @NameInMap("userIdType")
    public Integer userIdType;

    public static UpdateCardWithDelegateRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCardWithDelegateRequest self = new UpdateCardWithDelegateRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCardWithDelegateRequest setCardData(UpdateCardWithDelegateRequestCardData cardData) {
        this.cardData = cardData;
        return this;
    }
    public UpdateCardWithDelegateRequestCardData getCardData() {
        return this.cardData;
    }

    public UpdateCardWithDelegateRequest setCardUpdateOptions(UpdateCardWithDelegateRequestCardUpdateOptions cardUpdateOptions) {
        this.cardUpdateOptions = cardUpdateOptions;
        return this;
    }
    public UpdateCardWithDelegateRequestCardUpdateOptions getCardUpdateOptions() {
        return this.cardUpdateOptions;
    }

    public UpdateCardWithDelegateRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public UpdateCardWithDelegateRequest setPrivateData(java.util.Map<String, PrivateDataValue> privateData) {
        this.privateData = privateData;
        return this;
    }
    public java.util.Map<String, PrivateDataValue> getPrivateData() {
        return this.privateData;
    }

    public UpdateCardWithDelegateRequest setUserIdType(Integer userIdType) {
        this.userIdType = userIdType;
        return this;
    }
    public Integer getUserIdType() {
        return this.userIdType;
    }

    public static class UpdateCardWithDelegateRequestCardData extends TeaModel {
        @NameInMap("cardParamMap")
        public java.util.Map<String, String> cardParamMap;

        public static UpdateCardWithDelegateRequestCardData build(java.util.Map<String, ?> map) throws Exception {
            UpdateCardWithDelegateRequestCardData self = new UpdateCardWithDelegateRequestCardData();
            return TeaModel.build(map, self);
        }

        public UpdateCardWithDelegateRequestCardData setCardParamMap(java.util.Map<String, String> cardParamMap) {
            this.cardParamMap = cardParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardParamMap() {
            return this.cardParamMap;
        }

    }

    public static class UpdateCardWithDelegateRequestCardUpdateOptions extends TeaModel {
        @NameInMap("updateCardDataByKey")
        public Boolean updateCardDataByKey;

        @NameInMap("updatePrivateDataByKey")
        public Boolean updatePrivateDataByKey;

        public static UpdateCardWithDelegateRequestCardUpdateOptions build(java.util.Map<String, ?> map) throws Exception {
            UpdateCardWithDelegateRequestCardUpdateOptions self = new UpdateCardWithDelegateRequestCardUpdateOptions();
            return TeaModel.build(map, self);
        }

        public UpdateCardWithDelegateRequestCardUpdateOptions setUpdateCardDataByKey(Boolean updateCardDataByKey) {
            this.updateCardDataByKey = updateCardDataByKey;
            return this;
        }
        public Boolean getUpdateCardDataByKey() {
            return this.updateCardDataByKey;
        }

        public UpdateCardWithDelegateRequestCardUpdateOptions setUpdatePrivateDataByKey(Boolean updatePrivateDataByKey) {
            this.updatePrivateDataByKey = updatePrivateDataByKey;
            return this;
        }
        public Boolean getUpdatePrivateDataByKey() {
            return this.updatePrivateDataByKey;
        }

    }

}
