// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QuerySchemaByProcessCodeResponseBody extends TeaModel {
    // 返回结果详情。
    @NameInMap("result")
    public QuerySchemaByProcessCodeResponseBodyResult result;

    public static QuerySchemaByProcessCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySchemaByProcessCodeResponseBody self = new QuerySchemaByProcessCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySchemaByProcessCodeResponseBody setResult(QuerySchemaByProcessCodeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QuerySchemaByProcessCodeResponseBodyResult getResult() {
        return this.result;
    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField extends TeaModel {
        // id 值。
        @NameInMap("id")
        public String id;

        // 名称。
        @NameInMap("label")
        public String label;

        // 大写。
        @NameInMap("upper")
        public Boolean upper;

        // 单位。
        @NameInMap("unit")
        public String unit;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions extends TeaModel {
        @NameInMap("value")
        public String value;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush extends TeaModel {
        // 开启状态(1表示开启, 0表示关闭)
        @NameInMap("pushSwitch")
        public Integer pushSwitch;

        // 状态显示名称
        @NameInMap("pushTag")
        public String pushTag;

        // 考勤类型(1表示请假, 2表示出差, 3表示加班, 4表示外出)
        @NameInMap("attendanceRule")
        public Integer attendanceRule;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush setPushSwitch(Integer pushSwitch) {
            this.pushSwitch = pushSwitch;
            return this;
        }
        public Integer getPushSwitch() {
            return this.pushSwitch;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush setPushTag(String pushTag) {
            this.pushTag = pushTag;
            return this;
        }
        public String getPushTag() {
            return this.pushTag;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush setAttendanceRule(Integer attendanceRule) {
            this.attendanceRule = attendanceRule;
            return this;
        }
        public Integer getAttendanceRule() {
            return this.attendanceRule;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets extends TeaModel {
        // 字段 id。
        @NameInMap("fieldId")
        public String fieldId;

        // 行为。
        @NameInMap("behavior")
        public String behavior;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets setBehavior(String behavior) {
            this.behavior = behavior;
            return this;
        }
        public String getBehavior() {
            return this.behavior;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage extends TeaModel {
        // 控件值。
        @NameInMap("value")
        public String value;

        // 关联控件列表。
        @NameInMap("targets")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets> targets;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage setTargets(java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets> targets) {
            this.targets = targets;
            return this;
        }
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets> getTargets() {
            return this.targets;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps extends TeaModel {
        // 控件 id。
        @NameInMap("id")
        public String id;

        // 控件名称。
        @NameInMap("label")
        public String label;

        // 控件业务自定义别名。
        @NameInMap("bizAlias")
        public String bizAlias;

        // 是否必填。
        @NameInMap("required")
        public Boolean required;

        // 占位符。
        @NameInMap("placeholder")
        public String placeholder;

        // 单选框选项列表。
        @NameInMap("options")
        public java.util.List<String> options;

        // ISV 微应用 appId，用于ISV身份权限识别，ISV可获得相应数据。
        @NameInMap("appId")
        public Long appId;

        // 兼容字段。
        @NameInMap("durationLabel")
        public String durationLabel;

        // 是否推送管理日历(DDDateRangeField, 1表示推送, 0表示不推送, 该属性为兼容保留)。
        @NameInMap("pushToCalendar")
        public Integer pushToCalendar;

        // textnote的样式，top|middle|bottom。
        @NameInMap("align")
        public String align;

        // 需要计算总和的明细组件
        @NameInMap("statField")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField> statField;

        // 加班套件4.0新增 加班明细是否隐藏标签。
        @NameInMap("hideLabel")
        public Boolean hideLabel;

        // 选项内容列表，提供给业务方更多的选择器操作。
        @NameInMap("objOptions")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions> objOptions;

        // 时间格式(DDDateField和DDDateRangeField)。
        @NameInMap("format")
        public String format;

        // 推送到考勤, 子类型(DDSelectField)。
        @NameInMap("pushToAttendance")
        public Boolean pushToAttendance;

        // label是否可修改 true：不可修改。
        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        // 同步到考勤, 表示是否设置为员工状态。
        @NameInMap("push")
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush push;

        // common field的commonBizType。
        @NameInMap("commonBizType")
        public String commonBizType;

        // 必填是否可修改 true：不可修改。
        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        // 数字组件/日期区间组件单位属性。
        @NameInMap("unit")
        public String unit;

        // 套件值是否打平
        @NameInMap("extract")
        public Boolean extract;

        // 说明文案的链接地址。
        @NameInMap("link")
        public String link;

        // 是否有支付属性。
        @NameInMap("payEnable")
        public Boolean payEnable;

        // 加班套件4.0新增 加班明细是否隐藏。
        @NameInMap("hidden")
        public Boolean hidden;

        // 业务套件类型。
        @NameInMap("bizType")
        public String bizType;

        // 是否开启员工状态。
        @NameInMap("staffStatusEnabled")
        public Boolean staffStatusEnabled;

        // 加班套件4.0新增 加班明细名称。
        @NameInMap("actionName")
        public String actionName;

        // 请假、出差、外出、加班类型标签。
        @NameInMap("attendTypeLabel")
        public String attendTypeLabel;

        // 套件内子组件可见性。
        @NameInMap("childFieldVisible")
        public Boolean childFieldVisible;

        // 是否参与打印(1表示不打印, 0表示打印)。
        @NameInMap("notPrint")
        public String notPrint;

        // 明细打印排版方式 false：横向 true：纵向。
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        // 是否自动计算时长。
        @NameInMap("duration")
        public Boolean duration;

        // 兼容出勤套件类型。
        @NameInMap("holidayOptions")
        public String holidayOptions;

        // 是否使用考勤日历。
        @NameInMap("useCalendar")
        public Boolean useCalendar;

        // textnote在详情页是否隐藏，true隐藏， false不隐藏
        @NameInMap("hiddenInApprovalDetail")
        public Boolean hiddenInApprovalDetail;

        // 是否可编辑。
        @NameInMap("disabled")
        public Boolean disabled;

        // 套件是否开启异步获取分条件规则，true：开启；false：不开启。
        @NameInMap("asyncCondition")
        public Boolean asyncCondition;

        // 表单关联控件列表。
        @NameInMap("behaviorLinkage")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage> behaviorLinkage;

        // 兼容出勤套件类型。
        @NameInMap("showAttendOptions")
        public Boolean showAttendOptions;

        // 是否需要大写 默认是需要; 1:不需要大写, 空或者0:需要大写。
        @NameInMap("notUpper")
        public String notUpper;

        // 关联表单中的fields存储
        @NameInMap("fieldsInfo")
        public String fieldsInfo;

        // e签宝专用标识。
        @NameInMap("eSign")
        public Boolean eSign;

        // 加班套件4.0新增 加班明细描述。
        @NameInMap("mainTitle")
        public String mainTitle;

        // 公式。
        @NameInMap("formula")
        public String formula;

        // 内部联系人choice，1表示多选，0表示单选。
        @NameInMap("choice")
        public Integer choice;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setOptions(java.util.List<String> options) {
            this.options = options;
            return this;
        }
        public java.util.List<String> getOptions() {
            return this.options;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setAppId(Long appId) {
            this.appId = appId;
            return this;
        }
        public Long getAppId() {
            return this.appId;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setPushToCalendar(Integer pushToCalendar) {
            this.pushToCalendar = pushToCalendar;
            return this;
        }
        public Integer getPushToCalendar() {
            return this.pushToCalendar;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setStatField(java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField> getStatField() {
            return this.statField;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setHideLabel(Boolean hideLabel) {
            this.hideLabel = hideLabel;
            return this;
        }
        public Boolean getHideLabel() {
            return this.hideLabel;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setObjOptions(java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions> objOptions) {
            this.objOptions = objOptions;
            return this;
        }
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions> getObjOptions() {
            return this.objOptions;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setPushToAttendance(Boolean pushToAttendance) {
            this.pushToAttendance = pushToAttendance;
            return this;
        }
        public Boolean getPushToAttendance() {
            return this.pushToAttendance;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setPush(QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush push) {
            this.push = push;
            return this;
        }
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush getPush() {
            return this.push;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setCommonBizType(String commonBizType) {
            this.commonBizType = commonBizType;
            return this;
        }
        public String getCommonBizType() {
            return this.commonBizType;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setExtract(Boolean extract) {
            this.extract = extract;
            return this;
        }
        public Boolean getExtract() {
            return this.extract;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setHidden(Boolean hidden) {
            this.hidden = hidden;
            return this;
        }
        public Boolean getHidden() {
            return this.hidden;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setStaffStatusEnabled(Boolean staffStatusEnabled) {
            this.staffStatusEnabled = staffStatusEnabled;
            return this;
        }
        public Boolean getStaffStatusEnabled() {
            return this.staffStatusEnabled;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setActionName(String actionName) {
            this.actionName = actionName;
            return this;
        }
        public String getActionName() {
            return this.actionName;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setAttendTypeLabel(String attendTypeLabel) {
            this.attendTypeLabel = attendTypeLabel;
            return this;
        }
        public String getAttendTypeLabel() {
            return this.attendTypeLabel;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setChildFieldVisible(Boolean childFieldVisible) {
            this.childFieldVisible = childFieldVisible;
            return this;
        }
        public Boolean getChildFieldVisible() {
            return this.childFieldVisible;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setHolidayOptions(String holidayOptions) {
            this.holidayOptions = holidayOptions;
            return this;
        }
        public String getHolidayOptions() {
            return this.holidayOptions;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setUseCalendar(Boolean useCalendar) {
            this.useCalendar = useCalendar;
            return this;
        }
        public Boolean getUseCalendar() {
            return this.useCalendar;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setHiddenInApprovalDetail(Boolean hiddenInApprovalDetail) {
            this.hiddenInApprovalDetail = hiddenInApprovalDetail;
            return this;
        }
        public Boolean getHiddenInApprovalDetail() {
            return this.hiddenInApprovalDetail;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setAsyncCondition(Boolean asyncCondition) {
            this.asyncCondition = asyncCondition;
            return this;
        }
        public Boolean getAsyncCondition() {
            return this.asyncCondition;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setBehaviorLinkage(java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage> behaviorLinkage) {
            this.behaviorLinkage = behaviorLinkage;
            return this;
        }
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage> getBehaviorLinkage() {
            return this.behaviorLinkage;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setShowAttendOptions(Boolean showAttendOptions) {
            this.showAttendOptions = showAttendOptions;
            return this;
        }
        public Boolean getShowAttendOptions() {
            return this.showAttendOptions;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setFieldsInfo(String fieldsInfo) {
            this.fieldsInfo = fieldsInfo;
            return this;
        }
        public String getFieldsInfo() {
            return this.fieldsInfo;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setESign(Boolean eSign) {
            this.eSign = eSign;
            return this;
        }
        public Boolean getESign() {
            return this.eSign;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setMainTitle(String mainTitle) {
            this.mainTitle = mainTitle;
            return this;
        }
        public String getMainTitle() {
            return this.mainTitle;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setChoice(Integer choice) {
            this.choice = choice;
            return this;
        }
        public Integer getChoice() {
            return this.choice;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems extends TeaModel {
        // 控件类型，取值：
        @NameInMap("componentName")
        public String componentName;

        // 控件属性。
        @NameInMap("props")
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps props;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems setProps(QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps props) {
            this.props = props;
            return this;
        }
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps getProps() {
            return this.props;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContent extends TeaModel {
        // 表单名称。
        @NameInMap("title")
        public String title;

        // 图标
        @NameInMap("icon")
        public String icon;

        // 控件列表。
        @NameInMap("items")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems> items;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContent build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContent self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContent();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContent setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContent setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContent setItems(java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems> getItems() {
            return this.items;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResult extends TeaModel {
        // 创建人 userId。
        @NameInMap("creatorUserId")
        public String creatorUserId;

        // 创建人 uid。
        @NameInMap("creatorUid")
        public Long creatorUid;

        // 表单应用 uuid 或者 corpId。
        @NameInMap("appUuid")
        public String appUuid;

        // 表单的唯一码。
        @NameInMap("formCode")
        public String formCode;

        // 表单 uuid。
        @NameInMap("formUuid")
        public String formUuid;

        // 表单名称。
        @NameInMap("name")
        public String name;

        // 说明文案。
        @NameInMap("memo")
        public String memo;

        // 数据归属者的 id。
        @NameInMap("ownerId")
        public String ownerId;

        // 数据归属者的 id 类型。企业(orgId), 群(cid), 人(uid)。
        @NameInMap("ownerIdType")
        public String ownerIdType;

        // 表单 schema 详情。
        @NameInMap("schemaContent")
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContent schemaContent;

        // 图标。
        @NameInMap("icon")
        public String icon;

        // 表单类型。
        @NameInMap("appType")
        public Integer appType;

        // 代表表单业务含义的类型。
        @NameInMap("bizType")
        public String bizType;

        // 引擎类型，表单：0，页面：1
        @NameInMap("engineType")
        public Integer engineType;

        // 状态, PUBLISHED(启用), INVALID(停用), SAVED(草稿)
        @NameInMap("status")
        public String status;

        // 排序 id。
        @NameInMap("listOrder")
        public Integer listOrder;

        // 业务自定义设置数据。
        @NameInMap("customSetting")
        public String customSetting;

        // 目标类型: inner, outer, customer。
        @NameInMap("procType")
        public String procType;

        // 可见范围类型。
        @NameInMap("visibleRange")
        public String visibleRange;

        // 创建时间的时间戳。
        @NameInMap("gmtCreate")
        public Integer gmtCreate;

        // 修改时间的时间戳。
        @NameInMap("gmtModified")
        public Integer gmtModified;

        public static QuerySchemaByProcessCodeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResult self = new QuerySchemaByProcessCodeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResult setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setCreatorUid(Long creatorUid) {
            this.creatorUid = creatorUid;
            return this;
        }
        public Long getCreatorUid() {
            return this.creatorUid;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setOwnerId(String ownerId) {
            this.ownerId = ownerId;
            return this;
        }
        public String getOwnerId() {
            return this.ownerId;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setOwnerIdType(String ownerIdType) {
            this.ownerIdType = ownerIdType;
            return this;
        }
        public String getOwnerIdType() {
            return this.ownerIdType;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setSchemaContent(QuerySchemaByProcessCodeResponseBodyResultSchemaContent schemaContent) {
            this.schemaContent = schemaContent;
            return this;
        }
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContent getSchemaContent() {
            return this.schemaContent;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setAppType(Integer appType) {
            this.appType = appType;
            return this;
        }
        public Integer getAppType() {
            return this.appType;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setEngineType(Integer engineType) {
            this.engineType = engineType;
            return this;
        }
        public Integer getEngineType() {
            return this.engineType;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setListOrder(Integer listOrder) {
            this.listOrder = listOrder;
            return this;
        }
        public Integer getListOrder() {
            return this.listOrder;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setCustomSetting(String customSetting) {
            this.customSetting = customSetting;
            return this;
        }
        public String getCustomSetting() {
            return this.customSetting;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setProcType(String procType) {
            this.procType = procType;
            return this;
        }
        public String getProcType() {
            return this.procType;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setVisibleRange(String visibleRange) {
            this.visibleRange = visibleRange;
            return this;
        }
        public String getVisibleRange() {
            return this.visibleRange;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setGmtCreate(Integer gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Integer getGmtCreate() {
            return this.gmtCreate;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setGmtModified(Integer gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Integer getGmtModified() {
            return this.gmtModified;
        }

    }

}
