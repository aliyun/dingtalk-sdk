// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesTodoResponseBody extends TeaModel {
    @NameInMap("actions")
    public java.util.List<String> actions;

    public static QueryMinutesTodoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesTodoResponseBody self = new QueryMinutesTodoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMinutesTodoResponseBody setActions(java.util.List<String> actions) {
        this.actions = actions;
        return this;
    }
    public java.util.List<String> getActions() {
        return this.actions;
    }

}
