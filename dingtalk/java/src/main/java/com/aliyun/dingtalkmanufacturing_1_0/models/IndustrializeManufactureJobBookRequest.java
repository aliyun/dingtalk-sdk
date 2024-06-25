// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmanufacturing_1_0.models;

import com.aliyun.tea.*;

public class IndustrializeManufactureJobBookRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ding2fff8349a3ae0105d</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>[     { 		&quot;code&quot;: &quot;equipmentName&quot;， 		&quot;name&quot;: &quot;设备名称&quot;, 		&quot;value&quot;: &quot;8000&quot;, 		&quot;valueType&quot;: &quot;类型：字符串，数字等&quot; 	}, { 		&quot;code&quot;: &quot;唯一标识&quot;， 		&quot;name&quot;: &quot;自定义字段1&quot;, 		&quot;value&quot;: &quot;值&quot;, 		&quot;valueType&quot;: &quot;类型：字符串，数字等&quot; 	}, { 		&quot;code&quot;: &quot;唯一标识&quot;， 		&quot;name&quot;: &quot;自定义字段2&quot;, 		&quot;value&quot;: &quot;值&quot;, 		&quot;valueType&quot;: &quot;类型：字符串，数字等&quot; 	}  ]</p>
     */
    @NameInMap("extend")
    public String extend;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("instNo")
    public String instNo;

    /**
     * <strong>example:</strong>
     * <p>n</p>
     */
    @NameInMap("isBatchJob")
    public String isBatchJob;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2021-07-05 08:00:21</p>
     */
    @NameInMap("manufactureDate")
    public String manufactureDate;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mesAppKey")
    public String mesAppKey;

    @NameInMap("processEnName")
    public String processEnName;

    @NameInMap("processName")
    public String processName;

    @NameInMap("productCode")
    public String productCode;

    @NameInMap("productEnName")
    public String productEnName;

    @NameInMap("productName")
    public String productName;

    @NameInMap("productSpecification")
    public String productSpecification;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("qualifiedQuantity")
    public String qualifiedQuantity;

    @NameInMap("reworkableQuantity")
    public String reworkableQuantity;

    @NameInMap("scrappedQuantity")
    public String scrappedQuantity;

    /**
     * <strong>example:</strong>
     * <p>1.02</p>
     */
    @NameInMap("unitPrice")
    public String unitPrice;

    /**
     * <strong>example:</strong>
     * <p>1919442747879777, 1919442747879774</p>
     */
    @NameInMap("userIdList")
    public String userIdList;

    @NameInMap("userName")
    public String userName;

    /**
     * <strong>example:</strong>
     * <p>张三,李四</p>
     */
    @NameInMap("userNameList")
    public String userNameList;

    /**
     * <p>This parameter is required.</p>
     */
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
