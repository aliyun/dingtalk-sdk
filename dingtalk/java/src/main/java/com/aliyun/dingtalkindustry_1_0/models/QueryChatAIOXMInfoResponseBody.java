// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryChatAIOXMInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static QueryChatAIOXMInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryChatAIOXMInfoResponseBody self = new QueryChatAIOXMInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryChatAIOXMInfoResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
