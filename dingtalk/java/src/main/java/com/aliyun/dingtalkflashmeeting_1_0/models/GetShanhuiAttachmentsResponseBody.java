// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class GetShanhuiAttachmentsResponseBody extends TeaModel {
    @NameInMap("result")
    public GetShanhuiAttachmentsResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetShanhuiAttachmentsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetShanhuiAttachmentsResponseBody self = new GetShanhuiAttachmentsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetShanhuiAttachmentsResponseBody setResult(GetShanhuiAttachmentsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetShanhuiAttachmentsResponseBodyResult getResult() {
        return this.result;
    }

    public GetShanhuiAttachmentsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetShanhuiAttachmentsResponseBodyResultAttachments extends TeaModel {
        @NameInMap("resourceUrl")
        public String resourceUrl;

        public static GetShanhuiAttachmentsResponseBodyResultAttachments build(java.util.Map<String, ?> map) throws Exception {
            GetShanhuiAttachmentsResponseBodyResultAttachments self = new GetShanhuiAttachmentsResponseBodyResultAttachments();
            return TeaModel.build(map, self);
        }

        public GetShanhuiAttachmentsResponseBodyResultAttachments setResourceUrl(String resourceUrl) {
            this.resourceUrl = resourceUrl;
            return this;
        }
        public String getResourceUrl() {
            return this.resourceUrl;
        }

    }

    public static class GetShanhuiAttachmentsResponseBodyResult extends TeaModel {
        @NameInMap("attachments")
        public java.util.List<GetShanhuiAttachmentsResponseBodyResultAttachments> attachments;

        public static GetShanhuiAttachmentsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetShanhuiAttachmentsResponseBodyResult self = new GetShanhuiAttachmentsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetShanhuiAttachmentsResponseBodyResult setAttachments(java.util.List<GetShanhuiAttachmentsResponseBodyResultAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<GetShanhuiAttachmentsResponseBodyResultAttachments> getAttachments() {
            return this.attachments;
        }

    }

}
