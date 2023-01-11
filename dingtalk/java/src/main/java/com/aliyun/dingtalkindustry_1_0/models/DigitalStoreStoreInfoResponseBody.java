// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreStoreInfoResponseBody extends TeaModel {
    /**
     * <p>门店地址</p>
     */
    @NameInMap("address")
    public String address;

    /**
     * <p>营业时间</p>
     */
    @NameInMap("businessHours")
    public String businessHours;

    /**
     * <p>纬度</p>
     */
    @NameInMap("latitude")
    public String latitude;

    /**
     * <p>定位地址</p>
     */
    @NameInMap("locationAddress")
    public String locationAddress;

    /**
     * <p>经度</p>
     */
    @NameInMap("longitude")
    public String longitude;

    /**
     * <p>门店名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>上级节点id</p>
     */
    @NameInMap("parentId")
    public Long parentId;

    /**
     * <p>门店状态</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>门店面积</p>
     */
    @NameInMap("storeAcreage")
    public String storeAcreage;

    /**
     * <p>门店带宽</p>
     */
    @NameInMap("storeBandwidth")
    public String storeBandwidth;

    /**
     * <p>门店编号</p>
     */
    @NameInMap("storeCode")
    public String storeCode;

    /**
     * <p>门店Id</p>
     */
    @NameInMap("storeId")
    public Long storeId;

    /**
     * <p>门店电话</p>
     */
    @NameInMap("telephone")
    public String telephone;

    public static DigitalStoreStoreInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreStoreInfoResponseBody self = new DigitalStoreStoreInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreStoreInfoResponseBody setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public DigitalStoreStoreInfoResponseBody setBusinessHours(String businessHours) {
        this.businessHours = businessHours;
        return this;
    }
    public String getBusinessHours() {
        return this.businessHours;
    }

    public DigitalStoreStoreInfoResponseBody setLatitude(String latitude) {
        this.latitude = latitude;
        return this;
    }
    public String getLatitude() {
        return this.latitude;
    }

    public DigitalStoreStoreInfoResponseBody setLocationAddress(String locationAddress) {
        this.locationAddress = locationAddress;
        return this;
    }
    public String getLocationAddress() {
        return this.locationAddress;
    }

    public DigitalStoreStoreInfoResponseBody setLongitude(String longitude) {
        this.longitude = longitude;
        return this;
    }
    public String getLongitude() {
        return this.longitude;
    }

    public DigitalStoreStoreInfoResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public DigitalStoreStoreInfoResponseBody setParentId(Long parentId) {
        this.parentId = parentId;
        return this;
    }
    public Long getParentId() {
        return this.parentId;
    }

    public DigitalStoreStoreInfoResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public DigitalStoreStoreInfoResponseBody setStoreAcreage(String storeAcreage) {
        this.storeAcreage = storeAcreage;
        return this;
    }
    public String getStoreAcreage() {
        return this.storeAcreage;
    }

    public DigitalStoreStoreInfoResponseBody setStoreBandwidth(String storeBandwidth) {
        this.storeBandwidth = storeBandwidth;
        return this;
    }
    public String getStoreBandwidth() {
        return this.storeBandwidth;
    }

    public DigitalStoreStoreInfoResponseBody setStoreCode(String storeCode) {
        this.storeCode = storeCode;
        return this;
    }
    public String getStoreCode() {
        return this.storeCode;
    }

    public DigitalStoreStoreInfoResponseBody setStoreId(Long storeId) {
        this.storeId = storeId;
        return this;
    }
    public Long getStoreId() {
        return this.storeId;
    }

    public DigitalStoreStoreInfoResponseBody setTelephone(String telephone) {
        this.telephone = telephone;
        return this;
    }
    public String getTelephone() {
        return this.telephone;
    }

}
