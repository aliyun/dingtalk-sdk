// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class CreateTopboxRequest extends TeaModel {
    // 可控制卡片回调时的路由Key，用于指定特定的callbackUrl。
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    // 卡片数据。
    @NameInMap("cardData")
    public CreateTopboxRequestCardData cardData;

    // 卡片设置项。
    @NameInMap("cardSettings")
    public CreateTopboxRequestCardSettings cardSettings;

    // 互动卡片的消息模板ID
    @NameInMap("cardTemplateId")
    public String cardTemplateId;

    // 会话类型。
    @NameInMap("conversationType")
    public Integer conversationType;

    // 酷应用编码。
    @NameInMap("coolAppCode")
    public String coolAppCode;

    // 吊顶的过期时间，绝对时间。
    @NameInMap("expiredTime")
    public Long expiredTime;

    // 群模板id。
    @NameInMap("groupTemplateId")
    public String groupTemplateId;

    // 会话id。
    @NameInMap("openConversationId")
    public String openConversationId;

    // 唯一标识一张卡片的外部ID。
    @NameInMap("outTrackId")
    public String outTrackId;

    // 期望吊顶的端，如果有多个用“｜”分隔。 例如：ios|mac|android|win表示iOS、MAC、安卓和windows端。
    @NameInMap("platforms")
    public String platforms;

    // 吊顶可见者unionId，最多可传100个unionId。
    @NameInMap("receiverUnionIdList")
    public java.util.List<String> receiverUnionIdList;

    // 吊顶可见者userId，最多可传100个userId。
    @NameInMap("receiverUserIdList")
    public java.util.List<String> receiverUserIdList;

    // 单聊助手会话，机器人编码。
    @NameInMap("robotCode")
    public String robotCode;

    // 卡片模板unionId差异用户参数。
    @NameInMap("unionIdPrivateDataMap")
    public java.util.Map<String, UnionIdPrivateDataMapValue> unionIdPrivateDataMap;

    // 单聊助手会话，用户unionId。
    @NameInMap("unoinId")
    public String unoinId;

    // 单聊助手会话，用户userId。
    @NameInMap("userId")
    public String userId;

    // 卡片模板userId差异用户参数。
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
        // 卡片模板内容替换参数，包含普通文本类型和多媒体类型。
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
        // 是否开启卡片纯拉模式。
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
