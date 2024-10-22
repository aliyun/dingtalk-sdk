// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class GetUserTaskListResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetUserTaskListResponseBodyData> data;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("totalCount")
    public Long totalCount;

    public static GetUserTaskListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserTaskListResponseBody self = new GetUserTaskListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserTaskListResponseBody setData(java.util.List<GetUserTaskListResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetUserTaskListResponseBodyData> getData() {
        return this.data;
    }

    public GetUserTaskListResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetUserTaskListResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetUserTaskListResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetUserTaskListResponseBodyData extends TeaModel {
        @NameInMap("createdTime")
        public Long createdTime;

        @NameInMap("description")
        public String description;

        @NameInMap("done")
        public Boolean done;

        @NameInMap("dueTime")
        public Long dueTime;

        @NameInMap("subject")
        public String subject;

        @NameInMap("taskId")
        public String taskId;

        public static GetUserTaskListResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetUserTaskListResponseBodyData self = new GetUserTaskListResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetUserTaskListResponseBodyData setCreatedTime(Long createdTime) {
            this.createdTime = createdTime;
            return this;
        }
        public Long getCreatedTime() {
            return this.createdTime;
        }

        public GetUserTaskListResponseBodyData setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetUserTaskListResponseBodyData setDone(Boolean done) {
            this.done = done;
            return this;
        }
        public Boolean getDone() {
            return this.done;
        }

        public GetUserTaskListResponseBodyData setDueTime(Long dueTime) {
            this.dueTime = dueTime;
            return this;
        }
        public Long getDueTime() {
            return this.dueTime;
        }

        public GetUserTaskListResponseBodyData setSubject(String subject) {
            this.subject = subject;
            return this;
        }
        public String getSubject() {
            return this.subject;
        }

        public GetUserTaskListResponseBodyData setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
