// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QuerySchemaByProcessCodeRequest extends TeaModel {
    // 表单的唯一码
    @NameInMap("processCode")
    public String processCode;

    public static QuerySchemaByProcessCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySchemaByProcessCodeRequest self = new QuerySchemaByProcessCodeRequest();
        return TeaModel.build(map, self);
    }

    public QuerySchemaByProcessCodeRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

}
