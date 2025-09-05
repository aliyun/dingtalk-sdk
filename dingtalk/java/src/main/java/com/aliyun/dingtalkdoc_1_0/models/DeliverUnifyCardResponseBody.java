// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeliverUnifyCardResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.Map<String, ?> result;

    @NameInMap("success")
    public Boolean success;

    public static DeliverUnifyCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeliverUnifyCardResponseBody self = new DeliverUnifyCardResponseBody();
        return TeaModel.build(map, self);
    }

    public DeliverUnifyCardResponseBody setResult(java.util.Map<String, ?> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ?> getResult() {
        return this.result;
    }

    public DeliverUnifyCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
