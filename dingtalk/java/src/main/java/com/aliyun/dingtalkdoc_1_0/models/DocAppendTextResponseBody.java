// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocAppendTextResponseBody extends TeaModel {
    @NameInMap("result")
    public DocAppendTextResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DocAppendTextResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocAppendTextResponseBody self = new DocAppendTextResponseBody();
        return TeaModel.build(map, self);
    }

    public DocAppendTextResponseBody setResult(DocAppendTextResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DocAppendTextResponseBodyResult getResult() {
        return this.result;
    }

    public DocAppendTextResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DocAppendTextResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        public static DocAppendTextResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DocAppendTextResponseBodyResult self = new DocAppendTextResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DocAppendTextResponseBodyResult setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

    }

}
