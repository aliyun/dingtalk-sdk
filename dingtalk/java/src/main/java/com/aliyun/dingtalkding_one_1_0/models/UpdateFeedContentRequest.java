// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class UpdateFeedContentRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public UpdateFeedContentRequestContent content;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dd-one-work-eSo869uR9Vhse2sqTw3dDF</p>
     */
    @NameInMap("feedId")
    public String feedId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ntThCP2X44FlskVliPIXPUQiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static UpdateFeedContentRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateFeedContentRequest self = new UpdateFeedContentRequest();
        return TeaModel.build(map, self);
    }

    public UpdateFeedContentRequest setContent(UpdateFeedContentRequestContent content) {
        this.content = content;
        return this;
    }
    public UpdateFeedContentRequestContent getContent() {
        return this.content;
    }

    public UpdateFeedContentRequest setFeedId(String feedId) {
        this.feedId = feedId;
        return this;
    }
    public String getFeedId() {
        return this.feedId;
    }

    public UpdateFeedContentRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class UpdateFeedContentRequestContentDslTemplateContent extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="https://xxxxx.xxx.com/v1.0/test.html">https://xxxxx.xxx.com/v1.0/test.html</a></p>
         */
        @NameInMap("applyUrl")
        public String applyUrl;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>{&quot;date&quot;:&quot;2025-11-06&quot;}</p>
         */
        @NameInMap("body")
        public String body;

        public static UpdateFeedContentRequestContentDslTemplateContent build(java.util.Map<String, ?> map) throws Exception {
            UpdateFeedContentRequestContentDslTemplateContent self = new UpdateFeedContentRequestContentDslTemplateContent();
            return TeaModel.build(map, self);
        }

        public UpdateFeedContentRequestContentDslTemplateContent setApplyUrl(String applyUrl) {
            this.applyUrl = applyUrl;
            return this;
        }
        public String getApplyUrl() {
            return this.applyUrl;
        }

        public UpdateFeedContentRequestContentDslTemplateContent setBody(String body) {
            this.body = body;
            return this;
        }
        public String getBody() {
            return this.body;
        }

    }

    public static class UpdateFeedContentRequestContent extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dslTemplate</p>
         */
        @NameInMap("contentType")
        public String contentType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("dslTemplateContent")
        public UpdateFeedContentRequestContentDslTemplateContent dslTemplateContent;

        public static UpdateFeedContentRequestContent build(java.util.Map<String, ?> map) throws Exception {
            UpdateFeedContentRequestContent self = new UpdateFeedContentRequestContent();
            return TeaModel.build(map, self);
        }

        public UpdateFeedContentRequestContent setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

        public UpdateFeedContentRequestContent setDslTemplateContent(UpdateFeedContentRequestContentDslTemplateContent dslTemplateContent) {
            this.dslTemplateContent = dslTemplateContent;
            return this;
        }
        public UpdateFeedContentRequestContentDslTemplateContent getDslTemplateContent() {
            return this.dslTemplateContent;
        }

    }

}
