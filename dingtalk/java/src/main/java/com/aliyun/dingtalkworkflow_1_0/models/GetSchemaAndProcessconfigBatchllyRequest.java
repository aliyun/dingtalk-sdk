// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetSchemaAndProcessconfigBatchllyRequest extends TeaModel {
    @NameInMap("processCodes")
    public java.util.List<String> processCodes;

    public static GetSchemaAndProcessconfigBatchllyRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSchemaAndProcessconfigBatchllyRequest self = new GetSchemaAndProcessconfigBatchllyRequest();
        return TeaModel.build(map, self);
    }

    public GetSchemaAndProcessconfigBatchllyRequest setProcessCodes(java.util.List<String> processCodes) {
        this.processCodes = processCodes;
        return this;
    }
    public java.util.List<String> getProcessCodes() {
        return this.processCodes;
    }

}
