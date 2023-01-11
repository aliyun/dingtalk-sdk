// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateRequest extends TeaModel {
    /**
     * <p>卡片业务类型，打卡写死：industry_center</p>
     */
    @NameInMap("cardBizCode")
    public String cardBizCode;

    /**
     * <p>卡片详细数据</p>
     */
    @NameInMap("data")
    public BatchCreateRequestData data;

    /**
     * <p>卡片幂等唯一键</p>
     */
    @NameInMap("identifier")
    public String identifier;

    /**
     * <p>小程序版本号</p>
     */
    @NameInMap("jsVersion")
    public Integer jsVersion;

    /**
     * <p>isv业务类型</p>
     */
    @NameInMap("sourceType")
    public String sourceType;

    /**
     * <p>老师用户id</p>
     */
    @NameInMap("userid")
    public String userid;

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

    public BatchCreateRequest setJsVersion(Integer jsVersion) {
        this.jsVersion = jsVersion;
        return this;
    }
    public Integer getJsVersion() {
        return this.jsVersion;
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

    public static class BatchCreateRequestDataCardRuleItemParamList extends TeaModel {
        /**
         * <p>扩展属性，存放配音难度、每日配音视频的url等</p>
         */
        @NameInMap("cardRuleAttr")
        public String cardRuleAttr;

        /**
         * <p>卡片taskCode</p>
         */
        @NameInMap("cardTaskCode")
        public String cardTaskCode;

        /**
         * <p>每日配音数</p>
         */
        @NameInMap("dailyDubbing")
        public Integer dailyDubbing;

        /**
         * <p>关联的外部Id</p>
         */
        @NameInMap("relationId")
        public String relationId;

        /**
         * <p>关联内容标题（会在打卡详页页展示）</p>
         */
        @NameInMap("relationTitle")
        public String relationTitle;

        /**
         * <p>relationUrl（点击打卡内容后跳转的链接）（点击卡片内容后跳转的链接）</p>
         */
        @NameInMap("relationUrl")
        public String relationUrl;

        public static BatchCreateRequestDataCardRuleItemParamList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateRequestDataCardRuleItemParamList self = new BatchCreateRequestDataCardRuleItemParamList();
            return TeaModel.build(map, self);
        }

        public BatchCreateRequestDataCardRuleItemParamList setCardRuleAttr(String cardRuleAttr) {
            this.cardRuleAttr = cardRuleAttr;
            return this;
        }
        public String getCardRuleAttr() {
            return this.cardRuleAttr;
        }

        public BatchCreateRequestDataCardRuleItemParamList setCardTaskCode(String cardTaskCode) {
            this.cardTaskCode = cardTaskCode;
            return this;
        }
        public String getCardTaskCode() {
            return this.cardTaskCode;
        }

        public BatchCreateRequestDataCardRuleItemParamList setDailyDubbing(Integer dailyDubbing) {
            this.dailyDubbing = dailyDubbing;
            return this;
        }
        public Integer getDailyDubbing() {
            return this.dailyDubbing;
        }

        public BatchCreateRequestDataCardRuleItemParamList setRelationId(String relationId) {
            this.relationId = relationId;
            return this;
        }
        public String getRelationId() {
            return this.relationId;
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
        /**
         * <p>学生名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>学生id</p>
         */
        @NameInMap("staffId")
        public String staffId;

        public static BatchCreateRequestDataOrgClassStudentGroupListClassListStudents build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateRequestDataOrgClassStudentGroupListClassListStudents self = new BatchCreateRequestDataOrgClassStudentGroupListClassListStudents();
            return TeaModel.build(map, self);
        }

        public BatchCreateRequestDataOrgClassStudentGroupListClassListStudents setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchCreateRequestDataOrgClassStudentGroupListClassListStudents setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

    }

    public static class BatchCreateRequestDataOrgClassStudentGroupListClassList extends TeaModel {
        /**
         * <p>班级id</p>
         */
        @NameInMap("classId")
        public Long classId;

        /**
         * <p>班级名称</p>
         */
        @NameInMap("className")
        public String className;

        /**
         * <p>班级学生</p>
         */
        @NameInMap("students")
        public java.util.List<BatchCreateRequestDataOrgClassStudentGroupListClassListStudents> students;

        public static BatchCreateRequestDataOrgClassStudentGroupListClassList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateRequestDataOrgClassStudentGroupListClassList self = new BatchCreateRequestDataOrgClassStudentGroupListClassList();
            return TeaModel.build(map, self);
        }

        public BatchCreateRequestDataOrgClassStudentGroupListClassList setClassId(Long classId) {
            this.classId = classId;
            return this;
        }
        public Long getClassId() {
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
        /**
         * <p>班级列表</p>
         */
        @NameInMap("classList")
        public java.util.List<BatchCreateRequestDataOrgClassStudentGroupListClassList> classList;

        /**
         * <p>组织id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        public static BatchCreateRequestDataOrgClassStudentGroupList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateRequestDataOrgClassStudentGroupList self = new BatchCreateRequestDataOrgClassStudentGroupList();
            return TeaModel.build(map, self);
        }

        public BatchCreateRequestDataOrgClassStudentGroupList setClassList(java.util.List<BatchCreateRequestDataOrgClassStudentGroupListClassList> classList) {
            this.classList = classList;
            return this;
        }
        public java.util.List<BatchCreateRequestDataOrgClassStudentGroupListClassList> getClassList() {
            return this.classList;
        }

        public BatchCreateRequestDataOrgClassStudentGroupList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

    }

    public static class BatchCreateRequestData extends TeaModel {
        /**
         * <p>是否可以补卡</p>
         */
        @NameInMap("canReissueCard")
        public Boolean canReissueCard;

        /**
         * <p>打卡周期,单位为天</p>
         */
        @NameInMap("cardCycle")
        public Integer cardCycle;

        /**
         * <p>打卡的频次设置："cardFrequency":[             1,//周天             2,//周一             3,//周二             4,//周三             5,//周四             6,//周五             7//周六         ]</p>
         */
        @NameInMap("cardFrequency")
        public java.util.List<Integer> cardFrequency;

        @NameInMap("cardRuleItemParamList")
        public java.util.List<BatchCreateRequestDataCardRuleItemParamList> cardRuleItemParamList;

        /**
         * <p>班级列表</p>
         */
        @NameInMap("classIds")
        public java.util.List<String> classIds;

        /**
         * <p>班级名称列表</p>
         */
        @NameInMap("classNames")
        public java.util.List<String> classNames;

        /**
         * <p>打卡的内容</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>卡片生效时间</p>
         */
        @NameInMap("effectDate")
        public Long effectDate;

        /**
         * <p>上传相册，图片，录音，盯盘的信息</p>
         */
        @NameInMap("medias")
        public String medias;

        /**
         * <p>计量开启</p>
         */
        @NameInMap("needMetering")
        public String needMetering;

        @NameInMap("orgClassStudentGroupList")
        public java.util.List<BatchCreateRequestDataOrgClassStudentGroupList> orgClassStudentGroupList;

        /**
         * <p>提醒时间（小时）</p>
         */
        @NameInMap("remindHour")
        public Integer remindHour;

        /**
         * <p>提醒时间（分钟）</p>
         */
        @NameInMap("remindMinute")
        public Integer remindMinute;

        /**
         * <p>默认：student_guardian</p>
         */
        @NameInMap("targetRole")
        public String targetRole;

        /**
         * <p>打卡模板id</p>
         */
        @NameInMap("templateId")
        public Long templateId;

        /**
         * <p>卡片标题</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>计量单位</p>
         */
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

        public BatchCreateRequestData setCardCycle(Integer cardCycle) {
            this.cardCycle = cardCycle;
            return this;
        }
        public Integer getCardCycle() {
            return this.cardCycle;
        }

        public BatchCreateRequestData setCardFrequency(java.util.List<Integer> cardFrequency) {
            this.cardFrequency = cardFrequency;
            return this;
        }
        public java.util.List<Integer> getCardFrequency() {
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

        public BatchCreateRequestData setEffectDate(Long effectDate) {
            this.effectDate = effectDate;
            return this;
        }
        public Long getEffectDate() {
            return this.effectDate;
        }

        public BatchCreateRequestData setMedias(String medias) {
            this.medias = medias;
            return this;
        }
        public String getMedias() {
            return this.medias;
        }

        public BatchCreateRequestData setNeedMetering(String needMetering) {
            this.needMetering = needMetering;
            return this;
        }
        public String getNeedMetering() {
            return this.needMetering;
        }

        public BatchCreateRequestData setOrgClassStudentGroupList(java.util.List<BatchCreateRequestDataOrgClassStudentGroupList> orgClassStudentGroupList) {
            this.orgClassStudentGroupList = orgClassStudentGroupList;
            return this;
        }
        public java.util.List<BatchCreateRequestDataOrgClassStudentGroupList> getOrgClassStudentGroupList() {
            return this.orgClassStudentGroupList;
        }

        public BatchCreateRequestData setRemindHour(Integer remindHour) {
            this.remindHour = remindHour;
            return this;
        }
        public Integer getRemindHour() {
            return this.remindHour;
        }

        public BatchCreateRequestData setRemindMinute(Integer remindMinute) {
            this.remindMinute = remindMinute;
            return this;
        }
        public Integer getRemindMinute() {
            return this.remindMinute;
        }

        public BatchCreateRequestData setTargetRole(String targetRole) {
            this.targetRole = targetRole;
            return this;
        }
        public String getTargetRole() {
            return this.targetRole;
        }

        public BatchCreateRequestData setTemplateId(Long templateId) {
            this.templateId = templateId;
            return this;
        }
        public Long getTemplateId() {
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
