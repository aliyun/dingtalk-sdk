// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskPriorityResponseBody extends TeaModel {
    /**
     * <p>返回对象</p>
     */
    @NameInMap("result")
    public UpdateOrganizationTaskPriorityResponseBodyResult result;

    public static UpdateOrganizationTaskPriorityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskPriorityResponseBody self = new UpdateOrganizationTaskPriorityResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskPriorityResponseBody setResult(UpdateOrganizationTaskPriorityResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateOrganizationTaskPriorityResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateOrganizationTaskPriorityResponseBodyResult extends TeaModel {
        /**
         * <p>优先级【-10,0,1,2】中的一个</p>
         */
        @NameInMap("priority")
        public Integer priority;

        /**
         * <p>更新时间</p>
         */
        @NameInMap("updated")
        public String updated;

        public static UpdateOrganizationTaskPriorityResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateOrganizationTaskPriorityResponseBodyResult self = new UpdateOrganizationTaskPriorityResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateOrganizationTaskPriorityResponseBodyResult setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

        public UpdateOrganizationTaskPriorityResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
