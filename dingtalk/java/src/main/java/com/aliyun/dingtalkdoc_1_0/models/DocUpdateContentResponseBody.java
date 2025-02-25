// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocUpdateContentResponseBody extends TeaModel {
    @NameInMap("result")
    public DocUpdateContentResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DocUpdateContentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocUpdateContentResponseBody self = new DocUpdateContentResponseBody();
        return TeaModel.build(map, self);
    }

    public DocUpdateContentResponseBody setResult(DocUpdateContentResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DocUpdateContentResponseBodyResult getResult() {
        return this.result;
    }

    public DocUpdateContentResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DocUpdateContentResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        public static DocUpdateContentResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DocUpdateContentResponseBodyResult self = new DocUpdateContentResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DocUpdateContentResponseBodyResult setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

    }

}
