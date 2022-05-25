// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentInfoRequest extends TeaModel {
    @NameInMap("address")
    public String address;

    // 建筑面积，组多支持2位小数，总长不超过8位
    @NameInMap("buildingArea")
    public Float buildingArea;

    // 市的名字，有值时provName必填
    @NameInMap("cityName")
    public String cityName;

    // 1纯住宅；2:商住混合；3:办公；4:办公商业混合；5:商业；6:公共场所；7:其他
    @NameInMap("communityType")
    public Long communityType;

    // 区/县名，有值是provName，cityName必填
    @NameInMap("countyName")
    public String countyName;

    // 经纬度，格式：经度,纬度
    @NameInMap("location")
    public String location;

    // 小区名
    @NameInMap("name")
    public String name;

    // 省的名字
    @NameInMap("provName")
    public String provName;

    // 小区状态：0正常/1关闭/2作废
    @NameInMap("state")
    public Long state;

    // 小区服务电话
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
