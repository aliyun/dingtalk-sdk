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
        // originatorNickName
        @NameInMap("originatorNickName")
        public String originatorNickName;

        // processInstanceId
        @NameInMap("processInstanceId")
        public String processInstanceId;

        // originatorName
        @NameInMap("originatorName")
        public String originatorName;

        // 标题英文
        @NameInMap("titleInEnglish")
        public String titleInEnglish;

        // originatorNickNameEn
        @NameInMap("originatorNickNameInEnglish")
        public String originatorNickNameInEnglish;

        // originatorEmail
        @NameInMap("originatorEmail")
        public String originatorEmail;

        // 标题
        @NameInMap("title")
        public String title;

        // outResultName
        @NameInMap("outResultName")
        public String outResultName;

        // 实际执行人id
        @NameInMap("actualActionExecutorId")
        public String actualActionExecutorId;

        // outResult
        @NameInMap("outResult")
        public String outResult;

        // 创建时间
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        // originatorPhoto
        @NameInMap("originatorPhoto")
        public String originatorPhoto;

        // 任务类型
        @NameInMap("taskType")
        public String taskType;

        // originatorNameEn
        @NameInMap("originatorNameInEnglish")
        public String originatorNameInEnglish;

        // appType
        @NameInMap("appType")
        public String appType;

        // 激活时间
        @NameInMap("activeTimeGMT")
        public String activeTimeGMT;

        // 结束时间
        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        // originatorId
        @NameInMap("originatorId")
        public String originatorId;

        // 任务id
        @NameInMap("taskId")
        public String taskId;

        // 状态
        @NameInMap("status")
        public String status;

        public static GetRunningTaskListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetRunningTaskListResponseBodyResult self = new GetRunningTaskListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetRunningTaskListResponseBodyResult setOriginatorNickName(String originatorNickName) {
            this.originatorNickName = originatorNickName;
            return this;
        }
        public String getOriginatorNickName() {
            return this.originatorNickName;
        }

        public GetRunningTaskListResponseBodyResult setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetRunningTaskListResponseBodyResult setOriginatorName(String originatorName) {
            this.originatorName = originatorName;
            return this;
        }
        public String getOriginatorName() {
            return this.originatorName;
        }

        public GetRunningTaskListResponseBodyResult setTitleInEnglish(String titleInEnglish) {
            this.titleInEnglish = titleInEnglish;
            return this;
        }
        public String getTitleInEnglish() {
            return this.titleInEnglish;
        }

        public GetRunningTaskListResponseBodyResult setOriginatorNickNameInEnglish(String originatorNickNameInEnglish) {
            this.originatorNickNameInEnglish = originatorNickNameInEnglish;
            return this;
        }
        public String getOriginatorNickNameInEnglish() {
            return this.originatorNickNameInEnglish;
        }

        public GetRunningTaskListResponseBodyResult setOriginatorEmail(String originatorEmail) {
            this.originatorEmail = originatorEmail;
            return this;
        }
        public String getOriginatorEmail() {
            return this.originatorEmail;
        }

        public GetRunningTaskListResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetRunningTaskListResponseBodyResult setOutResultName(String outResultName) {
            this.outResultName = outResultName;
            return this;
        }
        public String getOutResultName() {
            return this.outResultName;
        }

        public GetRunningTaskListResponseBodyResult setActualActionExecutorId(String actualActionExecutorId) {
            this.actualActionExecutorId = actualActionExecutorId;
            return this;
        }
        public String getActualActionExecutorId() {
            return this.actualActionExecutorId;
        }

        public GetRunningTaskListResponseBodyResult setOutResult(String outResult) {
            this.outResult = outResult;
            return this;
        }
        public String getOutResult() {
            return this.outResult;
        }

        public GetRunningTaskListResponseBodyResult setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetRunningTaskListResponseBodyResult setOriginatorPhoto(String originatorPhoto) {
            this.originatorPhoto = originatorPhoto;
            return this;
        }
        public String getOriginatorPhoto() {
            return this.originatorPhoto;
        }

        public GetRunningTaskListResponseBodyResult setTaskType(String taskType) {
            this.taskType = taskType;
            return this;
        }
        public String getTaskType() {
            return this.taskType;
        }

        public GetRunningTaskListResponseBodyResult setOriginatorNameInEnglish(String originatorNameInEnglish) {
            this.originatorNameInEnglish = originatorNameInEnglish;
            return this;
        }
        public String getOriginatorNameInEnglish() {
            return this.originatorNameInEnglish;
        }

        public GetRunningTaskListResponseBodyResult setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public GetRunningTaskListResponseBodyResult setActiveTimeGMT(String activeTimeGMT) {
            this.activeTimeGMT = activeTimeGMT;
            return this;
        }
        public String getActiveTimeGMT() {
            return this.activeTimeGMT;
        }

        public GetRunningTaskListResponseBodyResult setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

        public GetRunningTaskListResponseBodyResult setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

        public GetRunningTaskListResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetRunningTaskListResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
