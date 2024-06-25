// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class CreateTopboxRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>abcxxx</p>
     */
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("cardData")
    public CreateTopboxRequestCardData cardData;

    @NameInMap("cardSettings")
    public CreateTopboxRequestCardSettings cardSettings;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>56xxx-xxx</p>
     */
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("conversationType")
    public Integer conversationType;

    /**
     * <strong>example:</strong>
     * <p>COOLAPP-x-xxx</p>
     */
    @NameInMap("coolAppCode")
    public String coolAppCode;

    /**
     * <strong>example:</strong>
     * <p>1850042969000</p>
     */
    @NameInMap("expiredTime")
    public Long expiredTime;

    /**
     * <strong>example:</strong>
     * <p>xxx-xxx-xxx</p>
     */
    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    /**
     * <strong>example:</strong>
     * <p>cidxxxxx==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123xxx</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    /**
     * <strong>example:</strong>
     * <p>ios|win</p>
     */
    @NameInMap("platforms")
    public String platforms;

    @NameInMap("receiverUnionIdList")
    public java.util.List<String> receiverUnionIdList;

    @NameInMap("receiverUserIdList")
    public java.util.List<String> receiverUserIdList;

    /**
     * <strong>example:</strong>
     * <p>dingxxx</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    @NameInMap("unionIdPrivateDataMap")
    public java.util.Map<String, UnionIdPrivateDataMapValue> unionIdPrivateDataMap;

    /**
     * <strong>example:</strong>
     * <p>jHsR7xxx</p>
     */
    @NameInMap("unoinId")
    public String unoinId;

    /**
     * <strong>example:</strong>
     * <p>011xxx</p>
     */
    @NameInMap("userId")
    public String userId;

    @NameInMap("userIdPrivateDataMap")
    public java.util.Map<String, UserIdPrivateDataMapValue> userIdPrivateDataMap;

    public static CreateTopboxRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTopboxRequest self = new CreateTopboxRequest();
        return TeaModel.build(map, self);
    }

    public CreateTopboxRequest setCallbackRouteKey(String callbackRouteKey) {
        this.callbackRouteKey = callbackRouteKey;
        return this;
    }
    public String getCallbackRouteKey() {
        return this.callbackRouteKey;
    }

    public CreateTopboxRequest setCardData(CreateTopboxRequestCardData cardData) {
        this.cardData = cardData;
        return this;
    }
    public CreateTopboxRequestCardData getCardData() {
        return this.cardData;
    }

    public CreateTopboxRequest setCardSettings(CreateTopboxRequestCardSettings cardSettings) {
        this.cardSettings = cardSettings;
        return this;
    }
    public CreateTopboxRequestCardSettings getCardSettings() {
        return this.cardSettings;
    }

    public CreateTopboxRequest setCardTemplateId(String cardTemplateId) {
        this.cardTemplateId = cardTemplateId;
        return this;
    }
    public String getCardTemplateId() {
        return this.cardTemplateId;
    }

    public CreateTopboxRequest setConversationType(Integer conversationType) {
        this.conversationType = conversationType;
        return this;
    }
    public Integer getConversationType() {
        return this.conversationType;
    }

    public CreateTopboxRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public CreateTopboxRequest setExpiredTime(Long expiredTime) {
        this.expiredTime = expiredTime;
        return this;
    }
    public Long getExpiredTime() {
        return this.expiredTime;
    }

    public CreateTopboxRequest setGroupTemplateId(String groupTemplateId) {
        this.groupTemplateId = groupTemplateId;
        return this;
    }
    public String getGroupTemplateId() {
        return this.groupTemplateId;
    }

    public CreateTopboxRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public CreateTopboxRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

    public CreateTopboxRequest setPlatforms(String platforms) {
        this.platforms = platforms;
        return this;
    }
    public String getPlatforms() {
        return this.platforms;
    }

    public CreateTopboxRequest setReceiverUnionIdList(java.util.List<String> receiverUnionIdList) {
        this.receiverUnionIdList = receiverUnionIdList;
        return this;
    }
    public java.util.List<String> getReceiverUnionIdList() {
        return this.receiverUnionIdList;
    }

    public CreateTopboxRequest setReceiverUserIdList(java.util.List<String> receiverUserIdList) {
        this.receiverUserIdList = receiverUserIdList;
        return this;
    }
    public java.util.List<String> getReceiverUserIdList() {
        return this.receiverUserIdList;
    }

    public CreateTopboxRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public CreateTopboxRequest setUnionIdPrivateDataMap(java.util.Map<String, UnionIdPrivateDataMapValue> unionIdPrivateDataMap) {
        this.unionIdPrivateDataMap = unionIdPrivateDataMap;
        return this;
    }
    public java.util.Map<String, UnionIdPrivateDataMapValue> getUnionIdPrivateDataMap() {
        return this.unionIdPrivateDataMap;
    }

    public CreateTopboxRequest setUnoinId(String unoinId) {
        this.unoinId = unoinId;
        return this;
    }
    public String getUnoinId() {
        return this.unoinId;
    }

    public CreateTopboxRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CreateTopboxRequest setUserIdPrivateDataMap(java.util.Map<String, UserIdPrivateDataMapValue> userIdPrivateDataMap) {
        this.userIdPrivateDataMap = userIdPrivateDataMap;
        return this;
    }
    public java.util.Map<String, UserIdPrivateDataMapValue> getUserIdPrivateDataMap() {
        return this.userIdPrivateDataMap;
    }

    public static class CreateTopboxRequestCardData extends TeaModel {
        @NameInMap("cardParamMap")
        public java.util.Map<String, String> cardParamMap;

        public static CreateTopboxRequestCardData build(java.util.Map<String, ?> map) throws Exception {
            CreateTopboxRequestCardData self = new CreateTopboxRequestCardData();
            return TeaModel.build(map, self);
        }

        public CreateTopboxRequestCardData setCardParamMap(java.util.Map<String, String> cardParamMap) {
            this.cardParamMap = cardParamMap;
            return this;
        }
        public java.util.Map<String, String> getCardParamMap() {
            return this.cardParamMap;
        }

    }

    public static class CreateTopboxRequestCardSettings extends TeaModel {
        @NameInMap("pullStrategy")
        public Boolean pullStrategy;

        public static CreateTopboxRequestCardSettings build(java.util.Map<String, ?> map) throws Exception {
            CreateTopboxRequestCardSettings self = new CreateTopboxRequestCardSettings();
            return TeaModel.build(map, self);
        }

        public CreateTopboxRequestCardSettings setPullStrategy(Boolean pullStrategy) {
            this.pullStrategy = pullStrategy;
            return this;
        }
        public Boolean getPullStrategy() {
            return this.pullStrategy;
        }

    }

}
