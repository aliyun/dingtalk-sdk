// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class QueryUnionOrderResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>tanant1231</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("flightList")
    public java.util.List<QueryUnionOrderResponseBodyFlightList> flightList;

    @NameInMap("hotelList")
    public java.util.List<QueryUnionOrderResponseBodyHotelList> hotelList;

    @NameInMap("trainList")
    public java.util.List<QueryUnionOrderResponseBodyTrainList> trainList;

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
         * <strong>example:</strong>
         * <p>1231</p>
         */
        @NameInMap("flightOrderId")
        public Long flightOrderId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
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
         * <strong>example:</strong>
         * <p>12312</p>
         */
        @NameInMap("hotelOrderId")
        public Long hotelOrderId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
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
         * <strong>example:</strong>
         * <p>231231</p>
         */
        @NameInMap("trainOrderId")
        public Long trainOrderId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
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
         * <strong>example:</strong>
         * <p>1231</p>
         */
        @NameInMap("vehicleOrderId")
        public Long vehicleOrderId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
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
