// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocDeleteBlockResponseBody extends TeaModel {
    @NameInMap("result")
    public DocDeleteBlockResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DocDeleteBlockResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocDeleteBlockResponseBody self = new DocDeleteBlockResponseBody();
        return TeaModel.build(map, self);
    }

    public DocDeleteBlockResponseBody setResult(DocDeleteBlockResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DocDeleteBlockResponseBodyResult getResult() {
        return this.result;
    }

    public DocDeleteBlockResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DocDeleteBlockResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        public static DocDeleteBlockResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DocDeleteBlockResponseBodyResult self = new DocDeleteBlockResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DocDeleteBlockResponseBodyResult setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

    }

}
