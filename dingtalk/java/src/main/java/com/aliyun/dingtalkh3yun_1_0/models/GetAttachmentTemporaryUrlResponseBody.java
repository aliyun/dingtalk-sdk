// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetAttachmentTemporaryUrlResponseBody extends TeaModel {
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public GetAttachmentTemporaryUrlResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static GetAttachmentTemporaryUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAttachmentTemporaryUrlResponseBody self = new GetAttachmentTemporaryUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAttachmentTemporaryUrlResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetAttachmentTemporaryUrlResponseBody setData(GetAttachmentTemporaryUrlResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetAttachmentTemporaryUrlResponseBodyData getData() {
        return this.data;
    }

    public GetAttachmentTemporaryUrlResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetAttachmentTemporaryUrlResponseBodyData extends TeaModel {
        @NameInMap("attachmentUrl")
        public String attachmentUrl;

        public static GetAttachmentTemporaryUrlResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetAttachmentTemporaryUrlResponseBodyData self = new GetAttachmentTemporaryUrlResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetAttachmentTemporaryUrlResponseBodyData setAttachmentUrl(String attachmentUrl) {
            this.attachmentUrl = attachmentUrl;
            return this;
        }
        public String getAttachmentUrl() {
            return this.attachmentUrl;
        }

    }

}
