// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetProcessConfigResponseBody extends TeaModel {
    @NameInMap("result")
    public GetProcessConfigResponseBodyResult result;

    public static GetProcessConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProcessConfigResponseBody self = new GetProcessConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProcessConfigResponseBody setResult(GetProcessConfigResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetProcessConfigResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetProcessConfigResponseBodyResultCommentConf extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>评论描述</p>
         */
        @NameInMap("commentDescription")
        public String commentDescription;

        @NameInMap("commentHiddenForProposer")
        public Boolean commentHiddenForProposer;

        @NameInMap("commentRequired")
        public Boolean commentRequired;

        public static GetProcessConfigResponseBodyResultCommentConf build(java.util.Map<String, ?> map) throws Exception {
            GetProcessConfigResponseBodyResultCommentConf self = new GetProcessConfigResponseBodyResultCommentConf();
            return TeaModel.build(map, self);
        }

        public GetProcessConfigResponseBodyResultCommentConf setCommentDescription(String commentDescription) {
            this.commentDescription = commentDescription;
            return this;
        }
        public String getCommentDescription() {
            return this.commentDescription;
        }

        public GetProcessConfigResponseBodyResultCommentConf setCommentHiddenForProposer(Boolean commentHiddenForProposer) {
            this.commentHiddenForProposer = commentHiddenForProposer;
            return this;
        }
        public Boolean getCommentHiddenForProposer() {
            return this.commentHiddenForProposer;
        }

        public GetProcessConfigResponseBodyResultCommentConf setCommentRequired(Boolean commentRequired) {
            this.commentRequired = commentRequired;
            return this;
        }
        public Boolean getCommentRequired() {
            return this.commentRequired;
        }

    }

    public static class GetProcessConfigResponseBodyResultHandSignConf extends TeaModel {
        @NameInMap("handSignEnable")
        public Boolean handSignEnable;

        @NameInMap("resignEnable")
        public Boolean resignEnable;

        public static GetProcessConfigResponseBodyResultHandSignConf build(java.util.Map<String, ?> map) throws Exception {
            GetProcessConfigResponseBodyResultHandSignConf self = new GetProcessConfigResponseBodyResultHandSignConf();
            return TeaModel.build(map, self);
        }

        public GetProcessConfigResponseBodyResultHandSignConf setHandSignEnable(Boolean handSignEnable) {
            this.handSignEnable = handSignEnable;
            return this;
        }
        public Boolean getHandSignEnable() {
            return this.handSignEnable;
        }

        public GetProcessConfigResponseBodyResultHandSignConf setResignEnable(Boolean resignEnable) {
            this.resignEnable = resignEnable;
            return this;
        }
        public Boolean getResignEnable() {
            return this.resignEnable;
        }

    }

    public static class GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>钉三多</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>approval</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p>manager1234</p>
         */
        @NameInMap("value")
        public String value;

        public static GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList build(java.util.Map<String, ?> map) throws Exception {
            GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList self = new GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList();
            return TeaModel.build(map, self);
        }

        public GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetProcessConfigResponseBodyResultSubstituteSubmitConf extends TeaModel {
        @NameInMap("enable")
        public Boolean enable;

        @NameInMap("submitterList")
        public java.util.List<GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList> submitterList;

        public static GetProcessConfigResponseBodyResultSubstituteSubmitConf build(java.util.Map<String, ?> map) throws Exception {
            GetProcessConfigResponseBodyResultSubstituteSubmitConf self = new GetProcessConfigResponseBodyResultSubstituteSubmitConf();
            return TeaModel.build(map, self);
        }

        public GetProcessConfigResponseBodyResultSubstituteSubmitConf setEnable(Boolean enable) {
            this.enable = enable;
            return this;
        }
        public Boolean getEnable() {
            return this.enable;
        }

        public GetProcessConfigResponseBodyResultSubstituteSubmitConf setSubmitterList(java.util.List<GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList> submitterList) {
            this.submitterList = submitterList;
            return this;
        }
        public java.util.List<GetProcessConfigResponseBodyResultSubstituteSubmitConfSubmitterList> getSubmitterList() {
            return this.submitterList;
        }

    }

    public static class GetProcessConfigResponseBodyResultTitleGenRule extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>#{originator}#{formName}#{createTime}</p>
         */
        @NameInMap("express")
        public String express;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("type")
        public Integer type;

        public static GetProcessConfigResponseBodyResultTitleGenRule build(java.util.Map<String, ?> map) throws Exception {
            GetProcessConfigResponseBodyResultTitleGenRule self = new GetProcessConfigResponseBodyResultTitleGenRule();
            return TeaModel.build(map, self);
        }

        public GetProcessConfigResponseBodyResultTitleGenRule setExpress(String express) {
            this.express = express;
            return this;
        }
        public String getExpress() {
            return this.express;
        }

        public GetProcessConfigResponseBodyResultTitleGenRule setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

    public static class GetProcessConfigResponseBodyResultVisibility extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("type")
        public Integer type;

        /**
         * <strong>example:</strong>
         * <p>manager345</p>
         */
        @NameInMap("value")
        public String value;

        public static GetProcessConfigResponseBodyResultVisibility build(java.util.Map<String, ?> map) throws Exception {
            GetProcessConfigResponseBodyResultVisibility self = new GetProcessConfigResponseBodyResultVisibility();
            return TeaModel.build(map, self);
        }

        public GetProcessConfigResponseBodyResultVisibility setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

        public GetProcessConfigResponseBodyResultVisibility setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetProcessConfigResponseBodyResult extends TeaModel {
        @NameInMap("abstractGenRule")
        public java.util.List<String> abstractGenRule;

        /**
         * <strong>example:</strong>
         * <p>{&quot;sid_instStart&quot;:[{&quot;fieldId&quot;:&quot;TextField-K2AD4O5B&quot;,&quot;fieldBehavior&quot;:&quot;HIDDEN&quot;,&quot;componentName&quot;:&quot;TextField&quot;,&quot;disableBehaviors&quot;:[]}],&quot;1918_5cd3&quot;:[{&quot;fieldId&quot;:&quot;TextField-K2AD4O5B&quot;,&quot;fieldBehavior&quot;:&quot;HIDDEN&quot;,&quot;componentName&quot;:&quot;TextField&quot;,&quot;disableBehaviors&quot;:[]}],&quot;d01c_a677&quot;:[{&quot;fieldId&quot;:&quot;TextField-K2AD4O5B&quot;,&quot;fieldBehavior&quot;:&quot;NORMAL&quot;,&quot;componentName&quot;:&quot;TextField&quot;,&quot;disableBehaviors&quot;:[]}]}</p>
         */
        @NameInMap("activityAuth")
        public String activityAuth;

        @NameInMap("allowRevoke")
        public Boolean allowRevoke;

        @NameInMap("appendEnable")
        public Boolean appendEnable;

        @NameInMap("autoExecuteOriginatorTasks")
        public Boolean autoExecuteOriginatorTasks;

        /**
         * <strong>example:</strong>
         * <p>alitrip.business</p>
         */
        @NameInMap("bizCategoryId")
        public String bizCategoryId;

        /**
         * <strong>example:</strong>
         * <p>crm_customer</p>
         */
        @NameInMap("bizType")
        public String bizType;

        @NameInMap("commentConf")
        public GetProcessConfigResponseBodyResultCommentConf commentConf;

        /**
         * <strong>example:</strong>
         * <p>continuousFirst</p>
         */
        @NameInMap("duplicateRemoval")
        public String duplicateRemoval;

        /**
         * <strong>example:</strong>
         * <p>{&quot;items&quot;:[]}</p>
         */
        @NameInMap("formSchema")
        public String formSchema;

        @NameInMap("handSignConf")
        public GetProcessConfigResponseBodyResultHandSignConf handSignConf;

        @NameInMap("managers")
        public java.util.List<String> managers;

        /**
         * <strong>example:</strong>
         * <p>模板名称</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("processAppType")
        public Boolean processAppType;

        /**
         * <strong>example:</strong>
         * <p>{&quot;type&quot;:&quot;&quot;,&quot;properties&quot;:{},&quot;childNode&quot;:{}}</p>
         */
        @NameInMap("processConfig")
        public String processConfig;

        @NameInMap("staticProc")
        public Boolean staticProc;

        @NameInMap("substituteSubmitConf")
        public GetProcessConfigResponseBodyResultSubstituteSubmitConf substituteSubmitConf;

        @NameInMap("titleGenRule")
        public GetProcessConfigResponseBodyResultTitleGenRule titleGenRule;

        @NameInMap("visibility")
        public java.util.List<GetProcessConfigResponseBodyResultVisibility> visibility;

        public static GetProcessConfigResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetProcessConfigResponseBodyResult self = new GetProcessConfigResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetProcessConfigResponseBodyResult setAbstractGenRule(java.util.List<String> abstractGenRule) {
            this.abstractGenRule = abstractGenRule;
            return this;
        }
        public java.util.List<String> getAbstractGenRule() {
            return this.abstractGenRule;
        }

        public GetProcessConfigResponseBodyResult setActivityAuth(String activityAuth) {
            this.activityAuth = activityAuth;
            return this;
        }
        public String getActivityAuth() {
            return this.activityAuth;
        }

        public GetProcessConfigResponseBodyResult setAllowRevoke(Boolean allowRevoke) {
            this.allowRevoke = allowRevoke;
            return this;
        }
        public Boolean getAllowRevoke() {
            return this.allowRevoke;
        }

        public GetProcessConfigResponseBodyResult setAppendEnable(Boolean appendEnable) {
            this.appendEnable = appendEnable;
            return this;
        }
        public Boolean getAppendEnable() {
            return this.appendEnable;
        }

        public GetProcessConfigResponseBodyResult setAutoExecuteOriginatorTasks(Boolean autoExecuteOriginatorTasks) {
            this.autoExecuteOriginatorTasks = autoExecuteOriginatorTasks;
            return this;
        }
        public Boolean getAutoExecuteOriginatorTasks() {
            return this.autoExecuteOriginatorTasks;
        }

        public GetProcessConfigResponseBodyResult setBizCategoryId(String bizCategoryId) {
            this.bizCategoryId = bizCategoryId;
            return this;
        }
        public String getBizCategoryId() {
            return this.bizCategoryId;
        }

        public GetProcessConfigResponseBodyResult setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public GetProcessConfigResponseBodyResult setCommentConf(GetProcessConfigResponseBodyResultCommentConf commentConf) {
            this.commentConf = commentConf;
            return this;
        }
        public GetProcessConfigResponseBodyResultCommentConf getCommentConf() {
            return this.commentConf;
        }

        public GetProcessConfigResponseBodyResult setDuplicateRemoval(String duplicateRemoval) {
            this.duplicateRemoval = duplicateRemoval;
            return this;
        }
        public String getDuplicateRemoval() {
            return this.duplicateRemoval;
        }

        public GetProcessConfigResponseBodyResult setFormSchema(String formSchema) {
            this.formSchema = formSchema;
            return this;
        }
        public String getFormSchema() {
            return this.formSchema;
        }

        public GetProcessConfigResponseBodyResult setHandSignConf(GetProcessConfigResponseBodyResultHandSignConf handSignConf) {
            this.handSignConf = handSignConf;
            return this;
        }
        public GetProcessConfigResponseBodyResultHandSignConf getHandSignConf() {
            return this.handSignConf;
        }

        public GetProcessConfigResponseBodyResult setManagers(java.util.List<String> managers) {
            this.managers = managers;
            return this;
        }
        public java.util.List<String> getManagers() {
            return this.managers;
        }

        public GetProcessConfigResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetProcessConfigResponseBodyResult setProcessAppType(Boolean processAppType) {
            this.processAppType = processAppType;
            return this;
        }
        public Boolean getProcessAppType() {
            return this.processAppType;
        }

        public GetProcessConfigResponseBodyResult setProcessConfig(String processConfig) {
            this.processConfig = processConfig;
            return this;
        }
        public String getProcessConfig() {
            return this.processConfig;
        }

        public GetProcessConfigResponseBodyResult setStaticProc(Boolean staticProc) {
            this.staticProc = staticProc;
            return this;
        }
        public Boolean getStaticProc() {
            return this.staticProc;
        }

        public GetProcessConfigResponseBodyResult setSubstituteSubmitConf(GetProcessConfigResponseBodyResultSubstituteSubmitConf substituteSubmitConf) {
            this.substituteSubmitConf = substituteSubmitConf;
            return this;
        }
        public GetProcessConfigResponseBodyResultSubstituteSubmitConf getSubstituteSubmitConf() {
            return this.substituteSubmitConf;
        }

        public GetProcessConfigResponseBodyResult setTitleGenRule(GetProcessConfigResponseBodyResultTitleGenRule titleGenRule) {
            this.titleGenRule = titleGenRule;
            return this;
        }
        public GetProcessConfigResponseBodyResultTitleGenRule getTitleGenRule() {
            return this.titleGenRule;
        }

        public GetProcessConfigResponseBodyResult setVisibility(java.util.List<GetProcessConfigResponseBodyResultVisibility> visibility) {
            this.visibility = visibility;
            return this;
        }
        public java.util.List<GetProcessConfigResponseBodyResultVisibility> getVisibility() {
            return this.visibility;
        }

    }

}
