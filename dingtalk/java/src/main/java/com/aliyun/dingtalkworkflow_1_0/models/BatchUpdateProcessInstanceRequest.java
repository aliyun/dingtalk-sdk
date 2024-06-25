// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateProcessInstanceRequest extends TeaModel {
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>manager001</p>
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
        @NameInMap("notifiers")
        public java.util.List<BatchUpdateProcessInstanceRequestUpdateProcessInstanceRequestsNotifiers> notifiers;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <strong>example:</strong>
         * <p>agree</p>
         */
        @NameInMap("result")
        public String result;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>COMPLETED</p>
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
