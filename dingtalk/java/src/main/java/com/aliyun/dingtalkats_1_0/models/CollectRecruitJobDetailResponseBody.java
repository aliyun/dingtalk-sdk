// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectRecruitJobDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static CollectRecruitJobDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollectRecruitJobDetailResponseBody self = new CollectRecruitJobDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public CollectRecruitJobDetailResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
