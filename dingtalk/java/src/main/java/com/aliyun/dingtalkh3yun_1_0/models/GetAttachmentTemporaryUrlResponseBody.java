// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetAttachmentTemporaryUrlResponseBody extends TeaModel {
    /**
     * <p>状态码</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>业务响应结果</p>
     */
    @NameInMap("data")
    public GetAttachmentTemporaryUrlResponseBodyData data;

    /**
     * <p>提示信息</p>
     */
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
        /**
         * <p>附件临时免登地址。有效期为30分钟</p>
         */
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
