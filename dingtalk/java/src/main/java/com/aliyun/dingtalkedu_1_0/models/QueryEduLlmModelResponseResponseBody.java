// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryEduLlmModelResponseResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryEduLlmModelResponseResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryEduLlmModelResponseResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryEduLlmModelResponseResponseBody self = new QueryEduLlmModelResponseResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryEduLlmModelResponseResponseBody setResult(QueryEduLlmModelResponseResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryEduLlmModelResponseResponseBodyResult getResult() {
        return this.result;
    }

    public QueryEduLlmModelResponseResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryEduLlmModelResponseResponseBodyResultModelResultUsage extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>888</p>
         */
        @NameInMap("inputTokens")
        public Integer inputTokens;

        /**
         * <strong>example:</strong>
         * <p>666</p>
         */
        @NameInMap("outputTokens")
        public Integer outputTokens;

        public static QueryEduLlmModelResponseResponseBodyResultModelResultUsage build(java.util.Map<String, ?> map) throws Exception {
            QueryEduLlmModelResponseResponseBodyResultModelResultUsage self = new QueryEduLlmModelResponseResponseBodyResultModelResultUsage();
            return TeaModel.build(map, self);
        }

        public QueryEduLlmModelResponseResponseBodyResultModelResultUsage setInputTokens(Integer inputTokens) {
            this.inputTokens = inputTokens;
            return this;
        }
        public Integer getInputTokens() {
            return this.inputTokens;
        }

        public QueryEduLlmModelResponseResponseBodyResultModelResultUsage setOutputTokens(Integer outputTokens) {
            this.outputTokens = outputTokens;
            return this;
        }
        public Integer getOutputTokens() {
            return this.outputTokens;
        }

    }

    public static class QueryEduLlmModelResponseResponseBodyResultModelResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><code>json\n{\n  \&quot;题目1\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;\&quot;\n  },\n  \&quot;题目2\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;\&quot;\n  },\n  \&quot;题目3\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;\&quot;\n  },\n  \&quot;题目4\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;√\&quot;\n  },\n  \&quot;题目5\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;√\&quot;\n  },\n  \&quot;题目6\&quot;: {\n    \&quot;左侧括号内学生答案\&quot;: \&quot;√\&quot;,\n    \&quot;右侧括号内学生答案\&quot;: \&quot;\&quot;\n  }\n}\n</code></p>
         */
        @NameInMap("content")
        public String content;

        @NameInMap("usage")
        public QueryEduLlmModelResponseResponseBodyResultModelResultUsage usage;

        public static QueryEduLlmModelResponseResponseBodyResultModelResult build(java.util.Map<String, ?> map) throws Exception {
            QueryEduLlmModelResponseResponseBodyResultModelResult self = new QueryEduLlmModelResponseResponseBodyResultModelResult();
            return TeaModel.build(map, self);
        }

        public QueryEduLlmModelResponseResponseBodyResultModelResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public QueryEduLlmModelResponseResponseBodyResultModelResult setUsage(QueryEduLlmModelResponseResponseBodyResultModelResultUsage usage) {
            this.usage = usage;
            return this;
        }
        public QueryEduLlmModelResponseResponseBodyResultModelResultUsage getUsage() {
            return this.usage;
        }

    }

    public static class QueryEduLlmModelResponseResponseBodyResult extends TeaModel {
        @NameInMap("modelResult")
        public QueryEduLlmModelResponseResponseBodyResultModelResult modelResult;

        /**
         * <strong>example:</strong>
         * <p>requestxxxxxxx</p>
         */
        @NameInMap("reqId")
        public String reqId;

        public static QueryEduLlmModelResponseResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryEduLlmModelResponseResponseBodyResult self = new QueryEduLlmModelResponseResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryEduLlmModelResponseResponseBodyResult setModelResult(QueryEduLlmModelResponseResponseBodyResultModelResult modelResult) {
            this.modelResult = modelResult;
            return this;
        }
        public QueryEduLlmModelResponseResponseBodyResultModelResult getModelResult() {
            return this.modelResult;
        }

        public QueryEduLlmModelResponseResponseBodyResult setReqId(String reqId) {
            this.reqId = reqId;
            return this;
        }
        public String getReqId() {
            return this.reqId;
        }

    }

}
