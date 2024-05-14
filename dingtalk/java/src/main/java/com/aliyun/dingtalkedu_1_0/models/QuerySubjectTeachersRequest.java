// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySubjectTeachersRequest extends TeaModel {
    @NameInMap("classIds")
    public java.util.List<Long> classIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subjectCode")
    public String subjectCode;

    public static QuerySubjectTeachersRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySubjectTeachersRequest self = new QuerySubjectTeachersRequest();
        return TeaModel.build(map, self);
    }

    public QuerySubjectTeachersRequest setClassIds(java.util.List<Long> classIds) {
        this.classIds = classIds;
        return this;
    }
    public java.util.List<Long> getClassIds() {
        return this.classIds;
    }

    public QuerySubjectTeachersRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public QuerySubjectTeachersRequest setSubjectCode(String subjectCode) {
        this.subjectCode = subjectCode;
        return this;
    }
    public String getSubjectCode() {
        return this.subjectCode;
    }

}
