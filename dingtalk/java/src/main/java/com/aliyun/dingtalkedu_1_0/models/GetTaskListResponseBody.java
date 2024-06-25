// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetTaskListResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("count")
    public Long count;

    @NameInMap("taskList")
    public java.util.List<GetTaskListResponseBodyTaskList> taskList;

    public static GetTaskListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTaskListResponseBody self = new GetTaskListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTaskListResponseBody setCount(Long count) {
        this.count = count;
        return this;
    }
    public Long getCount() {
        return this.count;
    }

    public GetTaskListResponseBody setTaskList(java.util.List<GetTaskListResponseBodyTaskList> taskList) {
        this.taskList = taskList;
        return this;
    }
    public java.util.List<GetTaskListResponseBodyTaskList> getTaskList() {
        return this.taskList;
    }

    public static class GetTaskListResponseBodyTaskList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2023希望校区初中</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>4240028</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        /**
         * <strong>example:</strong>
         * <p>2023</p>
         */
        @NameInMap("taskYear")
        public Long taskYear;

        public static GetTaskListResponseBodyTaskList build(java.util.Map<String, ?> map) throws Exception {
            GetTaskListResponseBodyTaskList self = new GetTaskListResponseBodyTaskList();
            return TeaModel.build(map, self);
        }

        public GetTaskListResponseBodyTaskList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTaskListResponseBodyTaskList setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public GetTaskListResponseBodyTaskList setTaskYear(Long taskYear) {
            this.taskYear = taskYear;
            return this;
        }
        public Long getTaskYear() {
            return this.taskYear;
        }

    }

}
