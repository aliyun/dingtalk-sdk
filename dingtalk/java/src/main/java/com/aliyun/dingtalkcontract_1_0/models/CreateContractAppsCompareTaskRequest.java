// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractAppsCompareTaskRequest extends TeaModel {
    @NameInMap("comparativeFile")
    public CreateContractAppsCompareTaskRequestComparativeFile comparativeFile;

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
    public CreateContractAppsCompareTaskRequestStandardFile standardFile;

    @NameInMap("standardFileDownloadUrl")
    public String standardFileDownloadUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("standardFileName")
    public String standardFileName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static CreateContractAppsCompareTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateContractAppsCompareTaskRequest self = new CreateContractAppsCompareTaskRequest();
        return TeaModel.build(map, self);
    }

    public CreateContractAppsCompareTaskRequest setComparativeFile(CreateContractAppsCompareTaskRequestComparativeFile comparativeFile) {
        this.comparativeFile = comparativeFile;
        return this;
    }
    public CreateContractAppsCompareTaskRequestComparativeFile getComparativeFile() {
        return this.comparativeFile;
    }

    public CreateContractAppsCompareTaskRequest setComparativeFileDownloadUrl(String comparativeFileDownloadUrl) {
        this.comparativeFileDownloadUrl = comparativeFileDownloadUrl;
        return this;
    }
    public String getComparativeFileDownloadUrl() {
        return this.comparativeFileDownloadUrl;
    }

    public CreateContractAppsCompareTaskRequest setComparativeFileName(String comparativeFileName) {
        this.comparativeFileName = comparativeFileName;
        return this;
    }
    public String getComparativeFileName() {
        return this.comparativeFileName;
    }

    public CreateContractAppsCompareTaskRequest setFileSource(String fileSource) {
        this.fileSource = fileSource;
        return this;
    }
    public String getFileSource() {
        return this.fileSource;
    }

    public CreateContractAppsCompareTaskRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateContractAppsCompareTaskRequest setStandardFile(CreateContractAppsCompareTaskRequestStandardFile standardFile) {
        this.standardFile = standardFile;
        return this;
    }
    public CreateContractAppsCompareTaskRequestStandardFile getStandardFile() {
        return this.standardFile;
    }

    public CreateContractAppsCompareTaskRequest setStandardFileDownloadUrl(String standardFileDownloadUrl) {
        this.standardFileDownloadUrl = standardFileDownloadUrl;
        return this;
    }
    public String getStandardFileDownloadUrl() {
        return this.standardFileDownloadUrl;
    }

    public CreateContractAppsCompareTaskRequest setStandardFileName(String standardFileName) {
        this.standardFileName = standardFileName;
        return this;
    }
    public String getStandardFileName() {
        return this.standardFileName;
    }

    public CreateContractAppsCompareTaskRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class CreateContractAppsCompareTaskRequestComparativeFile extends TeaModel {
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

        public static CreateContractAppsCompareTaskRequestComparativeFile build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsCompareTaskRequestComparativeFile self = new CreateContractAppsCompareTaskRequestComparativeFile();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsCompareTaskRequestComparativeFile setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateContractAppsCompareTaskRequestComparativeFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CreateContractAppsCompareTaskRequestComparativeFile setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public CreateContractAppsCompareTaskRequestComparativeFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public CreateContractAppsCompareTaskRequestComparativeFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

    public static class CreateContractAppsCompareTaskRequestStandardFile extends TeaModel {
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

        public static CreateContractAppsCompareTaskRequestStandardFile build(java.util.Map<String, ?> map) throws Exception {
            CreateContractAppsCompareTaskRequestStandardFile self = new CreateContractAppsCompareTaskRequestStandardFile();
            return TeaModel.build(map, self);
        }

        public CreateContractAppsCompareTaskRequestStandardFile setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateContractAppsCompareTaskRequestStandardFile setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CreateContractAppsCompareTaskRequestStandardFile setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public CreateContractAppsCompareTaskRequestStandardFile setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public CreateContractAppsCompareTaskRequestStandardFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
