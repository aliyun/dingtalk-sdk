// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentInfoRequest extends TeaModel {
    @NameInMap("address")
    public String address;

    @NameInMap("buildingArea")
    public Float buildingArea;

    @NameInMap("cityName")
    public String cityName;

    @NameInMap("communityType")
    public Long communityType;

    @NameInMap("countyName")
    public String countyName;

    @NameInMap("location")
    public String location;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试小区1</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("provName")
    public String provName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("state")
    public Long state;

    @NameInMap("telephone")
    public String telephone;

    public static UpdateResidentInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentInfoRequest self = new UpdateResidentInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateResidentInfoRequest setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public UpdateResidentInfoRequest setBuildingArea(Float buildingArea) {
        this.buildingArea = buildingArea;
        return this;
    }
    public Float getBuildingArea() {
        return this.buildingArea;
    }

    public UpdateResidentInfoRequest setCityName(String cityName) {
        this.cityName = cityName;
        return this;
    }
    public String getCityName() {
        return this.cityName;
    }

    public UpdateResidentInfoRequest setCommunityType(Long communityType) {
        this.communityType = communityType;
        return this;
    }
    public Long getCommunityType() {
        return this.communityType;
    }

    public UpdateResidentInfoRequest setCountyName(String countyName) {
        this.countyName = countyName;
        return this;
    }
    public String getCountyName() {
        return this.countyName;
    }

    public UpdateResidentInfoRequest setLocation(String location) {
        this.location = location;
        return this;
    }
    public String getLocation() {
        return this.location;
    }

    public UpdateResidentInfoRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateResidentInfoRequest setProvName(String provName) {
        this.provName = provName;
        return this;
    }
    public String getProvName() {
        return this.provName;
    }

    public UpdateResidentInfoRequest setState(Long state) {
        this.state = state;
        return this;
    }
    public Long getState() {
        return this.state;
    }

    public UpdateResidentInfoRequest setTelephone(String telephone) {
        this.telephone = telephone;
        return this;
    }
    public String getTelephone() {
        return this.telephone;
    }

}
