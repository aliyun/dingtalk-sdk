// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryAllProcessInstancesResponseBody extends TeaModel {
    // result
    @NameInMap("result")
    public QueryAllProcessInstancesResponseBodyResult result;

    public static QueryAllProcessInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllProcessInstancesResponseBody self = new QueryAllProcessInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllProcessInstancesResponseBody setResult(QueryAllProcessInstancesResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryAllProcessInstancesResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryAllProcessInstancesResponseBodyResultListFormComponentValues extends TeaModel {
        // 控件名称
        @NameInMap("name")
        public String name;

        // 控件id
        @NameInMap("id")
        public String id;

        // 控件数据
        @NameInMap("value")
        public String value;

        // 控件扩展数据
        @NameInMap("extValue")
        public String extValue;

        public static QueryAllProcessInstancesResponseBodyResultListFormComponentValues build(java.util.Map<String, ?> map) throws Exception {
            QueryAllProcessInstancesResponseBodyResultListFormComponentValues self = new QueryAllProcessInstancesResponseBodyResultListFormComponentValues();
            return TeaModel.build(map, self);
        }

        public QueryAllProcessInstancesResponseBodyResultListFormComponentValues setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryAllProcessInstancesResponseBodyResultListFormComponentValues setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public QueryAllProcessInstancesResponseBodyResultListFormComponentValues setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public QueryAllProcessInstancesResponseBodyResultListFormComponentValues setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

    }

    public static class QueryAllProcessInstancesResponseBodyResultList extends TeaModel {
        // 流程实例ID
        @NameInMap("processInstanceId")
        public String processInstanceId;

        // 主单实例Id
        @NameInMap("mainProcessInstanceId")
        public String mainProcessInstanceId;

        // 审批结束时间
        @NameInMap("finishTime")
        public Long finishTime;

        // 附属单信息
        @NameInMap("attachedProcessInstanceIds")
        public String attachedProcessInstanceIds;

        // 审批单编号
        @NameInMap("businessId")
        public String businessId;

        // 审批单标题
        @NameInMap("title")
        public String title;

        // 发起人部门id
        @NameInMap("originatorDeptId")
        public String originatorDeptId;

        // 审批结果
        @NameInMap("result")
        public String result;

        // 审批单创建时间
        @NameInMap("createTime")
        public Long createTime;

        // 发起者userId
        @NameInMap("originatorUserid")
        public String originatorUserid;

        // 审批单状态
        @NameInMap("status")
        public String status;

        @NameInMap("formComponentValues")
        public java.util.List<QueryAllProcessInstancesResponseBodyResultListFormComponentValues> formComponentValues;

        public static QueryAllProcessInstancesResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            QueryAllProcessInstancesResponseBodyResultList self = new QueryAllProcessInstancesResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public QueryAllProcessInstancesResponseBodyResultList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public QueryAllProcessInstancesResponseBodyResultList setMainProcessInstanceId(String mainProcessInstanceId) {
            this.mainProcessInstanceId = mainProcessInstanceId;
            return this;
        }
        public String getMainProcessInstanceId() {
            return this.mainProcessInstanceId;
        }

        public QueryAllProcessInstancesResponseBodyResultList setFinishTime(Long finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public Long getFinishTime() {
            return this.finishTime;
        }

        public QueryAllProcessInstancesResponseBodyResultList setAttachedProcessInstanceIds(String attachedProcessInstanceIds) {
            this.attachedProcessInstanceIds = attachedProcessInstanceIds;
            return this;
        }
        public String getAttachedProcessInstanceIds() {
            return this.attachedProcessInstanceIds;
        }

        public QueryAllProcessInstancesResponseBodyResultList setBusinessId(String businessId) {
            this.businessId = businessId;
            return this;
        }
        public String getBusinessId() {
            return this.businessId;
        }

        public QueryAllProcessInstancesResponseBodyResultList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public QueryAllProcessInstancesResponseBodyResultList setOriginatorDeptId(String originatorDeptId) {
            this.originatorDeptId = originatorDeptId;
            return this;
        }
        public String getOriginatorDeptId() {
            return this.originatorDeptId;
        }

        public QueryAllProcessInstancesResponseBodyResultList setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public QueryAllProcessInstancesResponseBodyResultList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryAllProcessInstancesResponseBodyResultList setOriginatorUserid(String originatorUserid) {
            this.originatorUserid = originatorUserid;
            return this;
        }
        public String getOriginatorUserid() {
            return this.originatorUserid;
        }

        public QueryAllProcessInstancesResponseBodyResultList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryAllProcessInstancesResponseBodyResultList setFormComponentValues(java.util.List<QueryAllProcessInstancesResponseBodyResultListFormComponentValues> formComponentValues) {
            this.formComponentValues = formComponentValues;
            return this;
        }
        public java.util.List<QueryAllProcessInstancesResponseBodyResultListFormComponentValues> getFormComponentValues() {
            return this.formComponentValues;
        }

    }

    public static class QueryAllProcessInstancesResponseBodyResult extends TeaModel {
        // 下次获取数据的游标
        @NameInMap("nextToken")
        public String nextToken;

        // 是否有更多数据
        @NameInMap("hasMore")
        public Boolean hasMore;

        // 总数
        @NameInMap("maxResults")
        public Long maxResults;

        @NameInMap("list")
        public java.util.List<QueryAllProcessInstancesResponseBodyResultList> list;

        public static QueryAllProcessInstancesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryAllProcessInstancesResponseBodyResult self = new QueryAllProcessInstancesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryAllProcessInstancesResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public QueryAllProcessInstancesResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public QueryAllProcessInstancesResponseBodyResult setMaxResults(Long maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Long getMaxResults() {
            return this.maxResults;
        }

        public QueryAllProcessInstancesResponseBodyResult setList(java.util.List<QueryAllProcessInstancesResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<QueryAllProcessInstancesResponseBodyResultList> getList() {
            return this.list;
        }

    }

}
