// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenKnowledgeResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public AddOpenKnowledgeResponseBodyResult result;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static AddOpenKnowledgeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddOpenKnowledgeResponseBody self = new AddOpenKnowledgeResponseBody();
        return TeaModel.build(map, self);
    }

    public AddOpenKnowledgeResponseBody setResult(AddOpenKnowledgeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddOpenKnowledgeResponseBodyResult getResult() {
        return this.result;
    }

    public AddOpenKnowledgeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AddOpenKnowledgeResponseBodyResult extends TeaModel {
        @NameInMap("id")
        public Long id;

        @NameInMap("message")
        public String message;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static AddOpenKnowledgeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddOpenKnowledgeResponseBodyResult self = new AddOpenKnowledgeResponseBodyResult();
            return TeaModel.build(map, self);
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

        public AddOpenKnowledgeResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
