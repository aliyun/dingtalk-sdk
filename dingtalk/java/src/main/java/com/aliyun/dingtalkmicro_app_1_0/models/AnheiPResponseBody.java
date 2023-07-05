// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AnheiPResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static AnheiPResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AnheiPResponseBody self = new AnheiPResponseBody();
        return TeaModel.build(map, self);
    }

    public AnheiPResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
