// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class UpdateProcessInstanceRequest extends TeaModel {
    @NameInMap("notifiers")
    public java.util.List<UpdateProcessInstanceRequestNotifiers> notifiers;

    @NameInMap("processInstanceId")
    public String processInstanceId;

    @NameInMap("result")
    public String result;

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

    public static class UpdateProcessInstanceRequestNotifiers extends TeaModel {
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
