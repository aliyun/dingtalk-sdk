// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureQueryJobsRequest extends TeaModel {
    @NameInMap("currentPage")
    public Integer currentPage;

    @NameInMap("instNo")
    public String instNo;

    @NameInMap("manufactureDay")
    public String manufactureDay;

    @NameInMap("mesAppKey")
    public String mesAppKey;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("processName")
    public String processName;

    @NameInMap("productCode")
    public String productCode;

    @NameInMap("productName")
    public String productName;

    @NameInMap("productSpecification")
    public String productSpecification;

    @NameInMap("qualifiedQuantity")
    public String qualifiedQuantity;

    @NameInMap("unitPrice")
    public String unitPrice;

    @NameInMap("userId")
    public String userId;

    @NameInMap("userIdList")
    public String userIdList;

    @NameInMap("userName")
    public String userName;

    @NameInMap("uuid")
    public String uuid;

    public static IndustrializeManufactureQueryJobsRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustrializeManufactureQueryJobsRequest self = new IndustrializeManufactureQueryJobsRequest();
        return TeaModel.build(map, self);
    }

    public IndustrializeManufactureQueryJobsRequest setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

    public IndustrializeManufactureQueryJobsRequest setInstNo(String instNo) {
        this.instNo = instNo;
        return this;
    }
    public String getInstNo() {
        return this.instNo;
    }

    public IndustrializeManufactureQueryJobsRequest setManufactureDay(String manufactureDay) {
        this.manufactureDay = manufactureDay;
        return this;
    }
    public String getManufactureDay() {
        return this.manufactureDay;
    }

    public IndustrializeManufactureQueryJobsRequest setMesAppKey(String mesAppKey) {
        this.mesAppKey = mesAppKey;
        return this;
    }
    public String getMesAppKey() {
        return this.mesAppKey;
    }

    public IndustrializeManufactureQueryJobsRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public IndustrializeManufactureQueryJobsRequest setProcessName(String processName) {
        this.processName = processName;
        return this;
    }
    public String getProcessName() {
        return this.processName;
    }

    public IndustrializeManufactureQueryJobsRequest setProductCode(String productCode) {
        this.productCode = productCode;
        return this;
    }
    public String getProductCode() {
        return this.productCode;
    }

    public IndustrializeManufactureQueryJobsRequest setProductName(String productName) {
        this.productName = productName;
        return this;
    }
    public String getProductName() {
        return this.productName;
    }

    public IndustrializeManufactureQueryJobsRequest setProductSpecification(String productSpecification) {
        this.productSpecification = productSpecification;
        return this;
    }
    public String getProductSpecification() {
        return this.productSpecification;
    }

    public IndustrializeManufactureQueryJobsRequest setQualifiedQuantity(String qualifiedQuantity) {
        this.qualifiedQuantity = qualifiedQuantity;
        return this;
    }
    public String getQualifiedQuantity() {
        return this.qualifiedQuantity;
    }

    public IndustrializeManufactureQueryJobsRequest setUnitPrice(String unitPrice) {
        this.unitPrice = unitPrice;
        return this;
    }
    public String getUnitPrice() {
        return this.unitPrice;
    }

    public IndustrializeManufactureQueryJobsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public IndustrializeManufactureQueryJobsRequest setUserIdList(String userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public String getUserIdList() {
        return this.userIdList;
    }

    public IndustrializeManufactureQueryJobsRequest setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

    public IndustrializeManufactureQueryJobsRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
