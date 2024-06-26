// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskPriorityResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateTaskPriorityResponseBodyResult result;

    public static UpdateTaskPriorityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskPriorityResponseBody self = new UpdateTaskPriorityResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTaskPriorityResponseBody setResult(UpdateTaskPriorityResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateTaskPriorityResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateTaskPriorityResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("priority")
        public Integer priority;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        public static UpdateTaskPriorityResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateTaskPriorityResponseBodyResult self = new UpdateTaskPriorityResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateTaskPriorityResponseBodyResult setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

        public UpdateTaskPriorityResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
