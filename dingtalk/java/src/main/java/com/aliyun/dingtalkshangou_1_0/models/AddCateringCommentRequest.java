// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkshangou_1_0.models;

import com.aliyun.tea.*;

public class AddCateringCommentRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("commentId")
    public String commentId;

    @NameInMap("orderId")
    public String orderId;

    @NameInMap("rateContent")
    public String rateContent;

    @NameInMap("ratedAt")
    public Long ratedAt;

    @NameInMap("rating")
    public Double rating;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("shopId")
    public String shopId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("source")
    public String source;

    @NameInMap("status")
    public Integer status;

    public static AddCateringCommentRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCateringCommentRequest self = new AddCateringCommentRequest();
        return TeaModel.build(map, self);
    }

    public AddCateringCommentRequest setCommentId(String commentId) {
        this.commentId = commentId;
        return this;
    }
    public String getCommentId() {
        return this.commentId;
    }

    public AddCateringCommentRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public AddCateringCommentRequest setRateContent(String rateContent) {
        this.rateContent = rateContent;
        return this;
    }
    public String getRateContent() {
        return this.rateContent;
    }

    public AddCateringCommentRequest setRatedAt(Long ratedAt) {
        this.ratedAt = ratedAt;
        return this;
    }
    public Long getRatedAt() {
        return this.ratedAt;
    }

    public AddCateringCommentRequest setRating(Double rating) {
        this.rating = rating;
        return this;
    }
    public Double getRating() {
        return this.rating;
    }

    public AddCateringCommentRequest setShopId(String shopId) {
        this.shopId = shopId;
        return this;
    }
    public String getShopId() {
        return this.shopId;
    }

    public AddCateringCommentRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public AddCateringCommentRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
