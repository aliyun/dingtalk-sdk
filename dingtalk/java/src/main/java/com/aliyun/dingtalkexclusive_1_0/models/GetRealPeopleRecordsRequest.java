// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRealPeopleRecordsRequest extends TeaModel {
    // 应用唯一标识
    @NameInMap("agentId")
    public Long agentId;

    // 记录开始时间(毫秒时间戳)
    @NameInMap("fromTime")
    public Long fromTime;

    // 一页最大值（最大50）
    @NameInMap("maxResults")
    public Integer maxResults;

    // 查询数据的起始位置，0表示从头开始。
    @NameInMap("nextToken")
    public Long nextToken;

    // 实人认证结果 1-成功 2-失败
    @NameInMap("personIdentification")
    public Integer personIdentification;

    // 记录结束时间(毫秒时间戳)
    @NameInMap("toTime")
    public Long toTime;

    // 员工userIds
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
