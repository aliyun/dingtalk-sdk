// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateInteractiveCardRequest extends TeaModel {
    /**
     * <p>卡片公共主体部分数据</p>
     */
    @NameInMap("cardData")
    public UpdateInteractiveCardRequestCardData cardData;

    /**
     * <p>发送可交互卡片的一些功能选项</p>
     */
    @NameInMap("cardOptions")
    public UpdateInteractiveCardRequestCardOptions cardOptions;

    /**
     * <p>唯一标识一张卡片的外部ID</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    /**
     * <p>卡片用户私有差异部分数据（如卡片不同人显示不同按钮；key：用户userId；value：用户数据变量）</p>
     */
    @NameInMap("privateData")
    public java.util.Map<String, PrivateDataValue> privateData;

    /**
     * <p>用户ID类型：1：userId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式</p>
     */
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
        /**
         * <p>卡片模板内容替换参数-多媒体类型</p>
         */
        @NameInMap("cardMediaIdParamMap")
        public java.util.Map<String, String> cardMediaIdParamMap;

        /**
         * <p>卡片模板内容替换参数-普通文本类型</p>
         */
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
        /**
         * <p>按key更新cardData数据(不填默认覆盖更新)</p>
         */
        @NameInMap("updateCardDataByKey")
        public Boolean updateCardDataByKey;

        /**
         * <p>按key更新privateData用户数据(不填默认覆盖更新)</p>
         */
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
