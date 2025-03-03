// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PublishSchoolReportRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("classDetailItems")
    public java.util.List<PublishSchoolReportRequestClassDetailItems> classDetailItems;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("examClass")
    public String examClass;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("examTitle")
    public String examTitle;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("identifier")
    public String identifier;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("publishScope")
    public String publishScope;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("scoreType")
    public String scoreType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("share")
    public Boolean share;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("showRank")
    public Boolean showRank;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("showStatisticsScore")
    public Boolean showStatisticsScore;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subScoreType")
    public String subScoreType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subjectList")
    public java.util.List<PublishSchoolReportRequestSubjectList> subjectList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subjects")
    public String subjects;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("teacherId")
    public String teacherId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("teacherName")
    public String teacherName;

    public static PublishSchoolReportRequest build(java.util.Map<String, ?> map) throws Exception {
        PublishSchoolReportRequest self = new PublishSchoolReportRequest();
        return TeaModel.build(map, self);
    }

    public PublishSchoolReportRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public PublishSchoolReportRequest setClassDetailItems(java.util.List<PublishSchoolReportRequestClassDetailItems> classDetailItems) {
        this.classDetailItems = classDetailItems;
        return this;
    }
    public java.util.List<PublishSchoolReportRequestClassDetailItems> getClassDetailItems() {
        return this.classDetailItems;
    }

    public PublishSchoolReportRequest setExamClass(String examClass) {
        this.examClass = examClass;
        return this;
    }
    public String getExamClass() {
        return this.examClass;
    }

    public PublishSchoolReportRequest setExamTitle(String examTitle) {
        this.examTitle = examTitle;
        return this;
    }
    public String getExamTitle() {
        return this.examTitle;
    }

    public PublishSchoolReportRequest setIdentifier(String identifier) {
        this.identifier = identifier;
        return this;
    }
    public String getIdentifier() {
        return this.identifier;
    }

    public PublishSchoolReportRequest setPublishScope(String publishScope) {
        this.publishScope = publishScope;
        return this;
    }
    public String getPublishScope() {
        return this.publishScope;
    }

    public PublishSchoolReportRequest setScoreType(String scoreType) {
        this.scoreType = scoreType;
        return this;
    }
    public String getScoreType() {
        return this.scoreType;
    }

    public PublishSchoolReportRequest setShare(Boolean share) {
        this.share = share;
        return this;
    }
    public Boolean getShare() {
        return this.share;
    }

    public PublishSchoolReportRequest setShowRank(Boolean showRank) {
        this.showRank = showRank;
        return this;
    }
    public Boolean getShowRank() {
        return this.showRank;
    }

    public PublishSchoolReportRequest setShowStatisticsScore(Boolean showStatisticsScore) {
        this.showStatisticsScore = showStatisticsScore;
        return this;
    }
    public Boolean getShowStatisticsScore() {
        return this.showStatisticsScore;
    }

    public PublishSchoolReportRequest setSubScoreType(String subScoreType) {
        this.subScoreType = subScoreType;
        return this;
    }
    public String getSubScoreType() {
        return this.subScoreType;
    }

    public PublishSchoolReportRequest setSubjectList(java.util.List<PublishSchoolReportRequestSubjectList> subjectList) {
        this.subjectList = subjectList;
        return this;
    }
    public java.util.List<PublishSchoolReportRequestSubjectList> getSubjectList() {
        return this.subjectList;
    }

    public PublishSchoolReportRequest setSubjects(String subjects) {
        this.subjects = subjects;
        return this;
    }
    public String getSubjects() {
        return this.subjects;
    }

    public PublishSchoolReportRequest setTeacherId(String teacherId) {
        this.teacherId = teacherId;
        return this;
    }
    public String getTeacherId() {
        return this.teacherId;
    }

    public PublishSchoolReportRequest setTeacherName(String teacherName) {
        this.teacherName = teacherName;
        return this;
    }
    public String getTeacherName() {
        return this.teacherName;
    }

    public static class PublishSchoolReportRequestClassDetailItemsStudentDetailListSubjectList extends TeaModel {
        @NameInMap("gradeRank")
        public Long gradeRank;

        @NameInMap("levelScore")
        public String levelScore;

        @NameInMap("name")
        public String name;

        @NameInMap("score")
        public Double score;

        public static PublishSchoolReportRequestClassDetailItemsStudentDetailListSubjectList build(java.util.Map<String, ?> map) throws Exception {
            PublishSchoolReportRequestClassDetailItemsStudentDetailListSubjectList self = new PublishSchoolReportRequestClassDetailItemsStudentDetailListSubjectList();
            return TeaModel.build(map, self);
        }

        public PublishSchoolReportRequestClassDetailItemsStudentDetailListSubjectList setGradeRank(Long gradeRank) {
            this.gradeRank = gradeRank;
            return this;
        }
        public Long getGradeRank() {
            return this.gradeRank;
        }

        public PublishSchoolReportRequestClassDetailItemsStudentDetailListSubjectList setLevelScore(String levelScore) {
            this.levelScore = levelScore;
            return this;
        }
        public String getLevelScore() {
            return this.levelScore;
        }

        public PublishSchoolReportRequestClassDetailItemsStudentDetailListSubjectList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PublishSchoolReportRequestClassDetailItemsStudentDetailListSubjectList setScore(Double score) {
            this.score = score;
            return this;
        }
        public Double getScore() {
            return this.score;
        }

    }

    public static class PublishSchoolReportRequestClassDetailItemsStudentDetailList extends TeaModel {
        @NameInMap("studentId")
        public String studentId;

        @NameInMap("studentName")
        public String studentName;

        @NameInMap("subjectList")
        public java.util.List<PublishSchoolReportRequestClassDetailItemsStudentDetailListSubjectList> subjectList;

        public static PublishSchoolReportRequestClassDetailItemsStudentDetailList build(java.util.Map<String, ?> map) throws Exception {
            PublishSchoolReportRequestClassDetailItemsStudentDetailList self = new PublishSchoolReportRequestClassDetailItemsStudentDetailList();
            return TeaModel.build(map, self);
        }

        public PublishSchoolReportRequestClassDetailItemsStudentDetailList setStudentId(String studentId) {
            this.studentId = studentId;
            return this;
        }
        public String getStudentId() {
            return this.studentId;
        }

        public PublishSchoolReportRequestClassDetailItemsStudentDetailList setStudentName(String studentName) {
            this.studentName = studentName;
            return this;
        }
        public String getStudentName() {
            return this.studentName;
        }

        public PublishSchoolReportRequestClassDetailItemsStudentDetailList setSubjectList(java.util.List<PublishSchoolReportRequestClassDetailItemsStudentDetailListSubjectList> subjectList) {
            this.subjectList = subjectList;
            return this;
        }
        public java.util.List<PublishSchoolReportRequestClassDetailItemsStudentDetailListSubjectList> getSubjectList() {
            return this.subjectList;
        }

    }

    public static class PublishSchoolReportRequestClassDetailItems extends TeaModel {
        @NameInMap("classId")
        public String classId;

        @NameInMap("className")
        public String className;

        @NameInMap("studentDetailList")
        public java.util.List<PublishSchoolReportRequestClassDetailItemsStudentDetailList> studentDetailList;

        public static PublishSchoolReportRequestClassDetailItems build(java.util.Map<String, ?> map) throws Exception {
            PublishSchoolReportRequestClassDetailItems self = new PublishSchoolReportRequestClassDetailItems();
            return TeaModel.build(map, self);
        }

        public PublishSchoolReportRequestClassDetailItems setClassId(String classId) {
            this.classId = classId;
            return this;
        }
        public String getClassId() {
            return this.classId;
        }

        public PublishSchoolReportRequestClassDetailItems setClassName(String className) {
            this.className = className;
            return this;
        }
        public String getClassName() {
            return this.className;
        }

        public PublishSchoolReportRequestClassDetailItems setStudentDetailList(java.util.List<PublishSchoolReportRequestClassDetailItemsStudentDetailList> studentDetailList) {
            this.studentDetailList = studentDetailList;
            return this;
        }
        public java.util.List<PublishSchoolReportRequestClassDetailItemsStudentDetailList> getStudentDetailList() {
            return this.studentDetailList;
        }

    }

    public static class PublishSchoolReportRequestSubjectList extends TeaModel {
        @NameInMap("name")
        public String name;

        public static PublishSchoolReportRequestSubjectList build(java.util.Map<String, ?> map) throws Exception {
            PublishSchoolReportRequestSubjectList self = new PublishSchoolReportRequestSubjectList();
            return TeaModel.build(map, self);
        }

        public PublishSchoolReportRequestSubjectList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
