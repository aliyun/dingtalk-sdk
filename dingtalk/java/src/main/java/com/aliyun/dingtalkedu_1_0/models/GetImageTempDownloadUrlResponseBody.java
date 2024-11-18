// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetImageTempDownloadUrlResponseBody extends TeaModel {
    @NameInMap("result")
    public GetImageTempDownloadUrlResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetImageTempDownloadUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetImageTempDownloadUrlResponseBody self = new GetImageTempDownloadUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetImageTempDownloadUrlResponseBody setResult(GetImageTempDownloadUrlResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetImageTempDownloadUrlResponseBodyResult getResult() {
        return this.result;
    }

    public GetImageTempDownloadUrlResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetImageTempDownloadUrlResponseBodyResult extends TeaModel {
        @NameInMap("extension")
        public String extension;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public Long fileSize;

        @NameInMap("url")
        public String url;

        public static GetImageTempDownloadUrlResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetImageTempDownloadUrlResponseBodyResult self = new GetImageTempDownloadUrlResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetImageTempDownloadUrlResponseBodyResult setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public GetImageTempDownloadUrlResponseBodyResult setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetImageTempDownloadUrlResponseBodyResult setFileSize(Long fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Long getFileSize() {
            return this.fileSize;
        }

        public GetImageTempDownloadUrlResponseBodyResult setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
