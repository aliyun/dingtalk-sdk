// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractAppsExtractTaskRequest extends TeaModel {
    @NameInMap("contractFile")
    public CreateContractAppsExtractTaskRequestContractFile contractFile;

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
    @NameInMap("extractKeys")
    public java.util.List<String> extractKeys;

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

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static CreateContractAppsExtractTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateContractAppsExtractTaskRequest self = new CreateContractAppsExtractTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateContractAppsExtractTaskRequest setContractFile(CreateContractAppsExtractTaskRequestContractFile contractFile) {
        this.contractFile = contractFile;
        return this;
    }
    public CreateContractAppsExtractTaskRequestContractFile getContractFile() {
        return this.contractFile;
    }

    public CreateContractAppsExtractTaskRequest setContractFileDownloadUrl(String contractFileDownloadUrl) {
        this.contractFileDownloadUrl = contractFileDownloadUrl;
        return this;
    }
    public String getContractFileDownloadUrl() {
        return this.contractFileDownloadUrl;
    }

    public CreateContractAppsExtractTaskRequest setContractFileName(String contractFileName) {
        this.contractFileName = contractFileName;
        return this;
    }
    public String getContractFileName() {
        return this.contractFileName;
    }

    public CreateContractAppsExtractTaskRequest setExtractKeys(java.util.List<String> extractKeys) {
        this.extractKeys = extractKeys;
        return this;
    }
    public java.util.List<String> getExtractKeys() {
        return this.extractKeys;
    }

    public CreateContractAppsExtractTaskRequest setFileSource(String fileSource) {
        this.fileSource = fileSource;
        return this;
    }
    public String getFileSource() {
        return this.fileSource;
    }

    public CreateContractAppsExtractTaskRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateContractAppsExtractTaskRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class CreateContractAppsExtractTaskRequestContractFile extends TeaModel {
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

        public static CreateContractAppsExtractTaskRequestContractFile build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsExtractTaskRequestContractFile self = new CreateContractAppsExtractTaskRequestContractFile();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsExtractTaskRequestContractFile setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateContractAppsExtractTaskRequestContractFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CreateContractAppsExtractTaskRequestContractFile setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public CreateContractAppsExtractTaskRequestContractFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public CreateContractAppsExtractTaskRequestContractFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
