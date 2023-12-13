// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmMailSendResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static HrmMailSendResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrmMailSendResponseBody self = new HrmMailSendResponseBody();
        return TeaModel.build(map, self);
    }

    public HrmMailSendResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
