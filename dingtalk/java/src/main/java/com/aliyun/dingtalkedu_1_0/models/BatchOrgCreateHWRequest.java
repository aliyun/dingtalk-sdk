// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchOrgCreateHWRequest extends TeaModel {
    // 作业视频
    @NameInMap("hwMedia")
    public String hwMedia;

    // 作业内容
    @NameInMap("hwContent")
    public String hwContent;

    // 作业标题
    @NameInMap("hwTitle")
    public String hwTitle;

    // 作业课程名称
    @NameInMap("courseName")
    public String courseName;

    // 作业图片
    @NameInMap("hwPhoto")
    public String hwPhoto;

    // 作业音视频
    @NameInMap("hwVideo")
    public String hwVideo;

    // 老师名称
    @NameInMap("teacherName")
    public String teacherName;

    // 老师userid
    @NameInMap("teacherUserId")
    public String teacherUserId;

    // 幂等ID字段
    @NameInMap("identifier")
    public String identifier;

    // 扩展属性
    @NameInMap("attributes")
    public String attributes;

    // 发送对象
    @NameInMap("targetRole")
    public String targetRole;

    // 业务编码
    @NameInMap("bizCode")
    public String bizCode;

    // 状态
    @NameInMap("status")
    public String status;

    // 定时调度
    @NameInMap("scheduledRelease")
    public String scheduledRelease;

    // 定时调度时间
    @NameInMap("scheduledTime")
    public String scheduledTime;

    // 截止时间开启
    @NameInMap("hwDeadlineOpen")
    public String hwDeadlineOpen;

    // 截止时间
    @NameInMap("hwDeadline")
    public Long hwDeadline;

    // 作业类型
    @NameInMap("hwType")
    public String hwType;

    // 选择跨组织班级
    @NameInMap("openSelectItemList")
    public java.util.List<BatchOrgCreateHWRequestOpenSelectItemList> openSelectItemList;

    // 组织ID
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    public static BatchOrgCreateHWRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchOrgCreateHWRequest self = new BatchOrgCreateHWRequest();
        return TeaModel.build(map, self);
    }

    public BatchOrgCreateHWRequest setHwMedia(String hwMedia) {
        this.hwMedia = hwMedia;
        return this;
    }
    public String getHwMedia() {
        return this.hwMedia;
    }

    public BatchOrgCreateHWRequest setHwContent(String hwContent) {
        this.hwContent = hwContent;
        return this;
    }
    public String getHwContent() {
        return this.hwContent;
    }

    public BatchOrgCreateHWRequest setHwTitle(String hwTitle) {
        this.hwTitle = hwTitle;
        return this;
    }
    public String getHwTitle() {
        return this.hwTitle;
    }

    public BatchOrgCreateHWRequest setCourseName(String courseName) {
        this.courseName = courseName;
        return this;
    }
    public String getCourseName() {
        return this.courseName;
    }

    public BatchOrgCreateHWRequest setHwPhoto(String hwPhoto) {
        this.hwPhoto = hwPhoto;
        return this;
    }
    public String getHwPhoto() {
        return this.hwPhoto;
    }

    public BatchOrgCreateHWRequest setHwVideo(String hwVideo) {
        this.hwVideo = hwVideo;
        return this;
    }
    public String getHwVideo() {
        return this.hwVideo;
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

    public BatchOrgCreateHWRequest setIdentifier(String identifier) {
        this.identifier = identifier;
        return this;
    }
    public String getIdentifier() {
        return this.identifier;
    }

    public BatchOrgCreateHWRequest setAttributes(String attributes) {
        this.attributes = attributes;
        return this;
    }
    public String getAttributes() {
        return this.attributes;
    }

    public BatchOrgCreateHWRequest setTargetRole(String targetRole) {
        this.targetRole = targetRole;
        return this;
    }
    public String getTargetRole() {
        return this.targetRole;
    }

    public BatchOrgCreateHWRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public BatchOrgCreateHWRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
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

    public BatchOrgCreateHWRequest setHwDeadlineOpen(String hwDeadlineOpen) {
        this.hwDeadlineOpen = hwDeadlineOpen;
        return this;
    }
    public String getHwDeadlineOpen() {
        return this.hwDeadlineOpen;
    }

    public BatchOrgCreateHWRequest setHwDeadline(Long hwDeadline) {
        this.hwDeadline = hwDeadline;
        return this;
    }
    public Long getHwDeadline() {
        return this.hwDeadline;
    }

    public BatchOrgCreateHWRequest setHwType(String hwType) {
        this.hwType = hwType;
        return this;
    }
    public String getHwType() {
        return this.hwType;
    }

    public BatchOrgCreateHWRequest setOpenSelectItemList(java.util.List<BatchOrgCreateHWRequestOpenSelectItemList> openSelectItemList) {
        this.openSelectItemList = openSelectItemList;
        return this;
    }
    public java.util.List<BatchOrgCreateHWRequestOpenSelectItemList> getOpenSelectItemList() {
        return this.openSelectItemList;
    }

    public BatchOrgCreateHWRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public static class BatchOrgCreateHWRequestOpenSelectItemListClassListStudents extends TeaModel {
        // 学生姓名
        @NameInMap("name")
        public String name;

        // 学生userid
        @NameInMap("staffId")
        public String staffId;

        // 学生头像
        @NameInMap("avatar")
        public String avatar;

        public static BatchOrgCreateHWRequestOpenSelectItemListClassListStudents build(java.util.Map<String, ?> map) throws Exception {
            BatchOrgCreateHWRequestOpenSelectItemListClassListStudents self = new BatchOrgCreateHWRequestOpenSelectItemListClassListStudents();
            return TeaModel.build(map, self);
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

        public BatchOrgCreateHWRequestOpenSelectItemListClassListStudents setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

    }

    public static class BatchOrgCreateHWRequestOpenSelectItemListClassList extends TeaModel {
        // 班级id
        @NameInMap("classId")
        public String classId;

        // 班级名称
        @NameInMap("className")
        public String className;

        // 是否全选
        @NameInMap("all")
        public Boolean all;

        // 学生列表
        @NameInMap("students")
        public java.util.List<BatchOrgCreateHWRequestOpenSelectItemListClassListStudents> students;

        public static BatchOrgCreateHWRequestOpenSelectItemListClassList build(java.util.Map<String, ?> map) throws Exception {
            BatchOrgCreateHWRequestOpenSelectItemListClassList self = new BatchOrgCreateHWRequestOpenSelectItemListClassList();
            return TeaModel.build(map, self);
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

        public BatchOrgCreateHWRequestOpenSelectItemListClassList setAll(Boolean all) {
            this.all = all;
            return this;
        }
        public Boolean getAll() {
            return this.all;
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
        // 组织corpId
        @NameInMap("corpId")
        public String corpId;

        // 选择内容
        @NameInMap("selectedClassesDesc")
        public String selectedClassesDesc;

        // 班级列表
        @NameInMap("classList")
        public java.util.List<BatchOrgCreateHWRequestOpenSelectItemListClassList> classList;

        public static BatchOrgCreateHWRequestOpenSelectItemList build(java.util.Map<String, ?> map) throws Exception {
            BatchOrgCreateHWRequestOpenSelectItemList self = new BatchOrgCreateHWRequestOpenSelectItemList();
            return TeaModel.build(map, self);
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

        public BatchOrgCreateHWRequestOpenSelectItemList setClassList(java.util.List<BatchOrgCreateHWRequestOpenSelectItemListClassList> classList) {
            this.classList = classList;
            return this;
        }
        public java.util.List<BatchOrgCreateHWRequestOpenSelectItemListClassList> getClassList() {
            return this.classList;
        }

    }

}
