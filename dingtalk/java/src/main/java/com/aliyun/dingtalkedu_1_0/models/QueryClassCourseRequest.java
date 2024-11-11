// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassCourseRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>class_xxx</p>
     */
    @NameInMap("classId")
    public String classId;

    /**
     * <strong>example:</strong>
     * <p>ding_xxx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>ISV_XXX</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    /**
     * <strong>example:</strong>
     * <p>course_xxx</p>
     */
    @NameInMap("isvCourseId")
    public String isvCourseId;

    public static QueryClassCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryClassCourseRequest self = new QueryClassCourseRequest();
        return TeaModel.build(map, self);
    }

    public QueryClassCourseRequest setClassId(String classId) {
        this.classId = classId;
        return this;
    }
    public String getClassId() {
        return this.classId;
    }

    public QueryClassCourseRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryClassCourseRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public QueryClassCourseRequest setIsvCourseId(String isvCourseId) {
        this.isvCourseId = isvCourseId;
        return this;
    }
    public String getIsvCourseId() {
        return this.isvCourseId;
    }

}
