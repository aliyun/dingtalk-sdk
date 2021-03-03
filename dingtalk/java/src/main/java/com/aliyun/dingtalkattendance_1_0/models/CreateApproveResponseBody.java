// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CreateApproveResponseBody extends TeaModel {
    // 返回结果
    @NameInMap("dingtalkApproveId")
    public String dingtalkApproveId;

    public static CreateApproveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateApproveResponseBody self = new CreateApproveResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateApproveResponseBody setDingtalkApproveId(String dingtalkApproveId) {
        this.dingtalkApproveId = dingtalkApproveId;
        return this;
    }
    public String getDingtalkApproveId() {
        return this.dingtalkApproveId;
    }

}
