// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class QueryUnionOrderResponseBody extends TeaModel {
    // 飞机订单信息
    @NameInMap("flightList")
    public java.util.List<QueryUnionOrderResponseBodyFlightList> flightList;

    // 企业id
    @NameInMap("corpId")
    public String corpId;

    // 火车订单信息
    @NameInMap("trainList")
    public java.util.List<QueryUnionOrderResponseBodyTrainList> trainList;

    // 酒店订单信息
    @NameInMap("hotelList")
    public java.util.List<QueryUnionOrderResponseBodyHotelList> hotelList;

    // 用车订单信息
    @NameInMap("vehicleList")
    public java.util.List<QueryUnionOrderResponseBodyVehicleList> vehicleList;

    public static QueryUnionOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUnionOrderResponseBody self = new QueryUnionOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUnionOrderResponseBody setFlightList(java.util.List<QueryUnionOrderResponseBodyFlightList> flightList) {
        this.flightList = flightList;
        return this;
    }
    public java.util.List<QueryUnionOrderResponseBodyFlightList> getFlightList() {
        return this.flightList;
    }

    public QueryUnionOrderResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryUnionOrderResponseBody setTrainList(java.util.List<QueryUnionOrderResponseBodyTrainList> trainList) {
        this.trainList = trainList;
        return this;
    }
    public java.util.List<QueryUnionOrderResponseBodyTrainList> getTrainList() {
        return this.trainList;
    }

    public QueryUnionOrderResponseBody setHotelList(java.util.List<QueryUnionOrderResponseBodyHotelList> hotelList) {
        this.hotelList = hotelList;
        return this;
    }
    public java.util.List<QueryUnionOrderResponseBodyHotelList> getHotelList() {
        return this.hotelList;
    }

    public QueryUnionOrderResponseBody setVehicleList(java.util.List<QueryUnionOrderResponseBodyVehicleList> vehicleList) {
        this.vehicleList = vehicleList;
        return this;
    }
    public java.util.List<QueryUnionOrderResponseBodyVehicleList> getVehicleList() {
        return this.vehicleList;
    }

    public static class QueryUnionOrderResponseBodyFlightList extends TeaModel {
        // 订单id
        @NameInMap("id")
        public Long id;

        // 订单状态：0待支付,1出票中,2已关闭,3有改签单,4有退票单,5出票成功,6退票申请中,7改签申请中
        @NameInMap("status")
        public Long status;

        public static QueryUnionOrderResponseBodyFlightList build(java.util.Map<String, ?> map) throws Exception {
            QueryUnionOrderResponseBodyFlightList self = new QueryUnionOrderResponseBodyFlightList();
            return TeaModel.build(map, self);
        }

        public QueryUnionOrderResponseBodyFlightList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryUnionOrderResponseBodyFlightList setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

    }

    public static class QueryUnionOrderResponseBodyTrainList extends TeaModel {
        // 火车订单号
        @NameInMap("id")
        public Long id;

        // 订单状态：0待支付,1出票中,2已关闭,3,改签成功,4退票成功,5出票完成,6退票申请中,7改签申请中,8已出票,已发货,9出票失败,10改签失败,11退票失败
        @NameInMap("status")
        public Long status;

        public static QueryUnionOrderResponseBodyTrainList build(java.util.Map<String, ?> map) throws Exception {
            QueryUnionOrderResponseBodyTrainList self = new QueryUnionOrderResponseBodyTrainList();
            return TeaModel.build(map, self);
        }

        public QueryUnionOrderResponseBodyTrainList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryUnionOrderResponseBodyTrainList setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

    }

    public static class QueryUnionOrderResponseBodyHotelList extends TeaModel {
        // 酒店订单号
        @NameInMap("id")
        public Long id;

        // 订单状态1:等待确认,2:等待付款,3:预订成功,4:申请退款,5:退款成功,6:已关闭,7:结账成功,8:支付成功
        @NameInMap("orderStatus")
        public Long orderStatus;

        public static QueryUnionOrderResponseBodyHotelList build(java.util.Map<String, ?> map) throws Exception {
            QueryUnionOrderResponseBodyHotelList self = new QueryUnionOrderResponseBodyHotelList();
            return TeaModel.build(map, self);
        }

        public QueryUnionOrderResponseBodyHotelList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryUnionOrderResponseBodyHotelList setOrderStatus(Long orderStatus) {
            this.orderStatus = orderStatus;
            return this;
        }
        public Long getOrderStatus() {
            return this.orderStatus;
        }

    }

    public static class QueryUnionOrderResponseBodyVehicleList extends TeaModel {
        // 用车订单号
        @NameInMap("id")
        public Long id;

        // 订单状态:0:初始状态,1:已超时,2:派单成功,3:派单失败,4:已退款,5:已支付,6:已取消
        @NameInMap("orderStatus")
        public Long orderStatus;

        public static QueryUnionOrderResponseBodyVehicleList build(java.util.Map<String, ?> map) throws Exception {
            QueryUnionOrderResponseBodyVehicleList self = new QueryUnionOrderResponseBodyVehicleList();
            return TeaModel.build(map, self);
        }

        public QueryUnionOrderResponseBodyVehicleList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryUnionOrderResponseBodyVehicleList setOrderStatus(Long orderStatus) {
            this.orderStatus = orderStatus;
            return this;
        }
        public Long getOrderStatus() {
            return this.orderStatus;
        }

    }

}
