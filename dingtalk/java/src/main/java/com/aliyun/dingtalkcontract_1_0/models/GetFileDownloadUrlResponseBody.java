// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadUrlResponseBody extends TeaModel {
    @NameInMap("result")
    public GetFileDownloadUrlResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetFileDownloadUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFileDownloadUrlResponseBody self = new GetFileDownloadUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFileDownloadUrlResponseBody setResult(GetFileDownloadUrlResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetFileDownloadUrlResponseBodyResult getResult() {
        return this.result;
    }

    public GetFileDownloadUrlResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetFileDownloadUrlResponseBodyResultDataAttachment extends TeaModel {
        @NameInMap("downloadUrl")
        public String downloadUrl;

        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileStatus")
        public String fileStatus;

        @NameInMap("urlExpireTime")
        public Long urlExpireTime;

        public static GetFileDownloadUrlResponseBodyResultDataAttachment build(java.util.Map<String, ?> map) throws Exception {
            GetFileDownloadUrlResponseBodyResultDataAttachment self = new GetFileDownloadUrlResponseBodyResultDataAttachment();
            return TeaModel.build(map, self);
        }

        public GetFileDownloadUrlResponseBodyResultDataAttachment setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public GetFileDownloadUrlResponseBodyResultDataAttachment setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public GetFileDownloadUrlResponseBodyResultDataAttachment setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetFileDownloadUrlResponseBodyResultDataAttachment setFileStatus(String fileStatus) {
            this.fileStatus = fileStatus;
            return this;
        }
        public String getFileStatus() {
            return this.fileStatus;
        }

        public GetFileDownloadUrlResponseBodyResultDataAttachment setUrlExpireTime(Long urlExpireTime) {
            this.urlExpireTime = urlExpireTime;
            return this;
        }
        public Long getUrlExpireTime() {
            return this.urlExpireTime;
        }

    }

    public static class GetFileDownloadUrlResponseBodyResultDataSignDocs extends TeaModel {
        @NameInMap("downloadUrl")
        public String downloadUrl;

        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileStatus")
        public String fileStatus;

        @NameInMap("urlExpireTime")
        public Long urlExpireTime;

        public static GetFileDownloadUrlResponseBodyResultDataSignDocs build(java.util.Map<String, ?> map) throws Exception {
            GetFileDownloadUrlResponseBodyResultDataSignDocs self = new GetFileDownloadUrlResponseBodyResultDataSignDocs();
            return TeaModel.build(map, self);
        }

        public GetFileDownloadUrlResponseBodyResultDataSignDocs setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public GetFileDownloadUrlResponseBodyResultDataSignDocs setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public GetFileDownloadUrlResponseBodyResultDataSignDocs setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetFileDownloadUrlResponseBodyResultDataSignDocs setFileStatus(String fileStatus) {
            this.fileStatus = fileStatus;
            return this;
        }
        public String getFileStatus() {
            return this.fileStatus;
        }

        public GetFileDownloadUrlResponseBodyResultDataSignDocs setUrlExpireTime(Long urlExpireTime) {
            this.urlExpireTime = urlExpireTime;
            return this;
        }
        public Long getUrlExpireTime() {
            return this.urlExpireTime;
        }

    }

    public static class GetFileDownloadUrlResponseBodyResultData extends TeaModel {
        @NameInMap("attachment")
        public java.util.List<GetFileDownloadUrlResponseBodyResultDataAttachment> attachment;

        @NameInMap("signDocs")
        public java.util.List<GetFileDownloadUrlResponseBodyResultDataSignDocs> signDocs;

        @NameInMap("signFlowId")
        public String signFlowId;

        public static GetFileDownloadUrlResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            GetFileDownloadUrlResponseBodyResultData self = new GetFileDownloadUrlResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public GetFileDownloadUrlResponseBodyResultData setAttachment(java.util.List<GetFileDownloadUrlResponseBodyResultDataAttachment> attachment) {
            this.attachment = attachment;
            return this;
        }
        public java.util.List<GetFileDownloadUrlResponseBodyResultDataAttachment> getAttachment() {
            return this.attachment;
        }

        public GetFileDownloadUrlResponseBodyResultData setSignDocs(java.util.List<GetFileDownloadUrlResponseBodyResultDataSignDocs> signDocs) {
            this.signDocs = signDocs;
            return this;
        }
        public java.util.List<GetFileDownloadUrlResponseBodyResultDataSignDocs> getSignDocs() {
            return this.signDocs;
        }

        public GetFileDownloadUrlResponseBodyResultData setSignFlowId(String signFlowId) {
            this.signFlowId = signFlowId;
            return this;
        }
        public String getSignFlowId() {
            return this.signFlowId;
        }

    }

    public static class GetFileDownloadUrlResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public GetFileDownloadUrlResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static GetFileDownloadUrlResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFileDownloadUrlResponseBodyResult self = new GetFileDownloadUrlResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFileDownloadUrlResponseBodyResult setData(GetFileDownloadUrlResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public GetFileDownloadUrlResponseBodyResultData getData() {
            return this.data;
        }

        public GetFileDownloadUrlResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
