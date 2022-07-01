// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceIgnoreStatusRequest extends TeaModel {
    // 发票全票面信息
    @NameInMap("generalInvoiceVO")
    public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO generalInvoiceVO;

    // 发票编码
    @NameInMap("invoiceCode")
    public String invoiceCode;

    // 发票号码
    @NameInMap("invoiceNo")
    public String invoiceNo;

    // 发票状态
    @NameInMap("status")
    public String status;

    public static UpdateInvoiceIgnoreStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceIgnoreStatusRequest self = new UpdateInvoiceIgnoreStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceIgnoreStatusRequest setGeneralInvoiceVO(UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO generalInvoiceVO) {
        this.generalInvoiceVO = generalInvoiceVO;
        return this;
    }
    public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO getGeneralInvoiceVO() {
        return this.generalInvoiceVO;
    }

    public UpdateInvoiceIgnoreStatusRequest setInvoiceCode(String invoiceCode) {
        this.invoiceCode = invoiceCode;
        return this;
    }
    public String getInvoiceCode() {
        return this.invoiceCode;
    }

    public UpdateInvoiceIgnoreStatusRequest setInvoiceNo(String invoiceNo) {
        this.invoiceNo = invoiceNo;
        return this;
    }
    public String getInvoiceNo() {
        return this.invoiceNo;
    }

    public UpdateInvoiceIgnoreStatusRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public static class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList extends TeaModel {
        // 金额
        @NameInMap("amount")
        public String amount;

        // 商品名称
        @NameInMap("goodName")
        public String goodName;

        // 数量
        @NameInMap("quantity")
        public String quantity;

        // 税收分类编码
        @NameInMap("revenueCode")
        public String revenueCode;

        // 行号
        @NameInMap("rowNo")
        public String rowNo;

        // 规格型号
        @NameInMap("specification")
        public String specification;

        // 税额
        @NameInMap("taxAmount")
        public String taxAmount;

        // 是否享受税收优惠：0-不享受，1-享受
        @NameInMap("taxPre")
        public String taxPre;

        // 税率
        @NameInMap("taxRate")
        public String taxRate;

        // 单位
        @NameInMap("unit")
        public String unit;

        // 单价
        @NameInMap("unitPrice")
        public String unitPrice;

        public static UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList self = new UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setGoodName(String goodName) {
            this.goodName = goodName;
            return this;
        }
        public String getGoodName() {
            return this.goodName;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setQuantity(String quantity) {
            this.quantity = quantity;
            return this;
        }
        public String getQuantity() {
            return this.quantity;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxPre(String taxPre) {
            this.taxPre = taxPre;
            return this;
        }
        public String getTaxPre() {
            return this.taxPre;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList setUnitPrice(String unitPrice) {
            this.unitPrice = unitPrice;
            return this;
        }
        public String getUnitPrice() {
            return this.unitPrice;
        }

    }

    public static class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList extends TeaModel {
        // 金额
        @NameInMap("amount")
        public String amount;

        // 车牌号
        @NameInMap("cardNo")
        public String cardNo;

        // 通行日期止
        @NameInMap("endDate")
        public String endDate;

        // 商品名称
        @NameInMap("goodsName")
        public String goodsName;

        // 税收分类编码
        @NameInMap("revenueCode")
        public String revenueCode;

        // 行号
        @NameInMap("rowNo")
        public String rowNo;

        // 通行日期起
        @NameInMap("startDate")
        public String startDate;

        // 税额
        @NameInMap("taxAmount")
        public String taxAmount;

        // 税率
        @NameInMap("taxRate")
        public String taxRate;

        // 类型
        @NameInMap("vehicleType")
        public String vehicleType;

        public static UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList self = new UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList extends TeaModel {
        // 经营、拍卖单位
        @NameInMap("auctionUnit")
        public String auctionUnit;

        // 经营、拍卖单位地址
        @NameInMap("auctionUnitAddress")
        public String auctionUnitAddress;

        // 经营、拍卖单位银行
        @NameInMap("auctionUnitBank")
        public String auctionUnitBank;

        // 经营、拍卖单位税号
        @NameInMap("auctionUnitTaxNo")
        public String auctionUnitTaxNo;

        // 经营、拍卖单位电话
        @NameInMap("auctionUtilTel")
        public String auctionUtilTel;

        // 厂牌型号
        @NameInMap("carModel")
        public String carModel;

        // 车牌照号
        @NameInMap("cardNo")
        public String cardNo;

        // 登记证号
        @NameInMap("registration")
        public String registration;

        // 转入地车辆管理所名称
        @NameInMap("transferVehicle")
        public String transferVehicle;

        // 二手车市场地址
        @NameInMap("usedCarAddress")
        public String usedCarAddress;

        // 二手车市场
        @NameInMap("usedCarMarket")
        public String usedCarMarket;

        // 二手车市场开户银行、账号
        @NameInMap("usedCarMarketBank")
        public String usedCarMarketBank;

        // 二手车市场电话
        @NameInMap("usedCarMarketPhone")
        public String usedCarMarketPhone;

        // 二手车市场纳税人识别号
        @NameInMap("usedCarMarketTaxNo")
        public String usedCarMarketTaxNo;

        // 车架号/车辆识别号
        @NameInMap("vehicleNo")
        public String vehicleNo;

        // 车辆类型
        @NameInMap("vehicleType")
        public String vehicleType;

        public static UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList self = new UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnit(String auctionUnit) {
            this.auctionUnit = auctionUnit;
            return this;
        }
        public String getAuctionUnit() {
            return this.auctionUnit;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnitAddress(String auctionUnitAddress) {
            this.auctionUnitAddress = auctionUnitAddress;
            return this;
        }
        public String getAuctionUnitAddress() {
            return this.auctionUnitAddress;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnitBank(String auctionUnitBank) {
            this.auctionUnitBank = auctionUnitBank;
            return this;
        }
        public String getAuctionUnitBank() {
            return this.auctionUnitBank;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnitTaxNo(String auctionUnitTaxNo) {
            this.auctionUnitTaxNo = auctionUnitTaxNo;
            return this;
        }
        public String getAuctionUnitTaxNo() {
            return this.auctionUnitTaxNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUtilTel(String auctionUtilTel) {
            this.auctionUtilTel = auctionUtilTel;
            return this;
        }
        public String getAuctionUtilTel() {
            return this.auctionUtilTel;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setCarModel(String carModel) {
            this.carModel = carModel;
            return this;
        }
        public String getCarModel() {
            return this.carModel;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setRegistration(String registration) {
            this.registration = registration;
            return this;
        }
        public String getRegistration() {
            return this.registration;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setTransferVehicle(String transferVehicle) {
            this.transferVehicle = transferVehicle;
            return this;
        }
        public String getTransferVehicle() {
            return this.transferVehicle;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarAddress(String usedCarAddress) {
            this.usedCarAddress = usedCarAddress;
            return this;
        }
        public String getUsedCarAddress() {
            return this.usedCarAddress;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarket(String usedCarMarket) {
            this.usedCarMarket = usedCarMarket;
            return this;
        }
        public String getUsedCarMarket() {
            return this.usedCarMarket;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarketBank(String usedCarMarketBank) {
            this.usedCarMarketBank = usedCarMarketBank;
            return this;
        }
        public String getUsedCarMarketBank() {
            return this.usedCarMarketBank;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarketPhone(String usedCarMarketPhone) {
            this.usedCarMarketPhone = usedCarMarketPhone;
            return this;
        }
        public String getUsedCarMarketPhone() {
            return this.usedCarMarketPhone;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarketTaxNo(String usedCarMarketTaxNo) {
            this.usedCarMarketTaxNo = usedCarMarketTaxNo;
            return this;
        }
        public String getUsedCarMarketTaxNo() {
            return this.usedCarMarketTaxNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList extends TeaModel {
        // 品牌
        @NameInMap("brand")
        public String brand;

        // 合格证号
        @NameInMap("certificateNo")
        public String certificateNo;

        // 发动机号
        @NameInMap("engineNo")
        public String engineNo;

        // 身份证号/组织机构代码
        @NameInMap("idCardNo")
        public String idCardNo;

        // 进口证书号
        @NameInMap("importCertificateNo")
        public String importCertificateNo;

        // 限乘人数
        @NameInMap("maxPassengers")
        public String maxPassengers;

        // 产地
        @NameInMap("originPlace")
        public String originPlace;

        // 完税凭证号码
        @NameInMap("paymentVoucherNo")
        public String paymentVoucherNo;

        // 主管税务机关名称
        @NameInMap("taxAuthorityName")
        public String taxAuthorityName;

        // 主管税务机关代码
        @NameInMap("taxAuthorityNo")
        public String taxAuthorityNo;

        // 税率
        @NameInMap("taxRate")
        public String taxRate;

        // 吨位
        @NameInMap("tonnage")
        public String tonnage;

        // 车架号码
        @NameInMap("vehicleNo")
        public String vehicleNo;

        // 车辆类型
        @NameInMap("vehicleType")
        public String vehicleType;

        public static UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList self = new UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setBrand(String brand) {
            this.brand = brand;
            return this;
        }
        public String getBrand() {
            return this.brand;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setCertificateNo(String certificateNo) {
            this.certificateNo = certificateNo;
            return this;
        }
        public String getCertificateNo() {
            return this.certificateNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setEngineNo(String engineNo) {
            this.engineNo = engineNo;
            return this;
        }
        public String getEngineNo() {
            return this.engineNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setIdCardNo(String idCardNo) {
            this.idCardNo = idCardNo;
            return this;
        }
        public String getIdCardNo() {
            return this.idCardNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setImportCertificateNo(String importCertificateNo) {
            this.importCertificateNo = importCertificateNo;
            return this;
        }
        public String getImportCertificateNo() {
            return this.importCertificateNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setMaxPassengers(String maxPassengers) {
            this.maxPassengers = maxPassengers;
            return this;
        }
        public String getMaxPassengers() {
            return this.maxPassengers;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setOriginPlace(String originPlace) {
            this.originPlace = originPlace;
            return this;
        }
        public String getOriginPlace() {
            return this.originPlace;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setPaymentVoucherNo(String paymentVoucherNo) {
            this.paymentVoucherNo = paymentVoucherNo;
            return this;
        }
        public String getPaymentVoucherNo() {
            return this.paymentVoucherNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setTaxAuthorityName(String taxAuthorityName) {
            this.taxAuthorityName = taxAuthorityName;
            return this;
        }
        public String getTaxAuthorityName() {
            return this.taxAuthorityName;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setTaxAuthorityNo(String taxAuthorityNo) {
            this.taxAuthorityNo = taxAuthorityNo;
            return this;
        }
        public String getTaxAuthorityNo() {
            return this.taxAuthorityNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setTonnage(String tonnage) {
            this.tonnage = tonnage;
            return this;
        }
        public String getTonnage() {
            return this.tonnage;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO extends TeaModel {
        // 账期时间
        @NameInMap("accountPeriod")
        public String accountPeriod;

        // 不含税金额
        @NameInMap("amount")
        public String amount;

        // 含税金额
        @NameInMap("amountWithTax")
        public String amountWithTax;

        // 校验码
        @NameInMap("checkCode")
        public String checkCode;

        // 查验时间
        @NameInMap("checkTime")
        public String checkTime;

        // 开票日期
        @NameInMap("drewDate")
        public String drewDate;

        // 电票版式文件下载地址
        @NameInMap("electronicUrl")
        public String electronicUrl;

        // 财务类型，INPUT-VAT(进项),OUTPUT_VAT(销项)
        @NameInMap("financeType")
        public String financeType;

        // 资金类型 ，RED（红票），（BLUE）蓝票
        @NameInMap("fundType")
        public String fundType;

        // 常规发票明细
        @NameInMap("generalInvoiceDetailVOList")
        public java.util.List<UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList> generalInvoiceDetailVOList;

        // 发票代码
        @NameInMap("invoiceCode")
        public String invoiceCode;

        // 发票号码
        @NameInMap("invoiceNo")
        public String invoiceNo;

        // 发票类型
        @NameInMap("invoiceType")
        public String invoiceType;

        // 机器码
        @NameInMap("machineCode")
        public String machineCode;

        // 成品油标识
        @NameInMap("oilFlag")
        public String oilFlag;

        // 收款人
        @NameInMap("payee")
        public String payee;

        // 审批单实例
        @NameInMap("processInstCode")
        public String processInstCode;

        // 审批单类型
        @NameInMap("processInstType")
        public String processInstType;

        // 购方地址
        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        // 购方银行
        @NameInMap("purchaserBankNameAccount")
        public String purchaserBankNameAccount;

        // 购方名称
        @NameInMap("purchaserName")
        public String purchaserName;

        // 购方税号
        @NameInMap("purchaserTaxNo")
        public String purchaserTaxNo;

        // 购方电话
        @NameInMap("purchaserTel")
        public String purchaserTel;

        // 备注
        @NameInMap("remark")
        public String remark;

        @NameInMap("secondHandCarInvoiceDetailList")
        public java.util.List<UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList;

        // 销方地址
        @NameInMap("sellerAddress")
        public String sellerAddress;

        // 销方银行
        @NameInMap("sellerBankNameAccount")
        public String sellerBankNameAccount;

        // 销方名称
        @NameInMap("sellerName")
        public String sellerName;

        // 销方税号
        @NameInMap("sellerTaxNo")
        public String sellerTaxNo;

        // 销方电话
        @NameInMap("sellerTel")
        public String sellerTel;

        // 发票状态
        @NameInMap("status")
        public String status;

        // 代开发票标识 1-自开，2-代开
        @NameInMap("supplySign")
        public String supplySign;

        // 税额
        @NameInMap("taxAmount")
        public String taxAmount;

        @NameInMap("usedVehicleSaleDetailVOList")
        public java.util.List<UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList;

        @NameInMap("vehicleSaleDetailVOList")
        public java.util.List<UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList> vehicleSaleDetailVOList;

        // 发票查验状态
        @NameInMap("verifyStatus")
        public String verifyStatus;

        // 凭证code
        @NameInMap("voucherCode")
        public String voucherCode;

        // 生成凭证状态
        @NameInMap("voucherStatus")
        public String voucherStatus;

        public static UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO self = new UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setAccountPeriod(String accountPeriod) {
            this.accountPeriod = accountPeriod;
            return this;
        }
        public String getAccountPeriod() {
            return this.accountPeriod;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setAmountWithTax(String amountWithTax) {
            this.amountWithTax = amountWithTax;
            return this;
        }
        public String getAmountWithTax() {
            return this.amountWithTax;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setCheckCode(String checkCode) {
            this.checkCode = checkCode;
            return this;
        }
        public String getCheckCode() {
            return this.checkCode;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setDrewDate(String drewDate) {
            this.drewDate = drewDate;
            return this;
        }
        public String getDrewDate() {
            return this.drewDate;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setElectronicUrl(String electronicUrl) {
            this.electronicUrl = electronicUrl;
            return this;
        }
        public String getElectronicUrl() {
            return this.electronicUrl;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setFinanceType(String financeType) {
            this.financeType = financeType;
            return this;
        }
        public String getFinanceType() {
            return this.financeType;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setFundType(String fundType) {
            this.fundType = fundType;
            return this;
        }
        public String getFundType() {
            return this.fundType;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setGeneralInvoiceDetailVOList(java.util.List<UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList> generalInvoiceDetailVOList) {
            this.generalInvoiceDetailVOList = generalInvoiceDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList> getGeneralInvoiceDetailVOList() {
            return this.generalInvoiceDetailVOList;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setMachineCode(String machineCode) {
            this.machineCode = machineCode;
            return this;
        }
        public String getMachineCode() {
            return this.machineCode;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setOilFlag(String oilFlag) {
            this.oilFlag = oilFlag;
            return this;
        }
        public String getOilFlag() {
            return this.oilFlag;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setPayee(String payee) {
            this.payee = payee;
            return this;
        }
        public String getPayee() {
            return this.payee;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setProcessInstCode(String processInstCode) {
            this.processInstCode = processInstCode;
            return this;
        }
        public String getProcessInstCode() {
            return this.processInstCode;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setProcessInstType(String processInstType) {
            this.processInstType = processInstType;
            return this;
        }
        public String getProcessInstType() {
            return this.processInstType;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setPurchaserAddress(String purchaserAddress) {
            this.purchaserAddress = purchaserAddress;
            return this;
        }
        public String getPurchaserAddress() {
            return this.purchaserAddress;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setPurchaserBankNameAccount(String purchaserBankNameAccount) {
            this.purchaserBankNameAccount = purchaserBankNameAccount;
            return this;
        }
        public String getPurchaserBankNameAccount() {
            return this.purchaserBankNameAccount;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setPurchaserName(String purchaserName) {
            this.purchaserName = purchaserName;
            return this;
        }
        public String getPurchaserName() {
            return this.purchaserName;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setPurchaserTaxNo(String purchaserTaxNo) {
            this.purchaserTaxNo = purchaserTaxNo;
            return this;
        }
        public String getPurchaserTaxNo() {
            return this.purchaserTaxNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setPurchaserTel(String purchaserTel) {
            this.purchaserTel = purchaserTel;
            return this;
        }
        public String getPurchaserTel() {
            return this.purchaserTel;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setSecondHandCarInvoiceDetailList(java.util.List<UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList) {
            this.secondHandCarInvoiceDetailList = secondHandCarInvoiceDetailList;
            return this;
        }
        public java.util.List<UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList> getSecondHandCarInvoiceDetailList() {
            return this.secondHandCarInvoiceDetailList;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setSellerAddress(String sellerAddress) {
            this.sellerAddress = sellerAddress;
            return this;
        }
        public String getSellerAddress() {
            return this.sellerAddress;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setSellerBankNameAccount(String sellerBankNameAccount) {
            this.sellerBankNameAccount = sellerBankNameAccount;
            return this;
        }
        public String getSellerBankNameAccount() {
            return this.sellerBankNameAccount;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setSellerName(String sellerName) {
            this.sellerName = sellerName;
            return this;
        }
        public String getSellerName() {
            return this.sellerName;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setSellerTaxNo(String sellerTaxNo) {
            this.sellerTaxNo = sellerTaxNo;
            return this;
        }
        public String getSellerTaxNo() {
            return this.sellerTaxNo;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setSellerTel(String sellerTel) {
            this.sellerTel = sellerTel;
            return this;
        }
        public String getSellerTel() {
            return this.sellerTel;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setSupplySign(String supplySign) {
            this.supplySign = supplySign;
            return this;
        }
        public String getSupplySign() {
            return this.supplySign;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setUsedVehicleSaleDetailVOList(java.util.List<UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList) {
            this.usedVehicleSaleDetailVOList = usedVehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList> getUsedVehicleSaleDetailVOList() {
            return this.usedVehicleSaleDetailVOList;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setVehicleSaleDetailVOList(java.util.List<UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList> vehicleSaleDetailVOList) {
            this.vehicleSaleDetailVOList = vehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVOList> getVehicleSaleDetailVOList() {
            return this.vehicleSaleDetailVOList;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setVerifyStatus(String verifyStatus) {
            this.verifyStatus = verifyStatus;
            return this;
        }
        public String getVerifyStatus() {
            return this.verifyStatus;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setVoucherCode(String voucherCode) {
            this.voucherCode = voucherCode;
            return this;
        }
        public String getVoucherCode() {
            return this.voucherCode;
        }

        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO setVoucherStatus(String voucherStatus) {
            this.voucherStatus = voucherStatus;
            return this;
        }
        public String getVoucherStatus() {
            return this.voucherStatus;
        }

    }

}
