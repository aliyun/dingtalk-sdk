// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbay_max_1_0.models;

import com.aliyun.tea.*;

public class QueryBaymaxSkillLogResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static QueryBaymaxSkillLogResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBaymaxSkillLogResponseBody self = new QueryBaymaxSkillLogResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBaymaxSkillLogResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
