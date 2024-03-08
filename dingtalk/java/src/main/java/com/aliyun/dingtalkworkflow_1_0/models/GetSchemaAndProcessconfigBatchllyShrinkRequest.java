// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetSchemaAndProcessconfigBatchllyShrinkRequest extends TeaModel {
    @NameInMap("processCodes")
    public String processCodesShrink;

    public static GetSchemaAndProcessconfigBatchllyShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSchemaAndProcessconfigBatchllyShrinkRequest self = new GetSchemaAndProcessconfigBatchllyShrinkRequest();
        return TeaModel.build(map, self);
    }

    public GetSchemaAndProcessconfigBatchllyShrinkRequest setProcessCodesShrink(String processCodesShrink) {
        this.processCodesShrink = processCodesShrink;
        return this;
    }
    public String getProcessCodesShrink() {
        return this.processCodesShrink;
    }

}
