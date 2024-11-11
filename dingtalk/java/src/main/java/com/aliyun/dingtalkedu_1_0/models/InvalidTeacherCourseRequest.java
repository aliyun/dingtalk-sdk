// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InvalidTeacherCourseRequest extends TeaModel {
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

    @NameInMap("needDeleteCourseIdList")
    public java.util.List<String> needDeleteCourseIdList;

    /**
     * <strong>example:</strong>
     * <p>staffxxx</p>
     */
    @NameInMap("teacherUserId")
    public String teacherUserId;

    public static InvalidTeacherCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        InvalidTeacherCourseRequest self = new InvalidTeacherCourseRequest();
        return TeaModel.build(map, self);
    }

    public InvalidTeacherCourseRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public InvalidTeacherCourseRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public InvalidTeacherCourseRequest setNeedDeleteCourseIdList(java.util.List<String> needDeleteCourseIdList) {
        this.needDeleteCourseIdList = needDeleteCourseIdList;
        return this;
    }
    public java.util.List<String> getNeedDeleteCourseIdList() {
        return this.needDeleteCourseIdList;
    }

    public InvalidTeacherCourseRequest setTeacherUserId(String teacherUserId) {
        this.teacherUserId = teacherUserId;
        return this;
    }
    public String getTeacherUserId() {
        return this.teacherUserId;
    }

}
