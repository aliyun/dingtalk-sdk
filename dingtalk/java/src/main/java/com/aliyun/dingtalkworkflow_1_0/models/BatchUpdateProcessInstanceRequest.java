// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateProcessInstanceRequest extends TeaModel {
    /**
     * <p>实列列表。</p>
     */
    @NameInMap("updateProcessInstanceRequests")
    public java.util.List<BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests> updateProcessInstanceRequests;

    public static BatchUpdateProcessInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateProcessInstanceRequest self = new BatchUpdateProcessInstanceRequest();
        return TeaModel.build(map, self);
    }

    public BatchUpdateProcessInstanceRequest setUpdateProcessInstanceRequests(java.util.List<BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests> updateProcessInstanceRequests) {
        this.updateProcessInstanceRequests = updateProcessInstanceRequests;
        return this;
    }
    public java.util.List<BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequests> getUpdateProcessInstanceRequests() {
        return this.updateProcessInstanceRequests;
    }

    public static class BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers extends TeaModel {
        /**
         * <p>抄送接收人用户userId。</p>
         */
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
        /**
         * <p>抄送列表，注意最大抄送人数量不能超过30。</p>
         */
        @NameInMap("notifiers")
        public java.util.List<BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers> notifiers;

        /**
         * <p>实例id</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <p>实例结果：</p>
         * <p>实例状态是COMPLETED，必须设置代表以下含义。</p>
         * <p>agree：同意</p>
         * <p>refuse：拒绝</p>
         * <p>实例状态为TERMINATED，必须设置代表含义，result取值agree和refuse均代表撤销审批流。</p>
         */
        @NameInMap("result")
        public String result;

        /**
         * <p>实例状态：</p>
         * <p>COMPLETED：结束审批流</p>
         * <p>TERMINATED：终止审批流</p>
         */
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

}
