// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SubmitTripApprovalProcessRequest extends TeaModel {
    @NameInMap("itineraries")
    public java.util.List<SubmitTripApprovalProcessRequestItineraries> itineraries;

    /**
     * <strong>example:</strong>
     * <p>PROC_XXXX</p>
     */
    @NameInMap("processCode")
    public String processCode;

    /**
     * <strong>example:</strong>
     * <p>拜访客户</p>
     */
    @NameInMap("reason")
    public String reason;

    /**
     * <strong>example:</strong>
     * <p>5046195764756652</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SubmitTripApprovalProcessRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitTripApprovalProcessRequest self = new SubmitTripApprovalProcessRequest();
        return TeaModel.build(map, self);
    }

    public SubmitTripApprovalProcessRequest setItineraries(java.util.List<SubmitTripApprovalProcessRequestItineraries> itineraries) {
        this.itineraries = itineraries;
        return this;
    }
    public java.util.List<SubmitTripApprovalProcessRequestItineraries> getItineraries() {
        return this.itineraries;
    }

    public SubmitTripApprovalProcessRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public SubmitTripApprovalProcessRequest setReason(String reason) {
        this.reason = reason;
        return this;
    }
    public String getReason() {
        return this.reason;
    }

    public SubmitTripApprovalProcessRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class SubmitTripApprovalProcessRequestItineraries extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2026-01-20 09:00</p>
         */
        @NameInMap("departureTime")
        public String departureTime;

        /**
         * <strong>example:</strong>
         * <p>北京</p>
         */
        @NameInMap("destination")
        public String destination;

        /**
         * <strong>example:</strong>
         * <p>望京阿里巴巴园区</p>
         */
        @NameInMap("destinationDetail")
        public String destinationDetail;

        /**
         * <strong>example:</strong>
         * <p>杭州</p>
         */
        @NameInMap("placeOfDeparture")
        public String placeOfDeparture;

        /**
         * <strong>example:</strong>
         * <p>余杭区文一西路969号</p>
         */
        @NameInMap("placeOfDepartureDetail")
        public String placeOfDepartureDetail;

        /**
         * <strong>example:</strong>
         * <p>2026-01-22 09:00</p>
         */
        @NameInMap("returnTime")
        public String returnTime;

        /**
         * <strong>example:</strong>
         * <p>单程</p>
         */
        @NameInMap("singleOrReturn")
        public String singleOrReturn;

        /**
         * <strong>example:</strong>
         * <p>飞机</p>
         */
        @NameInMap("vehicle")
        public String vehicle;

        public static SubmitTripApprovalProcessRequestItineraries build(java.util.Map<String, ?> map) throws Exception {
            SubmitTripApprovalProcessRequestItineraries self = new SubmitTripApprovalProcessRequestItineraries();
            return TeaModel.build(map, self);
        }

        public SubmitTripApprovalProcessRequestItineraries setDepartureTime(String departureTime) {
            this.departureTime = departureTime;
            return this;
        }
        public String getDepartureTime() {
            return this.departureTime;
        }

        public SubmitTripApprovalProcessRequestItineraries setDestination(String destination) {
            this.destination = destination;
            return this;
        }
        public String getDestination() {
            return this.destination;
        }

        public SubmitTripApprovalProcessRequestItineraries setDestinationDetail(String destinationDetail) {
            this.destinationDetail = destinationDetail;
            return this;
        }
        public String getDestinationDetail() {
            return this.destinationDetail;
        }

        public SubmitTripApprovalProcessRequestItineraries setPlaceOfDeparture(String placeOfDeparture) {
            this.placeOfDeparture = placeOfDeparture;
            return this;
        }
        public String getPlaceOfDeparture() {
            return this.placeOfDeparture;
        }

        public SubmitTripApprovalProcessRequestItineraries setPlaceOfDepartureDetail(String placeOfDepartureDetail) {
            this.placeOfDepartureDetail = placeOfDepartureDetail;
            return this;
        }
        public String getPlaceOfDepartureDetail() {
            return this.placeOfDepartureDetail;
        }

        public SubmitTripApprovalProcessRequestItineraries setReturnTime(String returnTime) {
            this.returnTime = returnTime;
            return this;
        }
        public String getReturnTime() {
            return this.returnTime;
        }

        public SubmitTripApprovalProcessRequestItineraries setSingleOrReturn(String singleOrReturn) {
            this.singleOrReturn = singleOrReturn;
            return this;
        }
        public String getSingleOrReturn() {
            return this.singleOrReturn;
        }

        public SubmitTripApprovalProcessRequestItineraries setVehicle(String vehicle) {
            this.vehicle = vehicle;
            return this;
        }
        public String getVehicle() {
            return this.vehicle;
        }

    }

}
