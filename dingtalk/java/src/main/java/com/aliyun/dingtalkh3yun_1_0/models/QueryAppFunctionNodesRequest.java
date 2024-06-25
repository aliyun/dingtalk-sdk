// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryAppFunctionNodesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>D000001</p>
     */
    @NameInMap("appCode")
    public String appCode;

    public static QueryAppFunctionNodesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAppFunctionNodesRequest self = new QueryAppFunctionNodesRequest();
        return TeaModel.build(map, self);
    }

    public QueryAppFunctionNodesRequest setAppCode(String appCode) {
        this.appCode = appCode;
        return this;
    }
    public String getAppCode() {
        return this.appCode;
    }

}
