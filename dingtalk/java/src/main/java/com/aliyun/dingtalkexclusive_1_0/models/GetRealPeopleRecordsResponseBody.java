// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRealPeopleRecordsResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetRealPeopleRecordsResponseBodyData> data;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("total")
    public Integer total;

    public static GetRealPeopleRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRealPeopleRecordsResponseBody self = new GetRealPeopleRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRealPeopleRecordsResponseBody setData(java.util.List<GetRealPeopleRecordsResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetRealPeopleRecordsResponseBodyData> getData() {
        return this.data;
    }

    public GetRealPeopleRecordsResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetRealPeopleRecordsResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

    public static class GetRealPeopleRecordsResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>agentId</p>
         */
        @NameInMap("agentId")
        public Long agentId;

        /**
         * <strong>example:</strong>
         * <p>166700000</p>
         */
        @NameInMap("invokeTime")
        public Long invokeTime;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("personIdentification")
        public Integer personIdentification;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("platform")
        public Integer platform;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("scene")
        public Integer scene;

        /**
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetRealPeopleRecordsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetRealPeopleRecordsResponseBodyData self = new GetRealPeopleRecordsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetRealPeopleRecordsResponseBodyData setAgentId(Long agentId) {
            this.agentId = agentId;
            return this;
        }
        public Long getAgentId() {
            return this.agentId;
        }

        public GetRealPeopleRecordsResponseBodyData setInvokeTime(Long invokeTime) {
            this.invokeTime = invokeTime;
            return this;
        }
        public Long getInvokeTime() {
            return this.invokeTime;
        }

        public GetRealPeopleRecordsResponseBodyData setPersonIdentification(Integer personIdentification) {
            this.personIdentification = personIdentification;
            return this;
        }
        public Integer getPersonIdentification() {
            return this.personIdentification;
        }

        public GetRealPeopleRecordsResponseBodyData setPlatform(Integer platform) {
            this.platform = platform;
            return this;
        }
        public Integer getPlatform() {
            return this.platform;
        }

        public GetRealPeopleRecordsResponseBodyData setScene(Integer scene) {
            this.scene = scene;
            return this;
        }
        public Integer getScene() {
            return this.scene;
        }

        public GetRealPeopleRecordsResponseBodyData setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
