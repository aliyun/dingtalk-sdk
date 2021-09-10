// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetHotelExceedApplyResponseBody extends TeaModel {
    // 第三方企业id
    @NameInMap("corpId")
    public String corpId;

    // 商旅超标审批单id
    @NameInMap("applyId")
    public Long applyId;

    // 审批单状态 0:审批中 1:已同意 2:已拒绝
    @NameInMap("status")
    public Integer status;

    // 出差原因
    @NameInMap("btripCause")
    public String btripCause;

    // 超标类型，32：金额超标
    @NameInMap("exceedType")
    public Integer exceedType;

    // 超标原因
    @NameInMap("exceedReason")
    public String exceedReason;

    // 原差旅标准
    @NameInMap("originStandard")
    public String originStandard;

    // 审批单提交时间
    @NameInMap("submitTime")
    public String submitTime;

    // 第三方用户id
    @NameInMap("userId")
    public String userId;

    // 意向出行信息
    @NameInMap("applyIntentionInfoDO")
    public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO;

    // 第三方出差审批单号
    @NameInMap("thirdpartApplyId")
    public String thirdpartApplyId;

    public static GetHotelExceedApplyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetHotelExceedApplyResponseBody self = new GetHotelExceedApplyResponseBody();
        return TeaModel.build(map, self);
    }

    public GetHotelExceedApplyResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetHotelExceedApplyResponseBody setApplyId(Long applyId) {
        this.applyId = applyId;
        return this;
    }
    public Long getApplyId() {
        return this.applyId;
    }

    public GetHotelExceedApplyResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public GetHotelExceedApplyResponseBody setBtripCause(String btripCause) {
        this.btripCause = btripCause;
        return this;
    }
    public String getBtripCause() {
        return this.btripCause;
    }

    public GetHotelExceedApplyResponseBody setExceedType(Integer exceedType) {
        this.exceedType = exceedType;
        return this;
    }
    public Integer getExceedType() {
        return this.exceedType;
    }

    public GetHotelExceedApplyResponseBody setExceedReason(String exceedReason) {
        this.exceedReason = exceedReason;
        return this;
    }
    public String getExceedReason() {
        return this.exceedReason;
    }

    public GetHotelExceedApplyResponseBody setOriginStandard(String originStandard) {
        this.originStandard = originStandard;
        return this;
    }
    public String getOriginStandard() {
        return this.originStandard;
    }

    public GetHotelExceedApplyResponseBody setSubmitTime(String submitTime) {
        this.submitTime = submitTime;
        return this;
    }
    public String getSubmitTime() {
        return this.submitTime;
    }

    public GetHotelExceedApplyResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetHotelExceedApplyResponseBody setApplyIntentionInfoDO(GetHotelExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO) {
        this.applyIntentionInfoDO = applyIntentionInfoDO;
        return this;
    }
    public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO getApplyIntentionInfoDO() {
        return this.applyIntentionInfoDO;
    }

    public GetHotelExceedApplyResponseBody setThirdpartApplyId(String thirdpartApplyId) {
        this.thirdpartApplyId = thirdpartApplyId;
        return this;
    }
    public String getThirdpartApplyId() {
        return this.thirdpartApplyId;
    }

    public static class GetHotelExceedApplyResponseBodyApplyIntentionInfoDO extends TeaModel {
        // 入住日期
        @NameInMap("checkIn")
        public String checkIn;

        // 离店日期
        @NameInMap("checkOut")
        public String checkOut;

        // 入住城市三字码
        @NameInMap("cityCode")
        public String cityCode;

        // 入住城市名称
        @NameInMap("cityName")
        public String cityName;

        // 意向酒店金额（分）
        @NameInMap("price")
        public Long price;

        // 是否合住
        @NameInMap("together")
        public Boolean together;

        // 超标类型，32：金额超标
        @NameInMap("type")
        public Integer type;

        public static GetHotelExceedApplyResponseBodyApplyIntentionInfoDO build(java.util.Map<String, ?> map) throws Exception {
            GetHotelExceedApplyResponseBodyApplyIntentionInfoDO self = new GetHotelExceedApplyResponseBodyApplyIntentionInfoDO();
            return TeaModel.build(map, self);
        }

        public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO setCheckIn(String checkIn) {
            this.checkIn = checkIn;
            return this;
        }
        public String getCheckIn() {
            return this.checkIn;
        }

        public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO setCheckOut(String checkOut) {
            this.checkOut = checkOut;
            return this;
        }
        public String getCheckOut() {
            return this.checkOut;
        }

        public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO setCityName(String cityName) {
            this.cityName = cityName;
            return this;
        }
        public String getCityName() {
            return this.cityName;
        }

        public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO setPrice(Long price) {
            this.price = price;
            return this;
        }
        public Long getPrice() {
            return this.price;
        }

        public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO setTogether(Boolean together) {
            this.together = together;
            return this;
        }
        public Boolean getTogether() {
            return this.together;
        }

        public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

}
