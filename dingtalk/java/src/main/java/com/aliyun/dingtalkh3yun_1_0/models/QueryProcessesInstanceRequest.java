// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessesInstanceRequest extends TeaModel {
    // 业务数据id
    @NameInMap("bizObjectId")
    public String bizObjectId;

    // 表单编码
    @NameInMap("schemaCode")
    public String schemaCode;

    public static QueryProcessesInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryProcessesInstanceRequest self = new QueryProcessesInstanceRequest();
        return TeaModel.build(map, self);
    }

    public QueryProcessesInstanceRequest setBizObjectId(String bizObjectId) {
        this.bizObjectId = bizObjectId;
        return this;
    }
    public String getBizObjectId() {
        return this.bizObjectId;
    }

    public QueryProcessesInstanceRequest setSchemaCode(String schemaCode) {
        this.schemaCode = schemaCode;
        return this;
    }
    public String getSchemaCode() {
        return this.schemaCode;
    }

}
