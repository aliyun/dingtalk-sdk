// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteBatchQueryResultServiceRequest extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    public static SmartQuoteBatchQueryResultServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteBatchQueryResultServiceRequest self = new SmartQuoteBatchQueryResultServiceRequest();
        return TeaModel.build(map, self);
    }

    public SmartQuoteBatchQueryResultServiceRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
