// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetNotifyMeResponseBody extends TeaModel {
    // data
    @NameInMap("data")
    public java.util.List<GetNotifyMeResponseBodyData> data;

    // 当前第几页
    @NameInMap("pageNumber")
    public Long pageNumber;

    // 总数量
    @NameInMap("totalCount")
    public Long totalCount;

    public static GetNotifyMeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetNotifyMeResponseBody self = new GetNotifyMeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetNotifyMeResponseBody setData(java.util.List<GetNotifyMeResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetNotifyMeResponseBodyData> getData() {
        return this.data;
    }

    public GetNotifyMeResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetNotifyMeResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetNotifyMeResponseBodyData extends TeaModel {
        // activityId
        @NameInMap("activityId")
        public String activityId;

        // appType
        @NameInMap("appType")
        public String appType;

        // corpId
        @NameInMap("corpId")
        public String corpId;

        // 创建时间
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        // 创建者的userId
        @NameInMap("creatorUserId")
        public String creatorUserId;

        // 流程实例id
        @NameInMap("formInstanceId")
        public String formInstanceId;

        // instStatus
        @NameInMap("instStatus")
        public String instStatus;

        // mobileUrl
        @NameInMap("mobileUrl")
        public String mobileUrl;

        // 修改时间
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        // processCode
        @NameInMap("processCode")
        public String processCode;

        // title
        @NameInMap("title")
        public String title;

        // titleEn
        @NameInMap("titleInEnglish")
        public String titleInEnglish;

        // url
        @NameInMap("url")
        public String url;

        public static GetNotifyMeResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetNotifyMeResponseBodyData self = new GetNotifyMeResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetNotifyMeResponseBodyData setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetNotifyMeResponseBodyData setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public GetNotifyMeResponseBodyData setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetNotifyMeResponseBodyData setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetNotifyMeResponseBodyData setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
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

        public GetNotifyMeResponseBodyData setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public GetNotifyMeResponseBodyData setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public GetNotifyMeResponseBodyData setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public GetNotifyMeResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetNotifyMeResponseBodyData setTitleInEnglish(String titleInEnglish) {
            this.titleInEnglish = titleInEnglish;
            return this;
        }
        public String getTitleInEnglish() {
            return this.titleInEnglish;
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
