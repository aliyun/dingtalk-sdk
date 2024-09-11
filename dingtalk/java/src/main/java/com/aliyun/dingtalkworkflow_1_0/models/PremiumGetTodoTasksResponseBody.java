// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetTodoTasksResponseBody extends TeaModel {
    @NameInMap("result")
    public PremiumGetTodoTasksResponseBodyResult result;

    public static PremiumGetTodoTasksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetTodoTasksResponseBody self = new PremiumGetTodoTasksResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumGetTodoTasksResponseBody setResult(PremiumGetTodoTasksResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumGetTodoTasksResponseBodyResult getResult() {
        return this.result;
    }

    public static class PremiumGetTodoTasksResponseBodyResultList extends TeaModel {
        @NameInMap("activityId")
        public String activityId;

        @NameInMap("appType")
        public Integer appType;

        @NameInMap("formMassage")
        public String formMassage;

        @NameInMap("originatorId")
        public String originatorId;

        @NameInMap("originatorName")
        public String originatorName;

        @NameInMap("originatorPhoto")
        public String originatorPhoto;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("processCreateTime")
        public String processCreateTime;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("processEndTime")
        public String processEndTime;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("processType")
        public Integer processType;

        /**
         * <strong>example:</strong>
         * <p>RUNNING</p>
         */
        @NameInMap("status")
        public String status;

        @NameInMap("taskId")
        public String taskId;

        @NameInMap("title")
        public String title;

        @NameInMap("url")
        public String url;

        public static PremiumGetTodoTasksResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetTodoTasksResponseBodyResultList self = new PremiumGetTodoTasksResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public PremiumGetTodoTasksResponseBodyResultList setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public PremiumGetTodoTasksResponseBodyResultList setAppType(Integer appType) {
            this.appType = appType;
            return this;
        }
        public Integer getAppType() {
            return this.appType;
        }

        public PremiumGetTodoTasksResponseBodyResultList setFormMassage(String formMassage) {
            this.formMassage = formMassage;
            return this;
        }
        public String getFormMassage() {
            return this.formMassage;
        }

        public PremiumGetTodoTasksResponseBodyResultList setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

        public PremiumGetTodoTasksResponseBodyResultList setOriginatorName(String originatorName) {
            this.originatorName = originatorName;
            return this;
        }
        public String getOriginatorName() {
            return this.originatorName;
        }

        public PremiumGetTodoTasksResponseBodyResultList setOriginatorPhoto(String originatorPhoto) {
            this.originatorPhoto = originatorPhoto;
            return this;
        }
        public String getOriginatorPhoto() {
            return this.originatorPhoto;
        }

        public PremiumGetTodoTasksResponseBodyResultList setProcessCreateTime(String processCreateTime) {
            this.processCreateTime = processCreateTime;
            return this;
        }
        public String getProcessCreateTime() {
            return this.processCreateTime;
        }

        public PremiumGetTodoTasksResponseBodyResultList setProcessEndTime(String processEndTime) {
            this.processEndTime = processEndTime;
            return this;
        }
        public String getProcessEndTime() {
            return this.processEndTime;
        }

        public PremiumGetTodoTasksResponseBodyResultList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public PremiumGetTodoTasksResponseBodyResultList setProcessType(Integer processType) {
            this.processType = processType;
            return this;
        }
        public Integer getProcessType() {
            return this.processType;
        }

        public PremiumGetTodoTasksResponseBodyResultList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public PremiumGetTodoTasksResponseBodyResultList setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public PremiumGetTodoTasksResponseBodyResultList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public PremiumGetTodoTasksResponseBodyResultList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class PremiumGetTodoTasksResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<PremiumGetTodoTasksResponseBodyResultList> list;

        @NameInMap("success")
        public Boolean success;

        public static PremiumGetTodoTasksResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetTodoTasksResponseBodyResult self = new PremiumGetTodoTasksResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumGetTodoTasksResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public PremiumGetTodoTasksResponseBodyResult setList(java.util.List<PremiumGetTodoTasksResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<PremiumGetTodoTasksResponseBodyResultList> getList() {
            return this.list;
        }

        public PremiumGetTodoTasksResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
