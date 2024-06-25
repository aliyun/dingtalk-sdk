// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetAttachmentTemporaryUrlResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>success</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public GetAttachmentTemporaryUrlResponseBodyData data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OK</p>
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
         * <strong>example:</strong>
         * <p><a href="http://h3yun-infrastructure.oss-cn-shenzhen.aliyuncs.com/mi4x54jcr54b0p8hwoad4wxo3/Formal/D000183te0qsxc20pulavqhgv8sky2p1/F0000041/21a42cb3-f679-4206-8314-597a59a7fd7a/01a27595-53ba-406f-8f39-cd31d99435d8?Expires=1641113859&OSSAccessKeyId=LTAI4G6TouCWDLHSHpAsM1eq&Signature=6FBbQbHMt7lrwi6wX1EsEo0Kr84%3D">http://h3yun-infrastructure.oss-cn-shenzhen.aliyuncs.com/mi4x54jcr54b0p8hwoad4wxo3/Formal/D000183te0qsxc20pulavqhgv8sky2p1/F0000041/21a42cb3-f679-4206-8314-597a59a7fd7a/01a27595-53ba-406f-8f39-cd31d99435d8?Expires=1641113859&amp;OSSAccessKeyId=LTAI4G6TouCWDLHSHpAsM1eq&amp;Signature=6FBbQbHMt7lrwi6wX1EsEo0Kr84%3D</a></p>
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
