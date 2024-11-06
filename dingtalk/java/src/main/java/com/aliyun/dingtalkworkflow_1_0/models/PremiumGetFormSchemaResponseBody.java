// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetFormSchemaResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public PremiumGetFormSchemaResponseBodyResult result;

    public static PremiumGetFormSchemaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetFormSchemaResponseBody self = new PremiumGetFormSchemaResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumGetFormSchemaResponseBody setResult(PremiumGetFormSchemaResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumGetFormSchemaResponseBodyResult getResult() {
        return this.result;
    }

    public static class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps extends TeaModel {
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

        public static PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps self = new PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps setOptions(java.util.List<String> options) {
            this.options = options;
            return this;
        }
        public java.util.List<String> getOptions() {
            return this.options;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

    }

    public static class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren extends TeaModel {
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
        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps props;

        public static PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren self = new PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren setProps(PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps props) {
            this.props = props;
            return this;
        }
        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildrenProps getProps() {
            return this.props;
        }

    }

    public static class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets extends TeaModel {
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

        public static PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets self = new PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets setBehavior(String behavior) {
            this.behavior = behavior;
            return this;
        }
        public String getBehavior() {
            return this.behavior;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets setFieldId(String fieldId) {
            this.fieldId = fieldId;
            return this;
        }
        public String getFieldId() {
            return this.fieldId;
        }

    }

    public static class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage extends TeaModel {
        @NameInMap("targets")
        public java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets> targets;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("value")
        public String value;

        public static PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage self = new PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage setTargets(java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets> targets) {
            this.targets = targets;
            return this;
        }
        public java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkageTargets> getTargets() {
            return this.targets;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsObjOptions extends TeaModel {
        @NameInMap("value")
        public String value;

        public static PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsObjOptions build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsObjOptions self = new PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsObjOptions();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsObjOptions setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush extends TeaModel {
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

        public static PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush self = new PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush setAttendanceRule(Integer attendanceRule) {
            this.attendanceRule = attendanceRule;
            return this;
        }
        public Integer getAttendanceRule() {
            return this.attendanceRule;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush setPushSwitch(Integer pushSwitch) {
            this.pushSwitch = pushSwitch;
            return this;
        }
        public Integer getPushSwitch() {
            return this.pushSwitch;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush setPushTag(String pushTag) {
            this.pushTag = pushTag;
            return this;
        }
        public String getPushTag() {
            return this.pushTag;
        }

    }

    public static class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField extends TeaModel {
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

        public static PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField self = new PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField setUpper(Boolean upper) {
            this.upper = upper;
            return this;
        }
        public Boolean getUpper() {
            return this.upper;
        }

    }

    public static class PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps extends TeaModel {
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
        public java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage> behaviorLinkage;

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
        public java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsObjOptions> objOptions;

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
        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush push;

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
        public java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField> statField;

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

        public static PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps self = new PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setActionName(String actionName) {
            this.actionName = actionName;
            return this;
        }
        public String getActionName() {
            return this.actionName;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setAlign(String align) {
            this.align = align;
            return this;
        }
        public String getAlign() {
            return this.align;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setAppId(Long appId) {
            this.appId = appId;
            return this;
        }
        public Long getAppId() {
            return this.appId;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setAsyncCondition(Boolean asyncCondition) {
            this.asyncCondition = asyncCondition;
            return this;
        }
        public Boolean getAsyncCondition() {
            return this.asyncCondition;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setAttendTypeLabel(String attendTypeLabel) {
            this.attendTypeLabel = attendTypeLabel;
            return this;
        }
        public String getAttendTypeLabel() {
            return this.attendTypeLabel;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setBehaviorLinkage(java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage> behaviorLinkage) {
            this.behaviorLinkage = behaviorLinkage;
            return this;
        }
        public java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsBehaviorLinkage> getBehaviorLinkage() {
            return this.behaviorLinkage;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setChildFieldVisible(java.util.Map<String, Boolean> childFieldVisible) {
            this.childFieldVisible = childFieldVisible;
            return this;
        }
        public java.util.Map<String, Boolean> getChildFieldVisible() {
            return this.childFieldVisible;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setChoice(Integer choice) {
            this.choice = choice;
            return this;
        }
        public Integer getChoice() {
            return this.choice;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setCommonBizType(String commonBizType) {
            this.commonBizType = commonBizType;
            return this;
        }
        public String getCommonBizType() {
            return this.commonBizType;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setDisabled(Boolean disabled) {
            this.disabled = disabled;
            return this;
        }
        public Boolean getDisabled() {
            return this.disabled;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setDuration(Boolean duration) {
            this.duration = duration;
            return this;
        }
        public Boolean getDuration() {
            return this.duration;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setDurationLabel(String durationLabel) {
            this.durationLabel = durationLabel;
            return this;
        }
        public String getDurationLabel() {
            return this.durationLabel;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setESign(Boolean eSign) {
            this.eSign = eSign;
            return this;
        }
        public Boolean getESign() {
            return this.eSign;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setExtract(Boolean extract) {
            this.extract = extract;
            return this;
        }
        public Boolean getExtract() {
            return this.extract;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setFieldsInfo(String fieldsInfo) {
            this.fieldsInfo = fieldsInfo;
            return this;
        }
        public String getFieldsInfo() {
            return this.fieldsInfo;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setFormula(String formula) {
            this.formula = formula;
            return this;
        }
        public String getFormula() {
            return this.formula;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setHidden(Boolean hidden) {
            this.hidden = hidden;
            return this;
        }
        public Boolean getHidden() {
            return this.hidden;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setHiddenInApprovalDetail(Boolean hiddenInApprovalDetail) {
            this.hiddenInApprovalDetail = hiddenInApprovalDetail;
            return this;
        }
        public Boolean getHiddenInApprovalDetail() {
            return this.hiddenInApprovalDetail;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setHideLabel(Boolean hideLabel) {
            this.hideLabel = hideLabel;
            return this;
        }
        public Boolean getHideLabel() {
            return this.hideLabel;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setHolidayOptions(java.util.List<java.util.Map<String, String>> holidayOptions) {
            this.holidayOptions = holidayOptions;
            return this;
        }
        public java.util.List<java.util.Map<String, String>> getHolidayOptions() {
            return this.holidayOptions;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setLabelEditableFreeze(Boolean labelEditableFreeze) {
            this.labelEditableFreeze = labelEditableFreeze;
            return this;
        }
        public Boolean getLabelEditableFreeze() {
            return this.labelEditableFreeze;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setLink(String link) {
            this.link = link;
            return this;
        }
        public String getLink() {
            return this.link;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setMainTitle(String mainTitle) {
            this.mainTitle = mainTitle;
            return this;
        }
        public String getMainTitle() {
            return this.mainTitle;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setNotPrint(String notPrint) {
            this.notPrint = notPrint;
            return this;
        }
        public String getNotPrint() {
            return this.notPrint;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setNotUpper(String notUpper) {
            this.notUpper = notUpper;
            return this;
        }
        public String getNotUpper() {
            return this.notUpper;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setObjOptions(java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsObjOptions> objOptions) {
            this.objOptions = objOptions;
            return this;
        }
        public java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsObjOptions> getObjOptions() {
            return this.objOptions;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setOptions(java.util.List<String> options) {
            this.options = options;
            return this;
        }
        public java.util.List<String> getOptions() {
            return this.options;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setPayEnable(Boolean payEnable) {
            this.payEnable = payEnable;
            return this;
        }
        public Boolean getPayEnable() {
            return this.payEnable;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setPlaceholder(String placeholder) {
            this.placeholder = placeholder;
            return this;
        }
        public String getPlaceholder() {
            return this.placeholder;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setPush(PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush push) {
            this.push = push;
            return this;
        }
        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsPush getPush() {
            return this.push;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setPushToAttendance(Boolean pushToAttendance) {
            this.pushToAttendance = pushToAttendance;
            return this;
        }
        public Boolean getPushToAttendance() {
            return this.pushToAttendance;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setPushToCalendar(Integer pushToCalendar) {
            this.pushToCalendar = pushToCalendar;
            return this;
        }
        public Integer getPushToCalendar() {
            return this.pushToCalendar;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setRequired(Boolean required) {
            this.required = required;
            return this;
        }
        public Boolean getRequired() {
            return this.required;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setRequiredEditableFreeze(Boolean requiredEditableFreeze) {
            this.requiredEditableFreeze = requiredEditableFreeze;
            return this;
        }
        public Boolean getRequiredEditableFreeze() {
            return this.requiredEditableFreeze;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setShowAttendOptions(Boolean showAttendOptions) {
            this.showAttendOptions = showAttendOptions;
            return this;
        }
        public Boolean getShowAttendOptions() {
            return this.showAttendOptions;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setStaffStatusEnabled(Boolean staffStatusEnabled) {
            this.staffStatusEnabled = staffStatusEnabled;
            return this;
        }
        public Boolean getStaffStatusEnabled() {
            return this.staffStatusEnabled;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setStatField(java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField> statField) {
            this.statField = statField;
            return this;
        }
        public java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsPropsStatField> getStatField() {
            return this.statField;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setTableViewMode(String tableViewMode) {
            this.tableViewMode = tableViewMode;
            return this;
        }
        public String getTableViewMode() {
            return this.tableViewMode;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setUseCalendar(Boolean useCalendar) {
            this.useCalendar = useCalendar;
            return this;
        }
        public Boolean getUseCalendar() {
            return this.useCalendar;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps setVerticalPrint(Boolean verticalPrint) {
            this.verticalPrint = verticalPrint;
            return this;
        }
        public Boolean getVerticalPrint() {
            return this.verticalPrint;
        }

    }

    public static class PremiumGetFormSchemaResponseBodyResultSchemaContentItems extends TeaModel {
        @NameInMap("children")
        public java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren> children;

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
        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps props;

        public static PremiumGetFormSchemaResponseBodyResultSchemaContentItems build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormSchemaResponseBodyResultSchemaContentItems self = new PremiumGetFormSchemaResponseBodyResultSchemaContentItems();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItems setChildren(java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren> children) {
            this.children = children;
            return this;
        }
        public java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItemsChildren> getChildren() {
            return this.children;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItems setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContentItems setProps(PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps props) {
            this.props = props;
            return this;
        }
        public PremiumGetFormSchemaResponseBodyResultSchemaContentItemsProps getProps() {
            return this.props;
        }

    }

    public static class PremiumGetFormSchemaResponseBodyResultSchemaContent extends TeaModel {
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
        public java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItems> items;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>示例模板</p>
         */
        @NameInMap("title")
        public String title;

        public static PremiumGetFormSchemaResponseBodyResultSchemaContent build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormSchemaResponseBodyResultSchemaContent self = new PremiumGetFormSchemaResponseBodyResultSchemaContent();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContent setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContent setItems(java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<PremiumGetFormSchemaResponseBodyResultSchemaContentItems> getItems() {
            return this.items;
        }

        public PremiumGetFormSchemaResponseBodyResultSchemaContent setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class PremiumGetFormSchemaResponseBodyResult extends TeaModel {
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
         * <p>26652461xxxx5992</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

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
         */
        @NameInMap("schemaContent")
        public PremiumGetFormSchemaResponseBodyResultSchemaContent schemaContent;

        /**
         * <strong>example:</strong>
         * <p>PUBLISHED</p>
         */
        @NameInMap("status")
        public String status;

        public static PremiumGetFormSchemaResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetFormSchemaResponseBodyResult self = new PremiumGetFormSchemaResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumGetFormSchemaResponseBodyResult setAppType(Integer appType) {
            this.appType = appType;
            return this;
        }
        public Integer getAppType() {
            return this.appType;
        }

        public PremiumGetFormSchemaResponseBodyResult setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public PremiumGetFormSchemaResponseBodyResult setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public PremiumGetFormSchemaResponseBodyResult setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public PremiumGetFormSchemaResponseBodyResult setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public PremiumGetFormSchemaResponseBodyResult setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public PremiumGetFormSchemaResponseBodyResult setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public PremiumGetFormSchemaResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PremiumGetFormSchemaResponseBodyResult setSchemaContent(PremiumGetFormSchemaResponseBodyResultSchemaContent schemaContent) {
            this.schemaContent = schemaContent;
            return this;
        }
        public PremiumGetFormSchemaResponseBodyResultSchemaContent getSchemaContent() {
            return this.schemaContent;
        }

        public PremiumGetFormSchemaResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
