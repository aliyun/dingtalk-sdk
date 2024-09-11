// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetDoneTasksResponseBody extends TeaModel {
    @NameInMap("result")
    public PremiumGetDoneTasksResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static PremiumGetDoneTasksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetDoneTasksResponseBody self = new PremiumGetDoneTasksResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumGetDoneTasksResponseBody setResult(PremiumGetDoneTasksResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumGetDoneTasksResponseBodyResult getResult() {
        return this.result;
    }

    public PremiumGetDoneTasksResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PremiumGetDoneTasksResponseBodyResultList extends TeaModel {
        @NameInMap("activityId")
        public String activityId;

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

        @NameInMap("taskId")
        public String taskId;

        @NameInMap("title")
        public String title;

        @NameInMap("url")
        public String url;

        public static PremiumGetDoneTasksResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetDoneTasksResponseBodyResultList self = new PremiumGetDoneTasksResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public PremiumGetDoneTasksResponseBodyResultList setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public PremiumGetDoneTasksResponseBodyResultList setFormMassage(String formMassage) {
            this.formMassage = formMassage;
            return this;
        }
        public String getFormMassage() {
            return this.formMassage;
        }

        public PremiumGetDoneTasksResponseBodyResultList setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

        public PremiumGetDoneTasksResponseBodyResultList setOriginatorName(String originatorName) {
            this.originatorName = originatorName;
            return this;
        }
        public String getOriginatorName() {
            return this.originatorName;
        }

        public PremiumGetDoneTasksResponseBodyResultList setOriginatorPhoto(String originatorPhoto) {
            this.originatorPhoto = originatorPhoto;
            return this;
        }
        public String getOriginatorPhoto() {
            return this.originatorPhoto;
        }

        public PremiumGetDoneTasksResponseBodyResultList setProcessCreateTime(String processCreateTime) {
            this.processCreateTime = processCreateTime;
            return this;
        }
        public String getProcessCreateTime() {
            return this.processCreateTime;
        }

        public PremiumGetDoneTasksResponseBodyResultList setProcessEndTime(String processEndTime) {
            this.processEndTime = processEndTime;
            return this;
        }
        public String getProcessEndTime() {
            return this.processEndTime;
        }

        public PremiumGetDoneTasksResponseBodyResultList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public PremiumGetDoneTasksResponseBodyResultList setProcessType(Integer processType) {
            this.processType = processType;
            return this;
        }
        public Integer getProcessType() {
            return this.processType;
        }

        public PremiumGetDoneTasksResponseBodyResultList setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public PremiumGetDoneTasksResponseBodyResultList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public PremiumGetDoneTasksResponseBodyResultList setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public PremiumGetDoneTasksResponseBodyResultList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public PremiumGetDoneTasksResponseBodyResultList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class PremiumGetDoneTasksResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<PremiumGetDoneTasksResponseBodyResultList> list;

        public static PremiumGetDoneTasksResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetDoneTasksResponseBodyResult self = new PremiumGetDoneTasksResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumGetDoneTasksResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public PremiumGetDoneTasksResponseBodyResult setList(java.util.List<PremiumGetDoneTasksResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<PremiumGetDoneTasksResponseBodyResultList> getList() {
            return this.list;
        }

    }

}
