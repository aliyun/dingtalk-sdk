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
        // 提示内容
        @NameInMap("commentDescription")
        public String commentDescription;

        // 评论对发起人不可见
        @NameInMap("commentHiddenForProposer")
        public Boolean commentHiddenForProposer;

        // 评论必填
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
        // 开启手写签名
        @NameInMap("handSignEnable")
        public Boolean handSignEnable;

        // 是否使用上次签名
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
        // 名称
        @NameInMap("name")
        public String name;

        // 类型
        @NameInMap("type")
        public String type;

        // 员工staffId/部门id
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
        // 是否允许代提交
        @NameInMap("enable")
        public Boolean enable;

        // 代提交人
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
        // 规则表达式
        @NameInMap("express")
        public String express;

        // 规则类型
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
        // 类型
        @NameInMap("type")
        public Integer type;

        // 员工staffId/部门id
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
        // 自定义摘要信息
        @NameInMap("abstractGenRule")
        public java.util.List<String> abstractGenRule;

        // 是否允许撤销
        @NameInMap("allowRevoke")
        public Boolean allowRevoke;

        // 是否允许加签
        @NameInMap("appendEnable")
        public Boolean appendEnable;

        // 如果审批人和发起人是同一个人，则去重
        @NameInMap("autoExecuteOriginatorTasks")
        public Boolean autoExecuteOriginatorTasks;

        // 流程表单业务标识
        @NameInMap("bizCategoryId")
        public String bizCategoryId;

        // 纯表单业务标识
        @NameInMap("bizType")
        public String bizType;

        // 评论配置
        @NameInMap("commentConf")
        public GetProcessConfigResponseBodyResultCommentConf commentConf;

        // 审批人自动去重
        @NameInMap("duplicateRemoval")
        public String duplicateRemoval;

        // 手写签名配置
        @NameInMap("handSignConf")
        public GetProcessConfigResponseBodyResultHandSignConf handSignConf;

        // 表单管理员
        @NameInMap("managers")
        public java.util.List<String> managers;

        // 表单名称
        @NameInMap("name")
        public String name;

        // 是否流程表单
        @NameInMap("processAppType")
        public Boolean processAppType;

        // 流程配置
        @NameInMap("processConfig")
        public String processConfig;

        // 是否静态流程
        @NameInMap("staticProc")
        public Boolean staticProc;

        // 代提交配置
        @NameInMap("substituteSubmitConf")
        public GetProcessConfigResponseBodyResultSubstituteSubmitConf substituteSubmitConf;

        // 自定义标题规则
        @NameInMap("titleGenRule")
        public GetProcessConfigResponseBodyResultTitleGenRule titleGenRule;

        // 模板可见性
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
