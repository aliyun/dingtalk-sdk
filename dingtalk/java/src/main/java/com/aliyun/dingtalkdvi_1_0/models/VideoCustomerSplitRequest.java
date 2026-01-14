// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class VideoCustomerSplitRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("customer")
    public VideoCustomerSplitRequestCustomer customer;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("segmentId")
    public String segmentId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static VideoCustomerSplitRequest build(java.util.Map<String, ?> map) throws Exception {
        VideoCustomerSplitRequest self = new VideoCustomerSplitRequest();
        return TeaModel.build(map, self);
    }

    public VideoCustomerSplitRequest setCustomer(VideoCustomerSplitRequestCustomer customer) {
        this.customer = customer;
        return this;
    }
    public VideoCustomerSplitRequestCustomer getCustomer() {
        return this.customer;
    }

    public VideoCustomerSplitRequest setSegmentId(String segmentId) {
        this.segmentId = segmentId;
        return this;
    }
    public String getSegmentId() {
        return this.segmentId;
    }

    public VideoCustomerSplitRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class VideoCustomerSplitRequestCustomerCustomersAppearance extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("videoId")
        public String videoId;

        public static VideoCustomerSplitRequestCustomerCustomersAppearance build(java.util.Map<String, ?> map) throws Exception {
            VideoCustomerSplitRequestCustomerCustomersAppearance self = new VideoCustomerSplitRequestCustomerCustomersAppearance();
            return TeaModel.build(map, self);
        }

        public VideoCustomerSplitRequestCustomerCustomersAppearance setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public VideoCustomerSplitRequestCustomerCustomersAppearance setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public VideoCustomerSplitRequestCustomerCustomersAppearance setVideoId(String videoId) {
            this.videoId = videoId;
            return this;
        }
        public String getVideoId() {
            return this.videoId;
        }

    }

    public static class VideoCustomerSplitRequestCustomerCustomers extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("appearance")
        public VideoCustomerSplitRequestCustomerCustomersAppearance appearance;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("customerId")
        public String customerId;

        public static VideoCustomerSplitRequestCustomerCustomers build(java.util.Map<String, ?> map) throws Exception {
            VideoCustomerSplitRequestCustomerCustomers self = new VideoCustomerSplitRequestCustomerCustomers();
            return TeaModel.build(map, self);
        }

        public VideoCustomerSplitRequestCustomerCustomers setAppearance(VideoCustomerSplitRequestCustomerCustomersAppearance appearance) {
            this.appearance = appearance;
            return this;
        }
        public VideoCustomerSplitRequestCustomerCustomersAppearance getAppearance() {
            return this.appearance;
        }

        public VideoCustomerSplitRequestCustomerCustomers setCustomerId(String customerId) {
            this.customerId = customerId;
            return this;
        }
        public String getCustomerId() {
            return this.customerId;
        }

    }

    public static class VideoCustomerSplitRequestCustomer extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("customers")
        public java.util.List<VideoCustomerSplitRequestCustomerCustomers> customers;

        public static VideoCustomerSplitRequestCustomer build(java.util.Map<String, ?> map) throws Exception {
            VideoCustomerSplitRequestCustomer self = new VideoCustomerSplitRequestCustomer();
            return TeaModel.build(map, self);
        }

        public VideoCustomerSplitRequestCustomer setCustomers(java.util.List<VideoCustomerSplitRequestCustomerCustomers> customers) {
            this.customers = customers;
            return this;
        }
        public java.util.List<VideoCustomerSplitRequestCustomerCustomers> getCustomers() {
            return this.customers;
        }

    }

}
