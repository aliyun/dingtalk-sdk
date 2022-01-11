// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetRunningTasksResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetRunningTasksResponseBodyResult> result;

    public static GetRunningTasksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRunningTasksResponseBody self = new GetRunningTasksResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRunningTasksResponseBody setResult(java.util.List<GetRunningTasksResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetRunningTasksResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetRunningTasksResponseBodyResult extends TeaModel {
        // activeTime
        @NameInMap("activeTimeGMT")
        public String activeTimeGMT;

        // activityId
        @NameInMap("activityId")
        public String activityId;

        // actualActionerId
        @NameInMap("actualActionerId")
        public String actualActionerId;

        // createTime
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        // finishTime
        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        // originatorId
        @NameInMap("originatorId")
        public String originatorId;

        // processInstanceId
        @NameInMap("processInstanceId")
        public String processInstanceId;

        // status
        @NameInMap("status")
        public String status;

        // taskId
        @NameInMap("taskId")
        public String taskId;

        // taskType
        @NameInMap("taskType")
        public String taskType;

        // title
        @NameInMap("title")
        public String title;

        // titleEn
        @NameInMap("titleInEnglish")
        public String titleInEnglish;

        public static GetRunningTasksResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetRunningTasksResponseBodyResult self = new GetRunningTasksResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetRunningTasksResponseBodyResult setActiveTimeGMT(String activeTimeGMT) {
            this.activeTimeGMT = activeTimeGMT;
            return this;
        }
        public String getActiveTimeGMT() {
            return this.activeTimeGMT;
        }

        public GetRunningTasksResponseBodyResult setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetRunningTasksResponseBodyResult setActualActionerId(String actualActionerId) {
            this.actualActionerId = actualActionerId;
            return this;
        }
        public String getActualActionerId() {
            return this.actualActionerId;
        }

        public GetRunningTasksResponseBodyResult setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetRunningTasksResponseBodyResult setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

        public GetRunningTasksResponseBodyResult setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

        public GetRunningTasksResponseBodyResult setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetRunningTasksResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetRunningTasksResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetRunningTasksResponseBodyResult setTaskType(String taskType) {
            this.taskType = taskType;
            return this;
        }
        public String getTaskType() {
            return this.taskType;
        }

        public GetRunningTasksResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetRunningTasksResponseBodyResult setTitleInEnglish(String titleInEnglish) {
            this.titleInEnglish = titleInEnglish;
            return this;
        }
        public String getTitleInEnglish() {
            return this.titleInEnglish;
        }

    }

}
