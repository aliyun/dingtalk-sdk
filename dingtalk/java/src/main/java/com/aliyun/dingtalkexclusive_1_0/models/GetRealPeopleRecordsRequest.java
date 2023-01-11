// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRealPeopleRecordsRequest extends TeaModel {
    /**
     * <p>应用唯一标识</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <p>记录开始时间(毫秒时间戳)</p>
     */
    @NameInMap("fromTime")
    public Long fromTime;

    /**
     * <p>一页最大值（最大50）</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>查询数据的起始位置，0表示从头开始。</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>实人认证结果 1-成功 2-失败</p>
     */
    @NameInMap("personIdentification")
    public Integer personIdentification;

    /**
     * <p>1. 姓名匹配阶段失败 2. 认证阶段失败 3. 实人流程阶段失败 4. 协议签署阶段失败 5. 人脸录入阶段失败 6. 人脸录入阶段用户主动取消 7. 人脸录入阶段成功 8. 人脸识别阶段失败 9. 人脸识别阶段主动取消 10. 人脸识别阶段成功  11.去实人场景</p>
     */
    @NameInMap("scene")
    public Integer scene;

    /**
     * <p>记录结束时间(毫秒时间戳)</p>
     */
    @NameInMap("toTime")
    public Long toTime;

    /**
     * <p>员工userIds</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static GetRealPeopleRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRealPeopleRecordsRequest self = new GetRealPeopleRecordsRequest();
        return TeaModel.build(map, self);
    }

    public GetRealPeopleRecordsRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public GetRealPeopleRecordsRequest setFromTime(Long fromTime) {
        this.fromTime = fromTime;
        return this;
    }
    public Long getFromTime() {
        return this.fromTime;
    }

    public GetRealPeopleRecordsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetRealPeopleRecordsRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetRealPeopleRecordsRequest setPersonIdentification(Integer personIdentification) {
        this.personIdentification = personIdentification;
        return this;
    }
    public Integer getPersonIdentification() {
        return this.personIdentification;
    }

    public GetRealPeopleRecordsRequest setScene(Integer scene) {
        this.scene = scene;
        return this;
    }
    public Integer getScene() {
        return this.scene;
    }

    public GetRealPeopleRecordsRequest setToTime(Long toTime) {
        this.toTime = toTime;
        return this;
    }
    public Long getToTime() {
        return this.toTime;
    }

    public GetRealPeopleRecordsRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
