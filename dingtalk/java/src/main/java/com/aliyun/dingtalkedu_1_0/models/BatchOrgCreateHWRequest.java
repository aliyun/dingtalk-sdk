// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchOrgCreateHWRequest extends TeaModel {
    /**
     * <p>扩展属性</p>
     */
    @NameInMap("attributes")
    public String attributes;

    /**
     * <p>业务编码</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>作业课程名称</p>
     */
    @NameInMap("courseName")
    public String courseName;

    /**
     * <p>作业内容</p>
     */
    @NameInMap("hwContent")
    public String hwContent;

    /**
     * <p>截止时间</p>
     */
    @NameInMap("hwDeadline")
    public Long hwDeadline;

    /**
     * <p>截止时间开启</p>
     */
    @NameInMap("hwDeadlineOpen")
    public String hwDeadlineOpen;

    /**
     * <p>作业视频</p>
     */
    @NameInMap("hwMedia")
    public String hwMedia;

    /**
     * <p>作业图片</p>
     */
    @NameInMap("hwPhoto")
    public String hwPhoto;

    /**
     * <p>作业标题</p>
     */
    @NameInMap("hwTitle")
    public String hwTitle;

    /**
     * <p>作业类型</p>
     */
    @NameInMap("hwType")
    public String hwType;

    /**
     * <p>作业音视频</p>
     */
    @NameInMap("hwVideo")
    public String hwVideo;

    /**
     * <p>幂等ID字段</p>
     */
    @NameInMap("identifier")
    public String identifier;

    /**
     * <p>选择跨组织班级</p>
     */
    @NameInMap("openSelectItemList")
    public java.util.List<BatchOrgCreateHWRequestOpenSelectItemList> openSelectItemList;

    /**
     * <p>定时调度</p>
     */
    @NameInMap("scheduledRelease")
    public String scheduledRelease;

    /**
     * <p>定时调度时间</p>
     */
    @NameInMap("scheduledTime")
    public String scheduledTime;

    /**
     * <p>状态</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>发送对象</p>
     */
    @NameInMap("targetRole")
    public String targetRole;

    /**
     * <p>老师名称</p>
     */
    @NameInMap("teacherName")
    public String teacherName;

    /**
     * <p>老师userid</p>
     */
    @NameInMap("teacherUserId")
    public String teacherUserId;

    public static BatchOrgCreateHWRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchOrgCreateHWRequest self = new BatchOrgCreateHWRequest();
        return TeaModel.build(map, self);
    }

    public BatchOrgCreateHWRequest setAttributes(String attributes) {
        this.attributes = attributes;
        return this;
    }
    public String getAttributes() {
        return this.attributes;
    }

    public BatchOrgCreateHWRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public BatchOrgCreateHWRequest setCourseName(String courseName) {
        this.courseName = courseName;
        return this;
    }
    public String getCourseName() {
        return this.courseName;
    }

    public BatchOrgCreateHWRequest setHwContent(String hwContent) {
        this.hwContent = hwContent;
        return this;
    }
    public String getHwContent() {
        return this.hwContent;
    }

    public BatchOrgCreateHWRequest setHwDeadline(Long hwDeadline) {
        this.hwDeadline = hwDeadline;
        return this;
    }
    public Long getHwDeadline() {
        return this.hwDeadline;
    }

    public BatchOrgCreateHWRequest setHwDeadlineOpen(String hwDeadlineOpen) {
        this.hwDeadlineOpen = hwDeadlineOpen;
        return this;
    }
    public String getHwDeadlineOpen() {
        return this.hwDeadlineOpen;
    }

    public BatchOrgCreateHWRequest setHwMedia(String hwMedia) {
        this.hwMedia = hwMedia;
        return this;
    }
    public String getHwMedia() {
        return this.hwMedia;
    }

    public BatchOrgCreateHWRequest setHwPhoto(String hwPhoto) {
        this.hwPhoto = hwPhoto;
        return this;
    }
    public String getHwPhoto() {
        return this.hwPhoto;
    }

    public BatchOrgCreateHWRequest setHwTitle(String hwTitle) {
        this.hwTitle = hwTitle;
        return this;
    }
    public String getHwTitle() {
        return this.hwTitle;
    }

    public BatchOrgCreateHWRequest setHwType(String hwType) {
        this.hwType = hwType;
        return this;
    }
    public String getHwType() {
        return this.hwType;
    }

    public BatchOrgCreateHWRequest setHwVideo(String hwVideo) {
        this.hwVideo = hwVideo;
        return this;
    }
    public String getHwVideo() {
        return this.hwVideo;
    }

    public BatchOrgCreateHWRequest setIdentifier(String identifier) {
        this.identifier = identifier;
        return this;
    }
    public String getIdentifier() {
        return this.identifier;
    }

    public BatchOrgCreateHWRequest setOpenSelectItemList(java.util.List<BatchOrgCreateHWRequestOpenSelectItemList> openSelectItemList) {
        this.openSelectItemList = openSelectItemList;
        return this;
    }
    public java.util.List<BatchOrgCreateHWRequestOpenSelectItemList> getOpenSelectItemList() {
        return this.openSelectItemList;
    }

    public BatchOrgCreateHWRequest setScheduledRelease(String scheduledRelease) {
        this.scheduledRelease = scheduledRelease;
        return this;
    }
    public String getScheduledRelease() {
        return this.scheduledRelease;
    }

    public BatchOrgCreateHWRequest setScheduledTime(String scheduledTime) {
        this.scheduledTime = scheduledTime;
        return this;
    }
    public String getScheduledTime() {
        return this.scheduledTime;
    }

    public BatchOrgCreateHWRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public BatchOrgCreateHWRequest setTargetRole(String targetRole) {
        this.targetRole = targetRole;
        return this;
    }
    public String getTargetRole() {
        return this.targetRole;
    }

    public BatchOrgCreateHWRequest setTeacherName(String teacherName) {
        this.teacherName = teacherName;
        return this;
    }
    public String getTeacherName() {
        return this.teacherName;
    }

    public BatchOrgCreateHWRequest setTeacherUserId(String teacherUserId) {
        this.teacherUserId = teacherUserId;
        return this;
    }
    public String getTeacherUserId() {
        return this.teacherUserId;
    }

    public static class BatchOrgCreateHWRequestOpenSelectItemListClassListStudents extends TeaModel {
        /**
         * <p>学生头像</p>
         */
        @NameInMap("avatar")
        public String avatar;

        /**
         * <p>学生姓名</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>学生userid</p>
         */
        @NameInMap("staffId")
        public String staffId;

        public static BatchOrgCreateHWRequestOpenSelectItemListClassListStudents build(java.util.Map<String, ?> map) throws Exception {
            BatchOrgCreateHWRequestOpenSelectItemListClassListStudents self = new BatchOrgCreateHWRequestOpenSelectItemListClassListStudents();
            return TeaModel.build(map, self);
        }

        public BatchOrgCreateHWRequestOpenSelectItemListClassListStudents setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

        public BatchOrgCreateHWRequestOpenSelectItemListClassListStudents setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchOrgCreateHWRequestOpenSelectItemListClassListStudents setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

    }

    public static class BatchOrgCreateHWRequestOpenSelectItemListClassList extends TeaModel {
        /**
         * <p>是否全选</p>
         */
        @NameInMap("all")
        public Boolean all;

        /**
         * <p>班级id</p>
         */
        @NameInMap("classId")
        public String classId;

        /**
         * <p>班级名称</p>
         */
        @NameInMap("className")
        public String className;

        /**
         * <p>学生列表</p>
         */
        @NameInMap("students")
        public java.util.List<BatchOrgCreateHWRequestOpenSelectItemListClassListStudents> students;

        public static BatchOrgCreateHWRequestOpenSelectItemListClassList build(java.util.Map<String, ?> map) throws Exception {
            BatchOrgCreateHWRequestOpenSelectItemListClassList self = new BatchOrgCreateHWRequestOpenSelectItemListClassList();
            return TeaModel.build(map, self);
        }

        public BatchOrgCreateHWRequestOpenSelectItemListClassList setAll(Boolean all) {
            this.all = all;
            return this;
        }
        public Boolean getAll() {
            return this.all;
        }

        public BatchOrgCreateHWRequestOpenSelectItemListClassList setClassId(String classId) {
            this.classId = classId;
            return this;
        }
        public String getClassId() {
            return this.classId;
        }

        public BatchOrgCreateHWRequestOpenSelectItemListClassList setClassName(String className) {
            this.className = className;
            return this;
        }
        public String getClassName() {
            return this.className;
        }

        public BatchOrgCreateHWRequestOpenSelectItemListClassList setStudents(java.util.List<BatchOrgCreateHWRequestOpenSelectItemListClassListStudents> students) {
            this.students = students;
            return this;
        }
        public java.util.List<BatchOrgCreateHWRequestOpenSelectItemListClassListStudents> getStudents() {
            return this.students;
        }

    }

    public static class BatchOrgCreateHWRequestOpenSelectItemList extends TeaModel {
        /**
         * <p>班级列表</p>
         */
        @NameInMap("classList")
        public java.util.List<BatchOrgCreateHWRequestOpenSelectItemListClassList> classList;

        /**
         * <p>组织corpId</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>选择内容</p>
         */
        @NameInMap("selectedClassesDesc")
        public String selectedClassesDesc;

        public static BatchOrgCreateHWRequestOpenSelectItemList build(java.util.Map<String, ?> map) throws Exception {
            BatchOrgCreateHWRequestOpenSelectItemList self = new BatchOrgCreateHWRequestOpenSelectItemList();
            return TeaModel.build(map, self);
        }

        public BatchOrgCreateHWRequestOpenSelectItemList setClassList(java.util.List<BatchOrgCreateHWRequestOpenSelectItemListClassList> classList) {
            this.classList = classList;
            return this;
        }
        public java.util.List<BatchOrgCreateHWRequestOpenSelectItemListClassList> getClassList() {
            return this.classList;
        }

        public BatchOrgCreateHWRequestOpenSelectItemList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public BatchOrgCreateHWRequestOpenSelectItemList setSelectedClassesDesc(String selectedClassesDesc) {
            this.selectedClassesDesc = selectedClassesDesc;
            return this;
        }
        public String getSelectedClassesDesc() {
            return this.selectedClassesDesc;
        }

    }

}
