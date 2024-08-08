// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryScreenTemplateResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryScreenTemplateResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static QueryScreenTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryScreenTemplateResponseBody self = new QueryScreenTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryScreenTemplateResponseBody setResult(java.util.List<QueryScreenTemplateResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryScreenTemplateResponseBodyResult> getResult() {
        return this.result;
    }

    public QueryScreenTemplateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryScreenTemplateResponseBodyResult extends TeaModel {
        @NameInMap("previewUrl")
        public String previewUrl;

        @NameInMap("screenSize")
        public String screenSize;

        @NameInMap("templateId")
        public String templateId;

        @NameInMap("templateName")
        public String templateName;

        @NameInMap("thumbUrl")
        public String thumbUrl;

        public static QueryScreenTemplateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryScreenTemplateResponseBodyResult self = new QueryScreenTemplateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryScreenTemplateResponseBodyResult setPreviewUrl(String previewUrl) {
            this.previewUrl = previewUrl;
            return this;
        }
        public String getPreviewUrl() {
            return this.previewUrl;
        }

        public QueryScreenTemplateResponseBodyResult setScreenSize(String screenSize) {
            this.screenSize = screenSize;
            return this;
        }
        public String getScreenSize() {
            return this.screenSize;
        }

        public QueryScreenTemplateResponseBodyResult setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public QueryScreenTemplateResponseBodyResult setTemplateName(String templateName) {
            this.templateName = templateName;
            return this;
        }
        public String getTemplateName() {
            return this.templateName;
        }

        public QueryScreenTemplateResponseBodyResult setThumbUrl(String thumbUrl) {
            this.thumbUrl = thumbUrl;
            return this;
        }
        public String getThumbUrl() {
            return this.thumbUrl;
        }

    }

}
