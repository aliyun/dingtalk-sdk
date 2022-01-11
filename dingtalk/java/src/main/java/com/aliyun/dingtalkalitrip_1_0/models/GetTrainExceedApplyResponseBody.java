// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetTrainExceedApplyResponseBody extends TeaModel {
    // 商旅超标审批单id
    @NameInMap("applyId")
    public Long applyId;

    // 意向出行信息
    @NameInMap("applyIntentionInfoDO")
    public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO;

    // 出差原因
    @NameInMap("btripCause")
    public String btripCause;

    // 第三方企业id
    @NameInMap("corpId")
    public String corpId;

    // 超标原因
    @NameInMap("exceedReason")
    public String exceedReason;

    // 超标类型，32：坐席超标
    @NameInMap("exceedType")
    public Integer exceedType;

    // 原差旅标准
    @NameInMap("originStandard")
    public String originStandard;

    // 审批单状态 0:审批中 1:已同意 2:已拒绝
    @NameInMap("status")
    public Integer status;

    // 审批单提交时间
    @NameInMap("submitTime")
    public String submitTime;

    // 第三方出差审批单号
    @NameInMap("thirdpartApplyId")
    public String thirdpartApplyId;

    // 第三方用户id
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
        // 到达城市三字码
        @NameInMap("arrCity")
        public String arrCity;

        // 到达城市名
        @NameInMap("arrCityName")
        public String arrCityName;

        // 到达站点名称
        @NameInMap("arrStation")
        public String arrStation;

        // 到达时间
        @NameInMap("arrTime")
        public String arrTime;

        // 出发城市三字码
        @NameInMap("depCity")
        public String depCity;

        // 出发城市名
        @NameInMap("depCityName")
        public String depCityName;

        // 出发站点名称
        @NameInMap("depStation")
        public String depStation;

        // 出发时间
        @NameInMap("depTime")
        public String depTime;

        // 意向坐席价格（分）
        @NameInMap("price")
        public Long price;

        // 意向坐席名称
        @NameInMap("seatName")
        public String seatName;

        // 意向车次号
        @NameInMap("trainNo")
        public String trainNo;

        // 意向车次类型
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
