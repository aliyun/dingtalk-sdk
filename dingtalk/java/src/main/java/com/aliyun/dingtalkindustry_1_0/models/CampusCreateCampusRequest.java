// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusCreateCampusRequest extends TeaModel {
    // 园区所在详细地址
    @NameInMap("address")
    public String address;

    // 园区面积
    @NameInMap("area")
    public Double area;

    // 归属项目组
    @NameInMap("belongProjectGroupId")
    public Long belongProjectGroupId;

    // 园区项目名
    @NameInMap("campusName")
    public String campusName;

    // 园区容量
    @NameInMap("capacity")
    public Integer capacity;

    // 园区所在市行政编码
    @NameInMap("cityId")
    public Integer cityId;

    // 园区所在国家
    @NameInMap("country")
    public String country;

    // 园区所在区行政编码
    @NameInMap("countyId")
    public Integer countyId;

    // 创建人的unionId
    @NameInMap("creatorUnionId")
    public String creatorUnionId;

    // 园区项目描述
    @NameInMap("description")
    public String description;

    // 扩展字段
    @NameInMap("extend")
    public String extend;

    // 项目订购结束时间
    @NameInMap("orderInfo")
    public Long orderInfo;

    // 项目订购开始时间
    @NameInMap("orderStartTime")
    public Long orderStartTime;

    // 园区所在省行政编码
    @NameInMap("provId")
    public Integer provId;

    // 联系电话
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

    public CampusCreateCampusRequest setOrderInfo(Long orderInfo) {
        this.orderInfo = orderInfo;
        return this;
    }
    public Long getOrderInfo() {
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
