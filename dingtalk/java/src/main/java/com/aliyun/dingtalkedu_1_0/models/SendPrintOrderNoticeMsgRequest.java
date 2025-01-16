// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SendPrintOrderNoticeMsgRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("createOrderTime")
    public String createOrderTime;

    @NameInMap("deliveryCompanyName")
    public String deliveryCompanyName;

    @NameInMap("deliveryNumber")
    public String deliveryNumber;

    @NameInMap("deliveryTime")
    public String deliveryTime;

    @NameInMap("paymentTime")
    public String paymentTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("price")
    public String price;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sceneCode")
    public String sceneCode;

    public static SendPrintOrderNoticeMsgRequest build(java.util.Map<String, ?> map) throws Exception {
        SendPrintOrderNoticeMsgRequest self = new SendPrintOrderNoticeMsgRequest();
        return TeaModel.build(map, self);
    }

    public SendPrintOrderNoticeMsgRequest setCreateOrderTime(String createOrderTime) {
        this.createOrderTime = createOrderTime;
        return this;
    }
    public String getCreateOrderTime() {
        return this.createOrderTime;
    }

    public SendPrintOrderNoticeMsgRequest setDeliveryCompanyName(String deliveryCompanyName) {
        this.deliveryCompanyName = deliveryCompanyName;
        return this;
    }
    public String getDeliveryCompanyName() {
        return this.deliveryCompanyName;
    }

    public SendPrintOrderNoticeMsgRequest setDeliveryNumber(String deliveryNumber) {
        this.deliveryNumber = deliveryNumber;
        return this;
    }
    public String getDeliveryNumber() {
        return this.deliveryNumber;
    }

    public SendPrintOrderNoticeMsgRequest setDeliveryTime(String deliveryTime) {
        this.deliveryTime = deliveryTime;
        return this;
    }
    public String getDeliveryTime() {
        return this.deliveryTime;
    }

    public SendPrintOrderNoticeMsgRequest setPaymentTime(String paymentTime) {
        this.paymentTime = paymentTime;
        return this;
    }
    public String getPaymentTime() {
        return this.paymentTime;
    }

    public SendPrintOrderNoticeMsgRequest setPrice(String price) {
        this.price = price;
        return this;
    }
    public String getPrice() {
        return this.price;
    }

    public SendPrintOrderNoticeMsgRequest setSceneCode(String sceneCode) {
        this.sceneCode = sceneCode;
        return this;
    }
    public String getSceneCode() {
        return this.sceneCode;
    }

}
