// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class DeleteTeamResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteTeamResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteTeamResponseBody self = new DeleteTeamResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteTeamResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
