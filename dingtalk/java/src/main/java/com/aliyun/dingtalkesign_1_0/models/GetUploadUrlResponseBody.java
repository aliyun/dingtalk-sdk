// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetUploadUrlResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("message")
    public String message;

    @NameInMap("data")
    public GetUploadUrlResponseBodyData data;

    public static GetUploadUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUploadUrlResponseBody self = new GetUploadUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUploadUrlResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public GetUploadUrlResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public GetUploadUrlResponseBody setData(GetUploadUrlResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetUploadUrlResponseBodyData getData() {
        return this.data;
    }

    public static class GetUploadUrlResponseBodyData extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("uploadUrl")
        public String uploadUrl;

        public static GetUploadUrlResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetUploadUrlResponseBodyData self = new GetUploadUrlResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetUploadUrlResponseBodyData setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public GetUploadUrlResponseBodyData setUploadUrl(String uploadUrl) {
            this.uploadUrl = uploadUrl;
            return this;
        }
        public String getUploadUrl() {
            return this.uploadUrl;
        }

    }

}
