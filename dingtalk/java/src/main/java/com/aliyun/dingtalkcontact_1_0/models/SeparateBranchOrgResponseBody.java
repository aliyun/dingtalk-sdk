// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SeparateBranchOrgResponseBody extends TeaModel {
    // 处理结果
    @NameInMap("result")
    public Boolean result;

    public static SeparateBranchOrgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SeparateBranchOrgResponseBody self = new SeparateBranchOrgResponseBody();
        return TeaModel.build(map, self);
    }

    public SeparateBranchOrgResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
