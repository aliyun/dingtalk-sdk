// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumQuerySchemaAndProcessByCodeListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("processCodes")
    public java.util.List<String> processCodes;

    public static PremiumQuerySchemaAndProcessByCodeListRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumQuerySchemaAndProcessByCodeListRequest self = new PremiumQuerySchemaAndProcessByCodeListRequest();
        return TeaModel.build(map, self);
    }

    public PremiumQuerySchemaAndProcessByCodeListRequest setProcessCodes(java.util.List<String> processCodes) {
        this.processCodes = processCodes;
        return this;
    }
    public java.util.List<String> getProcessCodes() {
        return this.processCodes;
    }

}
