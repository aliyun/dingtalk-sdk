// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetAsyncCreateContractAnalysisRequest extends TeaModel {
    @NameInMap("fileInfo")
    public GetAsyncCreateContractAnalysisRequestFileInfo fileInfo;

    @NameInMap("originatorUserId")
    public String originatorUserId;

    public static GetAsyncCreateContractAnalysisRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAsyncCreateContractAnalysisRequest self = new GetAsyncCreateContractAnalysisRequest();
        return TeaModel.build(map, self);
    }

    public GetAsyncCreateContractAnalysisRequest setFileInfo(GetAsyncCreateContractAnalysisRequestFileInfo fileInfo) {
        this.fileInfo = fileInfo;
        return this;
    }
    public GetAsyncCreateContractAnalysisRequestFileInfo getFileInfo() {
        return this.fileInfo;
    }

    public GetAsyncCreateContractAnalysisRequest setOriginatorUserId(String originatorUserId) {
        this.originatorUserId = originatorUserId;
        return this;
    }
    public String getOriginatorUserId() {
        return this.originatorUserId;
    }

    public static class GetAsyncCreateContractAnalysisRequestFileInfo extends TeaModel {
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

        public static GetAsyncCreateContractAnalysisRequestFileInfo build(java.util.Map<String, ?> map) throws Exception {
            GetAsyncCreateContractAnalysisRequestFileInfo self = new GetAsyncCreateContractAnalysisRequestFileInfo();
            return TeaModel.build(map, self);
        }

        public GetAsyncCreateContractAnalysisRequestFileInfo setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public GetAsyncCreateContractAnalysisRequestFileInfo setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetAsyncCreateContractAnalysisRequestFileInfo setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public GetAsyncCreateContractAnalysisRequestFileInfo setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public GetAsyncCreateContractAnalysisRequestFileInfo setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
