// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCorpScaleRequest extends TeaModel {
    @NameInMap("corpNames")
    public java.util.List<String> corpNames;

    public static QueryCorpScaleRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpScaleRequest self = new QueryCorpScaleRequest();
        return TeaModel.build(map, self);
    }

    public QueryCorpScaleRequest setCorpNames(java.util.List<String> corpNames) {
        this.corpNames = corpNames;
        return this;
    }
    public java.util.List<String> getCorpNames() {
        return this.corpNames;
    }

}
