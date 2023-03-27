// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskDueDateResponseBody extends TeaModel {
    /**
     * <p>结果。</p>
     */
    @NameInMap("result")
    public UpdateTaskDueDateResponseBodyResult result;

    public static UpdateTaskDueDateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskDueDateResponseBody self = new UpdateTaskDueDateResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTaskDueDateResponseBody setResult(UpdateTaskDueDateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateTaskDueDateResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateTaskDueDateResponseBodyResult extends TeaModel {
        /**
         * <p>截止时间。</p>
         */
        @NameInMap("dueDate")
        public String dueDate;

        /**
         * <p>更新时间。</p>
         */
        @NameInMap("updated")
        public String updated;

        public static UpdateTaskDueDateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateTaskDueDateResponseBodyResult self = new UpdateTaskDueDateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateTaskDueDateResponseBodyResult setDueDate(String dueDate) {
            this.dueDate = dueDate;
            return this;
        }
        public String getDueDate() {
            return this.dueDate;
        }

        public UpdateTaskDueDateResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
