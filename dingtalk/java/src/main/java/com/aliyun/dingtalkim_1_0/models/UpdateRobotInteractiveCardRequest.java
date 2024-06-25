// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateRobotInteractiveCardRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cardXXXX01</p>
     */
    @NameInMap("cardBizId")
    public String cardBizId;

    /**
     * <strong>example:</strong>
     * <p>根据具体的cardTemplateId参考文档格式</p>
     */
    @NameInMap("cardData")
    public String cardData;

    @NameInMap("unionIdPrivateDataMap")
    public String unionIdPrivateDataMap;

    @NameInMap("updateOptions")
    public UpdateRobotInteractiveCardRequestUpdateOptions updateOptions;

    @NameInMap("userIdPrivateDataMap")
    public String userIdPrivateDataMap;

    public static UpdateRobotInteractiveCardRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRobotInteractiveCardRequest self = new UpdateRobotInteractiveCardRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRobotInteractiveCardRequest setCardBizId(String cardBizId) {
        this.cardBizId = cardBizId;
        return this;
    }
    public String getCardBizId() {
        return this.cardBizId;
    }

    public UpdateRobotInteractiveCardRequest setCardData(String cardData) {
        this.cardData = cardData;
        return this;
    }
    public String getCardData() {
        return this.cardData;
    }

    public UpdateRobotInteractiveCardRequest setUnionIdPrivateDataMap(String unionIdPrivateDataMap) {
        this.unionIdPrivateDataMap = unionIdPrivateDataMap;
        return this;
    }
    public String getUnionIdPrivateDataMap() {
        return this.unionIdPrivateDataMap;
    }

    public UpdateRobotInteractiveCardRequest setUpdateOptions(UpdateRobotInteractiveCardRequestUpdateOptions updateOptions) {
        this.updateOptions = updateOptions;
        return this;
    }
    public UpdateRobotInteractiveCardRequestUpdateOptions getUpdateOptions() {
        return this.updateOptions;
    }

    public UpdateRobotInteractiveCardRequest setUserIdPrivateDataMap(String userIdPrivateDataMap) {
        this.userIdPrivateDataMap = userIdPrivateDataMap;
        return this;
    }
    public String getUserIdPrivateDataMap() {
        return this.userIdPrivateDataMap;
    }

    public static class UpdateRobotInteractiveCardRequestUpdateOptions extends TeaModel {
        @NameInMap("updateCardDataByKey")
        public Boolean updateCardDataByKey;

        @NameInMap("updatePrivateDataByKey")
        public Boolean updatePrivateDataByKey;

        public static UpdateRobotInteractiveCardRequestUpdateOptions build(java.util.Map<String, ?> map) throws Exception {
            UpdateRobotInteractiveCardRequestUpdateOptions self = new UpdateRobotInteractiveCardRequestUpdateOptions();
            return TeaModel.build(map, self);
        }

        public UpdateRobotInteractiveCardRequestUpdateOptions setUpdateCardDataByKey(Boolean updateCardDataByKey) {
            this.updateCardDataByKey = updateCardDataByKey;
            return this;
        }
        public Boolean getUpdateCardDataByKey() {
            return this.updateCardDataByKey;
        }

        public UpdateRobotInteractiveCardRequestUpdateOptions setUpdatePrivateDataByKey(Boolean updatePrivateDataByKey) {
            this.updatePrivateDataByKey = updatePrivateDataByKey;
            return this;
        }
        public Boolean getUpdatePrivateDataByKey() {
            return this.updatePrivateDataByKey;
        }

    }

}
