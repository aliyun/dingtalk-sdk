// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreStoreInfoResponseBody extends TeaModel {
    // 门店地址
    @NameInMap("address")
    public String address;

    // 营业时间
    @NameInMap("businessHours")
    public String businessHours;

    // 纬度
    @NameInMap("latitude")
    public String latitude;

    // 定位地址
    @NameInMap("locationAddress")
    public String locationAddress;

    // 经度
    @NameInMap("longitude")
    public String longitude;

    // 门店名称
    @NameInMap("name")
    public String name;

    // 上级节点id
    @NameInMap("parentId")
    public Long parentId;

    // 门店状态
    @NameInMap("status")
    public String status;

    // 门店面积
    @NameInMap("storeAcreage")
    public String storeAcreage;

    // 门店带宽
    @NameInMap("storeBandwidth")
    public String storeBandwidth;

    // 门店编号
    @NameInMap("storeCode")
    public String storeCode;

    // 门店Id
    @NameInMap("storeId")
    public Long storeId;

    // 门店电话
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
