// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocInsertBlocksResponseBody extends TeaModel {
    @NameInMap("result")
    public DocInsertBlocksResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DocInsertBlocksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocInsertBlocksResponseBody self = new DocInsertBlocksResponseBody();
        return TeaModel.build(map, self);
    }

    public DocInsertBlocksResponseBody setResult(DocInsertBlocksResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DocInsertBlocksResponseBodyResult getResult() {
        return this.result;
    }

    public DocInsertBlocksResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DocInsertBlocksResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        public static DocInsertBlocksResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DocInsertBlocksResponseBodyResult self = new DocInsertBlocksResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DocInsertBlocksResponseBodyResult setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

    }

}
