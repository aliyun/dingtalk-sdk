// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetFlightExceedApplyResponseBody extends TeaModel {
    /**
     * <p>商旅超标审批单id</p>
     */
    @NameInMap("applyId")
    public Long applyId;

    /**
     * <p>意向出行信息</p>
     */
    @NameInMap("applyIntentionInfoDO")
    public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO;

    /**
     * <p>出差原因</p>
     */
    @NameInMap("btripCause")
    public String btripCause;

    /**
     * <p>第三方企业id</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>超标原因</p>
     */
    @NameInMap("exceedReason")
    public String exceedReason;

    /**
     * <p>超标类型，1:折扣 2,8,10:时间 3,9,11:折扣和时间</p>
     */
    @NameInMap("exceedType")
    public Integer exceedType;

    /**
     * <p>原差旅标准</p>
     */
    @NameInMap("originStandard")
    public String originStandard;

    /**
     * <p>审批单状态 0:审批中 1:已同意 2:已拒绝</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>审批单提交时间</p>
     */
    @NameInMap("submitTime")
    public String submitTime;

    /**
     * <p>第三方出差审批单号</p>
     */
    @NameInMap("thirdpartApplyId")
    public String thirdpartApplyId;

    /**
     * <p>第三方用户id</p>
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
         * <p>到达城市三字码</p>
         */
        @NameInMap("arrCity")
        public String arrCity;

        /**
         * <p>到达城市名称</p>
         */
        @NameInMap("arrCityName")
        public String arrCityName;

        /**
         * <p>到达时间</p>
         */
        @NameInMap("arrTime")
        public String arrTime;

        /**
         * <p>超标的舱位，F：头等舱 C：商务舱 Y：经济舱 P：超值经济舱</p>
         */
        @NameInMap("cabin")
        public String cabin;

        /**
         * <p>申请超标的舱等 0：头等舱 1：商务舱 2：经济舱 3：超值经济舱</p>
         */
        @NameInMap("cabinClass")
        public Integer cabinClass;

        /**
         * <p>舱等描述，头等舱，商务舱，经济舱，超值经济舱</p>
         */
        @NameInMap("cabinClassStr")
        public String cabinClassStr;

        /**
         * <p>出发城市三字码</p>
         */
        @NameInMap("depCity")
        public String depCity;

        /**
         * <p>出发城市名称</p>
         */
        @NameInMap("depCityName")
        public String depCityName;

        /**
         * <p>出发时间</p>
         */
        @NameInMap("depTime")
        public String depTime;

        /**
         * <p>折扣</p>
         */
        @NameInMap("discount")
        public Double discount;

        /**
         * <p>航班号</p>
         */
        @NameInMap("flightNo")
        public String flightNo;

        /**
         * <p>意向航班价格（元）</p>
         */
        @NameInMap("price")
        public Long price;

        /**
         * <p>超标类型，1:折扣 2,8,10:时间 3,9,11:折扣和时间</p>
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
