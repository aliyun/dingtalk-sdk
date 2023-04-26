// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchBindingGroupBizIdsResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static BatchBindingGroupBizIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchBindingGroupBizIdsResponseBody self = new BatchBindingGroupBizIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchBindingGroupBizIdsResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
