// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCorpScaleShrinkRequest extends TeaModel {
    @NameInMap("corpNames")
    public String corpNamesShrink;

    public static QueryCorpScaleShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpScaleShrinkRequest self = new QueryCorpScaleShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QueryCorpScaleShrinkRequest setCorpNamesShrink(String corpNamesShrink) {
        this.corpNamesShrink = corpNamesShrink;
        return this;
    }
    public String getCorpNamesShrink() {
        return this.corpNamesShrink;
    }

}
