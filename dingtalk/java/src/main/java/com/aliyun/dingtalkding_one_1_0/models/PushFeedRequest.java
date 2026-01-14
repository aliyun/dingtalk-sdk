// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class PushFeedRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public PushFeedRequestContent content;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1772177962000</p>
     */
    @NameInMap("expireTime")
    public Long expireTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("feedFeature")
    public java.util.Map<String, ?> feedFeature;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>iwElAqN6aXADBgQABQAGsO9WlNbxvoXaCN</p>
     */
    @NameInMap("idempotentKey")
    public String idempotentKey;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ntThCP2X44Fw73IXPUQiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static PushFeedRequest build(java.util.Map<String, ?> map) throws Exception {
        PushFeedRequest self = new PushFeedRequest();
        return TeaModel.build(map, self);
    }

    public PushFeedRequest setContent(PushFeedRequestContent content) {
        this.content = content;
        return this;
    }
    public PushFeedRequestContent getContent() {
        return this.content;
    }

    public PushFeedRequest setExpireTime(Long expireTime) {
        this.expireTime = expireTime;
        return this;
    }
    public Long getExpireTime() {
        return this.expireTime;
    }

    public PushFeedRequest setFeedFeature(java.util.Map<String, ?> feedFeature) {
        this.feedFeature = feedFeature;
        return this;
    }
    public java.util.Map<String, ?> getFeedFeature() {
        return this.feedFeature;
    }

    public PushFeedRequest setIdempotentKey(String idempotentKey) {
        this.idempotentKey = idempotentKey;
        return this;
    }
    public String getIdempotentKey() {
        return this.idempotentKey;
    }

    public PushFeedRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class PushFeedRequestContentDslTemplateContent extends TeaModel {
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

        public static PushFeedRequestContentDslTemplateContent build(java.util.Map<String, ?> map) throws Exception {
            PushFeedRequestContentDslTemplateContent self = new PushFeedRequestContentDslTemplateContent();
            return TeaModel.build(map, self);
        }

        public PushFeedRequestContentDslTemplateContent setApplyUrl(String applyUrl) {
            this.applyUrl = applyUrl;
            return this;
        }
        public String getApplyUrl() {
            return this.applyUrl;
        }

        public PushFeedRequestContentDslTemplateContent setBody(String body) {
            this.body = body;
            return this;
        }
        public String getBody() {
            return this.body;
        }

    }

    public static class PushFeedRequestContent extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dsTemplate</p>
         */
        @NameInMap("contentType")
        public String contentType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("dslTemplateContent")
        public PushFeedRequestContentDslTemplateContent dslTemplateContent;

        public static PushFeedRequestContent build(java.util.Map<String, ?> map) throws Exception {
            PushFeedRequestContent self = new PushFeedRequestContent();
            return TeaModel.build(map, self);
        }

        public PushFeedRequestContent setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

        public PushFeedRequestContent setDslTemplateContent(PushFeedRequestContentDslTemplateContent dslTemplateContent) {
            this.dslTemplateContent = dslTemplateContent;
            return this;
        }
        public PushFeedRequestContentDslTemplateContent getDslTemplateContent() {
            return this.dslTemplateContent;
        }

    }

}
