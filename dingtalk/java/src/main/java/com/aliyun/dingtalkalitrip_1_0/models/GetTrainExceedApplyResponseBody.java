// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetTrainExceedApplyResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("applyId")
    public Long applyId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("applyIntentionInfoDO")
    public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO;

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

    public static GetTrainExceedApplyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTrainExceedApplyResponseBody self = new GetTrainExceedApplyResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTrainExceedApplyResponseBody setApplyId(Long applyId) {
        this.applyId = applyId;
        return this;
    }
    public Long getApplyId() {
        return this.applyId;
    }

    public GetTrainExceedApplyResponseBody setApplyIntentionInfoDO(GetTrainExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO) {
        this.applyIntentionInfoDO = applyIntentionInfoDO;
        return this;
    }
    public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO getApplyIntentionInfoDO() {
        return this.applyIntentionInfoDO;
    }

    public GetTrainExceedApplyResponseBody setBtripCause(String btripCause) {
        this.btripCause = btripCause;
        return this;
    }
    public String getBtripCause() {
        return this.btripCause;
    }

    public GetTrainExceedApplyResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetTrainExceedApplyResponseBody setExceedReason(String exceedReason) {
        this.exceedReason = exceedReason;
        return this;
    }
    public String getExceedReason() {
        return this.exceedReason;
    }

    public GetTrainExceedApplyResponseBody setExceedType(Integer exceedType) {
        this.exceedType = exceedType;
        return this;
    }
    public Integer getExceedType() {
        return this.exceedType;
    }

    public GetTrainExceedApplyResponseBody setOriginStandard(String originStandard) {
        this.originStandard = originStandard;
        return this;
    }
    public String getOriginStandard() {
        return this.originStandard;
    }

    public GetTrainExceedApplyResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public GetTrainExceedApplyResponseBody setSubmitTime(String submitTime) {
        this.submitTime = submitTime;
        return this;
    }
    public String getSubmitTime() {
        return this.submitTime;
    }

    public GetTrainExceedApplyResponseBody setThirdpartApplyId(String thirdpartApplyId) {
        this.thirdpartApplyId = thirdpartApplyId;
        return this;
    }
    public String getThirdpartApplyId() {
        return this.thirdpartApplyId;
    }

    public GetTrainExceedApplyResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class GetTrainExceedApplyResponseBodyApplyIntentionInfoDO extends TeaModel {
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
        @NameInMap("arrStation")
        public String arrStation;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("arrTime")
        public String arrTime;

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
        @NameInMap("depStation")
        public String depStation;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("depTime")
        public String depTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("price")
        public Long price;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("seatName")
        public String seatName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("trainNo")
        public String trainNo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("trainTypeDesc")
        public String trainTypeDesc;

        public static GetTrainExceedApplyResponseBodyApplyIntentionInfoDO build(java.util.Map<String, ?> map) throws Exception {
            GetTrainExceedApplyResponseBodyApplyIntentionInfoDO self = new GetTrainExceedApplyResponseBodyApplyIntentionInfoDO();
            return TeaModel.build(map, self);
        }

        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO setArrCity(String arrCity) {
            this.arrCity = arrCity;
            return this;
        }
        public String getArrCity() {
            return this.arrCity;
        }

        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO setArrCityName(String arrCityName) {
            this.arrCityName = arrCityName;
            return this;
        }
        public String getArrCityName() {
            return this.arrCityName;
        }

        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO setArrStation(String arrStation) {
            this.arrStation = arrStation;
            return this;
        }
        public String getArrStation() {
            return this.arrStation;
        }

        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO setArrTime(String arrTime) {
            this.arrTime = arrTime;
            return this;
        }
        public String getArrTime() {
            return this.arrTime;
        }

        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO setDepCity(String depCity) {
            this.depCity = depCity;
            return this;
        }
        public String getDepCity() {
            return this.depCity;
        }

        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO setDepCityName(String depCityName) {
            this.depCityName = depCityName;
            return this;
        }
        public String getDepCityName() {
            return this.depCityName;
        }

        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO setDepStation(String depStation) {
            this.depStation = depStation;
            return this;
        }
        public String getDepStation() {
            return this.depStation;
        }

        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO setDepTime(String depTime) {
            this.depTime = depTime;
            return this;
        }
        public String getDepTime() {
            return this.depTime;
        }

        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO setPrice(Long price) {
            this.price = price;
            return this;
        }
        public Long getPrice() {
            return this.price;
        }

        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO setSeatName(String seatName) {
            this.seatName = seatName;
            return this;
        }
        public String getSeatName() {
            return this.seatName;
        }

        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO setTrainNo(String trainNo) {
            this.trainNo = trainNo;
            return this;
        }
        public String getTrainNo() {
            return this.trainNo;
        }

        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO setTrainTypeDesc(String trainTypeDesc) {
            this.trainTypeDesc = trainTypeDesc;
            return this;
        }
        public String getTrainTypeDesc() {
            return this.trainTypeDesc;
        }

    }

}
