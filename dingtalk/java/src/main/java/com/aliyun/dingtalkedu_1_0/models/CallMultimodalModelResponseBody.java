// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CallMultimodalModelResponseBody extends TeaModel {
    @NameInMap("result")
    public CallMultimodalModelResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CallMultimodalModelResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CallMultimodalModelResponseBody self = new CallMultimodalModelResponseBody();
        return TeaModel.build(map, self);
    }

    public CallMultimodalModelResponseBody setResult(CallMultimodalModelResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CallMultimodalModelResponseBodyResult getResult() {
        return this.result;
    }

    public CallMultimodalModelResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CallMultimodalModelResponseBodyResultUsage extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("inputTokens")
        public Integer inputTokens;

        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("outputTokens")
        public Integer outputTokens;

        public static CallMultimodalModelResponseBodyResultUsage build(java.util.Map<String, ?> map) throws Exception {
            CallMultimodalModelResponseBodyResultUsage self = new CallMultimodalModelResponseBodyResultUsage();
            return TeaModel.build(map, self);
        }

        public CallMultimodalModelResponseBodyResultUsage setInputTokens(Integer inputTokens) {
            this.inputTokens = inputTokens;
            return this;
        }
        public Integer getInputTokens() {
            return this.inputTokens;
        }

        public CallMultimodalModelResponseBodyResultUsage setOutputTokens(Integer outputTokens) {
            this.outputTokens = outputTokens;
            return this;
        }
        public Integer getOutputTokens() {
            return this.outputTokens;
        }

    }

    public static class CallMultimodalModelResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><code>json\n{\n  \&quot;题目1\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;\&quot;\n  },\n  \&quot;题目2\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;\&quot;\n  }\n}\n</code></p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <strong>example:</strong>
         * <p>requestxxxxxxx</p>
         */
        @NameInMap("reqId")
        public String reqId;

        @NameInMap("usage")
        public CallMultimodalModelResponseBodyResultUsage usage;

        public static CallMultimodalModelResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CallMultimodalModelResponseBodyResult self = new CallMultimodalModelResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CallMultimodalModelResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public CallMultimodalModelResponseBodyResult setReqId(String reqId) {
            this.reqId = reqId;
            return this;
        }
        public String getReqId() {
            return this.reqId;
        }

        public CallMultimodalModelResponseBodyResult setUsage(CallMultimodalModelResponseBodyResultUsage usage) {
            this.usage = usage;
            return this;
        }
        public CallMultimodalModelResponseBodyResultUsage getUsage() {
            return this.usage;
        }

    }

}
