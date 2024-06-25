// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskExecutorResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateTaskExecutorResponseBodyResult result;

    public static UpdateTaskExecutorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskExecutorResponseBody self = new UpdateTaskExecutorResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTaskExecutorResponseBody setResult(UpdateTaskExecutorResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateTaskExecutorResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateTaskExecutorResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>0517xxxxxxx</p>
         */
        @NameInMap("executorId")
        public String executorId;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        public static UpdateTaskExecutorResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateTaskExecutorResponseBodyResult self = new UpdateTaskExecutorResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateTaskExecutorResponseBodyResult setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public UpdateTaskExecutorResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
