// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SmartQuoteQueryResultServiceRequest extends TeaModel {
    @NameInMap("taskId")
    public String taskId;

    public static SmartQuoteQueryResultServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        SmartQuoteQueryResultServiceRequest self = new SmartQuoteQueryResultServiceRequest();
        return TeaModel.build(map, self);
    }

    public SmartQuoteQueryResultServiceRequest setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
