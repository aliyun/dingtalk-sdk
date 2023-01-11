// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceAbandonStatusRequest extends TeaModel {
    /**
     * <p>发票全票面信息（蓝票）</p>
     */
    @NameInMap("blueGeneralInvoiceVO")
    public UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO blueGeneralInvoiceVO;

    /**
     * <p>发票编码（蓝票）</p>
     */
    @NameInMap("blueInvoiceCode")
    public String blueInvoiceCode;

    /**
     * <p>发票号码（蓝票）</p>
     */
    @NameInMap("blueInvoiceNo")
    public String blueInvoiceNo;

    /**
     * <p>状态-红冲、废弃</p>
     */
    @NameInMap("blueInvoiceStatus")
    public String blueInvoiceStatus;

    /**
     * <p>操作员</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <p>发票全票面信息（红票）</p>
     */
    @NameInMap("redGeneralInvoiceVO")
    public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO redGeneralInvoiceVO;

    /**
     * <p>红字发票code</p>
     */
    @NameInMap("redInvoiceCode")
    public String redInvoiceCode;

    /**
     * <p>红字发票编码</p>
     */
    @NameInMap("redInvoiceNo")
    public String redInvoiceNo;

    /**
     * <p>红字发票状态</p>
     */
    @NameInMap("redInvoiceStatus")
    public String redInvoiceStatus;

    /**
     * <p>目标发票</p>
     */
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
        public java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList> generalInvoiceDetailVOList;

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
         */
        @NameInMap("purchaserBankAccount")
        public String purchaserBankAccount;

        /**
         * <p>购方银行名称</p>
         */
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
        public java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList;

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

        /**
         * <p>销方银行</p>
         */
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
        public java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList;

        @NameInMap("vehicleSaleDetailVOList")
        public java.util.List<UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList> vehicleSaleDetailVOList;

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
        public java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList> generalInvoiceDetailVOList;

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
         */
        @NameInMap("purchaserBankAccount")
        public String purchaserBankAccount;

        /**
         * <p>购方银行</p>
         */
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
        public java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList> secondHandCarInvoiceDetailList;

        /**
         * <p>销方地址</p>
         */
        @NameInMap("sellerAddress")
        public String sellerAddress;

        /**
         * <p>购方银行账户</p>
         */
        @NameInMap("sellerBankAccount")
        public String sellerBankAccount;

        /**
         * <p>销方银行</p>
         */
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
        public java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList> usedVehicleSaleDetailVOList;

        @NameInMap("vehicleSaleDetailVOList")
        public java.util.List<UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList> vehicleSaleDetailVOList;

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

        public UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO setInvoiceStatus(String invoiceStatus) {
            this.invoiceStatus = invoiceStatus;
            return this;
        }
        public String getInvoiceStatus() {
            return this.invoiceStatus;
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
