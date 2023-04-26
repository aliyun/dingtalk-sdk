// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupCapacityInquiryResponseBody extends TeaModel {
    @NameInMap("actualPrice")
    public Long actualPrice;

    @NameInMap("createdAt")
    public Long createdAt;

    @NameInMap("currentCapacity")
    public Integer currentCapacity;

    @NameInMap("currentEffectUntil")
    public Long currentEffectUntil;

    @NameInMap("discount")
    public Integer discount;

    @NameInMap("extInfo")
    public java.util.Map<String, ?> extInfo;

    @NameInMap("groupOwner")
    public String groupOwner;

    @NameInMap("groupTitle")
    public String groupTitle;

    @NameInMap("markedPrice")
    public Long markedPrice;

    @NameInMap("memberCount")
    public Integer memberCount;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("operator")
    public String operator;

    @NameInMap("targetCapacity")
    public Integer targetCapacity;

    @NameInMap("targetEffectUntil")
    public Long targetEffectUntil;

    @NameInMap("token")
    public String token;

    public static GroupCapacityInquiryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GroupCapacityInquiryResponseBody self = new GroupCapacityInquiryResponseBody();
        return TeaModel.build(map, self);
    }

    public GroupCapacityInquiryResponseBody setActualPrice(Long actualPrice) {
        this.actualPrice = actualPrice;
        return this;
    }
    public Long getActualPrice() {
        return this.actualPrice;
    }

    public GroupCapacityInquiryResponseBody setCreatedAt(Long createdAt) {
        this.createdAt = createdAt;
        return this;
    }
    public Long getCreatedAt() {
        return this.createdAt;
    }

    public GroupCapacityInquiryResponseBody setCurrentCapacity(Integer currentCapacity) {
        this.currentCapacity = currentCapacity;
        return this;
    }
    public Integer getCurrentCapacity() {
        return this.currentCapacity;
    }

    public GroupCapacityInquiryResponseBody setCurrentEffectUntil(Long currentEffectUntil) {
        this.currentEffectUntil = currentEffectUntil;
        return this;
    }
    public Long getCurrentEffectUntil() {
        return this.currentEffectUntil;
    }

    public GroupCapacityInquiryResponseBody setDiscount(Integer discount) {
        this.discount = discount;
        return this;
    }
    public Integer getDiscount() {
        return this.discount;
    }

    public GroupCapacityInquiryResponseBody setExtInfo(java.util.Map<String, ?> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, ?> getExtInfo() {
        return this.extInfo;
    }

    public GroupCapacityInquiryResponseBody setGroupOwner(String groupOwner) {
        this.groupOwner = groupOwner;
        return this;
    }
    public String getGroupOwner() {
        return this.groupOwner;
    }

    public GroupCapacityInquiryResponseBody setGroupTitle(String groupTitle) {
        this.groupTitle = groupTitle;
        return this;
    }
    public String getGroupTitle() {
        return this.groupTitle;
    }

    public GroupCapacityInquiryResponseBody setMarkedPrice(Long markedPrice) {
        this.markedPrice = markedPrice;
        return this;
    }
    public Long getMarkedPrice() {
        return this.markedPrice;
    }

    public GroupCapacityInquiryResponseBody setMemberCount(Integer memberCount) {
        this.memberCount = memberCount;
        return this;
    }
    public Integer getMemberCount() {
        return this.memberCount;
    }

    public GroupCapacityInquiryResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GroupCapacityInquiryResponseBody setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public GroupCapacityInquiryResponseBody setTargetCapacity(Integer targetCapacity) {
        this.targetCapacity = targetCapacity;
        return this;
    }
    public Integer getTargetCapacity() {
        return this.targetCapacity;
    }

    public GroupCapacityInquiryResponseBody setTargetEffectUntil(Long targetEffectUntil) {
        this.targetEffectUntil = targetEffectUntil;
        return this;
    }
    public Long getTargetEffectUntil() {
        return this.targetEffectUntil;
    }

    public GroupCapacityInquiryResponseBody setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

}
