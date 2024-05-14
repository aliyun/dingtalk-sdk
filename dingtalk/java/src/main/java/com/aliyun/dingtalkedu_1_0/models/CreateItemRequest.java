// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateItemRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("effectType")
    public Long effectType;

    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("merchantId")
    public String merchantId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("optUser")
    public String optUser;

    @NameInMap("periodType")
    public Long periodType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("price")
    public Long price;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("scene")
    public Long scene;

    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("type")
    public Long type;

    public static CreateItemRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateItemRequest self = new CreateItemRequest();
        return TeaModel.build(map, self);
    }

    public CreateItemRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CreateItemRequest setEffectType(Long effectType) {
        this.effectType = effectType;
        return this;
    }
    public Long getEffectType() {
        return this.effectType;
    }

    public CreateItemRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CreateItemRequest setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public CreateItemRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateItemRequest setOptUser(String optUser) {
        this.optUser = optUser;
        return this;
    }
    public String getOptUser() {
        return this.optUser;
    }

    public CreateItemRequest setPeriodType(Long periodType) {
        this.periodType = periodType;
        return this;
    }
    public Long getPeriodType() {
        return this.periodType;
    }

    public CreateItemRequest setPrice(Long price) {
        this.price = price;
        return this;
    }
    public Long getPrice() {
        return this.price;
    }

    public CreateItemRequest setScene(Long scene) {
        this.scene = scene;
        return this;
    }
    public Long getScene() {
        return this.scene;
    }

    public CreateItemRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CreateItemRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public CreateItemRequest setType(Long type) {
        this.type = type;
        return this;
    }
    public Long getType() {
        return this.type;
    }

}
