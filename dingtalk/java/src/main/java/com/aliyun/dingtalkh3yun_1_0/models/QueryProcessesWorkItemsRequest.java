// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessesWorkItemsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>006f870b-4d1c-4cd0-85b3-2e866798e947</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    public static QueryProcessesWorkItemsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryProcessesWorkItemsRequest self = new QueryProcessesWorkItemsRequest();
        return TeaModel.build(map, self);
    }

    public QueryProcessesWorkItemsRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

}
