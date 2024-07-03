// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class CloseDataDeliverResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static CloseDataDeliverResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CloseDataDeliverResponseBody self = new CloseDataDeliverResponseBody();
        return TeaModel.build(map, self);
    }

    public CloseDataDeliverResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public CloseDataDeliverResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
