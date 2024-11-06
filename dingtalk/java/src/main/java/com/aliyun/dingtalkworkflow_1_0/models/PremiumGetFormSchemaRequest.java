// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetFormSchemaRequest extends TeaModel {
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

    public static PremiumGetFormSchemaRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetFormSchemaRequest self = new PremiumGetFormSchemaRequest();
        return TeaModel.build(map, self);
    }

    public PremiumGetFormSchemaRequest setAppUuid(String appUuid) {
        this.appUuid = appUuid;
        return this;
    }
    public String getAppUuid() {
        return this.appUuid;
    }

    public PremiumGetFormSchemaRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

}
