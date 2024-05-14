// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetFlightExceedApplyResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("applyId")
    public Long applyId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("applyIntentionInfoDO")
    public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("btripCause")
    public String btripCause;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("exceedReason")
    public String exceedReason;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("exceedType")
    public Integer exceedType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("originStandard")
    public String originStandard;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("submitTime")
    public String submitTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("thirdpartApplyId")
    public String thirdpartApplyId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetFlightExceedApplyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFlightExceedApplyResponseBody self = new GetFlightExceedApplyResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFlightExceedApplyResponseBody setApplyId(Long applyId) {
        this.applyId = applyId;
        return this;
    }
    public Long getApplyId() {
        return this.applyId;
    }

    public GetFlightExceedApplyResponseBody setApplyIntentionInfoDO(GetFlightExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO) {
        this.applyIntentionInfoDO = applyIntentionInfoDO;
        return this;
    }
    public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO getApplyIntentionInfoDO() {
        return this.applyIntentionInfoDO;
    }

    public GetFlightExceedApplyResponseBody setBtripCause(String btripCause) {
        this.btripCause = btripCause;
        return this;
    }
    public String getBtripCause() {
        return this.btripCause;
    }

    public GetFlightExceedApplyResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetFlightExceedApplyResponseBody setExceedReason(String exceedReason) {
        this.exceedReason = exceedReason;
        return this;
    }
    public String getExceedReason() {
        return this.exceedReason;
    }

    public GetFlightExceedApplyResponseBody setExceedType(Integer exceedType) {
        this.exceedType = exceedType;
        return this;
    }
    public Integer getExceedType() {
        return this.exceedType;
    }

    public GetFlightExceedApplyResponseBody setOriginStandard(String originStandard) {
        this.originStandard = originStandard;
        return this;
    }
    public String getOriginStandard() {
        return this.originStandard;
    }

    public GetFlightExceedApplyResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public GetFlightExceedApplyResponseBody setSubmitTime(String submitTime) {
        this.submitTime = submitTime;
        return this;
    }
    public String getSubmitTime() {
        return this.submitTime;
    }

    public GetFlightExceedApplyResponseBody setThirdpartApplyId(String thirdpartApplyId) {
        this.thirdpartApplyId = thirdpartApplyId;
        return this;
    }
    public String getThirdpartApplyId() {
        return this.thirdpartApplyId;
    }

    public GetFlightExceedApplyResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class GetFlightExceedApplyResponseBodyApplyIntentionInfoDO extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("arrCity")
        public String arrCity;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("arrCityName")
        public String arrCityName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("arrTime")
        public String arrTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("cabin")
        public String cabin;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("cabinClass")
        public Integer cabinClass;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("cabinClassStr")
        public String cabinClassStr;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("depCity")
        public String depCity;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("depCityName")
        public String depCityName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("depTime")
        public String depTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("discount")
        public Double discount;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("flightNo")
        public String flightNo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("price")
        public Long price;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public Integer type;

        public static GetFlightExceedApplyResponseBodyApplyIntentionInfoDO build(java.util.Map<String, ?> map) throws Exception {
            GetFlightExceedApplyResponseBodyApplyIntentionInfoDO self = new GetFlightExceedApplyResponseBodyApplyIntentionInfoDO();
            return TeaModel.build(map, self);
        }

        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO setArrCity(String arrCity) {
            this.arrCity = arrCity;
            return this;
        }
        public String getArrCity() {
            return this.arrCity;
        }

        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO setArrCityName(String arrCityName) {
            this.arrCityName = arrCityName;
            return this;
        }
        public String getArrCityName() {
            return this.arrCityName;
        }

        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO setArrTime(String arrTime) {
            this.arrTime = arrTime;
            return this;
        }
        public String getArrTime() {
            return this.arrTime;
        }

        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO setCabin(String cabin) {
            this.cabin = cabin;
            return this;
        }
        public String getCabin() {
            return this.cabin;
        }

        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO setCabinClass(Integer cabinClass) {
            this.cabinClass = cabinClass;
            return this;
        }
        public Integer getCabinClass() {
            return this.cabinClass;
        }

        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO setCabinClassStr(String cabinClassStr) {
            this.cabinClassStr = cabinClassStr;
            return this;
        }
        public String getCabinClassStr() {
            return this.cabinClassStr;
        }

        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO setDepCity(String depCity) {
            this.depCity = depCity;
            return this;
        }
        public String getDepCity() {
            return this.depCity;
        }

        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO setDepCityName(String depCityName) {
            this.depCityName = depCityName;
            return this;
        }
        public String getDepCityName() {
            return this.depCityName;
        }

        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO setDepTime(String depTime) {
            this.depTime = depTime;
            return this;
        }
        public String getDepTime() {
            return this.depTime;
        }

        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO setDiscount(Double discount) {
            this.discount = discount;
            return this;
        }
        public Double getDiscount() {
            return this.discount;
        }

        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO setFlightNo(String flightNo) {
            this.flightNo = flightNo;
            return this;
        }
        public String getFlightNo() {
            return this.flightNo;
        }

        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO setPrice(Long price) {
            this.price = price;
            return this;
        }
        public Long getPrice() {
            return this.price;
        }

        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

}
