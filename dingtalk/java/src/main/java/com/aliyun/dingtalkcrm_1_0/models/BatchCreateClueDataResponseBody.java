// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateClueDataResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<BatchCreateClueDataResponseBodyResult> result;

    public static BatchCreateClueDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateClueDataResponseBody self = new BatchCreateClueDataResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchCreateClueDataResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public BatchCreateClueDataResponseBody setResult(java.util.List<BatchCreateClueDataResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<BatchCreateClueDataResponseBodyResult> getResult() {
        return this.result;
    }

    public static class BatchCreateClueDataResponseBodyResult extends TeaModel {
        @NameInMap("clueId")
        public String clueId;

        @NameInMap("dataId")
        public String dataId;

        @NameInMap("resultCode")
        public String resultCode;

        public static BatchCreateClueDataResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateClueDataResponseBodyResult self = new BatchCreateClueDataResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchCreateClueDataResponseBodyResult setClueId(String clueId) {
            this.clueId = clueId;
            return this;
        }
        public String getClueId() {
            return this.clueId;
        }

        public BatchCreateClueDataResponseBodyResult setDataId(String dataId) {
            this.dataId = dataId;
            return this;
        }
        public String getDataId() {
            return this.dataId;
        }

        public BatchCreateClueDataResponseBodyResult setResultCode(String resultCode) {
            this.resultCode = resultCode;
            return this;
        }
        public String getResultCode() {
            return this.resultCode;
        }

    }

}
