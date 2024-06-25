// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusUpdateCampusRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>锦城街道和谐社区101号</p>
     */
    @NameInMap("address")
    public String address;

    /**
     * <strong>example:</strong>
     * <p>5200.13（平方米）</p>
     */
    @NameInMap("area")
    public Double area;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("belongProjectGroupId")
    public Long belongProjectGroupId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12345</p>
     */
    @NameInMap("campusDeptId")
    public Long campusDeptId;

    /**
     * <strong>example:</strong>
     * <p>绿城未来park</p>
     */
    @NameInMap("campusName")
    public String campusName;

    /**
     * <strong>example:</strong>
     * <p>10000</p>
     */
    @NameInMap("capacity")
    public Integer capacity;

    /**
     * <strong>example:</strong>
     * <p>371500</p>
     */
    @NameInMap("cityId")
    public Integer cityId;

    /**
     * <strong>example:</strong>
     * <p>中国</p>
     */
    @NameInMap("country")
    public String country;

    /**
     * <strong>example:</strong>
     * <p>371502</p>
     */
    @NameInMap("countyId")
    public Integer countyId;

    /**
     * <strong>example:</strong>
     * <p>绿城产业</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <strong>example:</strong>
     * <p>{&quot;creator&quot;:&quot;dsy&quot;}</p>
     */
    @NameInMap("extend")
    public String extend;

    /**
     * <strong>example:</strong>
     * <p>1655704317794</p>
     */
    @NameInMap("orderEndTime")
    public Long orderEndTime;

    /**
     * <strong>example:</strong>
     * <p>线下付款</p>
     */
    @NameInMap("orderInfo")
    public Long orderInfo;

    /**
     * <strong>example:</strong>
     * <p>1655704317794</p>
     */
    @NameInMap("orderStartTime")
    public Long orderStartTime;

    /**
     * <strong>example:</strong>
     * <p>370000（山东）</p>
     */
    @NameInMap("provId")
    public Integer provId;

    /**
     * <strong>example:</strong>
     * <p>156XXXX338</p>
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
