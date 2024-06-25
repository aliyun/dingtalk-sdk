// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesOutPlanRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>APPROVING</p>
     */
    @NameInMap("approvalStatus")
    public String approvalStatus;

    /**
     * <strong>example:</strong>
     * <p>[{&quot;userId&quot;:&quot;123&quot;,&quot;name&quot;:&quot;汉俊&quot;}]</p>
     */
    @NameInMap("approver")
    public String approver;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>wwPlan</p>
     */
    @NameInMap("baseDataName")
    public String baseDataName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>WWJH-20220728</p>
     */
    @NameInMap("outSourceProjectCode")
    public String outSourceProjectCode;

    /**
     * <strong>example:</strong>
     * <p>cid34444</p>
     */
    @NameInMap("outSourceTeamId")
    public String outSourceTeamId;

    /**
     * <strong>example:</strong>
     * <p>321</p>
     */
    @NameInMap("price")
    public String price;

    /**
     * <strong>example:</strong>
     * <p>20220728_OP20</p>
     */
    @NameInMap("processIdentificationCode")
    public String processIdentificationCode;

    /**
     * <strong>example:</strong>
     * <p>[{       &quot;uuid&quot;: &quot;1543878029936459777&quot;,       &quot;name&quot;: &quot;YF-盐雾&quot;,       &quot;preProcess&quot;: &quot;1470231820594245633&quot;     }]</p>
     */
    @NameInMap("processUuids")
    public String processUuids;

    /**
     * <strong>example:</strong>
     * <p>WL12345</p>
     */
    @NameInMap("productCode")
    public String productCode;

    /**
     * <strong>example:</strong>
     * <p>毛坯KM63三级盖</p>
     */
    @NameInMap("productName")
    public String productName;

    /**
     * <strong>example:</strong>
     * <p>5/16*13.5</p>
     */
    @NameInMap("productSpecification")
    public String productSpecification;

    /**
     * <strong>example:</strong>
     * <p>20220728_001</p>
     */
    @NameInMap("projectCode")
    public String projectCode;

    /**
     * <strong>example:</strong>
     * <p>20220728_001</p>
     */
    @NameInMap("projectId")
    public String projectId;

    /**
     * <strong>example:</strong>
     * <p>321</p>
     */
    @NameInMap("sendPlanQuantity")
    public String sendPlanQuantity;

    /**
     * <strong>example:</strong>
     * <p>GX002</p>
     */
    @NameInMap("supplierCode")
    public String supplierCode;

    /**
     * <strong>example:</strong>
     * <p>北京供应</p>
     */
    @NameInMap("supplierName")
    public String supplierName;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("totalWage")
    public String totalWage;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>C1E213-86B2-706B-9615-5B957DF8C15D</p>
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
