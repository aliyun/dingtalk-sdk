// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetHotelExceedApplyResponseBody extends TeaModel {
    @NameInMap("applyId")
    public Long applyId;

    @NameInMap("applyIntentionInfoDO")
    public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO;

    @NameInMap("btripCause")
    public String btripCause;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("exceedReason")
    public String exceedReason;

    @NameInMap("exceedType")
    public Integer exceedType;

    @NameInMap("originStandard")
    public String originStandard;

    @NameInMap("status")
    public Integer status;

    @NameInMap("submitTime")
    public String submitTime;

    @NameInMap("thirdpartApplyId")
    public String thirdpartApplyId;

    @NameInMap("userId")
    public String userId;

    public static GetHotelExceedApplyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetHotelExceedApplyResponseBody self = new GetHotelExceedApplyResponseBody();
        return TeaModel.build(map, self);
    }

    public GetHotelExceedApplyResponseBody setApplyId(Long applyId) {
        this.applyId = applyId;
        return this;
    }
    public Long getApplyId() {
        return this.applyId;
    }

    public GetHotelExceedApplyResponseBody setApplyIntentionInfoDO(GetHotelExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO) {
        this.applyIntentionInfoDO = applyIntentionInfoDO;
        return this;
    }
    public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO getApplyIntentionInfoDO() {
        return this.applyIntentionInfoDO;
    }

    public GetHotelExceedApplyResponseBody setBtripCause(String btripCause) {
        this.btripCause = btripCause;
        return this;
    }
    public String getBtripCause() {
        return this.btripCause;
    }

    public GetHotelExceedApplyResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetHotelExceedApplyResponseBody setExceedReason(String exceedReason) {
        this.exceedReason = exceedReason;
        return this;
    }
    public String getExceedReason() {
        return this.exceedReason;
    }

    public GetHotelExceedApplyResponseBody setExceedType(Integer exceedType) {
        this.exceedType = exceedType;
        return this;
    }
    public Integer getExceedType() {
        return this.exceedType;
    }

    public GetHotelExceedApplyResponseBody setOriginStandard(String originStandard) {
        this.originStandard = originStandard;
        return this;
    }
    public String getOriginStandard() {
        return this.originStandard;
    }

    public GetHotelExceedApplyResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public GetHotelExceedApplyResponseBody setSubmitTime(String submitTime) {
        this.submitTime = submitTime;
        return this;
    }
    public String getSubmitTime() {
        return this.submitTime;
    }

    public GetHotelExceedApplyResponseBody setThirdpartApplyId(String thirdpartApplyId) {
        this.thirdpartApplyId = thirdpartApplyId;
        return this;
    }
    public String getThirdpartApplyId() {
        return this.thirdpartApplyId;
    }

    public GetHotelExceedApplyResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class GetHotelExceedApplyResponseBodyApplyIntentionInfoDO extends TeaModel {
        @NameInMap("checkIn")
        public String checkIn;

        @NameInMap("checkOut")
        public String checkOut;

        @NameInMap("cityCode")
        public String cityCode;

        @NameInMap("cityName")
        public String cityName;

        @NameInMap("price")
        public Long price;

        @NameInMap("together")
        public Boolean together;

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
