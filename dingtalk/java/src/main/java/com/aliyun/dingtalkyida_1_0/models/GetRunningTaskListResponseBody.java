// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetRunningTaskListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetRunningTaskListResponseBodyResult> result;

    public static GetRunningTaskListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRunningTaskListResponseBody self = new GetRunningTaskListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRunningTaskListResponseBody setResult(java.util.List<GetRunningTaskListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetRunningTaskListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetRunningTaskListResponseBodyResult extends TeaModel {
        // 激活时间
        @NameInMap("activeTimeGMT")
        public String activeTimeGMT;

        // 实际执行人id
        @NameInMap("actualActionExecutorId")
        public String actualActionExecutorId;

        // appType
        @NameInMap("appType")
        public String appType;

        // 创建时间
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        // 结束时间
        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        // originatorEmail
        @NameInMap("originatorEmail")
        public String originatorEmail;

        // originatorId
        @NameInMap("originatorId")
        public String originatorId;

        // originatorName
        @NameInMap("originatorName")
        public String originatorName;

        // originatorNameEn
        @NameInMap("originatorNameInEnglish")
        public String originatorNameInEnglish;

        // originatorNickName
        @NameInMap("originatorNickName")
        public String originatorNickName;

        // originatorNickNameEn
        @NameInMap("originatorNickNameInEnglish")
        public String originatorNickNameInEnglish;

        // originatorPhoto
        @NameInMap("originatorPhoto")
        public String originatorPhoto;

        // outResult
        @NameInMap("outResult")
        public String outResult;

        // outResultName
        @NameInMap("outResultName")
        public String outResultName;

        // processInstanceId
        @NameInMap("processInstanceId")
        public String processInstanceId;

        // 状态
        @NameInMap("status")
        public String status;

        // 任务id
        @NameInMap("taskId")
        public String taskId;

        // 任务类型
        @NameInMap("taskType")
        public String taskType;

        // 标题
        @NameInMap("title")
        public String title;

        // 标题英文
        @NameInMap("titleInEnglish")
        public String titleInEnglish;

        public static GetRunningTaskListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetRunningTaskListResponseBodyResult self = new GetRunningTaskListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetRunningTaskListResponseBodyResult setActiveTimeGMT(String activeTimeGMT) {
            this.activeTimeGMT = activeTimeGMT;
            return this;
        }
        public String getActiveTimeGMT() {
            return this.activeTimeGMT;
        }

        public GetRunningTaskListResponseBodyResult setActualActionExecutorId(String actualActionExecutorId) {
            this.actualActionExecutorId = actualActionExecutorId;
            return this;
        }
        public String getActualActionExecutorId() {
            return this.actualActionExecutorId;
        }

        public GetRunningTaskListResponseBodyResult setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public GetRunningTaskListResponseBodyResult setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetRunningTaskListResponseBodyResult setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

        public GetRunningTaskListResponseBodyResult setOriginatorEmail(String originatorEmail) {
            this.originatorEmail = originatorEmail;
            return this;
        }
        public String getOriginatorEmail() {
            return this.originatorEmail;
        }

        public GetRunningTaskListResponseBodyResult setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

        public GetRunningTaskListResponseBodyResult setOriginatorName(String originatorName) {
            this.originatorName = originatorName;
            return this;
        }
        public String getOriginatorName() {
            return this.originatorName;
        }

        public GetRunningTaskListResponseBodyResult setOriginatorNameInEnglish(String originatorNameInEnglish) {
            this.originatorNameInEnglish = originatorNameInEnglish;
            return this;
        }
        public String getOriginatorNameInEnglish() {
            return this.originatorNameInEnglish;
        }

        public GetRunningTaskListResponseBodyResult setOriginatorNickName(String originatorNickName) {
            this.originatorNickName = originatorNickName;
            return this;
        }
        public String getOriginatorNickName() {
            return this.originatorNickName;
        }

        public GetRunningTaskListResponseBodyResult setOriginatorNickNameInEnglish(String originatorNickNameInEnglish) {
            this.originatorNickNameInEnglish = originatorNickNameInEnglish;
            return this;
        }
        public String getOriginatorNickNameInEnglish() {
            return this.originatorNickNameInEnglish;
        }

        public GetRunningTaskListResponseBodyResult setOriginatorPhoto(String originatorPhoto) {
            this.originatorPhoto = originatorPhoto;
            return this;
        }
        public String getOriginatorPhoto() {
            return this.originatorPhoto;
        }

        public GetRunningTaskListResponseBodyResult setOutResult(String outResult) {
            this.outResult = outResult;
            return this;
        }
        public String getOutResult() {
            return this.outResult;
        }

        public GetRunningTaskListResponseBodyResult setOutResultName(String outResultName) {
            this.outResultName = outResultName;
            return this;
        }
        public String getOutResultName() {
            return this.outResultName;
        }

        public GetRunningTaskListResponseBodyResult setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetRunningTaskListResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetRunningTaskListResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetRunningTaskListResponseBodyResult setTaskType(String taskType) {
            this.taskType = taskType;
            return this;
        }
        public String getTaskType() {
            return this.taskType;
        }

        public GetRunningTaskListResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetRunningTaskListResponseBodyResult setTitleInEnglish(String titleInEnglish) {
            this.titleInEnglish = titleInEnglish;
            return this;
        }
        public String getTitleInEnglish() {
            return this.titleInEnglish;
        }

    }

}
