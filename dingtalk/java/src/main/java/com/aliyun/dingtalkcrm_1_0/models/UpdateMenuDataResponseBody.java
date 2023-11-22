// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateMenuDataResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static UpdateMenuDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateMenuDataResponseBody self = new UpdateMenuDataResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateMenuDataResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
