// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRealPeopleRecordsResponseBody extends TeaModel {
    // data
    @NameInMap("data")
    public java.util.List<GetRealPeopleRecordsResponseBodyData> data;

    // 下一次拉取启始值
    @NameInMap("nextToken")
    public Long nextToken;

    // 总数据数
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
        // agentId
        @NameInMap("agentId")
        public Long agentId;

        // 接口调用时间(毫秒时间戳)
        @NameInMap("invokeTime")
        public Long invokeTime;

        // 实人认证结果 1-成功 2-失败
        @NameInMap("personIdentification")
        public Integer personIdentification;

        // 平台 0-Android 或 1-iOS
        @NameInMap("platform")
        public Integer platform;

        // userId
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

        public GetRealPeopleRecordsResponseBodyData setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
