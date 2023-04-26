// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListOperationLogsResponseBody extends TeaModel {
    @NameInMap("operationLogMap")
    public java.util.Map<String, ?> operationLogMap;

    public static ListOperationLogsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListOperationLogsResponseBody self = new ListOperationLogsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListOperationLogsResponseBody setOperationLogMap(java.util.Map<String, ?> operationLogMap) {
        this.operationLogMap = operationLogMap;
        return this;
    }
    public java.util.Map<String, ?> getOperationLogMap() {
        return this.operationLogMap;
    }

}
