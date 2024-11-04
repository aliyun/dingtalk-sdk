// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class CreateClueTempResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static CreateClueTempResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateClueTempResponseBody self = new CreateClueTempResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateClueTempResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
