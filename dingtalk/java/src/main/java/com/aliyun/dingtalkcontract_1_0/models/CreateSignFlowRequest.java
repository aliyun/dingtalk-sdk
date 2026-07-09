// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateSignFlowRequest extends TeaModel {
    @NameInMap("bizFlowId")
    public String bizFlowId;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("signDocs")
    public java.util.List<CreateSignFlowRequestSignDocs> signDocs;

    @NameInMap("signFlowConfig")
    public CreateSignFlowRequestSignFlowConfig signFlowConfig;

    @NameInMap("signFlowInitiator")
    public CreateSignFlowRequestSignFlowInitiator signFlowInitiator;

    @NameInMap("signers")
    public java.util.List<CreateSignFlowRequestSigners> signers;

    public static CreateSignFlowRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSignFlowRequest self = new CreateSignFlowRequest();
        return TeaModel.build(map, self);
    }

    public CreateSignFlowRequest setBizFlowId(String bizFlowId) {
        this.bizFlowId = bizFlowId;
        return this;
    }
    public String getBizFlowId() {
        return this.bizFlowId;
    }

    public CreateSignFlowRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateSignFlowRequest setSignDocs(java.util.List<CreateSignFlowRequestSignDocs> signDocs) {
        this.signDocs = signDocs;
        return this;
    }
    public java.util.List<CreateSignFlowRequestSignDocs> getSignDocs() {
        return this.signDocs;
    }

    public CreateSignFlowRequest setSignFlowConfig(CreateSignFlowRequestSignFlowConfig signFlowConfig) {
        this.signFlowConfig = signFlowConfig;
        return this;
    }
    public CreateSignFlowRequestSignFlowConfig getSignFlowConfig() {
        return this.signFlowConfig;
    }

    public CreateSignFlowRequest setSignFlowInitiator(CreateSignFlowRequestSignFlowInitiator signFlowInitiator) {
        this.signFlowInitiator = signFlowInitiator;
        return this;
    }
    public CreateSignFlowRequestSignFlowInitiator getSignFlowInitiator() {
        return this.signFlowInitiator;
    }

    public CreateSignFlowRequest setSigners(java.util.List<CreateSignFlowRequestSigners> signers) {
        this.signers = signers;
        return this;
    }
    public java.util.List<CreateSignFlowRequestSigners> getSigners() {
        return this.signers;
    }

    public static class CreateSignFlowRequestSignDocs extends TeaModel {
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

        public static CreateSignFlowRequestSignDocs build(java.util.Map<String, ?> map) throws Exception {
            CreateSignFlowRequestSignDocs self = new CreateSignFlowRequestSignDocs();
            return TeaModel.build(map, self);
        }

        public CreateSignFlowRequestSignDocs setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateSignFlowRequestSignDocs setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CreateSignFlowRequestSignDocs setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public CreateSignFlowRequestSignDocs setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public CreateSignFlowRequestSignDocs setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

    public static class CreateSignFlowRequestSignFlowConfig extends TeaModel {
        @NameInMap("autoStart")
        public Boolean autoStart;

        @NameInMap("isOrderedSign")
        public Boolean isOrderedSign;

        @NameInMap("signFlowName")
        public String signFlowName;

        public static CreateSignFlowRequestSignFlowConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateSignFlowRequestSignFlowConfig self = new CreateSignFlowRequestSignFlowConfig();
            return TeaModel.build(map, self);
        }

        public CreateSignFlowRequestSignFlowConfig setAutoStart(Boolean autoStart) {
            this.autoStart = autoStart;
            return this;
        }
        public Boolean getAutoStart() {
            return this.autoStart;
        }

        public CreateSignFlowRequestSignFlowConfig setIsOrderedSign(Boolean isOrderedSign) {
            this.isOrderedSign = isOrderedSign;
            return this;
        }
        public Boolean getIsOrderedSign() {
            return this.isOrderedSign;
        }

        public CreateSignFlowRequestSignFlowConfig setSignFlowName(String signFlowName) {
            this.signFlowName = signFlowName;
            return this;
        }
        public String getSignFlowName() {
            return this.signFlowName;
        }

    }

    public static class CreateSignFlowRequestSignFlowInitiator extends TeaModel {
        @NameInMap("companyId")
        public String companyId;

        @NameInMap("orgName")
        public String orgName;

        @NameInMap("userId")
        public String userId;

        public static CreateSignFlowRequestSignFlowInitiator build(java.util.Map<String, ?> map) throws Exception {
            CreateSignFlowRequestSignFlowInitiator self = new CreateSignFlowRequestSignFlowInitiator();
            return TeaModel.build(map, self);
        }

        public CreateSignFlowRequestSignFlowInitiator setCompanyId(String companyId) {
            this.companyId = companyId;
            return this;
        }
        public String getCompanyId() {
            return this.companyId;
        }

        public CreateSignFlowRequestSignFlowInitiator setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public CreateSignFlowRequestSignFlowInitiator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class CreateSignFlowRequestSignersOrgInfo extends TeaModel {
        @NameInMap("companyId")
        public String companyId;

        @NameInMap("orgName")
        public String orgName;

        public static CreateSignFlowRequestSignersOrgInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateSignFlowRequestSignersOrgInfo self = new CreateSignFlowRequestSignersOrgInfo();
            return TeaModel.build(map, self);
        }

        public CreateSignFlowRequestSignersOrgInfo setCompanyId(String companyId) {
            this.companyId = companyId;
            return this;
        }
        public String getCompanyId() {
            return this.companyId;
        }

        public CreateSignFlowRequestSignersOrgInfo setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

    public static class CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignDateConfig extends TeaModel {
        @NameInMap("dateFormat")
        public String dateFormat;

        @NameInMap("showSignDate")
        public Boolean showSignDate;

        public static CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignDateConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignDateConfig self = new CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignDateConfig();
            return TeaModel.build(map, self);
        }

        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignDateConfig setDateFormat(String dateFormat) {
            this.dateFormat = dateFormat;
            return this;
        }
        public String getDateFormat() {
            return this.dateFormat;
        }

        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignDateConfig setShowSignDate(Boolean showSignDate) {
            this.showSignDate = showSignDate;
            return this;
        }
        public Boolean getShowSignDate() {
            return this.showSignDate;
        }

    }

    public static class CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig extends TeaModel {
        @NameInMap("positionPage")
        public Long positionPage;

        @NameInMap("positionX")
        public Double positionX;

        @NameInMap("positionY")
        public Double positionY;

        public static CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig self = new CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig();
            return TeaModel.build(map, self);
        }

        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig setPositionPage(Long positionPage) {
            this.positionPage = positionPage;
            return this;
        }
        public Long getPositionPage() {
            return this.positionPage;
        }

        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig setPositionX(Double positionX) {
            this.positionX = positionX;
            return this;
        }
        public Double getPositionX() {
            return this.positionX;
        }

        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig setPositionY(Double positionY) {
            this.positionY = positionY;
            return this;
        }
        public Double getPositionY() {
            return this.positionY;
        }

    }

    public static class CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig extends TeaModel {
        @NameInMap("availableOrgSealTypes")
        public java.util.List<String> availableOrgSealTypes;

        @NameInMap("availablePsnSealTypes")
        public java.util.List<String> availablePsnSealTypes;

        @NameInMap("crossPageType")
        public String crossPageType;

        @NameInMap("signDateConfig")
        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignDateConfig signDateConfig;

        @NameInMap("signPositionConfig")
        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig signPositionConfig;

        public static CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig self = new CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig();
            return TeaModel.build(map, self);
        }

        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig setAvailableOrgSealTypes(java.util.List<String> availableOrgSealTypes) {
            this.availableOrgSealTypes = availableOrgSealTypes;
            return this;
        }
        public java.util.List<String> getAvailableOrgSealTypes() {
            return this.availableOrgSealTypes;
        }

        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig setAvailablePsnSealTypes(java.util.List<String> availablePsnSealTypes) {
            this.availablePsnSealTypes = availablePsnSealTypes;
            return this;
        }
        public java.util.List<String> getAvailablePsnSealTypes() {
            return this.availablePsnSealTypes;
        }

        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig setCrossPageType(String crossPageType) {
            this.crossPageType = crossPageType;
            return this;
        }
        public String getCrossPageType() {
            return this.crossPageType;
        }

        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig setSignDateConfig(CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignDateConfig signDateConfig) {
            this.signDateConfig = signDateConfig;
            return this;
        }
        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignDateConfig getSignDateConfig() {
            return this.signDateConfig;
        }

        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig setSignPositionConfig(CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig signPositionConfig) {
            this.signPositionConfig = signPositionConfig;
            return this;
        }
        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig getSignPositionConfig() {
            return this.signPositionConfig;
        }

    }

    public static class CreateSignFlowRequestSignersSignComponentConfig extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("signFieldComponentConfig")
        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig signFieldComponentConfig;

        public static CreateSignFlowRequestSignersSignComponentConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateSignFlowRequestSignersSignComponentConfig self = new CreateSignFlowRequestSignersSignComponentConfig();
            return TeaModel.build(map, self);
        }

        public CreateSignFlowRequestSignersSignComponentConfig setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateSignFlowRequestSignersSignComponentConfig setSignFieldComponentConfig(CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig signFieldComponentConfig) {
            this.signFieldComponentConfig = signFieldComponentConfig;
            return this;
        }
        public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig getSignFieldComponentConfig() {
            return this.signFieldComponentConfig;
        }

    }

    public static class CreateSignFlowRequestSignersSignConfig extends TeaModel {
        @NameInMap("signOrder")
        public Integer signOrder;

        public static CreateSignFlowRequestSignersSignConfig build(java.util.Map<String, ?> map) throws Exception {
            CreateSignFlowRequestSignersSignConfig self = new CreateSignFlowRequestSignersSignConfig();
            return TeaModel.build(map, self);
        }

        public CreateSignFlowRequestSignersSignConfig setSignOrder(Integer signOrder) {
            this.signOrder = signOrder;
            return this;
        }
        public Integer getSignOrder() {
            return this.signOrder;
        }

    }

    public static class CreateSignFlowRequestSignersSignerInfo extends TeaModel {
        @NameInMap("psnMobile")
        public String psnMobile;

        @NameInMap("psnName")
        public String psnName;

        @NameInMap("userId")
        public String userId;

        public static CreateSignFlowRequestSignersSignerInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateSignFlowRequestSignersSignerInfo self = new CreateSignFlowRequestSignersSignerInfo();
            return TeaModel.build(map, self);
        }

        public CreateSignFlowRequestSignersSignerInfo setPsnMobile(String psnMobile) {
            this.psnMobile = psnMobile;
            return this;
        }
        public String getPsnMobile() {
            return this.psnMobile;
        }

        public CreateSignFlowRequestSignersSignerInfo setPsnName(String psnName) {
            this.psnName = psnName;
            return this;
        }
        public String getPsnName() {
            return this.psnName;
        }

        public CreateSignFlowRequestSignersSignerInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class CreateSignFlowRequestSigners extends TeaModel {
        @NameInMap("bizTaskId")
        public String bizTaskId;

        @NameInMap("orgInfo")
        public CreateSignFlowRequestSignersOrgInfo orgInfo;

        @NameInMap("signComponentConfig")
        public java.util.List<CreateSignFlowRequestSignersSignComponentConfig> signComponentConfig;

        @NameInMap("signConfig")
        public CreateSignFlowRequestSignersSignConfig signConfig;

        @NameInMap("signerInfo")
        public CreateSignFlowRequestSignersSignerInfo signerInfo;

        @NameInMap("signerType")
        public String signerType;

        public static CreateSignFlowRequestSigners build(java.util.Map<String, ?> map) throws Exception {
            CreateSignFlowRequestSigners self = new CreateSignFlowRequestSigners();
            return TeaModel.build(map, self);
        }

        public CreateSignFlowRequestSigners setBizTaskId(String bizTaskId) {
            this.bizTaskId = bizTaskId;
            return this;
        }
        public String getBizTaskId() {
            return this.bizTaskId;
        }

        public CreateSignFlowRequestSigners setOrgInfo(CreateSignFlowRequestSignersOrgInfo orgInfo) {
            this.orgInfo = orgInfo;
            return this;
        }
        public CreateSignFlowRequestSignersOrgInfo getOrgInfo() {
            return this.orgInfo;
        }

        public CreateSignFlowRequestSigners setSignComponentConfig(java.util.List<CreateSignFlowRequestSignersSignComponentConfig> signComponentConfig) {
            this.signComponentConfig = signComponentConfig;
            return this;
        }
        public java.util.List<CreateSignFlowRequestSignersSignComponentConfig> getSignComponentConfig() {
            return this.signComponentConfig;
        }

        public CreateSignFlowRequestSigners setSignConfig(CreateSignFlowRequestSignersSignConfig signConfig) {
            this.signConfig = signConfig;
            return this;
        }
        public CreateSignFlowRequestSignersSignConfig getSignConfig() {
            return this.signConfig;
        }

        public CreateSignFlowRequestSigners setSignerInfo(CreateSignFlowRequestSignersSignerInfo signerInfo) {
            this.signerInfo = signerInfo;
            return this;
        }
        public CreateSignFlowRequestSignersSignerInfo getSignerInfo() {
            return this.signerInfo;
        }

        public CreateSignFlowRequestSigners setSignerType(String signerType) {
            this.signerType = signerType;
            return this;
        }
        public String getSignerType() {
            return this.signerType;
        }

    }

}
