// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class ListDataDeliversResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static ListDataDeliversResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListDataDeliversResponseBody self = new ListDataDeliversResponseBody();
        return TeaModel.build(map, self);
    }

    public ListDataDeliversResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public ListDataDeliversResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
