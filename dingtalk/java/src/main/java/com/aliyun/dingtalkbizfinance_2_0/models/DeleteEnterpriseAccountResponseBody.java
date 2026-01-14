// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class DeleteEnterpriseAccountResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeleteEnterpriseAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteEnterpriseAccountResponseBody self = new DeleteEnterpriseAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteEnterpriseAccountResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
