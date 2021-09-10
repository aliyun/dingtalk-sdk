// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetFlightExceedApplyResponseBody extends TeaModel {
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

    // 超标类型，1:折扣 2,8,10:时间 3,9,11:折扣和时间
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
    public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO;

    // 第三方出差审批单号
    @NameInMap("thirdpartApplyId")
    public String thirdpartApplyId;

    public static GetFlightExceedApplyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFlightExceedApplyResponseBody self = new GetFlightExceedApplyResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFlightExceedApplyResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetFlightExceedApplyResponseBody setApplyId(Long applyId) {
        this.applyId = applyId;
        return this;
    }
    public Long getApplyId() {
        return this.applyId;
    }

    public GetFlightExceedApplyResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public GetFlightExceedApplyResponseBody setBtripCause(String btripCause) {
        this.btripCause = btripCause;
        return this;
    }
    public String getBtripCause() {
        return this.btripCause;
    }

    public GetFlightExceedApplyResponseBody setExceedType(Integer exceedType) {
        this.exceedType = exceedType;
        return this;
    }
    public Integer getExceedType() {
        return this.exceedType;
    }

    public GetFlightExceedApplyResponseBody setExceedReason(String exceedReason) {
        this.exceedReason = exceedReason;
        return this;
    }
    public String getExceedReason() {
        return this.exceedReason;
    }

    public GetFlightExceedApplyResponseBody setOriginStandard(String originStandard) {
        this.originStandard = originStandard;
        return this;
    }
    public String getOriginStandard() {
        return this.originStandard;
    }

    public GetFlightExceedApplyResponseBody setSubmitTime(String submitTime) {
        this.submitTime = submitTime;
        return this;
    }
    public String getSubmitTime() {
        return this.submitTime;
    }

    public GetFlightExceedApplyResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetFlightExceedApplyResponseBody setApplyIntentionInfoDO(GetFlightExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO) {
        this.applyIntentionInfoDO = applyIntentionInfoDO;
        return this;
    }
    public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO getApplyIntentionInfoDO() {
        return this.applyIntentionInfoDO;
    }

    public GetFlightExceedApplyResponseBody setThirdpartApplyId(String thirdpartApplyId) {
        this.thirdpartApplyId = thirdpartApplyId;
        return this;
    }
    public String getThirdpartApplyId() {
        return this.thirdpartApplyId;
    }

    public static class GetFlightExceedApplyResponseBodyApplyIntentionInfoDO extends TeaModel {
        // 到达城市三字码
        @NameInMap("arrCity")
        public String arrCity;

        // 到达城市名称
        @NameInMap("arrCityName")
        public String arrCityName;

        // 到达时间
        @NameInMap("arrTime")
        public String arrTime;

        // 超标的舱位，F：头等舱 C：商务舱 Y：经济舱 P：超值经济舱
        @NameInMap("cabin")
        public String cabin;

        // 申请超标的舱等 0：头等舱 1：商务舱 2：经济舱 3：超值经济舱
        @NameInMap("cabinClass")
        public Integer cabinClass;

        // 舱等描述，头等舱，商务舱，经济舱，超值经济舱
        @NameInMap("cabinClassStr")
        public String cabinClassStr;

        // 出发城市三字码
        @NameInMap("depCity")
        public String depCity;

        // 出发城市名称
        @NameInMap("depCityName")
        public String depCityName;

        // 出发时间
        @NameInMap("depTime")
        public String depTime;

        // 折扣
        @NameInMap("discount")
        public Double discount;

        // 航班号
        @NameInMap("flightNo")
        public String flightNo;

        // 意向航班价格（元）
        @NameInMap("price")
        public Long price;

        // 超标类型，1:折扣 2,8,10:时间 3,9,11:折扣和时间
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
