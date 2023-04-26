// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ValidateUserRoleResponseBody extends TeaModel {
    @NameInMap("matchParentIdentity")
    public Boolean matchParentIdentity;

    @NameInMap("matchTeacherIdentity")
    public Boolean matchTeacherIdentity;

    public static ValidateUserRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ValidateUserRoleResponseBody self = new ValidateUserRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public ValidateUserRoleResponseBody setMatchParentIdentity(Boolean matchParentIdentity) {
        this.matchParentIdentity = matchParentIdentity;
        return this;
    }
    public Boolean getMatchParentIdentity() {
        return this.matchParentIdentity;
    }

    public ValidateUserRoleResponseBody setMatchTeacherIdentity(Boolean matchTeacherIdentity) {
        this.matchTeacherIdentity = matchTeacherIdentity;
        return this;
    }
    public Boolean getMatchTeacherIdentity() {
        return this.matchTeacherIdentity;
    }

}
