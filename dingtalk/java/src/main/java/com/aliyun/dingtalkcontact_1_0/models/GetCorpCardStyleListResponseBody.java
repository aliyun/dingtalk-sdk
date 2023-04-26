// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetCorpCardStyleListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<java.util.Map<String, ?>> result;

    public static GetCorpCardStyleListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCorpCardStyleListResponseBody self = new GetCorpCardStyleListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCorpCardStyleListResponseBody setResult(java.util.List<java.util.Map<String, ?>> result) {
        this.result = result;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getResult() {
        return this.result;
    }

}
