// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class AssistantMeResponseResponseBody extends TeaModel {
    @NameInMap("created_at")
    public Long createdAt;

    @NameInMap("error")
    public String error;

    @NameInMap("id")
    public String id;

    @NameInMap("metadata")
    public java.util.Map<String, ?> metadata;

    @NameInMap("model")
    public String model;

    @NameInMap("object")
    public String object;

    @NameInMap("output")
    public java.util.List<AssistantMeResponseResponseBodyOutput> output;

    @NameInMap("status")
    public String status;

    public static AssistantMeResponseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AssistantMeResponseResponseBody self = new AssistantMeResponseResponseBody();
        return TeaModel.build(map, self);
    }

    public AssistantMeResponseResponseBody setCreatedAt(Long createdAt) {
        this.createdAt = createdAt;
        return this;
    }
    public Long getCreatedAt() {
        return this.createdAt;
    }

    public AssistantMeResponseResponseBody setError(String error) {
        this.error = error;
        return this;
    }
    public String getError() {
        return this.error;
    }

    public AssistantMeResponseResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public AssistantMeResponseResponseBody setMetadata(java.util.Map<String, ?> metadata) {
        this.metadata = metadata;
        return this;
    }
    public java.util.Map<String, ?> getMetadata() {
        return this.metadata;
    }

    public AssistantMeResponseResponseBody setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public AssistantMeResponseResponseBody setObject(String object) {
        this.object = object;
        return this;
    }
    public String getObject() {
        return this.object;
    }

    public AssistantMeResponseResponseBody setOutput(java.util.List<AssistantMeResponseResponseBodyOutput> output) {
        this.output = output;
        return this;
    }
    public java.util.List<AssistantMeResponseResponseBodyOutput> getOutput() {
        return this.output;
    }

    public AssistantMeResponseResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public static class AssistantMeResponseResponseBodyOutputContent extends TeaModel {
        @NameInMap("annotations")
        public java.util.List<?> annotations;

        @NameInMap("text")
        public String text;

        @NameInMap("type")
        public String type;

        public static AssistantMeResponseResponseBodyOutputContent build(java.util.Map<String, ?> map) throws Exception {
            AssistantMeResponseResponseBodyOutputContent self = new AssistantMeResponseResponseBodyOutputContent();
            return TeaModel.build(map, self);
        }

        public AssistantMeResponseResponseBodyOutputContent setAnnotations(java.util.List<?> annotations) {
            this.annotations = annotations;
            return this;
        }
        public java.util.List<?> getAnnotations() {
            return this.annotations;
        }

        public AssistantMeResponseResponseBodyOutputContent setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public AssistantMeResponseResponseBodyOutputContent setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class AssistantMeResponseResponseBodyOutput extends TeaModel {
        @NameInMap("content")
        public java.util.List<AssistantMeResponseResponseBodyOutputContent> content;

        @NameInMap("id")
        public String id;

        @NameInMap("role")
        public String role;

        @NameInMap("type")
        public String type;

        public static AssistantMeResponseResponseBodyOutput build(java.util.Map<String, ?> map) throws Exception {
            AssistantMeResponseResponseBodyOutput self = new AssistantMeResponseResponseBodyOutput();
            return TeaModel.build(map, self);
        }

        public AssistantMeResponseResponseBodyOutput setContent(java.util.List<AssistantMeResponseResponseBodyOutputContent> content) {
            this.content = content;
            return this;
        }
        public java.util.List<AssistantMeResponseResponseBodyOutputContent> getContent() {
            return this.content;
        }

        public AssistantMeResponseResponseBodyOutput setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public AssistantMeResponseResponseBodyOutput setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

        public AssistantMeResponseResponseBodyOutput setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
