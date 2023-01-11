// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAndReceiptRelatedRequest extends TeaModel {
    /**
     * <p>发票全票面信息</p>
     */
    @NameInMap("generalInvoiceVO")
    public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO generalInvoiceVO;

    /**
     * <p>发票代码</p>
     */
    @NameInMap("invoiceCode")
    public String invoiceCode;

    /**
     * <p>发票号码</p>
     */
    @NameInMap("invoiceNo")
    public String invoiceNo;

    /**
     * <p>操作员</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <p>钉钉审批单号</p>
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

    public static class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList extends TeaModel {
        /**
         * <p>金额</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>商品名称</p>
         */
        @NameInMap("goodsName")
        public String goodsName;

        /**
         * <p>数量</p>
         */
        @NameInMap("quantity")
        public String quantity;

        /**
         * <p>税收分类编码</p>
         */
        @NameInMap("revenueCode")
        public String revenueCode;

        /**
         * <p>行号</p>
         */
        @NameInMap("rowNo")
        public String rowNo;

        /**
         * <p>规格型号</p>
         */
        @NameInMap("specification")
        public String specification;

        /**
         * <p>税额</p>
         */
        @NameInMap("taxAmount")
        public String taxAmount;

        /**
         * <p>是否享受税收优惠：0-不享受，1-享受</p>
         */
        @NameInMap("taxPre")
        public String taxPre;

        /**
         * <p>优惠政策类型</p>
         */
        @NameInMap("taxPreType")
        public String taxPreType;

        /**
         * <p>税率</p>
         */
        @NameInMap("taxRate")
        public String taxRate;

        /**
         * <p>单位</p>
         */
        @NameInMap("unit")
        public String unit;

        /**
         * <p>单价</p>
         */
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
        /**
         * <p>金额</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>车牌号</p>
         */
        @NameInMap("cardNo")
        public String cardNo;

        /**
         * <p>通行日期止</p>
         */
        @NameInMap("endDate")
        public String endDate;

        /**
         * <p>商品名称</p>
         */
        @NameInMap("goodsName")
        public String goodsName;

        /**
         * <p>税收分类编码</p>
         */
        @NameInMap("revenueCode")
        public String revenueCode;

        /**
         * <p>行号</p>
         */
        @NameInMap("rowNo")
        public String rowNo;

        /**
         * <p>通行日期起</p>
         */
        @NameInMap("startDate")
        public String startDate;

        /**
         * <p>税额</p>
         */
        @NameInMap("taxAmount")
        public String taxAmount;

        /**
         * <p>税率</p>
         */
        @NameInMap("taxRate")
        public String taxRate;

        /**
         * <p>类型</p>
         */
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
        /**
         * <p>经营、拍卖单位</p>
         */
        @NameInMap("auctionUnit")
        public String auctionUnit;

        /**
         * <p>经营、拍卖单位地址</p>
         */
        @NameInMap("auctionUnitAddress")
        public String auctionUnitAddress;

        /**
         * <p>经营、拍卖单位银行</p>
         */
        @NameInMap("auctionUnitBank")
        public String auctionUnitBank;

        /**
         * <p>经营、拍卖单位税号</p>
         */
        @NameInMap("auctionUnitTaxNo")
        public String auctionUnitTaxNo;

        /**
         * <p>经营、拍卖单位电话</p>
         */
        @NameInMap("auctionUtilTel")
        public String auctionUtilTel;

        /**
         * <p>厂牌型号</p>
         */
        @NameInMap("carModel")
        public String carModel;

        /**
         * <p>车牌照号</p>
         */
        @NameInMap("cardNo")
        public String cardNo;

        /**
         * <p>登记证号</p>
         */
        @NameInMap("registration")
        public String registration;

        /**
         * <p>转入地车辆管理所名称</p>
         */
        @NameInMap("transferVehicle")
        public String transferVehicle;

        /**
         * <p>二手车市场地址</p>
         */
        @NameInMap("usedCarAddress")
        public String usedCarAddress;

        /**
         * <p>二手车市场</p>
         */
        @NameInMap("usedCarMarket")
        public String usedCarMarket;

        /**
         * <p>二手车市场开户银行、账号</p>
         */
        @NameInMap("usedCarMarketBank")
        public String usedCarMarketBank;

        /**
         * <p>二手车市场电话</p>
         */
        @NameInMap("usedCarMarketPhone")
        public String usedCarMarketPhone;

        /**
         * <p>二手车市场纳税人识别号</p>
         */
        @NameInMap("usedCarMarketTaxNo")
        public String usedCarMarketTaxNo;

        /**
         * <p>车架号/车辆识别号</p>
         */
        @NameInMap("vehicleNo")
        public String vehicleNo;

        /**
         * <p>车辆类型</p>
         */
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
        /**
         * <p>品牌</p>
         */
        @NameInMap("brand")
        public String brand;

        /**
         * <p>合格证号</p>
         */
        @NameInMap("certificateNo")
        public String certificateNo;

        /**
         * <p>发动机号</p>
         */
        @NameInMap("engineNo")
        public String engineNo;

        /**
         * <p>身份证号/组织机构代码</p>
         */
        @NameInMap("idCardNo")
        public String idCardNo;

        /**
         * <p>进口证书号</p>
         */
        @NameInMap("importCertificateNo")
        public String importCertificateNo;

        /**
         * <p>商检单号</p>
         */
        @NameInMap("inspectionListNo")
        public String inspectionListNo;

        /**
         * <p>限乘人数</p>
         */
        @NameInMap("maxPassengers")
        public String maxPassengers;

        /**
         * <p>产地</p>
         */
        @NameInMap("originPlace")
        public String originPlace;

        /**
         * <p>完税凭证号码</p>
         */
        @NameInMap("paymentVoucherNo")
        public String paymentVoucherNo;

        /**
         * <p>主管税务机关名称</p>
         */
        @NameInMap("taxAuthorityName")
        public String taxAuthorityName;

        /**
         * <p>主管税务机关代码</p>
         */
        @NameInMap("taxAuthorityNo")
        public String taxAuthorityNo;

        /**
         * <p>税率</p>
         */
        @NameInMap("taxRate")
        public String taxRate;

        /**
         * <p>吨位</p>
         */
        @NameInMap("tonnage")
        public String tonnage;

        /**
         * <p>车架号码</p>
         */
        @NameInMap("vehicleNo")
        public String vehicleNo;

        /**
         * <p>车辆类型</p>
         */
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
        /**
         * <p>账期时间</p>
         */
        @NameInMap("accountPeriod")
        public String accountPeriod;

        /**
         * <p>不含税金额</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>含税金额</p>
         */
        @NameInMap("amountWithTax")
        public String amountWithTax;

        /**
         * <p>校验码</p>
         */
        @NameInMap("checkCode")
        public String checkCode;

        /**
         * <p>查验时间</p>
         */
        @NameInMap("checkTime")
        public String checkTime;

        /**
         * <p>开票日期</p>
         */
        @NameInMap("drewDate")
        public String drewDate;

        /**
         * <p>电票版式文件下载地址</p>
         */
        @NameInMap("electronicUrl")
        public String electronicUrl;

        /**
         * <p>财务类型，INPUT-VAT(进项),OUTPUT_VAT(销项)</p>
         */
        @NameInMap("financeType")
        public String financeType;

        /**
         * <p>资金类型 ，RED（红票），（BLUE）蓝票</p>
         */
        @NameInMap("fundType")
        public String fundType;

        /**
         * <p>常规发票明细</p>
         */
        @NameInMap("generalInvoiceDetailVOList")
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList> generalInvoiceDetailVOList;

        /**
         * <p>发票代码</p>
         */
        @NameInMap("invoiceCode")
        public String invoiceCode;

        /**
         * <p>发票号码</p>
         */
        @NameInMap("invoiceNo")
        public String invoiceNo;

        /**
         * <p>发票状态</p>
         */
        @NameInMap("invoiceStatus")
        public String invoiceStatus;

        /**
         * <p>发票类型</p>
         */
        @NameInMap("invoiceType")
        public String invoiceType;

        /**
         * <p>机器码</p>
         */
        @NameInMap("machineCode")
        public String machineCode;

        /**
         * <p>成品油标识</p>
         */
        @NameInMap("oilFlag")
        public String oilFlag;

        /**
         * <p>收款人</p>
         */
        @NameInMap("payee")
        public String payee;

        /**
         * <p>审批单实例</p>
         */
        @NameInMap("processInstCode")
        public String processInstCode;

        /**
         * <p>审批单类型</p>
         */
        @NameInMap("processInstType")
        public String processInstType;

        /**
         * <p>购方地址</p>
         */
        @NameInMap("purchaserAddress")
        public String purchaserAddress;

        /**
         * <p>购方银行账户</p>
         * <br>
         */
        @NameInMap("purchaserBankAccount")
        public String purchaserBankAccount;

        @NameInMap("purchaserBankNameAccount")
        public String purchaserBankNameAccount;

        /**
         * <p>购方名称</p>
         */
        @NameInMap("purchaserName")
        public String purchaserName;

        /**
         * <p>购方税号</p>
         */
        @NameInMap("purchaserTaxNo")
        public String purchaserTaxNo;

        /**
         * <p>购方电话</p>
         */
        @NameInMap("purchaserTel")
        public String purchaserTel;

        /**
         * <p>备注</p>
         */
        @NameInMap("remark")
        public String remark;

        @NameInMap("secondHandCarInvoiceDetailList")
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList;

        /**
         * <p>销方地址</p>
         */
        @NameInMap("sellerAddress")
        public String sellerAddress;

        /**
         * <p>销方银行账户</p>
         */
        @NameInMap("sellerBankAccount")
        public String sellerBankAccount;

        @NameInMap("sellerBankNameAccount")
        public String sellerBankNameAccount;

        /**
         * <p>销方名称</p>
         */
        @NameInMap("sellerName")
        public String sellerName;

        /**
         * <p>销方税号</p>
         */
        @NameInMap("sellerTaxNo")
        public String sellerTaxNo;

        /**
         * <p>销方电话</p>
         */
        @NameInMap("sellerTel")
        public String sellerTel;

        /**
         * <p>代开发票标识 1-自开，2-代开</p>
         */
        @NameInMap("supplySign")
        public String supplySign;

        /**
         * <p>税额</p>
         */
        @NameInMap("taxAmount")
        public String taxAmount;

        @NameInMap("usedVehicleSaleDetailVOList")
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList;

        @NameInMap("vehicleSaleDetailVOList")
        public java.util.List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList> vehicleSaleDetailVOList;

        /**
         * <p>发票查验状态</p>
         */
        @NameInMap("verifyStatus")
        public String verifyStatus;

        /**
         * <p>凭证code</p>
         */
        @NameInMap("voucherCode")
        public String voucherCode;

        /**
         * <p>生成凭证状态</p>
         */
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

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setFinanceType(String financeType) {
            this.financeType = financeType;
            return this;
        }
        public String getFinanceType() {
            return this.financeType;
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

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setPayee(String payee) {
            this.payee = payee;
            return this;
        }
        public String getPayee() {
            return this.payee;
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

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
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

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setSupplySign(String supplySign) {
            this.supplySign = supplySign;
            return this;
        }
        public String getSupplySign() {
            return this.supplySign;
        }

        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO setTaxAmount(String taxAmount) {
            this.taxAmount = taxAmount;
            return this;
        }
        public String getTaxAmount() {
            return this.taxAmount;
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
