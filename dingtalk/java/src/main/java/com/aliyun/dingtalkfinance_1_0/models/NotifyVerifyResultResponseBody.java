// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyVerifyResultResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SUCCESS</p>
     */
    @NameInMap("result")
    public String result;

    public static NotifyVerifyResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        NotifyVerifyResultResponseBody self = new NotifyVerifyResultResponseBody();
        return TeaModel.build(map, self);
    }

    public NotifyVerifyResultResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
