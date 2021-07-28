// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureJobBookRequest extends TeaModel {
    // 报废数量
    @NameInMap("scrappedQuantity")
    public String scrappedQuantity;

    // 产品规格
    @NameInMap("productSpecification")
    public String productSpecification;

    // 合格数量
    @NameInMap("qualifiedQuantity")
    public String qualifiedQuantity;

    // 可重工数量
    @NameInMap("reworkableQuantity")
    public String reworkableQuantity;

    // 员工姓名
    @NameInMap("userName")
    public String userName;

    // 随机串，唯一标识(用于幂等及更新)
    @NameInMap("uuid")
    public String uuid;

    // 产品名称，例如"双头螺柱001"
    @NameInMap("productName")
    public String productName;

    // 产品英文名称
    @NameInMap("productEnName")
    public String productEnName;

    // 扩展字段，用于增加自定义字段
    @NameInMap("extend")
    public String extend;

    // 产品唯一标识
    @NameInMap("productCode")
    public String productCode;

    // 制程名称
    @NameInMap("processName")
    public String processName;

    // 制程英文名称
    @NameInMap("processEnName")
    public String processEnName;

    // mes 系统唯一标识
    @NameInMap("mesAppKey")
    public String mesAppKey;

    // 工单编号
    @NameInMap("instNo")
    public String instNo;

    // 生产日期时间(到时分秒)
    @NameInMap("manufactureDate")
    public String manufactureDate;

    // 钉钉组织id
    @NameInMap("dingCorpId")
    public String dingCorpId;

    public static IndustrializeManufactureJobBookRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustrializeManufactureJobBookRequest self = new IndustrializeManufactureJobBookRequest();
        return TeaModel.build(map, self);
    }

    public IndustrializeManufactureJobBookRequest setScrappedQuantity(String scrappedQuantity) {
        this.scrappedQuantity = scrappedQuantity;
        return this;
    }
    public String getScrappedQuantity() {
        return this.scrappedQuantity;
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

    public IndustrializeManufactureJobBookRequest setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

    public IndustrializeManufactureJobBookRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public IndustrializeManufactureJobBookRequest setProductName(String productName) {
        this.productName = productName;
        return this;
    }
    public String getProductName() {
        return this.productName;
    }

    public IndustrializeManufactureJobBookRequest setProductEnName(String productEnName) {
        this.productEnName = productEnName;
        return this;
    }
    public String getProductEnName() {
        return this.productEnName;
    }

    public IndustrializeManufactureJobBookRequest setExtend(String extend) {
        this.extend = extend;
        return this;
    }
    public String getExtend() {
        return this.extend;
    }

    public IndustrializeManufactureJobBookRequest setProductCode(String productCode) {
        this.productCode = productCode;
        return this;
    }
    public String getProductCode() {
        return this.productCode;
    }

    public IndustrializeManufactureJobBookRequest setProcessName(String processName) {
        this.processName = processName;
        return this;
    }
    public String getProcessName() {
        return this.processName;
    }

    public IndustrializeManufactureJobBookRequest setProcessEnName(String processEnName) {
        this.processEnName = processEnName;
        return this;
    }
    public String getProcessEnName() {
        return this.processEnName;
    }

    public IndustrializeManufactureJobBookRequest setMesAppKey(String mesAppKey) {
        this.mesAppKey = mesAppKey;
        return this;
    }
    public String getMesAppKey() {
        return this.mesAppKey;
    }

    public IndustrializeManufactureJobBookRequest setInstNo(String instNo) {
        this.instNo = instNo;
        return this;
    }
    public String getInstNo() {
        return this.instNo;
    }

    public IndustrializeManufactureJobBookRequest setManufactureDate(String manufactureDate) {
        this.manufactureDate = manufactureDate;
        return this;
    }
    public String getManufactureDate() {
        return this.manufactureDate;
    }

    public IndustrializeManufactureJobBookRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

}
