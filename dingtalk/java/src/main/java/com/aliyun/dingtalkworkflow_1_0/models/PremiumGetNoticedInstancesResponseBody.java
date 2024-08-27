// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetNoticedInstancesResponseBody extends TeaModel {
    @NameInMap("result")
    public PremiumGetNoticedInstancesResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static PremiumGetNoticedInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetNoticedInstancesResponseBody self = new PremiumGetNoticedInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumGetNoticedInstancesResponseBody setResult(PremiumGetNoticedInstancesResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumGetNoticedInstancesResponseBodyResult getResult() {
        return this.result;
    }

    public PremiumGetNoticedInstancesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PremiumGetNoticedInstancesResponseBodyResultList extends TeaModel {
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

        public static PremiumGetNoticedInstancesResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetNoticedInstancesResponseBodyResultList self = new PremiumGetNoticedInstancesResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public PremiumGetNoticedInstancesResponseBodyResultList setFormMassage(String formMassage) {
            this.formMassage = formMassage;
            return this;
        }
        public String getFormMassage() {
            return this.formMassage;
        }

        public PremiumGetNoticedInstancesResponseBodyResultList setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

        public PremiumGetNoticedInstancesResponseBodyResultList setOriginatorName(String originatorName) {
            this.originatorName = originatorName;
            return this;
        }
        public String getOriginatorName() {
            return this.originatorName;
        }

        public PremiumGetNoticedInstancesResponseBodyResultList setOriginatorPhoto(String originatorPhoto) {
            this.originatorPhoto = originatorPhoto;
            return this;
        }
        public String getOriginatorPhoto() {
            return this.originatorPhoto;
        }

        public PremiumGetNoticedInstancesResponseBodyResultList setProcessCreateTime(String processCreateTime) {
            this.processCreateTime = processCreateTime;
            return this;
        }
        public String getProcessCreateTime() {
            return this.processCreateTime;
        }

        public PremiumGetNoticedInstancesResponseBodyResultList setProcessEndTime(String processEndTime) {
            this.processEndTime = processEndTime;
            return this;
        }
        public String getProcessEndTime() {
            return this.processEndTime;
        }

        public PremiumGetNoticedInstancesResponseBodyResultList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public PremiumGetNoticedInstancesResponseBodyResultList setProcessType(Integer processType) {
            this.processType = processType;
            return this;
        }
        public Integer getProcessType() {
            return this.processType;
        }

        public PremiumGetNoticedInstancesResponseBodyResultList setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public PremiumGetNoticedInstancesResponseBodyResultList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public PremiumGetNoticedInstancesResponseBodyResultList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public PremiumGetNoticedInstancesResponseBodyResultList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class PremiumGetNoticedInstancesResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<PremiumGetNoticedInstancesResponseBodyResultList> list;

        public static PremiumGetNoticedInstancesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetNoticedInstancesResponseBodyResult self = new PremiumGetNoticedInstancesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumGetNoticedInstancesResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public PremiumGetNoticedInstancesResponseBodyResult setList(java.util.List<PremiumGetNoticedInstancesResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<PremiumGetNoticedInstancesResponseBodyResultList> getList() {
            return this.list;
        }

    }

}
