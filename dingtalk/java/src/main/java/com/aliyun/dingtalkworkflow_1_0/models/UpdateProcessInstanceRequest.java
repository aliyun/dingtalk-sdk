// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class UpdateProcessInstanceRequest extends TeaModel {
    /**
     * <p>抄送列表，注意最大抄送人数量不能超过30。</p>
     */
    @NameInMap("notifiers")
    public java.util.List<UpdateProcessInstanceRequestNotifiers> notifiers;

    /**
     * <p>审批实例ID。</p>
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
        /**
         * <p>抄送接收人用户userId。</p>
         */
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
