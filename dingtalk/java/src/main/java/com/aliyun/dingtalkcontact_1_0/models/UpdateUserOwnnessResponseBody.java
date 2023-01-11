// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateUserOwnnessResponseBody extends TeaModel {
    /**
     * <p>业务标识id</p>
     */
    @NameInMap("result")
    public String result;

    public static UpdateUserOwnnessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateUserOwnnessResponseBody self = new UpdateUserOwnnessResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateUserOwnnessResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
