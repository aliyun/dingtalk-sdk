// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateTeacherCourseRequest extends TeaModel {
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

    @NameInMap("teacherCourseDetailItemList")
    public java.util.List<BatchCreateTeacherCourseRequestTeacherCourseDetailItemList> teacherCourseDetailItemList;

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

    public static BatchCreateTeacherCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateTeacherCourseRequest self = new BatchCreateTeacherCourseRequest();
        return TeaModel.build(map, self);
    }

    public BatchCreateTeacherCourseRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BatchCreateTeacherCourseRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public BatchCreateTeacherCourseRequest setTeacherCourseDetailItemList(java.util.List<BatchCreateTeacherCourseRequestTeacherCourseDetailItemList> teacherCourseDetailItemList) {
        this.teacherCourseDetailItemList = teacherCourseDetailItemList;
        return this;
    }
    public java.util.List<BatchCreateTeacherCourseRequestTeacherCourseDetailItemList> getTeacherCourseDetailItemList() {
        return this.teacherCourseDetailItemList;
    }

    public BatchCreateTeacherCourseRequest setTeacherName(String teacherName) {
        this.teacherName = teacherName;
        return this;
    }
    public String getTeacherName() {
        return this.teacherName;
    }

    public BatchCreateTeacherCourseRequest setTeacherUserId(String teacherUserId) {
        this.teacherUserId = teacherUserId;
        return this;
    }
    public String getTeacherUserId() {
        return this.teacherUserId;
    }

    public static class BatchCreateTeacherCourseRequestTeacherCourseDetailItemList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>{&quot;key&quot;:&quot;value&quot;}</p>
         */
        @NameInMap("attributes")
        public String attributes;

        /**
         * <strong>example:</strong>
         * <p>courseIdxxx</p>
         */
        @NameInMap("isvCourseId")
        public String isvCourseId;

        public static BatchCreateTeacherCourseRequestTeacherCourseDetailItemList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateTeacherCourseRequestTeacherCourseDetailItemList self = new BatchCreateTeacherCourseRequestTeacherCourseDetailItemList();
            return TeaModel.build(map, self);
        }

        public BatchCreateTeacherCourseRequestTeacherCourseDetailItemList setAttributes(String attributes) {
            this.attributes = attributes;
            return this;
        }
        public String getAttributes() {
            return this.attributes;
        }

        public BatchCreateTeacherCourseRequestTeacherCourseDetailItemList setIsvCourseId(String isvCourseId) {
            this.isvCourseId = isvCourseId;
            return this;
        }
        public String getIsvCourseId() {
            return this.isvCourseId;
        }

    }

}
