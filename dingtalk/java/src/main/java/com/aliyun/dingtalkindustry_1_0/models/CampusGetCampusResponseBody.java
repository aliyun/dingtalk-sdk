// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetCampusResponseBody extends TeaModel {
    // 详细地址
    @NameInMap("address")
    public String address;

    // 面积
    @NameInMap("area")
    public Double area;

    // 项目组ID
    @NameInMap("belongProjectGroupId")
    public String belongProjectGroupId;

    // 园区组织ID
    @NameInMap("campusCorpId")
    public String campusCorpId;

    // 园区部门ID
    @NameInMap("campusDeptId")
    public Long campusDeptId;

    // 园区名称
    @NameInMap("campusName")
    public String campusName;

    // 容纳人数
    @NameInMap("capacity")
    public String capacity;

    // 市
    @NameInMap("cityId")
    public Integer cityId;

    // 国家
    @NameInMap("country")
    public String country;

    // 区
    @NameInMap("countyId")
    public Integer countyId;

    // 描述
    @NameInMap("description")
    public String description;

    // 扩展属性
    @NameInMap("extend")
    public String extend;

    // 经纬度
    @NameInMap("location")
    public String location;

    // 过期时间
    @NameInMap("orderEndTime")
    public Long orderEndTime;

    // 购买信息
    @NameInMap("orderInfo")
    public String orderInfo;

    // 订购时间
    @NameInMap("orderStartTime")
    public Long orderStartTime;

    // 省
    @NameInMap("provId")
    public Integer provId;

    // 电话
    @NameInMap("telephone")
    public String telephone;

    public static CampusGetCampusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusGetCampusResponseBody self = new CampusGetCampusResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusGetCampusResponseBody setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public CampusGetCampusResponseBody setArea(Double area) {
        this.area = area;
        return this;
    }
    public Double getArea() {
        return this.area;
    }

    public CampusGetCampusResponseBody setBelongProjectGroupId(String belongProjectGroupId) {
        this.belongProjectGroupId = belongProjectGroupId;
        return this;
    }
    public String getBelongProjectGroupId() {
        return this.belongProjectGroupId;
    }

    public CampusGetCampusResponseBody setCampusCorpId(String campusCorpId) {
        this.campusCorpId = campusCorpId;
        return this;
    }
    public String getCampusCorpId() {
        return this.campusCorpId;
    }

    public CampusGetCampusResponseBody setCampusDeptId(Long campusDeptId) {
        this.campusDeptId = campusDeptId;
        return this;
    }
    public Long getCampusDeptId() {
        return this.campusDeptId;
    }

    public CampusGetCampusResponseBody setCampusName(String campusName) {
        this.campusName = campusName;
        return this;
    }
    public String getCampusName() {
        return this.campusName;
    }

    public CampusGetCampusResponseBody setCapacity(String capacity) {
        this.capacity = capacity;
        return this;
    }
    public String getCapacity() {
        return this.capacity;
    }

    public CampusGetCampusResponseBody setCityId(Integer cityId) {
        this.cityId = cityId;
        return this;
    }
    public Integer getCityId() {
        return this.cityId;
    }

    public CampusGetCampusResponseBody setCountry(String country) {
        this.country = country;
        return this;
    }
    public String getCountry() {
        return this.country;
    }

    public CampusGetCampusResponseBody setCountyId(Integer countyId) {
        this.countyId = countyId;
        return this;
    }
    public Integer getCountyId() {
        return this.countyId;
    }

    public CampusGetCampusResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CampusGetCampusResponseBody setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public CampusGetCampusResponseBody setLocation(String location) {
        this.location = location;
        return this;
    }
    public String getLocation() {
        return this.location;
    }

    public CampusGetCampusResponseBody setOrderEndTime(Long orderEndTime) {
        this.orderEndTime = orderEndTime;
        return this;
    }
    public Long getOrderEndTime() {
        return this.orderEndTime;
    }

    public CampusGetCampusResponseBody setOrderInfo(String orderInfo) {
        this.orderInfo = orderInfo;
        return this;
    }
    public String getOrderInfo() {
        return this.orderInfo;
    }

    public CampusGetCampusResponseBody setOrderStartTime(Long orderStartTime) {
        this.orderStartTime = orderStartTime;
        return this;
    }
    public Long getOrderStartTime() {
        return this.orderStartTime;
    }

    public CampusGetCampusResponseBody setProvId(Integer provId) {
        this.provId = provId;
        return this;
    }
    public Integer getProvId() {
        return this.provId;
    }

    public CampusGetCampusResponseBody setTelephone(String telephone) {
        this.telephone = telephone;
        return this;
    }
    public String getTelephone() {
        return this.telephone;
    }

}
