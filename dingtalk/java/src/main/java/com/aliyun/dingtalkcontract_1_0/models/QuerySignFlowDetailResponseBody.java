// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QuerySignFlowDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public QuerySignFlowDetailResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QuerySignFlowDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySignFlowDetailResponseBody self = new QuerySignFlowDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySignFlowDetailResponseBody setResult(QuerySignFlowDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QuerySignFlowDetailResponseBodyResult getResult() {
        return this.result;
    }

    public QuerySignFlowDetailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QuerySignFlowDetailResponseBodyResultDataSignDocs extends TeaModel {
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

        public static QuerySignFlowDetailResponseBodyResultDataSignDocs build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSignDocs self = new QuerySignFlowDetailResponseBodyResultDataSignDocs();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSignDocs setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignDocs setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignDocs setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignDocs setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignDocs setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultDataSignFlowConfig extends TeaModel {
        @NameInMap("autoStart")
        public Boolean autoStart;

        @NameInMap("isOrderedSign")
        public Boolean isOrderedSign;

        @NameInMap("signFlowName")
        public String signFlowName;

        public static QuerySignFlowDetailResponseBodyResultDataSignFlowConfig build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSignFlowConfig self = new QuerySignFlowDetailResponseBodyResultDataSignFlowConfig();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSignFlowConfig setAutoStart(Boolean autoStart) {
            this.autoStart = autoStart;
            return this;
        }
        public Boolean getAutoStart() {
            return this.autoStart;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignFlowConfig setIsOrderedSign(Boolean isOrderedSign) {
            this.isOrderedSign = isOrderedSign;
            return this;
        }
        public Boolean getIsOrderedSign() {
            return this.isOrderedSign;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignFlowConfig setSignFlowName(String signFlowName) {
            this.signFlowName = signFlowName;
            return this;
        }
        public String getSignFlowName() {
            return this.signFlowName;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultDataSignFlowInitiator extends TeaModel {
        @NameInMap("companyId")
        public String companyId;

        @NameInMap("orgName")
        public String orgName;

        @NameInMap("userId")
        public String userId;

        public static QuerySignFlowDetailResponseBodyResultDataSignFlowInitiator build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSignFlowInitiator self = new QuerySignFlowDetailResponseBodyResultDataSignFlowInitiator();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSignFlowInitiator setCompanyId(String companyId) {
            this.companyId = companyId;
            return this;
        }
        public String getCompanyId() {
            return this.companyId;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignFlowInitiator setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignFlowInitiator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultDataSignTasksOrgInfo extends TeaModel {
        @NameInMap("companyId")
        public String companyId;

        @NameInMap("orgName")
        public String orgName;

        public static QuerySignFlowDetailResponseBodyResultDataSignTasksOrgInfo build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSignTasksOrgInfo self = new QuerySignFlowDetailResponseBodyResultDataSignTasksOrgInfo();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasksOrgInfo setCompanyId(String companyId) {
            this.companyId = companyId;
            return this;
        }
        public String getCompanyId() {
            return this.companyId;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasksOrgInfo setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultDataSignTasksSignerInfo extends TeaModel {
        @NameInMap("psnMobile")
        public String psnMobile;

        @NameInMap("psnName")
        public String psnName;

        @NameInMap("userId")
        public String userId;

        public static QuerySignFlowDetailResponseBodyResultDataSignTasksSignerInfo build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSignTasksSignerInfo self = new QuerySignFlowDetailResponseBodyResultDataSignTasksSignerInfo();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasksSignerInfo setPsnMobile(String psnMobile) {
            this.psnMobile = psnMobile;
            return this;
        }
        public String getPsnMobile() {
            return this.psnMobile;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasksSignerInfo setPsnName(String psnName) {
            this.psnName = psnName;
            return this;
        }
        public String getPsnName() {
            return this.psnName;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasksSignerInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultDataSignTasks extends TeaModel {
        @NameInMap("activateTime")
        public Long activateTime;

        @NameInMap("actualOrgSealType")
        public String actualOrgSealType;

        @NameInMap("actualPsnSealType")
        public String actualPsnSealType;

        @NameInMap("bizTaskId")
        public String bizTaskId;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("finishTime")
        public Long finishTime;

        @NameInMap("orgInfo")
        public QuerySignFlowDetailResponseBodyResultDataSignTasksOrgInfo orgInfo;

        @NameInMap("signOrder")
        public Integer signOrder;

        @NameInMap("signTaskId")
        public String signTaskId;

        @NameInMap("signUrl")
        public String signUrl;

        @NameInMap("signerInfo")
        public QuerySignFlowDetailResponseBodyResultDataSignTasksSignerInfo signerInfo;

        @NameInMap("signerType")
        public String signerType;

        @NameInMap("taskStatus")
        public String taskStatus;

        public static QuerySignFlowDetailResponseBodyResultDataSignTasks build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSignTasks self = new QuerySignFlowDetailResponseBodyResultDataSignTasks();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasks setActivateTime(Long activateTime) {
            this.activateTime = activateTime;
            return this;
        }
        public Long getActivateTime() {
            return this.activateTime;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasks setActualOrgSealType(String actualOrgSealType) {
            this.actualOrgSealType = actualOrgSealType;
            return this;
        }
        public String getActualOrgSealType() {
            return this.actualOrgSealType;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasks setActualPsnSealType(String actualPsnSealType) {
            this.actualPsnSealType = actualPsnSealType;
            return this;
        }
        public String getActualPsnSealType() {
            return this.actualPsnSealType;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasks setBizTaskId(String bizTaskId) {
            this.bizTaskId = bizTaskId;
            return this;
        }
        public String getBizTaskId() {
            return this.bizTaskId;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasks setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasks setFinishTime(Long finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public Long getFinishTime() {
            return this.finishTime;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasks setOrgInfo(QuerySignFlowDetailResponseBodyResultDataSignTasksOrgInfo orgInfo) {
            this.orgInfo = orgInfo;
            return this;
        }
        public QuerySignFlowDetailResponseBodyResultDataSignTasksOrgInfo getOrgInfo() {
            return this.orgInfo;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasks setSignOrder(Integer signOrder) {
            this.signOrder = signOrder;
            return this;
        }
        public Integer getSignOrder() {
            return this.signOrder;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasks setSignTaskId(String signTaskId) {
            this.signTaskId = signTaskId;
            return this;
        }
        public String getSignTaskId() {
            return this.signTaskId;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasks setSignUrl(String signUrl) {
            this.signUrl = signUrl;
            return this;
        }
        public String getSignUrl() {
            return this.signUrl;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasks setSignerInfo(QuerySignFlowDetailResponseBodyResultDataSignTasksSignerInfo signerInfo) {
            this.signerInfo = signerInfo;
            return this;
        }
        public QuerySignFlowDetailResponseBodyResultDataSignTasksSignerInfo getSignerInfo() {
            return this.signerInfo;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasks setSignerType(String signerType) {
            this.signerType = signerType;
            return this;
        }
        public String getSignerType() {
            return this.signerType;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignTasks setTaskStatus(String taskStatus) {
            this.taskStatus = taskStatus;
            return this;
        }
        public String getTaskStatus() {
            return this.taskStatus;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultDataSignersOrgInfo extends TeaModel {
        @NameInMap("companyId")
        public String companyId;

        @NameInMap("orgName")
        public String orgName;

        public static QuerySignFlowDetailResponseBodyResultDataSignersOrgInfo build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSignersOrgInfo self = new QuerySignFlowDetailResponseBodyResultDataSignersOrgInfo();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersOrgInfo setCompanyId(String companyId) {
            this.companyId = companyId;
            return this;
        }
        public String getCompanyId() {
            return this.companyId;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersOrgInfo setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignDateConfig extends TeaModel {
        @NameInMap("dateFormat")
        public String dateFormat;

        @NameInMap("showSignDate")
        public Boolean showSignDate;

        public static QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignDateConfig build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignDateConfig self = new QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignDateConfig();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignDateConfig setDateFormat(String dateFormat) {
            this.dateFormat = dateFormat;
            return this;
        }
        public String getDateFormat() {
            return this.dateFormat;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignDateConfig setShowSignDate(Boolean showSignDate) {
            this.showSignDate = showSignDate;
            return this;
        }
        public Boolean getShowSignDate() {
            return this.showSignDate;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig extends TeaModel {
        @NameInMap("positionPage")
        public Long positionPage;

        @NameInMap("positionX")
        public Double positionX;

        @NameInMap("positionY")
        public Double positionY;

        public static QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig self = new QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig setPositionPage(Long positionPage) {
            this.positionPage = positionPage;
            return this;
        }
        public Long getPositionPage() {
            return this.positionPage;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig setPositionX(Double positionX) {
            this.positionX = positionX;
            return this;
        }
        public Double getPositionX() {
            return this.positionX;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig setPositionY(Double positionY) {
            this.positionY = positionY;
            return this;
        }
        public Double getPositionY() {
            return this.positionY;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig extends TeaModel {
        @NameInMap("availableOrgSealTypes")
        public java.util.List<String> availableOrgSealTypes;

        @NameInMap("availablePsnSealTypes")
        public java.util.List<String> availablePsnSealTypes;

        @NameInMap("crossPageType")
        public String crossPageType;

        @NameInMap("signDateConfig")
        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignDateConfig signDateConfig;

        @NameInMap("signPositionConfig")
        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig signPositionConfig;

        public static QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig self = new QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig setAvailableOrgSealTypes(java.util.List<String> availableOrgSealTypes) {
            this.availableOrgSealTypes = availableOrgSealTypes;
            return this;
        }
        public java.util.List<String> getAvailableOrgSealTypes() {
            return this.availableOrgSealTypes;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig setAvailablePsnSealTypes(java.util.List<String> availablePsnSealTypes) {
            this.availablePsnSealTypes = availablePsnSealTypes;
            return this;
        }
        public java.util.List<String> getAvailablePsnSealTypes() {
            return this.availablePsnSealTypes;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig setCrossPageType(String crossPageType) {
            this.crossPageType = crossPageType;
            return this;
        }
        public String getCrossPageType() {
            return this.crossPageType;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig setSignDateConfig(QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignDateConfig signDateConfig) {
            this.signDateConfig = signDateConfig;
            return this;
        }
        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignDateConfig getSignDateConfig() {
            return this.signDateConfig;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig setSignPositionConfig(QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig signPositionConfig) {
            this.signPositionConfig = signPositionConfig;
            return this;
        }
        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig getSignPositionConfig() {
            return this.signPositionConfig;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfig extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("signFieldComponentConfig")
        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig signFieldComponentConfig;

        public static QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfig build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfig self = new QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfig();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfig setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfig setSignFieldComponentConfig(QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig signFieldComponentConfig) {
            this.signFieldComponentConfig = signFieldComponentConfig;
            return this;
        }
        public QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfigSignFieldComponentConfig getSignFieldComponentConfig() {
            return this.signFieldComponentConfig;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultDataSignersSignConfig extends TeaModel {
        @NameInMap("signOrder")
        public Long signOrder;

        public static QuerySignFlowDetailResponseBodyResultDataSignersSignConfig build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSignersSignConfig self = new QuerySignFlowDetailResponseBodyResultDataSignersSignConfig();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignConfig setSignOrder(Long signOrder) {
            this.signOrder = signOrder;
            return this;
        }
        public Long getSignOrder() {
            return this.signOrder;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultDataSignersSignerInfo extends TeaModel {
        @NameInMap("psnMobile")
        public String psnMobile;

        @NameInMap("psnName")
        public String psnName;

        @NameInMap("userId")
        public String userId;

        public static QuerySignFlowDetailResponseBodyResultDataSignersSignerInfo build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSignersSignerInfo self = new QuerySignFlowDetailResponseBodyResultDataSignersSignerInfo();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignerInfo setPsnMobile(String psnMobile) {
            this.psnMobile = psnMobile;
            return this;
        }
        public String getPsnMobile() {
            return this.psnMobile;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignerInfo setPsnName(String psnName) {
            this.psnName = psnName;
            return this;
        }
        public String getPsnName() {
            return this.psnName;
        }

        public QuerySignFlowDetailResponseBodyResultDataSignersSignerInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultDataSigners extends TeaModel {
        @NameInMap("bizTaskId")
        public String bizTaskId;

        @NameInMap("orgInfo")
        public QuerySignFlowDetailResponseBodyResultDataSignersOrgInfo orgInfo;

        @NameInMap("signComponentConfig")
        public java.util.List<QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfig> signComponentConfig;

        @NameInMap("signConfig")
        public QuerySignFlowDetailResponseBodyResultDataSignersSignConfig signConfig;

        @NameInMap("signerInfo")
        public QuerySignFlowDetailResponseBodyResultDataSignersSignerInfo signerInfo;

        @NameInMap("signerType")
        public String signerType;

        public static QuerySignFlowDetailResponseBodyResultDataSigners build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultDataSigners self = new QuerySignFlowDetailResponseBodyResultDataSigners();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultDataSigners setBizTaskId(String bizTaskId) {
            this.bizTaskId = bizTaskId;
            return this;
        }
        public String getBizTaskId() {
            return this.bizTaskId;
        }

        public QuerySignFlowDetailResponseBodyResultDataSigners setOrgInfo(QuerySignFlowDetailResponseBodyResultDataSignersOrgInfo orgInfo) {
            this.orgInfo = orgInfo;
            return this;
        }
        public QuerySignFlowDetailResponseBodyResultDataSignersOrgInfo getOrgInfo() {
            return this.orgInfo;
        }

        public QuerySignFlowDetailResponseBodyResultDataSigners setSignComponentConfig(java.util.List<QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfig> signComponentConfig) {
            this.signComponentConfig = signComponentConfig;
            return this;
        }
        public java.util.List<QuerySignFlowDetailResponseBodyResultDataSignersSignComponentConfig> getSignComponentConfig() {
            return this.signComponentConfig;
        }

        public QuerySignFlowDetailResponseBodyResultDataSigners setSignConfig(QuerySignFlowDetailResponseBodyResultDataSignersSignConfig signConfig) {
            this.signConfig = signConfig;
            return this;
        }
        public QuerySignFlowDetailResponseBodyResultDataSignersSignConfig getSignConfig() {
            return this.signConfig;
        }

        public QuerySignFlowDetailResponseBodyResultDataSigners setSignerInfo(QuerySignFlowDetailResponseBodyResultDataSignersSignerInfo signerInfo) {
            this.signerInfo = signerInfo;
            return this;
        }
        public QuerySignFlowDetailResponseBodyResultDataSignersSignerInfo getSignerInfo() {
            return this.signerInfo;
        }

        public QuerySignFlowDetailResponseBodyResultDataSigners setSignerType(String signerType) {
            this.signerType = signerType;
            return this;
        }
        public String getSignerType() {
            return this.signerType;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResultData extends TeaModel {
        @NameInMap("bizFlowId")
        public String bizFlowId;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("finishTime")
        public Long finishTime;

        @NameInMap("initiateUrl")
        public String initiateUrl;

        @NameInMap("signDocs")
        public java.util.List<QuerySignFlowDetailResponseBodyResultDataSignDocs> signDocs;

        @NameInMap("signFlowConfig")
        public QuerySignFlowDetailResponseBodyResultDataSignFlowConfig signFlowConfig;

        @NameInMap("signFlowId")
        public String signFlowId;

        @NameInMap("signFlowInitiator")
        public QuerySignFlowDetailResponseBodyResultDataSignFlowInitiator signFlowInitiator;

        @NameInMap("signFlowStatus")
        public String signFlowStatus;

        @NameInMap("signTasks")
        public java.util.List<QuerySignFlowDetailResponseBodyResultDataSignTasks> signTasks;

        @NameInMap("signers")
        public java.util.List<QuerySignFlowDetailResponseBodyResultDataSigners> signers;

        @NameInMap("startTime")
        public Long startTime;

        public static QuerySignFlowDetailResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResultData self = new QuerySignFlowDetailResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResultData setBizFlowId(String bizFlowId) {
            this.bizFlowId = bizFlowId;
            return this;
        }
        public String getBizFlowId() {
            return this.bizFlowId;
        }

        public QuerySignFlowDetailResponseBodyResultData setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QuerySignFlowDetailResponseBodyResultData setFinishTime(Long finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public Long getFinishTime() {
            return this.finishTime;
        }

        public QuerySignFlowDetailResponseBodyResultData setInitiateUrl(String initiateUrl) {
            this.initiateUrl = initiateUrl;
            return this;
        }
        public String getInitiateUrl() {
            return this.initiateUrl;
        }

        public QuerySignFlowDetailResponseBodyResultData setSignDocs(java.util.List<QuerySignFlowDetailResponseBodyResultDataSignDocs> signDocs) {
            this.signDocs = signDocs;
            return this;
        }
        public java.util.List<QuerySignFlowDetailResponseBodyResultDataSignDocs> getSignDocs() {
            return this.signDocs;
        }

        public QuerySignFlowDetailResponseBodyResultData setSignFlowConfig(QuerySignFlowDetailResponseBodyResultDataSignFlowConfig signFlowConfig) {
            this.signFlowConfig = signFlowConfig;
            return this;
        }
        public QuerySignFlowDetailResponseBodyResultDataSignFlowConfig getSignFlowConfig() {
            return this.signFlowConfig;
        }

        public QuerySignFlowDetailResponseBodyResultData setSignFlowId(String signFlowId) {
            this.signFlowId = signFlowId;
            return this;
        }
        public String getSignFlowId() {
            return this.signFlowId;
        }

        public QuerySignFlowDetailResponseBodyResultData setSignFlowInitiator(QuerySignFlowDetailResponseBodyResultDataSignFlowInitiator signFlowInitiator) {
            this.signFlowInitiator = signFlowInitiator;
            return this;
        }
        public QuerySignFlowDetailResponseBodyResultDataSignFlowInitiator getSignFlowInitiator() {
            return this.signFlowInitiator;
        }

        public QuerySignFlowDetailResponseBodyResultData setSignFlowStatus(String signFlowStatus) {
            this.signFlowStatus = signFlowStatus;
            return this;
        }
        public String getSignFlowStatus() {
            return this.signFlowStatus;
        }

        public QuerySignFlowDetailResponseBodyResultData setSignTasks(java.util.List<QuerySignFlowDetailResponseBodyResultDataSignTasks> signTasks) {
            this.signTasks = signTasks;
            return this;
        }
        public java.util.List<QuerySignFlowDetailResponseBodyResultDataSignTasks> getSignTasks() {
            return this.signTasks;
        }

        public QuerySignFlowDetailResponseBodyResultData setSigners(java.util.List<QuerySignFlowDetailResponseBodyResultDataSigners> signers) {
            this.signers = signers;
            return this;
        }
        public java.util.List<QuerySignFlowDetailResponseBodyResultDataSigners> getSigners() {
            return this.signers;
        }

        public QuerySignFlowDetailResponseBodyResultData setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

    }

    public static class QuerySignFlowDetailResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public QuerySignFlowDetailResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static QuerySignFlowDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QuerySignFlowDetailResponseBodyResult self = new QuerySignFlowDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QuerySignFlowDetailResponseBodyResult setData(QuerySignFlowDetailResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public QuerySignFlowDetailResponseBodyResultData getData() {
            return this.data;
        }

        public QuerySignFlowDetailResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
