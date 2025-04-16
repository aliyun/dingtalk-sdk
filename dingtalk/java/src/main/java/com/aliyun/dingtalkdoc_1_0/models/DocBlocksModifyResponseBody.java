// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocBlocksModifyResponseBody extends TeaModel {
    @NameInMap("result")
    public DocBlocksModifyResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DocBlocksModifyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocBlocksModifyResponseBody self = new DocBlocksModifyResponseBody();
        return TeaModel.build(map, self);
    }

    public DocBlocksModifyResponseBody setResult(DocBlocksModifyResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DocBlocksModifyResponseBodyResult getResult() {
        return this.result;
    }

    public DocBlocksModifyResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DocBlocksModifyResponseBodyResult extends TeaModel {
        @NameInMap("result")
        public java.util.List<?> result;

        public static DocBlocksModifyResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DocBlocksModifyResponseBodyResult self = new DocBlocksModifyResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DocBlocksModifyResponseBodyResult setResult(java.util.List<?> result) {
            this.result = result;
            return this;
        }
        public java.util.List<?> getResult() {
            return this.result;
        }

    }

}
