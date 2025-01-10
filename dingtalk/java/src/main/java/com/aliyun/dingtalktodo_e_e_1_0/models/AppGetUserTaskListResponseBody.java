// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class AppGetUserTaskListResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<AppGetUserTaskListResponseBodyData> data;

    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static AppGetUserTaskListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AppGetUserTaskListResponseBody self = new AppGetUserTaskListResponseBody();
        return TeaModel.build(map, self);
    }

    public AppGetUserTaskListResponseBody setData(java.util.List<AppGetUserTaskListResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<AppGetUserTaskListResponseBodyData> getData() {
        return this.data;
    }

    public AppGetUserTaskListResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public AppGetUserTaskListResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public AppGetUserTaskListResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public AppGetUserTaskListResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class AppGetUserTaskListResponseBodyDataDetailUrl extends TeaModel {
        @NameInMap("appUrl")
        public String appUrl;

        @NameInMap("webUrl")
        public String webUrl;

        public static AppGetUserTaskListResponseBodyDataDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            AppGetUserTaskListResponseBodyDataDetailUrl self = new AppGetUserTaskListResponseBodyDataDetailUrl();
            return TeaModel.build(map, self);
        }

        public AppGetUserTaskListResponseBodyDataDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public AppGetUserTaskListResponseBodyDataDetailUrl setWebUrl(String webUrl) {
            this.webUrl = webUrl;
            return this;
        }
        public String getWebUrl() {
            return this.webUrl;
        }

    }

    public static class AppGetUserTaskListResponseBodyData extends TeaModel {
        @NameInMap("bizCategoryId")
        public String bizCategoryId;

        @NameInMap("createdTime")
        public Long createdTime;

        @NameInMap("description")
        public String description;

        @NameInMap("detailUrl")
        public AppGetUserTaskListResponseBodyDataDetailUrl detailUrl;

        @NameInMap("done")
        public Boolean done;

        @NameInMap("dueTime")
        public Long dueTime;

        @NameInMap("modifiedTime")
        public Long modifiedTime;

        @NameInMap("operatorId")
        public String operatorId;

        @NameInMap("priority")
        public Long priority;

        @NameInMap("subject")
        public String subject;

        @NameInMap("taskId")
        public String taskId;

        public static AppGetUserTaskListResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            AppGetUserTaskListResponseBodyData self = new AppGetUserTaskListResponseBodyData();
            return TeaModel.build(map, self);
        }

        public AppGetUserTaskListResponseBodyData setBizCategoryId(String bizCategoryId) {
            this.bizCategoryId = bizCategoryId;
            return this;
        }
        public String getBizCategoryId() {
            return this.bizCategoryId;
        }

        public AppGetUserTaskListResponseBodyData setCreatedTime(Long createdTime) {
            this.createdTime = createdTime;
            return this;
        }
        public Long getCreatedTime() {
            return this.createdTime;
        }

        public AppGetUserTaskListResponseBodyData setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public AppGetUserTaskListResponseBodyData setDetailUrl(AppGetUserTaskListResponseBodyDataDetailUrl detailUrl) {
            this.detailUrl = detailUrl;
            return this;
        }
        public AppGetUserTaskListResponseBodyDataDetailUrl getDetailUrl() {
            return this.detailUrl;
        }

        public AppGetUserTaskListResponseBodyData setDone(Boolean done) {
            this.done = done;
            return this;
        }
        public Boolean getDone() {
            return this.done;
        }

        public AppGetUserTaskListResponseBodyData setDueTime(Long dueTime) {
            this.dueTime = dueTime;
            return this;
        }
        public Long getDueTime() {
            return this.dueTime;
        }

        public AppGetUserTaskListResponseBodyData setModifiedTime(Long modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public Long getModifiedTime() {
            return this.modifiedTime;
        }

        public AppGetUserTaskListResponseBodyData setOperatorId(String operatorId) {
            this.operatorId = operatorId;
            return this;
        }
        public String getOperatorId() {
            return this.operatorId;
        }

        public AppGetUserTaskListResponseBodyData setPriority(Long priority) {
            this.priority = priority;
            return this;
        }
        public Long getPriority() {
            return this.priority;
        }

        public AppGetUserTaskListResponseBodyData setSubject(String subject) {
            this.subject = subject;
            return this;
        }
        public String getSubject() {
            return this.subject;
        }

        public AppGetUserTaskListResponseBodyData setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
