// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetActivationCodeByCallerUnionIdResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static GetActivationCodeByCallerUnionIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetActivationCodeByCallerUnionIdResponseBody self = new GetActivationCodeByCallerUnionIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetActivationCodeByCallerUnionIdResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
