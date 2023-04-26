// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetMicroAppUserAccessResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static GetMicroAppUserAccessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMicroAppUserAccessResponseBody self = new GetMicroAppUserAccessResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMicroAppUserAccessResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
