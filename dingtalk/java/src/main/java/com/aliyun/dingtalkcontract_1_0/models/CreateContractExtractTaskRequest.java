// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractExtractTaskRequest extends TeaModel {
    /**
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("contractFile")
    public CreateContractExtractTaskRequestContractFile contractFile;

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

    public static CreateContractExtractTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateContractExtractTaskRequest self = new CreateContractExtractTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateContractExtractTaskRequest setContractFile(CreateContractExtractTaskRequestContractFile contractFile) {
        this.contractFile = contractFile;
        return this;
    }
    public CreateContractExtractTaskRequestContractFile getContractFile() {
        return this.contractFile;
    }

    public CreateContractExtractTaskRequest setContractFileDownloadUrl(String contractFileDownloadUrl) {
        this.contractFileDownloadUrl = contractFileDownloadUrl;
        return this;
    }
    public String getContractFileDownloadUrl() {
        return this.contractFileDownloadUrl;
    }

    public CreateContractExtractTaskRequest setContractFileName(String contractFileName) {
        this.contractFileName = contractFileName;
        return this;
    }
    public String getContractFileName() {
        return this.contractFileName;
    }

    public CreateContractExtractTaskRequest setExtractKeys(java.util.List<String> extractKeys) {
        this.extractKeys = extractKeys;
        return this;
    }
    public java.util.List<String> getExtractKeys() {
        return this.extractKeys;
    }

    public CreateContractExtractTaskRequest setFileSource(String fileSource) {
        this.fileSource = fileSource;
        return this;
    }
    public String getFileSource() {
        return this.fileSource;
    }

    public CreateContractExtractTaskRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public static class CreateContractExtractTaskRequestContractFile extends TeaModel {
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

        public static CreateContractExtractTaskRequestContractFile build(java.util.Map<String, ?> map) throws Exception {
            CreateContractExtractTaskRequestContractFile self = new CreateContractExtractTaskRequestContractFile();
            return TeaModel.build(map, self);
        }

        public CreateContractExtractTaskRequestContractFile setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateContractExtractTaskRequestContractFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CreateContractExtractTaskRequestContractFile setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public CreateContractExtractTaskRequestContractFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public CreateContractExtractTaskRequestContractFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
