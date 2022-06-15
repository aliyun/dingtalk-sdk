// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskDueDateResponseBody extends TeaModel {
    // 返回对象
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
        // 任务截止时间
        @NameInMap("dueDate")
        public String dueDate;

        // 更新时间
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
