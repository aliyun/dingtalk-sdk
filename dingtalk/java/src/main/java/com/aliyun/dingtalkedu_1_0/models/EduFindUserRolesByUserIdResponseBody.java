// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduFindUserRolesByUserIdResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<String> result;

    public static EduFindUserRolesByUserIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EduFindUserRolesByUserIdResponseBody self = new EduFindUserRolesByUserIdResponseBody();
        return TeaModel.build(map, self);
    }

    public EduFindUserRolesByUserIdResponseBody setResult(java.util.List<String> result) {
        this.result = result;
        return this;
    }
    public java.util.List<String> getResult() {
        return this.result;
    }

}
