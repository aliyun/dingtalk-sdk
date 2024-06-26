// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskDueDateResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateOrganizationTaskDueDateResponseBodyResult result;

    public static UpdateOrganizationTaskDueDateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskDueDateResponseBody self = new UpdateOrganizationTaskDueDateResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskDueDateResponseBody setResult(UpdateOrganizationTaskDueDateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateOrganizationTaskDueDateResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateOrganizationTaskDueDateResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2022-06-13T03:30:42.830Z</p>
         */
        @NameInMap("dueDate")
        public String dueDate;

        /**
         * <strong>example:</strong>
         * <p>2022-06-13T03:30:42.830Z</p>
         */
        @NameInMap("updateTime")
        public String updateTime;

        public static UpdateOrganizationTaskDueDateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateOrganizationTaskDueDateResponseBodyResult self = new UpdateOrganizationTaskDueDateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateOrganizationTaskDueDateResponseBodyResult setDueDate(String dueDate) {
            this.dueDate = dueDate;
            return this;
        }
        public String getDueDate() {
            return this.dueDate;
        }

        public UpdateOrganizationTaskDueDateResponseBodyResult setUpdateTime(String updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public String getUpdateTime() {
            return this.updateTime;
        }

    }

}
