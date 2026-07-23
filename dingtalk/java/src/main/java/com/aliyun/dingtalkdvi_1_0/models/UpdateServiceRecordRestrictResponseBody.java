// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class UpdateServiceRecordRestrictResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateServiceRecordRestrictResponseBodyResult result;

    public static UpdateServiceRecordRestrictResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateServiceRecordRestrictResponseBody self = new UpdateServiceRecordRestrictResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateServiceRecordRestrictResponseBody setResult(UpdateServiceRecordRestrictResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateServiceRecordRestrictResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateServiceRecordRestrictResponseBodyResult extends TeaModel {
        @NameInMap("failCount")
        public Integer failCount;

        @NameInMap("failedRecordIds")
        public java.util.List<String> failedRecordIds;

        @NameInMap("successCount")
        public Integer successCount;

        @NameInMap("total")
        public Integer total;

        public static UpdateServiceRecordRestrictResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateServiceRecordRestrictResponseBodyResult self = new UpdateServiceRecordRestrictResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateServiceRecordRestrictResponseBodyResult setFailCount(Integer failCount) {
            this.failCount = failCount;
            return this;
        }
        public Integer getFailCount() {
            return this.failCount;
        }

        public UpdateServiceRecordRestrictResponseBodyResult setFailedRecordIds(java.util.List<String> failedRecordIds) {
            this.failedRecordIds = failedRecordIds;
            return this;
        }
        public java.util.List<String> getFailedRecordIds() {
            return this.failedRecordIds;
        }

        public UpdateServiceRecordRestrictResponseBodyResult setSuccessCount(Integer successCount) {
            this.successCount = successCount;
            return this;
        }
        public Integer getSuccessCount() {
            return this.successCount;
        }

        public UpdateServiceRecordRestrictResponseBodyResult setTotal(Integer total) {
            this.total = total;
            return this;
        }
        public Integer getTotal() {
            return this.total;
        }

    }

}
