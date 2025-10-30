// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractSignInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryContractSignInfoResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryContractSignInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryContractSignInfoResponseBody self = new QueryContractSignInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryContractSignInfoResponseBody setResult(QueryContractSignInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryContractSignInfoResponseBodyResult getResult() {
        return this.result;
    }

    public QueryContractSignInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryContractSignInfoResponseBodyResultActualOriginator extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("staffId")
        public String staffId;

        public static QueryContractSignInfoResponseBodyResultActualOriginator build(java.util.Map<String, ?> map) throws Exception {
            QueryContractSignInfoResponseBodyResultActualOriginator self = new QueryContractSignInfoResponseBodyResultActualOriginator();
            return TeaModel.build(map, self);
        }

        public QueryContractSignInfoResponseBodyResultActualOriginator setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryContractSignInfoResponseBodyResultActualOriginator setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

    }

    public static class QueryContractSignInfoResponseBodyResultContractAttachmentFiles extends TeaModel {
        @NameInMap("fileDownloadUrl")
        public String fileDownloadUrl;

        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public Long fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("spaceId")
        public Long spaceId;

        public static QueryContractSignInfoResponseBodyResultContractAttachmentFiles build(java.util.Map<String, ?> map) throws Exception {
            QueryContractSignInfoResponseBodyResultContractAttachmentFiles self = new QueryContractSignInfoResponseBodyResultContractAttachmentFiles();
            return TeaModel.build(map, self);
        }

        public QueryContractSignInfoResponseBodyResultContractAttachmentFiles setFileDownloadUrl(String fileDownloadUrl) {
            this.fileDownloadUrl = fileDownloadUrl;
            return this;
        }
        public String getFileDownloadUrl() {
            return this.fileDownloadUrl;
        }

        public QueryContractSignInfoResponseBodyResultContractAttachmentFiles setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public QueryContractSignInfoResponseBodyResultContractAttachmentFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public QueryContractSignInfoResponseBodyResultContractAttachmentFiles setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public QueryContractSignInfoResponseBodyResultContractAttachmentFiles setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public QueryContractSignInfoResponseBodyResultContractAttachmentFiles setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

    public static class QueryContractSignInfoResponseBodyResultContractContentFiles extends TeaModel {
        @NameInMap("fileDownloadUrl")
        public String fileDownloadUrl;

        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public Long fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("spaceId")
        public Long spaceId;

        public static QueryContractSignInfoResponseBodyResultContractContentFiles build(java.util.Map<String, ?> map) throws Exception {
            QueryContractSignInfoResponseBodyResultContractContentFiles self = new QueryContractSignInfoResponseBodyResultContractContentFiles();
            return TeaModel.build(map, self);
        }

        public QueryContractSignInfoResponseBodyResultContractContentFiles setFileDownloadUrl(String fileDownloadUrl) {
            this.fileDownloadUrl = fileDownloadUrl;
            return this;
        }
        public String getFileDownloadUrl() {
            return this.fileDownloadUrl;
        }

        public QueryContractSignInfoResponseBodyResultContractContentFiles setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public QueryContractSignInfoResponseBodyResultContractContentFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public QueryContractSignInfoResponseBodyResultContractContentFiles setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public QueryContractSignInfoResponseBodyResultContractContentFiles setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public QueryContractSignInfoResponseBodyResultContractContentFiles setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

    public static class QueryContractSignInfoResponseBodyResultOppositeParties extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        @NameInMap("owner")
        public String owner;

        @NameInMap("phoneNumber")
        public String phoneNumber;

        @NameInMap("type")
        public String type;

        @NameInMap("uniqueCode")
        public String uniqueCode;

        public static QueryContractSignInfoResponseBodyResultOppositeParties build(java.util.Map<String, ?> map) throws Exception {
            QueryContractSignInfoResponseBodyResultOppositeParties self = new QueryContractSignInfoResponseBodyResultOppositeParties();
            return TeaModel.build(map, self);
        }

        public QueryContractSignInfoResponseBodyResultOppositeParties setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryContractSignInfoResponseBodyResultOppositeParties setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryContractSignInfoResponseBodyResultOppositeParties setOwner(String owner) {
            this.owner = owner;
            return this;
        }
        public String getOwner() {
            return this.owner;
        }

        public QueryContractSignInfoResponseBodyResultOppositeParties setPhoneNumber(String phoneNumber) {
            this.phoneNumber = phoneNumber;
            return this;
        }
        public String getPhoneNumber() {
            return this.phoneNumber;
        }

        public QueryContractSignInfoResponseBodyResultOppositeParties setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public QueryContractSignInfoResponseBodyResultOppositeParties setUniqueCode(String uniqueCode) {
            this.uniqueCode = uniqueCode;
            return this;
        }
        public String getUniqueCode() {
            return this.uniqueCode;
        }

    }

    public static class QueryContractSignInfoResponseBodyResultOurParties extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        @NameInMap("owner")
        public String owner;

        @NameInMap("phoneNumber")
        public String phoneNumber;

        @NameInMap("type")
        public String type;

        @NameInMap("uniqueCode")
        public String uniqueCode;

        public static QueryContractSignInfoResponseBodyResultOurParties build(java.util.Map<String, ?> map) throws Exception {
            QueryContractSignInfoResponseBodyResultOurParties self = new QueryContractSignInfoResponseBodyResultOurParties();
            return TeaModel.build(map, self);
        }

        public QueryContractSignInfoResponseBodyResultOurParties setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryContractSignInfoResponseBodyResultOurParties setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryContractSignInfoResponseBodyResultOurParties setOwner(String owner) {
            this.owner = owner;
            return this;
        }
        public String getOwner() {
            return this.owner;
        }

        public QueryContractSignInfoResponseBodyResultOurParties setPhoneNumber(String phoneNumber) {
            this.phoneNumber = phoneNumber;
            return this;
        }
        public String getPhoneNumber() {
            return this.phoneNumber;
        }

        public QueryContractSignInfoResponseBodyResultOurParties setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public QueryContractSignInfoResponseBodyResultOurParties setUniqueCode(String uniqueCode) {
            this.uniqueCode = uniqueCode;
            return this;
        }
        public String getUniqueCode() {
            return this.uniqueCode;
        }

    }

    public static class QueryContractSignInfoResponseBodyResultSigners extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("staffId")
        public String staffId;

        public static QueryContractSignInfoResponseBodyResultSigners build(java.util.Map<String, ?> map) throws Exception {
            QueryContractSignInfoResponseBodyResultSigners self = new QueryContractSignInfoResponseBodyResultSigners();
            return TeaModel.build(map, self);
        }

        public QueryContractSignInfoResponseBodyResultSigners setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryContractSignInfoResponseBodyResultSigners setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

    }

    public static class QueryContractSignInfoResponseBodyResult extends TeaModel {
        @NameInMap("actualOriginator")
        public QueryContractSignInfoResponseBodyResultActualOriginator actualOriginator;

        @NameInMap("amountType")
        public String amountType;

        @NameInMap("applicantDate")
        public Long applicantDate;

        @NameInMap("approveTime")
        public Long approveTime;

        @NameInMap("bizId")
        public String bizId;

        @NameInMap("contractAmount")
        public String contractAmount;

        @NameInMap("contractAmountMethod")
        public String contractAmountMethod;

        @NameInMap("contractAttachmentFiles")
        public java.util.List<QueryContractSignInfoResponseBodyResultContractAttachmentFiles> contractAttachmentFiles;

        @NameInMap("contractContentFiles")
        public java.util.List<QueryContractSignInfoResponseBodyResultContractContentFiles> contractContentFiles;

        @NameInMap("contractEndDate")
        public Long contractEndDate;

        @NameInMap("contractId")
        public Integer contractId;

        @NameInMap("contractName")
        public String contractName;

        @NameInMap("contractNo")
        public String contractNo;

        @NameInMap("contractRemark")
        public String contractRemark;

        @NameInMap("contractStartDate")
        public Long contractStartDate;

        @NameInMap("contractStatus")
        public String contractStatus;

        @NameInMap("contractTermType")
        public String contractTermType;

        @NameInMap("currencyCode")
        public String currencyCode;

        @NameInMap("deptName")
        public String deptName;

        @NameInMap("directoryName")
        public String directoryName;

        @NameInMap("effectiveStatus")
        public String effectiveStatus;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("oppositeParties")
        public java.util.List<QueryContractSignInfoResponseBodyResultOppositeParties> oppositeParties;

        @NameInMap("ourParties")
        public java.util.List<QueryContractSignInfoResponseBodyResultOurParties> ourParties;

        @NameInMap("ownerName")
        public String ownerName;

        @NameInMap("ownerStaffId")
        public String ownerStaffId;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("signers")
        public java.util.List<QueryContractSignInfoResponseBodyResultSigners> signers;

        public static QueryContractSignInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryContractSignInfoResponseBodyResult self = new QueryContractSignInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryContractSignInfoResponseBodyResult setActualOriginator(QueryContractSignInfoResponseBodyResultActualOriginator actualOriginator) {
            this.actualOriginator = actualOriginator;
            return this;
        }
        public QueryContractSignInfoResponseBodyResultActualOriginator getActualOriginator() {
            return this.actualOriginator;
        }

        public QueryContractSignInfoResponseBodyResult setAmountType(String amountType) {
            this.amountType = amountType;
            return this;
        }
        public String getAmountType() {
            return this.amountType;
        }

        public QueryContractSignInfoResponseBodyResult setApplicantDate(Long applicantDate) {
            this.applicantDate = applicantDate;
            return this;
        }
        public Long getApplicantDate() {
            return this.applicantDate;
        }

        public QueryContractSignInfoResponseBodyResult setApproveTime(Long approveTime) {
            this.approveTime = approveTime;
            return this;
        }
        public Long getApproveTime() {
            return this.approveTime;
        }

        public QueryContractSignInfoResponseBodyResult setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public QueryContractSignInfoResponseBodyResult setContractAmount(String contractAmount) {
            this.contractAmount = contractAmount;
            return this;
        }
        public String getContractAmount() {
            return this.contractAmount;
        }

        public QueryContractSignInfoResponseBodyResult setContractAmountMethod(String contractAmountMethod) {
            this.contractAmountMethod = contractAmountMethod;
            return this;
        }
        public String getContractAmountMethod() {
            return this.contractAmountMethod;
        }

        public QueryContractSignInfoResponseBodyResult setContractAttachmentFiles(java.util.List<QueryContractSignInfoResponseBodyResultContractAttachmentFiles> contractAttachmentFiles) {
            this.contractAttachmentFiles = contractAttachmentFiles;
            return this;
        }
        public java.util.List<QueryContractSignInfoResponseBodyResultContractAttachmentFiles> getContractAttachmentFiles() {
            return this.contractAttachmentFiles;
        }

        public QueryContractSignInfoResponseBodyResult setContractContentFiles(java.util.List<QueryContractSignInfoResponseBodyResultContractContentFiles> contractContentFiles) {
            this.contractContentFiles = contractContentFiles;
            return this;
        }
        public java.util.List<QueryContractSignInfoResponseBodyResultContractContentFiles> getContractContentFiles() {
            return this.contractContentFiles;
        }

        public QueryContractSignInfoResponseBodyResult setContractEndDate(Long contractEndDate) {
            this.contractEndDate = contractEndDate;
            return this;
        }
        public Long getContractEndDate() {
            return this.contractEndDate;
        }

        public QueryContractSignInfoResponseBodyResult setContractId(Integer contractId) {
            this.contractId = contractId;
            return this;
        }
        public Integer getContractId() {
            return this.contractId;
        }

        public QueryContractSignInfoResponseBodyResult setContractName(String contractName) {
            this.contractName = contractName;
            return this;
        }
        public String getContractName() {
            return this.contractName;
        }

        public QueryContractSignInfoResponseBodyResult setContractNo(String contractNo) {
            this.contractNo = contractNo;
            return this;
        }
        public String getContractNo() {
            return this.contractNo;
        }

        public QueryContractSignInfoResponseBodyResult setContractRemark(String contractRemark) {
            this.contractRemark = contractRemark;
            return this;
        }
        public String getContractRemark() {
            return this.contractRemark;
        }

        public QueryContractSignInfoResponseBodyResult setContractStartDate(Long contractStartDate) {
            this.contractStartDate = contractStartDate;
            return this;
        }
        public Long getContractStartDate() {
            return this.contractStartDate;
        }

        public QueryContractSignInfoResponseBodyResult setContractStatus(String contractStatus) {
            this.contractStatus = contractStatus;
            return this;
        }
        public String getContractStatus() {
            return this.contractStatus;
        }

        public QueryContractSignInfoResponseBodyResult setContractTermType(String contractTermType) {
            this.contractTermType = contractTermType;
            return this;
        }
        public String getContractTermType() {
            return this.contractTermType;
        }

        public QueryContractSignInfoResponseBodyResult setCurrencyCode(String currencyCode) {
            this.currencyCode = currencyCode;
            return this;
        }
        public String getCurrencyCode() {
            return this.currencyCode;
        }

        public QueryContractSignInfoResponseBodyResult setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public QueryContractSignInfoResponseBodyResult setDirectoryName(String directoryName) {
            this.directoryName = directoryName;
            return this;
        }
        public String getDirectoryName() {
            return this.directoryName;
        }

        public QueryContractSignInfoResponseBodyResult setEffectiveStatus(String effectiveStatus) {
            this.effectiveStatus = effectiveStatus;
            return this;
        }
        public String getEffectiveStatus() {
            return this.effectiveStatus;
        }

        public QueryContractSignInfoResponseBodyResult setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryContractSignInfoResponseBodyResult setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public QueryContractSignInfoResponseBodyResult setOppositeParties(java.util.List<QueryContractSignInfoResponseBodyResultOppositeParties> oppositeParties) {
            this.oppositeParties = oppositeParties;
            return this;
        }
        public java.util.List<QueryContractSignInfoResponseBodyResultOppositeParties> getOppositeParties() {
            return this.oppositeParties;
        }

        public QueryContractSignInfoResponseBodyResult setOurParties(java.util.List<QueryContractSignInfoResponseBodyResultOurParties> ourParties) {
            this.ourParties = ourParties;
            return this;
        }
        public java.util.List<QueryContractSignInfoResponseBodyResultOurParties> getOurParties() {
            return this.ourParties;
        }

        public QueryContractSignInfoResponseBodyResult setOwnerName(String ownerName) {
            this.ownerName = ownerName;
            return this;
        }
        public String getOwnerName() {
            return this.ownerName;
        }

        public QueryContractSignInfoResponseBodyResult setOwnerStaffId(String ownerStaffId) {
            this.ownerStaffId = ownerStaffId;
            return this;
        }
        public String getOwnerStaffId() {
            return this.ownerStaffId;
        }

        public QueryContractSignInfoResponseBodyResult setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public QueryContractSignInfoResponseBodyResult setSigners(java.util.List<QueryContractSignInfoResponseBodyResultSigners> signers) {
            this.signers = signers;
            return this;
        }
        public java.util.List<QueryContractSignInfoResponseBodyResultSigners> getSigners() {
            return this.signers;
        }

    }

}
