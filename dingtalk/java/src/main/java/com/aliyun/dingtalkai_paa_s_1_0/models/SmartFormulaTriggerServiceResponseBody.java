// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartFormulaTriggerServiceResponseBody extends TeaModel {
    @NameInMap("result")
    public SmartFormulaTriggerServiceResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SmartFormulaTriggerServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SmartFormulaTriggerServiceResponseBody self = new SmartFormulaTriggerServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public SmartFormulaTriggerServiceResponseBody setResult(SmartFormulaTriggerServiceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SmartFormulaTriggerServiceResponseBodyResult getResult() {
        return this.result;
    }

    public SmartFormulaTriggerServiceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SmartFormulaTriggerServiceResponseBodyResult extends TeaModel {
        @NameInMap("taskId")
        public String taskId;

        public static SmartFormulaTriggerServiceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SmartFormulaTriggerServiceResponseBodyResult self = new SmartFormulaTriggerServiceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SmartFormulaTriggerServiceResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
