// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesOutPlanRequest extends TeaModel {
    /**
     * <p>审批状态</p>
     */
    @NameInMap("approvalStatus")
    public String approvalStatus;

    /**
     * <p>审批人</p>
     */
    @NameInMap("approver")
    public String approver;

    /**
     * <p>主数据名称</p>
     */
    @NameInMap("baseDataName")
    public String baseDataName;

    /**
     * <p>委外计划单号</p>
     */
    @NameInMap("outSourceProjectCode")
    public String outSourceProjectCode;

    /**
     * <p>委外群</p>
     */
    @NameInMap("outSourceTeamId")
    public String outSourceTeamId;

    /**
     * <p>单价（元）</p>
     */
    @NameInMap("price")
    public String price;

    /**
     * <p>工序识别码</p>
     */
    @NameInMap("processIdentificationCode")
    public String processIdentificationCode;

    /**
     * <p>委外的工序列表(多个)</p>
     */
    @NameInMap("processUuids")
    public String processUuids;

    /**
     * <p>产品代码(物料编号)</p>
     */
    @NameInMap("productCode")
    public String productCode;

    /**
     * <p>产品名称</p>
     */
    @NameInMap("productName")
    public String productName;

    /**
     * <p>规格型号</p>
     */
    @NameInMap("productSpecification")
    public String productSpecification;

    /**
     * <p>工单编号(生产任务单)</p>
     */
    @NameInMap("projectCode")
    public String projectCode;

    /**
     * <p>工单(生产计划单)ID</p>
     */
    @NameInMap("projectId")
    public String projectId;

    /**
     * <p>委外计划数</p>
     */
    @NameInMap("sendPlanQuantity")
    public String sendPlanQuantity;

    /**
     * <p>供应商代码</p>
     */
    @NameInMap("supplierCode")
    public String supplierCode;

    /**
     * <p>供应商名称</p>
     */
    @NameInMap("supplierName")
    public String supplierName;

    /**
     * <p>金额（元）</p>
     */
    @NameInMap("totalWage")
    public String totalWage;

    /**
     * <p>记录唯一标识</p>
     */
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
