// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetRealPeopleRecordsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>123333</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <strong>example:</strong>
     * <p>1667000000</p>
     */
    @NameInMap("fromTime")
    public Long fromTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

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
    @NameInMap("scene")
    public Integer scene;

    /**
     * <strong>example:</strong>
     * <p>1669000000</p>
     */
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
