// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetCrmProcCodesResponseBody extends TeaModel {
    /**
     * <p>模板code列表。</p>
     */
    @NameInMap("result")
    public java.util.List<String> result;

    public static GetCrmProcCodesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCrmProcCodesResponseBody self = new GetCrmProcCodesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCrmProcCodesResponseBody setResult(java.util.List<String> result) {
        this.result = result;
        return this;
    }
    public java.util.List<String> getResult() {
        return this.result;
    }

}
