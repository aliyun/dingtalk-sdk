// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupCapacityOrderPlaceResponseBody extends TeaModel {
    @NameInMap("actualPrice")
    public Long actualPrice;

    @NameInMap("currentCapacity")
    public Integer currentCapacity;

    @NameInMap("currentEffectUntil")
    public Long currentEffectUntil;

    @NameInMap("discount")
    public Integer discount;

    @NameInMap("extInfo")
    public java.util.Map<String, String> extInfo;

    @NameInMap("markedPrice")
    public Long markedPrice;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("operator")
    public String operator;

    @NameInMap("orderId")
    public String orderId;

    @NameInMap("targetCapacity")
    public Integer targetCapacity;

    @NameInMap("targetEffectUntil")
    public Long targetEffectUntil;

    @NameInMap("token")
    public String token;

    public static GroupCapacityOrderPlaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GroupCapacityOrderPlaceResponseBody self = new GroupCapacityOrderPlaceResponseBody();
        return TeaModel.build(map, self);
    }

    public GroupCapacityOrderPlaceResponseBody setActualPrice(Long actualPrice) {
        this.actualPrice = actualPrice;
        return this;
    }
    public Long getActualPrice() {
        return this.actualPrice;
    }

    public GroupCapacityOrderPlaceResponseBody setCurrentCapacity(Integer currentCapacity) {
        this.currentCapacity = currentCapacity;
        return this;
    }
    public Integer getCurrentCapacity() {
        return this.currentCapacity;
    }

    public GroupCapacityOrderPlaceResponseBody setCurrentEffectUntil(Long currentEffectUntil) {
        this.currentEffectUntil = currentEffectUntil;
        return this;
    }
    public Long getCurrentEffectUntil() {
        return this.currentEffectUntil;
    }

    public GroupCapacityOrderPlaceResponseBody setDiscount(Integer discount) {
        this.discount = discount;
        return this;
    }
    public Integer getDiscount() {
        return this.discount;
    }

    public GroupCapacityOrderPlaceResponseBody setExtInfo(java.util.Map<String, String> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, String> getExtInfo() {
        return this.extInfo;
    }

    public GroupCapacityOrderPlaceResponseBody setMarkedPrice(Long markedPrice) {
        this.markedPrice = markedPrice;
        return this;
    }
    public Long getMarkedPrice() {
        return this.markedPrice;
    }

    public GroupCapacityOrderPlaceResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GroupCapacityOrderPlaceResponseBody setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public GroupCapacityOrderPlaceResponseBody setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public GroupCapacityOrderPlaceResponseBody setTargetCapacity(Integer targetCapacity) {
        this.targetCapacity = targetCapacity;
        return this;
    }
    public Integer getTargetCapacity() {
        return this.targetCapacity;
    }

    public GroupCapacityOrderPlaceResponseBody setTargetEffectUntil(Long targetEffectUntil) {
        this.targetEffectUntil = targetEffectUntil;
        return this;
    }
    public Long getTargetEffectUntil() {
        return this.targetEffectUntil;
    }

    public GroupCapacityOrderPlaceResponseBody setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

}
