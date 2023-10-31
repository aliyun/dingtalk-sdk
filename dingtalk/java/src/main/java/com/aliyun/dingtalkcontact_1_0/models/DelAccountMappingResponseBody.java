// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DelAccountMappingResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DelAccountMappingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DelAccountMappingResponseBody self = new DelAccountMappingResponseBody();
        return TeaModel.build(map, self);
    }

    public DelAccountMappingResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
