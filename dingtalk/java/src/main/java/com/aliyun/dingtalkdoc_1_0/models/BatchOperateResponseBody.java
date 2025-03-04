// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BatchOperateResponseBody extends TeaModel {
    @NameInMap("result")
    public BatchOperateResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static BatchOperateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchOperateResponseBody self = new BatchOperateResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchOperateResponseBody setResult(BatchOperateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public BatchOperateResponseBodyResult getResult() {
        return this.result;
    }

    public BatchOperateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class BatchOperateResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public java.util.List<?> data;

        public static BatchOperateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchOperateResponseBodyResult self = new BatchOperateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchOperateResponseBodyResult setData(java.util.List<?> data) {
            this.data = data;
            return this;
        }
        public java.util.List<?> getData() {
            return this.data;
        }

    }

}
