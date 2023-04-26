// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreStoreInfoResponseBody extends TeaModel {
    @NameInMap("address")
    public String address;

    @NameInMap("businessHours")
    public String businessHours;

    @NameInMap("dingDeptId")
    public Long dingDeptId;

    @NameInMap("latitude")
    public String latitude;

    @NameInMap("locationAddress")
    public String locationAddress;

    @NameInMap("longitude")
    public String longitude;

    @NameInMap("name")
    public String name;

    @NameInMap("parentId")
    public Long parentId;

    @NameInMap("status")
    public String status;

    @NameInMap("storeAcreage")
    public String storeAcreage;

    @NameInMap("storeBandwidth")
    public String storeBandwidth;

    @NameInMap("storeCode")
    public String storeCode;

    @NameInMap("storeId")
    public Long storeId;

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

    public DigitalStoreStoreInfoResponseBody setDingDeptId(Long dingDeptId) {
        this.dingDeptId = dingDeptId;
        return this;
    }
    public Long getDingDeptId() {
        return this.dingDeptId;
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
