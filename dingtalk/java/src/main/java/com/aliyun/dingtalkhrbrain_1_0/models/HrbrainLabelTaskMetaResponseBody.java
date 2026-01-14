// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelTaskMetaResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<HrbrainLabelTaskMetaResponseBodyContent> content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainLabelTaskMetaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelTaskMetaResponseBody self = new HrbrainLabelTaskMetaResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelTaskMetaResponseBody setContent(java.util.List<HrbrainLabelTaskMetaResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<HrbrainLabelTaskMetaResponseBodyContent> getContent() {
        return this.content;
    }

    public HrbrainLabelTaskMetaResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainLabelTaskMetaResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainLabelTaskMetaResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class HrbrainLabelTaskMetaResponseBodyContent extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("description")
        public String description;

        @NameInMap("isSystem")
        public String isSystem;

        @NameInMap("name")
        public String name;

        @NameInMap("tagConfig")
        public java.util.Map<String, ?> tagConfig;

        public static HrbrainLabelTaskMetaResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            HrbrainLabelTaskMetaResponseBodyContent self = new HrbrainLabelTaskMetaResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public HrbrainLabelTaskMetaResponseBodyContent setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public HrbrainLabelTaskMetaResponseBodyContent setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public HrbrainLabelTaskMetaResponseBodyContent setIsSystem(String isSystem) {
            this.isSystem = isSystem;
            return this;
        }
        public String getIsSystem() {
            return this.isSystem;
        }

        public HrbrainLabelTaskMetaResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainLabelTaskMetaResponseBodyContent setTagConfig(java.util.Map<String, ?> tagConfig) {
            this.tagConfig = tagConfig;
            return this;
        }
        public java.util.Map<String, ?> getTagConfig() {
            return this.tagConfig;
        }

    }

}
