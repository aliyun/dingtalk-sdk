// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ValidateUserRoleResponseBody extends TeaModel {
    /**
     * <p>是否是家长身份。</p>
     * <p>true表示是家长，false表示不是家长。</p>
     */
    @NameInMap("matchParentIdentity")
    public Boolean matchParentIdentity;

    /**
     * <p>是否为老师身份。</p>
     * <p>true表示是老师，false表示不是老师。</p>
     */
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
