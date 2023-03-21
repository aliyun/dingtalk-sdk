// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CheckUserIsGroupMemberResponseBody extends TeaModel {
    /**
     * <p>用户是否为群成员。</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static CheckUserIsGroupMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckUserIsGroupMemberResponseBody self = new CheckUserIsGroupMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckUserIsGroupMemberResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
