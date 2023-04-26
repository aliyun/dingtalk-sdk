// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ReleaseCommodityResponseBody extends TeaModel {
    @NameInMap("message")
    public String message;

    @NameInMap("success")
    public Boolean success;

    public static ReleaseCommodityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReleaseCommodityResponseBody self = new ReleaseCommodityResponseBody();
        return TeaModel.build(map, self);
    }

    public ReleaseCommodityResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public ReleaseCommodityResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
