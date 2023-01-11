// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateCampusRequest extends TeaModel {
    /**
     * <p>所在具体地址</p>
     */
    @NameInMap("address")
    public String address;

    /**
     * <p>面积</p>
     */
    @NameInMap("area")
    public Double area;

    /**
     * <p>归属项目组</p>
     */
    @NameInMap("belongProjectGroupId")
    public Long belongProjectGroupId;

    /**
     * <p>项目部门id</p>
     */
    @NameInMap("campusDeptId")
    public Long campusDeptId;

    /**
     * <p>园区项目名</p>
     */
    @NameInMap("campusName")
    public String campusName;

    /**
     * <p>容量</p>
     */
    @NameInMap("capacity")
    public Integer capacity;

    /**
     * <p>所在市行政编码</p>
     */
    @NameInMap("cityId")
    public Integer cityId;

    /**
     * <p>国家</p>
     */
    @NameInMap("country")
    public String country;

    /**
     * <p>所在区行政编码</p>
     */
    @NameInMap("countyId")
    public Integer countyId;

    /**
     * <p>园区项目描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>扩展信息</p>
     */
    @NameInMap("extend")
    public String extend;

    /**
     * <p>项目订阅到期时间</p>
     */
    @NameInMap("orderEndTime")
    public Long orderEndTime;

    /**
     * <p>购买信息</p>
     */
    @NameInMap("orderInfo")
    public Long orderInfo;

    /**
     * <p>项目订阅开始时间</p>
     */
    @NameInMap("orderStartTime")
    public Long orderStartTime;

    /**
     * <p>所在省行政编码</p>
     */
    @NameInMap("provId")
    public Integer provId;

    /**
     * <p>联系电话</p>
     */
    @NameInMap("telephone")
    public String telephone;

    public static CampusUpdateCampusRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusUpdateCampusRequest self = new CampusUpdateCampusRequest();
        return TeaModel.build(map, self);
    }

    public CampusUpdateCampusRequest setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public CampusUpdateCampusRequest setArea(Double area) {
        this.area = area;
        return this;
    }
    public Double getArea() {
        return this.area;
    }

    public CampusUpdateCampusRequest setBelongProjectGroupId(Long belongProjectGroupId) {
        this.belongProjectGroupId = belongProjectGroupId;
        return this;
    }
    public Long getBelongProjectGroupId() {
        return this.belongProjectGroupId;
    }

    public CampusUpdateCampusRequest setCampusDeptId(Long campusDeptId) {
        this.campusDeptId = campusDeptId;
        return this;
    }
    public Long getCampusDeptId() {
        return this.campusDeptId;
    }

    public CampusUpdateCampusRequest setCampusName(String campusName) {
        this.campusName = campusName;
        return this;
    }
    public String getCampusName() {
        return this.campusName;
    }

    public CampusUpdateCampusRequest setCapacity(Integer capacity) {
        this.capacity = capacity;
        return this;
    }
    public Integer getCapacity() {
        return this.capacity;
    }

    public CampusUpdateCampusRequest setCityId(Integer cityId) {
        this.cityId = cityId;
        return this;
    }
    public Integer getCityId() {
        return this.cityId;
    }

    public CampusUpdateCampusRequest setCountry(String country) {
        this.country = country;
        return this;
    }
    public String getCountry() {
        return this.country;
    }

    public CampusUpdateCampusRequest setCountyId(Integer countyId) {
        this.countyId = countyId;
        return this;
    }
    public Integer getCountyId() {
        return this.countyId;
    }

    public CampusUpdateCampusRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public CampusUpdateCampusRequest setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public CampusUpdateCampusRequest setOrderEndTime(Long orderEndTime) {
        this.orderEndTime = orderEndTime;
        return this;
    }
    public Long getOrderEndTime() {
        return this.orderEndTime;
    }

    public CampusUpdateCampusRequest setOrderInfo(Long orderInfo) {
        this.orderInfo = orderInfo;
        return this;
    }
    public Long getOrderInfo() {
        return this.orderInfo;
    }

    public CampusUpdateCampusRequest setOrderStartTime(Long orderStartTime) {
        this.orderStartTime = orderStartTime;
        return this;
    }
    public Long getOrderStartTime() {
        return this.orderStartTime;
    }

    public CampusUpdateCampusRequest setProvId(Integer provId) {
        this.provId = provId;
        return this;
    }
    public Integer getProvId() {
        return this.provId;
    }

    public CampusUpdateCampusRequest setTelephone(String telephone) {
        this.telephone = telephone;
        return this;
    }
    public String getTelephone() {
        return this.telephone;
    }

}
