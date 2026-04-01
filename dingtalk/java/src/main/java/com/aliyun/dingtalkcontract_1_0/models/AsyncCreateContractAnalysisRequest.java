// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class AsyncCreateContractAnalysisRequest extends TeaModel {
    @NameInMap("fileInfo")
    public AsyncCreateContractAnalysisRequestFileInfo fileInfo;

    @NameInMap("originatorUserId")
    public String originatorUserId;

    public static AsyncCreateContractAnalysisRequest build(java.util.Map<String, ?> map) throws Exception {
        AsyncCreateContractAnalysisRequest self = new AsyncCreateContractAnalysisRequest();
        return TeaModel.build(map, self);
    }

    public AsyncCreateContractAnalysisRequest setFileInfo(AsyncCreateContractAnalysisRequestFileInfo fileInfo) {
        this.fileInfo = fileInfo;
        return this;
    }
    public AsyncCreateContractAnalysisRequestFileInfo getFileInfo() {
        return this.fileInfo;
    }

    public AsyncCreateContractAnalysisRequest setOriginatorUserId(String originatorUserId) {
        this.originatorUserId = originatorUserId;
        return this;
    }
    public String getOriginatorUserId() {
        return this.originatorUserId;
    }

    public static class AsyncCreateContractAnalysisRequestFileInfo extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("spaceId")
        public String spaceId;

        public static AsyncCreateContractAnalysisRequestFileInfo build(java.util.Map<String, ?> map) throws Exception {
            AsyncCreateContractAnalysisRequestFileInfo self = new AsyncCreateContractAnalysisRequestFileInfo();
            return TeaModel.build(map, self);
        }

        public AsyncCreateContractAnalysisRequestFileInfo setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public AsyncCreateContractAnalysisRequestFileInfo setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public AsyncCreateContractAnalysisRequestFileInfo setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public AsyncCreateContractAnalysisRequestFileInfo setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

    }

}
