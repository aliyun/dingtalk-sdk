// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetInvoiceByPageResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public GetInvoiceByPageResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetInvoiceByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInvoiceByPageResponseBody self = new GetInvoiceByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInvoiceByPageResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public GetInvoiceByPageResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public GetInvoiceByPageResponseBody setResult(GetInvoiceByPageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetInvoiceByPageResponseBodyResult getResult() {
        return this.result;
    }

    public GetInvoiceByPageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList extends TeaModel {
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

        @NameInMap("taxRate")
        public String taxRate;

        @NameInMap("unit")
        public String unit;

        @NameInMap("unitPrice")
        public String unitPrice;

        public static GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList self = new GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList();
            return TeaModel.build(map, self);
        }

        public GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList setQuantity(String quantity) {
            this.quantity = quantity;
            return this;
        }
        public String getQuantity() {
            return this.quantity;
        }

        public GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList setTaxPre(String taxPre) {
            this.taxPre = taxPre;
            return this;
        }
        public String getTaxPre() {
            return this.taxPre;
        }

        public GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList setUnitPrice(String unitPrice) {
            this.unitPrice = unitPrice;
            return this;
        }
        public String getUnitPrice() {
            return this.unitPrice;
        }

    }

    public static class GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList extends TeaModel {
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

        public static GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList self = new GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList();
            return TeaModel.build(map, self);
        }

        public GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList extends TeaModel {
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

        public static GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList self = new GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setAuctionUnit(String auctionUnit) {
            this.auctionUnit = auctionUnit;
            return this;
        }
        public String getAuctionUnit() {
            return this.auctionUnit;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setAuctionUnitAddress(String auctionUnitAddress) {
            this.auctionUnitAddress = auctionUnitAddress;
            return this;
        }
        public String getAuctionUnitAddress() {
            return this.auctionUnitAddress;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setAuctionUnitBank(String auctionUnitBank) {
            this.auctionUnitBank = auctionUnitBank;
            return this;
        }
        public String getAuctionUnitBank() {
            return this.auctionUnitBank;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setAuctionUnitTaxNo(String auctionUnitTaxNo) {
            this.auctionUnitTaxNo = auctionUnitTaxNo;
            return this;
        }
        public String getAuctionUnitTaxNo() {
            return this.auctionUnitTaxNo;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setAuctionUtilTel(String auctionUtilTel) {
            this.auctionUtilTel = auctionUtilTel;
            return this;
        }
        public String getAuctionUtilTel() {
            return this.auctionUtilTel;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setCarModel(String carModel) {
            this.carModel = carModel;
            return this;
        }
        public String getCarModel() {
            return this.carModel;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setRegistration(String registration) {
            this.registration = registration;
            return this;
        }
        public String getRegistration() {
            return this.registration;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setTransferVehicle(String transferVehicle) {
            this.transferVehicle = transferVehicle;
            return this;
        }
        public String getTransferVehicle() {
            return this.transferVehicle;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setUsedCarAddress(String usedCarAddress) {
            this.usedCarAddress = usedCarAddress;
            return this;
        }
        public String getUsedCarAddress() {
            return this.usedCarAddress;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setUsedCarMarket(String usedCarMarket) {
            this.usedCarMarket = usedCarMarket;
            return this;
        }
        public String getUsedCarMarket() {
            return this.usedCarMarket;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setUsedCarMarketBank(String usedCarMarketBank) {
            this.usedCarMarketBank = usedCarMarketBank;
            return this;
        }
        public String getUsedCarMarketBank() {
            return this.usedCarMarketBank;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setUsedCarMarketPhone(String usedCarMarketPhone) {
            this.usedCarMarketPhone = usedCarMarketPhone;
            return this;
        }
        public String getUsedCarMarketPhone() {
            return this.usedCarMarketPhone;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setUsedCarMarketTaxNo(String usedCarMarketTaxNo) {
            this.usedCarMarketTaxNo = usedCarMarketTaxNo;
            return this;
        }
        public String getUsedCarMarketTaxNo() {
            return this.usedCarMarketTaxNo;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList extends TeaModel {
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

        public static GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList self = new GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setBrand(String brand) {
            this.brand = brand;
            return this;
        }
        public String getBrand() {
            return this.brand;
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setCertificateNo(String certificateNo) {
            this.certificateNo = certificateNo;
            return this;
        }
        public String getCertificateNo() {
            return this.certificateNo;
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setEngineNo(String engineNo) {
            this.engineNo = engineNo;
            return this;
        }
        public String getEngineNo() {
            return this.engineNo;
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setIdCardNo(String idCardNo) {
            this.idCardNo = idCardNo;
            return this;
        }
        public String getIdCardNo() {
            return this.idCardNo;
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setImportCertificateNo(String importCertificateNo) {
            this.importCertificateNo = importCertificateNo;
            return this;
        }
        public String getImportCertificateNo() {
            return this.importCertificateNo;
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setMaxPassengers(String maxPassengers) {
            this.maxPassengers = maxPassengers;
            return this;
        }
        public String getMaxPassengers() {
            return this.maxPassengers;
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setOriginPlace(String originPlace) {
            this.originPlace = originPlace;
            return this;
        }
        public String getOriginPlace() {
            return this.originPlace;
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setPaymentVoucherNo(String paymentVoucherNo) {
            this.paymentVoucherNo = paymentVoucherNo;
            return this;
        }
        public String getPaymentVoucherNo() {
            return this.paymentVoucherNo;
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setTaxAuthorityName(String taxAuthorityName) {
            this.taxAuthorityName = taxAuthorityName;
            return this;
        }
        public String getTaxAuthorityName() {
            return this.taxAuthorityName;
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setTaxAuthorityNo(String taxAuthorityNo) {
            this.taxAuthorityNo = taxAuthorityNo;
            return this;
        }
        public String getTaxAuthorityNo() {
            return this.taxAuthorityNo;
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setTonnage(String tonnage) {
            this.tonnage = tonnage;
            return this;
        }
        public String getTonnage() {
            return this.tonnage;
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class GetInvoiceByPageResponseBodyResultList extends TeaModel {
        @NameInMap("accountPeriod")
        public String accountPeriod;

        @NameInMap("amount")
        public String amount;

        @NameInMap("amountWithTax")
        public String amountWithTax;

        @NameInMap("checkCode")
        public String checkCode;

        @NameInMap("checkTime")
        public String checkTime;

        @NameInMap("drewDate")
        public String drewDate;

        @NameInMap("electronicUrl")
        public String electronicUrl;

        @NameInMap("financeType")
        public String financeType;

        @NameInMap("fundType")
        public String fundType;

        @NameInMap("generalInvoiceDetailVOList")
        public java.util.List<GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList> generalInvoiceDetailVOList;

        @NameInMap("invoiceCode")
        public String invoiceCode;

        @NameInMap("invoiceNo")
        public String invoiceNo;

        @NameInMap("invoiceStatus")
        public String invoiceStatus;

        @NameInMap("invoiceType")
        public String invoiceType;

        @NameInMap("machineCode")
        public String machineCode;

        @NameInMap("oilFlag")
        public String oilFlag;

        @NameInMap("payee")
        public String payee;

        @NameInMap("processInstCode")
        public String processInstCode;

        @NameInMap("processInstType")
        public String processInstType;

        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        @NameInMap("purchaserBankNameAccount")
        public String purchaserBankNameAccount;

        @NameInMap("purchaserName")
        public String purchaserName;

        @NameInMap("purchaserTaxNo")
        public String purchaserTaxNo;

        @NameInMap("purchaserTel")
        public String purchaserTel;

        @NameInMap("remark")
        public String remark;

        @NameInMap("sellerAddress")
        public String sellerAddress;

        @NameInMap("sellerBankNameAccount")
        public String sellerBankNameAccount;

        @NameInMap("sellerName")
        public String sellerName;

        @NameInMap("sellerTaxNo")
        public String sellerTaxNo;

        @NameInMap("sellerTel")
        public String sellerTel;

        @NameInMap("status")
        public String status;

        @NameInMap("supplySign")
        public String supplySign;

        @NameInMap("taxAmount")
        public String taxAmount;

        @NameInMap("transportFeeDetailVOList")
        public java.util.List<GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList> transportFeeDetailVOList;

        @NameInMap("usedVehicleSaleDetailVOList")
        public java.util.List<GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList;

        @NameInMap("vehicleSaleDetailVOList")
        public java.util.List<GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList> vehicleSaleDetailVOList;

        @NameInMap("verifyStatus")
        public String verifyStatus;

        @NameInMap("voucherCode")
        public String voucherCode;

        @NameInMap("voucherStatus")
        public String voucherStatus;

        public static GetInvoiceByPageResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            GetInvoiceByPageResponseBodyResultList self = new GetInvoiceByPageResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public GetInvoiceByPageResponseBodyResultList setAccountPeriod(String accountPeriod) {
            this.accountPeriod = accountPeriod;
            return this;
        }
        public String getAccountPeriod() {
            return this.accountPeriod;
        }

        public GetInvoiceByPageResponseBodyResultList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public GetInvoiceByPageResponseBodyResultList setAmountWithTax(String amountWithTax) {
            this.amountWithTax = amountWithTax;
            return this;
        }
        public String getAmountWithTax() {
            return this.amountWithTax;
        }

        public GetInvoiceByPageResponseBodyResultList setCheckCode(String checkCode) {
            this.checkCode = checkCode;
            return this;
        }
        public String getCheckCode() {
            return this.checkCode;
        }

        public GetInvoiceByPageResponseBodyResultList setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public GetInvoiceByPageResponseBodyResultList setDrewDate(String drewDate) {
            this.drewDate = drewDate;
            return this;
        }
        public String getDrewDate() {
            return this.drewDate;
        }

        public GetInvoiceByPageResponseBodyResultList setElectronicUrl(String electronicUrl) {
            this.electronicUrl = electronicUrl;
            return this;
        }
        public String getElectronicUrl() {
            return this.electronicUrl;
        }

        public GetInvoiceByPageResponseBodyResultList setFinanceType(String financeType) {
            this.financeType = financeType;
            return this;
        }
        public String getFinanceType() {
            return this.financeType;
        }

        public GetInvoiceByPageResponseBodyResultList setFundType(String fundType) {
            this.fundType = fundType;
            return this;
        }
        public String getFundType() {
            return this.fundType;
        }

        public GetInvoiceByPageResponseBodyResultList setGeneralInvoiceDetailVOList(java.util.List<GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList> generalInvoiceDetailVOList) {
            this.generalInvoiceDetailVOList = generalInvoiceDetailVOList;
            return this;
        }
        public java.util.List<GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList> getGeneralInvoiceDetailVOList() {
            return this.generalInvoiceDetailVOList;
        }

        public GetInvoiceByPageResponseBodyResultList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public GetInvoiceByPageResponseBodyResultList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public GetInvoiceByPageResponseBodyResultList setInvoiceStatus(String invoiceStatus) {
            this.invoiceStatus = invoiceStatus;
            return this;
        }
        public String getInvoiceStatus() {
            return this.invoiceStatus;
        }

        public GetInvoiceByPageResponseBodyResultList setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

        public GetInvoiceByPageResponseBodyResultList setMachineCode(String machineCode) {
            this.machineCode = machineCode;
            return this;
        }
        public String getMachineCode() {
            return this.machineCode;
        }

        public GetInvoiceByPageResponseBodyResultList setOilFlag(String oilFlag) {
            this.oilFlag = oilFlag;
            return this;
        }
        public String getOilFlag() {
            return this.oilFlag;
        }

        public GetInvoiceByPageResponseBodyResultList setPayee(String payee) {
            this.payee = payee;
            return this;
        }
        public String getPayee() {
            return this.payee;
        }

        public GetInvoiceByPageResponseBodyResultList setProcessInstCode(String processInstCode) {
            this.processInstCode = processInstCode;
            return this;
        }
        public String getProcessInstCode() {
            return this.processInstCode;
        }

        public GetInvoiceByPageResponseBodyResultList setProcessInstType(String processInstType) {
            this.processInstType = processInstType;
            return this;
        }
        public String getProcessInstType() {
            return this.processInstType;
        }

        public GetInvoiceByPageResponseBodyResultList setPurchaserAddress(String purchaserAddress) {
            this.purchaserAddress = purchaserAddress;
            return this;
        }
        public String getPurchaserAddress() {
            return this.purchaserAddress;
        }

        public GetInvoiceByPageResponseBodyResultList setPurchaserBankNameAccount(String purchaserBankNameAccount) {
            this.purchaserBankNameAccount = purchaserBankNameAccount;
            return this;
        }
        public String getPurchaserBankNameAccount() {
            return this.purchaserBankNameAccount;
        }

        public GetInvoiceByPageResponseBodyResultList setPurchaserName(String purchaserName) {
            this.purchaserName = purchaserName;
            return this;
        }
        public String getPurchaserName() {
            return this.purchaserName;
        }

        public GetInvoiceByPageResponseBodyResultList setPurchaserTaxNo(String purchaserTaxNo) {
            this.purchaserTaxNo = purchaserTaxNo;
            return this;
        }
        public String getPurchaserTaxNo() {
            return this.purchaserTaxNo;
        }

        public GetInvoiceByPageResponseBodyResultList setPurchaserTel(String purchaserTel) {
            this.purchaserTel = purchaserTel;
            return this;
        }
        public String getPurchaserTel() {
            return this.purchaserTel;
        }

        public GetInvoiceByPageResponseBodyResultList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public GetInvoiceByPageResponseBodyResultList setSellerAddress(String sellerAddress) {
            this.sellerAddress = sellerAddress;
            return this;
        }
        public String getSellerAddress() {
            return this.sellerAddress;
        }

        public GetInvoiceByPageResponseBodyResultList setSellerBankNameAccount(String sellerBankNameAccount) {
            this.sellerBankNameAccount = sellerBankNameAccount;
            return this;
        }
        public String getSellerBankNameAccount() {
            return this.sellerBankNameAccount;
        }

        public GetInvoiceByPageResponseBodyResultList setSellerName(String sellerName) {
            this.sellerName = sellerName;
            return this;
        }
        public String getSellerName() {
            return this.sellerName;
        }

        public GetInvoiceByPageResponseBodyResultList setSellerTaxNo(String sellerTaxNo) {
            this.sellerTaxNo = sellerTaxNo;
            return this;
        }
        public String getSellerTaxNo() {
            return this.sellerTaxNo;
        }

        public GetInvoiceByPageResponseBodyResultList setSellerTel(String sellerTel) {
            this.sellerTel = sellerTel;
            return this;
        }
        public String getSellerTel() {
            return this.sellerTel;
        }

        public GetInvoiceByPageResponseBodyResultList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetInvoiceByPageResponseBodyResultList setSupplySign(String supplySign) {
            this.supplySign = supplySign;
            return this;
        }
        public String getSupplySign() {
            return this.supplySign;
        }

        public GetInvoiceByPageResponseBodyResultList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public GetInvoiceByPageResponseBodyResultList setTransportFeeDetailVOList(java.util.List<GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList> transportFeeDetailVOList) {
            this.transportFeeDetailVOList = transportFeeDetailVOList;
            return this;
        }
        public java.util.List<GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList> getTransportFeeDetailVOList() {
            return this.transportFeeDetailVOList;
        }

        public GetInvoiceByPageResponseBodyResultList setUsedVehicleSaleDetailVOList(java.util.List<GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList) {
            this.usedVehicleSaleDetailVOList = usedVehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList> getUsedVehicleSaleDetailVOList() {
            return this.usedVehicleSaleDetailVOList;
        }

        public GetInvoiceByPageResponseBodyResultList setVehicleSaleDetailVOList(java.util.List<GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList> vehicleSaleDetailVOList) {
            this.vehicleSaleDetailVOList = vehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList> getVehicleSaleDetailVOList() {
            return this.vehicleSaleDetailVOList;
        }

        public GetInvoiceByPageResponseBodyResultList setVerifyStatus(String verifyStatus) {
            this.verifyStatus = verifyStatus;
            return this;
        }
        public String getVerifyStatus() {
            return this.verifyStatus;
        }

        public GetInvoiceByPageResponseBodyResultList setVoucherCode(String voucherCode) {
            this.voucherCode = voucherCode;
            return this;
        }
        public String getVoucherCode() {
            return this.voucherCode;
        }

        public GetInvoiceByPageResponseBodyResultList setVoucherStatus(String voucherStatus) {
            this.voucherStatus = voucherStatus;
            return this;
        }
        public String getVoucherStatus() {
            return this.voucherStatus;
        }

    }

    public static class GetInvoiceByPageResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public String hasMore;

        @NameInMap("list")
        public java.util.List<GetInvoiceByPageResponseBodyResultList> list;

        @NameInMap("nextCursor")
        public Long nextCursor;

        @NameInMap("totalCount")
        public Long totalCount;

        public static GetInvoiceByPageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetInvoiceByPageResponseBodyResult self = new GetInvoiceByPageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetInvoiceByPageResponseBodyResult setHasMore(String hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public String getHasMore() {
            return this.hasMore;
        }

        public GetInvoiceByPageResponseBodyResult setList(java.util.List<GetInvoiceByPageResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<GetInvoiceByPageResponseBodyResultList> getList() {
            return this.list;
        }

        public GetInvoiceByPageResponseBodyResult setNextCursor(Long nextCursor) {
            this.nextCursor = nextCursor;
            return this;
        }
        public Long getNextCursor() {
            return this.nextCursor;
        }

        public GetInvoiceByPageResponseBodyResult setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
