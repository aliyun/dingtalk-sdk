// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmMokaOapiResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.Map<String, ?> result;

    public static HrmMokaOapiResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrmMokaOapiResponseBody self = new HrmMokaOapiResponseBody();
        return TeaModel.build(map, self);
    }

    public HrmMokaOapiResponseBody setResult(java.util.Map<String, ?> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ?> getResult() {
        return this.result;
    }

}
