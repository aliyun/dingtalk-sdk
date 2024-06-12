// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class CreateDataDeliverResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static CreateDataDeliverResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateDataDeliverResponseBody self = new CreateDataDeliverResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateDataDeliverResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public CreateDataDeliverResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
