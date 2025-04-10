// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class AssistantResponseResponseBody extends TeaModel {
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
    public java.util.List<AssistantResponseResponseBodyOutput> output;

    @NameInMap("status")
    public String status;

    public static AssistantResponseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AssistantResponseResponseBody self = new AssistantResponseResponseBody();
        return TeaModel.build(map, self);
    }

    public AssistantResponseResponseBody setCreatedAt(Long createdAt) {
        this.createdAt = createdAt;
        return this;
    }
    public Long getCreatedAt() {
        return this.createdAt;
    }

    public AssistantResponseResponseBody setError(String error) {
        this.error = error;
        return this;
    }
    public String getError() {
        return this.error;
    }

    public AssistantResponseResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public AssistantResponseResponseBody setMetadata(java.util.Map<String, ?> metadata) {
        this.metadata = metadata;
        return this;
    }
    public java.util.Map<String, ?> getMetadata() {
        return this.metadata;
    }

    public AssistantResponseResponseBody setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public AssistantResponseResponseBody setObject(String object) {
        this.object = object;
        return this;
    }
    public String getObject() {
        return this.object;
    }

    public AssistantResponseResponseBody setOutput(java.util.List<AssistantResponseResponseBodyOutput> output) {
        this.output = output;
        return this;
    }
    public java.util.List<AssistantResponseResponseBodyOutput> getOutput() {
        return this.output;
    }

    public AssistantResponseResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public static class AssistantResponseResponseBodyOutputContent extends TeaModel {
        @NameInMap("annotations")
        public java.util.List<?> annotations;

        @NameInMap("text")
        public String text;

        @NameInMap("type")
        public String type;

        public static AssistantResponseResponseBodyOutputContent build(java.util.Map<String, ?> map) throws Exception {
            AssistantResponseResponseBodyOutputContent self = new AssistantResponseResponseBodyOutputContent();
            return TeaModel.build(map, self);
        }

        public AssistantResponseResponseBodyOutputContent setAnnotations(java.util.List<?> annotations) {
            this.annotations = annotations;
            return this;
        }
        public java.util.List<?> getAnnotations() {
            return this.annotations;
        }

        public AssistantResponseResponseBodyOutputContent setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public AssistantResponseResponseBodyOutputContent setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class AssistantResponseResponseBodyOutput extends TeaModel {
        @NameInMap("content")
        public java.util.List<AssistantResponseResponseBodyOutputContent> content;

        @NameInMap("id")
        public String id;

        @NameInMap("role")
        public String role;

        @NameInMap("type")
        public String type;

        public static AssistantResponseResponseBodyOutput build(java.util.Map<String, ?> map) throws Exception {
            AssistantResponseResponseBodyOutput self = new AssistantResponseResponseBodyOutput();
            return TeaModel.build(map, self);
        }

        public AssistantResponseResponseBodyOutput setContent(java.util.List<AssistantResponseResponseBodyOutputContent> content) {
            this.content = content;
            return this;
        }
        public java.util.List<AssistantResponseResponseBodyOutputContent> getContent() {
            return this.content;
        }

        public AssistantResponseResponseBodyOutput setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public AssistantResponseResponseBodyOutput setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

        public AssistantResponseResponseBodyOutput setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
