// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryFormInstanceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>SWAPP-dfeacds-example</p>
     */
    @NameInMap("appUuid")
    public String appUuid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-abcdef-example</p>
     */
    @NameInMap("formCode")
    public String formCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>951a8-8828-430c-b3e-example</p>
     */
    @NameInMap("formInstanceId")
    public String formInstanceId;

    public static QueryFormInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryFormInstanceRequest self = new QueryFormInstanceRequest();
        return TeaModel.build(map, self);
    }

    public QueryFormInstanceRequest setAppUuid(String appUuid) {
        this.appUuid = appUuid;
        return this;
    }
    public String getAppUuid() {
        return this.appUuid;
    }

    public QueryFormInstanceRequest setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public QueryFormInstanceRequest setFormInstanceId(String formInstanceId) {
        this.formInstanceId = formInstanceId;
        return this;
    }
    public String getFormInstanceId() {
        return this.formInstanceId;
    }

}
