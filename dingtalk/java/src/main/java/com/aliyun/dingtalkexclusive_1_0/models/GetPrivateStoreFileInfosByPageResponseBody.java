// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreFileInfosByPageResponseBody extends TeaModel {
    @NameInMap("fileInfos")
    public java.util.List<GetPrivateStoreFileInfosByPageResponseBodyFileInfos> fileInfos;

    @NameInMap("nextToken")
    public String nextToken;

    public static GetPrivateStoreFileInfosByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreFileInfosByPageResponseBody self = new GetPrivateStoreFileInfosByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreFileInfosByPageResponseBody setFileInfos(java.util.List<GetPrivateStoreFileInfosByPageResponseBodyFileInfos> fileInfos) {
        this.fileInfos = fileInfos;
        return this;
    }
    public java.util.List<GetPrivateStoreFileInfosByPageResponseBodyFileInfos> getFileInfos() {
        return this.fileInfos;
    }

    public GetPrivateStoreFileInfosByPageResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class GetPrivateStoreFileInfosByPageResponseBodyFileInfos extends TeaModel {
        @NameInMap("dentryId")
        public Long dentryId;

        @NameInMap("fileCreateTime")
        public Long fileCreateTime;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("filePath")
        public String filePath;

        @NameInMap("fileSize")
        public Long fileSize;

        @NameInMap("spaceId")
        public Long spaceId;

        @NameInMap("status")
        public String status;

        public static GetPrivateStoreFileInfosByPageResponseBodyFileInfos build(java.util.Map<String, ?> map) throws Exception {
            GetPrivateStoreFileInfosByPageResponseBodyFileInfos self = new GetPrivateStoreFileInfosByPageResponseBodyFileInfos();
            return TeaModel.build(map, self);
        }

        public GetPrivateStoreFileInfosByPageResponseBodyFileInfos setDentryId(Long dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public Long getDentryId() {
            return this.dentryId;
        }

        public GetPrivateStoreFileInfosByPageResponseBodyFileInfos setFileCreateTime(Long fileCreateTime) {
            this.fileCreateTime = fileCreateTime;
            return this;
        }
        public Long getFileCreateTime() {
            return this.fileCreateTime;
        }

        public GetPrivateStoreFileInfosByPageResponseBodyFileInfos setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetPrivateStoreFileInfosByPageResponseBodyFileInfos setFilePath(String filePath) {
            this.filePath = filePath;
            return this;
        }
        public String getFilePath() {
            return this.filePath;
        }

        public GetPrivateStoreFileInfosByPageResponseBodyFileInfos setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public GetPrivateStoreFileInfosByPageResponseBodyFileInfos setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

        public GetPrivateStoreFileInfosByPageResponseBodyFileInfos setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
