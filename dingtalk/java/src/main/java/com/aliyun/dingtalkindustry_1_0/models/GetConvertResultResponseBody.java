// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class GetConvertResultResponseBody extends TeaModel {
    @NameInMap("dingOpenErrcode")
    public Long dingOpenErrcode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public GetConvertResultResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetConvertResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConvertResultResponseBody self = new GetConvertResultResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConvertResultResponseBody setDingOpenErrcode(Long dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Long getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public GetConvertResultResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public GetConvertResultResponseBody setResult(GetConvertResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetConvertResultResponseBodyResult getResult() {
        return this.result;
    }

    public GetConvertResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetConvertResultResponseBodyResultOutputInfo extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("fileName")
        public String fileName;

        @NameInMap("fileSize")
        public Float fileSize;

        @NameInMap("fileType")
        public String fileType;

        @NameInMap("fileUrl")
        public String fileUrl;

        public static GetConvertResultResponseBodyResultOutputInfo build(java.util.Map<String, ?> map) throws Exception {
            GetConvertResultResponseBodyResultOutputInfo self = new GetConvertResultResponseBodyResultOutputInfo();
            return TeaModel.build(map, self);
        }

        public GetConvertResultResponseBodyResultOutputInfo setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetConvertResultResponseBodyResultOutputInfo setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public GetConvertResultResponseBodyResultOutputInfo setFileSize(Float fileSize) {
            this.fileSize = fileSize;
            return this;
        }
        public Float getFileSize() {
            return this.fileSize;
        }

        public GetConvertResultResponseBodyResultOutputInfo setFileType(String fileType) {
            this.fileType = fileType;
            return this;
        }
        public String getFileType() {
            return this.fileType;
        }

        public GetConvertResultResponseBodyResultOutputInfo setFileUrl(String fileUrl) {
            this.fileUrl = fileUrl;
            return this;
        }
        public String getFileUrl() {
            return this.fileUrl;
        }

    }

    public static class GetConvertResultResponseBodyResult extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("createTime")
        public Float createTime;

        @NameInMap("creatorName")
        public String creatorName;

        @NameInMap("outputInfo")
        public GetConvertResultResponseBodyResultOutputInfo outputInfo;

        @NameInMap("status")
        public String status;

        @NameInMap("taskBizId")
        public String taskBizId;

        @NameInMap("title")
        public String title;

        public static GetConvertResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetConvertResultResponseBodyResult self = new GetConvertResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetConvertResultResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetConvertResultResponseBodyResult setCreateTime(Float createTime) {
            this.createTime = createTime;
            return this;
        }
        public Float getCreateTime() {
            return this.createTime;
        }

        public GetConvertResultResponseBodyResult setCreatorName(String creatorName) {
            this.creatorName = creatorName;
            return this;
        }
        public String getCreatorName() {
            return this.creatorName;
        }

        public GetConvertResultResponseBodyResult setOutputInfo(GetConvertResultResponseBodyResultOutputInfo outputInfo) {
            this.outputInfo = outputInfo;
            return this;
        }
        public GetConvertResultResponseBodyResultOutputInfo getOutputInfo() {
            return this.outputInfo;
        }

        public GetConvertResultResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetConvertResultResponseBodyResult setTaskBizId(String taskBizId) {
            this.taskBizId = taskBizId;
            return this;
        }
        public String getTaskBizId() {
            return this.taskBizId;
        }

        public GetConvertResultResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
