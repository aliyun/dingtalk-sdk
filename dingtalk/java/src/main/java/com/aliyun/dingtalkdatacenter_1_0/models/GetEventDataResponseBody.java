// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetEventDataResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    @NameInMap("value")
    public java.util.Map<String, ?> value;

    public static GetEventDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetEventDataResponseBody self = new GetEventDataResponseBody();
        return TeaModel.build(map, self);
    }

    public GetEventDataResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public GetEventDataResponseBody setValue(java.util.Map<String, ?> value) {
        this.value = value;
        return this;
    }
    public java.util.Map<String, ?> getValue() {
        return this.value;
    }

}
