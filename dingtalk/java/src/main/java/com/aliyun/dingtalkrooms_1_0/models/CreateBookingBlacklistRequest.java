// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateBookingBlacklistRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
     */
    @NameInMap("blacklistUnionId")
    public String blacklistUnionId;

    /**
     * <strong>example:</strong>
     * <p>1728539655110</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <strong>example:</strong>
     * <p>备注</p>
     */
    @NameInMap("memo")
    public String memo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1728539655017</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static CreateBookingBlacklistRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateBookingBlacklistRequest self = new CreateBookingBlacklistRequest();
        return TeaModel.build(map, self);
    }

    public CreateBookingBlacklistRequest setBlacklistUnionId(String blacklistUnionId) {
        this.blacklistUnionId = blacklistUnionId;
        return this;
    }
    public String getBlacklistUnionId() {
        return this.blacklistUnionId;
    }

    public CreateBookingBlacklistRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public CreateBookingBlacklistRequest setMemo(String memo) {
        this.memo = memo;
        return this;
    }
    public String getMemo() {
        return this.memo;
    }

    public CreateBookingBlacklistRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public CreateBookingBlacklistRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
