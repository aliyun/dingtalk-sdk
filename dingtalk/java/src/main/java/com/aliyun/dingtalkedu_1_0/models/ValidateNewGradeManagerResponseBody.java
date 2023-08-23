// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ValidateNewGradeManagerResponseBody extends TeaModel {
    @NameInMap("matchRule")
    public Boolean matchRule;

    public static ValidateNewGradeManagerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ValidateNewGradeManagerResponseBody self = new ValidateNewGradeManagerResponseBody();
        return TeaModel.build(map, self);
    }

    public ValidateNewGradeManagerResponseBody setMatchRule(Boolean matchRule) {
        this.matchRule = matchRule;
        return this;
    }
    public Boolean getMatchRule() {
        return this.matchRule;
    }

}
