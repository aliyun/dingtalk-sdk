// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetUserAppDevAccessResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static GetUserAppDevAccessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserAppDevAccessResponseBody self = new GetUserAppDevAccessResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserAppDevAccessResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
