// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateTeacherCourseRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>{&quot;key&quot;:&quot;value&quot;}</p>
     */
    @NameInMap("attributes")
    public String attributes;

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

    /**
     * <strong>example:</strong>
     * <p>courseIdxxx</p>
     */
    @NameInMap("isvCourseId")
    public String isvCourseId;

    /**
     * <strong>example:</strong>
     * <p>李老师</p>
     */
    @NameInMap("teacherName")
    public String teacherName;

    /**
     * <strong>example:</strong>
     * <p>staffxxx</p>
     */
    @NameInMap("teacherUserId")
    public String teacherUserId;

    public static CreateTeacherCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTeacherCourseRequest self = new CreateTeacherCourseRequest();
        return TeaModel.build(map, self);
    }

    public CreateTeacherCourseRequest setAttributes(String attributes) {
        this.attributes = attributes;
        return this;
    }
    public String getAttributes() {
        return this.attributes;
    }

    public CreateTeacherCourseRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateTeacherCourseRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public CreateTeacherCourseRequest setIsvCourseId(String isvCourseId) {
        this.isvCourseId = isvCourseId;
        return this;
    }
    public String getIsvCourseId() {
        return this.isvCourseId;
    }

    public CreateTeacherCourseRequest setTeacherName(String teacherName) {
        this.teacherName = teacherName;
        return this;
    }
    public String getTeacherName() {
        return this.teacherName;
    }

    public CreateTeacherCourseRequest setTeacherUserId(String teacherUserId) {
        this.teacherUserId = teacherUserId;
        return this;
    }
    public String getTeacherUserId() {
        return this.teacherUserId;
    }

}
