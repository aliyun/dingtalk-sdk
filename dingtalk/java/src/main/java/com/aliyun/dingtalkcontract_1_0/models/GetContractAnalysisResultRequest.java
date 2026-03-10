// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractAnalysisResultRequest extends TeaModel {
    @NameInMap("fileInfo")
    public GetContractAnalysisResultRequestFileInfo fileInfo;

    @NameInMap("originatorUserId")
    public String originatorUserId;

    public static GetContractAnalysisResultRequest build(java.util.Map<String, ?> map) throws Exception {
        GetContractAnalysisResultRequest self = new GetContractAnalysisResultRequest();
        return TeaModel.build(map, self);
    }

    public GetContractAnalysisResultRequest setFileInfo(GetContractAnalysisResultRequestFileInfo fileInfo) {
        this.fileInfo = fileInfo;
        return this;
    }
    public GetContractAnalysisResultRequestFileInfo getFileInfo() {
        return this.fileInfo;
    }

    public GetContractAnalysisResultRequest setOriginatorUserId(String originatorUserId) {
        this.originatorUserId = originatorUserId;
        return this;
    }
    public String getOriginatorUserId() {
        return this.originatorUserId;
    }

    public static class GetContractAnalysisResultRequestFileInfo extends TeaModel {
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

        public static GetContractAnalysisResultRequestFileInfo build(java.util.Map<String, ?> map) throws Exception {
            GetContractAnalysisResultRequestFileInfo self = new GetContractAnalysisResultRequestFileInfo();
            return TeaModel.build(map, self);
        }

        public GetContractAnalysisResultRequestFileInfo setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public GetContractAnalysisResultRequestFileInfo setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetContractAnalysisResultRequestFileInfo setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public GetContractAnalysisResultRequestFileInfo setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public GetContractAnalysisResultRequestFileInfo setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
