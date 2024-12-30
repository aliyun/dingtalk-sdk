// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractCompareTaskRequest extends TeaModel {
    @NameInMap("comparativeFile")
    public CreateContractCompareTaskRequestComparativeFile comparativeFile;

    @NameInMap("comparativeFileDownloadUrl")
    public String comparativeFileDownloadUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("comparativeFileName")
    public String comparativeFileName;

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

    @NameInMap("standardFile")
    public CreateContractCompareTaskRequestStandardFile standardFile;

    @NameInMap("standardFileDownloadUrl")
    public String standardFileDownloadUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("standardFileName")
    public String standardFileName;

    public static CreateContractCompareTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateContractCompareTaskRequest self = new CreateContractCompareTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateContractCompareTaskRequest setComparativeFile(CreateContractCompareTaskRequestComparativeFile comparativeFile) {
        this.comparativeFile = comparativeFile;
        return this;
    }
    public CreateContractCompareTaskRequestComparativeFile getComparativeFile() {
        return this.comparativeFile;
    }

    public CreateContractCompareTaskRequest setComparativeFileDownloadUrl(String comparativeFileDownloadUrl) {
        this.comparativeFileDownloadUrl = comparativeFileDownloadUrl;
        return this;
    }
    public String getComparativeFileDownloadUrl() {
        return this.comparativeFileDownloadUrl;
    }

    public CreateContractCompareTaskRequest setComparativeFileName(String comparativeFileName) {
        this.comparativeFileName = comparativeFileName;
        return this;
    }
    public String getComparativeFileName() {
        return this.comparativeFileName;
    }

    public CreateContractCompareTaskRequest setFileSource(String fileSource) {
        this.fileSource = fileSource;
        return this;
    }
    public String getFileSource() {
        return this.fileSource;
    }

    public CreateContractCompareTaskRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateContractCompareTaskRequest setStandardFile(CreateContractCompareTaskRequestStandardFile standardFile) {
        this.standardFile = standardFile;
        return this;
    }
    public CreateContractCompareTaskRequestStandardFile getStandardFile() {
        return this.standardFile;
    }

    public CreateContractCompareTaskRequest setStandardFileDownloadUrl(String standardFileDownloadUrl) {
        this.standardFileDownloadUrl = standardFileDownloadUrl;
        return this;
    }
    public String getStandardFileDownloadUrl() {
        return this.standardFileDownloadUrl;
    }

    public CreateContractCompareTaskRequest setStandardFileName(String standardFileName) {
        this.standardFileName = standardFileName;
        return this;
    }
    public String getStandardFileName() {
        return this.standardFileName;
    }

    public static class CreateContractCompareTaskRequestComparativeFile extends TeaModel {
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

        public static CreateContractCompareTaskRequestComparativeFile build(java.util.Map<String, ?> map) throws Exception {
            CreateContractCompareTaskRequestComparativeFile self = new CreateContractCompareTaskRequestComparativeFile();
            return TeaModel.build(map, self);
        }

        public CreateContractCompareTaskRequestComparativeFile setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateContractCompareTaskRequestComparativeFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CreateContractCompareTaskRequestComparativeFile setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public CreateContractCompareTaskRequestComparativeFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public CreateContractCompareTaskRequestComparativeFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

    public static class CreateContractCompareTaskRequestStandardFile extends TeaModel {
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

        public static CreateContractCompareTaskRequestStandardFile build(java.util.Map<String, ?> map) throws Exception {
            CreateContractCompareTaskRequestStandardFile self = new CreateContractCompareTaskRequestStandardFile();
            return TeaModel.build(map, self);
        }

        public CreateContractCompareTaskRequestStandardFile setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateContractCompareTaskRequestStandardFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CreateContractCompareTaskRequestStandardFile setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public CreateContractCompareTaskRequestStandardFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public CreateContractCompareTaskRequestStandardFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
