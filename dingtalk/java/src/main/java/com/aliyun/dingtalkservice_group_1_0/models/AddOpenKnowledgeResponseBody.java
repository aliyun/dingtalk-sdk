// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenKnowledgeResponseBody extends TeaModel {
    // 请求是否成功
    @NameInMap("success")
    public Boolean success;

    // 返回结果
    @NameInMap("result")
    public AddOpenKnowledgeResponseBodyResult result;

    public static AddOpenKnowledgeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddOpenKnowledgeResponseBody self = new AddOpenKnowledgeResponseBody();
        return TeaModel.build(map, self);
    }

    public AddOpenKnowledgeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public AddOpenKnowledgeResponseBody setResult(AddOpenKnowledgeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddOpenKnowledgeResponseBodyResult getResult() {
        return this.result;
    }

    public static class AddOpenKnowledgeResponseBodyResult extends TeaModel {
        // 操作是否成功标识
        @NameInMap("success")
        public Boolean success;

        // 知识点ID
        @NameInMap("id")
        public Long id;

        // 失败错误消息
        @NameInMap("message")
        public String message;

        public static AddOpenKnowledgeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddOpenKnowledgeResponseBodyResult self = new AddOpenKnowledgeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddOpenKnowledgeResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public AddOpenKnowledgeResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public AddOpenKnowledgeResponseBodyResult setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
        }

    }

}
