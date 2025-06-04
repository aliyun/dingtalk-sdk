// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractAppsTermsExtractEaskRequest extends TeaModel {
    @NameInMap("contractFile")
    public CreateContractAppsTermsExtractEaskRequestContractFile contractFile;

    @NameInMap("contractFileDownloadUrl")
    public String contractFileDownloadUrl;

    @NameInMap("contractFileName")
    public String contractFileName;

    @NameInMap("extractRules")
    public java.util.List<CreateContractAppsTermsExtractEaskRequestExtractRules> extractRules;

    @NameInMap("fileSource")
    public String fileSource;

    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static CreateContractAppsTermsExtractEaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateContractAppsTermsExtractEaskRequest self = new CreateContractAppsTermsExtractEaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateContractAppsTermsExtractEaskRequest setContractFile(CreateContractAppsTermsExtractEaskRequestContractFile contractFile) {
        this.contractFile = contractFile;
        return this;
    }
    public CreateContractAppsTermsExtractEaskRequestContractFile getContractFile() {
        return this.contractFile;
    }

    public CreateContractAppsTermsExtractEaskRequest setContractFileDownloadUrl(String contractFileDownloadUrl) {
        this.contractFileDownloadUrl = contractFileDownloadUrl;
        return this;
    }
    public String getContractFileDownloadUrl() {
        return this.contractFileDownloadUrl;
    }

    public CreateContractAppsTermsExtractEaskRequest setContractFileName(String contractFileName) {
        this.contractFileName = contractFileName;
        return this;
    }
    public String getContractFileName() {
        return this.contractFileName;
    }

    public CreateContractAppsTermsExtractEaskRequest setExtractRules(java.util.List<CreateContractAppsTermsExtractEaskRequestExtractRules> extractRules) {
        this.extractRules = extractRules;
        return this;
    }
    public java.util.List<CreateContractAppsTermsExtractEaskRequestExtractRules> getExtractRules() {
        return this.extractRules;
    }

    public CreateContractAppsTermsExtractEaskRequest setFileSource(String fileSource) {
        this.fileSource = fileSource;
        return this;
    }
    public String getFileSource() {
        return this.fileSource;
    }

    public CreateContractAppsTermsExtractEaskRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateContractAppsTermsExtractEaskRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class CreateContractAppsTermsExtractEaskRequestContractFile extends TeaModel {
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

        public static CreateContractAppsTermsExtractEaskRequestContractFile build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsTermsExtractEaskRequestContractFile self = new CreateContractAppsTermsExtractEaskRequestContractFile();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsTermsExtractEaskRequestContractFile setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateContractAppsTermsExtractEaskRequestContractFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CreateContractAppsTermsExtractEaskRequestContractFile setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public CreateContractAppsTermsExtractEaskRequestContractFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public CreateContractAppsTermsExtractEaskRequestContractFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

    public static class CreateContractAppsTermsExtractEaskRequestExtractRulesTermRules extends TeaModel {
        @NameInMap("description")
        public String description;

        @NameInMap("termCategory")
        public String termCategory;

        public static CreateContractAppsTermsExtractEaskRequestExtractRulesTermRules build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsTermsExtractEaskRequestExtractRulesTermRules self = new CreateContractAppsTermsExtractEaskRequestExtractRulesTermRules();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsTermsExtractEaskRequestExtractRulesTermRules setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public CreateContractAppsTermsExtractEaskRequestExtractRulesTermRules setTermCategory(String termCategory) {
            this.termCategory = termCategory;
            return this;
        }
        public String getTermCategory() {
            return this.termCategory;
        }

    }

    public static class CreateContractAppsTermsExtractEaskRequestExtractRules extends TeaModel {
        @NameInMap("ruleCategory")
        public String ruleCategory;

        @NameInMap("termRules")
        public java.util.List<CreateContractAppsTermsExtractEaskRequestExtractRulesTermRules> termRules;

        public static CreateContractAppsTermsExtractEaskRequestExtractRules build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsTermsExtractEaskRequestExtractRules self = new CreateContractAppsTermsExtractEaskRequestExtractRules();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsTermsExtractEaskRequestExtractRules setRuleCategory(String ruleCategory) {
            this.ruleCategory = ruleCategory;
            return this;
        }
        public String getRuleCategory() {
            return this.ruleCategory;
        }

        public CreateContractAppsTermsExtractEaskRequestExtractRules setTermRules(java.util.List<CreateContractAppsTermsExtractEaskRequestExtractRulesTermRules> termRules) {
            this.termRules = termRules;
            return this;
        }
        public java.util.List<CreateContractAppsTermsExtractEaskRequestExtractRulesTermRules> getTermRules() {
            return this.termRules;
        }

    }

}
