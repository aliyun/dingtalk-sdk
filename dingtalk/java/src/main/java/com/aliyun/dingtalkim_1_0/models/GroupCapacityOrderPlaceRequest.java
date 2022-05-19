// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupCapacityOrderPlaceRequest extends TeaModel {
    // 实际价格
    @NameInMap("actualPrice")
    public Long actualPrice;

    // 当前容量
    @NameInMap("currentCapacity")
    public Integer currentCapacity;

    // 当前操当前容量生效至何时
    @NameInMap("currentEffectUntil")
    public Long currentEffectUntil;

    // 折扣
    @NameInMap("discount")
    public Integer discount;

    // 扩展信息
    @NameInMap("extInfo")
    public java.util.Map<String, ?> extInfo;

    // 标价
    @NameInMap("markedPrice")
    public Long markedPrice;

    // 开放的群id
    @NameInMap("openConversationId")
    public String openConversationId;

    // 当前操作人工号
    @NameInMap("operator")
    public String operator;

    // 目标容量
    @NameInMap("targetCapacity")
    public Integer targetCapacity;

    // 目标容量生效至何时
    @NameInMap("targetEffectUntil")
    public Long targetEffectUntil;

    // 校验令牌
    @NameInMap("token")
    public String token;

    public static GroupCapacityOrderPlaceRequest build(java.util.Map<String, ?> map) throws Exception {
        GroupCapacityOrderPlaceRequest self = new GroupCapacityOrderPlaceRequest();
        return TeaModel.build(map, self);
    }

    public GroupCapacityOrderPlaceRequest setActualPrice(Long actualPrice) {
        this.actualPrice = actualPrice;
        return this;
    }
    public Long getActualPrice() {
        return this.actualPrice;
    }

    public GroupCapacityOrderPlaceRequest setCurrentCapacity(Integer currentCapacity) {
        this.currentCapacity = currentCapacity;
        return this;
    }
    public Integer getCurrentCapacity() {
        return this.currentCapacity;
    }

    public GroupCapacityOrderPlaceRequest setCurrentEffectUntil(Long currentEffectUntil) {
        this.currentEffectUntil = currentEffectUntil;
        return this;
    }
    public Long getCurrentEffectUntil() {
        return this.currentEffectUntil;
    }

    public GroupCapacityOrderPlaceRequest setDiscount(Integer discount) {
        this.discount = discount;
        return this;
    }
    public Integer getDiscount() {
        return this.discount;
    }

    public GroupCapacityOrderPlaceRequest setExtInfo(java.util.Map<String, ?> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, ?> getExtInfo() {
        return this.extInfo;
    }

    public GroupCapacityOrderPlaceRequest setMarkedPrice(Long markedPrice) {
        this.markedPrice = markedPrice;
        return this;
    }
    public Long getMarkedPrice() {
        return this.markedPrice;
    }

    public GroupCapacityOrderPlaceRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GroupCapacityOrderPlaceRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public GroupCapacityOrderPlaceRequest setTargetCapacity(Integer targetCapacity) {
        this.targetCapacity = targetCapacity;
        return this;
    }
    public Integer getTargetCapacity() {
        return this.targetCapacity;
    }

    public GroupCapacityOrderPlaceRequest setTargetEffectUntil(Long targetEffectUntil) {
        this.targetEffectUntil = targetEffectUntil;
        return this;
    }
    public Long getTargetEffectUntil() {
        return this.targetEffectUntil;
    }

    public GroupCapacityOrderPlaceRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

}
