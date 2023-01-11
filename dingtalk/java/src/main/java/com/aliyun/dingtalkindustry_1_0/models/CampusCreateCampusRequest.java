// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusCreateCampusRequest extends TeaModel {
    /**
     * <p>园区所在详细地址</p>
     */
    @NameInMap("address")
    public String address;

    /**
     * <p>园区面积，单位：平方千米</p>
     */
    @NameInMap("area")
    public Double area;

    /**
     * <p>归属项目组</p>
     */
    @NameInMap("belongProjectGroupId")
    public Long belongProjectGroupId;

    /**
     * <p>园区项目名</p>
     */
    @NameInMap("campusName")
    public String campusName;

    /**
     * <p>园区容量</p>
     */
    @NameInMap("capacity")
    public Integer capacity;

    /**
     * <p>园区所在市行政编码</p>
     */
    @NameInMap("cityId")
    public Integer cityId;

    /**
     * <p>园区所在国家</p>
     */
    @NameInMap("country")
    public String country;

    /**
     * <p>园区所在区行政编码</p>
     */
    @NameInMap("countyId")
    public Integer countyId;

    /**
     * <p>创建人的unionId</p>
     */
    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    /**
     * <p>园区项目描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>扩展字段</p>
     */
    @NameInMap("extend")
    public String extend;

    /**
     * <p>园区经纬度,格式：经度,纬度</p>
     */
    @NameInMap("location")
    public String location;

    @NameInMap("orderEndTime")
    public Long orderEndTime;

    @NameInMap("orderInfo")
    public String orderInfo;

    /**
     * <p>项目订购开始时间</p>
     */
    @NameInMap("orderStartTime")
    public Long orderStartTime;

    /**
     * <p>园区所在省行政编码</p>
     */
    @NameInMap("provId")
    public Integer provId;

    /**
     * <p>联系电话</p>
     */
    @NameInMap("telephone")
    public String telephone;

    public static CampusCreateCampusRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusCreateCampusRequest self = new CampusCreateCampusRequest();
        return TeaModel.build(map, self);
    }

    public CampusCreateCampusRequest setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public CampusCreateCampusRequest setArea(Double area) {
        this.area = area;
        return this;
    }
    public Double getArea() {
        return this.area;
    }

    public CampusCreateCampusRequest setBelongProjectGroupId(Long belongProjectGroupId) {
        this.belongProjectGroupId = belongProjectGroupId;
        return this;
    }
    public Long getBelongProjectGroupId() {
        return this.belongProjectGroupId;
    }

    public CampusCreateCampusRequest setCampusName(String campusName) {
        this.campusName = campusName;
        return this;
    }
    public String getCampusName() {
        return this.campusName;
    }

    public CampusCreateCampusRequest setCapacity(Integer capacity) {
        this.capacity = capacity;
        return this;
    }
    public Integer getCapacity() {
        return this.capacity;
    }

    public CampusCreateCampusRequest setCityId(Integer cityId) {
        this.cityId = cityId;
        return this;
    }
    public Integer getCityId() {
        return this.cityId;
    }

    public CampusCreateCampusRequest setCountry(String country) {
        this.country = country;
        return this;
    }
    public String getCountry() {
        return this.country;
    }

    public CampusCreateCampusRequest setCountyId(Integer countyId) {
        this.countyId = countyId;
        return this;
    }
    public Integer getCountyId() {
        return this.countyId;
    }

    public CampusCreateCampusRequest setCreatorUnionId(String creatorUnionId) {
        this.creatorUnionId = creatorUnionId;
        return this;
    }
    public String getCreatorUnionId() {
        return this.creatorUnionId;
    }

    public CampusCreateCampusRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CampusCreateCampusRequest setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public CampusCreateCampusRequest setLocation(String location) {
        this.location = location;
        return this;
    }
    public String getLocation() {
        return this.location;
    }

    public CampusCreateCampusRequest setOrderEndTime(Long orderEndTime) {
        this.orderEndTime = orderEndTime;
        return this;
    }
    public Long getOrderEndTime() {
        return this.orderEndTime;
    }

    public CampusCreateCampusRequest setOrderInfo(String orderInfo) {
        this.orderInfo = orderInfo;
        return this;
    }
    public String getOrderInfo() {
        return this.orderInfo;
    }

    public CampusCreateCampusRequest setOrderStartTime(Long orderStartTime) {
        this.orderStartTime = orderStartTime;
        return this;
    }
    public Long getOrderStartTime() {
        return this.orderStartTime;
    }

    public CampusCreateCampusRequest setProvId(Integer provId) {
        this.provId = provId;
        return this;
    }
    public Integer getProvId() {
        return this.provId;
    }

    public CampusCreateCampusRequest setTelephone(String telephone) {
        this.telephone = telephone;
        return this;
    }
    public String getTelephone() {
        return this.telephone;
    }

}
