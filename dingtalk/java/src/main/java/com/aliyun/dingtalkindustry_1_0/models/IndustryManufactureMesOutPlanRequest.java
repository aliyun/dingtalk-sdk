// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesOutPlanRequest extends TeaModel {
    // 审批状态
    @NameInMap("approvalStatus")
    public String approvalStatus;

    // 审批人
    @NameInMap("approver")
    public String approver;

    // 主数据名称
    @NameInMap("baseDataName")
    public String baseDataName;

    // 委外计划单号
    @NameInMap("outSourceProjectCode")
    public String outSourceProjectCode;

    // 委外群
    @NameInMap("outSourceTeamId")
    public String outSourceTeamId;

    // 单价（元）
    @NameInMap("price")
    public String price;

    // 工序识别码
    @NameInMap("processIdentificationCode")
    public String processIdentificationCode;

    // 委外的工序列表(多个)
    @NameInMap("processUuids")
    public String processUuids;

    // 产品代码(物料编号)
    @NameInMap("productCode")
    public String productCode;

    // 产品名称
    @NameInMap("productName")
    public String productName;

    // 规格型号
    @NameInMap("productSpecification")
    public String productSpecification;

    // 工单编号(生产任务单)
    @NameInMap("projectCode")
    public String projectCode;

    // 工单(生产计划单)ID
    @NameInMap("projectId")
    public String projectId;

    // 委外计划数
    @NameInMap("sendPlanQuantity")
    public String sendPlanQuantity;

    // 供应商代码
    @NameInMap("supplierCode")
    public String supplierCode;

    // 供应商名称
    @NameInMap("supplierName")
    public String supplierName;

    // 金额（元）
    @NameInMap("totalWage")
    public String totalWage;

    // 记录唯一标识
    @NameInMap("uuid")
    public String uuid;

    public static IndustryManufactureMesOutPlanRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesOutPlanRequest self = new IndustryManufactureMesOutPlanRequest();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesOutPlanRequest setApprovalStatus(String approvalStatus) {
        this.approvalStatus = approvalStatus;
        return this;
    }
    public String getApprovalStatus() {
        return this.approvalStatus;
    }

    public IndustryManufactureMesOutPlanRequest setApprover(String approver) {
        this.approver = approver;
        return this;
    }
    public String getApprover() {
        return this.approver;
    }

    public IndustryManufactureMesOutPlanRequest setBaseDataName(String baseDataName) {
        this.baseDataName = baseDataName;
        return this;
    }
    public String getBaseDataName() {
        return this.baseDataName;
    }

    public IndustryManufactureMesOutPlanRequest setOutSourceProjectCode(String outSourceProjectCode) {
        this.outSourceProjectCode = outSourceProjectCode;
        return this;
    }
    public String getOutSourceProjectCode() {
        return this.outSourceProjectCode;
    }

    public IndustryManufactureMesOutPlanRequest setOutSourceTeamId(String outSourceTeamId) {
        this.outSourceTeamId = outSourceTeamId;
        return this;
    }
    public String getOutSourceTeamId() {
        return this.outSourceTeamId;
    }

    public IndustryManufactureMesOutPlanRequest setPrice(String price) {
        this.price = price;
        return this;
    }
    public String getPrice() {
        return this.price;
    }

    public IndustryManufactureMesOutPlanRequest setProcessIdentificationCode(String processIdentificationCode) {
        this.processIdentificationCode = processIdentificationCode;
        return this;
    }
    public String getProcessIdentificationCode() {
        return this.processIdentificationCode;
    }

    public IndustryManufactureMesOutPlanRequest setProcessUuids(String processUuids) {
        this.processUuids = processUuids;
        return this;
    }
    public String getProcessUuids() {
        return this.processUuids;
    }

    public IndustryManufactureMesOutPlanRequest setProductCode(String productCode) {
        this.productCode = productCode;
        return this;
    }
    public String getProductCode() {
        return this.productCode;
    }

    public IndustryManufactureMesOutPlanRequest setProductName(String productName) {
        this.productName = productName;
        return this;
    }
    public String getProductName() {
        return this.productName;
    }

    public IndustryManufactureMesOutPlanRequest setProductSpecification(String productSpecification) {
        this.productSpecification = productSpecification;
        return this;
    }
    public String getProductSpecification() {
        return this.productSpecification;
    }

    public IndustryManufactureMesOutPlanRequest setProjectCode(String projectCode) {
        this.projectCode = projectCode;
        return this;
    }
    public String getProjectCode() {
        return this.projectCode;
    }

    public IndustryManufactureMesOutPlanRequest setProjectId(String projectId) {
        this.projectId = projectId;
        return this;
    }
    public String getProjectId() {
        return this.projectId;
    }

    public IndustryManufactureMesOutPlanRequest setSendPlanQuantity(String sendPlanQuantity) {
        this.sendPlanQuantity = sendPlanQuantity;
        return this;
    }
    public String getSendPlanQuantity() {
        return this.sendPlanQuantity;
    }

    public IndustryManufactureMesOutPlanRequest setSupplierCode(String supplierCode) {
        this.supplierCode = supplierCode;
        return this;
    }
    public String getSupplierCode() {
        return this.supplierCode;
    }

    public IndustryManufactureMesOutPlanRequest setSupplierName(String supplierName) {
        this.supplierName = supplierName;
        return this;
    }
    public String getSupplierName() {
        return this.supplierName;
    }

    public IndustryManufactureMesOutPlanRequest setTotalWage(String totalWage) {
        this.totalWage = totalWage;
        return this;
    }
    public String getTotalWage() {
        return this.totalWage;
    }

    public IndustryManufactureMesOutPlanRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
