// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateRequest extends TeaModel {
    // 卡片业务类型，打卡写死：industry_center
    @NameInMap("cardBizCode")
    public String cardBizCode;

    // 卡片详细数据
    @NameInMap("data")
    public BatchCreateRequestData data;

    // 卡片幂等唯一键
    @NameInMap("identifier")
    public String identifier;

    // isv业务类型
    @NameInMap("sourceType")
    public String sourceType;

    // 老师用户id
    @NameInMap("userid")
    public String userid;

    // 老师corpId
    @NameInMap("dingCorpId")
    public String dingCorpId;

    // 小程序版本号
    @NameInMap("jsVersion")
    public Long jsVersion;

    public static BatchCreateRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateRequest self = new BatchCreateRequest();
        return TeaModel.build(map, self);
    }

    public BatchCreateRequest setCardBizCode(String cardBizCode) {
        this.cardBizCode = cardBizCode;
        return this;
    }
    public String getCardBizCode() {
        return this.cardBizCode;
    }

    public BatchCreateRequest setData(BatchCreateRequestData data) {
        this.data = data;
        return this;
    }
    public BatchCreateRequestData getData() {
        return this.data;
    }

    public BatchCreateRequest setIdentifier(String identifier) {
        this.identifier = identifier;
        return this;
    }
    public String getIdentifier() {
        return this.identifier;
    }

    public BatchCreateRequest setSourceType(String sourceType) {
        this.sourceType = sourceType;
        return this;
    }
    public String getSourceType() {
        return this.sourceType;
    }

    public BatchCreateRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

    public BatchCreateRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public BatchCreateRequest setJsVersion(Long jsVersion) {
        this.jsVersion = jsVersion;
        return this;
    }
    public Long getJsVersion() {
        return this.jsVersion;
    }

    public static class BatchCreateRequestDataCardRuleItemParamList extends TeaModel {
        // 卡片taskCode
        @NameInMap("cardTaskCode")
        public String cardTaskCode;

        // 关联的外部Id
        @NameInMap("relationId")
        public String relationId;

        // 扩展属性，存放配音难度、每日配音视频的url等
        @NameInMap("cardRuleAttr")
        public String cardRuleAttr;

        // 每日配音数
        @NameInMap("dailyDubbing")
        public Long dailyDubbing;

        // 关联内容标题（会在打卡详页页展示）
        @NameInMap("relationTitle")
        public String relationTitle;

        // relationUrl（点击打卡内容后跳转的链接）（点击卡片内容后跳转的链接）
        @NameInMap("relationUrl")
        public String relationUrl;

        public static BatchCreateRequestDataCardRuleItemParamList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateRequestDataCardRuleItemParamList self = new BatchCreateRequestDataCardRuleItemParamList();
            return TeaModel.build(map, self);
        }

        public BatchCreateRequestDataCardRuleItemParamList setCardTaskCode(String cardTaskCode) {
            this.cardTaskCode = cardTaskCode;
            return this;
        }
        public String getCardTaskCode() {
            return this.cardTaskCode;
        }

        public BatchCreateRequestDataCardRuleItemParamList setRelationId(String relationId) {
            this.relationId = relationId;
            return this;
        }
        public String getRelationId() {
            return this.relationId;
        }

        public BatchCreateRequestDataCardRuleItemParamList setCardRuleAttr(String cardRuleAttr) {
            this.cardRuleAttr = cardRuleAttr;
            return this;
        }
        public String getCardRuleAttr() {
            return this.cardRuleAttr;
        }

        public BatchCreateRequestDataCardRuleItemParamList setDailyDubbing(Long dailyDubbing) {
            this.dailyDubbing = dailyDubbing;
            return this;
        }
        public Long getDailyDubbing() {
            return this.dailyDubbing;
        }

        public BatchCreateRequestDataCardRuleItemParamList setRelationTitle(String relationTitle) {
            this.relationTitle = relationTitle;
            return this;
        }
        public String getRelationTitle() {
            return this.relationTitle;
        }

        public BatchCreateRequestDataCardRuleItemParamList setRelationUrl(String relationUrl) {
            this.relationUrl = relationUrl;
            return this;
        }
        public String getRelationUrl() {
            return this.relationUrl;
        }

    }

    public static class BatchCreateRequestDataOrgClassStudentGroupListClassListStudents extends TeaModel {
        // 学生名称
        @NameInMap("stuName")
        public String stuName;

        // 学生id
        @NameInMap("stuId")
        public String stuId;

        public static BatchCreateRequestDataOrgClassStudentGroupListClassListStudents build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateRequestDataOrgClassStudentGroupListClassListStudents self = new BatchCreateRequestDataOrgClassStudentGroupListClassListStudents();
            return TeaModel.build(map, self);
        }

        public BatchCreateRequestDataOrgClassStudentGroupListClassListStudents setStuName(String stuName) {
            this.stuName = stuName;
            return this;
        }
        public String getStuName() {
            return this.stuName;
        }

        public BatchCreateRequestDataOrgClassStudentGroupListClassListStudents setStuId(String stuId) {
            this.stuId = stuId;
            return this;
        }
        public String getStuId() {
            return this.stuId;
        }

    }

    public static class BatchCreateRequestDataOrgClassStudentGroupListClassList extends TeaModel {
        // 班级id
        @NameInMap("classId")
        public Float classId;

        // 班级名称
        @NameInMap("className")
        public String className;

        // 班级学生
        @NameInMap("students")
        public java.util.List<BatchCreateRequestDataOrgClassStudentGroupListClassListStudents> students;

        public static BatchCreateRequestDataOrgClassStudentGroupListClassList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateRequestDataOrgClassStudentGroupListClassList self = new BatchCreateRequestDataOrgClassStudentGroupListClassList();
            return TeaModel.build(map, self);
        }

        public BatchCreateRequestDataOrgClassStudentGroupListClassList setClassId(Float classId) {
            this.classId = classId;
            return this;
        }
        public Float getClassId() {
            return this.classId;
        }

        public BatchCreateRequestDataOrgClassStudentGroupListClassList setClassName(String className) {
            this.className = className;
            return this;
        }
        public String getClassName() {
            return this.className;
        }

        public BatchCreateRequestDataOrgClassStudentGroupListClassList setStudents(java.util.List<BatchCreateRequestDataOrgClassStudentGroupListClassListStudents> students) {
            this.students = students;
            return this;
        }
        public java.util.List<BatchCreateRequestDataOrgClassStudentGroupListClassListStudents> getStudents() {
            return this.students;
        }

    }

    public static class BatchCreateRequestDataOrgClassStudentGroupList extends TeaModel {
        // 组织id
        @NameInMap("corpId")
        public String corpId;

        // 班级列表
        @NameInMap("classList")
        public java.util.List<BatchCreateRequestDataOrgClassStudentGroupListClassList> classList;

        public static BatchCreateRequestDataOrgClassStudentGroupList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateRequestDataOrgClassStudentGroupList self = new BatchCreateRequestDataOrgClassStudentGroupList();
            return TeaModel.build(map, self);
        }

        public BatchCreateRequestDataOrgClassStudentGroupList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public BatchCreateRequestDataOrgClassStudentGroupList setClassList(java.util.List<BatchCreateRequestDataOrgClassStudentGroupListClassList> classList) {
            this.classList = classList;
            return this;
        }
        public java.util.List<BatchCreateRequestDataOrgClassStudentGroupListClassList> getClassList() {
            return this.classList;
        }

    }

    public static class BatchCreateRequestData extends TeaModel {
        // 是否可以补卡
        @NameInMap("canReissueCard")
        public Boolean canReissueCard;

        // 打卡周期,单位为天
        @NameInMap("cardCycle")
        public Long cardCycle;

        // 打卡的频次设置："cardFrequency":[             1,//周天             2,//周一             3,//周二             4,//周三             5,//周四             6,//周五             7//周六         ]
        @NameInMap("cardFrequency")
        public java.util.List<Long> cardFrequency;

        @NameInMap("cardRuleItemParamList")
        public java.util.List<BatchCreateRequestDataCardRuleItemParamList> cardRuleItemParamList;

        // 班级列表
        @NameInMap("classIds")
        public java.util.List<String> classIds;

        // 班级名称列表
        @NameInMap("classNames")
        public java.util.List<String> classNames;

        // 打卡的内容
        @NameInMap("content")
        public String content;

        // 卡片生效时间
        @NameInMap("effectDate")
        public Float effectDate;

        // 上传相册，图片，录音，盯盘的信息
        @NameInMap("medias")
        public String medias;

        // 计量开启
        @NameInMap("needMetering")
        public Boolean needMetering;

        @NameInMap("orgClassStudentGroupList")
        public java.util.List<BatchCreateRequestDataOrgClassStudentGroupList> orgClassStudentGroupList;

        // 提醒时间（小时）
        @NameInMap("remindHour")
        public Long remindHour;

        // 提醒时间（分钟）
        @NameInMap("remindMinute")
        public Long remindMinute;

        // 默认：student_guardian
        @NameInMap("targetRole")
        public String targetRole;

        // 打卡模板id
        @NameInMap("templateId")
        public Float templateId;

        // 卡片标题
        @NameInMap("title")
        public String title;

        // 计量单位
        @NameInMap("unitOfMeasurement")
        public String unitOfMeasurement;

        public static BatchCreateRequestData build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateRequestData self = new BatchCreateRequestData();
            return TeaModel.build(map, self);
        }

        public BatchCreateRequestData setCanReissueCard(Boolean canReissueCard) {
            this.canReissueCard = canReissueCard;
            return this;
        }
        public Boolean getCanReissueCard() {
            return this.canReissueCard;
        }

        public BatchCreateRequestData setCardCycle(Long cardCycle) {
            this.cardCycle = cardCycle;
            return this;
        }
        public Long getCardCycle() {
            return this.cardCycle;
        }

        public BatchCreateRequestData setCardFrequency(java.util.List<Long> cardFrequency) {
            this.cardFrequency = cardFrequency;
            return this;
        }
        public java.util.List<Long> getCardFrequency() {
            return this.cardFrequency;
        }

        public BatchCreateRequestData setCardRuleItemParamList(java.util.List<BatchCreateRequestDataCardRuleItemParamList> cardRuleItemParamList) {
            this.cardRuleItemParamList = cardRuleItemParamList;
            return this;
        }
        public java.util.List<BatchCreateRequestDataCardRuleItemParamList> getCardRuleItemParamList() {
            return this.cardRuleItemParamList;
        }

        public BatchCreateRequestData setClassIds(java.util.List<String> classIds) {
            this.classIds = classIds;
            return this;
        }
        public java.util.List<String> getClassIds() {
            return this.classIds;
        }

        public BatchCreateRequestData setClassNames(java.util.List<String> classNames) {
            this.classNames = classNames;
            return this;
        }
        public java.util.List<String> getClassNames() {
            return this.classNames;
        }

        public BatchCreateRequestData setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public BatchCreateRequestData setEffectDate(Float effectDate) {
            this.effectDate = effectDate;
            return this;
        }
        public Float getEffectDate() {
            return this.effectDate;
        }

        public BatchCreateRequestData setMedias(String medias) {
            this.medias = medias;
            return this;
        }
        public String getMedias() {
            return this.medias;
        }

        public BatchCreateRequestData setNeedMetering(Boolean needMetering) {
            this.needMetering = needMetering;
            return this;
        }
        public Boolean getNeedMetering() {
            return this.needMetering;
        }

        public BatchCreateRequestData setOrgClassStudentGroupList(java.util.List<BatchCreateRequestDataOrgClassStudentGroupList> orgClassStudentGroupList) {
            this.orgClassStudentGroupList = orgClassStudentGroupList;
            return this;
        }
        public java.util.List<BatchCreateRequestDataOrgClassStudentGroupList> getOrgClassStudentGroupList() {
            return this.orgClassStudentGroupList;
        }

        public BatchCreateRequestData setRemindHour(Long remindHour) {
            this.remindHour = remindHour;
            return this;
        }
        public Long getRemindHour() {
            return this.remindHour;
        }

        public BatchCreateRequestData setRemindMinute(Long remindMinute) {
            this.remindMinute = remindMinute;
            return this;
        }
        public Long getRemindMinute() {
            return this.remindMinute;
        }

        public BatchCreateRequestData setTargetRole(String targetRole) {
            this.targetRole = targetRole;
            return this;
        }
        public String getTargetRole() {
            return this.targetRole;
        }

        public BatchCreateRequestData setTemplateId(Float templateId) {
            this.templateId = templateId;
            return this;
        }
        public Float getTemplateId() {
            return this.templateId;
        }

        public BatchCreateRequestData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public BatchCreateRequestData setUnitOfMeasurement(String unitOfMeasurement) {
            this.unitOfMeasurement = unitOfMeasurement;
            return this;
        }
        public String getUnitOfMeasurement() {
            return this.unitOfMeasurement;
        }

    }

}
