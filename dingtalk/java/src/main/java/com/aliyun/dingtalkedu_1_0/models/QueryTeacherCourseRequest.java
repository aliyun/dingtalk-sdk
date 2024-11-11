// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryTeacherCourseRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dingxxx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>ISV_XXX</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    @NameInMap("isvCourseIdList")
    public java.util.List<String> isvCourseIdList;

    /**
     * <strong>example:</strong>
     * <p>staffxxx</p>
     */
    @NameInMap("teacherUserId")
    public String teacherUserId;

    public static QueryTeacherCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTeacherCourseRequest self = new QueryTeacherCourseRequest();
        return TeaModel.build(map, self);
    }

    public QueryTeacherCourseRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryTeacherCourseRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public QueryTeacherCourseRequest setIsvCourseIdList(java.util.List<String> isvCourseIdList) {
        this.isvCourseIdList = isvCourseIdList;
        return this;
    }
    public java.util.List<String> getIsvCourseIdList() {
        return this.isvCourseIdList;
    }

    public QueryTeacherCourseRequest setTeacherUserId(String teacherUserId) {
        this.teacherUserId = teacherUserId;
        return this;
    }
    public String getTeacherUserId() {
        return this.teacherUserId;
    }

}
