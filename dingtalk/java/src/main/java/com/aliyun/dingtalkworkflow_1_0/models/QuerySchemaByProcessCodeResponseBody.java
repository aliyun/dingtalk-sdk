// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QuerySchemaByProcessCodeResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
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
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("id")
        public String id;

        @NameInMap("label")
        public String label;

        @NameInMap("options")
        public java.util.List<String> options;

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

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildrenProps setOptions(java.util.List<String> options) {
            this.options = options;
            return this;
        }
        public java.util.List<String> getOptions() {
            return this.options;
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>TextField</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
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
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("behavior")
        public String behavior;

        /**
         * <strong>example:</strong>
         * <p>TextField-K2AD4O5B</p>
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
        @NameInMap("targets")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets> targets;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
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
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("attendanceRule")
        public Integer attendanceRule;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("pushSwitch")
        public Integer pushSwitch;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
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
         * <strong>example:</strong>
         * <p>TextField-K2AD4O5B</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>单行输入框</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <strong>example:</strong>
         * <p>true</p>
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
         * <strong>example:</strong>
         * <p>添加</p>
         */
        @NameInMap("actionName")
        public String actionName;

        /**
         * <strong>example:</strong>
         * <p>top</p>
         */
        @NameInMap("align")
        public String align;

        /**
         * <strong>example:</strong>
         * <p>1234567</p>
         */
        @NameInMap("appId")
        public Long appId;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("asyncCondition")
        public Boolean asyncCondition;

        /**
         * <strong>example:</strong>
         * <p>请假</p>
         */
        @NameInMap("attendTypeLabel")
        public String attendTypeLabel;

        @NameInMap("behaviorLinkage")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsBehaviorLinkage> behaviorLinkage;

        /**
         * <strong>example:</strong>
         * <p>我的单行输入框</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <strong>example:</strong>
         * <p>hrm.xxxx</p>
         */
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("childFieldVisible")
        public java.util.Map<String, Boolean> childFieldVisible;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("choice")
        public Integer choice;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("commonBizType")
        public String commonBizType;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("disabled")
        public Boolean disabled;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("duration")
        public Boolean duration;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("durationLabel")
        public String durationLabel;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("eSign")
        public Boolean eSign;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("extract")
        public Boolean extract;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("fieldsInfo")
        public String fieldsInfo;

        /**
         * <strong>example:</strong>
         * <p>yyyy-MM-dd</p>
         */
        @NameInMap("format")
        public String format;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("formula")
        public String formula;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("hidden")
        public Boolean hidden;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("hiddenInApprovalDetail")
        public Boolean hiddenInApprovalDetail;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("hideLabel")
        public Boolean hideLabel;

        /**
         * <strong>example:</strong>
         * <p>&quot;[{&quot;name&quot;:&quot;\open&quot;}]&quot;</p>
         */
        @NameInMap("holidayOptions")
        public java.util.List<java.util.Map<String, String>> holidayOptions;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>TextField-K2AD4O5B</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>单行输入框</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("labelEditableFreeze")
        public Boolean labelEditableFreeze;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("link")
        public String link;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("mainTitle")
        public String mainTitle;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("notPrint")
        public String notPrint;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("notUpper")
        public String notUpper;

        @NameInMap("objOptions")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsObjOptions> objOptions;

        @NameInMap("options")
        public java.util.List<String> options;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("payEnable")
        public Boolean payEnable;

        /**
         * <strong>example:</strong>
         * <p>请输入文字</p>
         */
        @NameInMap("placeholder")
        public String placeholder;

        @NameInMap("push")
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsPush push;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("pushToAttendance")
        public Boolean pushToAttendance;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("pushToCalendar")
        public Integer pushToCalendar;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("required")
        public Boolean required;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("requiredEditableFreeze")
        public Boolean requiredEditableFreeze;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("showAttendOptions")
        public Boolean showAttendOptions;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("staffStatusEnabled")
        public Boolean staffStatusEnabled;

        @NameInMap("statField")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsPropsStatField> statField;

        /**
         * <strong>example:</strong>
         * <p>list</p>
         */
        @NameInMap("tableViewMode")
        public String tableViewMode;

        /**
         * <strong>example:</strong>
         * <p>天</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("useCalendar")
        public Boolean useCalendar;

        /**
         * <strong>example:</strong>
         * <p>true</p>
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

        public QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsProps setTableViewMode(String tableViewMode) {
            this.tableViewMode = tableViewMode;
            return this;
        }
        public String getTableViewMode() {
            return this.tableViewMode;
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
        @NameInMap("children")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItemsChildren> children;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>TextField</p>
         */
        @NameInMap("componentName")
        public String componentName;

        /**
         * <p>This parameter is required.</p>
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
         * <strong>example:</strong>
         * <p>common</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("items")
        public java.util.List<QuerySchemaByProcessCodeResponseBodyResultSchemaContentItems> items;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>示例模板</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("appType")
        public Integer appType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("appUuid")
        public String appUuid;

        /**
         * <strong>example:</strong>
         * <p>hrm.xxxx</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>26652461xxxx5992</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <strong>example:</strong>
         * <p>null</p>
         */
        @NameInMap("customSetting")
        public String customSetting;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("engineType")
        public Integer engineType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>PROC-17428B8C-6C60-470E-xxxx-64F1037AE067</p>
         */
        @NameInMap("formCode")
        public String formCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>FORM-28215C3E-00E3-4118-xxxx-4091F828AF2F</p>
         */
        @NameInMap("formUuid")
        public String formUuid;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-12-01T10:49Z</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-12-01T10:49Z</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <strong>example:</strong>
         * <p>null</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("listOrder")
        public Integer listOrder;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("memo")
        public String memo;

        /**
         * <strong>example:</strong>
         * <p>示例模板</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>25xxxx01</p>
         */
        @NameInMap("ownerIdType")
        public String ownerIdType;

        /**
         * <strong>example:</strong>
         * <p>inner</p>
         */
        @NameInMap("procType")
        public String procType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("schemaContent")
        public QuerySchemaByProcessCodeResponseBodyResultSchemaContent schemaContent;

        /**
         * <strong>example:</strong>
         * <p>PUBLISHED</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <strong>example:</strong>
         * <p>PRIVATE</p>
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
