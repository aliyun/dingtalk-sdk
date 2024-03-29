// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryAllSubjectsFromClassScheduleShrinkRequest extends TeaModel {
    @NameInMap("classIds")
    public String classIdsShrink;

    @NameInMap("opUserId")
    public String opUserId;

    @NameInMap("periodCode")
    public String periodCode;

    public static QueryAllSubjectsFromClassScheduleShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAllSubjectsFromClassScheduleShrinkRequest self = new QueryAllSubjectsFromClassScheduleShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QueryAllSubjectsFromClassScheduleShrinkRequest setClassIdsShrink(String classIdsShrink) {
        this.classIdsShrink = classIdsShrink;
        return this;
    }
    public String getClassIdsShrink() {
        return this.classIdsShrink;
    }

    public QueryAllSubjectsFromClassScheduleShrinkRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public QueryAllSubjectsFromClassScheduleShrinkRequest setPeriodCode(String periodCode) {
        this.periodCode = periodCode;
        return this;
    }
    public String getPeriodCode() {
        return this.periodCode;
    }

}
