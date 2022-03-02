// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureJobBookRequest extends TeaModel {
    // 钉钉组织id
    @NameInMap("corpId")
    public String corpId;

    // 扩展字段，用于增加自定义字段
    @NameInMap("extend")
    public String extend;

    // 工单编号
    @NameInMap("instNo")
    public String instNo;

    // 是否是批量报工(取值[n,y])
    @NameInMap("isBatchJob")
    public String isBatchJob;

    // 生产日期时间(到时分秒)
    @NameInMap("manufactureDate")
    public String manufactureDate;

    // mes 系统唯一标识
    @NameInMap("mesAppKey")
    public String mesAppKey;

    // 制程英文名称
    @NameInMap("processEnName")
    public String processEnName;

    // 制程名称
    @NameInMap("processName")
    public String processName;

    // 产品唯一标识
    @NameInMap("productCode")
    public String productCode;

    // 产品英文名称
    @NameInMap("productEnName")
    public String productEnName;

    // 产品名称，例如"双头螺柱001"
    @NameInMap("productName")
    public String productName;

    // 产品规格
    @NameInMap("productSpecification")
    public String productSpecification;

    // 合格数量
    @NameInMap("qualifiedQuantity")
    public String qualifiedQuantity;

    // 可重工数量
    @NameInMap("reworkableQuantity")
    public String reworkableQuantity;

    // 报废数量
    @NameInMap("scrappedQuantity")
    public String scrappedQuantity;

    // 计件单价，单位：分
    @NameInMap("unitPrice")
    public String unitPrice;

    // 批量报工时多个工人userId以英文逗号分隔
    @NameInMap("userIdList")
    public String userIdList;

    // 员工姓名
    @NameInMap("userName")
    public String userName;

    // 批量报工时多个人名以英文逗号分隔
    @NameInMap("userNameList")
    public String userNameList;

    // 随机串，唯一标识(用于幂等及更新)
    @NameInMap("uuid")
    public String uuid;

    public static IndustrializeManufactureJobBookRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustrializeManufactureJobBookRequest self = new IndustrializeManufactureJobBookRequest();
        return TeaModel.build(map, self);
    }

    public IndustrializeManufactureJobBookRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public IndustrializeManufactureJobBookRequest setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public IndustrializeManufactureJobBookRequest setInstNo(String instNo) {
        this.instNo = instNo;
        return this;
    }
    public String getInstNo() {
        return this.instNo;
    }

    public IndustrializeManufactureJobBookRequest setIsBatchJob(String isBatchJob) {
        this.isBatchJob = isBatchJob;
        return this;
    }
    public String getIsBatchJob() {
        return this.isBatchJob;
    }

    public IndustrializeManufactureJobBookRequest setManufactureDate(String manufactureDate) {
        this.manufactureDate = manufactureDate;
        return this;
    }
    public String getManufactureDate() {
        return this.manufactureDate;
    }

    public IndustrializeManufactureJobBookRequest setMesAppKey(String mesAppKey) {
        this.mesAppKey = mesAppKey;
        return this;
    }
    public String getMesAppKey() {
        return this.mesAppKey;
    }

    public IndustrializeManufactureJobBookRequest setProcessEnName(String processEnName) {
        this.processEnName = processEnName;
        return this;
    }
    public String getProcessEnName() {
        return this.processEnName;
    }

    public IndustrializeManufactureJobBookRequest setProcessName(String processName) {
        this.processName = processName;
        return this;
    }
    public String getProcessName() {
        return this.processName;
    }

    public IndustrializeManufactureJobBookRequest setProductCode(String productCode) {
        this.productCode = productCode;
        return this;
    }
    public String getProductCode() {
        return this.productCode;
    }

    public IndustrializeManufactureJobBookRequest setProductEnName(String productEnName) {
        this.productEnName = productEnName;
        return this;
    }
    public String getProductEnName() {
        return this.productEnName;
    }

    public IndustrializeManufactureJobBookRequest setProductName(String productName) {
        this.productName = productName;
        return this;
    }
    public String getProductName() {
        return this.productName;
    }

    public IndustrializeManufactureJobBookRequest setProductSpecification(String productSpecification) {
        this.productSpecification = productSpecification;
        return this;
    }
    public String getProductSpecification() {
        return this.productSpecification;
    }

    public IndustrializeManufactureJobBookRequest setQualifiedQuantity(String qualifiedQuantity) {
        this.qualifiedQuantity = qualifiedQuantity;
        return this;
    }
    public String getQualifiedQuantity() {
        return this.qualifiedQuantity;
    }

    public IndustrializeManufactureJobBookRequest setReworkableQuantity(String reworkableQuantity) {
        this.reworkableQuantity = reworkableQuantity;
        return this;
    }
    public String getReworkableQuantity() {
        return this.reworkableQuantity;
    }

    public IndustrializeManufactureJobBookRequest setScrappedQuantity(String scrappedQuantity) {
        this.scrappedQuantity = scrappedQuantity;
        return this;
    }
    public String getScrappedQuantity() {
        return this.scrappedQuantity;
    }

    public IndustrializeManufactureJobBookRequest setUnitPrice(String unitPrice) {
        this.unitPrice = unitPrice;
        return this;
    }
    public String getUnitPrice() {
        return this.unitPrice;
    }

    public IndustrializeManufactureJobBookRequest setUserIdList(String userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public String getUserIdList() {
        return this.userIdList;
    }

    public IndustrializeManufactureJobBookRequest setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

    public IndustrializeManufactureJobBookRequest setUserNameList(String userNameList) {
        this.userNameList = userNameList;
        return this;
    }
    public String getUserNameList() {
        return this.userNameList;
    }

    public IndustrializeManufactureJobBookRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
