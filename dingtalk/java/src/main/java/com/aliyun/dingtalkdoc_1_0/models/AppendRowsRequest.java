// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class AppendRowsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("values")
    public java.util.List<java.util.List<String>> values;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static AppendRowsRequest build(java.util.Map<String, ?> map) throws Exception {
        AppendRowsRequest self = new AppendRowsRequest();
        return TeaModel.build(map, self);
    }

    public AppendRowsRequest setValues(java.util.List<java.util.List<String>> values) {
        this.values = values;
        return this;
    }
    public java.util.List<java.util.List<String>> getValues() {
        return this.values;
    }

    public AppendRowsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
