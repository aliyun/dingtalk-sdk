// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class QueryUnionOrderResponseBody extends TeaModel {
    /**
     * <p>企业id</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>飞机订单信息</p>
     */
    @NameInMap("flightList")
    public java.util.List<QueryUnionOrderResponseBodyFlightList> flightList;

    /**
     * <p>酒店订单信息</p>
     */
    @NameInMap("hotelList")
    public java.util.List<QueryUnionOrderResponseBodyHotelList> hotelList;

    /**
     * <p>火车订单信息</p>
     */
    @NameInMap("trainList")
    public java.util.List<QueryUnionOrderResponseBodyTrainList> trainList;

    /**
     * <p>用车订单信息</p>
     */
    @NameInMap("vehicleList")
    public java.util.List<QueryUnionOrderResponseBodyVehicleList> vehicleList;

    public static QueryUnionOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUnionOrderResponseBody self = new QueryUnionOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUnionOrderResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryUnionOrderResponseBody setFlightList(java.util.List<QueryUnionOrderResponseBodyFlightList> flightList) {
        this.flightList = flightList;
        return this;
    }
    public java.util.List<QueryUnionOrderResponseBodyFlightList> getFlightList() {
        return this.flightList;
    }

    public QueryUnionOrderResponseBody setHotelList(java.util.List<QueryUnionOrderResponseBodyHotelList> hotelList) {
        this.hotelList = hotelList;
        return this;
    }
    public java.util.List<QueryUnionOrderResponseBodyHotelList> getHotelList() {
        return this.hotelList;
    }

    public QueryUnionOrderResponseBody setTrainList(java.util.List<QueryUnionOrderResponseBodyTrainList> trainList) {
        this.trainList = trainList;
        return this;
    }
    public java.util.List<QueryUnionOrderResponseBodyTrainList> getTrainList() {
        return this.trainList;
    }

    public QueryUnionOrderResponseBody setVehicleList(java.util.List<QueryUnionOrderResponseBodyVehicleList> vehicleList) {
        this.vehicleList = vehicleList;
        return this;
    }
    public java.util.List<QueryUnionOrderResponseBodyVehicleList> getVehicleList() {
        return this.vehicleList;
    }

    public static class QueryUnionOrderResponseBodyFlightList extends TeaModel {
        /**
         * <p>订单id</p>
         */
        @NameInMap("flightOrderId")
        public Long flightOrderId;

        /**
         * <p>订单状态：0待支付,1出票中,2已关闭,3有改签单,4有退票单,5出票成功,6退票申请中,7改签申请中</p>
         */
        @NameInMap("flightOrderStatus")
        public Long flightOrderStatus;

        public static QueryUnionOrderResponseBodyFlightList build(java.util.Map<String, ?> map) throws Exception {
            QueryUnionOrderResponseBodyFlightList self = new QueryUnionOrderResponseBodyFlightList();
            return TeaModel.build(map, self);
        }

        public QueryUnionOrderResponseBodyFlightList setFlightOrderId(Long flightOrderId) {
            this.flightOrderId = flightOrderId;
            return this;
        }
        public Long getFlightOrderId() {
            return this.flightOrderId;
        }

        public QueryUnionOrderResponseBodyFlightList setFlightOrderStatus(Long flightOrderStatus) {
            this.flightOrderStatus = flightOrderStatus;
            return this;
        }
        public Long getFlightOrderStatus() {
            return this.flightOrderStatus;
        }

    }

    public static class QueryUnionOrderResponseBodyHotelList extends TeaModel {
        /**
         * <p>酒店订单号</p>
         */
        @NameInMap("hotelOrderId")
        public Long hotelOrderId;

        /**
         * <p>订单状态1:等待确认,2:等待付款,3:预订成功,4:申请退款,5:退款成功,6:已关闭,7:结账成功,8:支付成功</p>
         */
        @NameInMap("hotelOrderStatus")
        public Long hotelOrderStatus;

        public static QueryUnionOrderResponseBodyHotelList build(java.util.Map<String, ?> map) throws Exception {
            QueryUnionOrderResponseBodyHotelList self = new QueryUnionOrderResponseBodyHotelList();
            return TeaModel.build(map, self);
        }

        public QueryUnionOrderResponseBodyHotelList setHotelOrderId(Long hotelOrderId) {
            this.hotelOrderId = hotelOrderId;
            return this;
        }
        public Long getHotelOrderId() {
            return this.hotelOrderId;
        }

        public QueryUnionOrderResponseBodyHotelList setHotelOrderStatus(Long hotelOrderStatus) {
            this.hotelOrderStatus = hotelOrderStatus;
            return this;
        }
        public Long getHotelOrderStatus() {
            return this.hotelOrderStatus;
        }

    }

    public static class QueryUnionOrderResponseBodyTrainList extends TeaModel {
        /**
         * <p>火车订单号</p>
         */
        @NameInMap("trainOrderId")
        public Long trainOrderId;

        /**
         * <p>订单状态：0待支付,1出票中,2已关闭,3,改签成功,4退票成功,5出票完成,6退票申请中,7改签申请中,8已出票,已发货,9出票失败,10改签失败,11退票失败</p>
         */
        @NameInMap("trainOrderstatus")
        public Long trainOrderstatus;

        public static QueryUnionOrderResponseBodyTrainList build(java.util.Map<String, ?> map) throws Exception {
            QueryUnionOrderResponseBodyTrainList self = new QueryUnionOrderResponseBodyTrainList();
            return TeaModel.build(map, self);
        }

        public QueryUnionOrderResponseBodyTrainList setTrainOrderId(Long trainOrderId) {
            this.trainOrderId = trainOrderId;
            return this;
        }
        public Long getTrainOrderId() {
            return this.trainOrderId;
        }

        public QueryUnionOrderResponseBodyTrainList setTrainOrderstatus(Long trainOrderstatus) {
            this.trainOrderstatus = trainOrderstatus;
            return this;
        }
        public Long getTrainOrderstatus() {
            return this.trainOrderstatus;
        }

    }

    public static class QueryUnionOrderResponseBodyVehicleList extends TeaModel {
        /**
         * <p>用车订单号</p>
         */
        @NameInMap("vehicleOrderId")
        public Long vehicleOrderId;

        /**
         * <p>订单状态:0:初始状态,1:已超时,2:派单成功,3:派单失败,4:已退款,5:已支付,6:已取消</p>
         */
        @NameInMap("vehicleOrderStatus")
        public Long vehicleOrderStatus;

        public static QueryUnionOrderResponseBodyVehicleList build(java.util.Map<String, ?> map) throws Exception {
            QueryUnionOrderResponseBodyVehicleList self = new QueryUnionOrderResponseBodyVehicleList();
            return TeaModel.build(map, self);
        }

        public QueryUnionOrderResponseBodyVehicleList setVehicleOrderId(Long vehicleOrderId) {
            this.vehicleOrderId = vehicleOrderId;
            return this;
        }
        public Long getVehicleOrderId() {
            return this.vehicleOrderId;
        }

        public QueryUnionOrderResponseBodyVehicleList setVehicleOrderStatus(Long vehicleOrderStatus) {
            this.vehicleOrderStatus = vehicleOrderStatus;
            return this;
        }
        public Long getVehicleOrderStatus() {
            return this.vehicleOrderStatus;
        }

    }

}
