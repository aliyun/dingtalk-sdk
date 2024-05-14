// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class CreateSpaceRequest extends TeaModel {
    @NameInMap("billingArea")
    public Float billingArea;

    @NameInMap("buildingArea")
    public Float buildingArea;

    @NameInMap("floor")
    public String floor;

    @NameInMap("houseState")
    public Long houseState;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("parentDeptId")
    public String parentDeptId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tagCode")
    public String tagCode;

    @NameInMap("type")
    public String type;

    public static CreateSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSpaceRequest self = new CreateSpaceRequest();
        return TeaModel.build(map, self);
    }

    public CreateSpaceRequest setBillingArea(Float billingArea) {
        this.billingArea = billingArea;
        return this;
    }
    public Float getBillingArea() {
        return this.billingArea;
    }

    public CreateSpaceRequest setBuildingArea(Float buildingArea) {
        this.buildingArea = buildingArea;
        return this;
    }
    public Float getBuildingArea() {
        return this.buildingArea;
    }

    public CreateSpaceRequest setFloor(String floor) {
        this.floor = floor;
        return this;
    }
    public String getFloor() {
        return this.floor;
    }

    public CreateSpaceRequest setHouseState(Long houseState) {
        this.houseState = houseState;
        return this;
    }
    public Long getHouseState() {
        return this.houseState;
    }

    public CreateSpaceRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateSpaceRequest setParentDeptId(String parentDeptId) {
        this.parentDeptId = parentDeptId;
        return this;
    }
    public String getParentDeptId() {
        return this.parentDeptId;
    }

    public CreateSpaceRequest setTagCode(String tagCode) {
        this.tagCode = tagCode;
        return this;
    }
    public String getTagCode() {
        return this.tagCode;
    }

    public CreateSpaceRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
