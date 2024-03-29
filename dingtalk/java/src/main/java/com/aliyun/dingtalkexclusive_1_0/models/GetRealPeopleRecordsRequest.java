// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRealPeopleRecordsRequest extends TeaModel {
    @NameInMap("agentId")
    public Long agentId;

    @NameInMap("fromTime")
    public Long fromTime;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("personIdentification")
    public Integer personIdentification;

    @NameInMap("scene")
    public Integer scene;

    @NameInMap("toTime")
    public Long toTime;

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
