// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetPointActionRecordResponseBody extends TeaModel {
    @NameInMap("result")
    public GetPointActionRecordResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetPointActionRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPointActionRecordResponseBody self = new GetPointActionRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPointActionRecordResponseBody setResult(GetPointActionRecordResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetPointActionRecordResponseBodyResult getResult() {
        return this.result;
    }

    public GetPointActionRecordResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetPointActionRecordResponseBodyResult extends TeaModel {
        @NameInMap("actionTime")
        public String actionTime;

        @NameInMap("quantity")
        public Long quantity;

        @NameInMap("status")
        public String status;

        public static GetPointActionRecordResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetPointActionRecordResponseBodyResult self = new GetPointActionRecordResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetPointActionRecordResponseBodyResult setActionTime(String actionTime) {
            this.actionTime = actionTime;
            return this;
        }
        public String getActionTime() {
            return this.actionTime;
        }

        public GetPointActionRecordResponseBodyResult setQuantity(Long quantity) {
            this.quantity = quantity;
            return this;
        }
        public Long getQuantity() {
            return this.quantity;
        }

        public GetPointActionRecordResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
