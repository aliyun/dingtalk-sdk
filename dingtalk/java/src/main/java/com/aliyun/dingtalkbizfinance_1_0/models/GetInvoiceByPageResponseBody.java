// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetInvoiceByPageResponseBody extends TeaModel {
    @NameInMap("list")
    public java.util.List<GetInvoiceByPageResponseBodyList> list;

    public static GetInvoiceByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInvoiceByPageResponseBody self = new GetInvoiceByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInvoiceByPageResponseBody setList(java.util.List<GetInvoiceByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<GetInvoiceByPageResponseBodyList> getList() {
        return this.list;
    }

    public static class GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList extends TeaModel {
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

        public static GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList self = new GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList();
            return TeaModel.build(map, self);
        }

        public GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList setGoodName(String goodName) {
            this.goodName = goodName;
            return this;
        }
        public String getGoodName() {
            return this.goodName;
        }

        public GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList setQuantity(String quantity) {
            this.quantity = quantity;
            return this;
        }
        public String getQuantity() {
            return this.quantity;
        }

        public GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList setTaxPre(String taxPre) {
            this.taxPre = taxPre;
            return this;
        }
        public String getTaxPre() {
            return this.taxPre;
        }

        public GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList setUnitPrice(String unitPrice) {
            this.unitPrice = unitPrice;
            return this;
        }
        public String getUnitPrice() {
            return this.unitPrice;
        }

    }

    public static class GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail extends TeaModel {
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

        public static GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail build(java.util.Map<String, ?> map) throws Exception {
            GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail self = new GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail();
            return TeaModel.build(map, self);
        }

        public GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO extends TeaModel {
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

        public static GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO build(java.util.Map<String, ?> map) throws Exception {
            GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO self = new GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO();
            return TeaModel.build(map, self);
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setAuctionUnit(String auctionUnit) {
            this.auctionUnit = auctionUnit;
            return this;
        }
        public String getAuctionUnit() {
            return this.auctionUnit;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setAuctionUnitAddress(String auctionUnitAddress) {
            this.auctionUnitAddress = auctionUnitAddress;
            return this;
        }
        public String getAuctionUnitAddress() {
            return this.auctionUnitAddress;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setAuctionUnitBank(String auctionUnitBank) {
            this.auctionUnitBank = auctionUnitBank;
            return this;
        }
        public String getAuctionUnitBank() {
            return this.auctionUnitBank;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setAuctionUnitTaxNo(String auctionUnitTaxNo) {
            this.auctionUnitTaxNo = auctionUnitTaxNo;
            return this;
        }
        public String getAuctionUnitTaxNo() {
            return this.auctionUnitTaxNo;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setAuctionUtilTel(String auctionUtilTel) {
            this.auctionUtilTel = auctionUtilTel;
            return this;
        }
        public String getAuctionUtilTel() {
            return this.auctionUtilTel;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setCarModel(String carModel) {
            this.carModel = carModel;
            return this;
        }
        public String getCarModel() {
            return this.carModel;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setRegistration(String registration) {
            this.registration = registration;
            return this;
        }
        public String getRegistration() {
            return this.registration;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setTransferVehicle(String transferVehicle) {
            this.transferVehicle = transferVehicle;
            return this;
        }
        public String getTransferVehicle() {
            return this.transferVehicle;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setUsedCarAddress(String usedCarAddress) {
            this.usedCarAddress = usedCarAddress;
            return this;
        }
        public String getUsedCarAddress() {
            return this.usedCarAddress;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setUsedCarMarket(String usedCarMarket) {
            this.usedCarMarket = usedCarMarket;
            return this;
        }
        public String getUsedCarMarket() {
            return this.usedCarMarket;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setUsedCarMarketBank(String usedCarMarketBank) {
            this.usedCarMarketBank = usedCarMarketBank;
            return this;
        }
        public String getUsedCarMarketBank() {
            return this.usedCarMarketBank;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setUsedCarMarketPhone(String usedCarMarketPhone) {
            this.usedCarMarketPhone = usedCarMarketPhone;
            return this;
        }
        public String getUsedCarMarketPhone() {
            return this.usedCarMarketPhone;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setUsedCarMarketTaxNo(String usedCarMarketTaxNo) {
            this.usedCarMarketTaxNo = usedCarMarketTaxNo;
            return this;
        }
        public String getUsedCarMarketTaxNo() {
            return this.usedCarMarketTaxNo;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class GetInvoiceByPageResponseBodyListVehicleSaleDetailVO extends TeaModel {
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

        public static GetInvoiceByPageResponseBodyListVehicleSaleDetailVO build(java.util.Map<String, ?> map) throws Exception {
            GetInvoiceByPageResponseBodyListVehicleSaleDetailVO self = new GetInvoiceByPageResponseBodyListVehicleSaleDetailVO();
            return TeaModel.build(map, self);
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setBrand(String brand) {
            this.brand = brand;
            return this;
        }
        public String getBrand() {
            return this.brand;
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setCertificateNo(String certificateNo) {
            this.certificateNo = certificateNo;
            return this;
        }
        public String getCertificateNo() {
            return this.certificateNo;
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setEngineNo(String engineNo) {
            this.engineNo = engineNo;
            return this;
        }
        public String getEngineNo() {
            return this.engineNo;
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setIdCardNo(String idCardNo) {
            this.idCardNo = idCardNo;
            return this;
        }
        public String getIdCardNo() {
            return this.idCardNo;
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setImportCertificateNo(String importCertificateNo) {
            this.importCertificateNo = importCertificateNo;
            return this;
        }
        public String getImportCertificateNo() {
            return this.importCertificateNo;
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setMaxPassengers(String maxPassengers) {
            this.maxPassengers = maxPassengers;
            return this;
        }
        public String getMaxPassengers() {
            return this.maxPassengers;
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setOriginPlace(String originPlace) {
            this.originPlace = originPlace;
            return this;
        }
        public String getOriginPlace() {
            return this.originPlace;
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setPaymentVoucherNo(String paymentVoucherNo) {
            this.paymentVoucherNo = paymentVoucherNo;
            return this;
        }
        public String getPaymentVoucherNo() {
            return this.paymentVoucherNo;
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setTaxAuthorityName(String taxAuthorityName) {
            this.taxAuthorityName = taxAuthorityName;
            return this;
        }
        public String getTaxAuthorityName() {
            return this.taxAuthorityName;
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setTaxAuthorityNo(String taxAuthorityNo) {
            this.taxAuthorityNo = taxAuthorityNo;
            return this;
        }
        public String getTaxAuthorityNo() {
            return this.taxAuthorityNo;
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setTonnage(String tonnage) {
            this.tonnage = tonnage;
            return this;
        }
        public String getTonnage() {
            return this.tonnage;
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class GetInvoiceByPageResponseBodyList extends TeaModel {
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
        public java.util.List<GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList> generalInvoiceDetailVOList;

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

        @NameInMap("secondHandCarInvoiceDetail")
        public java.util.List<GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail> secondHandCarInvoiceDetail;

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

        @NameInMap("usedVehicleSaleDetailVO")
        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO usedVehicleSaleDetailVO;

        @NameInMap("vehicleSaleDetailVO")
        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO vehicleSaleDetailVO;

        // 发票查验状态
        @NameInMap("verifyStatus")
        public String verifyStatus;

        // 凭证code
        @NameInMap("voucherCode")
        public String voucherCode;

        // 生成凭证状态
        @NameInMap("voucherStatus")
        public String voucherStatus;

        public static GetInvoiceByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            GetInvoiceByPageResponseBodyList self = new GetInvoiceByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public GetInvoiceByPageResponseBodyList setAccountPeriod(String accountPeriod) {
            this.accountPeriod = accountPeriod;
            return this;
        }
        public String getAccountPeriod() {
            return this.accountPeriod;
        }

        public GetInvoiceByPageResponseBodyList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public GetInvoiceByPageResponseBodyList setAmountWithTax(String amountWithTax) {
            this.amountWithTax = amountWithTax;
            return this;
        }
        public String getAmountWithTax() {
            return this.amountWithTax;
        }

        public GetInvoiceByPageResponseBodyList setCheckCode(String checkCode) {
            this.checkCode = checkCode;
            return this;
        }
        public String getCheckCode() {
            return this.checkCode;
        }

        public GetInvoiceByPageResponseBodyList setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public GetInvoiceByPageResponseBodyList setDrewDate(String drewDate) {
            this.drewDate = drewDate;
            return this;
        }
        public String getDrewDate() {
            return this.drewDate;
        }

        public GetInvoiceByPageResponseBodyList setElectronicUrl(String electronicUrl) {
            this.electronicUrl = electronicUrl;
            return this;
        }
        public String getElectronicUrl() {
            return this.electronicUrl;
        }

        public GetInvoiceByPageResponseBodyList setFinanceType(String financeType) {
            this.financeType = financeType;
            return this;
        }
        public String getFinanceType() {
            return this.financeType;
        }

        public GetInvoiceByPageResponseBodyList setFundType(String fundType) {
            this.fundType = fundType;
            return this;
        }
        public String getFundType() {
            return this.fundType;
        }

        public GetInvoiceByPageResponseBodyList setGeneralInvoiceDetailVOList(java.util.List<GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList> generalInvoiceDetailVOList) {
            this.generalInvoiceDetailVOList = generalInvoiceDetailVOList;
            return this;
        }
        public java.util.List<GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList> getGeneralInvoiceDetailVOList() {
            return this.generalInvoiceDetailVOList;
        }

        public GetInvoiceByPageResponseBodyList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public GetInvoiceByPageResponseBodyList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public GetInvoiceByPageResponseBodyList setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

        public GetInvoiceByPageResponseBodyList setMachineCode(String machineCode) {
            this.machineCode = machineCode;
            return this;
        }
        public String getMachineCode() {
            return this.machineCode;
        }

        public GetInvoiceByPageResponseBodyList setOilFlag(String oilFlag) {
            this.oilFlag = oilFlag;
            return this;
        }
        public String getOilFlag() {
            return this.oilFlag;
        }

        public GetInvoiceByPageResponseBodyList setPayee(String payee) {
            this.payee = payee;
            return this;
        }
        public String getPayee() {
            return this.payee;
        }

        public GetInvoiceByPageResponseBodyList setProcessInstCode(String processInstCode) {
            this.processInstCode = processInstCode;
            return this;
        }
        public String getProcessInstCode() {
            return this.processInstCode;
        }

        public GetInvoiceByPageResponseBodyList setProcessInstType(String processInstType) {
            this.processInstType = processInstType;
            return this;
        }
        public String getProcessInstType() {
            return this.processInstType;
        }

        public GetInvoiceByPageResponseBodyList setPurchaserAddress(String purchaserAddress) {
            this.purchaserAddress = purchaserAddress;
            return this;
        }
        public String getPurchaserAddress() {
            return this.purchaserAddress;
        }

        public GetInvoiceByPageResponseBodyList setPurchaserBankNameAccount(String purchaserBankNameAccount) {
            this.purchaserBankNameAccount = purchaserBankNameAccount;
            return this;
        }
        public String getPurchaserBankNameAccount() {
            return this.purchaserBankNameAccount;
        }

        public GetInvoiceByPageResponseBodyList setPurchaserName(String purchaserName) {
            this.purchaserName = purchaserName;
            return this;
        }
        public String getPurchaserName() {
            return this.purchaserName;
        }

        public GetInvoiceByPageResponseBodyList setPurchaserTaxNo(String purchaserTaxNo) {
            this.purchaserTaxNo = purchaserTaxNo;
            return this;
        }
        public String getPurchaserTaxNo() {
            return this.purchaserTaxNo;
        }

        public GetInvoiceByPageResponseBodyList setPurchaserTel(String purchaserTel) {
            this.purchaserTel = purchaserTel;
            return this;
        }
        public String getPurchaserTel() {
            return this.purchaserTel;
        }

        public GetInvoiceByPageResponseBodyList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public GetInvoiceByPageResponseBodyList setSecondHandCarInvoiceDetail(java.util.List<GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail> secondHandCarInvoiceDetail) {
            this.secondHandCarInvoiceDetail = secondHandCarInvoiceDetail;
            return this;
        }
        public java.util.List<GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail> getSecondHandCarInvoiceDetail() {
            return this.secondHandCarInvoiceDetail;
        }

        public GetInvoiceByPageResponseBodyList setSellerAddress(String sellerAddress) {
            this.sellerAddress = sellerAddress;
            return this;
        }
        public String getSellerAddress() {
            return this.sellerAddress;
        }

        public GetInvoiceByPageResponseBodyList setSellerBankNameAccount(String sellerBankNameAccount) {
            this.sellerBankNameAccount = sellerBankNameAccount;
            return this;
        }
        public String getSellerBankNameAccount() {
            return this.sellerBankNameAccount;
        }

        public GetInvoiceByPageResponseBodyList setSellerName(String sellerName) {
            this.sellerName = sellerName;
            return this;
        }
        public String getSellerName() {
            return this.sellerName;
        }

        public GetInvoiceByPageResponseBodyList setSellerTaxNo(String sellerTaxNo) {
            this.sellerTaxNo = sellerTaxNo;
            return this;
        }
        public String getSellerTaxNo() {
            return this.sellerTaxNo;
        }

        public GetInvoiceByPageResponseBodyList setSellerTel(String sellerTel) {
            this.sellerTel = sellerTel;
            return this;
        }
        public String getSellerTel() {
            return this.sellerTel;
        }

        public GetInvoiceByPageResponseBodyList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetInvoiceByPageResponseBodyList setSupplySign(String supplySign) {
            this.supplySign = supplySign;
            return this;
        }
        public String getSupplySign() {
            return this.supplySign;
        }

        public GetInvoiceByPageResponseBodyList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public GetInvoiceByPageResponseBodyList setUsedVehicleSaleDetailVO(GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO usedVehicleSaleDetailVO) {
            this.usedVehicleSaleDetailVO = usedVehicleSaleDetailVO;
            return this;
        }
        public GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO getUsedVehicleSaleDetailVO() {
            return this.usedVehicleSaleDetailVO;
        }

        public GetInvoiceByPageResponseBodyList setVehicleSaleDetailVO(GetInvoiceByPageResponseBodyListVehicleSaleDetailVO vehicleSaleDetailVO) {
            this.vehicleSaleDetailVO = vehicleSaleDetailVO;
            return this;
        }
        public GetInvoiceByPageResponseBodyListVehicleSaleDetailVO getVehicleSaleDetailVO() {
            return this.vehicleSaleDetailVO;
        }

        public GetInvoiceByPageResponseBodyList setVerifyStatus(String verifyStatus) {
            this.verifyStatus = verifyStatus;
            return this;
        }
        public String getVerifyStatus() {
            return this.verifyStatus;
        }

        public GetInvoiceByPageResponseBodyList setVoucherCode(String voucherCode) {
            this.voucherCode = voucherCode;
            return this;
        }
        public String getVoucherCode() {
            return this.voucherCode;
        }

        public GetInvoiceByPageResponseBodyList setVoucherStatus(String voucherStatus) {
            this.voucherStatus = voucherStatus;
            return this;
        }
        public String getVoucherStatus() {
            return this.voucherStatus;
        }

    }

}
