// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiRetailProductQueryResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<AiRetailProductQueryResponseBodyData> data;

    public static AiRetailProductQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AiRetailProductQueryResponseBody self = new AiRetailProductQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public AiRetailProductQueryResponseBody setData(java.util.List<AiRetailProductQueryResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<AiRetailProductQueryResponseBodyData> getData() {
        return this.data;
    }

    public static class AiRetailProductQueryResponseBodyData extends TeaModel {
        @NameInMap("attribute")
        public String attribute;

        @NameInMap("barcodes")
        public String barcodes;

        @NameInMap("brand")
        public String brand;

        @NameInMap("category")
        public String category;

        @NameInMap("imageFileIds")
        public String imageFileIds;

        @NameInMap("itemNumbers")
        public String itemNumbers;

        @NameInMap("price")
        public Float price;

        @NameInMap("productCode")
        public String productCode;

        @NameInMap("productFab")
        public String productFab;

        @NameInMap("productId")
        public Long productId;

        @NameInMap("productInfo")
        public String productInfo;

        @NameInMap("productName")
        public String productName;

        public static AiRetailProductQueryResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            AiRetailProductQueryResponseBodyData self = new AiRetailProductQueryResponseBodyData();
            return TeaModel.build(map, self);
        }

        public AiRetailProductQueryResponseBodyData setAttribute(String attribute) {
            this.attribute = attribute;
            return this;
        }
        public String getAttribute() {
            return this.attribute;
        }

        public AiRetailProductQueryResponseBodyData setBarcodes(String barcodes) {
            this.barcodes = barcodes;
            return this;
        }
        public String getBarcodes() {
            return this.barcodes;
        }

        public AiRetailProductQueryResponseBodyData setBrand(String brand) {
            this.brand = brand;
            return this;
        }
        public String getBrand() {
            return this.brand;
        }

        public AiRetailProductQueryResponseBodyData setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public AiRetailProductQueryResponseBodyData setImageFileIds(String imageFileIds) {
            this.imageFileIds = imageFileIds;
            return this;
        }
        public String getImageFileIds() {
            return this.imageFileIds;
        }

        public AiRetailProductQueryResponseBodyData setItemNumbers(String itemNumbers) {
            this.itemNumbers = itemNumbers;
            return this;
        }
        public String getItemNumbers() {
            return this.itemNumbers;
        }

        public AiRetailProductQueryResponseBodyData setPrice(Float price) {
            this.price = price;
            return this;
        }
        public Float getPrice() {
            return this.price;
        }

        public AiRetailProductQueryResponseBodyData setProductCode(String productCode) {
            this.productCode = productCode;
            return this;
        }
        public String getProductCode() {
            return this.productCode;
        }

        public AiRetailProductQueryResponseBodyData setProductFab(String productFab) {
            this.productFab = productFab;
            return this;
        }
        public String getProductFab() {
            return this.productFab;
        }

        public AiRetailProductQueryResponseBodyData setProductId(Long productId) {
            this.productId = productId;
            return this;
        }
        public Long getProductId() {
            return this.productId;
        }

        public AiRetailProductQueryResponseBodyData setProductInfo(String productInfo) {
            this.productInfo = productInfo;
            return this;
        }
        public String getProductInfo() {
            return this.productInfo;
        }

        public AiRetailProductQueryResponseBodyData setProductName(String productName) {
            this.productName = productName;
            return this;
        }
        public String getProductName() {
            return this.productName;
        }

    }

}
