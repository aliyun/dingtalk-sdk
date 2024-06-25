// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueueNotifyRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>5</p>
     */
    @NameInMap("estimateWaitMin")
    public Long estimateWaitMin;

    /**
     * <strong>example:</strong>
     * <p>eWaJSqDcLsoiE</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <strong>example:</strong>
     * <p>11</p>
     */
    @NameInMap("queuePlace")
    public Long queuePlace;

    /**
     * <strong>example:</strong>
     * <p>3333333333</p>
     */
    @NameInMap("serviceToken")
    public String serviceToken;

    /**
     * <strong>example:</strong>
     * <p>SourceTypeEnum</p>
     */
    @NameInMap("targetChannel")
    public String targetChannel;

    /**
     * <strong>example:</strong>
     * <p>你好，欢迎来到这里</p>
     */
    @NameInMap("tips")
    public String tips;

    /**
     * <strong>example:</strong>
     * <p>eeeeeeeeerrrrr</p>
     */
    @NameInMap("visitorToken")
    public String visitorToken;

    public static QueueNotifyRequest build(java.util.Map<String, ?> map) throws Exception {
        QueueNotifyRequest self = new QueueNotifyRequest();
        return TeaModel.build(map, self);
    }

    public QueueNotifyRequest setEstimateWaitMin(Long estimateWaitMin) {
        this.estimateWaitMin = estimateWaitMin;
        return this;
    }
    public Long getEstimateWaitMin() {
        return this.estimateWaitMin;
    }

    public QueueNotifyRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public QueueNotifyRequest setQueuePlace(Long queuePlace) {
        this.queuePlace = queuePlace;
        return this;
    }
    public Long getQueuePlace() {
        return this.queuePlace;
    }

    public QueueNotifyRequest setServiceToken(String serviceToken) {
        this.serviceToken = serviceToken;
        return this;
    }
    public String getServiceToken() {
        return this.serviceToken;
    }

    public QueueNotifyRequest setTargetChannel(String targetChannel) {
        this.targetChannel = targetChannel;
        return this;
    }
    public String getTargetChannel() {
        return this.targetChannel;
    }

    public QueueNotifyRequest setTips(String tips) {
        this.tips = tips;
        return this;
    }
    public String getTips() {
        return this.tips;
    }

    public QueueNotifyRequest setVisitorToken(String visitorToken) {
        this.visitorToken = visitorToken;
        return this;
    }
    public String getVisitorToken() {
        return this.visitorToken;
    }

}
