// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryAllSubjectsFromClassScheduleShrinkRequest extends TeaModel {
    // 班级ID。
    @NameInMap("classIds")
    public String classIdsShrink;

    // 操作者的userid。
    @NameInMap("opUserId")
    public String opUserId;

    // 学段编码：KINDERGARTEN：小学 PRIMARY_SCHOOL：小学 MODDLE_SCHOOL： 初中 HIGH_SCHOOL： 高中 UNIVERSITY：大学 NOT_SCHOOL：无学段
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
