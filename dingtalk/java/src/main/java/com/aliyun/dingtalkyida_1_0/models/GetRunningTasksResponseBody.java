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
        // createTime
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        // activityId
        @NameInMap("activityId")
        public String activityId;

        // processInstanceId
        @NameInMap("processInstanceId")
        public String processInstanceId;

        // taskType
        @NameInMap("taskType")
        public String taskType;

        // titleEn
        @NameInMap("titleInEnglish")
        public String titleInEnglish;

        // activeTime
        @NameInMap("activeTimeGMT")
        public String activeTimeGMT;

        // actualActionerId
        @NameInMap("actualActionerId")
        public String actualActionerId;

        // originatorId
        @NameInMap("originatorId")
        public String originatorId;

        // finishTime
        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        // title
        @NameInMap("title")
        public String title;

        // taskId
        @NameInMap("taskId")
        public String taskId;

        // status
        @NameInMap("status")
        public String status;

        public static GetRunningTasksResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetRunningTasksResponseBodyResult self = new GetRunningTasksResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetRunningTasksResponseBodyResult setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetRunningTasksResponseBodyResult setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetRunningTasksResponseBodyResult setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetRunningTasksResponseBodyResult setTaskType(String taskType) {
            this.taskType = taskType;
            return this;
        }
        public String getTaskType() {
            return this.taskType;
        }

        public GetRunningTasksResponseBodyResult setTitleInEnglish(String titleInEnglish) {
            this.titleInEnglish = titleInEnglish;
            return this;
        }
        public String getTitleInEnglish() {
            return this.titleInEnglish;
        }

        public GetRunningTasksResponseBodyResult setActiveTimeGMT(String activeTimeGMT) {
            this.activeTimeGMT = activeTimeGMT;
            return this;
        }
        public String getActiveTimeGMT() {
            return this.activeTimeGMT;
        }

        public GetRunningTasksResponseBodyResult setActualActionerId(String actualActionerId) {
            this.actualActionerId = actualActionerId;
            return this;
        }
        public String getActualActionerId() {
            return this.actualActionerId;
        }

        public GetRunningTasksResponseBodyResult setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

        public GetRunningTasksResponseBodyResult setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

        public GetRunningTasksResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetRunningTasksResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetRunningTasksResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
