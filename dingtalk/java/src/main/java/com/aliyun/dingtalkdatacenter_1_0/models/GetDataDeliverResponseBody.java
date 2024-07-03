// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetDataDeliverResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static GetDataDeliverResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDataDeliverResponseBody self = new GetDataDeliverResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDataDeliverResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public GetDataDeliverResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
