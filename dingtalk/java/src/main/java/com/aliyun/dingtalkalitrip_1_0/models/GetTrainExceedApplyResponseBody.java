// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class GetTrainExceedApplyResponseBody extends TeaModel {
    /**
     * <p>商旅超标审批单id</p>
     */
    @NameInMap("applyId")
    public Long applyId;

    /**
     * <p>意向出行信息</p>
     */
    @NameInMap("applyIntentionInfoDO")
    public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO applyIntentionInfoDO;

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
     * <p>超标类型，32：坐席超标</p>
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
         * <p>到达城市三字码</p>
         */
        @NameInMap("arrCity")
        public String arrCity;

        /**
         * <p>到达城市名</p>
         */
        @NameInMap("arrCityName")
        public String arrCityName;

        /**
         * <p>到达站点名称</p>
         */
        @NameInMap("arrStation")
        public String arrStation;

        /**
         * <p>到达时间</p>
         */
        @NameInMap("arrTime")
        public String arrTime;

        /**
         * <p>出发城市三字码</p>
         */
        @NameInMap("depCity")
        public String depCity;

        /**
         * <p>出发城市名</p>
         */
        @NameInMap("depCityName")
        public String depCityName;

        /**
         * <p>出发站点名称</p>
         */
        @NameInMap("depStation")
        public String depStation;

        /**
         * <p>出发时间</p>
         */
        @NameInMap("depTime")
        public String depTime;

        /**
         * <p>意向坐席价格（分）</p>
         */
        @NameInMap("price")
        public Long price;

        /**
         * <p>意向坐席名称</p>
         */
        @NameInMap("seatName")
        public String seatName;

        /**
         * <p>意向车次号</p>
         */
        @NameInMap("trainNo")
        public String trainNo;

        /**
         * <p>意向车次类型</p>
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
