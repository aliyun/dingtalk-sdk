// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddOrgAccountOwnnessRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1698335999000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("ownenssType")
    public Long ownenssType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("ownnessId")
    public Long ownnessId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1698335999000</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>会议中</p>
     */
    @NameInMap("text")
    public String text;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("userId")
    public String userId;

    public static AddOrgAccountOwnnessRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOrgAccountOwnnessRequest self = new AddOrgAccountOwnnessRequest();
        return TeaModel.build(map, self);
    }

    public AddOrgAccountOwnnessRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public AddOrgAccountOwnnessRequest setOwnenssType(Long ownenssType) {
        this.ownenssType = ownenssType;
        return this;
    }
    public Long getOwnenssType() {
        return this.ownenssType;
    }

    public AddOrgAccountOwnnessRequest setOwnnessId(Long ownnessId) {
        this.ownnessId = ownnessId;
        return this;
    }
    public Long getOwnnessId() {
        return this.ownnessId;
    }

    public AddOrgAccountOwnnessRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public AddOrgAccountOwnnessRequest setText(String text) {
        this.text = text;
        return this;
    }
    public String getText() {
        return this.text;
    }

    public AddOrgAccountOwnnessRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
