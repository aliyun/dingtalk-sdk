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

        // 1. 姓名匹配阶段失败 2. 认证阶段失败 3. 实人流程阶段失败 4. 协议签署阶段失败 5. 人脸录入阶段失败 6. 人脸录入阶段用户主动取消 7. 人脸录入阶段成功 8. 人脸识别阶段失败 9. 人脸识别阶段主动取消 10. 人脸识别阶段成功  11.去实人场景
        @NameInMap("scene")
        public Integer scene;

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
