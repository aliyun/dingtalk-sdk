// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryIntegratedTodoTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryIntegratedTodoTaskResponseBodyResult result;

    public static QueryIntegratedTodoTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryIntegratedTodoTaskResponseBody self = new QueryIntegratedTodoTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryIntegratedTodoTaskResponseBody setResult(QueryIntegratedTodoTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryIntegratedTodoTaskResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryIntegratedTodoTaskResponseBodyResultList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>act_0001</p>
         */
        @NameInMap("activityId")
        public String activityId;

        /**
         * <strong>example:</strong>
         * <p>2022-10-17T15:12Z</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>2022-10-17T15:12Z</p>
         */
        @NameInMap("finishTime")
        public String finishTime;

        /**
         * <strong>example:</strong>
         * <p>Siw2WNVZS4KiUt3tTmaNKg04*****809950</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <strong>example:</strong>
         * <p>agree</p>
         */
        @NameInMap("result")
        public String result;

        /**
         * <strong>example:</strong>
         * <p>RUNNING</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <strong>example:</strong>
         * <p>1234567</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        /**
         * <strong>example:</strong>
         * <p>manager001</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryIntegratedTodoTaskResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            QueryIntegratedTodoTaskResponseBodyResultList self = new QueryIntegratedTodoTaskResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public QueryIntegratedTodoTaskResponseBodyResultList setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public QueryIntegratedTodoTaskResponseBodyResultList setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public QueryIntegratedTodoTaskResponseBodyResultList setFinishTime(String finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public String getFinishTime() {
            return this.finishTime;
        }

        public QueryIntegratedTodoTaskResponseBodyResultList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public QueryIntegratedTodoTaskResponseBodyResultList setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public QueryIntegratedTodoTaskResponseBodyResultList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryIntegratedTodoTaskResponseBodyResultList setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public QueryIntegratedTodoTaskResponseBodyResultList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryIntegratedTodoTaskResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<QueryIntegratedTodoTaskResponseBodyResultList> list;

        public static QueryIntegratedTodoTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryIntegratedTodoTaskResponseBodyResult self = new QueryIntegratedTodoTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryIntegratedTodoTaskResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public QueryIntegratedTodoTaskResponseBodyResult setList(java.util.List<QueryIntegratedTodoTaskResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<QueryIntegratedTodoTaskResponseBodyResultList> getList() {
            return this.list;
        }

    }

}
