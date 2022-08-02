// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAbandonStatusRequest extends TeaModel {
    // 发票全票面信息（蓝票）
    @NameInMap("blueGeneralInvoiceVO")
    public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO blueGeneralInvoiceVO;

    // 发票编码（蓝票）
    @NameInMap("blueInvoiceCode")
    public String blueInvoiceCode;

    // 发票号码（蓝票）
    @NameInMap("blueInvoiceNo")
    public String blueInvoiceNo;

    // 状态-红冲、废弃
    @NameInMap("blueInvoiceStatus")
    public String blueInvoiceStatus;

    // 操作员
    @NameInMap("operator")
    public String operator;

    // 发票全票面信息（红票）
    @NameInMap("redGeneralInvoiceVO")
    public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO redGeneralInvoiceVO;

    // 红字发票code
    @NameInMap("redInvoiceCode")
    public String redInvoiceCode;

    // 红字发票编码
    @NameInMap("redInvoiceNo")
    public String redInvoiceNo;

    // 红字发票状态
    @NameInMap("redInvoiceStatus")
    public String redInvoiceStatus;

    // 目标发票
    @NameInMap("targetInvoice")
    public String targetInvoice;

    public static UpdateInvoiceAbandonStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceAbandonStatusRequest self = new UpdateInvoiceAbandonStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceAbandonStatusRequest setBlueGeneralInvoiceVO(UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO blueGeneralInvoiceVO) {
        this.blueGeneralInvoiceVO = blueGeneralInvoiceVO;
        return this;
    }
    public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO getBlueGeneralInvoiceVO() {
        return this.blueGeneralInvoiceVO;
    }

    public UpdateInvoiceAbandonStatusRequest setBlueInvoiceCode(String blueInvoiceCode) {
        this.blueInvoiceCode = blueInvoiceCode;
        return this;
    }
    public String getBlueInvoiceCode() {
        return this.blueInvoiceCode;
    }

    public UpdateInvoiceAbandonStatusRequest setBlueInvoiceNo(String blueInvoiceNo) {
        this.blueInvoiceNo = blueInvoiceNo;
        return this;
    }
    public String getBlueInvoiceNo() {
        return this.blueInvoiceNo;
    }

    public UpdateInvoiceAbandonStatusRequest setBlueInvoiceStatus(String blueInvoiceStatus) {
        this.blueInvoiceStatus = blueInvoiceStatus;
        return this;
    }
    public String getBlueInvoiceStatus() {
        return this.blueInvoiceStatus;
    }

    public UpdateInvoiceAbandonStatusRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public UpdateInvoiceAbandonStatusRequest setRedGeneralInvoiceVO(UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO redGeneralInvoiceVO) {
        this.redGeneralInvoiceVO = redGeneralInvoiceVO;
        return this;
    }
    public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO getRedGeneralInvoiceVO() {
        return this.redGeneralInvoiceVO;
    }

    public UpdateInvoiceAbandonStatusRequest setRedInvoiceCode(String redInvoiceCode) {
        this.redInvoiceCode = redInvoiceCode;
        return this;
    }
    public String getRedInvoiceCode() {
        return this.redInvoiceCode;
    }

    public UpdateInvoiceAbandonStatusRequest setRedInvoiceNo(String redInvoiceNo) {
        this.redInvoiceNo = redInvoiceNo;
        return this;
    }
    public String getRedInvoiceNo() {
        return this.redInvoiceNo;
    }

    public UpdateInvoiceAbandonStatusRequest setRedInvoiceStatus(String redInvoiceStatus) {
        this.redInvoiceStatus = redInvoiceStatus;
        return this;
    }
    public String getRedInvoiceStatus() {
        return this.redInvoiceStatus;
    }

    public UpdateInvoiceAbandonStatusRequest setTargetInvoice(String targetInvoice) {
        this.targetInvoice = targetInvoice;
        return this;
    }
    public String getTargetInvoice() {
        return this.targetInvoice;
    }

    public static class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList extends TeaModel {
        // 金额
        @NameInMap("amount")
        public String amount;

        // 商品名称
        @NameInMap("goodsName")
        public String goodsName;

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

        // 优惠政策类型
        @NameInMap("taxPreType")
        public String taxPreType;

        // 税率
        @NameInMap("taxRate")
        public String taxRate;

        // 单位
        @NameInMap("unit")
        public String unit;

        // 单价
        @NameInMap("unitPrice")
        public String unitPrice;

        public static UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList self = new UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList setQuantity(String quantity) {
            this.quantity = quantity;
            return this;
        }
        public String getQuantity() {
            return this.quantity;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxPre(String taxPre) {
            this.taxPre = taxPre;
            return this;
        }
        public String getTaxPre() {
            return this.taxPre;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxPreType(String taxPreType) {
            this.taxPreType = taxPreType;
            return this;
        }
        public String getTaxPreType() {
            return this.taxPreType;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList setUnitPrice(String unitPrice) {
            this.unitPrice = unitPrice;
            return this;
        }
        public String getUnitPrice() {
            return this.unitPrice;
        }

    }

    public static class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList extends TeaModel {
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

        public static UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList self = new UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList extends TeaModel {
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

        public static UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList self = new UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnit(String auctionUnit) {
            this.auctionUnit = auctionUnit;
            return this;
        }
        public String getAuctionUnit() {
            return this.auctionUnit;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnitAddress(String auctionUnitAddress) {
            this.auctionUnitAddress = auctionUnitAddress;
            return this;
        }
        public String getAuctionUnitAddress() {
            return this.auctionUnitAddress;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnitBank(String auctionUnitBank) {
            this.auctionUnitBank = auctionUnitBank;
            return this;
        }
        public String getAuctionUnitBank() {
            return this.auctionUnitBank;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnitTaxNo(String auctionUnitTaxNo) {
            this.auctionUnitTaxNo = auctionUnitTaxNo;
            return this;
        }
        public String getAuctionUnitTaxNo() {
            return this.auctionUnitTaxNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUtilTel(String auctionUtilTel) {
            this.auctionUtilTel = auctionUtilTel;
            return this;
        }
        public String getAuctionUtilTel() {
            return this.auctionUtilTel;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setCarModel(String carModel) {
            this.carModel = carModel;
            return this;
        }
        public String getCarModel() {
            return this.carModel;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setRegistration(String registration) {
            this.registration = registration;
            return this;
        }
        public String getRegistration() {
            return this.registration;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setTransferVehicle(String transferVehicle) {
            this.transferVehicle = transferVehicle;
            return this;
        }
        public String getTransferVehicle() {
            return this.transferVehicle;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarAddress(String usedCarAddress) {
            this.usedCarAddress = usedCarAddress;
            return this;
        }
        public String getUsedCarAddress() {
            return this.usedCarAddress;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarket(String usedCarMarket) {
            this.usedCarMarket = usedCarMarket;
            return this;
        }
        public String getUsedCarMarket() {
            return this.usedCarMarket;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarketBank(String usedCarMarketBank) {
            this.usedCarMarketBank = usedCarMarketBank;
            return this;
        }
        public String getUsedCarMarketBank() {
            return this.usedCarMarketBank;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarketPhone(String usedCarMarketPhone) {
            this.usedCarMarketPhone = usedCarMarketPhone;
            return this;
        }
        public String getUsedCarMarketPhone() {
            return this.usedCarMarketPhone;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarketTaxNo(String usedCarMarketTaxNo) {
            this.usedCarMarketTaxNo = usedCarMarketTaxNo;
            return this;
        }
        public String getUsedCarMarketTaxNo() {
            return this.usedCarMarketTaxNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList extends TeaModel {
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

        @NameInMap("inspectionListNo")
        public String inspectionListNo;

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

        public static UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList self = new UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setBrand(String brand) {
            this.brand = brand;
            return this;
        }
        public String getBrand() {
            return this.brand;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setCertificateNo(String certificateNo) {
            this.certificateNo = certificateNo;
            return this;
        }
        public String getCertificateNo() {
            return this.certificateNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setEngineNo(String engineNo) {
            this.engineNo = engineNo;
            return this;
        }
        public String getEngineNo() {
            return this.engineNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setIdCardNo(String idCardNo) {
            this.idCardNo = idCardNo;
            return this;
        }
        public String getIdCardNo() {
            return this.idCardNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setImportCertificateNo(String importCertificateNo) {
            this.importCertificateNo = importCertificateNo;
            return this;
        }
        public String getImportCertificateNo() {
            return this.importCertificateNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setInspectionListNo(String inspectionListNo) {
            this.inspectionListNo = inspectionListNo;
            return this;
        }
        public String getInspectionListNo() {
            return this.inspectionListNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setMaxPassengers(String maxPassengers) {
            this.maxPassengers = maxPassengers;
            return this;
        }
        public String getMaxPassengers() {
            return this.maxPassengers;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setOriginPlace(String originPlace) {
            this.originPlace = originPlace;
            return this;
        }
        public String getOriginPlace() {
            return this.originPlace;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setPaymentVoucherNo(String paymentVoucherNo) {
            this.paymentVoucherNo = paymentVoucherNo;
            return this;
        }
        public String getPaymentVoucherNo() {
            return this.paymentVoucherNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setTaxAuthorityName(String taxAuthorityName) {
            this.taxAuthorityName = taxAuthorityName;
            return this;
        }
        public String getTaxAuthorityName() {
            return this.taxAuthorityName;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setTaxAuthorityNo(String taxAuthorityNo) {
            this.taxAuthorityNo = taxAuthorityNo;
            return this;
        }
        public String getTaxAuthorityNo() {
            return this.taxAuthorityNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setTonnage(String tonnage) {
            this.tonnage = tonnage;
            return this;
        }
        public String getTonnage() {
            return this.tonnage;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO extends TeaModel {
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
        public java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList> generalInvoiceDetailVOList;

        // 发票代码
        @NameInMap("invoiceCode")
        public String invoiceCode;

        // 发票号码
        @NameInMap("invoiceNo")
        public String invoiceNo;

        // 发票状态
        @NameInMap("invoiceStatus")
        public String invoiceStatus;

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

        // 购方银行账户
        @NameInMap("purchaserBankAccount")
        public String purchaserBankAccount;

        // 购方银行名称
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
        public java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList;

        // 销方地址
        @NameInMap("sellerAddress")
        public String sellerAddress;

        // 销方银行账户
        @NameInMap("sellerBankAccount")
        public String sellerBankAccount;

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

        // 代开发票标识 1-自开，2-代开
        @NameInMap("supplySign")
        public String supplySign;

        // 税额
        @NameInMap("taxAmount")
        public String taxAmount;

        @NameInMap("usedVehicleSaleDetailVOList")
        public java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList;

        @NameInMap("vehicleSaleDetailVOList")
        public java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList> vehicleSaleDetailVOList;

        // 发票查验状态
        @NameInMap("verifyStatus")
        public String verifyStatus;

        // 凭证code
        @NameInMap("voucherCode")
        public String voucherCode;

        // 生成凭证状态
        @NameInMap("voucherStatus")
        public String voucherStatus;

        public static UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO self = new UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setAccountPeriod(String accountPeriod) {
            this.accountPeriod = accountPeriod;
            return this;
        }
        public String getAccountPeriod() {
            return this.accountPeriod;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setAmountWithTax(String amountWithTax) {
            this.amountWithTax = amountWithTax;
            return this;
        }
        public String getAmountWithTax() {
            return this.amountWithTax;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setCheckCode(String checkCode) {
            this.checkCode = checkCode;
            return this;
        }
        public String getCheckCode() {
            return this.checkCode;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setDrewDate(String drewDate) {
            this.drewDate = drewDate;
            return this;
        }
        public String getDrewDate() {
            return this.drewDate;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setElectronicUrl(String electronicUrl) {
            this.electronicUrl = electronicUrl;
            return this;
        }
        public String getElectronicUrl() {
            return this.electronicUrl;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setFinanceType(String financeType) {
            this.financeType = financeType;
            return this;
        }
        public String getFinanceType() {
            return this.financeType;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setFundType(String fundType) {
            this.fundType = fundType;
            return this;
        }
        public String getFundType() {
            return this.fundType;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setGeneralInvoiceDetailVOList(java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList> generalInvoiceDetailVOList) {
            this.generalInvoiceDetailVOList = generalInvoiceDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList> getGeneralInvoiceDetailVOList() {
            return this.generalInvoiceDetailVOList;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setInvoiceStatus(String invoiceStatus) {
            this.invoiceStatus = invoiceStatus;
            return this;
        }
        public String getInvoiceStatus() {
            return this.invoiceStatus;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setMachineCode(String machineCode) {
            this.machineCode = machineCode;
            return this;
        }
        public String getMachineCode() {
            return this.machineCode;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setOilFlag(String oilFlag) {
            this.oilFlag = oilFlag;
            return this;
        }
        public String getOilFlag() {
            return this.oilFlag;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setPayee(String payee) {
            this.payee = payee;
            return this;
        }
        public String getPayee() {
            return this.payee;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setProcessInstCode(String processInstCode) {
            this.processInstCode = processInstCode;
            return this;
        }
        public String getProcessInstCode() {
            return this.processInstCode;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setProcessInstType(String processInstType) {
            this.processInstType = processInstType;
            return this;
        }
        public String getProcessInstType() {
            return this.processInstType;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setPurchaserAddress(String purchaserAddress) {
            this.purchaserAddress = purchaserAddress;
            return this;
        }
        public String getPurchaserAddress() {
            return this.purchaserAddress;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setPurchaserBankAccount(String purchaserBankAccount) {
            this.purchaserBankAccount = purchaserBankAccount;
            return this;
        }
        public String getPurchaserBankAccount() {
            return this.purchaserBankAccount;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setPurchaserBankNameAccount(String purchaserBankNameAccount) {
            this.purchaserBankNameAccount = purchaserBankNameAccount;
            return this;
        }
        public String getPurchaserBankNameAccount() {
            return this.purchaserBankNameAccount;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setPurchaserName(String purchaserName) {
            this.purchaserName = purchaserName;
            return this;
        }
        public String getPurchaserName() {
            return this.purchaserName;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setPurchaserTaxNo(String purchaserTaxNo) {
            this.purchaserTaxNo = purchaserTaxNo;
            return this;
        }
        public String getPurchaserTaxNo() {
            return this.purchaserTaxNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setPurchaserTel(String purchaserTel) {
            this.purchaserTel = purchaserTel;
            return this;
        }
        public String getPurchaserTel() {
            return this.purchaserTel;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setSecondHandCarInvoiceDetailList(java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList) {
            this.secondHandCarInvoiceDetailList = secondHandCarInvoiceDetailList;
            return this;
        }
        public java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList> getSecondHandCarInvoiceDetailList() {
            return this.secondHandCarInvoiceDetailList;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setSellerAddress(String sellerAddress) {
            this.sellerAddress = sellerAddress;
            return this;
        }
        public String getSellerAddress() {
            return this.sellerAddress;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setSellerBankAccount(String sellerBankAccount) {
            this.sellerBankAccount = sellerBankAccount;
            return this;
        }
        public String getSellerBankAccount() {
            return this.sellerBankAccount;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setSellerBankNameAccount(String sellerBankNameAccount) {
            this.sellerBankNameAccount = sellerBankNameAccount;
            return this;
        }
        public String getSellerBankNameAccount() {
            return this.sellerBankNameAccount;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setSellerName(String sellerName) {
            this.sellerName = sellerName;
            return this;
        }
        public String getSellerName() {
            return this.sellerName;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setSellerTaxNo(String sellerTaxNo) {
            this.sellerTaxNo = sellerTaxNo;
            return this;
        }
        public String getSellerTaxNo() {
            return this.sellerTaxNo;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setSellerTel(String sellerTel) {
            this.sellerTel = sellerTel;
            return this;
        }
        public String getSellerTel() {
            return this.sellerTel;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setSupplySign(String supplySign) {
            this.supplySign = supplySign;
            return this;
        }
        public String getSupplySign() {
            return this.supplySign;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setUsedVehicleSaleDetailVOList(java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList) {
            this.usedVehicleSaleDetailVOList = usedVehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList> getUsedVehicleSaleDetailVOList() {
            return this.usedVehicleSaleDetailVOList;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setVehicleSaleDetailVOList(java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList> vehicleSaleDetailVOList) {
            this.vehicleSaleDetailVOList = vehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList> getVehicleSaleDetailVOList() {
            return this.vehicleSaleDetailVOList;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setVerifyStatus(String verifyStatus) {
            this.verifyStatus = verifyStatus;
            return this;
        }
        public String getVerifyStatus() {
            return this.verifyStatus;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setVoucherCode(String voucherCode) {
            this.voucherCode = voucherCode;
            return this;
        }
        public String getVoucherCode() {
            return this.voucherCode;
        }

        public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO setVoucherStatus(String voucherStatus) {
            this.voucherStatus = voucherStatus;
            return this;
        }
        public String getVoucherStatus() {
            return this.voucherStatus;
        }

    }

    public static class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList extends TeaModel {
        // 金额
        @NameInMap("amount")
        public String amount;

        // 商品名称
        @NameInMap("goodsName")
        public String goodsName;

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

        // 优惠政策类型
        @NameInMap("taxPreType")
        public String taxPreType;

        // 税率
        @NameInMap("taxRate")
        public String taxRate;

        // 单位
        @NameInMap("unit")
        public String unit;

        // 单价
        @NameInMap("unitPrice")
        public String unitPrice;

        public static UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList self = new UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList setQuantity(String quantity) {
            this.quantity = quantity;
            return this;
        }
        public String getQuantity() {
            return this.quantity;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList setSpecification(String specification) {
            this.specification = specification;
            return this;
        }
        public String getSpecification() {
            return this.specification;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxPre(String taxPre) {
            this.taxPre = taxPre;
            return this;
        }
        public String getTaxPre() {
            return this.taxPre;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxPreType(String taxPreType) {
            this.taxPreType = taxPreType;
            return this;
        }
        public String getTaxPreType() {
            return this.taxPreType;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList setUnitPrice(String unitPrice) {
            this.unitPrice = unitPrice;
            return this;
        }
        public String getUnitPrice() {
            return this.unitPrice;
        }

    }

    public static class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList extends TeaModel {
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

        public static UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList self = new UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList setGoodsName(String goodsName) {
            this.goodsName = goodsName;
            return this;
        }
        public String getGoodsName() {
            return this.goodsName;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList setRevenueCode(String revenueCode) {
            this.revenueCode = revenueCode;
            return this;
        }
        public String getRevenueCode() {
            return this.revenueCode;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList setRowNo(String rowNo) {
            this.rowNo = rowNo;
            return this;
        }
        public String getRowNo() {
            return this.rowNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList extends TeaModel {
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

        public static UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList self = new UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnit(String auctionUnit) {
            this.auctionUnit = auctionUnit;
            return this;
        }
        public String getAuctionUnit() {
            return this.auctionUnit;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnitAddress(String auctionUnitAddress) {
            this.auctionUnitAddress = auctionUnitAddress;
            return this;
        }
        public String getAuctionUnitAddress() {
            return this.auctionUnitAddress;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnitBank(String auctionUnitBank) {
            this.auctionUnitBank = auctionUnitBank;
            return this;
        }
        public String getAuctionUnitBank() {
            return this.auctionUnitBank;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUnitTaxNo(String auctionUnitTaxNo) {
            this.auctionUnitTaxNo = auctionUnitTaxNo;
            return this;
        }
        public String getAuctionUnitTaxNo() {
            return this.auctionUnitTaxNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setAuctionUtilTel(String auctionUtilTel) {
            this.auctionUtilTel = auctionUtilTel;
            return this;
        }
        public String getAuctionUtilTel() {
            return this.auctionUtilTel;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setCarModel(String carModel) {
            this.carModel = carModel;
            return this;
        }
        public String getCarModel() {
            return this.carModel;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setCardNo(String cardNo) {
            this.cardNo = cardNo;
            return this;
        }
        public String getCardNo() {
            return this.cardNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setRegistration(String registration) {
            this.registration = registration;
            return this;
        }
        public String getRegistration() {
            return this.registration;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setTransferVehicle(String transferVehicle) {
            this.transferVehicle = transferVehicle;
            return this;
        }
        public String getTransferVehicle() {
            return this.transferVehicle;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarAddress(String usedCarAddress) {
            this.usedCarAddress = usedCarAddress;
            return this;
        }
        public String getUsedCarAddress() {
            return this.usedCarAddress;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarket(String usedCarMarket) {
            this.usedCarMarket = usedCarMarket;
            return this;
        }
        public String getUsedCarMarket() {
            return this.usedCarMarket;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarketBank(String usedCarMarketBank) {
            this.usedCarMarketBank = usedCarMarketBank;
            return this;
        }
        public String getUsedCarMarketBank() {
            return this.usedCarMarketBank;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarketPhone(String usedCarMarketPhone) {
            this.usedCarMarketPhone = usedCarMarketPhone;
            return this;
        }
        public String getUsedCarMarketPhone() {
            return this.usedCarMarketPhone;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setUsedCarMarketTaxNo(String usedCarMarketTaxNo) {
            this.usedCarMarketTaxNo = usedCarMarketTaxNo;
            return this;
        }
        public String getUsedCarMarketTaxNo() {
            return this.usedCarMarketTaxNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList extends TeaModel {
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

        // 商检单号
        @NameInMap("inspectionListNo")
        public String inspectionListNo;

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

        public static UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList self = new UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setBrand(String brand) {
            this.brand = brand;
            return this;
        }
        public String getBrand() {
            return this.brand;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setCertificateNo(String certificateNo) {
            this.certificateNo = certificateNo;
            return this;
        }
        public String getCertificateNo() {
            return this.certificateNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setEngineNo(String engineNo) {
            this.engineNo = engineNo;
            return this;
        }
        public String getEngineNo() {
            return this.engineNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setIdCardNo(String idCardNo) {
            this.idCardNo = idCardNo;
            return this;
        }
        public String getIdCardNo() {
            return this.idCardNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setImportCertificateNo(String importCertificateNo) {
            this.importCertificateNo = importCertificateNo;
            return this;
        }
        public String getImportCertificateNo() {
            return this.importCertificateNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setInspectionListNo(String inspectionListNo) {
            this.inspectionListNo = inspectionListNo;
            return this;
        }
        public String getInspectionListNo() {
            return this.inspectionListNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setMaxPassengers(String maxPassengers) {
            this.maxPassengers = maxPassengers;
            return this;
        }
        public String getMaxPassengers() {
            return this.maxPassengers;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setOriginPlace(String originPlace) {
            this.originPlace = originPlace;
            return this;
        }
        public String getOriginPlace() {
            return this.originPlace;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setPaymentVoucherNo(String paymentVoucherNo) {
            this.paymentVoucherNo = paymentVoucherNo;
            return this;
        }
        public String getPaymentVoucherNo() {
            return this.paymentVoucherNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setTaxAuthorityName(String taxAuthorityName) {
            this.taxAuthorityName = taxAuthorityName;
            return this;
        }
        public String getTaxAuthorityName() {
            return this.taxAuthorityName;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setTaxAuthorityNo(String taxAuthorityNo) {
            this.taxAuthorityNo = taxAuthorityNo;
            return this;
        }
        public String getTaxAuthorityNo() {
            return this.taxAuthorityNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setTaxRate(String taxRate) {
            this.taxRate = taxRate;
            return this;
        }
        public String getTaxRate() {
            return this.taxRate;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setTonnage(String tonnage) {
            this.tonnage = tonnage;
            return this;
        }
        public String getTonnage() {
            return this.tonnage;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setVehicleNo(String vehicleNo) {
            this.vehicleNo = vehicleNo;
            return this;
        }
        public String getVehicleNo() {
            return this.vehicleNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList setVehicleType(String vehicleType) {
            this.vehicleType = vehicleType;
            return this;
        }
        public String getVehicleType() {
            return this.vehicleType;
        }

    }

    public static class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO extends TeaModel {
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
        public java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList> generalInvoiceDetailVOList;

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

        // 购方银行账户
        @NameInMap("purchaserBankAccount")
        public String purchaserBankAccount;

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
        public java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList;

        // 销方地址
        @NameInMap("sellerAddress")
        public String sellerAddress;

        // 购方银行账户
        @NameInMap("sellerBankAccount")
        public String sellerBankAccount;

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
        public java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList;

        @NameInMap("vehicleSaleDetailVOList")
        public java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList> vehicleSaleDetailVOList;

        // 发票查验状态
        @NameInMap("verifyStatus")
        public String verifyStatus;

        // 凭证code
        @NameInMap("voucherCode")
        public String voucherCode;

        // 生成凭证状态
        @NameInMap("voucherStatus")
        public String voucherStatus;

        public static UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO self = new UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setAccountPeriod(String accountPeriod) {
            this.accountPeriod = accountPeriod;
            return this;
        }
        public String getAccountPeriod() {
            return this.accountPeriod;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setAmountWithTax(String amountWithTax) {
            this.amountWithTax = amountWithTax;
            return this;
        }
        public String getAmountWithTax() {
            return this.amountWithTax;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setCheckCode(String checkCode) {
            this.checkCode = checkCode;
            return this;
        }
        public String getCheckCode() {
            return this.checkCode;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setCheckTime(String checkTime) {
            this.checkTime = checkTime;
            return this;
        }
        public String getCheckTime() {
            return this.checkTime;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setDrewDate(String drewDate) {
            this.drewDate = drewDate;
            return this;
        }
        public String getDrewDate() {
            return this.drewDate;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setElectronicUrl(String electronicUrl) {
            this.electronicUrl = electronicUrl;
            return this;
        }
        public String getElectronicUrl() {
            return this.electronicUrl;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setFinanceType(String financeType) {
            this.financeType = financeType;
            return this;
        }
        public String getFinanceType() {
            return this.financeType;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setFundType(String fundType) {
            this.fundType = fundType;
            return this;
        }
        public String getFundType() {
            return this.fundType;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setGeneralInvoiceDetailVOList(java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList> generalInvoiceDetailVOList) {
            this.generalInvoiceDetailVOList = generalInvoiceDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList> getGeneralInvoiceDetailVOList() {
            return this.generalInvoiceDetailVOList;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setInvoiceType(String invoiceType) {
            this.invoiceType = invoiceType;
            return this;
        }
        public String getInvoiceType() {
            return this.invoiceType;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setMachineCode(String machineCode) {
            this.machineCode = machineCode;
            return this;
        }
        public String getMachineCode() {
            return this.machineCode;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setOilFlag(String oilFlag) {
            this.oilFlag = oilFlag;
            return this;
        }
        public String getOilFlag() {
            return this.oilFlag;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setPayee(String payee) {
            this.payee = payee;
            return this;
        }
        public String getPayee() {
            return this.payee;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setProcessInstCode(String processInstCode) {
            this.processInstCode = processInstCode;
            return this;
        }
        public String getProcessInstCode() {
            return this.processInstCode;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setProcessInstType(String processInstType) {
            this.processInstType = processInstType;
            return this;
        }
        public String getProcessInstType() {
            return this.processInstType;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setPurchaserAddress(String purchaserAddress) {
            this.purchaserAddress = purchaserAddress;
            return this;
        }
        public String getPurchaserAddress() {
            return this.purchaserAddress;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setPurchaserBankAccount(String purchaserBankAccount) {
            this.purchaserBankAccount = purchaserBankAccount;
            return this;
        }
        public String getPurchaserBankAccount() {
            return this.purchaserBankAccount;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setPurchaserBankNameAccount(String purchaserBankNameAccount) {
            this.purchaserBankNameAccount = purchaserBankNameAccount;
            return this;
        }
        public String getPurchaserBankNameAccount() {
            return this.purchaserBankNameAccount;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setPurchaserName(String purchaserName) {
            this.purchaserName = purchaserName;
            return this;
        }
        public String getPurchaserName() {
            return this.purchaserName;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setPurchaserTaxNo(String purchaserTaxNo) {
            this.purchaserTaxNo = purchaserTaxNo;
            return this;
        }
        public String getPurchaserTaxNo() {
            return this.purchaserTaxNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setPurchaserTel(String purchaserTel) {
            this.purchaserTel = purchaserTel;
            return this;
        }
        public String getPurchaserTel() {
            return this.purchaserTel;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setSecondHandCarInvoiceDetailList(java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList) {
            this.secondHandCarInvoiceDetailList = secondHandCarInvoiceDetailList;
            return this;
        }
        public java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList> getSecondHandCarInvoiceDetailList() {
            return this.secondHandCarInvoiceDetailList;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setSellerAddress(String sellerAddress) {
            this.sellerAddress = sellerAddress;
            return this;
        }
        public String getSellerAddress() {
            return this.sellerAddress;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setSellerBankAccount(String sellerBankAccount) {
            this.sellerBankAccount = sellerBankAccount;
            return this;
        }
        public String getSellerBankAccount() {
            return this.sellerBankAccount;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setSellerBankNameAccount(String sellerBankNameAccount) {
            this.sellerBankNameAccount = sellerBankNameAccount;
            return this;
        }
        public String getSellerBankNameAccount() {
            return this.sellerBankNameAccount;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setSellerName(String sellerName) {
            this.sellerName = sellerName;
            return this;
        }
        public String getSellerName() {
            return this.sellerName;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setSellerTaxNo(String sellerTaxNo) {
            this.sellerTaxNo = sellerTaxNo;
            return this;
        }
        public String getSellerTaxNo() {
            return this.sellerTaxNo;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setSellerTel(String sellerTel) {
            this.sellerTel = sellerTel;
            return this;
        }
        public String getSellerTel() {
            return this.sellerTel;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setSupplySign(String supplySign) {
            this.supplySign = supplySign;
            return this;
        }
        public String getSupplySign() {
            return this.supplySign;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setUsedVehicleSaleDetailVOList(java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList) {
            this.usedVehicleSaleDetailVOList = usedVehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList> getUsedVehicleSaleDetailVOList() {
            return this.usedVehicleSaleDetailVOList;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setVehicleSaleDetailVOList(java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList> vehicleSaleDetailVOList) {
            this.vehicleSaleDetailVOList = vehicleSaleDetailVOList;
            return this;
        }
        public java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList> getVehicleSaleDetailVOList() {
            return this.vehicleSaleDetailVOList;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setVerifyStatus(String verifyStatus) {
            this.verifyStatus = verifyStatus;
            return this;
        }
        public String getVerifyStatus() {
            return this.verifyStatus;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setVoucherCode(String voucherCode) {
            this.voucherCode = voucherCode;
            return this;
        }
        public String getVoucherCode() {
            return this.voucherCode;
        }

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setVoucherStatus(String voucherStatus) {
            this.voucherStatus = voucherStatus;
            return this;
        }
        public String getVoucherStatus() {
            return this.voucherStatus;
        }

    }

}
