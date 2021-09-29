// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetNotifyMeResponseBody extends TeaModel {
    // 总数量
    @NameInMap("totalCount")
    public Long totalCount;

    // 当前第几页
    @NameInMap("pageNumber")
    public Long pageNumber;

    // data
    @NameInMap("data")
    public java.util.List<GetNotifyMeResponseBodyData> data;

    public static GetNotifyMeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetNotifyMeResponseBody self = new GetNotifyMeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetNotifyMeResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public GetNotifyMeResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetNotifyMeResponseBody setData(java.util.List<GetNotifyMeResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetNotifyMeResponseBodyData> getData() {
        return this.data;
    }

    public static class GetNotifyMeResponseBodyData extends TeaModel {
        // 创建时间
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        // activityId
        @NameInMap("activityId")
        public String activityId;

        // 创建者的userId
        @NameInMap("creatorUserId")
        public String creatorUserId;

        // corpId
        @NameInMap("corpId")
        public String corpId;

        // titleEn
        @NameInMap("titleInEnglish")
        public String titleInEnglish;

        // 修改时间
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        // appType
        @NameInMap("appType")
        public String appType;

        // processCode
        @NameInMap("processCode")
        public String processCode;

        // mobileUrl
        @NameInMap("mobileUrl")
        public String mobileUrl;

        // 流程实例id
        @NameInMap("formInstanceId")
        public String formInstanceId;

        // instStatus
        @NameInMap("instStatus")
        public String instStatus;

        // title
        @NameInMap("title")
        public String title;

        // url
        @NameInMap("url")
        public String url;

        public static GetNotifyMeResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetNotifyMeResponseBodyData self = new GetNotifyMeResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetNotifyMeResponseBodyData setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetNotifyMeResponseBodyData setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetNotifyMeResponseBodyData setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public GetNotifyMeResponseBodyData setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetNotifyMeResponseBodyData setTitleInEnglish(String titleInEnglish) {
            this.titleInEnglish = titleInEnglish;
            return this;
        }
        public String getTitleInEnglish() {
            return this.titleInEnglish;
        }

        public GetNotifyMeResponseBodyData setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public GetNotifyMeResponseBodyData setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public GetNotifyMeResponseBodyData setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public GetNotifyMeResponseBodyData setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public GetNotifyMeResponseBodyData setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public GetNotifyMeResponseBodyData setInstStatus(String instStatus) {
            this.instStatus = instStatus;
            return this;
        }
        public String getInstStatus() {
            return this.instStatus;
        }

        public GetNotifyMeResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetNotifyMeResponseBodyData setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
