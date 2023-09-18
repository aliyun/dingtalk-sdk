// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocAppendParagraphResponseBody extends TeaModel {
    @NameInMap("result")
    public DocAppendParagraphResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DocAppendParagraphResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocAppendParagraphResponseBody self = new DocAppendParagraphResponseBody();
        return TeaModel.build(map, self);
    }

    public DocAppendParagraphResponseBody setResult(DocAppendParagraphResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DocAppendParagraphResponseBodyResult getResult() {
        return this.result;
    }

    public DocAppendParagraphResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DocAppendParagraphResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        public static DocAppendParagraphResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DocAppendParagraphResponseBodyResult self = new DocAppendParagraphResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DocAppendParagraphResponseBodyResult setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

    }

}
