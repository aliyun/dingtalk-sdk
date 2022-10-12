// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class UpdateCardRequest extends TeaModel {
    // 卡片数据
    @NameInMap("cardData")
    public UpdateCardRequestCardData cardData;

    // 卡片更新选项
    @NameInMap("cardUpdateOptions")
    public UpdateCardRequestCardUpdateOptions cardUpdateOptions;

    // 【必填】外部卡片实例Id
    @NameInMap("outTrackId")
    public String outTrackId;

    // 用户的私有数据。
    // ● key：userId
    // ● value：用户私有数据（cardData）
    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

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

    public static class UpdateCardRequestCardData extends TeaModel {
        // 卡片模板内容替换参数，普通文本类型
        // ● key：参数名
        // ● value: 参数值
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
        // 按 key 更新 cardData 数据，不填默认覆盖更新。
        @NameInMap("updateCardDataByKey")
        public Boolean updateCardDataByKey;

        // 【可选】按key更新privateData用户数据，不填默认覆盖更新。
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
