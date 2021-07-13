// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class QueryHtmlBundleBuildResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static QueryHtmlBundleBuildResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryHtmlBundleBuildResponseBody self = new QueryHtmlBundleBuildResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryHtmlBundleBuildResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
