// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class RemoveContactFromOrgResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("result")
    public Boolean result;

    public static RemoveContactFromOrgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveContactFromOrgResponseBody self = new RemoveContactFromOrgResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveContactFromOrgResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
