// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceVerifyStatusRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>COM_DEFAULT</p>
     */
    @NameInMap("companyCode")
    public String companyCode;

    /**
     * <strong>example:</strong>
     * <p>DEDUCTED</p>
     */
    @NameInMap("deductStatus")
    public String deductStatus;

    @NameInMap("generalInvoiceVOList")
    public java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList> generalInvoiceVOList;

    @NameInMap("invoiceKeyVOList")
    public java.util.List<UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList> invoiceKeyVOList;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("verifyStatus")
    public String verifyStatus;

    public static UpdateInvoiceVerifyStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceVerifyStatusRequest self = new UpdateInvoiceVerifyStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceVerifyStatusRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

    public UpdateInvoiceVerifyStatusRequest setDeductStatus(String deductStatus) {
        this.deductStatus = deductStatus;
        return this;
    }
    public String getDeductStatus() {
        return this.deductStatus;
    }

    public UpdateInvoiceVerifyStatusRequest setGeneralInvoiceVOList(java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList> generalInvoiceVOList) {
        this.generalInvoiceVOList = generalInvoiceVOList;
        return this;
    }
    public java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList> getGeneralInvoiceVOList() {
        return this.generalInvoiceVOList;
    }

    public UpdateInvoiceVerifyStatusRequest setInvoiceKeyVOList(java.util.List<UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList> invoiceKeyVOList) {
        this.invoiceKeyVOList = invoiceKeyVOList;
        return this;
    }
    public java.util.List<UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList> getInvoiceKeyVOList() {
        return this.invoiceKeyVOList;
    }

    public UpdateInvoiceVerifyStatusRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public UpdateInvoiceVerifyStatusRequest setVerifyStatus(String verifyStatus) {
        this.verifyStatus = verifyStatus;
        return this;
    }
    public String getVerifyStatus() {
        return this.verifyStatus;
    }

    public static class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList extends TeaModel {
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

        public static UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList self = new UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setQuantity(String quantity) {
            this.quantity = quantity;
            return this;
        }
        public String getQuantity() {
            return this.quantity;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setTaxPre(String taxPre) {
            this.taxPre = taxPre;
            return this;
        }
        public String getTaxPre() {
            return this.taxPre;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setTaxPreType(String taxPreType) {
            this.taxPreType = taxPreType;
            return this;
        }
        public String getTaxPreType() {
            return this.taxPreType;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList setUnitPrice(String unitPrice) {
            this.unitPrice = unitPrice;
            return this;
        }
        public String getUnitPrice() {
            return this.unitPrice;
        }

    }

    public static class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList extends TeaModel {
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

        public static UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList self = new UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList extends TeaModel {
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

        public static UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList self = new UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setAuctionUnit(String auctionUnit) {
            this.auctionUnit = auctionUnit;
            return this;
        }
        public String getAuctionUnit() {
            return this.auctionUnit;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setAuctionUnitAddress(String auctionUnitAddress) {
            this.auctionUnitAddress = auctionUnitAddress;
            return this;
        }
        public String getAuctionUnitAddress() {
            return this.auctionUnitAddress;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setAuctionUnitBank(String auctionUnitBank) {
            this.auctionUnitBank = auctionUnitBank;
            return this;
        }
        public String getAuctionUnitBank() {
            return this.auctionUnitBank;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setAuctionUnitTaxNo(String auctionUnitTaxNo) {
            this.auctionUnitTaxNo = auctionUnitTaxNo;
            return this;
        }
        public String getAuctionUnitTaxNo() {
            return this.auctionUnitTaxNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setAuctionUtilTel(String auctionUtilTel) {
            this.auctionUtilTel = auctionUtilTel;
            return this;
        }
        public String getAuctionUtilTel() {
            return this.auctionUtilTel;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setCarModel(String carModel) {
            this.carModel = carModel;
            return this;
        }
        public String getCarModel() {
            return this.carModel;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setRegistration(String registration) {
            this.registration = registration;
            return this;
        }
        public String getRegistration() {
            return this.registration;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setTransferVehicle(String transferVehicle) {
            this.transferVehicle = transferVehicle;
            return this;
        }
        public String getTransferVehicle() {
            return this.transferVehicle;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setUsedCarAddress(String usedCarAddress) {
            this.usedCarAddress = usedCarAddress;
            return this;
        }
        public String getUsedCarAddress() {
            return this.usedCarAddress;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setUsedCarMarket(String usedCarMarket) {
            this.usedCarMarket = usedCarMarket;
            return this;
        }
        public String getUsedCarMarket() {
            return this.usedCarMarket;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setUsedCarMarketBank(String usedCarMarketBank) {
            this.usedCarMarketBank = usedCarMarketBank;
            return this;
        }
        public String getUsedCarMarketBank() {
            return this.usedCarMarketBank;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setUsedCarMarketPhone(String usedCarMarketPhone) {
            this.usedCarMarketPhone = usedCarMarketPhone;
            return this;
        }
        public String getUsedCarMarketPhone() {
            return this.usedCarMarketPhone;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setUsedCarMarketTaxNo(String usedCarMarketTaxNo) {
            this.usedCarMarketTaxNo = usedCarMarketTaxNo;
            return this;
        }
        public String getUsedCarMarketTaxNo() {
            return this.usedCarMarketTaxNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList extends TeaModel {
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

        public static UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList self = new UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setBrand(String brand) {
            this.brand = brand;
            return this;
        }
        public String getBrand() {
            return this.brand;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setCertificateNo(String certificateNo) {
            this.certificateNo = certificateNo;
            return this;
        }
        public String getCertificateNo() {
            return this.certificateNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setEngineNo(String engineNo) {
            this.engineNo = engineNo;
            return this;
        }
        public String getEngineNo() {
            return this.engineNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setIdCardNo(String idCardNo) {
            this.idCardNo = idCardNo;
            return this;
        }
        public String getIdCardNo() {
            return this.idCardNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setImportCertificateNo(String importCertificateNo) {
            this.importCertificateNo = importCertificateNo;
            return this;
        }
        public String getImportCertificateNo() {
            return this.importCertificateNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setInspectionListNo(String inspectionListNo) {
            this.inspectionListNo = inspectionListNo;
            return this;
        }
        public String getInspectionListNo() {
            return this.inspectionListNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setMaxPassengers(String maxPassengers) {
            this.maxPassengers = maxPassengers;
            return this;
        }
        public String getMaxPassengers() {
            return this.maxPassengers;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setOriginPlace(String originPlace) {
            this.originPlace = originPlace;
            return this;
        }
        public String getOriginPlace() {
            return this.originPlace;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setPaymentVoucherNo(String paymentVoucherNo) {
            this.paymentVoucherNo = paymentVoucherNo;
            return this;
        }
        public String getPaymentVoucherNo() {
            return this.paymentVoucherNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setTaxAuthorityName(String taxAuthorityName) {
            this.taxAuthorityName = taxAuthorityName;
            return this;
        }
        public String getTaxAuthorityName() {
            return this.taxAuthorityName;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setTaxAuthorityNo(String taxAuthorityNo) {
            this.taxAuthorityNo = taxAuthorityNo;
            return this;
        }
        public String getTaxAuthorityNo() {
            return this.taxAuthorityNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setTonnage(String tonnage) {
            this.tonnage = tonnage;
            return this;
        }
        public String getTonnage() {
            return this.tonnage;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList extends TeaModel {
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
        public java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList> generalInvoiceDetailVOList;

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

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("remark")
        public String remark;

        @NameInMap("secondHandCarInvoiceDetailList")
        public java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList;

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
        public java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList;

        @NameInMap("vehicleSaleDetailVOList")
        public java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList> vehicleSaleDetailVOList;

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

        public static UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList self = new UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setAccountPeriod(String accountPeriod) {
            this.accountPeriod = accountPeriod;
            return this;
        }
        public String getAccountPeriod() {
            return this.accountPeriod;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setAmountWithTax(String amountWithTax) {
            this.amountWithTax = amountWithTax;
            return this;
        }
        public String getAmountWithTax() {
            return this.amountWithTax;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setCheckCode(String checkCode) {
            this.checkCode = checkCode;
            return this;
        }
        public String getCheckCode() {
            return this.checkCode;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setDrawerName(String drawerName) {
            this.drawerName = drawerName;
            return this;
        }
        public String getDrawerName() {
            return this.drawerName;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setDrewDate(String drewDate) {
            this.drewDate = drewDate;
            return this;
        }
        public String getDrewDate() {
            return this.drewDate;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setElectronicUrl(String electronicUrl) {
            this.electronicUrl = electronicUrl;
            return this;
        }
        public String getElectronicUrl() {
            return this.electronicUrl;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setFinanceType(String financeType) {
            this.financeType = financeType;
            return this;
        }
        public String getFinanceType() {
            return this.financeType;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setFundType(String fundType) {
            this.fundType = fundType;
            return this;
        }
        public String getFundType() {
            return this.fundType;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setGeneralInvoiceDetailVOList(java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList> generalInvoiceDetailVOList) {
            this.generalInvoiceDetailVOList = generalInvoiceDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList> getGeneralInvoiceDetailVOList() {
            return this.generalInvoiceDetailVOList;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setImageUrl(String imageUrl) {
            this.imageUrl = imageUrl;
            return this;
        }
        public String getImageUrl() {
            return this.imageUrl;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setInvoiceStatus(String invoiceStatus) {
            this.invoiceStatus = invoiceStatus;
            return this;
        }
        public String getInvoiceStatus() {
            return this.invoiceStatus;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setMachineCode(String machineCode) {
            this.machineCode = machineCode;
            return this;
        }
        public String getMachineCode() {
            return this.machineCode;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setOilFlag(String oilFlag) {
            this.oilFlag = oilFlag;
            return this;
        }
        public String getOilFlag() {
            return this.oilFlag;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setPayee(String payee) {
            this.payee = payee;
            return this;
        }
        public String getPayee() {
            return this.payee;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setProcessInstCode(String processInstCode) {
            this.processInstCode = processInstCode;
            return this;
        }
        public String getProcessInstCode() {
            return this.processInstCode;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setProcessInstType(String processInstType) {
            this.processInstType = processInstType;
            return this;
        }
        public String getProcessInstType() {
            return this.processInstType;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setPurchaserAddress(String purchaserAddress) {
            this.purchaserAddress = purchaserAddress;
            return this;
        }
        public String getPurchaserAddress() {
            return this.purchaserAddress;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setPurchaserBankAccount(String purchaserBankAccount) {
            this.purchaserBankAccount = purchaserBankAccount;
            return this;
        }
        public String getPurchaserBankAccount() {
            return this.purchaserBankAccount;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setPurchaserBankNameAccount(String purchaserBankNameAccount) {
            this.purchaserBankNameAccount = purchaserBankNameAccount;
            return this;
        }
        public String getPurchaserBankNameAccount() {
            return this.purchaserBankNameAccount;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setPurchaserName(String purchaserName) {
            this.purchaserName = purchaserName;
            return this;
        }
        public String getPurchaserName() {
            return this.purchaserName;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setPurchaserTaxNo(String purchaserTaxNo) {
            this.purchaserTaxNo = purchaserTaxNo;
            return this;
        }
        public String getPurchaserTaxNo() {
            return this.purchaserTaxNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setPurchaserTel(String purchaserTel) {
            this.purchaserTel = purchaserTel;
            return this;
        }
        public String getPurchaserTel() {
            return this.purchaserTel;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setSecondHandCarInvoiceDetailList(java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList) {
            this.secondHandCarInvoiceDetailList = secondHandCarInvoiceDetailList;
            return this;
        }
        public java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList> getSecondHandCarInvoiceDetailList() {
            return this.secondHandCarInvoiceDetailList;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setSellerAddress(String sellerAddress) {
            this.sellerAddress = sellerAddress;
            return this;
        }
        public String getSellerAddress() {
            return this.sellerAddress;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setSellerBankAccount(String sellerBankAccount) {
            this.sellerBankAccount = sellerBankAccount;
            return this;
        }
        public String getSellerBankAccount() {
            return this.sellerBankAccount;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setSellerBankNameAccount(String sellerBankNameAccount) {
            this.sellerBankNameAccount = sellerBankNameAccount;
            return this;
        }
        public String getSellerBankNameAccount() {
            return this.sellerBankNameAccount;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setSellerName(String sellerName) {
            this.sellerName = sellerName;
            return this;
        }
        public String getSellerName() {
            return this.sellerName;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setSellerTaxNo(String sellerTaxNo) {
            this.sellerTaxNo = sellerTaxNo;
            return this;
        }
        public String getSellerTaxNo() {
            return this.sellerTaxNo;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setSellerTel(String sellerTel) {
            this.sellerTel = sellerTel;
            return this;
        }
        public String getSellerTel() {
            return this.sellerTel;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setSupplySign(String supplySign) {
            this.supplySign = supplySign;
            return this;
        }
        public String getSupplySign() {
            return this.supplySign;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setUsedVehicleSaleDetailVOList(java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList) {
            this.usedVehicleSaleDetailVOList = usedVehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList> getUsedVehicleSaleDetailVOList() {
            return this.usedVehicleSaleDetailVOList;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setVehicleSaleDetailVOList(java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList> vehicleSaleDetailVOList) {
            this.vehicleSaleDetailVOList = vehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList> getVehicleSaleDetailVOList() {
            return this.vehicleSaleDetailVOList;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setVerifyStatus(String verifyStatus) {
            this.verifyStatus = verifyStatus;
            return this;
        }
        public String getVerifyStatus() {
            return this.verifyStatus;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setVoucherCode(String voucherCode) {
            this.voucherCode = voucherCode;
            return this;
        }
        public String getVoucherCode() {
            return this.voucherCode;
        }

        public UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList setVoucherStatus(String voucherStatus) {
            this.voucherStatus = voucherStatus;
            return this;
        }
        public String getVoucherStatus() {
            return this.voucherStatus;
        }

    }

    public static class UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1001</p>
         */
        @NameInMap("invoiceCode")
        public String invoiceCode;

        /**
         * <strong>example:</strong>
         * <p>2202</p>
         */
        @NameInMap("invoiceNo")
        public String invoiceNo;

        public static UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList self = new UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

}
