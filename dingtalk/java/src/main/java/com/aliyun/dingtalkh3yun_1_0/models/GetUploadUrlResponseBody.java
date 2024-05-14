// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetUploadUrlResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public GetUploadUrlResponseBodyData data;

    /**
     * <p>This parameter is required.</p>
     */
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
