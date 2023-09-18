// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocBlocksQueryResponseBody extends TeaModel {
    @NameInMap("result")
    public DocBlocksQueryResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DocBlocksQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocBlocksQueryResponseBody self = new DocBlocksQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public DocBlocksQueryResponseBody setResult(DocBlocksQueryResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DocBlocksQueryResponseBodyResult getResult() {
        return this.result;
    }

    public DocBlocksQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DocBlocksQueryResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.List<?> data;

        public static DocBlocksQueryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DocBlocksQueryResponseBodyResult self = new DocBlocksQueryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DocBlocksQueryResponseBodyResult setData(java.util.List<?> data) {
            this.data = data;
            return this;
        }
        public java.util.List<?> getData() {
            return this.data;
        }

    }

}
