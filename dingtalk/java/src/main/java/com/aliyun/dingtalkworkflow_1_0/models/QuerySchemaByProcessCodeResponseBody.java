// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QuerySchemaByProcessCodeResponseBody extends TeaModel {
    /**
     * <p>返回结果详情。</p>
     */
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

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps extends TeaModel {
        /**
         * <p>控件业务别名</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>控件id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>控件名称</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>是否必填</p>
         */
        @NameInMap("required")
        public Boolean required;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren extends TeaModel {
        /**
         * <p>控件类型</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>子控件属性</p>
         */
        @NameInMap("props")
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps props;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren setProps(QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps props) {
            this.props = props;
            return this;
        }
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps getProps() {
            return this.props;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets extends TeaModel {
        /**
         * <p>行为。</p>
         */
        @NameInMap("behavior")
        public String behavior;

        /**
         * <p>字段 id。</p>
         */
        @NameInMap("fieldId")
        public String fieldId;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets setBehavior(String behavior) {
            this.behavior = behavior;
            return this;
        }
        public String getBehavior() {
            return this.behavior;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage extends TeaModel {
        /**
         * <p>关联控件列表。</p>
         */
        @NameInMap("targets")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets> targets;

        /**
         * <p>控件值。</p>
         */
        @NameInMap("value")
        public String value;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage setTargets(java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets> targets) {
            this.targets = targets;
            return this;
        }
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets> getTargets() {
            return this.targets;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
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
        /**
         * <p>考勤类型(1表示请假, 2表示出差, 3表示加班, 4表示外出)</p>
         */
        @NameInMap("attendanceRule")
        public Integer attendanceRule;

        /**
         * <p>开启状态(1表示开启, 0表示关闭)</p>
         */
        @NameInMap("pushSwitch")
        public Integer pushSwitch;

        /**
         * <p>状态显示名称</p>
         */
        @NameInMap("pushTag")
        public String pushTag;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush setAttendanceRule(Integer attendanceRule) {
            this.attendanceRule = attendanceRule;
            return this;
        }
        public Integer getAttendanceRule() {
            return this.attendanceRule;
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

    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField extends TeaModel {
        /**
         * <p>id 值。</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>名称。</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>单位。</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>大写。</p>
         */
        @NameInMap("upper")
        public Boolean upper;

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

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps extends TeaModel {
        /**
         * <p>加班套件4.0新增 加班明细名称。</p>
         */
        @NameInMap("actionName")
        public String actionName;

        /**
         * <p>textnote的样式，top|middle|bottom。</p>
         */
        @NameInMap("align")
        public String align;

        /**
         * <p>ISV 微应用 appId，用于ISV身份权限识别，ISV可获得相应数据。</p>
         */
        @NameInMap("appId")
        public Long appId;

        /**
         * <p>套件是否开启异步获取分条件规则，true：开启；false：不开启。</p>
         */
        @NameInMap("asyncCondition")
        public Boolean asyncCondition;

        /**
         * <p>请假、出差、外出、加班类型标签。</p>
         */
        @NameInMap("attendTypeLabel")
        public String attendTypeLabel;

        /**
         * <p>表单关联控件列表。</p>
         */
        @NameInMap("behaviorLinkage")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage> behaviorLinkage;

        /**
         * <p>控件业务自定义别名。</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>业务套件类型。</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>套件内子组件可见性</p>
         */
        @NameInMap("childFieldVisible")
        public java.util.Map<String, Boolean> childFieldVisible;

        /**
         * <p>内部联系人choice，1表示多选，0表示单选。</p>
         */
        @NameInMap("choice")
        public Integer choice;

        /**
         * <p>common field的commonBizType。</p>
         */
        @NameInMap("commonBizType")
        public String commonBizType;

        /**
         * <p>是否可编辑。</p>
         */
        @NameInMap("disabled")
        public Boolean disabled;

        /**
         * <p>是否自动计算时长。</p>
         */
        @NameInMap("duration")
        public Boolean duration;

        /**
         * <p>兼容字段。</p>
         */
        @NameInMap("durationLabel")
        public String durationLabel;

        /**
         * <p>e签宝专用标识。</p>
         */
        @NameInMap("eSign")
        public Boolean eSign;

        /**
         * <p>套件值是否打平</p>
         */
        @NameInMap("extract")
        public Boolean extract;

        /**
         * <p>关联表单中的fields存储</p>
         */
        @NameInMap("fieldsInfo")
        public String fieldsInfo;

        /**
         * <p>时间格式(DDDateField和DDDateRangeField)。</p>
         */
        @NameInMap("format")
        public String format;

        /**
         * <p>公式。</p>
         */
        @NameInMap("formula")
        public String formula;

        /**
         * <p>加班套件4.0新增 加班明细是否隐藏。</p>
         */
        @NameInMap("hidden")
        public Boolean hidden;

        /**
         * <p>textnote在详情页是否隐藏，true隐藏， false不隐藏</p>
         */
        @NameInMap("hiddenInApprovalDetail")
        public Boolean hiddenInApprovalDetail;

        /**
         * <p>加班套件4.0新增 加班明细是否隐藏标签。</p>
         */
        @NameInMap("hideLabel")
        public Boolean hideLabel;

        /**
         * <p>兼容出勤套件类型。</p>
         */
        @NameInMap("holidayOptions")
        public java.util.List<java.util.Map<String, String>> holidayOptions;

        /**
         * <p>控件 id。</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>控件名称。</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>label是否可修改 true：不可修改。</p>
         */
        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        /**
         * <p>说明文案的链接地址。</p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <p>加班套件4.0新增 加班明细描述。</p>
         */
        @NameInMap("mainTitle")
        public String mainTitle;

        /**
         * <p>是否参与打印(1表示不打印, 0表示打印)。</p>
         */
        @NameInMap("notPrint")
        public String notPrint;

        /**
         * <p>是否需要大写 默认是需要; 1:不需要大写, 空或者0:需要大写。</p>
         */
        @NameInMap("notUpper")
        public String notUpper;

        /**
         * <p>选项内容列表，提供给业务方更多的选择器操作。</p>
         */
        @NameInMap("objOptions")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions> objOptions;

        /**
         * <p>单选框选项列表。</p>
         */
        @NameInMap("options")
        public java.util.List<String> options;

        /**
         * <p>是否有支付属性。</p>
         */
        @NameInMap("payEnable")
        public Boolean payEnable;

        /**
         * <p>占位符。</p>
         */
        @NameInMap("placeholder")
        public String placeholder;

        /**
         * <p>同步到考勤, 表示是否设置为员工状态。</p>
         */
        @NameInMap("push")
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush push;

        /**
         * <p>推送到考勤, 子类型(DDSelectField)。</p>
         */
        @NameInMap("pushToAttendance")
        public Boolean pushToAttendance;

        /**
         * <p>是否推送管理日历(DDDateRangeField, 1表示推送, 0表示不推送, 该属性为兼容保留)。</p>
         */
        @NameInMap("pushToCalendar")
        public Integer pushToCalendar;

        /**
         * <p>是否必填。</p>
         */
        @NameInMap("required")
        public Boolean required;

        /**
         * <p>必填是否可修改 true：不可修改。</p>
         */
        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        /**
         * <p>兼容出勤套件类型。</p>
         */
        @NameInMap("showAttendOptions")
        public Boolean showAttendOptions;

        /**
         * <p>是否开启员工状态。</p>
         */
        @NameInMap("staffStatusEnabled")
        public Boolean staffStatusEnabled;

        /**
         * <p>需要计算总和的明细组件</p>
         */
        @NameInMap("statField")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField> statField;

        /**
         * <p>数字组件/日期区间组件单位属性。</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>是否使用考勤日历。</p>
         */
        @NameInMap("useCalendar")
        public Boolean useCalendar;

        /**
         * <p>明细打印排版方式 false：横向 true：纵向。</p>
         */
        @NameInMap("verticalPrint")
        public Boolean verticalPrint;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setActionName(String actionName) {
            this.actionName = actionName;
            return this;
        }
        public String getActionName() {
            return this.actionName;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setAppId(Long appId) {
            this.appId = appId;
            return this;
        }
        public Long getAppId() {
            return this.appId;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setAsyncCondition(Boolean asyncCondition) {
            this.asyncCondition = asyncCondition;
            return this;
        }
        public Boolean getAsyncCondition() {
            return this.asyncCondition;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setAttendTypeLabel(String attendTypeLabel) {
            this.attendTypeLabel = attendTypeLabel;
            return this;
        }
        public String getAttendTypeLabel() {
            return this.attendTypeLabel;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setBehaviorLinkage(java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage> behaviorLinkage) {
            this.behaviorLinkage = behaviorLinkage;
            return this;
        }
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage> getBehaviorLinkage() {
            return this.behaviorLinkage;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setChildFieldVisible(java.util.Map<String, Boolean> childFieldVisible) {
            this.childFieldVisible = childFieldVisible;
            return this;
        }
        public java.util.Map<String, Boolean> getChildFieldVisible() {
            return this.childFieldVisible;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setChoice(Integer choice) {
            this.choice = choice;
            return this;
        }
        public Integer getChoice() {
            return this.choice;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setCommonBizType(String commonBizType) {
            this.commonBizType = commonBizType;
            return this;
        }
        public String getCommonBizType() {
            return this.commonBizType;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setESign(Boolean eSign) {
            this.eSign = eSign;
            return this;
        }
        public Boolean getESign() {
            return this.eSign;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setExtract(Boolean extract) {
            this.extract = extract;
            return this;
        }
        public Boolean getExtract() {
            return this.extract;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setFieldsInfo(String fieldsInfo) {
            this.fieldsInfo = fieldsInfo;
            return this;
        }
        public String getFieldsInfo() {
            return this.fieldsInfo;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setHidden(Boolean hidden) {
            this.hidden = hidden;
            return this;
        }
        public Boolean getHidden() {
            return this.hidden;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setHiddenInApprovalDetail(Boolean hiddenInApprovalDetail) {
            this.hiddenInApprovalDetail = hiddenInApprovalDetail;
            return this;
        }
        public Boolean getHiddenInApprovalDetail() {
            return this.hiddenInApprovalDetail;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setHideLabel(Boolean hideLabel) {
            this.hideLabel = hideLabel;
            return this;
        }
        public Boolean getHideLabel() {
            return this.hideLabel;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setHolidayOptions(java.util.List<java.util.Map<String, String>> holidayOptions) {
            this.holidayOptions = holidayOptions;
            return this;
        }
        public java.util.List<java.util.Map<String, String>> getHolidayOptions() {
            return this.holidayOptions;
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

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setMainTitle(String mainTitle) {
            this.mainTitle = mainTitle;
            return this;
        }
        public String getMainTitle() {
            return this.mainTitle;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setObjOptions(java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions> objOptions) {
            this.objOptions = objOptions;
            return this;
        }
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions> getObjOptions() {
            return this.objOptions;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setOptions(java.util.List<String> options) {
            this.options = options;
            return this;
        }
        public java.util.List<String> getOptions() {
            return this.options;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setPush(QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush push) {
            this.push = push;
            return this;
        }
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush getPush() {
            return this.push;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setPushToAttendance(Boolean pushToAttendance) {
            this.pushToAttendance = pushToAttendance;
            return this;
        }
        public Boolean getPushToAttendance() {
            return this.pushToAttendance;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setPushToCalendar(Integer pushToCalendar) {
            this.pushToCalendar = pushToCalendar;
            return this;
        }
        public Integer getPushToCalendar() {
            return this.pushToCalendar;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setShowAttendOptions(Boolean showAttendOptions) {
            this.showAttendOptions = showAttendOptions;
            return this;
        }
        public Boolean getShowAttendOptions() {
            return this.showAttendOptions;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setStaffStatusEnabled(Boolean staffStatusEnabled) {
            this.staffStatusEnabled = staffStatusEnabled;
            return this;
        }
        public Boolean getStaffStatusEnabled() {
            return this.staffStatusEnabled;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setStatField(java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField> getStatField() {
            return this.statField;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setUseCalendar(Boolean useCalendar) {
            this.useCalendar = useCalendar;
            return this;
        }
        public Boolean getUseCalendar() {
            return this.useCalendar;
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems extends TeaModel {
        /**
         * <p>子控件列表</p>
         */
        @NameInMap("children")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren> children;

        /**
         * <p>控件类型，取值：</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>控件属性。</p>
         */
        @NameInMap("props")
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps props;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems setChildren(java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren> children) {
            this.children = children;
            return this;
        }
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren> getChildren() {
            return this.children;
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
        /**
         * <p>图标</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>控件列表</p>
         */
        @NameInMap("items")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems> items;

        /**
         * <p>表单名称。</p>
         */
        @NameInMap("title")
        public String title;

        public static QuerySchemaByProcessCodeResponseBodyResultSchemaContent build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResultSchemaContent self = new QuerySchemaByProcessCodeResponseBodyResultSchemaContent();
            return TeaModel.build(map, self);
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

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContent setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QuerySchemaByProcessCodeResponseBodyResult extends TeaModel {
        /**
         * <p>表单类型。</p>
         */
        @NameInMap("appType")
        public Integer appType;

        /**
         * <p>表单应用 uuid 或者 corpId。</p>
         */
        @NameInMap("appUuid")
        public String appUuid;

        /**
         * <p>代表表单业务含义的类型。</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>创建人 userId。</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <p>业务自定义设置数据。</p>
         */
        @NameInMap("customSetting")
        public String customSetting;

        /**
         * <p>引擎类型，表单：0，页面：1</p>
         */
        @NameInMap("engineType")
        public Integer engineType;

        /**
         * <p>表单的唯一码。</p>
         */
        @NameInMap("formCode")
        public String formCode;

        /**
         * <p>表单 uuid。</p>
         */
        @NameInMap("formUuid")
        public String formUuid;

        /**
         * <p>创建时间的时间戳。</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>修改时间的时间戳。</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <p>图标。</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>排序 id。</p>
         */
        @NameInMap("listOrder")
        public Integer listOrder;

        /**
         * <p>说明文案。</p>
         */
        @NameInMap("memo")
        public String memo;

        /**
         * <p>表单名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>数据归属者的 id 类型。企业(orgId), 群(cid), 人(uid)。</p>
         */
        @NameInMap("ownerIdType")
        public String ownerIdType;

        /**
         * <p>目标类型: inner, outer, customer。</p>
         */
        @NameInMap("procType")
        public String procType;

        /**
         * <p>表单 schema 详情。</p>
         */
        @NameInMap("schemaContent")
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContent schemaContent;

        /**
         * <p>状态, PUBLISHED(启用), INVALID(停用), SAVED(草稿)</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>可见范围类型。</p>
         */
        @NameInMap("visibleRange")
        public String visibleRange;

        public static QuerySchemaByProcessCodeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QuerySchemaByProcessCodeResponseBodyResult self = new QuerySchemaByProcessCodeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QuerySchemaByProcessCodeResponseBodyResult setAppType(Integer appType) {
            this.appType = appType;
            return this;
        }
        public Integer getAppType() {
            return this.appType;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setAppUuid(String appUuid) {
            this.appUuid = appUuid;
            return this;
        }
        public String getAppUuid() {
            return this.appUuid;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setCustomSetting(String customSetting) {
            this.customSetting = customSetting;
            return this;
        }
        public String getCustomSetting() {
            return this.customSetting;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setEngineType(Integer engineType) {
            this.engineType = engineType;
            return this;
        }
        public Integer getEngineType() {
            return this.engineType;
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

        public QuerySchemaByProcessCodeResponseBodyResult setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setListOrder(Integer listOrder) {
            this.listOrder = listOrder;
            return this;
        }
        public Integer getListOrder() {
            return this.listOrder;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setOwnerIdType(String ownerIdType) {
            this.ownerIdType = ownerIdType;
            return this;
        }
        public String getOwnerIdType() {
            return this.ownerIdType;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setProcType(String procType) {
            this.procType = procType;
            return this;
        }
        public String getProcType() {
            return this.procType;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setSchemaContent(QuerySchemaByProcessCodeResponseBodyResultSchemaContent schemaContent) {
            this.schemaContent = schemaContent;
            return this;
        }
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContent getSchemaContent() {
            return this.schemaContent;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QuerySchemaByProcessCodeResponseBodyResult setVisibleRange(String visibleRange) {
            this.visibleRange = visibleRange;
            return this;
        }
        public String getVisibleRange() {
            return this.visibleRange;
        }

    }

}
