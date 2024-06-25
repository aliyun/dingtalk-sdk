// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessesInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>006f870b-4d1c-4cd0-85b3-2e866798e947</p>
     */
    @NameInMap("bizObjectId")
    public String bizObjectId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>D0001833abb0fb61524487eb01848207bc89b47</p>
     */
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
