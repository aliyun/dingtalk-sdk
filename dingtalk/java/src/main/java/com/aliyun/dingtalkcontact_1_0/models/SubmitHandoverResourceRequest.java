// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SubmitHandoverResourceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tasks")
    public java.util.List<SubmitHandoverResourceRequestTasks> tasks;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>userIdXXX</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SubmitHandoverResourceRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitHandoverResourceRequest self = new SubmitHandoverResourceRequest();
        return TeaModel.build(map, self);
    }

    public SubmitHandoverResourceRequest setTasks(java.util.List<SubmitHandoverResourceRequestTasks> tasks) {
        this.tasks = tasks;
        return this;
    }
    public java.util.List<SubmitHandoverResourceRequestTasks> getTasks() {
        return this.tasks;
    }

    public SubmitHandoverResourceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class SubmitHandoverResourceRequestTasks extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>handover</p>
         */
        @NameInMap("actionType")
        public String actionType;

        /**
         * <strong>example:</strong>
         * <p>userIdYYY</p>
         */
        @NameInMap("receiverStaffId")
        public String receiverStaffId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("resourceTypeId")
        public Long resourceTypeId;

        public static SubmitHandoverResourceRequestTasks build(java.util.Map<String, ?> map) throws Exception {
            SubmitHandoverResourceRequestTasks self = new SubmitHandoverResourceRequestTasks();
            return TeaModel.build(map, self);
        }

        public SubmitHandoverResourceRequestTasks setActionType(String actionType) {
            this.actionType = actionType;
            return this;
        }
        public String getActionType() {
            return this.actionType;
        }

        public SubmitHandoverResourceRequestTasks setReceiverStaffId(String receiverStaffId) {
            this.receiverStaffId = receiverStaffId;
            return this;
        }
        public String getReceiverStaffId() {
            return this.receiverStaffId;
        }

        public SubmitHandoverResourceRequestTasks setResourceTypeId(Long resourceTypeId) {
            this.resourceTypeId = resourceTypeId;
            return this;
        }
        public Long getResourceTypeId() {
            return this.resourceTypeId;
        }

    }

}
