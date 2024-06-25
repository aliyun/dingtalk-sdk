// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAndReceiptRelatedRequest extends TeaModel {
    @NameInMap("generalInvoiceVO")
    public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO generalInvoiceVO;

    /**
     * <strong>example:</strong>
     * <p>code</p>
     */
    @NameInMap("invoiceCode")
    public String invoiceCode;

    /**
     * <strong>example:</strong>
     * <p>155</p>
     */
    @NameInMap("invoiceNo")
    public String invoiceNo;

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
    @NameInMap("receiptCode")
    public String receiptCode;

    public static UpdateInvoiceAndReceiptRelatedRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAndReceiptRelatedRequest self = new UpdateInvoiceAndReceiptRelatedRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAndReceiptRelatedRequest setGeneralInvoiceVO(UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO generalInvoiceVO) {
        this.generalInvoiceVO = generalInvoiceVO;
        return this;
    }
    public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO getGeneralInvoiceVO() {
        return this.generalInvoiceVO;
    }

    public UpdateInvoiceAndReceiptRelatedRequest setInvoiceCode(String invoiceCode) {
        this.invoiceCode = invoiceCode;
        return this;
    }
    public String getInvoiceCode() {
        return this.invoiceCode;
    }

    public UpdateInvoiceAndReceiptRelatedRequest setInvoiceNo(String invoiceNo) {
        this.invoiceNo = invoiceNo;
        return this;
    }
    public String getInvoiceNo() {
        return this.invoiceNo;
    }

    public UpdateInvoiceAndReceiptRelatedRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public UpdateInvoiceAndReceiptRelatedRequest setReceiptCode(String receiptCode) {
        this.receiptCode = receiptCode;
        return this;
    }
    public String getReceiptCode() {
        return this.receiptCode;
    }

    public static class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>北京国际机场</p>
         */
        @NameInMap("carrier")
        public String carrier;

        /**
         * <strong>example:</strong>
         * <p>AA1234</p>
         */
        @NameInMap("flightNumber")
        public String flightNumber;

        /**
         * <strong>example:</strong>
         * <p>2023-05-11</p>
         */
        @NameInMap("flyDate")
        public String flyDate;

        /**
         * <strong>example:</strong>
         * <p>杭州</p>
         */
        @NameInMap("flyFrom")
        public String flyFrom;

        /**
         * <strong>example:</strong>
         * <p>16:00</p>
         */
        @NameInMap("flyTime")
        public String flyTime;

        /**
         * <strong>example:</strong>
         * <p>北京</p>
         */
        @NameInMap("flyTo")
        public String flyTo;

        /**
         * <strong>example:</strong>
         * <p>头等舱</p>
         */
        @NameInMap("seat")
        public String seat;

        public static UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails self = new UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails setCarrier(String carrier) {
            this.carrier = carrier;
            return this;
        }
        public String getCarrier() {
            return this.carrier;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails setFlightNumber(String flightNumber) {
            this.flightNumber = flightNumber;
            return this;
        }
        public String getFlightNumber() {
            return this.flightNumber;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails setFlyDate(String flyDate) {
            this.flyDate = flyDate;
            return this;
        }
        public String getFlyDate() {
            return this.flyDate;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails setFlyFrom(String flyFrom) {
            this.flyFrom = flyFrom;
            return this;
        }
        public String getFlyFrom() {
            return this.flyFrom;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails setFlyTime(String flyTime) {
            this.flyTime = flyTime;
            return this;
        }
        public String getFlyTime() {
            return this.flyTime;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails setFlyTo(String flyTo) {
            this.flyTo = flyTo;
            return this;
        }
        public String getFlyTo() {
            return this.flyTo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails setSeat(String seat) {
            this.seat = seat;
            return this;
        }
        public String getSeat() {
            return this.seat;
        }

    }

    public static class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList extends TeaModel {
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

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("taxPreType")
        public String taxPreType;

        @NameInMap("taxRate")
        public String taxRate;

        @NameInMap("unit")
        public String unit;

        @NameInMap("unitPrice")
        public String unitPrice;

        public static UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList self = new UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setQuantity(String quantity) {
            this.quantity = quantity;
            return this;
        }
        public String getQuantity() {
            return this.quantity;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxPre(String taxPre) {
            this.taxPre = taxPre;
            return this;
        }
        public String getTaxPre() {
            return this.taxPre;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxPreType(String taxPreType) {
            this.taxPreType = taxPreType;
            return this;
        }
        public String getTaxPreType() {
            return this.taxPreType;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setUnitPrice(String unitPrice) {
            this.unitPrice = unitPrice;
            return this;
        }
        public String getUnitPrice() {
            return this.unitPrice;
        }

    }

    public static class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList extends TeaModel {
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

        public static UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList self = new UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList extends TeaModel {
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

        public static UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList self = new UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnit(String auctionUnit) {
            this.auctionUnit = auctionUnit;
            return this;
        }
        public String getAuctionUnit() {
            return this.auctionUnit;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnitAddress(String auctionUnitAddress) {
            this.auctionUnitAddress = auctionUnitAddress;
            return this;
        }
        public String getAuctionUnitAddress() {
            return this.auctionUnitAddress;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnitBank(String auctionUnitBank) {
            this.auctionUnitBank = auctionUnitBank;
            return this;
        }
        public String getAuctionUnitBank() {
            return this.auctionUnitBank;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnitTaxNo(String auctionUnitTaxNo) {
            this.auctionUnitTaxNo = auctionUnitTaxNo;
            return this;
        }
        public String getAuctionUnitTaxNo() {
            return this.auctionUnitTaxNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUtilTel(String auctionUtilTel) {
            this.auctionUtilTel = auctionUtilTel;
            return this;
        }
        public String getAuctionUtilTel() {
            return this.auctionUtilTel;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setCarModel(String carModel) {
            this.carModel = carModel;
            return this;
        }
        public String getCarModel() {
            return this.carModel;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setRegistration(String registration) {
            this.registration = registration;
            return this;
        }
        public String getRegistration() {
            return this.registration;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setTransferVehicle(String transferVehicle) {
            this.transferVehicle = transferVehicle;
            return this;
        }
        public String getTransferVehicle() {
            return this.transferVehicle;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarAddress(String usedCarAddress) {
            this.usedCarAddress = usedCarAddress;
            return this;
        }
        public String getUsedCarAddress() {
            return this.usedCarAddress;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarket(String usedCarMarket) {
            this.usedCarMarket = usedCarMarket;
            return this;
        }
        public String getUsedCarMarket() {
            return this.usedCarMarket;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarketBank(String usedCarMarketBank) {
            this.usedCarMarketBank = usedCarMarketBank;
            return this;
        }
        public String getUsedCarMarketBank() {
            return this.usedCarMarketBank;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarketPhone(String usedCarMarketPhone) {
            this.usedCarMarketPhone = usedCarMarketPhone;
            return this;
        }
        public String getUsedCarMarketPhone() {
            return this.usedCarMarketPhone;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarketTaxNo(String usedCarMarketTaxNo) {
            this.usedCarMarketTaxNo = usedCarMarketTaxNo;
            return this;
        }
        public String getUsedCarMarketTaxNo() {
            return this.usedCarMarketTaxNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList extends TeaModel {
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

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
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

        public static UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList self = new UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setBrand(String brand) {
            this.brand = brand;
            return this;
        }
        public String getBrand() {
            return this.brand;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setCertificateNo(String certificateNo) {
            this.certificateNo = certificateNo;
            return this;
        }
        public String getCertificateNo() {
            return this.certificateNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setEngineNo(String engineNo) {
            this.engineNo = engineNo;
            return this;
        }
        public String getEngineNo() {
            return this.engineNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setIdCardNo(String idCardNo) {
            this.idCardNo = idCardNo;
            return this;
        }
        public String getIdCardNo() {
            return this.idCardNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setImportCertificateNo(String importCertificateNo) {
            this.importCertificateNo = importCertificateNo;
            return this;
        }
        public String getImportCertificateNo() {
            return this.importCertificateNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setInspectionListNo(String inspectionListNo) {
            this.inspectionListNo = inspectionListNo;
            return this;
        }
        public String getInspectionListNo() {
            return this.inspectionListNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setMaxPassengers(String maxPassengers) {
            this.maxPassengers = maxPassengers;
            return this;
        }
        public String getMaxPassengers() {
            return this.maxPassengers;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setOriginPlace(String originPlace) {
            this.originPlace = originPlace;
            return this;
        }
        public String getOriginPlace() {
            return this.originPlace;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setPaymentVoucherNo(String paymentVoucherNo) {
            this.paymentVoucherNo = paymentVoucherNo;
            return this;
        }
        public String getPaymentVoucherNo() {
            return this.paymentVoucherNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setTaxAuthorityName(String taxAuthorityName) {
            this.taxAuthorityName = taxAuthorityName;
            return this;
        }
        public String getTaxAuthorityName() {
            return this.taxAuthorityName;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setTaxAuthorityNo(String taxAuthorityNo) {
            this.taxAuthorityNo = taxAuthorityNo;
            return this;
        }
        public String getTaxAuthorityNo() {
            return this.taxAuthorityNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setTonnage(String tonnage) {
            this.tonnage = tonnage;
            return this;
        }
        public String getTonnage() {
            return this.tonnage;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO extends TeaModel {
        @NameInMap("accountPeriod")
        public String accountPeriod;

        /**
         * <strong>example:</strong>
         * <p>ABC</p>
         */
        @NameInMap("agentCode")
        public String agentCode;

        @NameInMap("amount")
        public String amount;

        @NameInMap("amountWithTax")
        public String amountWithTax;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("caacDevelopmentFund")
        public String caacDevelopmentFund;

        @NameInMap("checkCode")
        public String checkCode;

        @NameInMap("checkTime")
        public String checkTime;

        /**
         * <strong>example:</strong>
         * <p>杭州</p>
         */
        @NameInMap("city")
        public String city;

        /**
         * <strong>example:</strong>
         * <p>北京</p>
         */
        @NameInMap("destination")
        public String destination;

        /**
         * <strong>example:</strong>
         * <p>123KM</p>
         */
        @NameInMap("distance")
        public String distance;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("drawerName")
        public String drawerName;

        @NameInMap("drewDate")
        public String drewDate;

        @NameInMap("electronicUrl")
        public String electronicUrl;

        /**
         * <strong>example:</strong>
         * <p>杭州北</p>
         */
        @NameInMap("entrance")
        public String entrance;

        /**
         * <strong>example:</strong>
         * <p>杭州北</p>
         */
        @NameInMap("exit")
        public String exit;

        @NameInMap("financeType")
        public String financeType;

        @NameInMap("flightItineraryDetails")
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails> flightItineraryDetails;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("fuelSurcharge")
        public String fuelSurcharge;

        @NameInMap("fundType")
        public String fundType;

        @NameInMap("generalInvoiceDetailVOList")
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList> generalInvoiceDetailVOList;

        /**
         * <strong>example:</strong>
         * <p>18:00</p>
         */
        @NameInMap("getOffTime")
        public String getOffTime;

        /**
         * <strong>example:</strong>
         * <p>17:00</p>
         */
        @NameInMap("getOnTime")
        public String getOnTime;

        /**
         * <strong>example:</strong>
         * <p><a href="http://XXX.jpg">http://XXX.jpg</a></p>
         */
        @NameInMap("imageUrl")
        public String imageUrl;

        @NameInMap("invoiceCode")
        public String invoiceCode;

        @NameInMap("invoiceNo")
        public String invoiceNo;

        @NameInMap("invoiceStatus")
        public String invoiceStatus;

        @NameInMap("invoiceType")
        public String invoiceType;

        /**
         * <strong>example:</strong>
         * <p>ABCD</p>
         */
        @NameInMap("issueBy")
        public String issueBy;

        @NameInMap("machineCode")
        public String machineCode;

        @NameInMap("oilFlag")
        public String oilFlag;

        /**
         * <strong>example:</strong>
         * <p>杭州</p>
         */
        @NameInMap("origin")
        public String origin;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("passenger")
        public String passenger;

        /**
         * <strong>example:</strong>
         * <p>330781****1234</p>
         */
        @NameInMap("passengerUserId")
        public String passengerUserId;

        @NameInMap("payee")
        public String payee;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("printSerialNumber")
        public String printSerialNumber;

        @NameInMap("processInstCode")
        public String processInstCode;

        @NameInMap("processInstType")
        public String processInstType;

        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("purchaserBankAccount")
        public String purchaserBankAccount;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("purchaserBankNameAccount")
        public String purchaserBankNameAccount;

        @NameInMap("purchaserName")
        public String purchaserName;

        @NameInMap("purchaserTaxNo")
        public String purchaserTaxNo;

        @NameInMap("purchaserTel")
        public String purchaserTel;

        /**
         * <strong>example:</strong>
         * <p><a href="mailto:abc@test.com">abc@test.com</a></p>
         */
        @NameInMap("receiverEmail")
        public String receiverEmail;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("receiverName")
        public String receiverName;

        /**
         * <strong>example:</strong>
         * <p>1234567809</p>
         */
        @NameInMap("receiverTel")
        public String receiverTel;

        @NameInMap("remark")
        public String remark;

        /**
         * <strong>example:</strong>
         * <p>2023-09-01</p>
         */
        @NameInMap("seatClass")
        public String seatClass;

        @NameInMap("secondHandCarInvoiceDetailList")
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList;

        @NameInMap("sellerAddress")
        public String sellerAddress;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("sellerBankAccount")
        public String sellerBankAccount;

        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("sellerBankNameAccount")
        public String sellerBankNameAccount;

        @NameInMap("sellerName")
        public String sellerName;

        @NameInMap("sellerTaxNo")
        public String sellerTaxNo;

        @NameInMap("sellerTel")
        public String sellerTel;

        /**
         * <strong>example:</strong>
         * <p>杭州</p>
         */
        @NameInMap("serialNo")
        public String serialNo;

        /**
         * <strong>example:</strong>
         * <p>杭州</p>
         */
        @NameInMap("startTime")
        public String startTime;

        @NameInMap("supplySign")
        public String supplySign;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("surcharge")
        public String surcharge;

        @NameInMap("taxAmount")
        public String taxAmount;

        /**
         * <strong>example:</strong>
         * <p>G1234</p>
         */
        @NameInMap("trainNo")
        public String trainNo;

        /**
         * <strong>example:</strong>
         * <p>2023-09-01</p>
         */
        @NameInMap("travelDate")
        public String travelDate;

        @NameInMap("usedVehicleSaleDetailVOList")
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList;

        @NameInMap("vehicleSaleDetailVOList")
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList> vehicleSaleDetailVOList;

        @NameInMap("verifyStatus")
        public String verifyStatus;

        @NameInMap("voucherCode")
        public String voucherCode;

        @NameInMap("voucherStatus")
        public String voucherStatus;

        public static UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO self = new UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setAccountPeriod(String accountPeriod) {
            this.accountPeriod = accountPeriod;
            return this;
        }
        public String getAccountPeriod() {
            return this.accountPeriod;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setAgentCode(String agentCode) {
            this.agentCode = agentCode;
            return this;
        }
        public String getAgentCode() {
            return this.agentCode;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setAmountWithTax(String amountWithTax) {
            this.amountWithTax = amountWithTax;
            return this;
        }
        public String getAmountWithTax() {
            return this.amountWithTax;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setCaacDevelopmentFund(String caacDevelopmentFund) {
            this.caacDevelopmentFund = caacDevelopmentFund;
            return this;
        }
        public String getCaacDevelopmentFund() {
            return this.caacDevelopmentFund;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setCheckCode(String checkCode) {
            this.checkCode = checkCode;
            return this;
        }
        public String getCheckCode() {
            return this.checkCode;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setCity(String city) {
            this.city = city;
            return this;
        }
        public String getCity() {
            return this.city;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setDestination(String destination) {
            this.destination = destination;
            return this;
        }
        public String getDestination() {
            return this.destination;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setDistance(String distance) {
            this.distance = distance;
            return this;
        }
        public String getDistance() {
            return this.distance;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setDrawerName(String drawerName) {
            this.drawerName = drawerName;
            return this;
        }
        public String getDrawerName() {
            return this.drawerName;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setDrewDate(String drewDate) {
            this.drewDate = drewDate;
            return this;
        }
        public String getDrewDate() {
            return this.drewDate;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setElectronicUrl(String electronicUrl) {
            this.electronicUrl = electronicUrl;
            return this;
        }
        public String getElectronicUrl() {
            return this.electronicUrl;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setEntrance(String entrance) {
            this.entrance = entrance;
            return this;
        }
        public String getEntrance() {
            return this.entrance;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setExit(String exit) {
            this.exit = exit;
            return this;
        }
        public String getExit() {
            return this.exit;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setFinanceType(String financeType) {
            this.financeType = financeType;
            return this;
        }
        public String getFinanceType() {
            return this.financeType;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setFlightItineraryDetails(java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails> flightItineraryDetails) {
            this.flightItineraryDetails = flightItineraryDetails;
            return this;
        }
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails> getFlightItineraryDetails() {
            return this.flightItineraryDetails;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setFuelSurcharge(String fuelSurcharge) {
            this.fuelSurcharge = fuelSurcharge;
            return this;
        }
        public String getFuelSurcharge() {
            return this.fuelSurcharge;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setFundType(String fundType) {
            this.fundType = fundType;
            return this;
        }
        public String getFundType() {
            return this.fundType;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setGeneralInvoiceDetailVOList(java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList> generalInvoiceDetailVOList) {
            this.generalInvoiceDetailVOList = generalInvoiceDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList> getGeneralInvoiceDetailVOList() {
            return this.generalInvoiceDetailVOList;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setGetOffTime(String getOffTime) {
            this.getOffTime = getOffTime;
            return this;
        }
        public String getGetOffTime() {
            return this.getOffTime;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setGetOnTime(String getOnTime) {
            this.getOnTime = getOnTime;
            return this;
        }
        public String getGetOnTime() {
            return this.getOnTime;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setImageUrl(String imageUrl) {
            this.imageUrl = imageUrl;
            return this;
        }
        public String getImageUrl() {
            return this.imageUrl;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setInvoiceStatus(String invoiceStatus) {
            this.invoiceStatus = invoiceStatus;
            return this;
        }
        public String getInvoiceStatus() {
            return this.invoiceStatus;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setIssueBy(String issueBy) {
            this.issueBy = issueBy;
            return this;
        }
        public String getIssueBy() {
            return this.issueBy;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setMachineCode(String machineCode) {
            this.machineCode = machineCode;
            return this;
        }
        public String getMachineCode() {
            return this.machineCode;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setOilFlag(String oilFlag) {
            this.oilFlag = oilFlag;
            return this;
        }
        public String getOilFlag() {
            return this.oilFlag;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setOrigin(String origin) {
            this.origin = origin;
            return this;
        }
        public String getOrigin() {
            return this.origin;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setPassenger(String passenger) {
            this.passenger = passenger;
            return this;
        }
        public String getPassenger() {
            return this.passenger;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setPassengerUserId(String passengerUserId) {
            this.passengerUserId = passengerUserId;
            return this;
        }
        public String getPassengerUserId() {
            return this.passengerUserId;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setPayee(String payee) {
            this.payee = payee;
            return this;
        }
        public String getPayee() {
            return this.payee;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setPrintSerialNumber(String printSerialNumber) {
            this.printSerialNumber = printSerialNumber;
            return this;
        }
        public String getPrintSerialNumber() {
            return this.printSerialNumber;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setProcessInstCode(String processInstCode) {
            this.processInstCode = processInstCode;
            return this;
        }
        public String getProcessInstCode() {
            return this.processInstCode;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setProcessInstType(String processInstType) {
            this.processInstType = processInstType;
            return this;
        }
        public String getProcessInstType() {
            return this.processInstType;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setPurchaserAddress(String purchaserAddress) {
            this.purchaserAddress = purchaserAddress;
            return this;
        }
        public String getPurchaserAddress() {
            return this.purchaserAddress;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setPurchaserBankAccount(String purchaserBankAccount) {
            this.purchaserBankAccount = purchaserBankAccount;
            return this;
        }
        public String getPurchaserBankAccount() {
            return this.purchaserBankAccount;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setPurchaserBankNameAccount(String purchaserBankNameAccount) {
            this.purchaserBankNameAccount = purchaserBankNameAccount;
            return this;
        }
        public String getPurchaserBankNameAccount() {
            return this.purchaserBankNameAccount;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setPurchaserName(String purchaserName) {
            this.purchaserName = purchaserName;
            return this;
        }
        public String getPurchaserName() {
            return this.purchaserName;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setPurchaserTaxNo(String purchaserTaxNo) {
            this.purchaserTaxNo = purchaserTaxNo;
            return this;
        }
        public String getPurchaserTaxNo() {
            return this.purchaserTaxNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setPurchaserTel(String purchaserTel) {
            this.purchaserTel = purchaserTel;
            return this;
        }
        public String getPurchaserTel() {
            return this.purchaserTel;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setReceiverEmail(String receiverEmail) {
            this.receiverEmail = receiverEmail;
            return this;
        }
        public String getReceiverEmail() {
            return this.receiverEmail;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setReceiverName(String receiverName) {
            this.receiverName = receiverName;
            return this;
        }
        public String getReceiverName() {
            return this.receiverName;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setReceiverTel(String receiverTel) {
            this.receiverTel = receiverTel;
            return this;
        }
        public String getReceiverTel() {
            return this.receiverTel;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setSeatClass(String seatClass) {
            this.seatClass = seatClass;
            return this;
        }
        public String getSeatClass() {
            return this.seatClass;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setSecondHandCarInvoiceDetailList(java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList) {
            this.secondHandCarInvoiceDetailList = secondHandCarInvoiceDetailList;
            return this;
        }
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList> getSecondHandCarInvoiceDetailList() {
            return this.secondHandCarInvoiceDetailList;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setSellerAddress(String sellerAddress) {
            this.sellerAddress = sellerAddress;
            return this;
        }
        public String getSellerAddress() {
            return this.sellerAddress;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setSellerBankAccount(String sellerBankAccount) {
            this.sellerBankAccount = sellerBankAccount;
            return this;
        }
        public String getSellerBankAccount() {
            return this.sellerBankAccount;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setSellerBankNameAccount(String sellerBankNameAccount) {
            this.sellerBankNameAccount = sellerBankNameAccount;
            return this;
        }
        public String getSellerBankNameAccount() {
            return this.sellerBankNameAccount;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setSellerName(String sellerName) {
            this.sellerName = sellerName;
            return this;
        }
        public String getSellerName() {
            return this.sellerName;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setSellerTaxNo(String sellerTaxNo) {
            this.sellerTaxNo = sellerTaxNo;
            return this;
        }
        public String getSellerTaxNo() {
            return this.sellerTaxNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setSellerTel(String sellerTel) {
            this.sellerTel = sellerTel;
            return this;
        }
        public String getSellerTel() {
            return this.sellerTel;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setSerialNo(String serialNo) {
            this.serialNo = serialNo;
            return this;
        }
        public String getSerialNo() {
            return this.serialNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setStartTime(String startTime) {
            this.startTime = startTime;
            return this;
        }
        public String getStartTime() {
            return this.startTime;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setSupplySign(String supplySign) {
            this.supplySign = supplySign;
            return this;
        }
        public String getSupplySign() {
            return this.supplySign;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setSurcharge(String surcharge) {
            this.surcharge = surcharge;
            return this;
        }
        public String getSurcharge() {
            return this.surcharge;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setTrainNo(String trainNo) {
            this.trainNo = trainNo;
            return this;
        }
        public String getTrainNo() {
            return this.trainNo;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setTravelDate(String travelDate) {
            this.travelDate = travelDate;
            return this;
        }
        public String getTravelDate() {
            return this.travelDate;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setUsedVehicleSaleDetailVOList(java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList) {
            this.usedVehicleSaleDetailVOList = usedVehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList> getUsedVehicleSaleDetailVOList() {
            return this.usedVehicleSaleDetailVOList;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setVehicleSaleDetailVOList(java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList> vehicleSaleDetailVOList) {
            this.vehicleSaleDetailVOList = vehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList> getVehicleSaleDetailVOList() {
            return this.vehicleSaleDetailVOList;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setVerifyStatus(String verifyStatus) {
            this.verifyStatus = verifyStatus;
            return this;
        }
        public String getVerifyStatus() {
            return this.verifyStatus;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setVoucherCode(String voucherCode) {
            this.voucherCode = voucherCode;
            return this;
        }
        public String getVoucherCode() {
            return this.voucherCode;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setVoucherStatus(String voucherStatus) {
            this.voucherStatus = voucherStatus;
            return this;
        }
        public String getVoucherStatus() {
            return this.voucherStatus;
        }

    }

}
