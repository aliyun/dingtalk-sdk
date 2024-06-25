// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BatchAddInvoiceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>COM_DEFAULT</p>
     */
    @NameInMap("companyCode")
    public String companyCode;

    @NameInMap("generalInvoiceVOList")
    public java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOList> generalInvoiceVOList;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <strong>example:</strong>
     * <p>APPROVAL</p>
     */
    @NameInMap("source")
    public String source;

    public static BatchAddInvoiceRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchAddInvoiceRequest self = new BatchAddInvoiceRequest();
        return TeaModel.build(map, self);
    }

    public BatchAddInvoiceRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public BatchAddInvoiceRequest setGeneralInvoiceVOList(java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOList> generalInvoiceVOList) {
        this.generalInvoiceVOList = generalInvoiceVOList;
        return this;
    }
    public java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOList> getGeneralInvoiceVOList() {
        return this.generalInvoiceVOList;
    }

    public BatchAddInvoiceRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public BatchAddInvoiceRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public static class BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList extends TeaModel {
        @NameInMap("amount")
        public String amount;

        @NameInMap("goodsName")
        public String goodsName;

        @NameInMap("quantity")
        public String quantity;

        @NameInMap("revenueCode")
        public String revenueCode;

        @NameInMap("rowNo")
        public String rowNo;

        @NameInMap("specification")
        public String specification;

        @NameInMap("taxAmount")
        public String taxAmount;

        @NameInMap("taxPre")
        public String taxPre;

        @NameInMap("taxPreType")
        public String taxPreType;

        @NameInMap("taxRate")
        public String taxRate;

        @NameInMap("unit")
        public String unit;

        @NameInMap("unitPrice")
        public String unitPrice;

        public static BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList self = new BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList();
            return TeaModel.build(map, self);
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setQuantity(String quantity) {
            this.quantity = quantity;
            return this;
        }
        public String getQuantity() {
            return this.quantity;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setTaxPre(String taxPre) {
            this.taxPre = taxPre;
            return this;
        }
        public String getTaxPre() {
            return this.taxPre;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setTaxPreType(String taxPreType) {
            this.taxPreType = taxPreType;
            return this;
        }
        public String getTaxPreType() {
            return this.taxPreType;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setUnitPrice(String unitPrice) {
            this.unitPrice = unitPrice;
            return this;
        }
        public String getUnitPrice() {
            return this.unitPrice;
        }

    }

    public static class BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList extends TeaModel {
        @NameInMap("amount")
        public String amount;

        @NameInMap("cardNo")
        public String cardNo;

        @NameInMap("endDate")
        public String endDate;

        @NameInMap("goodsName")
        public String goodsName;

        @NameInMap("revenueCode")
        public String revenueCode;

        @NameInMap("rowNo")
        public String rowNo;

        @NameInMap("startDate")
        public String startDate;

        @NameInMap("taxAmount")
        public String taxAmount;

        @NameInMap("taxRate")
        public String taxRate;

        @NameInMap("vehicleType")
        public String vehicleType;

        public static BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList build(java.util.Map<String, ?> map) throws Exception {
            BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList self = new BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList();
            return TeaModel.build(map, self);
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList extends TeaModel {
        @NameInMap("auctionUnit")
        public String auctionUnit;

        @NameInMap("auctionUnitAddress")
        public String auctionUnitAddress;

        @NameInMap("auctionUnitBank")
        public String auctionUnitBank;

        @NameInMap("auctionUnitTaxNo")
        public String auctionUnitTaxNo;

        @NameInMap("auctionUtilTel")
        public String auctionUtilTel;

        @NameInMap("carModel")
        public String carModel;

        @NameInMap("cardNo")
        public String cardNo;

        @NameInMap("registration")
        public String registration;

        @NameInMap("transferVehicle")
        public String transferVehicle;

        @NameInMap("usedCarAddress")
        public String usedCarAddress;

        @NameInMap("usedCarMarket")
        public String usedCarMarket;

        @NameInMap("usedCarMarketBank")
        public String usedCarMarketBank;

        @NameInMap("usedCarMarketPhone")
        public String usedCarMarketPhone;

        @NameInMap("usedCarMarketTaxNo")
        public String usedCarMarketTaxNo;

        @NameInMap("vehicleNo")
        public String vehicleNo;

        @NameInMap("vehicleType")
        public String vehicleType;

        public static BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList self = new BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setAuctionUnit(String auctionUnit) {
            this.auctionUnit = auctionUnit;
            return this;
        }
        public String getAuctionUnit() {
            return this.auctionUnit;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setAuctionUnitAddress(String auctionUnitAddress) {
            this.auctionUnitAddress = auctionUnitAddress;
            return this;
        }
        public String getAuctionUnitAddress() {
            return this.auctionUnitAddress;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setAuctionUnitBank(String auctionUnitBank) {
            this.auctionUnitBank = auctionUnitBank;
            return this;
        }
        public String getAuctionUnitBank() {
            return this.auctionUnitBank;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setAuctionUnitTaxNo(String auctionUnitTaxNo) {
            this.auctionUnitTaxNo = auctionUnitTaxNo;
            return this;
        }
        public String getAuctionUnitTaxNo() {
            return this.auctionUnitTaxNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setAuctionUtilTel(String auctionUtilTel) {
            this.auctionUtilTel = auctionUtilTel;
            return this;
        }
        public String getAuctionUtilTel() {
            return this.auctionUtilTel;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setCarModel(String carModel) {
            this.carModel = carModel;
            return this;
        }
        public String getCarModel() {
            return this.carModel;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setRegistration(String registration) {
            this.registration = registration;
            return this;
        }
        public String getRegistration() {
            return this.registration;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setTransferVehicle(String transferVehicle) {
            this.transferVehicle = transferVehicle;
            return this;
        }
        public String getTransferVehicle() {
            return this.transferVehicle;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setUsedCarAddress(String usedCarAddress) {
            this.usedCarAddress = usedCarAddress;
            return this;
        }
        public String getUsedCarAddress() {
            return this.usedCarAddress;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setUsedCarMarket(String usedCarMarket) {
            this.usedCarMarket = usedCarMarket;
            return this;
        }
        public String getUsedCarMarket() {
            return this.usedCarMarket;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setUsedCarMarketBank(String usedCarMarketBank) {
            this.usedCarMarketBank = usedCarMarketBank;
            return this;
        }
        public String getUsedCarMarketBank() {
            return this.usedCarMarketBank;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setUsedCarMarketPhone(String usedCarMarketPhone) {
            this.usedCarMarketPhone = usedCarMarketPhone;
            return this;
        }
        public String getUsedCarMarketPhone() {
            return this.usedCarMarketPhone;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setUsedCarMarketTaxNo(String usedCarMarketTaxNo) {
            this.usedCarMarketTaxNo = usedCarMarketTaxNo;
            return this;
        }
        public String getUsedCarMarketTaxNo() {
            return this.usedCarMarketTaxNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList extends TeaModel {
        @NameInMap("brand")
        public String brand;

        @NameInMap("certificateNo")
        public String certificateNo;

        @NameInMap("engineNo")
        public String engineNo;

        @NameInMap("idCardNo")
        public String idCardNo;

        @NameInMap("importCertificateNo")
        public String importCertificateNo;

        @NameInMap("inspectionListNo")
        public String inspectionListNo;

        @NameInMap("maxPassengers")
        public String maxPassengers;

        @NameInMap("originPlace")
        public String originPlace;

        @NameInMap("paymentVoucherNo")
        public String paymentVoucherNo;

        @NameInMap("taxAuthorityName")
        public String taxAuthorityName;

        @NameInMap("taxAuthorityNo")
        public String taxAuthorityNo;

        @NameInMap("taxRate")
        public String taxRate;

        @NameInMap("tonnage")
        public String tonnage;

        @NameInMap("vehicleNo")
        public String vehicleNo;

        @NameInMap("vehicleType")
        public String vehicleType;

        public static BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList self = new BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setBrand(String brand) {
            this.brand = brand;
            return this;
        }
        public String getBrand() {
            return this.brand;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setCertificateNo(String certificateNo) {
            this.certificateNo = certificateNo;
            return this;
        }
        public String getCertificateNo() {
            return this.certificateNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setEngineNo(String engineNo) {
            this.engineNo = engineNo;
            return this;
        }
        public String getEngineNo() {
            return this.engineNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setIdCardNo(String idCardNo) {
            this.idCardNo = idCardNo;
            return this;
        }
        public String getIdCardNo() {
            return this.idCardNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setImportCertificateNo(String importCertificateNo) {
            this.importCertificateNo = importCertificateNo;
            return this;
        }
        public String getImportCertificateNo() {
            return this.importCertificateNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setInspectionListNo(String inspectionListNo) {
            this.inspectionListNo = inspectionListNo;
            return this;
        }
        public String getInspectionListNo() {
            return this.inspectionListNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setMaxPassengers(String maxPassengers) {
            this.maxPassengers = maxPassengers;
            return this;
        }
        public String getMaxPassengers() {
            return this.maxPassengers;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setOriginPlace(String originPlace) {
            this.originPlace = originPlace;
            return this;
        }
        public String getOriginPlace() {
            return this.originPlace;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setPaymentVoucherNo(String paymentVoucherNo) {
            this.paymentVoucherNo = paymentVoucherNo;
            return this;
        }
        public String getPaymentVoucherNo() {
            return this.paymentVoucherNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setTaxAuthorityName(String taxAuthorityName) {
            this.taxAuthorityName = taxAuthorityName;
            return this;
        }
        public String getTaxAuthorityName() {
            return this.taxAuthorityName;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setTaxAuthorityNo(String taxAuthorityNo) {
            this.taxAuthorityNo = taxAuthorityNo;
            return this;
        }
        public String getTaxAuthorityNo() {
            return this.taxAuthorityNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setTonnage(String tonnage) {
            this.tonnage = tonnage;
            return this;
        }
        public String getTonnage() {
            return this.tonnage;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class BatchAddInvoiceRequestGeneralInvoiceVOList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("accountPeriod")
        public String accountPeriod;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <strong>example:</strong>
         * <p>120</p>
         */
        @NameInMap("amountWithTax")
        public String amountWithTax;

        /**
         * <strong>example:</strong>
         * <p>1111</p>
         */
        @NameInMap("checkCode")
        public String checkCode;

        /**
         * <strong>example:</strong>
         * <p>2010-12-12</p>
         */
        @NameInMap("checkTime")
        public String checkTime;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("drawerName")
        public String drawerName;

        /**
         * <strong>example:</strong>
         * <p>2022-12-10</p>
         */
        @NameInMap("drewDate")
        public String drewDate;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("electronicUrl")
        public String electronicUrl;

        /**
         * <strong>example:</strong>
         * <p>INPUT_VAT</p>
         */
        @NameInMap("financeType")
        public String financeType;

        /**
         * <strong>example:</strong>
         * <p>RED</p>
         */
        @NameInMap("fundType")
        public String fundType;

        @NameInMap("generalInvoiceDetailVOList")
        public java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList> generalInvoiceDetailVOList;

        /**
         * <strong>example:</strong>
         * <p><a href="http://XXX.jpg">http://XXX.jpg</a></p>
         */
        @NameInMap("imageUrl")
        public String imageUrl;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("invoiceCode")
        public String invoiceCode;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("invoiceNo")
        public String invoiceNo;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("invoiceStatus")
        public String invoiceStatus;

        /**
         * <strong>example:</strong>
         * <p>INTPUT_VAT</p>
         */
        @NameInMap("invoiceType")
        public String invoiceType;

        /**
         * <strong>example:</strong>
         * <p>1111</p>
         */
        @NameInMap("machineCode")
        public String machineCode;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("oilFlag")
        public String oilFlag;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("payee")
        public String payee;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("processInstCode")
        public String processInstCode;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("processInstType")
        public String processInstType;

        /**
         * <strong>example:</strong>
         * <p>杭州市</p>
         */
        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        @NameInMap("purchaserBankAccount")
        public String purchaserBankAccount;

        /**
         * <strong>example:</strong>
         * <p>建行</p>
         */
        @NameInMap("purchaserBankNameAccount")
        public String purchaserBankNameAccount;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("purchaserName")
        public String purchaserName;

        /**
         * <strong>example:</strong>
         * <p>155655</p>
         */
        @NameInMap("purchaserTaxNo")
        public String purchaserTaxNo;

        /**
         * <strong>example:</strong>
         * <p>1333333333</p>
         */
        @NameInMap("purchaserTel")
        public String purchaserTel;

        @NameInMap("receiverEmail")
        public String receiverEmail;

        @NameInMap("receiverName")
        public String receiverName;

        @NameInMap("receiverTel")
        public String receiverTel;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("remark")
        public String remark;

        @NameInMap("reviewer")
        public String reviewer;

        @NameInMap("secondHandCarInvoiceDetailList")
        public java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList;

        /**
         * <strong>example:</strong>
         * <p>8852</p>
         */
        @NameInMap("sellerAddress")
        public String sellerAddress;

        @NameInMap("sellerBankAccount")
        public String sellerBankAccount;

        /**
         * <strong>example:</strong>
         * <p>招商银行</p>
         */
        @NameInMap("sellerBankNameAccount")
        public String sellerBankNameAccount;

        /**
         * <strong>example:</strong>
         * <p>李四</p>
         */
        @NameInMap("sellerName")
        public String sellerName;

        /**
         * <strong>example:</strong>
         * <p>2202</p>
         */
        @NameInMap("sellerTaxNo")
        public String sellerTaxNo;

        /**
         * <strong>example:</strong>
         * <p>13355222222</p>
         */
        @NameInMap("sellerTel")
        public String sellerTel;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("supplySign")
        public String supplySign;

        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("taxAmount")
        public String taxAmount;

        @NameInMap("usedVehicleSaleDetailVOList")
        public java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList;

        @NameInMap("vehicleSaleDetailVOList")
        public java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList> vehicleSaleDetailVOList;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("verifyStatus")
        public String verifyStatus;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("voucherCode")
        public String voucherCode;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("voucherStatus")
        public String voucherStatus;

        public static BatchAddInvoiceRequestGeneralInvoiceVOList build(java.util.Map<String, ?> map) throws Exception {
            BatchAddInvoiceRequestGeneralInvoiceVOList self = new BatchAddInvoiceRequestGeneralInvoiceVOList();
            return TeaModel.build(map, self);
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setAccountPeriod(String accountPeriod) {
            this.accountPeriod = accountPeriod;
            return this;
        }
        public String getAccountPeriod() {
            return this.accountPeriod;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setAmountWithTax(String amountWithTax) {
            this.amountWithTax = amountWithTax;
            return this;
        }
        public String getAmountWithTax() {
            return this.amountWithTax;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setCheckCode(String checkCode) {
            this.checkCode = checkCode;
            return this;
        }
        public String getCheckCode() {
            return this.checkCode;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setDrawerName(String drawerName) {
            this.drawerName = drawerName;
            return this;
        }
        public String getDrawerName() {
            return this.drawerName;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setDrewDate(String drewDate) {
            this.drewDate = drewDate;
            return this;
        }
        public String getDrewDate() {
            return this.drewDate;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setElectronicUrl(String electronicUrl) {
            this.electronicUrl = electronicUrl;
            return this;
        }
        public String getElectronicUrl() {
            return this.electronicUrl;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setFinanceType(String financeType) {
            this.financeType = financeType;
            return this;
        }
        public String getFinanceType() {
            return this.financeType;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setFundType(String fundType) {
            this.fundType = fundType;
            return this;
        }
        public String getFundType() {
            return this.fundType;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setGeneralInvoiceDetailVOList(java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList> generalInvoiceDetailVOList) {
            this.generalInvoiceDetailVOList = generalInvoiceDetailVOList;
            return this;
        }
        public java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList> getGeneralInvoiceDetailVOList() {
            return this.generalInvoiceDetailVOList;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setImageUrl(String imageUrl) {
            this.imageUrl = imageUrl;
            return this;
        }
        public String getImageUrl() {
            return this.imageUrl;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setInvoiceStatus(String invoiceStatus) {
            this.invoiceStatus = invoiceStatus;
            return this;
        }
        public String getInvoiceStatus() {
            return this.invoiceStatus;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setMachineCode(String machineCode) {
            this.machineCode = machineCode;
            return this;
        }
        public String getMachineCode() {
            return this.machineCode;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setOilFlag(String oilFlag) {
            this.oilFlag = oilFlag;
            return this;
        }
        public String getOilFlag() {
            return this.oilFlag;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setPayee(String payee) {
            this.payee = payee;
            return this;
        }
        public String getPayee() {
            return this.payee;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setProcessInstCode(String processInstCode) {
            this.processInstCode = processInstCode;
            return this;
        }
        public String getProcessInstCode() {
            return this.processInstCode;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setProcessInstType(String processInstType) {
            this.processInstType = processInstType;
            return this;
        }
        public String getProcessInstType() {
            return this.processInstType;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setPurchaserAddress(String purchaserAddress) {
            this.purchaserAddress = purchaserAddress;
            return this;
        }
        public String getPurchaserAddress() {
            return this.purchaserAddress;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setPurchaserBankAccount(String purchaserBankAccount) {
            this.purchaserBankAccount = purchaserBankAccount;
            return this;
        }
        public String getPurchaserBankAccount() {
            return this.purchaserBankAccount;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setPurchaserBankNameAccount(String purchaserBankNameAccount) {
            this.purchaserBankNameAccount = purchaserBankNameAccount;
            return this;
        }
        public String getPurchaserBankNameAccount() {
            return this.purchaserBankNameAccount;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setPurchaserName(String purchaserName) {
            this.purchaserName = purchaserName;
            return this;
        }
        public String getPurchaserName() {
            return this.purchaserName;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setPurchaserTaxNo(String purchaserTaxNo) {
            this.purchaserTaxNo = purchaserTaxNo;
            return this;
        }
        public String getPurchaserTaxNo() {
            return this.purchaserTaxNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setPurchaserTel(String purchaserTel) {
            this.purchaserTel = purchaserTel;
            return this;
        }
        public String getPurchaserTel() {
            return this.purchaserTel;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setReceiverEmail(String receiverEmail) {
            this.receiverEmail = receiverEmail;
            return this;
        }
        public String getReceiverEmail() {
            return this.receiverEmail;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setReceiverName(String receiverName) {
            this.receiverName = receiverName;
            return this;
        }
        public String getReceiverName() {
            return this.receiverName;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setReceiverTel(String receiverTel) {
            this.receiverTel = receiverTel;
            return this;
        }
        public String getReceiverTel() {
            return this.receiverTel;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setReviewer(String reviewer) {
            this.reviewer = reviewer;
            return this;
        }
        public String getReviewer() {
            return this.reviewer;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setSecondHandCarInvoiceDetailList(java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList) {
            this.secondHandCarInvoiceDetailList = secondHandCarInvoiceDetailList;
            return this;
        }
        public java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList> getSecondHandCarInvoiceDetailList() {
            return this.secondHandCarInvoiceDetailList;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setSellerAddress(String sellerAddress) {
            this.sellerAddress = sellerAddress;
            return this;
        }
        public String getSellerAddress() {
            return this.sellerAddress;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setSellerBankAccount(String sellerBankAccount) {
            this.sellerBankAccount = sellerBankAccount;
            return this;
        }
        public String getSellerBankAccount() {
            return this.sellerBankAccount;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setSellerBankNameAccount(String sellerBankNameAccount) {
            this.sellerBankNameAccount = sellerBankNameAccount;
            return this;
        }
        public String getSellerBankNameAccount() {
            return this.sellerBankNameAccount;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setSellerName(String sellerName) {
            this.sellerName = sellerName;
            return this;
        }
        public String getSellerName() {
            return this.sellerName;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setSellerTaxNo(String sellerTaxNo) {
            this.sellerTaxNo = sellerTaxNo;
            return this;
        }
        public String getSellerTaxNo() {
            return this.sellerTaxNo;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setSellerTel(String sellerTel) {
            this.sellerTel = sellerTel;
            return this;
        }
        public String getSellerTel() {
            return this.sellerTel;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setSupplySign(String supplySign) {
            this.supplySign = supplySign;
            return this;
        }
        public String getSupplySign() {
            return this.supplySign;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setUsedVehicleSaleDetailVOList(java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList) {
            this.usedVehicleSaleDetailVOList = usedVehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList> getUsedVehicleSaleDetailVOList() {
            return this.usedVehicleSaleDetailVOList;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setVehicleSaleDetailVOList(java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList> vehicleSaleDetailVOList) {
            this.vehicleSaleDetailVOList = vehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList> getVehicleSaleDetailVOList() {
            return this.vehicleSaleDetailVOList;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setVerifyStatus(String verifyStatus) {
            this.verifyStatus = verifyStatus;
            return this;
        }
        public String getVerifyStatus() {
            return this.verifyStatus;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setVoucherCode(String voucherCode) {
            this.voucherCode = voucherCode;
            return this;
        }
        public String getVoucherCode() {
            return this.voucherCode;
        }

        public BatchAddInvoiceRequestGeneralInvoiceVOList setVoucherStatus(String voucherStatus) {
            this.voucherStatus = voucherStatus;
            return this;
        }
        public String getVoucherStatus() {
            return this.voucherStatus;
        }

    }

}
