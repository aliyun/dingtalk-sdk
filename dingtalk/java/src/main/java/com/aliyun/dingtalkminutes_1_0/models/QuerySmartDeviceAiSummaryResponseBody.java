// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QuerySmartDeviceAiSummaryResponseBody extends TeaModel {
    @NameInMap("aiSummaryList")
    public java.util.List<QuerySmartDeviceAiSummaryResponseBodyAiSummaryList> aiSummaryList;

    @NameInMap("state")
    public Integer state;

    public static QuerySmartDeviceAiSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySmartDeviceAiSummaryResponseBody self = new QuerySmartDeviceAiSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySmartDeviceAiSummaryResponseBody setAiSummaryList(java.util.List<QuerySmartDeviceAiSummaryResponseBodyAiSummaryList> aiSummaryList) {
        this.aiSummaryList = aiSummaryList;
        return this;
    }
    public java.util.List<QuerySmartDeviceAiSummaryResponseBodyAiSummaryList> getAiSummaryList() {
        return this.aiSummaryList;
    }

    public QuerySmartDeviceAiSummaryResponseBody setState(Integer state) {
        this.state = state;
        return this;
    }
    public Integer getState() {
        return this.state;
    }

    public static class QuerySmartDeviceAiSummaryResponseBodyAiSummaryList extends TeaModel {
        @NameInMap("agentId")
        public String agentId;

        @NameInMap("aiSceneRuleAvatarUrl")
        public String aiSceneRuleAvatarUrl;

        @NameInMap("creatorUnionId")
        public String creatorUnionId;

        @NameInMap("instanceId")
        public String instanceId;

        @NameInMap("openFileId")
        public String openFileId;

        @NameInMap("order")
        public Integer order;

        @NameInMap("summary")
        public String summary;

        @NameInMap("templateId")
        public String templateId;

        @NameInMap("title")
        public String title;

        public static QuerySmartDeviceAiSummaryResponseBodyAiSummaryList build(java.util.Map<String, ?> map) throws Exception {
            QuerySmartDeviceAiSummaryResponseBodyAiSummaryList self = new QuerySmartDeviceAiSummaryResponseBodyAiSummaryList();
            return TeaModel.build(map, self);
        }

        public QuerySmartDeviceAiSummaryResponseBodyAiSummaryList setAgentId(String agentId) {
            this.agentId = agentId;
            return this;
        }
        public String getAgentId() {
            return this.agentId;
        }

        public QuerySmartDeviceAiSummaryResponseBodyAiSummaryList setAiSceneRuleAvatarUrl(String aiSceneRuleAvatarUrl) {
            this.aiSceneRuleAvatarUrl = aiSceneRuleAvatarUrl;
            return this;
        }
        public String getAiSceneRuleAvatarUrl() {
            return this.aiSceneRuleAvatarUrl;
        }

        public QuerySmartDeviceAiSummaryResponseBodyAiSummaryList setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public QuerySmartDeviceAiSummaryResponseBodyAiSummaryList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public QuerySmartDeviceAiSummaryResponseBodyAiSummaryList setOpenFileId(String openFileId) {
            this.openFileId = openFileId;
            return this;
        }
        public String getOpenFileId() {
            return this.openFileId;
        }

        public QuerySmartDeviceAiSummaryResponseBodyAiSummaryList setOrder(Integer order) {
            this.order = order;
            return this;
        }
        public Integer getOrder() {
            return this.order;
        }

        public QuerySmartDeviceAiSummaryResponseBodyAiSummaryList setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public QuerySmartDeviceAiSummaryResponseBodyAiSummaryList setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public QuerySmartDeviceAiSummaryResponseBodyAiSummaryList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
