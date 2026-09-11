// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CreatePayableReceiptRequest extends TeaModel {
    @NameInMap("receipt")
    public CreatePayableReceiptRequestReceipt receipt;

    public static CreatePayableReceiptRequest build(java.util.Map<String, ?> map) throws Exception {
        CreatePayableReceiptRequest self = new CreatePayableReceiptRequest();
        return TeaModel.build(map, self);
    }

    public CreatePayableReceiptRequest setReceipt(CreatePayableReceiptRequestReceipt receipt) {
        this.receipt = receipt;
        return this;
    }
    public CreatePayableReceiptRequestReceipt getReceipt() {
        return this.receipt;
    }

    public static class CreatePayableReceiptRequestReceiptDangAnDataInfoList extends TeaModel {
        @NameInMap("dataCode")
        public String dataCode;

        @NameInMap("defineCode")
        public String defineCode;

        public static CreatePayableReceiptRequestReceiptDangAnDataInfoList build(java.util.Map<String, ?> map) throws Exception {
            CreatePayableReceiptRequestReceiptDangAnDataInfoList self = new CreatePayableReceiptRequestReceiptDangAnDataInfoList();
            return TeaModel.build(map, self);
        }

        public CreatePayableReceiptRequestReceiptDangAnDataInfoList setDataCode(String dataCode) {
            this.dataCode = dataCode;
            return this;
        }
        public String getDataCode() {
            return this.dataCode;
        }

        public CreatePayableReceiptRequestReceiptDangAnDataInfoList setDefineCode(String defineCode) {
            this.defineCode = defineCode;
            return this;
        }
        public String getDefineCode() {
            return this.defineCode;
        }

    }

    public static class CreatePayableReceiptRequestReceiptReceiptPlans extends TeaModel {
        @NameInMap("planAmount")
        public String planAmount;

        @NameInMap("planDate")
        public Long planDate;

        @NameInMap("planRemark")
        public String planRemark;

        @NameInMap("uuid")
        public String uuid;

        public static CreatePayableReceiptRequestReceiptReceiptPlans build(java.util.Map<String, ?> map) throws Exception {
            CreatePayableReceiptRequestReceiptReceiptPlans self = new CreatePayableReceiptRequestReceiptReceiptPlans();
            return TeaModel.build(map, self);
        }

        public CreatePayableReceiptRequestReceiptReceiptPlans setPlanAmount(String planAmount) {
            this.planAmount = planAmount;
            return this;
        }
        public String getPlanAmount() {
            return this.planAmount;
        }

        public CreatePayableReceiptRequestReceiptReceiptPlans setPlanDate(Long planDate) {
            this.planDate = planDate;
            return this;
        }
        public Long getPlanDate() {
            return this.planDate;
        }

        public CreatePayableReceiptRequestReceiptReceiptPlans setPlanRemark(String planRemark) {
            this.planRemark = planRemark;
            return this;
        }
        public String getPlanRemark() {
            return this.planRemark;
        }

        public CreatePayableReceiptRequestReceiptReceiptPlans setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

    public static class CreatePayableReceiptRequestReceipt extends TeaModel {
        @NameInMap("amount")
        public String amount;

        @NameInMap("categoryCode")
        public String categoryCode;

        @NameInMap("code")
        public String code;

        @NameInMap("companyCode")
        public String companyCode;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("customerCode")
        public String customerCode;

        @NameInMap("dangAnDataInfoList")
        public java.util.List<CreatePayableReceiptRequestReceiptDangAnDataInfoList> dangAnDataInfoList;

        @NameInMap("departmentCode")
        public String departmentCode;

        @NameInMap("empAccountUserId")
        public String empAccountUserId;

        @NameInMap("enterpriseAccountCode")
        public String enterpriseAccountCode;

        @NameInMap("formCode")
        public String formCode;

        @NameInMap("occurDate")
        public Long occurDate;

        @NameInMap("principalId")
        public String principalId;

        @NameInMap("productCode")
        public String productCode;

        @NameInMap("projectCode")
        public String projectCode;

        @NameInMap("receiptPlans")
        public java.util.List<CreatePayableReceiptRequestReceiptReceiptPlans> receiptPlans;

        @NameInMap("receiptType")
        public Long receiptType;

        @NameInMap("recodeTime")
        public Long recodeTime;

        @NameInMap("remark")
        public String remark;

        @NameInMap("supplierCode")
        public String supplierCode;

        @NameInMap("title")
        public String title;

        @NameInMap("userId")
        public String userId;

        public static CreatePayableReceiptRequestReceipt build(java.util.Map<String, ?> map) throws Exception {
            CreatePayableReceiptRequestReceipt self = new CreatePayableReceiptRequestReceipt();
            return TeaModel.build(map, self);
        }

        public CreatePayableReceiptRequestReceipt setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public CreatePayableReceiptRequestReceipt setCategoryCode(String categoryCode) {
            this.categoryCode = categoryCode;
            return this;
        }
        public String getCategoryCode() {
            return this.categoryCode;
        }

        public CreatePayableReceiptRequestReceipt setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public CreatePayableReceiptRequestReceipt setCompanyCode(String companyCode) {
            this.companyCode = companyCode;
            return this;
        }
        public String getCompanyCode() {
            return this.companyCode;
        }

        public CreatePayableReceiptRequestReceipt setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public CreatePayableReceiptRequestReceipt setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public CreatePayableReceiptRequestReceipt setCustomerCode(String customerCode) {
            this.customerCode = customerCode;
            return this;
        }
        public String getCustomerCode() {
            return this.customerCode;
        }

        public CreatePayableReceiptRequestReceipt setDangAnDataInfoList(java.util.List<CreatePayableReceiptRequestReceiptDangAnDataInfoList> dangAnDataInfoList) {
            this.dangAnDataInfoList = dangAnDataInfoList;
            return this;
        }
        public java.util.List<CreatePayableReceiptRequestReceiptDangAnDataInfoList> getDangAnDataInfoList() {
            return this.dangAnDataInfoList;
        }

        public CreatePayableReceiptRequestReceipt setDepartmentCode(String departmentCode) {
            this.departmentCode = departmentCode;
            return this;
        }
        public String getDepartmentCode() {
            return this.departmentCode;
        }

        public CreatePayableReceiptRequestReceipt setEmpAccountUserId(String empAccountUserId) {
            this.empAccountUserId = empAccountUserId;
            return this;
        }
        public String getEmpAccountUserId() {
            return this.empAccountUserId;
        }

        public CreatePayableReceiptRequestReceipt setEnterpriseAccountCode(String enterpriseAccountCode) {
            this.enterpriseAccountCode = enterpriseAccountCode;
            return this;
        }
        public String getEnterpriseAccountCode() {
            return this.enterpriseAccountCode;
        }

        public CreatePayableReceiptRequestReceipt setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public CreatePayableReceiptRequestReceipt setOccurDate(Long occurDate) {
            this.occurDate = occurDate;
            return this;
        }
        public Long getOccurDate() {
            return this.occurDate;
        }

        public CreatePayableReceiptRequestReceipt setPrincipalId(String principalId) {
            this.principalId = principalId;
            return this;
        }
        public String getPrincipalId() {
            return this.principalId;
        }

        public CreatePayableReceiptRequestReceipt setProductCode(String productCode) {
            this.productCode = productCode;
            return this;
        }
        public String getProductCode() {
            return this.productCode;
        }

        public CreatePayableReceiptRequestReceipt setProjectCode(String projectCode) {
            this.projectCode = projectCode;
            return this;
        }
        public String getProjectCode() {
            return this.projectCode;
        }

        public CreatePayableReceiptRequestReceipt setReceiptPlans(java.util.List<CreatePayableReceiptRequestReceiptReceiptPlans> receiptPlans) {
            this.receiptPlans = receiptPlans;
            return this;
        }
        public java.util.List<CreatePayableReceiptRequestReceiptReceiptPlans> getReceiptPlans() {
            return this.receiptPlans;
        }

        public CreatePayableReceiptRequestReceipt setReceiptType(Long receiptType) {
            this.receiptType = receiptType;
            return this;
        }
        public Long getReceiptType() {
            return this.receiptType;
        }

        public CreatePayableReceiptRequestReceipt setRecodeTime(Long recodeTime) {
            this.recodeTime = recodeTime;
            return this;
        }
        public Long getRecodeTime() {
            return this.recodeTime;
        }

        public CreatePayableReceiptRequestReceipt setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public CreatePayableReceiptRequestReceipt setSupplierCode(String supplierCode) {
            this.supplierCode = supplierCode;
            return this;
        }
        public String getSupplierCode() {
            return this.supplierCode;
        }

        public CreatePayableReceiptRequestReceipt setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public CreatePayableReceiptRequestReceipt setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
