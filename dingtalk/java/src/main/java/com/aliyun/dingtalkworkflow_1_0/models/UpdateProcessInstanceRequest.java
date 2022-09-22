// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class UpdateProcessInstanceRequest extends TeaModel {
    // 抄送列表，注意最大抄送人数量不能超过30。
    @NameInMap("notifiers")
    public java.util.List<UpdateProcessInstanceRequestNotifiers> notifiers;

    // 审批实例ID。
    @NameInMap("processInstanceId")
    public String processInstanceId;

    // 实例结果：
    // 实例状态是COMPLETED，必须设置代表以下含义。
    // agree：同意
    // refuse：拒绝
    // 实例状态为TERMINATED，必须设置代表含义，result取值agree和refuse均代表撤销审批流。
    @NameInMap("result")
    public String result;

    // 实例状态：
    // COMPLETED：结束审批流
    // TERMINATED：终止审批流
    @NameInMap("status")
    public String status;

    public static UpdateProcessInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateProcessInstanceRequest self = new UpdateProcessInstanceRequest();
        return TeaModel.build(map, self);
    }

    public UpdateProcessInstanceRequest setNotifiers(java.util.List<UpdateProcessInstanceRequestNotifiers> notifiers) {
        this.notifiers = notifiers;
        return this;
    }
    public java.util.List<UpdateProcessInstanceRequestNotifiers> getNotifiers() {
        return this.notifiers;
    }

    public UpdateProcessInstanceRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public UpdateProcessInstanceRequest setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public UpdateProcessInstanceRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public static class BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers extends TeaModel {
        // 抄送接收人用户userId。
        @NameInMap("userId")
        public String userId;

        public static BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers self = new BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers();
            return TeaModel.build(map, self);
        }

        public BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests extends TeaModel {
        // 抄送列表，注意最大抄送人数量不能超过30。
        @NameInMap("notifiers")
        public java.util.List<BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers> notifiers;

        // 实例id
        @NameInMap("processInstanceId")
        public String processInstanceId;

        // 实例结果：
        // 实例状态是COMPLETED，必须设置代表以下含义。
        // agree：同意
        // refuse：拒绝
        // 实例状态为TERMINATED，必须设置代表含义，result取值agree和refuse均代表撤销审批流。
        @NameInMap("result")
        public String result;

        // 实例状态：
        // COMPLETED：结束审批流
        // TERMINATED：终止审批流
        @NameInMap("status")
        public String status;

        public static BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests self = new BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests();
            return TeaModel.build(map, self);
        }

        public BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests setNotifiers(java.util.List<BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers> notifiers) {
            this.notifiers = notifiers;
            return this;
        }
        public java.util.List<BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers> getNotifiers() {
            return this.notifiers;
        }

        public BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

    public static class UpdateProcessInstanceRequestNotifiers extends TeaModel {
        // 抄送接收人用户userId。
        @NameInMap("userId")
        public String userId;

        public static UpdateProcessInstanceRequestNotifiers build(java.util.Map<String, ?> map) throws Exception {
            UpdateProcessInstanceRequestNotifiers self = new UpdateProcessInstanceRequestNotifiers();
            return TeaModel.build(map, self);
        }

        public UpdateProcessInstanceRequestNotifiers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
