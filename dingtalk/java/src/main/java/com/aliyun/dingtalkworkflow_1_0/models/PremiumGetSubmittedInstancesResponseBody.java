// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetSubmittedInstancesResponseBody extends TeaModel {
    @NameInMap("result")
    public PremiumGetSubmittedInstancesResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static PremiumGetSubmittedInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetSubmittedInstancesResponseBody self = new PremiumGetSubmittedInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumGetSubmittedInstancesResponseBody setResult(PremiumGetSubmittedInstancesResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumGetSubmittedInstancesResponseBodyResult getResult() {
        return this.result;
    }

    public PremiumGetSubmittedInstancesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PremiumGetSubmittedInstancesResponseBodyResultList extends TeaModel {
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

        @NameInMap("title")
        public String title;

        @NameInMap("url")
        public String url;

        public static PremiumGetSubmittedInstancesResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetSubmittedInstancesResponseBodyResultList self = new PremiumGetSubmittedInstancesResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public PremiumGetSubmittedInstancesResponseBodyResultList setAppType(Integer appType) {
            this.appType = appType;
            return this;
        }
        public Integer getAppType() {
            return this.appType;
        }

        public PremiumGetSubmittedInstancesResponseBodyResultList setFormMassage(String formMassage) {
            this.formMassage = formMassage;
            return this;
        }
        public String getFormMassage() {
            return this.formMassage;
        }

        public PremiumGetSubmittedInstancesResponseBodyResultList setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

        public PremiumGetSubmittedInstancesResponseBodyResultList setOriginatorName(String originatorName) {
            this.originatorName = originatorName;
            return this;
        }
        public String getOriginatorName() {
            return this.originatorName;
        }

        public PremiumGetSubmittedInstancesResponseBodyResultList setOriginatorPhoto(String originatorPhoto) {
            this.originatorPhoto = originatorPhoto;
            return this;
        }
        public String getOriginatorPhoto() {
            return this.originatorPhoto;
        }

        public PremiumGetSubmittedInstancesResponseBodyResultList setProcessCreateTime(String processCreateTime) {
            this.processCreateTime = processCreateTime;
            return this;
        }
        public String getProcessCreateTime() {
            return this.processCreateTime;
        }

        public PremiumGetSubmittedInstancesResponseBodyResultList setProcessEndTime(String processEndTime) {
            this.processEndTime = processEndTime;
            return this;
        }
        public String getProcessEndTime() {
            return this.processEndTime;
        }

        public PremiumGetSubmittedInstancesResponseBodyResultList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public PremiumGetSubmittedInstancesResponseBodyResultList setProcessType(Integer processType) {
            this.processType = processType;
            return this;
        }
        public Integer getProcessType() {
            return this.processType;
        }

        public PremiumGetSubmittedInstancesResponseBodyResultList setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public PremiumGetSubmittedInstancesResponseBodyResultList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public PremiumGetSubmittedInstancesResponseBodyResultList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public PremiumGetSubmittedInstancesResponseBodyResultList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class PremiumGetSubmittedInstancesResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<PremiumGetSubmittedInstancesResponseBodyResultList> list;

        public static PremiumGetSubmittedInstancesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetSubmittedInstancesResponseBodyResult self = new PremiumGetSubmittedInstancesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumGetSubmittedInstancesResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public PremiumGetSubmittedInstancesResponseBodyResult setList(java.util.List<PremiumGetSubmittedInstancesResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<PremiumGetSubmittedInstancesResponseBodyResultList> getList() {
            return this.list;
        }

    }

}
