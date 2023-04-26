// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class DeleteInnerAppResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeleteInnerAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteInnerAppResponseBody self = new DeleteInnerAppResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteInnerAppResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
