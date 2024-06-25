// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QuerySchemaAndProcessRequest extends TeaModel {
    @NameInMap("appUuid")
    public String appUuid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-17428B8C-6C60-xxxx-924C-64F1037AE067</p>
     */
    @NameInMap("processCode")
    public String processCode;

    public static QuerySchemaAndProcessRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySchemaAndProcessRequest self = new QuerySchemaAndProcessRequest();
        return TeaModel.build(map, self);
    }

    public QuerySchemaAndProcessRequest setAppUuid(String appUuid) {
        this.appUuid = appUuid;
        return this;
    }
    public String getAppUuid() {
        return this.appUuid;
    }

    public QuerySchemaAndProcessRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

}
