// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class PrepareSetRichTextResponseBody extends TeaModel {
    @NameInMap("markdown")
    public String markdown;

    @NameInMap("uploadInfos")
    public java.util.List<PrepareSetRichTextResponseBodyUploadInfos> uploadInfos;

    public static PrepareSetRichTextResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PrepareSetRichTextResponseBody self = new PrepareSetRichTextResponseBody();
        return TeaModel.build(map, self);
    }

    public PrepareSetRichTextResponseBody setMarkdown(String markdown) {
        this.markdown = markdown;
        return this;
    }
    public String getMarkdown() {
        return this.markdown;
    }

    public PrepareSetRichTextResponseBody setUploadInfos(java.util.List<PrepareSetRichTextResponseBodyUploadInfos> uploadInfos) {
        this.uploadInfos = uploadInfos;
        return this;
    }
    public java.util.List<PrepareSetRichTextResponseBodyUploadInfos> getUploadInfos() {
        return this.uploadInfos;
    }

    public static class PrepareSetRichTextResponseBodyUploadInfos extends TeaModel {
        @NameInMap("resourceId")
        public String resourceId;

        @NameInMap("resourceUrl")
        public String resourceUrl;

        @NameInMap("uploadUrl")
        public String uploadUrl;

        public static PrepareSetRichTextResponseBodyUploadInfos build(java.util.Map<String, ?> map) throws Exception {
            PrepareSetRichTextResponseBodyUploadInfos self = new PrepareSetRichTextResponseBodyUploadInfos();
            return TeaModel.build(map, self);
        }

        public PrepareSetRichTextResponseBodyUploadInfos setResourceId(String resourceId) {
            this.resourceId = resourceId;
            return this;
        }
        public String getResourceId() {
            return this.resourceId;
        }

        public PrepareSetRichTextResponseBodyUploadInfos setResourceUrl(String resourceUrl) {
            this.resourceUrl = resourceUrl;
            return this;
        }
        public String getResourceUrl() {
            return this.resourceUrl;
        }

        public PrepareSetRichTextResponseBodyUploadInfos setUploadUrl(String uploadUrl) {
            this.uploadUrl = uploadUrl;
            return this;
        }
        public String getUploadUrl() {
            return this.uploadUrl;
        }

    }

}
