// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCorpScaleResponseBody extends TeaModel {
    @NameInMap("corpScaleMap")
    public java.util.Map<String, ?> corpScaleMap;

    public static QueryCorpScaleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpScaleResponseBody self = new QueryCorpScaleResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCorpScaleResponseBody setCorpScaleMap(java.util.Map<String, ?> corpScaleMap) {
        this.corpScaleMap = corpScaleMap;
        return this;
    }
    public java.util.Map<String, ?> getCorpScaleMap() {
        return this.corpScaleMap;
    }

}
