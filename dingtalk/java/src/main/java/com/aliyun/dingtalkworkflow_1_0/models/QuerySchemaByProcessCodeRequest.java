// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QuerySchemaByProcessCodeRequest extends TeaModel {
    /**
     * <p>应用搭建隔离信息</p>
     */
    @NameInMap("appUuid")
    public String appUuid;

    /**
     * <p>表单的唯一码</p>
     */
    @NameInMap("processCode")
    public String processCode;

    public static QuerySchemaByProcessCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySchemaByProcessCodeRequest self = new QuerySchemaByProcessCodeRequest();
        return TeaModel.build(map, self);
    }

    public QuerySchemaByProcessCodeRequest setAppUuid(String appUuid) {
        this.appUuid = appUuid;
        return this;
    }
    public String getAppUuid() {
        return this.appUuid;
    }

    public QuerySchemaByProcessCodeRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

}
