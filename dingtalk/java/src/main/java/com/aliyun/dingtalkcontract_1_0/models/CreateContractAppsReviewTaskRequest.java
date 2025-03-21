// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractAppsReviewTaskRequest extends TeaModel {
    @NameInMap("contractFile")
    public CreateContractAppsReviewTaskRequestContractFile contractFile;

    @NameInMap("contractFileDownloadUrl")
    public String contractFileDownloadUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("contractFileName")
    public String contractFileName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileSource")
    public String fileSource;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("reviewCustomRules")
    public java.util.List<CreateContractAppsReviewTaskRequestReviewCustomRules> reviewCustomRules;

    @NameInMap("ruleType")
    public String ruleType;

    @NameInMap("standpoint")
    public String standpoint;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static CreateContractAppsReviewTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateContractAppsReviewTaskRequest self = new CreateContractAppsReviewTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateContractAppsReviewTaskRequest setContractFile(CreateContractAppsReviewTaskRequestContractFile contractFile) {
        this.contractFile = contractFile;
        return this;
    }
    public CreateContractAppsReviewTaskRequestContractFile getContractFile() {
        return this.contractFile;
    }

    public CreateContractAppsReviewTaskRequest setContractFileDownloadUrl(String contractFileDownloadUrl) {
        this.contractFileDownloadUrl = contractFileDownloadUrl;
        return this;
    }
    public String getContractFileDownloadUrl() {
        return this.contractFileDownloadUrl;
    }

    public CreateContractAppsReviewTaskRequest setContractFileName(String contractFileName) {
        this.contractFileName = contractFileName;
        return this;
    }
    public String getContractFileName() {
        return this.contractFileName;
    }

    public CreateContractAppsReviewTaskRequest setFileSource(String fileSource) {
        this.fileSource = fileSource;
        return this;
    }
    public String getFileSource() {
        return this.fileSource;
    }

    public CreateContractAppsReviewTaskRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateContractAppsReviewTaskRequest setReviewCustomRules(java.util.List<CreateContractAppsReviewTaskRequestReviewCustomRules> reviewCustomRules) {
        this.reviewCustomRules = reviewCustomRules;
        return this;
    }
    public java.util.List<CreateContractAppsReviewTaskRequestReviewCustomRules> getReviewCustomRules() {
        return this.reviewCustomRules;
    }

    public CreateContractAppsReviewTaskRequest setRuleType(String ruleType) {
        this.ruleType = ruleType;
        return this;
    }
    public String getRuleType() {
        return this.ruleType;
    }

    public CreateContractAppsReviewTaskRequest setStandpoint(String standpoint) {
        this.standpoint = standpoint;
        return this;
    }
    public String getStandpoint() {
        return this.standpoint;
    }

    public CreateContractAppsReviewTaskRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class CreateContractAppsReviewTaskRequestContractFile extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public Long fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("spaceId")
        public String spaceId;

        public static CreateContractAppsReviewTaskRequestContractFile build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsReviewTaskRequestContractFile self = new CreateContractAppsReviewTaskRequestContractFile();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsReviewTaskRequestContractFile setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateContractAppsReviewTaskRequestContractFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CreateContractAppsReviewTaskRequestContractFile setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public CreateContractAppsReviewTaskRequestContractFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public CreateContractAppsReviewTaskRequestContractFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

    public static class CreateContractAppsReviewTaskRequestReviewCustomRules extends TeaModel {
        @NameInMap("riskLevel")
        public String riskLevel;

        @NameInMap("ruleDesc")
        public String ruleDesc;

        @NameInMap("ruleSequence")
        public String ruleSequence;

        @NameInMap("ruleTag")
        public String ruleTag;

        @NameInMap("ruleTitle")
        public String ruleTitle;

        public static CreateContractAppsReviewTaskRequestReviewCustomRules build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsReviewTaskRequestReviewCustomRules self = new CreateContractAppsReviewTaskRequestReviewCustomRules();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsReviewTaskRequestReviewCustomRules setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public CreateContractAppsReviewTaskRequestReviewCustomRules setRuleDesc(String ruleDesc) {
            this.ruleDesc = ruleDesc;
            return this;
        }
        public String getRuleDesc() {
            return this.ruleDesc;
        }

        public CreateContractAppsReviewTaskRequestReviewCustomRules setRuleSequence(String ruleSequence) {
            this.ruleSequence = ruleSequence;
            return this;
        }
        public String getRuleSequence() {
            return this.ruleSequence;
        }

        public CreateContractAppsReviewTaskRequestReviewCustomRules setRuleTag(String ruleTag) {
            this.ruleTag = ruleTag;
            return this;
        }
        public String getRuleTag() {
            return this.ruleTag;
        }

        public CreateContractAppsReviewTaskRequestReviewCustomRules setRuleTitle(String ruleTitle) {
            this.ruleTitle = ruleTitle;
            return this;
        }
        public String getRuleTitle() {
            return this.ruleTitle;
        }

    }

}
