// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetCorpLevelByAccountIdResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static GetCorpLevelByAccountIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCorpLevelByAccountIdResponseBody self = new GetCorpLevelByAccountIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCorpLevelByAccountIdResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
