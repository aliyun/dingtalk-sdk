// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateRobotInteractiveCardRequest extends TeaModel {
    // 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
    @NameInMap("cardBizId")
    public String cardBizId;

    // 卡片模板-文本内容参数（卡片json结构体）
    @NameInMap("cardData")
    public String cardData;

    // 卡片模板-userId差异用户参数（json结构体）
    @NameInMap("unionIdPrivateDataMap")
    public String unionIdPrivateDataMap;

    // 互动卡片更新选项
    @NameInMap("updateOptions")
    public UpdateRobotInteractiveCardRequestUpdateOptions updateOptions;

    // 卡片模板-userId差异用户参数（json结构体）
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
        // 按key更新数据(默认全量更新)
        @NameInMap("updateCardDataByKey")
        public Boolean updateCardDataByKey;

        // 按key更新用户数据(默认全量更新)
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
