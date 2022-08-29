// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryIntegratedTodoTaskResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("taskPage")
    public QueryIntegratedTodoTaskResponseBodyTaskPage taskPage;

    public static QueryIntegratedTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryIntegratedTodoTaskResponseBody self = new QueryIntegratedTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryIntegratedTodoTaskResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryIntegratedTodoTaskResponseBody setTaskPage(QueryIntegratedTodoTaskResponseBodyTaskPage taskPage) {
        this.taskPage = taskPage;
        return this;
    }
    public QueryIntegratedTodoTaskResponseBodyTaskPage getTaskPage() {
        return this.taskPage;
    }

    public static class QueryIntegratedTodoTaskResponseBodyTaskPageList extends TeaModel {
        // 待办组ID，需要在调用创建流程中心集成任务接口时，主动设置该值。
        @NameInMap("activityId")
        public String activityId;

        // OA审批任务创建时间
        @NameInMap("createTime")
        public Long createTime;

        // OA审批任务完成时间
        @NameInMap("finishTime")
        public String finishTime;

        // 流程实例ID
        @NameInMap("processInstanceId")
        public String processInstanceId;

        // 任务处理结果：agree 或 refuse
        @NameInMap("result")
        public String result;

        // 任务状态
        @NameInMap("status")
        public String status;

        // OA审批任务ID
        @NameInMap("taskId")
        public Long taskId;

        // OA审批任务执行人的用户ID
        @NameInMap("userId")
        public String userId;

        public static QueryIntegratedTodoTaskResponseBodyTaskPageList build(java.util.Map<String, ?> map) throws Exception {
            QueryIntegratedTodoTaskResponseBodyTaskPageList self = new QueryIntegratedTodoTaskResponseBodyTaskPageList();
            return TeaModel.build(map, self);
        }

        public QueryIntegratedTodoTaskResponseBodyTaskPageList setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public QueryIntegratedTodoTaskResponseBodyTaskPageList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryIntegratedTodoTaskResponseBodyTaskPageList setFinishTime(String finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public String getFinishTime() {
            return this.finishTime;
        }

        public QueryIntegratedTodoTaskResponseBodyTaskPageList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public QueryIntegratedTodoTaskResponseBodyTaskPageList setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public QueryIntegratedTodoTaskResponseBodyTaskPageList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryIntegratedTodoTaskResponseBodyTaskPageList setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public QueryIntegratedTodoTaskResponseBodyTaskPageList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryIntegratedTodoTaskResponseBodyTaskPage extends TeaModel {
        // 是否还有下一页
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<QueryIntegratedTodoTaskResponseBodyTaskPageList> list;

        public static QueryIntegratedTodoTaskResponseBodyTaskPage build(java.util.Map<String, ?> map) throws Exception {
            QueryIntegratedTodoTaskResponseBodyTaskPage self = new QueryIntegratedTodoTaskResponseBodyTaskPage();
            return TeaModel.build(map, self);
        }

        public QueryIntegratedTodoTaskResponseBodyTaskPage setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public QueryIntegratedTodoTaskResponseBodyTaskPage setList(java.util.List<QueryIntegratedTodoTaskResponseBodyTaskPageList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<QueryIntegratedTodoTaskResponseBodyTaskPageList> getList() {
            return this.list;
        }

    }

}
