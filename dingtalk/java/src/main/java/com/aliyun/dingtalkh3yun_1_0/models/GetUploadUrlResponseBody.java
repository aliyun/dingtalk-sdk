// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetUploadUrlResponseBody extends TeaModel {
    // 状态码
    @NameInMap("code")
    public String code;

    // 返回结果
    @NameInMap("data")
    public GetUploadUrlResponseBodyData data;

    // 提示信息
    @NameInMap("message")
    public String message;

    public static GetUploadUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUploadUrlResponseBody self = new GetUploadUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUploadUrlResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetUploadUrlResponseBody setData(GetUploadUrlResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetUploadUrlResponseBodyData getData() {
        return this.data;
    }

    public GetUploadUrlResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetUploadUrlResponseBodyData extends TeaModel {
        // 附件上传地址
        @NameInMap("uploadUrl")
        public String uploadUrl;

        public static GetUploadUrlResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetUploadUrlResponseBodyData self = new GetUploadUrlResponseBodyData();
            return TeaModel.build(map, self);
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
