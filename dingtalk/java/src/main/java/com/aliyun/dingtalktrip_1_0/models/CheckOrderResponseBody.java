// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class CheckOrderResponseBody extends TeaModel {
    @NameInMap("errMsg")
    public String errMsg;

    @NameInMap("result")
    public Boolean result;

    public static CheckOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckOrderResponseBody self = new CheckOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckOrderResponseBody setErrMsg(String errMsg) {
        this.errMsg = errMsg;
        return this;
    }
    public String getErrMsg() {
        return this.errMsg;
    }

    public CheckOrderResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
