// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class AddApproveDentryAuthResponseBody extends TeaModel {
    /**
     * <p>返回结果。</p>
     */
    @NameInMap("result")
    public Boolean result;

    /**
     * <p>接口调用是否成功。</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static AddApproveDentryAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddApproveDentryAuthResponseBody self = new AddApproveDentryAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public AddApproveDentryAuthResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public AddApproveDentryAuthResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
