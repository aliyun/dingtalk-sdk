// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetCorpAccomplishmentTasksResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetCorpAccomplishmentTasksResponseBodyData> data;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("totalCount")
    public Long totalCount;

    public static GetCorpAccomplishmentTasksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCorpAccomplishmentTasksResponseBody self = new GetCorpAccomplishmentTasksResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCorpAccomplishmentTasksResponseBody setData(java.util.List<GetCorpAccomplishmentTasksResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetCorpAccomplishmentTasksResponseBodyData> getData() {
        return this.data;
    }

    public GetCorpAccomplishmentTasksResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetCorpAccomplishmentTasksResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetCorpAccomplishmentTasksResponseBodyData extends TeaModel {
        @NameInMap("activeTimeGMT")
        public String activeTimeGMT;

        @NameInMap("actualActionerId")
        public String actualActionerId;

        @NameInMap("appType")
        public String appType;

        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        @NameInMap("originatorEmail")
        public String originatorEmail;

        @NameInMap("originatorId")
        public String originatorId;

        @NameInMap("originatorName")
        public String originatorName;

        @NameInMap("originatorNameInEnglish")
        public String originatorNameInEnglish;

        @NameInMap("originatorNickName")
        public String originatorNickName;

        @NameInMap("originatorNickNameInEnglish")
        public String originatorNickNameInEnglish;

        @NameInMap("originatorPhoto")
        public String originatorPhoto;

        @NameInMap("outResult")
        public String outResult;

        @NameInMap("outResultName")
        public String outResultName;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("status")
        public String status;

        @NameInMap("taskId")
        public String taskId;

        @NameInMap("taskType")
        public String taskType;

        @NameInMap("title")
        public String title;

        @NameInMap("titleInEnglish")
        public String titleInEnglish;

        public static GetCorpAccomplishmentTasksResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetCorpAccomplishmentTasksResponseBodyData self = new GetCorpAccomplishmentTasksResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetCorpAccomplishmentTasksResponseBodyData setActiveTimeGMT(String activeTimeGMT) {
            this.activeTimeGMT = activeTimeGMT;
            return this;
        }
        public String getActiveTimeGMT() {
            return this.activeTimeGMT;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setActualActionerId(String actualActionerId) {
            this.actualActionerId = actualActionerId;
            return this;
        }
        public String getActualActionerId() {
            return this.actualActionerId;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setOriginatorEmail(String originatorEmail) {
            this.originatorEmail = originatorEmail;
            return this;
        }
        public String getOriginatorEmail() {
            return this.originatorEmail;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setOriginatorName(String originatorName) {
            this.originatorName = originatorName;
            return this;
        }
        public String getOriginatorName() {
            return this.originatorName;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setOriginatorNameInEnglish(String originatorNameInEnglish) {
            this.originatorNameInEnglish = originatorNameInEnglish;
            return this;
        }
        public String getOriginatorNameInEnglish() {
            return this.originatorNameInEnglish;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setOriginatorNickName(String originatorNickName) {
            this.originatorNickName = originatorNickName;
            return this;
        }
        public String getOriginatorNickName() {
            return this.originatorNickName;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setOriginatorNickNameInEnglish(String originatorNickNameInEnglish) {
            this.originatorNickNameInEnglish = originatorNickNameInEnglish;
            return this;
        }
        public String getOriginatorNickNameInEnglish() {
            return this.originatorNickNameInEnglish;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setOriginatorPhoto(String originatorPhoto) {
            this.originatorPhoto = originatorPhoto;
            return this;
        }
        public String getOriginatorPhoto() {
            return this.originatorPhoto;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setOutResult(String outResult) {
            this.outResult = outResult;
            return this;
        }
        public String getOutResult() {
            return this.outResult;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setOutResultName(String outResultName) {
            this.outResultName = outResultName;
            return this;
        }
        public String getOutResultName() {
            return this.outResultName;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setTaskType(String taskType) {
            this.taskType = taskType;
            return this;
        }
        public String getTaskType() {
            return this.taskType;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetCorpAccomplishmentTasksResponseBodyData setTitleInEnglish(String titleInEnglish) {
            this.titleInEnglish = titleInEnglish;
            return this;
        }
        public String getTitleInEnglish() {
            return this.titleInEnglish;
        }

    }

}
