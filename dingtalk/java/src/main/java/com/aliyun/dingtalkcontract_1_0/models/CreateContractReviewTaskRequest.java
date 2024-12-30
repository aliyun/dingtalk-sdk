// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractReviewTaskRequest extends TeaModel {
    /**
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("contractFile")
    public CreateContractReviewTaskRequestContractFile contractFile;

    @NameInMap("contractFileDownloadUrl")
    public String contractFileDownloadUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>采购合同.doc</p>
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
    public java.util.List<CreateContractReviewTaskRequestReviewCustomRules> reviewCustomRules;

    /**
     * <strong>example:</strong>
     * <p>model</p>
     */
    @NameInMap("ruleType")
    public String ruleType;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("standpoint")
    public String standpoint;

    public static CreateContractReviewTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateContractReviewTaskRequest self = new CreateContractReviewTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateContractReviewTaskRequest setContractFile(CreateContractReviewTaskRequestContractFile contractFile) {
        this.contractFile = contractFile;
        return this;
    }
    public CreateContractReviewTaskRequestContractFile getContractFile() {
        return this.contractFile;
    }

    public CreateContractReviewTaskRequest setContractFileDownloadUrl(String contractFileDownloadUrl) {
        this.contractFileDownloadUrl = contractFileDownloadUrl;
        return this;
    }
    public String getContractFileDownloadUrl() {
        return this.contractFileDownloadUrl;
    }

    public CreateContractReviewTaskRequest setContractFileName(String contractFileName) {
        this.contractFileName = contractFileName;
        return this;
    }
    public String getContractFileName() {
        return this.contractFileName;
    }

    public CreateContractReviewTaskRequest setFileSource(String fileSource) {
        this.fileSource = fileSource;
        return this;
    }
    public String getFileSource() {
        return this.fileSource;
    }

    public CreateContractReviewTaskRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateContractReviewTaskRequest setReviewCustomRules(java.util.List<CreateContractReviewTaskRequestReviewCustomRules> reviewCustomRules) {
        this.reviewCustomRules = reviewCustomRules;
        return this;
    }
    public java.util.List<CreateContractReviewTaskRequestReviewCustomRules> getReviewCustomRules() {
        return this.reviewCustomRules;
    }

    public CreateContractReviewTaskRequest setRuleType(String ruleType) {
        this.ruleType = ruleType;
        return this;
    }
    public String getRuleType() {
        return this.ruleType;
    }

    public CreateContractReviewTaskRequest setStandpoint(String standpoint) {
        this.standpoint = standpoint;
        return this;
    }
    public String getStandpoint() {
        return this.standpoint;
    }

    public static class CreateContractReviewTaskRequestContractFile extends TeaModel {
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

        public static CreateContractReviewTaskRequestContractFile build(java.util.Map<String, ?> map) throws Exception {
            CreateContractReviewTaskRequestContractFile self = new CreateContractReviewTaskRequestContractFile();
            return TeaModel.build(map, self);
        }

        public CreateContractReviewTaskRequestContractFile setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateContractReviewTaskRequestContractFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CreateContractReviewTaskRequestContractFile setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public CreateContractReviewTaskRequestContractFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public CreateContractReviewTaskRequestContractFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

    public static class CreateContractReviewTaskRequestReviewCustomRules extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>high</p>
         */
        @NameInMap("riskLevel")
        public String riskLevel;

        /**
         * <strong>example:</strong>
         * <p>审查合同金额大小，不得低于1000元</p>
         */
        @NameInMap("ruleDesc")
        public String ruleDesc;

        /**
         * <strong>example:</strong>
         * <p>1.1</p>
         */
        @NameInMap("ruleSequence")
        public String ruleSequence;

        /**
         * <strong>example:</strong>
         * <p>金额相关规则</p>
         */
        @NameInMap("ruleTag")
        public String ruleTag;

        /**
         * <strong>example:</strong>
         * <p>合同金额校验</p>
         */
        @NameInMap("ruleTitle")
        public String ruleTitle;

        public static CreateContractReviewTaskRequestReviewCustomRules build(java.util.Map<String, ?> map) throws Exception {
            CreateContractReviewTaskRequestReviewCustomRules self = new CreateContractReviewTaskRequestReviewCustomRules();
            return TeaModel.build(map, self);
        }

        public CreateContractReviewTaskRequestReviewCustomRules setRiskLevel(String riskLevel) {
            this.riskLevel = riskLevel;
            return this;
        }
        public String getRiskLevel() {
            return this.riskLevel;
        }

        public CreateContractReviewTaskRequestReviewCustomRules setRuleDesc(String ruleDesc) {
            this.ruleDesc = ruleDesc;
            return this;
        }
        public String getRuleDesc() {
            return this.ruleDesc;
        }

        public CreateContractReviewTaskRequestReviewCustomRules setRuleSequence(String ruleSequence) {
            this.ruleSequence = ruleSequence;
            return this;
        }
        public String getRuleSequence() {
            return this.ruleSequence;
        }

        public CreateContractReviewTaskRequestReviewCustomRules setRuleTag(String ruleTag) {
            this.ruleTag = ruleTag;
            return this;
        }
        public String getRuleTag() {
            return this.ruleTag;
        }

        public CreateContractReviewTaskRequestReviewCustomRules setRuleTitle(String ruleTitle) {
            this.ruleTitle = ruleTitle;
            return this;
        }
        public String getRuleTitle() {
            return this.ruleTitle;
        }

    }

}
