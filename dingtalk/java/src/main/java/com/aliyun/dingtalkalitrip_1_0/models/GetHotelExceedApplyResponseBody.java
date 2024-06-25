// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetHotelExceedApplyResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12345</p>
     */
    @NameInMap("applyId")
    public Long applyId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("applyIntentionInfoDO")
    public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>出差</p>
     */
    @NameInMap("btripCause")
    public String btripCause;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding12345</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>出差</p>
     */
    @NameInMap("exceedReason")
    public String exceedReason;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>16</p>
     */
    @NameInMap("exceedType")
    public Integer exceedType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>210000</p>
     */
    @NameInMap("originStandard")
    public String originStandard;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2021-07-08 15:23:56</p>
     */
    @NameInMap("submitTime")
    public String submitTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0001A1100000007EX08O</p>
     */
    @NameInMap("thirdpartApplyId")
    public String thirdpartApplyId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>weifeng</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-07-08</p>
         */
        @NameInMap("checkIn")
        public String checkIn;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-07-08</p>
         */
        @NameInMap("checkOut")
        public String checkOut;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>SHA</p>
         */
        @NameInMap("cityCode")
        public String cityCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>上海</p>
         */
        @NameInMap("cityName")
        public String cityName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10000</p>
         */
        @NameInMap("price")
        public Long price;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("together")
        public Boolean together;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>16</p>
         */
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
