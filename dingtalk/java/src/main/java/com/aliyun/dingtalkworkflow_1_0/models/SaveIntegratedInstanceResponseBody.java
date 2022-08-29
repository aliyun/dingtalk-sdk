// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SaveIntegratedInstanceResponseBody extends TeaModel {
    @NameInMap("result")
    public SaveIntegratedInstanceResponseBodyResult result;

    public static SaveIntegratedInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveIntegratedInstanceResponseBody self = new SaveIntegratedInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveIntegratedInstanceResponseBody setResult(SaveIntegratedInstanceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SaveIntegratedInstanceResponseBodyResult getResult() {
        return this.result;
    }

    public static class SaveIntegratedInstanceResponseBodyResult extends TeaModel {
        // 实例id
        @NameInMap("processInstanceId")
        public String processInstanceId;

        public static SaveIntegratedInstanceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SaveIntegratedInstanceResponseBodyResult self = new SaveIntegratedInstanceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SaveIntegratedInstanceResponseBodyResult setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

    }

}
