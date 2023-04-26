// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetOpenUrlResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static GetOpenUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOpenUrlResponseBody self = new GetOpenUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOpenUrlResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
