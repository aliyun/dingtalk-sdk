// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiRetailProductAddRequest extends TeaModel {
    @NameInMap("attribute")
    public java.util.Map<String, String> attribute;

    @NameInMap("barcodes")
    public java.util.List<String> barcodes;

    @NameInMap("brand")
    public String brand;

    @NameInMap("category")
    public String category;

    @NameInMap("imageFileIds")
    public java.util.List<String> imageFileIds;

    @NameInMap("itemNumbers")
    public java.util.List<String> itemNumbers;

    @NameInMap("price")
    public Float price;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("productCode")
    public String productCode;

    /**
     * <strong>example:</strong>
     * <p>办公室的电话是：13222333232</p>
     */
    @NameInMap("productFab")
    public String productFab;

    /**
     * <strong>example:</strong>
     * <p><a href="https://xxxxxxx.com/xxxxxx">https://xxxxxxx.com/xxxxxx</a></p>
     */
    @NameInMap("productInfo")
    public String productInfo;

    /**
     * <strong>example:</strong>
     * <p>办公室的电话是多少</p>
     */
    @NameInMap("productName")
    public String productName;

    public static AiRetailProductAddRequest build(java.util.Map<String, ?> map) throws Exception {
        AiRetailProductAddRequest self = new AiRetailProductAddRequest();
        return TeaModel.build(map, self);
    }

    public AiRetailProductAddRequest setAttribute(java.util.Map<String, String> attribute) {
        this.attribute = attribute;
        return this;
    }
    public java.util.Map<String, String> getAttribute() {
        return this.attribute;
    }

    public AiRetailProductAddRequest setBarcodes(java.util.List<String> barcodes) {
        this.barcodes = barcodes;
        return this;
    }
    public java.util.List<String> getBarcodes() {
        return this.barcodes;
    }

    public AiRetailProductAddRequest setBrand(String brand) {
        this.brand = brand;
        return this;
    }
    public String getBrand() {
        return this.brand;
    }

    public AiRetailProductAddRequest setCategory(String category) {
        this.category = category;
        return this;
    }
    public String getCategory() {
        return this.category;
    }

    public AiRetailProductAddRequest setImageFileIds(java.util.List<String> imageFileIds) {
        this.imageFileIds = imageFileIds;
        return this;
    }
    public java.util.List<String> getImageFileIds() {
        return this.imageFileIds;
    }

    public AiRetailProductAddRequest setItemNumbers(java.util.List<String> itemNumbers) {
        this.itemNumbers = itemNumbers;
        return this;
    }
    public java.util.List<String> getItemNumbers() {
        return this.itemNumbers;
    }

    public AiRetailProductAddRequest setPrice(Float price) {
        this.price = price;
        return this;
    }
    public Float getPrice() {
        return this.price;
    }

    public AiRetailProductAddRequest setProductCode(String productCode) {
        this.productCode = productCode;
        return this;
    }
    public String getProductCode() {
        return this.productCode;
    }

    public AiRetailProductAddRequest setProductFab(String productFab) {
        this.productFab = productFab;
        return this;
    }
    public String getProductFab() {
        return this.productFab;
    }

    public AiRetailProductAddRequest setProductInfo(String productInfo) {
        this.productInfo = productInfo;
        return this;
    }
    public String getProductInfo() {
        return this.productInfo;
    }

    public AiRetailProductAddRequest setProductName(String productName) {
        this.productName = productName;
        return this;
    }
    public String getProductName() {
        return this.productName;
    }

}
