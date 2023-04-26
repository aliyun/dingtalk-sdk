// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class DeleteProjectMemberResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<String> result;

    public static DeleteProjectMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteProjectMemberResponseBody self = new DeleteProjectMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteProjectMemberResponseBody setResult(java.util.List<String> result) {
        this.result = result;
        return this;
    }
    public java.util.List<String> getResult() {
        return this.result;
    }

}
