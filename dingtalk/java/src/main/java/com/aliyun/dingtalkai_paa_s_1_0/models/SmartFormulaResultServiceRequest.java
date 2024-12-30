// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartFormulaResultServiceRequest extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    public static SmartFormulaResultServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        SmartFormulaResultServiceRequest self = new SmartFormulaResultServiceRequest();
        return TeaModel.build(map, self);
    }

    public SmartFormulaResultServiceRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
