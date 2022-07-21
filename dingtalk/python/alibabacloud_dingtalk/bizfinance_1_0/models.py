# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class BatchAddInvoiceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        good_name: str = None,
        quantity: str = None,
        revenue_code: str = None,
        row_no: str = None,
        specification: str = None,
        tax_amount: str = None,
        tax_pre: str = None,
        tax_pre_type: str = None,
        tax_rate: str = None,
        unit: str = None,
        unit_price: str = None,
    ):
        # 金额
        self.amount = amount
        # 商品名称
        self.good_name = good_name
        # 数量
        self.quantity = quantity
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 规格型号
        self.specification = specification
        # 税额
        self.tax_amount = tax_amount
        # 是否享受税收优惠：0-不享受，1-享受
        self.tax_pre = tax_pre
        # 优惠政策类型
        self.tax_pre_type = tax_pre_type
        # 税率
        self.tax_rate = tax_rate
        # 单位
        self.unit = unit
        # 单价
        self.unit_price = unit_price

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.good_name is not None:
            result['goodName'] = self.good_name
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.specification is not None:
            result['specification'] = self.specification
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_pre is not None:
            result['taxPre'] = self.tax_pre
        if self.tax_pre_type is not None:
            result['taxPreType'] = self.tax_pre_type
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.unit is not None:
            result['unit'] = self.unit
        if self.unit_price is not None:
            result['unitPrice'] = self.unit_price
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('goodName') is not None:
            self.good_name = m.get('goodName')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxPre') is not None:
            self.tax_pre = m.get('taxPre')
        if m.get('taxPreType') is not None:
            self.tax_pre_type = m.get('taxPreType')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('unitPrice') is not None:
            self.unit_price = m.get('unitPrice')
        return self


class BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        card_no: str = None,
        end_date: str = None,
        goods_name: str = None,
        revenue_code: str = None,
        row_no: str = None,
        start_date: str = None,
        tax_amount: str = None,
        tax_rate: str = None,
        vehicle_type: str = None,
    ):
        # 金额
        self.amount = amount
        # 车牌号
        self.card_no = card_no
        # 通行日期止
        self.end_date = end_date
        # 商品名称
        self.goods_name = goods_name
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 通行日期起
        self.start_date = start_date
        # 税额
        self.tax_amount = tax_amount
        # 税率
        self.tax_rate = tax_rate
        # 类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        auction_unit: str = None,
        auction_unit_address: str = None,
        auction_unit_bank: str = None,
        auction_unit_tax_no: str = None,
        auction_util_tel: str = None,
        car_model: str = None,
        card_no: str = None,
        registration: str = None,
        transfer_vehicle: str = None,
        used_car_address: str = None,
        used_car_market: str = None,
        used_car_market_bank: str = None,
        used_car_market_phone: str = None,
        used_car_market_tax_no: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 经营、拍卖单位
        self.auction_unit = auction_unit
        # 经营、拍卖单位地址
        self.auction_unit_address = auction_unit_address
        # 经营、拍卖单位银行
        self.auction_unit_bank = auction_unit_bank
        # 经营、拍卖单位税号
        self.auction_unit_tax_no = auction_unit_tax_no
        # 经营、拍卖单位电话
        self.auction_util_tel = auction_util_tel
        # 厂牌型号
        self.car_model = car_model
        # 车牌照号
        self.card_no = card_no
        # 登记证号
        self.registration = registration
        # 转入地车辆管理所名称
        self.transfer_vehicle = transfer_vehicle
        # 二手车市场地址
        self.used_car_address = used_car_address
        # 二手车市场
        self.used_car_market = used_car_market
        # 二手车市场开户银行、账号
        self.used_car_market_bank = used_car_market_bank
        # 二手车市场电话
        self.used_car_market_phone = used_car_market_phone
        # 二手车市场纳税人识别号
        self.used_car_market_tax_no = used_car_market_tax_no
        # 车架号/车辆识别号
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auction_unit is not None:
            result['auctionUnit'] = self.auction_unit
        if self.auction_unit_address is not None:
            result['auctionUnitAddress'] = self.auction_unit_address
        if self.auction_unit_bank is not None:
            result['auctionUnitBank'] = self.auction_unit_bank
        if self.auction_unit_tax_no is not None:
            result['auctionUnitTaxNo'] = self.auction_unit_tax_no
        if self.auction_util_tel is not None:
            result['auctionUtilTel'] = self.auction_util_tel
        if self.car_model is not None:
            result['carModel'] = self.car_model
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.registration is not None:
            result['registration'] = self.registration
        if self.transfer_vehicle is not None:
            result['transferVehicle'] = self.transfer_vehicle
        if self.used_car_address is not None:
            result['usedCarAddress'] = self.used_car_address
        if self.used_car_market is not None:
            result['usedCarMarket'] = self.used_car_market
        if self.used_car_market_bank is not None:
            result['usedCarMarketBank'] = self.used_car_market_bank
        if self.used_car_market_phone is not None:
            result['usedCarMarketPhone'] = self.used_car_market_phone
        if self.used_car_market_tax_no is not None:
            result['usedCarMarketTaxNo'] = self.used_car_market_tax_no
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('auctionUnit') is not None:
            self.auction_unit = m.get('auctionUnit')
        if m.get('auctionUnitAddress') is not None:
            self.auction_unit_address = m.get('auctionUnitAddress')
        if m.get('auctionUnitBank') is not None:
            self.auction_unit_bank = m.get('auctionUnitBank')
        if m.get('auctionUnitTaxNo') is not None:
            self.auction_unit_tax_no = m.get('auctionUnitTaxNo')
        if m.get('auctionUtilTel') is not None:
            self.auction_util_tel = m.get('auctionUtilTel')
        if m.get('carModel') is not None:
            self.car_model = m.get('carModel')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('registration') is not None:
            self.registration = m.get('registration')
        if m.get('transferVehicle') is not None:
            self.transfer_vehicle = m.get('transferVehicle')
        if m.get('usedCarAddress') is not None:
            self.used_car_address = m.get('usedCarAddress')
        if m.get('usedCarMarket') is not None:
            self.used_car_market = m.get('usedCarMarket')
        if m.get('usedCarMarketBank') is not None:
            self.used_car_market_bank = m.get('usedCarMarketBank')
        if m.get('usedCarMarketPhone') is not None:
            self.used_car_market_phone = m.get('usedCarMarketPhone')
        if m.get('usedCarMarketTaxNo') is not None:
            self.used_car_market_tax_no = m.get('usedCarMarketTaxNo')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        brand: str = None,
        certificate_no: str = None,
        engine_no: str = None,
        id_card_no: str = None,
        import_certificate_no: str = None,
        inspection_list_no: str = None,
        max_passengers: str = None,
        origin_place: str = None,
        payment_voucher_no: str = None,
        tax_authority_name: str = None,
        tax_authority_no: str = None,
        tax_rate: str = None,
        tonnage: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 品牌
        self.brand = brand
        # 合格证号
        self.certificate_no = certificate_no
        # 发动机号
        self.engine_no = engine_no
        # 身份证号/组织机构代码
        self.id_card_no = id_card_no
        # 进口证书号
        self.import_certificate_no = import_certificate_no
        # 商检单号
        self.inspection_list_no = inspection_list_no
        # 限乘人数
        self.max_passengers = max_passengers
        # 产地
        self.origin_place = origin_place
        # 完税凭证号码
        self.payment_voucher_no = payment_voucher_no
        # 主管税务机关名称
        self.tax_authority_name = tax_authority_name
        # 主管税务机关代码
        self.tax_authority_no = tax_authority_no
        # 税率
        self.tax_rate = tax_rate
        # 吨位
        self.tonnage = tonnage
        # 车架号码
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.brand is not None:
            result['brand'] = self.brand
        if self.certificate_no is not None:
            result['certificateNo'] = self.certificate_no
        if self.engine_no is not None:
            result['engineNo'] = self.engine_no
        if self.id_card_no is not None:
            result['idCardNo'] = self.id_card_no
        if self.import_certificate_no is not None:
            result['importCertificateNo'] = self.import_certificate_no
        if self.inspection_list_no is not None:
            result['inspectionListNo'] = self.inspection_list_no
        if self.max_passengers is not None:
            result['maxPassengers'] = self.max_passengers
        if self.origin_place is not None:
            result['originPlace'] = self.origin_place
        if self.payment_voucher_no is not None:
            result['paymentVoucherNo'] = self.payment_voucher_no
        if self.tax_authority_name is not None:
            result['taxAuthorityName'] = self.tax_authority_name
        if self.tax_authority_no is not None:
            result['taxAuthorityNo'] = self.tax_authority_no
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.tonnage is not None:
            result['tonnage'] = self.tonnage
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('brand') is not None:
            self.brand = m.get('brand')
        if m.get('certificateNo') is not None:
            self.certificate_no = m.get('certificateNo')
        if m.get('engineNo') is not None:
            self.engine_no = m.get('engineNo')
        if m.get('idCardNo') is not None:
            self.id_card_no = m.get('idCardNo')
        if m.get('importCertificateNo') is not None:
            self.import_certificate_no = m.get('importCertificateNo')
        if m.get('inspectionListNo') is not None:
            self.inspection_list_no = m.get('inspectionListNo')
        if m.get('maxPassengers') is not None:
            self.max_passengers = m.get('maxPassengers')
        if m.get('originPlace') is not None:
            self.origin_place = m.get('originPlace')
        if m.get('paymentVoucherNo') is not None:
            self.payment_voucher_no = m.get('paymentVoucherNo')
        if m.get('taxAuthorityName') is not None:
            self.tax_authority_name = m.get('taxAuthorityName')
        if m.get('taxAuthorityNo') is not None:
            self.tax_authority_no = m.get('taxAuthorityNo')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('tonnage') is not None:
            self.tonnage = m.get('tonnage')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class BatchAddInvoiceRequestGeneralInvoiceVOList(TeaModel):
    def __init__(
        self,
        account_period: str = None,
        amount: str = None,
        amount_with_tax: str = None,
        check_code: str = None,
        check_time: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        finance_type: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList] = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_type: str = None,
        machine_code: str = None,
        oil_flag: str = None,
        payee: str = None,
        process_inst_code: str = None,
        process_inst_type: str = None,
        purchaser_address: str = None,
        purchaser_bank_account: str = None,
        purchaser_bank_name_account: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
        remark: str = None,
        second_hand_car_invoice_detail_list: List[BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList] = None,
        seller_address: str = None,
        seller_bank_account: str = None,
        seller_bank_name_account: str = None,
        seller_name: str = None,
        seller_tax_no: str = None,
        seller_tel: str = None,
        status: str = None,
        supply_sign: str = None,
        tax_amount: str = None,
        used_vehicle_sale_detail_volist: List[BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        # 账期时间
        self.account_period = account_period
        # 不含税金额
        self.amount = amount
        # 含税金额
        self.amount_with_tax = amount_with_tax
        # 校验码
        self.check_code = check_code
        # 查验时间
        self.check_time = check_time
        # 开票日期
        self.drew_date = drew_date
        # 电票版式文件下载地址
        self.electronic_url = electronic_url
        # 财务类型，INPUT-VAT(进项),OUTPUT_VAT(销项)
        self.finance_type = finance_type
        # 资金类型 ，RED（红票），（BLUE）蓝票
        self.fund_type = fund_type
        # 常规发票明细
        self.general_invoice_detail_volist = general_invoice_detail_volist
        # 发票代码
        self.invoice_code = invoice_code
        # 发票号码
        self.invoice_no = invoice_no
        # 发票类型
        self.invoice_type = invoice_type
        # 机器码
        self.machine_code = machine_code
        # 成品油标识
        self.oil_flag = oil_flag
        # 收款人
        self.payee = payee
        # 审批单实例
        self.process_inst_code = process_inst_code
        # 审批单类型
        self.process_inst_type = process_inst_type
        # 购方地址
        self.purchaser_address = purchaser_address
        # 购方银行账户
        self.purchaser_bank_account = purchaser_bank_account
        # 购方银行名称
        self.purchaser_bank_name_account = purchaser_bank_name_account
        # 购方名称
        self.purchaser_name = purchaser_name
        # 购方税号
        self.purchaser_tax_no = purchaser_tax_no
        # 购方电话
        self.purchaser_tel = purchaser_tel
        # 备注
        self.remark = remark
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        # 销方地址
        self.seller_address = seller_address
        # 销方银行账户
        self.seller_bank_account = seller_bank_account
        # 销方银行名称
        self.seller_bank_name_account = seller_bank_name_account
        # 销方名称
        self.seller_name = seller_name
        # 销方税号
        self.seller_tax_no = seller_tax_no
        # 销方电话
        self.seller_tel = seller_tel
        # 发票状态
        self.status = status
        # 代开发票标识 1-自开，2-代开
        self.supply_sign = supply_sign
        # 税额
        self.tax_amount = tax_amount
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        # 发票查验状态
        self.verify_status = verify_status
        # 凭证code
        self.voucher_code = voucher_code
        # 生成凭证状态
        self.voucher_status = voucher_status

    def validate(self):
        if self.general_invoice_detail_volist:
            for k in self.general_invoice_detail_volist:
                if k:
                    k.validate()
        if self.second_hand_car_invoice_detail_list:
            for k in self.second_hand_car_invoice_detail_list:
                if k:
                    k.validate()
        if self.used_vehicle_sale_detail_volist:
            for k in self.used_vehicle_sale_detail_volist:
                if k:
                    k.validate()
        if self.vehicle_sale_detail_volist:
            for k in self.vehicle_sale_detail_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_period is not None:
            result['accountPeriod'] = self.account_period
        if self.amount is not None:
            result['amount'] = self.amount
        if self.amount_with_tax is not None:
            result['amountWithTax'] = self.amount_with_tax
        if self.check_code is not None:
            result['checkCode'] = self.check_code
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.drew_date is not None:
            result['drewDate'] = self.drew_date
        if self.electronic_url is not None:
            result['electronicUrl'] = self.electronic_url
        if self.finance_type is not None:
            result['financeType'] = self.finance_type
        if self.fund_type is not None:
            result['fundType'] = self.fund_type
        result['generalInvoiceDetailVOList'] = []
        if self.general_invoice_detail_volist is not None:
            for k in self.general_invoice_detail_volist:
                result['generalInvoiceDetailVOList'].append(k.to_map() if k else None)
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.machine_code is not None:
            result['machineCode'] = self.machine_code
        if self.oil_flag is not None:
            result['oilFlag'] = self.oil_flag
        if self.payee is not None:
            result['payee'] = self.payee
        if self.process_inst_code is not None:
            result['processInstCode'] = self.process_inst_code
        if self.process_inst_type is not None:
            result['processInstType'] = self.process_inst_type
        if self.purchaser_address is not None:
            result['purchaserAddress'] = self.purchaser_address
        if self.purchaser_bank_account is not None:
            result['purchaserBankAccount'] = self.purchaser_bank_account
        if self.purchaser_bank_name_account is not None:
            result['purchaserBankNameAccount'] = self.purchaser_bank_name_account
        if self.purchaser_name is not None:
            result['purchaserName'] = self.purchaser_name
        if self.purchaser_tax_no is not None:
            result['purchaserTaxNo'] = self.purchaser_tax_no
        if self.purchaser_tel is not None:
            result['purchaserTel'] = self.purchaser_tel
        if self.remark is not None:
            result['remark'] = self.remark
        result['secondHandCarInvoiceDetailList'] = []
        if self.second_hand_car_invoice_detail_list is not None:
            for k in self.second_hand_car_invoice_detail_list:
                result['secondHandCarInvoiceDetailList'].append(k.to_map() if k else None)
        if self.seller_address is not None:
            result['sellerAddress'] = self.seller_address
        if self.seller_bank_account is not None:
            result['sellerBankAccount'] = self.seller_bank_account
        if self.seller_bank_name_account is not None:
            result['sellerBankNameAccount'] = self.seller_bank_name_account
        if self.seller_name is not None:
            result['sellerName'] = self.seller_name
        if self.seller_tax_no is not None:
            result['sellerTaxNo'] = self.seller_tax_no
        if self.seller_tel is not None:
            result['sellerTel'] = self.seller_tel
        if self.status is not None:
            result['status'] = self.status
        if self.supply_sign is not None:
            result['supplySign'] = self.supply_sign
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        result['usedVehicleSaleDetailVOList'] = []
        if self.used_vehicle_sale_detail_volist is not None:
            for k in self.used_vehicle_sale_detail_volist:
                result['usedVehicleSaleDetailVOList'].append(k.to_map() if k else None)
        result['vehicleSaleDetailVOList'] = []
        if self.vehicle_sale_detail_volist is not None:
            for k in self.vehicle_sale_detail_volist:
                result['vehicleSaleDetailVOList'].append(k.to_map() if k else None)
        if self.verify_status is not None:
            result['verifyStatus'] = self.verify_status
        if self.voucher_code is not None:
            result['voucherCode'] = self.voucher_code
        if self.voucher_status is not None:
            result['voucherStatus'] = self.voucher_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountPeriod') is not None:
            self.account_period = m.get('accountPeriod')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('amountWithTax') is not None:
            self.amount_with_tax = m.get('amountWithTax')
        if m.get('checkCode') is not None:
            self.check_code = m.get('checkCode')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('drewDate') is not None:
            self.drew_date = m.get('drewDate')
        if m.get('electronicUrl') is not None:
            self.electronic_url = m.get('electronicUrl')
        if m.get('financeType') is not None:
            self.finance_type = m.get('financeType')
        if m.get('fundType') is not None:
            self.fund_type = m.get('fundType')
        self.general_invoice_detail_volist = []
        if m.get('generalInvoiceDetailVOList') is not None:
            for k in m.get('generalInvoiceDetailVOList'):
                temp_model = BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList()
                self.general_invoice_detail_volist.append(temp_model.from_map(k))
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('machineCode') is not None:
            self.machine_code = m.get('machineCode')
        if m.get('oilFlag') is not None:
            self.oil_flag = m.get('oilFlag')
        if m.get('payee') is not None:
            self.payee = m.get('payee')
        if m.get('processInstCode') is not None:
            self.process_inst_code = m.get('processInstCode')
        if m.get('processInstType') is not None:
            self.process_inst_type = m.get('processInstType')
        if m.get('purchaserAddress') is not None:
            self.purchaser_address = m.get('purchaserAddress')
        if m.get('purchaserBankAccount') is not None:
            self.purchaser_bank_account = m.get('purchaserBankAccount')
        if m.get('purchaserBankNameAccount') is not None:
            self.purchaser_bank_name_account = m.get('purchaserBankNameAccount')
        if m.get('purchaserName') is not None:
            self.purchaser_name = m.get('purchaserName')
        if m.get('purchaserTaxNo') is not None:
            self.purchaser_tax_no = m.get('purchaserTaxNo')
        if m.get('purchaserTel') is not None:
            self.purchaser_tel = m.get('purchaserTel')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        self.second_hand_car_invoice_detail_list = []
        if m.get('secondHandCarInvoiceDetailList') is not None:
            for k in m.get('secondHandCarInvoiceDetailList'):
                temp_model = BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList()
                self.second_hand_car_invoice_detail_list.append(temp_model.from_map(k))
        if m.get('sellerAddress') is not None:
            self.seller_address = m.get('sellerAddress')
        if m.get('sellerBankAccount') is not None:
            self.seller_bank_account = m.get('sellerBankAccount')
        if m.get('sellerBankNameAccount') is not None:
            self.seller_bank_name_account = m.get('sellerBankNameAccount')
        if m.get('sellerName') is not None:
            self.seller_name = m.get('sellerName')
        if m.get('sellerTaxNo') is not None:
            self.seller_tax_no = m.get('sellerTaxNo')
        if m.get('sellerTel') is not None:
            self.seller_tel = m.get('sellerTel')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('supplySign') is not None:
            self.supply_sign = m.get('supplySign')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        self.used_vehicle_sale_detail_volist = []
        if m.get('usedVehicleSaleDetailVOList') is not None:
            for k in m.get('usedVehicleSaleDetailVOList'):
                temp_model = BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList()
                self.used_vehicle_sale_detail_volist.append(temp_model.from_map(k))
        self.vehicle_sale_detail_volist = []
        if m.get('vehicleSaleDetailVOList') is not None:
            for k in m.get('vehicleSaleDetailVOList'):
                temp_model = BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList()
                self.vehicle_sale_detail_volist.append(temp_model.from_map(k))
        if m.get('verifyStatus') is not None:
            self.verify_status = m.get('verifyStatus')
        if m.get('voucherCode') is not None:
            self.voucher_code = m.get('voucherCode')
        if m.get('voucherStatus') is not None:
            self.voucher_status = m.get('voucherStatus')
        return self


class BatchAddInvoiceRequest(TeaModel):
    def __init__(
        self,
        general_invoice_volist: List[BatchAddInvoiceRequestGeneralInvoiceVOList] = None,
        operator: str = None,
    ):
        # 发票模型
        self.general_invoice_volist = general_invoice_volist
        # 操作员
        self.operator = operator

    def validate(self):
        if self.general_invoice_volist:
            for k in self.general_invoice_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['generalInvoiceVOList'] = []
        if self.general_invoice_volist is not None:
            for k in self.general_invoice_volist:
                result['generalInvoiceVOList'].append(k.to_map() if k else None)
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.general_invoice_volist = []
        if m.get('generalInvoiceVOList') is not None:
            for k in m.get('generalInvoiceVOList'):
                temp_model = BatchAddInvoiceRequestGeneralInvoiceVOList()
                self.general_invoice_volist.append(temp_model.from_map(k))
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class BatchAddInvoiceResponseBodyResult(TeaModel):
    def __init__(
        self,
        error_key: str = None,
        error_msg: str = None,
    ):
        # 错误数据的key
        self.error_key = error_key
        # 错误信息
        self.error_msg = error_msg

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_key is not None:
            result['errorKey'] = self.error_key
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorKey') is not None:
            self.error_key = m.get('errorKey')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        return self


class BatchAddInvoiceResponseBody(TeaModel):
    def __init__(
        self,
        result: List[BatchAddInvoiceResponseBodyResult] = None,
    ):
        # 错误信息
        self.result = result

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = BatchAddInvoiceResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class BatchAddInvoiceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchAddInvoiceResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = BatchAddInvoiceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CheckVoucherStatusHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CheckVoucherStatusRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        finance_type: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        page_number: int = None,
        page_size: int = None,
        start_time: int = None,
        tax_no: str = None,
        verify_status: str = None,
    ):
        # 结束时间
        self.end_time = end_time
        # 进项发票/销项发票
        self.finance_type = finance_type
        # 发票编码
        self.invoice_code = invoice_code
        # 发票号码
        self.invoice_no = invoice_no
        # 页号
        self.page_number = page_number
        # 当前页大小
        self.page_size = page_size
        # 开始时间
        self.start_time = start_time
        # 税号
        self.tax_no = tax_no
        # 发票认证状态
        self.verify_status = verify_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.finance_type is not None:
            result['financeType'] = self.finance_type
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        if self.verify_status is not None:
            result['verifyStatus'] = self.verify_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('financeType') is not None:
            self.finance_type = m.get('financeType')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        if m.get('verifyStatus') is not None:
            self.verify_status = m.get('verifyStatus')
        return self


class CheckVoucherStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CheckVoucherStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CheckVoucherStatusResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = CheckVoucherStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateCustomerHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateCustomerRequest(TeaModel):
    def __init__(
        self,
        creator: str = None,
        description: str = None,
        name: str = None,
        purchaser_account: str = None,
        purchaser_address: str = None,
        purchaser_bank_name: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
    ):
        # 创建人userId
        self.creator = creator
        # 客户描述
        self.description = description
        # 客户名字
        self.name = name
        # 购方账户
        self.purchaser_account = purchaser_account
        # 购房地址
        self.purchaser_address = purchaser_address
        # 购方银行
        self.purchaser_bank_name = purchaser_bank_name
        # 购方名字
        self.purchaser_name = purchaser_name
        # 购方税号
        self.purchaser_tax_no = purchaser_tax_no
        # 购方电话
        self.purchaser_tel = purchaser_tel

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator is not None:
            result['creator'] = self.creator
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.purchaser_account is not None:
            result['purchaserAccount'] = self.purchaser_account
        if self.purchaser_address is not None:
            result['purchaserAddress'] = self.purchaser_address
        if self.purchaser_bank_name is not None:
            result['purchaserBankName'] = self.purchaser_bank_name
        if self.purchaser_name is not None:
            result['purchaserName'] = self.purchaser_name
        if self.purchaser_tax_no is not None:
            result['purchaserTaxNo'] = self.purchaser_tax_no
        if self.purchaser_tel is not None:
            result['purchaserTel'] = self.purchaser_tel
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('purchaserAccount') is not None:
            self.purchaser_account = m.get('purchaserAccount')
        if m.get('purchaserAddress') is not None:
            self.purchaser_address = m.get('purchaserAddress')
        if m.get('purchaserBankName') is not None:
            self.purchaser_bank_name = m.get('purchaserBankName')
        if m.get('purchaserName') is not None:
            self.purchaser_name = m.get('purchaserName')
        if m.get('purchaserTaxNo') is not None:
            self.purchaser_tax_no = m.get('purchaserTaxNo')
        if m.get('purchaserTel') is not None:
            self.purchaser_tel = m.get('purchaserTel')
        return self


class CreateCustomerResponseBody(TeaModel):
    def __init__(
        self,
        customer_code: str = None,
    ):
        # 客户CODE
        self.customer_code = customer_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.customer_code is not None:
            result['customerCode'] = self.customer_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customerCode') is not None:
            self.customer_code = m.get('customerCode')
        return self


class CreateCustomerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateCustomerResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = CreateCustomerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateReceiptHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateReceiptRequestReceipts(TeaModel):
    def __init__(
        self,
        amount: str = None,
        category_code: str = None,
        code: str = None,
        create_time: int = None,
        create_user_id: str = None,
        customer_code: str = None,
        enterprise_acount_code: str = None,
        occur_date: int = None,
        principal_id: str = None,
        project_code: str = None,
        receipt_type: int = None,
        remark: str = None,
        supplier_code: str = None,
        title: str = None,
    ):
        # 单据金额
        self.amount = amount
        # 关联收支类别code
        self.category_code = category_code
        # 单据唯一编号
        self.code = code
        # 单据创建时间，默认当前时间
        self.create_time = create_time
        # 创建人工号
        self.create_user_id = create_user_id
        # 关联客户code
        self.customer_code = customer_code
        # 关联企业账户code
        self.enterprise_acount_code = enterprise_acount_code
        # 业务发生时间，默认当前时间
        self.occur_date = occur_date
        # 负责人工号，传空代表不修改
        self.principal_id = principal_id
        # 关联项目code
        self.project_code = project_code
        # 单据类型：1付款单，2收款单
        self.receipt_type = receipt_type
        # 备注
        self.remark = remark
        # 关联供应商code
        self.supplier_code = supplier_code
        # 单据标题，不传由系统默认生成
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.category_code is not None:
            result['categoryCode'] = self.category_code
        if self.code is not None:
            result['code'] = self.code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.create_user_id is not None:
            result['createUserId'] = self.create_user_id
        if self.customer_code is not None:
            result['customerCode'] = self.customer_code
        if self.enterprise_acount_code is not None:
            result['enterpriseAcountCode'] = self.enterprise_acount_code
        if self.occur_date is not None:
            result['occurDate'] = self.occur_date
        if self.principal_id is not None:
            result['principalId'] = self.principal_id
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.receipt_type is not None:
            result['receiptType'] = self.receipt_type
        if self.remark is not None:
            result['remark'] = self.remark
        if self.supplier_code is not None:
            result['supplierCode'] = self.supplier_code
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('categoryCode') is not None:
            self.category_code = m.get('categoryCode')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('createUserId') is not None:
            self.create_user_id = m.get('createUserId')
        if m.get('customerCode') is not None:
            self.customer_code = m.get('customerCode')
        if m.get('enterpriseAcountCode') is not None:
            self.enterprise_acount_code = m.get('enterpriseAcountCode')
        if m.get('occurDate') is not None:
            self.occur_date = m.get('occurDate')
        if m.get('principalId') is not None:
            self.principal_id = m.get('principalId')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('receiptType') is not None:
            self.receipt_type = m.get('receiptType')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('supplierCode') is not None:
            self.supplier_code = m.get('supplierCode')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateReceiptRequest(TeaModel):
    def __init__(
        self,
        receipts: List[CreateReceiptRequestReceipts] = None,
    ):
        # 单据列表，不超过10条数据
        self.receipts = receipts

    def validate(self):
        if self.receipts:
            for k in self.receipts:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['receipts'] = []
        if self.receipts is not None:
            for k in self.receipts:
                result['receipts'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.receipts = []
        if m.get('receipts') is not None:
            for k in m.get('receipts'):
                temp_model = CreateReceiptRequestReceipts()
                self.receipts.append(temp_model.from_map(k))
        return self


class CreateReceiptResponseBodyResults(TeaModel):
    def __init__(
        self,
        code: str = None,
        error_code: str = None,
        error_msg: str = None,
        success: bool = None,
    ):
        # 数据唯一编号
        self.code = code
        # 错误码
        self.error_code = error_code
        # 错误信息
        self.error_msg = error_msg
        # 是否成功
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateReceiptResponseBody(TeaModel):
    def __init__(
        self,
        results: List[CreateReceiptResponseBodyResults] = None,
    ):
        # 结果列表
        self.results = results

    def validate(self):
        if self.results:
            for k in self.results:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['results'] = []
        if self.results is not None:
            for k in self.results:
                result['results'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.results = []
        if m.get('results') is not None:
            for k in m.get('results'):
                temp_model = CreateReceiptResponseBodyResults()
                self.results.append(temp_model.from_map(k))
        return self


class CreateReceiptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateReceiptResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = CreateReceiptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteReceiptHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteReceiptRequestReceipts(TeaModel):
    def __init__(
        self,
        code: str = None,
        delete_user_id: str = None,
        receipt_type: int = None,
    ):
        # 单据唯一编号
        self.code = code
        # 修改者工号
        self.delete_user_id = delete_user_id
        # 单据类型：1付款单，2收款单
        self.receipt_type = receipt_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.delete_user_id is not None:
            result['deleteUserId'] = self.delete_user_id
        if self.receipt_type is not None:
            result['receiptType'] = self.receipt_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('deleteUserId') is not None:
            self.delete_user_id = m.get('deleteUserId')
        if m.get('receiptType') is not None:
            self.receipt_type = m.get('receiptType')
        return self


class DeleteReceiptRequest(TeaModel):
    def __init__(
        self,
        receipts: List[DeleteReceiptRequestReceipts] = None,
    ):
        # 单据列表，最长不超过10条
        self.receipts = receipts

    def validate(self):
        if self.receipts:
            for k in self.receipts:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['receipts'] = []
        if self.receipts is not None:
            for k in self.receipts:
                result['receipts'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.receipts = []
        if m.get('receipts') is not None:
            for k in m.get('receipts'):
                temp_model = DeleteReceiptRequestReceipts()
                self.receipts.append(temp_model.from_map(k))
        return self


class DeleteReceiptResponseBodyResults(TeaModel):
    def __init__(
        self,
        code: str = None,
        error_code: str = None,
        error_msg: str = None,
        success: bool = None,
    ):
        # 数据唯一编号
        self.code = code
        # 错误码
        self.error_code = error_code
        # 错误信息
        self.error_msg = error_msg
        # 是否成功
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteReceiptResponseBody(TeaModel):
    def __init__(
        self,
        results: List[DeleteReceiptResponseBodyResults] = None,
    ):
        # 结果列表
        self.results = results

    def validate(self):
        if self.results:
            for k in self.results:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['results'] = []
        if self.results is not None:
            for k in self.results:
                result['results'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.results = []
        if m.get('results') is not None:
            for k in m.get('results'):
                temp_model = DeleteReceiptResponseBodyResults()
                self.results.append(temp_model.from_map(k))
        return self


class DeleteReceiptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteReceiptResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = DeleteReceiptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetBookkeepingUserListHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetBookkeepingUserListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[str] = None,
    ):
        # staffId列表
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class GetBookkeepingUserListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetBookkeepingUserListResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = GetBookkeepingUserListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCategoryHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetCategoryRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        # 类别code
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class GetCategoryResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
        is_dir: bool = None,
        name: str = None,
        parent_code: str = None,
        status: str = None,
        type: str = None,
    ):
        # 类别code
        self.code = code
        # 是否为目录
        self.is_dir = is_dir
        # 名称
        self.name = name
        # 父类别code
        self.parent_code = parent_code
        # 状态:valid,invalid,deleted
        self.status = status
        # 类型：income收入，expense支出
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.is_dir is not None:
            result['isDir'] = self.is_dir
        if self.name is not None:
            result['name'] = self.name
        if self.parent_code is not None:
            result['parentCode'] = self.parent_code
        if self.status is not None:
            result['status'] = self.status
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('isDir') is not None:
            self.is_dir = m.get('isDir')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentCode') is not None:
            self.parent_code = m.get('parentCode')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetCategoryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetCategoryResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = GetCategoryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCustomerHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetCustomerRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        # 客户code
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class GetCustomerResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
        create_time: int = None,
        description: str = None,
        name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        # 客户Code
        self.code = code
        # 创建时间(单位MS)
        self.create_time = create_time
        # 客户描述
        self.description = description
        # 客户名称
        self.name = name
        # 状态：启用(valid), 停用(invalid), 删除(deleted)
        self.status = status
        # 用户自定义code
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.status is not None:
            result['status'] = self.status
        if self.user_define_code is not None:
            result['userDefineCode'] = self.user_define_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class GetCustomerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetCustomerResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = GetCustomerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFinanceAccountHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetFinanceAccountRequest(TeaModel):
    def __init__(
        self,
        account_code: str = None,
    ):
        # 账户code
        self.account_code = account_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_code is not None:
            result['accountCode'] = self.account_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountCode') is not None:
            self.account_code = m.get('accountCode')
        return self


class GetFinanceAccountResponseBody(TeaModel):
    def __init__(
        self,
        account_code: str = None,
        account_id: str = None,
        account_name: str = None,
        account_remark: str = None,
        account_type: str = None,
        amount: str = None,
        bank_code: str = None,
        bank_name: str = None,
        create_time: int = None,
        creator: str = None,
    ):
        # 账户code
        self.account_code = account_code
        # 关联资金账户id
        self.account_id = account_id
        # 账户名称
        self.account_name = account_name
        # 备注
        self.account_remark = account_remark
        # 账户类型:ALIPAY, BANKCARD, CASH, WECHAT
        self.account_type = account_type
        # 账户总额，保留2位小数
        self.amount = amount
        # 银行代号，如果是银行卡类型，有值，其他类型时，为空
        self.bank_code = bank_code
        # 银行名称，如果是银行卡类型，有值，其他类型时，为空
        self.bank_name = bank_name
        # 创建时间
        self.create_time = create_time
        # 创建人工号
        self.creator = creator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_code is not None:
            result['accountCode'] = self.account_code
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.account_remark is not None:
            result['accountRemark'] = self.account_remark
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.amount is not None:
            result['amount'] = self.amount
        if self.bank_code is not None:
            result['bankCode'] = self.bank_code
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountCode') is not None:
            self.account_code = m.get('accountCode')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('accountRemark') is not None:
            self.account_remark = m.get('accountRemark')
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('bankCode') is not None:
            self.bank_code = m.get('bankCode')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        return self


class GetFinanceAccountResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetFinanceAccountResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = GetFinanceAccountResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInvoiceByPageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetInvoiceByPageRequestRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        finance_type: str = None,
        page_number: int = None,
        page_size: int = None,
        start_time: int = None,
        tax_no: str = None,
        verify_status: str = None,
    ):
        # 结束时间
        # 
        self.end_time = end_time
        # 进项票/销项票
        self.finance_type = finance_type
        # 分页参数
        self.page_number = page_number
        # 分页参数
        self.page_size = page_size
        # 开始时间
        self.start_time = start_time
        # 税号
        self.tax_no = tax_no
        # 认证状态
        self.verify_status = verify_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.finance_type is not None:
            result['financeType'] = self.finance_type
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        if self.verify_status is not None:
            result['verifyStatus'] = self.verify_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('financeType') is not None:
            self.finance_type = m.get('financeType')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        if m.get('verifyStatus') is not None:
            self.verify_status = m.get('verifyStatus')
        return self


class GetInvoiceByPageRequest(TeaModel):
    def __init__(
        self,
        request: GetInvoiceByPageRequestRequest = None,
    ):
        self.request = request

    def validate(self):
        if self.request:
            self.request.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request is not None:
            result['request'] = self.request.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('request') is not None:
            temp_model = GetInvoiceByPageRequestRequest()
            self.request = temp_model.from_map(m['request'])
        return self


class GetInvoiceByPageShrinkRequest(TeaModel):
    def __init__(
        self,
        request_shrink: str = None,
    ):
        self.request_shrink = request_shrink

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_shrink is not None:
            result['request'] = self.request_shrink
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('request') is not None:
            self.request_shrink = m.get('request')
        return self


class GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        good_name: str = None,
        quantity: str = None,
        revenue_code: str = None,
        row_no: str = None,
        specification: str = None,
        tax_amount: str = None,
        tax_pre: str = None,
        tax_rate: str = None,
        unit: str = None,
        unit_price: str = None,
    ):
        # 金额
        self.amount = amount
        # 商品名称
        self.good_name = good_name
        # 数量
        self.quantity = quantity
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 规格型号
        self.specification = specification
        # 税额
        self.tax_amount = tax_amount
        # 是否享受税收优惠：0-不享受，1-享受
        self.tax_pre = tax_pre
        # 税率
        self.tax_rate = tax_rate
        # 单位
        self.unit = unit
        # 单价
        self.unit_price = unit_price

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.good_name is not None:
            result['goodName'] = self.good_name
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.specification is not None:
            result['specification'] = self.specification
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_pre is not None:
            result['taxPre'] = self.tax_pre
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.unit is not None:
            result['unit'] = self.unit
        if self.unit_price is not None:
            result['unitPrice'] = self.unit_price
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('goodName') is not None:
            self.good_name = m.get('goodName')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxPre') is not None:
            self.tax_pre = m.get('taxPre')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('unitPrice') is not None:
            self.unit_price = m.get('unitPrice')
        return self


class GetInvoiceByPageResponseBodyResultListSecondHandCarInvoiceDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        card_no: str = None,
        end_date: str = None,
        goods_name: str = None,
        revenue_code: str = None,
        row_no: str = None,
        start_date: str = None,
        tax_amount: str = None,
        tax_rate: str = None,
        vehicle_type: str = None,
    ):
        # 金额
        self.amount = amount
        # 车牌号
        self.card_no = card_no
        # 通行日期止
        self.end_date = end_date
        # 商品名称
        self.goods_name = goods_name
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 通行日期起
        self.start_date = start_date
        # 税额
        self.tax_amount = tax_amount
        # 税率
        self.tax_rate = tax_rate
        # 类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        auction_unit: str = None,
        auction_unit_address: str = None,
        auction_unit_bank: str = None,
        auction_unit_tax_no: str = None,
        auction_util_tel: str = None,
        car_model: str = None,
        card_no: str = None,
        registration: str = None,
        transfer_vehicle: str = None,
        used_car_address: str = None,
        used_car_market: str = None,
        used_car_market_bank: str = None,
        used_car_market_phone: str = None,
        used_car_market_tax_no: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 经营、拍卖单位
        self.auction_unit = auction_unit
        # 经营、拍卖单位地址
        self.auction_unit_address = auction_unit_address
        # 经营、拍卖单位银行
        self.auction_unit_bank = auction_unit_bank
        # 经营、拍卖单位税号
        self.auction_unit_tax_no = auction_unit_tax_no
        # 经营、拍卖单位电话
        self.auction_util_tel = auction_util_tel
        # 厂牌型号
        self.car_model = car_model
        # 车牌照号
        self.card_no = card_no
        # 登记证号
        self.registration = registration
        # 转入地车辆管理所名称
        self.transfer_vehicle = transfer_vehicle
        # 二手车市场地址
        self.used_car_address = used_car_address
        # 二手车市场
        self.used_car_market = used_car_market
        # 二手车市场开户银行、账号
        self.used_car_market_bank = used_car_market_bank
        # 二手车市场电话
        self.used_car_market_phone = used_car_market_phone
        # 二手车市场纳税人识别号
        self.used_car_market_tax_no = used_car_market_tax_no
        # 车架号/车辆识别号
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auction_unit is not None:
            result['auctionUnit'] = self.auction_unit
        if self.auction_unit_address is not None:
            result['auctionUnitAddress'] = self.auction_unit_address
        if self.auction_unit_bank is not None:
            result['auctionUnitBank'] = self.auction_unit_bank
        if self.auction_unit_tax_no is not None:
            result['auctionUnitTaxNo'] = self.auction_unit_tax_no
        if self.auction_util_tel is not None:
            result['auctionUtilTel'] = self.auction_util_tel
        if self.car_model is not None:
            result['carModel'] = self.car_model
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.registration is not None:
            result['registration'] = self.registration
        if self.transfer_vehicle is not None:
            result['transferVehicle'] = self.transfer_vehicle
        if self.used_car_address is not None:
            result['usedCarAddress'] = self.used_car_address
        if self.used_car_market is not None:
            result['usedCarMarket'] = self.used_car_market
        if self.used_car_market_bank is not None:
            result['usedCarMarketBank'] = self.used_car_market_bank
        if self.used_car_market_phone is not None:
            result['usedCarMarketPhone'] = self.used_car_market_phone
        if self.used_car_market_tax_no is not None:
            result['usedCarMarketTaxNo'] = self.used_car_market_tax_no
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('auctionUnit') is not None:
            self.auction_unit = m.get('auctionUnit')
        if m.get('auctionUnitAddress') is not None:
            self.auction_unit_address = m.get('auctionUnitAddress')
        if m.get('auctionUnitBank') is not None:
            self.auction_unit_bank = m.get('auctionUnitBank')
        if m.get('auctionUnitTaxNo') is not None:
            self.auction_unit_tax_no = m.get('auctionUnitTaxNo')
        if m.get('auctionUtilTel') is not None:
            self.auction_util_tel = m.get('auctionUtilTel')
        if m.get('carModel') is not None:
            self.car_model = m.get('carModel')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('registration') is not None:
            self.registration = m.get('registration')
        if m.get('transferVehicle') is not None:
            self.transfer_vehicle = m.get('transferVehicle')
        if m.get('usedCarAddress') is not None:
            self.used_car_address = m.get('usedCarAddress')
        if m.get('usedCarMarket') is not None:
            self.used_car_market = m.get('usedCarMarket')
        if m.get('usedCarMarketBank') is not None:
            self.used_car_market_bank = m.get('usedCarMarketBank')
        if m.get('usedCarMarketPhone') is not None:
            self.used_car_market_phone = m.get('usedCarMarketPhone')
        if m.get('usedCarMarketTaxNo') is not None:
            self.used_car_market_tax_no = m.get('usedCarMarketTaxNo')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        brand: str = None,
        certificate_no: str = None,
        engine_no: str = None,
        id_card_no: str = None,
        import_certificate_no: str = None,
        max_passengers: str = None,
        origin_place: str = None,
        payment_voucher_no: str = None,
        tax_authority_name: str = None,
        tax_authority_no: str = None,
        tax_rate: str = None,
        tonnage: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 品牌
        self.brand = brand
        # 合格证号
        self.certificate_no = certificate_no
        # 发动机号
        self.engine_no = engine_no
        # 身份证号/组织机构代码
        self.id_card_no = id_card_no
        # 进口证书号
        self.import_certificate_no = import_certificate_no
        # 限乘人数
        self.max_passengers = max_passengers
        # 产地
        self.origin_place = origin_place
        # 完税凭证号码
        self.payment_voucher_no = payment_voucher_no
        # 主管税务机关名称
        self.tax_authority_name = tax_authority_name
        # 主管税务机关代码
        self.tax_authority_no = tax_authority_no
        # 税率
        self.tax_rate = tax_rate
        # 吨位
        self.tonnage = tonnage
        # 车架号码
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.brand is not None:
            result['brand'] = self.brand
        if self.certificate_no is not None:
            result['certificateNo'] = self.certificate_no
        if self.engine_no is not None:
            result['engineNo'] = self.engine_no
        if self.id_card_no is not None:
            result['idCardNo'] = self.id_card_no
        if self.import_certificate_no is not None:
            result['importCertificateNo'] = self.import_certificate_no
        if self.max_passengers is not None:
            result['maxPassengers'] = self.max_passengers
        if self.origin_place is not None:
            result['originPlace'] = self.origin_place
        if self.payment_voucher_no is not None:
            result['paymentVoucherNo'] = self.payment_voucher_no
        if self.tax_authority_name is not None:
            result['taxAuthorityName'] = self.tax_authority_name
        if self.tax_authority_no is not None:
            result['taxAuthorityNo'] = self.tax_authority_no
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.tonnage is not None:
            result['tonnage'] = self.tonnage
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('brand') is not None:
            self.brand = m.get('brand')
        if m.get('certificateNo') is not None:
            self.certificate_no = m.get('certificateNo')
        if m.get('engineNo') is not None:
            self.engine_no = m.get('engineNo')
        if m.get('idCardNo') is not None:
            self.id_card_no = m.get('idCardNo')
        if m.get('importCertificateNo') is not None:
            self.import_certificate_no = m.get('importCertificateNo')
        if m.get('maxPassengers') is not None:
            self.max_passengers = m.get('maxPassengers')
        if m.get('originPlace') is not None:
            self.origin_place = m.get('originPlace')
        if m.get('paymentVoucherNo') is not None:
            self.payment_voucher_no = m.get('paymentVoucherNo')
        if m.get('taxAuthorityName') is not None:
            self.tax_authority_name = m.get('taxAuthorityName')
        if m.get('taxAuthorityNo') is not None:
            self.tax_authority_no = m.get('taxAuthorityNo')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('tonnage') is not None:
            self.tonnage = m.get('tonnage')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class GetInvoiceByPageResponseBodyResultList(TeaModel):
    def __init__(
        self,
        account_period: str = None,
        amount: str = None,
        amount_with_tax: str = None,
        check_code: str = None,
        check_time: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        finance_type: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList] = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_type: str = None,
        machine_code: str = None,
        oil_flag: str = None,
        payee: str = None,
        process_inst_code: str = None,
        process_inst_type: str = None,
        purchaser_address: str = None,
        purchaser_bank_name_account: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
        remark: str = None,
        second_hand_car_invoice_detail_list: List[GetInvoiceByPageResponseBodyResultListSecondHandCarInvoiceDetailList] = None,
        seller_address: str = None,
        seller_bank_name_account: str = None,
        seller_name: str = None,
        seller_tax_no: str = None,
        seller_tel: str = None,
        status: str = None,
        supply_sign: str = None,
        tax_amount: str = None,
        used_vehicle_sale_detail_volist: List[GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        # 账期时间
        self.account_period = account_period
        # 不含税金额
        self.amount = amount
        # 含税金额
        self.amount_with_tax = amount_with_tax
        # 校验码
        self.check_code = check_code
        # 查验时间
        self.check_time = check_time
        # 开票日期
        self.drew_date = drew_date
        # 电票版式文件下载地址
        self.electronic_url = electronic_url
        # 财务类型，INPUT-VAT(进项),OUTPUT_VAT(销项)
        self.finance_type = finance_type
        # 资金类型 ，RED（红票），（BLUE）蓝票
        self.fund_type = fund_type
        # 常规发票明细
        self.general_invoice_detail_volist = general_invoice_detail_volist
        # 发票代码
        self.invoice_code = invoice_code
        # 发票号码
        self.invoice_no = invoice_no
        # 发票类型
        self.invoice_type = invoice_type
        # 机器码
        self.machine_code = machine_code
        # 成品油标识
        self.oil_flag = oil_flag
        # 收款人
        self.payee = payee
        # 审批单实例
        self.process_inst_code = process_inst_code
        # 审批单类型
        self.process_inst_type = process_inst_type
        # 购方地址
        self.purchaser_address = purchaser_address
        # 购方银行
        self.purchaser_bank_name_account = purchaser_bank_name_account
        # 购方名称
        self.purchaser_name = purchaser_name
        # 购方税号
        self.purchaser_tax_no = purchaser_tax_no
        # 购方电话
        self.purchaser_tel = purchaser_tel
        # 备注
        self.remark = remark
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        # 销方地址
        self.seller_address = seller_address
        # 销方银行
        self.seller_bank_name_account = seller_bank_name_account
        # 销方名称
        self.seller_name = seller_name
        # 销方税号
        self.seller_tax_no = seller_tax_no
        # 销方电话
        self.seller_tel = seller_tel
        # 发票状态
        self.status = status
        # 代开发票标识 1-自开，2-代开
        self.supply_sign = supply_sign
        # 税额
        self.tax_amount = tax_amount
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        # 发票查验状态
        self.verify_status = verify_status
        # 凭证code
        self.voucher_code = voucher_code
        # 生成凭证状态
        self.voucher_status = voucher_status

    def validate(self):
        if self.general_invoice_detail_volist:
            for k in self.general_invoice_detail_volist:
                if k:
                    k.validate()
        if self.second_hand_car_invoice_detail_list:
            for k in self.second_hand_car_invoice_detail_list:
                if k:
                    k.validate()
        if self.used_vehicle_sale_detail_volist:
            for k in self.used_vehicle_sale_detail_volist:
                if k:
                    k.validate()
        if self.vehicle_sale_detail_volist:
            for k in self.vehicle_sale_detail_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_period is not None:
            result['accountPeriod'] = self.account_period
        if self.amount is not None:
            result['amount'] = self.amount
        if self.amount_with_tax is not None:
            result['amountWithTax'] = self.amount_with_tax
        if self.check_code is not None:
            result['checkCode'] = self.check_code
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.drew_date is not None:
            result['drewDate'] = self.drew_date
        if self.electronic_url is not None:
            result['electronicUrl'] = self.electronic_url
        if self.finance_type is not None:
            result['financeType'] = self.finance_type
        if self.fund_type is not None:
            result['fundType'] = self.fund_type
        result['generalInvoiceDetailVOList'] = []
        if self.general_invoice_detail_volist is not None:
            for k in self.general_invoice_detail_volist:
                result['generalInvoiceDetailVOList'].append(k.to_map() if k else None)
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.machine_code is not None:
            result['machineCode'] = self.machine_code
        if self.oil_flag is not None:
            result['oilFlag'] = self.oil_flag
        if self.payee is not None:
            result['payee'] = self.payee
        if self.process_inst_code is not None:
            result['processInstCode'] = self.process_inst_code
        if self.process_inst_type is not None:
            result['processInstType'] = self.process_inst_type
        if self.purchaser_address is not None:
            result['purchaserAddress'] = self.purchaser_address
        if self.purchaser_bank_name_account is not None:
            result['purchaserBankNameAccount'] = self.purchaser_bank_name_account
        if self.purchaser_name is not None:
            result['purchaserName'] = self.purchaser_name
        if self.purchaser_tax_no is not None:
            result['purchaserTaxNo'] = self.purchaser_tax_no
        if self.purchaser_tel is not None:
            result['purchaserTel'] = self.purchaser_tel
        if self.remark is not None:
            result['remark'] = self.remark
        result['secondHandCarInvoiceDetailList'] = []
        if self.second_hand_car_invoice_detail_list is not None:
            for k in self.second_hand_car_invoice_detail_list:
                result['secondHandCarInvoiceDetailList'].append(k.to_map() if k else None)
        if self.seller_address is not None:
            result['sellerAddress'] = self.seller_address
        if self.seller_bank_name_account is not None:
            result['sellerBankNameAccount'] = self.seller_bank_name_account
        if self.seller_name is not None:
            result['sellerName'] = self.seller_name
        if self.seller_tax_no is not None:
            result['sellerTaxNo'] = self.seller_tax_no
        if self.seller_tel is not None:
            result['sellerTel'] = self.seller_tel
        if self.status is not None:
            result['status'] = self.status
        if self.supply_sign is not None:
            result['supplySign'] = self.supply_sign
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        result['usedVehicleSaleDetailVOList'] = []
        if self.used_vehicle_sale_detail_volist is not None:
            for k in self.used_vehicle_sale_detail_volist:
                result['usedVehicleSaleDetailVOList'].append(k.to_map() if k else None)
        result['vehicleSaleDetailVOList'] = []
        if self.vehicle_sale_detail_volist is not None:
            for k in self.vehicle_sale_detail_volist:
                result['vehicleSaleDetailVOList'].append(k.to_map() if k else None)
        if self.verify_status is not None:
            result['verifyStatus'] = self.verify_status
        if self.voucher_code is not None:
            result['voucherCode'] = self.voucher_code
        if self.voucher_status is not None:
            result['voucherStatus'] = self.voucher_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountPeriod') is not None:
            self.account_period = m.get('accountPeriod')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('amountWithTax') is not None:
            self.amount_with_tax = m.get('amountWithTax')
        if m.get('checkCode') is not None:
            self.check_code = m.get('checkCode')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('drewDate') is not None:
            self.drew_date = m.get('drewDate')
        if m.get('electronicUrl') is not None:
            self.electronic_url = m.get('electronicUrl')
        if m.get('financeType') is not None:
            self.finance_type = m.get('financeType')
        if m.get('fundType') is not None:
            self.fund_type = m.get('fundType')
        self.general_invoice_detail_volist = []
        if m.get('generalInvoiceDetailVOList') is not None:
            for k in m.get('generalInvoiceDetailVOList'):
                temp_model = GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList()
                self.general_invoice_detail_volist.append(temp_model.from_map(k))
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('machineCode') is not None:
            self.machine_code = m.get('machineCode')
        if m.get('oilFlag') is not None:
            self.oil_flag = m.get('oilFlag')
        if m.get('payee') is not None:
            self.payee = m.get('payee')
        if m.get('processInstCode') is not None:
            self.process_inst_code = m.get('processInstCode')
        if m.get('processInstType') is not None:
            self.process_inst_type = m.get('processInstType')
        if m.get('purchaserAddress') is not None:
            self.purchaser_address = m.get('purchaserAddress')
        if m.get('purchaserBankNameAccount') is not None:
            self.purchaser_bank_name_account = m.get('purchaserBankNameAccount')
        if m.get('purchaserName') is not None:
            self.purchaser_name = m.get('purchaserName')
        if m.get('purchaserTaxNo') is not None:
            self.purchaser_tax_no = m.get('purchaserTaxNo')
        if m.get('purchaserTel') is not None:
            self.purchaser_tel = m.get('purchaserTel')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        self.second_hand_car_invoice_detail_list = []
        if m.get('secondHandCarInvoiceDetailList') is not None:
            for k in m.get('secondHandCarInvoiceDetailList'):
                temp_model = GetInvoiceByPageResponseBodyResultListSecondHandCarInvoiceDetailList()
                self.second_hand_car_invoice_detail_list.append(temp_model.from_map(k))
        if m.get('sellerAddress') is not None:
            self.seller_address = m.get('sellerAddress')
        if m.get('sellerBankNameAccount') is not None:
            self.seller_bank_name_account = m.get('sellerBankNameAccount')
        if m.get('sellerName') is not None:
            self.seller_name = m.get('sellerName')
        if m.get('sellerTaxNo') is not None:
            self.seller_tax_no = m.get('sellerTaxNo')
        if m.get('sellerTel') is not None:
            self.seller_tel = m.get('sellerTel')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('supplySign') is not None:
            self.supply_sign = m.get('supplySign')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        self.used_vehicle_sale_detail_volist = []
        if m.get('usedVehicleSaleDetailVOList') is not None:
            for k in m.get('usedVehicleSaleDetailVOList'):
                temp_model = GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList()
                self.used_vehicle_sale_detail_volist.append(temp_model.from_map(k))
        self.vehicle_sale_detail_volist = []
        if m.get('vehicleSaleDetailVOList') is not None:
            for k in m.get('vehicleSaleDetailVOList'):
                temp_model = GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList()
                self.vehicle_sale_detail_volist.append(temp_model.from_map(k))
        if m.get('verifyStatus') is not None:
            self.verify_status = m.get('verifyStatus')
        if m.get('voucherCode') is not None:
            self.voucher_code = m.get('voucherCode')
        if m.get('voucherStatus') is not None:
            self.voucher_status = m.get('voucherStatus')
        return self


class GetInvoiceByPageResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: str = None,
        list: List[GetInvoiceByPageResponseBodyResultList] = None,
        next_cursor: int = None,
        total_count: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_cursor = next_cursor
        self.total_count = total_count

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = GetInvoiceByPageResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetInvoiceByPageResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        result: GetInvoiceByPageResponseBodyResult = None,
        success: bool = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            temp_model = GetInvoiceByPageResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetInvoiceByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetInvoiceByPageResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = GetInvoiceByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetIsNewVersionHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetIsNewVersionResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetIsNewVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetIsNewVersionResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = GetIsNewVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProjectHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetProjectRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        # 项目code
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class GetProjectResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
        create_time: int = None,
        creator: str = None,
        description: str = None,
        name: str = None,
        project_code: str = None,
        project_name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        # 项目code
        self.code = code
        # 创建时间
        self.create_time = create_time
        # 创建人工号
        self.creator = creator
        # 项目描述
        self.description = description
        # 项目名字
        self.name = name
        # 项目code，废弃，请使用code
        self.project_code = project_code
        # 项目名称，废弃，请使用name
        self.project_name = project_name
        # 状态:valid, invalid, deleted
        self.status = status
        # 用户自定义code
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.project_name is not None:
            result['projectName'] = self.project_name
        if self.status is not None:
            result['status'] = self.status
        if self.user_define_code is not None:
            result['userDefineCode'] = self.user_define_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('projectName') is not None:
            self.project_name = m.get('projectName')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class GetProjectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetProjectResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = GetProjectResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetReceiptHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetReceiptRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        model_id: str = None,
    ):
        # 单据号
        self.code = code
        # 模型id
        self.model_id = model_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.model_id is not None:
            result['modelId'] = self.model_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('modelId') is not None:
            self.model_id = m.get('modelId')
        return self


class GetReceiptResponseBody(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        data: str = None,
        model_id: str = None,
        source: str = None,
    ):
        # 数据来源于开放时，对应的微应用id
        self.app_id = app_id
        # 单据数据体json
        self.data = data
        # 数据模型id
        self.model_id = model_id
        # 数据来源：审批(approval)，开放接口(openapi)
        self.source = source

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.data is not None:
            result['data'] = self.data
        if self.model_id is not None:
            result['modelId'] = self.model_id
        if self.source is not None:
            result['source'] = self.source
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('modelId') is not None:
            self.model_id = m.get('modelId')
        if m.get('source') is not None:
            self.source = m.get('source')
        return self


class GetReceiptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetReceiptResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = GetReceiptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSupplierHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetSupplierRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        # 供应商code
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class GetSupplierResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
        create_time: int = None,
        description: str = None,
        name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        # 供应商Code
        self.code = code
        # 创建时间(单位MS)
        self.create_time = create_time
        # 供应商描述
        self.description = description
        # 供应商名称
        self.name = name
        # 状态：启用(valid), 停用(invalid), 删除(deleted)
        self.status = status
        # 用户自定义code
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.status is not None:
            result['status'] = self.status
        if self.user_define_code is not None:
            result['userDefineCode'] = self.user_define_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class GetSupplierResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetSupplierResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = GetSupplierResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCategoryByPageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryCategoryByPageRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        type: str = None,
    ):
        # 分页，从1开始
        self.page_number = page_number
        # 分页大小，默认10
        self.page_size = page_size
        # 类型：income收入，expense支出
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class QueryCategoryByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        code: str = None,
        is_dir: bool = None,
        name: str = None,
        parent_code: str = None,
        status: str = None,
        type: str = None,
    ):
        # 类别code
        self.code = code
        # 是否为目录
        self.is_dir = is_dir
        # 名字
        self.name = name
        # 父类别code
        self.parent_code = parent_code
        # 状态:valid,invalid,deleted
        self.status = status
        # 类型:income收入，expense支出
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.is_dir is not None:
            result['isDir'] = self.is_dir
        if self.name is not None:
            result['name'] = self.name
        if self.parent_code is not None:
            result['parentCode'] = self.parent_code
        if self.status is not None:
            result['status'] = self.status
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('isDir') is not None:
            self.is_dir = m.get('isDir')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentCode') is not None:
            self.parent_code = m.get('parentCode')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class QueryCategoryByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryCategoryByPageResponseBodyList] = None,
    ):
        # 是否还有更多数据
        self.has_more = has_more
        # resultList
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryCategoryByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryCategoryByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryCategoryByPageResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryCategoryByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCustomerByPageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryCustomerByPageRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # 分页，从1开始
        self.page_number = page_number
        # 分页大小，默认10
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryCustomerByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        code: str = None,
        create_time: int = None,
        description: str = None,
        name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        # 客户Code
        self.code = code
        # 创建时间(单位MS)
        self.create_time = create_time
        # 客户描述
        self.description = description
        # 客户名称
        self.name = name
        # 状态：启用(valid), 停用(invalid), 删除(deleted)
        self.status = status
        # 用户自定义code
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.status is not None:
            result['status'] = self.status
        if self.user_define_code is not None:
            result['userDefineCode'] = self.user_define_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class QueryCustomerByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryCustomerByPageResponseBodyList] = None,
    ):
        # 是否还有更多数据
        self.has_more = has_more
        # resultList
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryCustomerByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryCustomerByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryCustomerByPageResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryCustomerByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCustomerInfoHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryCustomerInfoRequest(TeaModel):
    def __init__(
        self,
        keyword: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # 查询条件，目前支持 名字、税号、购方电话
        self.keyword = keyword
        # 查询页码，从1开始
        self.page_number = page_number
        # 每页查询数量
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryCustomerInfoResponseBodyList(TeaModel):
    def __init__(
        self,
        code: str = None,
        contact_address: str = None,
        contact_company_telephone: str = None,
        contact_email: str = None,
        contact_name: str = None,
        contact_telephone: str = None,
        description: str = None,
        name: str = None,
        purchaser_account: str = None,
        purchaser_address: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
        purchaserr_bank_name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        # 客户code
        self.code = code
        self.contact_address = contact_address
        self.contact_company_telephone = contact_company_telephone
        self.contact_email = contact_email
        self.contact_name = contact_name
        self.contact_telephone = contact_telephone
        # 客户描述
        self.description = description
        # 客户名字
        self.name = name
        # 购方账户
        self.purchaser_account = purchaser_account
        # 购方地址
        self.purchaser_address = purchaser_address
        # 购方姓名
        self.purchaser_name = purchaser_name
        # 购方税号
        self.purchaser_tax_no = purchaser_tax_no
        # 购方电话
        self.purchaser_tel = purchaser_tel
        # 购方银行
        self.purchaserr_bank_name = purchaserr_bank_name
        # 状态
        self.status = status
        # 用户自定义code
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.contact_address is not None:
            result['contactAddress'] = self.contact_address
        if self.contact_company_telephone is not None:
            result['contactCompanyTelephone'] = self.contact_company_telephone
        if self.contact_email is not None:
            result['contactEmail'] = self.contact_email
        if self.contact_name is not None:
            result['contactName'] = self.contact_name
        if self.contact_telephone is not None:
            result['contactTelephone'] = self.contact_telephone
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.purchaser_account is not None:
            result['purchaserAccount'] = self.purchaser_account
        if self.purchaser_address is not None:
            result['purchaserAddress'] = self.purchaser_address
        if self.purchaser_name is not None:
            result['purchaserName'] = self.purchaser_name
        if self.purchaser_tax_no is not None:
            result['purchaserTaxNo'] = self.purchaser_tax_no
        if self.purchaser_tel is not None:
            result['purchaserTel'] = self.purchaser_tel
        if self.purchaserr_bank_name is not None:
            result['purchaserrBankName'] = self.purchaserr_bank_name
        if self.status is not None:
            result['status'] = self.status
        if self.user_define_code is not None:
            result['userDefineCode'] = self.user_define_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('contactAddress') is not None:
            self.contact_address = m.get('contactAddress')
        if m.get('contactCompanyTelephone') is not None:
            self.contact_company_telephone = m.get('contactCompanyTelephone')
        if m.get('contactEmail') is not None:
            self.contact_email = m.get('contactEmail')
        if m.get('contactName') is not None:
            self.contact_name = m.get('contactName')
        if m.get('contactTelephone') is not None:
            self.contact_telephone = m.get('contactTelephone')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('purchaserAccount') is not None:
            self.purchaser_account = m.get('purchaserAccount')
        if m.get('purchaserAddress') is not None:
            self.purchaser_address = m.get('purchaserAddress')
        if m.get('purchaserName') is not None:
            self.purchaser_name = m.get('purchaserName')
        if m.get('purchaserTaxNo') is not None:
            self.purchaser_tax_no = m.get('purchaserTaxNo')
        if m.get('purchaserTel') is not None:
            self.purchaser_tel = m.get('purchaserTel')
        if m.get('purchaserrBankName') is not None:
            self.purchaserr_bank_name = m.get('purchaserrBankName')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class QueryCustomerInfoResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryCustomerInfoResponseBodyList] = None,
        total_count: int = None,
    ):
        # 是否还有数据
        self.has_more = has_more
        # 客户分页数据
        self.list = list
        # 总数
        self.total_count = total_count

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryCustomerInfoResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryCustomerInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryCustomerInfoResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryCustomerInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryEnterpriseAccountByPageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryEnterpriseAccountByPageRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # 分页，从1开始
        self.page_number = page_number
        # 分页大小，默认10
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryEnterpriseAccountByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        account_code: str = None,
        account_id: str = None,
        account_name: str = None,
        account_remark: str = None,
        account_type: str = None,
        amount: str = None,
        bank_code: str = None,
        bank_name: str = None,
        create_time: int = None,
        creator: str = None,
    ):
        # 账户code
        self.account_code = account_code
        # 关联资金账号id
        self.account_id = account_id
        # 账户名称
        self.account_name = account_name
        # 备注
        self.account_remark = account_remark
        # 账户类型:ALIPAY, BANKCARD, CASH, WECHAT
        self.account_type = account_type
        # 账户总额，保留2位小数
        self.amount = amount
        # 银行代号，如果是银行卡类型，有值，其他类型时，为空
        self.bank_code = bank_code
        # 银行名字，如果是银行卡类型，有值，其他类型时，为空
        self.bank_name = bank_name
        # 创建时间
        self.create_time = create_time
        # 创建人工号
        self.creator = creator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_code is not None:
            result['accountCode'] = self.account_code
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.account_remark is not None:
            result['accountRemark'] = self.account_remark
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.amount is not None:
            result['amount'] = self.amount
        if self.bank_code is not None:
            result['bankCode'] = self.bank_code
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountCode') is not None:
            self.account_code = m.get('accountCode')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('accountRemark') is not None:
            self.account_remark = m.get('accountRemark')
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('bankCode') is not None:
            self.bank_code = m.get('bankCode')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        return self


class QueryEnterpriseAccountByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryEnterpriseAccountByPageResponseBodyList] = None,
    ):
        # 是否还有更多数据
        self.has_more = has_more
        # resultList
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryEnterpriseAccountByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryEnterpriseAccountByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryEnterpriseAccountByPageResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryEnterpriseAccountByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryFinanceCompanyInfoHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryFinanceCompanyInfoResponseBody(TeaModel):
    def __init__(
        self,
        company_name: str = None,
        tax_nature: str = None,
        tax_no: str = None,
    ):
        self.company_name = company_name
        self.tax_nature = tax_nature
        self.tax_no = tax_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_name is not None:
            result['companyName'] = self.company_name
        if self.tax_nature is not None:
            result['taxNature'] = self.tax_nature
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyName') is not None:
            self.company_name = m.get('companyName')
        if m.get('taxNature') is not None:
            self.tax_nature = m.get('taxNature')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        return self


class QueryFinanceCompanyInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryFinanceCompanyInfoResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryFinanceCompanyInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryInvoiceRelationCountHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryInvoiceRelationCountResponseBody(TeaModel):
    def __init__(
        self,
        relation_count_map: Dict[str, int] = None,
    ):
        self.relation_count_map = relation_count_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.relation_count_map is not None:
            result['relationCountMap'] = self.relation_count_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('relationCountMap') is not None:
            self.relation_count_map = m.get('relationCountMap')
        return self


class QueryInvoiceRelationCountResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryInvoiceRelationCountResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryInvoiceRelationCountResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPermissionByUserIdHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryPermissionByUserIdRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # 用户ID
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryPermissionByUserIdResponseBodyPermissionDTOList(TeaModel):
    def __init__(
        self,
        action_id_list: List[str] = None,
        resource_identity: str = None,
    ):
        self.action_id_list = action_id_list
        self.resource_identity = resource_identity

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_id_list is not None:
            result['actionIdList'] = self.action_id_list
        if self.resource_identity is not None:
            result['resourceIdentity'] = self.resource_identity
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionIdList') is not None:
            self.action_id_list = m.get('actionIdList')
        if m.get('resourceIdentity') is not None:
            self.resource_identity = m.get('resourceIdentity')
        return self


class QueryPermissionByUserIdResponseBody(TeaModel):
    def __init__(
        self,
        permission_dtolist: List[QueryPermissionByUserIdResponseBodyPermissionDTOList] = None,
        user_id: str = None,
    ):
        # 权限信息列表
        self.permission_dtolist = permission_dtolist
        # 用户ID
        self.user_id = user_id

    def validate(self):
        if self.permission_dtolist:
            for k in self.permission_dtolist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['permissionDTOList'] = []
        if self.permission_dtolist is not None:
            for k in self.permission_dtolist:
                result['permissionDTOList'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.permission_dtolist = []
        if m.get('permissionDTOList') is not None:
            for k in m.get('permissionDTOList'):
                temp_model = QueryPermissionByUserIdResponseBodyPermissionDTOList()
                self.permission_dtolist.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryPermissionByUserIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryPermissionByUserIdResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryPermissionByUserIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPermissionRoleMemberHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryPermissionRoleMemberRequest(TeaModel):
    def __init__(
        self,
        role_code_list: List[str] = None,
    ):
        # 角色的唯一标识列表
        self.role_code_list = role_code_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_code_list is not None:
            result['roleCodeList'] = self.role_code_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleCodeList') is not None:
            self.role_code_list = m.get('roleCodeList')
        return self


class RoleMemberMapValueMemberList(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        nick: str = None,
        avatar_url: str = None,
    ):
        # 用户ID
        self.user_id = user_id
        # 昵称
        self.nick = nick
        # 头像URL
        self.avatar_url = avatar_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.nick is not None:
            result['nick'] = self.nick
        if self.avatar_url is not None:
            result['avatarUrl'] = self.avatar_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('avatarUrl') is not None:
            self.avatar_url = m.get('avatarUrl')
        return self


class RoleMemberMapValue(TeaModel):
    def __init__(
        self,
        role_code: str = None,
        member_list: List[RoleMemberMapValueMemberList] = None,
    ):
        # 角色唯一标识
        self.role_code = role_code
        # 成员信息列表
        self.member_list = member_list

    def validate(self):
        if self.member_list:
            for k in self.member_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        result['memberList'] = []
        if self.member_list is not None:
            for k in self.member_list:
                result['memberList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        self.member_list = []
        if m.get('memberList') is not None:
            for k in m.get('memberList'):
                temp_model = RoleMemberMapValueMemberList()
                self.member_list.append(temp_model.from_map(k))
        return self


class QueryPermissionRoleMemberResponseBody(TeaModel):
    def __init__(
        self,
        role_member_map: Dict[str, RoleMemberMapValue] = None,
    ):
        # 角色下的成员MAP
        self.role_member_map = role_member_map

    def validate(self):
        if self.role_member_map:
            for v in self.role_member_map.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['roleMemberMap'] = {}
        if self.role_member_map is not None:
            for k, v in self.role_member_map.items():
                result['roleMemberMap'][k] = v.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.role_member_map = {}
        if m.get('roleMemberMap') is not None:
            for k, v in m.get('roleMemberMap').items():
                temp_model = RoleMemberMapValue()
                self.role_member_map[k] = temp_model.from_map(v)
        return self


class QueryPermissionRoleMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryPermissionRoleMemberResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryPermissionRoleMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryProjectByPageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryProjectByPageRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # 分页，从1开始
        self.page_number = page_number
        # 分页大小，默认10
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryProjectByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        caode: str = None,
        create_time: int = None,
        creator: str = None,
        description: str = None,
        name: str = None,
        project_code: str = None,
        project_name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        # 项目code
        self.caode = caode
        # 创建时间
        self.create_time = create_time
        # 创建人工号
        self.creator = creator
        # 描述
        self.description = description
        # 项目名字
        self.name = name
        # 项目code，废弃，请使用code
        self.project_code = project_code
        # 项目名称，废弃，请使用name
        self.project_name = project_name
        # 状态: valid, invalid, deleted
        self.status = status
        # 用户自定义code
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.caode is not None:
            result['caode'] = self.caode
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.project_name is not None:
            result['projectName'] = self.project_name
        if self.status is not None:
            result['status'] = self.status
        if self.user_define_code is not None:
            result['userDefineCode'] = self.user_define_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('caode') is not None:
            self.caode = m.get('caode')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('projectName') is not None:
            self.project_name = m.get('projectName')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class QueryProjectByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryProjectByPageResponseBodyList] = None,
    ):
        # 是否还有更多数据
        self.has_more = has_more
        # resultList
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryProjectByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryProjectByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryProjectByPageResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryProjectByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryReceiptForInvoiceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryReceiptForInvoiceRequest(TeaModel):
    def __init__(
        self,
        apply_status_list: List[str] = None,
        end_time: int = None,
        page_number: int = None,
        page_size: int = None,
        receipt_status_list: List[str] = None,
        start_time: int = None,
        title: str = None,
    ):
        # 发票状态筛选列表 applied 已生成、unapplied 未生成 、 ignore 已忽略
        self.apply_status_list = apply_status_list
        self.end_time = end_time
        # 分页参数，从1 开始
        self.page_number = page_number
        # 分页参数，每页查询个数
        self.page_size = page_size
        # 单据状态筛选条件列表，审批中、已通过 RUNNGIN、COMPLETED
        self.receipt_status_list = receipt_status_list
        # 开始时间
        self.start_time = start_time
        # 单据标题
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apply_status_list is not None:
            result['applyStatusList'] = self.apply_status_list
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.receipt_status_list is not None:
            result['receiptStatusList'] = self.receipt_status_list
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('applyStatusList') is not None:
            self.apply_status_list = m.get('applyStatusList')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('receiptStatusList') is not None:
            self.receipt_status_list = m.get('receiptStatusList')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryReceiptForInvoiceResponseBodyListCreator(TeaModel):
    def __init__(
        self,
        avatar_url: str = None,
        nick: str = None,
        user_id: str = None,
    ):
        # 创建人头像
        self.avatar_url = avatar_url
        # 创建人昵称
        self.nick = nick
        # 创建人工号
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_url is not None:
            result['avatarUrl'] = self.avatar_url
        if self.nick is not None:
            result['nick'] = self.nick
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarUrl') is not None:
            self.avatar_url = m.get('avatarUrl')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryReceiptForInvoiceResponseBodyListCustomer(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
    ):
        # 客户code
        self.code = code
        # 客户名字
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryReceiptForInvoiceResponseBodyList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        apply_status: str = None,
        creator: QueryReceiptForInvoiceResponseBodyListCreator = None,
        customer: QueryReceiptForInvoiceResponseBodyListCustomer = None,
        invoice_type: str = None,
        model_id: str = None,
        purchaser_account: str = None,
        purchaser_address: str = None,
        purchaser_bank_name: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
        receipt_id: str = None,
        record_time: str = None,
        remark: str = None,
        source: str = None,
        status: str = None,
        title: str = None,
    ):
        # 金额
        self.amount = amount
        # 开票状态
        self.apply_status = apply_status
        # 创建人
        self.creator = creator
        # 客户
        self.customer = customer
        # 发票种类
        self.invoice_type = invoice_type
        # 主数据modelId
        self.model_id = model_id
        # 购方账户
        self.purchaser_account = purchaser_account
        # 购方地址
        self.purchaser_address = purchaser_address
        # 购方银行
        self.purchaser_bank_name = purchaser_bank_name
        # 购方抬头
        self.purchaser_name = purchaser_name
        # 购方税号
        self.purchaser_tax_no = purchaser_tax_no
        # 购方电话
        self.purchaser_tel = purchaser_tel
        # 单据ID
        self.receipt_id = receipt_id
        # 记录时间，默认为审批通过时间
        self.record_time = record_time
        # 备注
        self.remark = remark
        # 来源
        self.source = source
        # 状态 agree running
        self.status = status
        # 单据标题
        self.title = title

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.customer:
            self.customer.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.apply_status is not None:
            result['applyStatus'] = self.apply_status
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.customer is not None:
            result['customer'] = self.customer.to_map()
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.model_id is not None:
            result['modelId'] = self.model_id
        if self.purchaser_account is not None:
            result['purchaserAccount'] = self.purchaser_account
        if self.purchaser_address is not None:
            result['purchaserAddress'] = self.purchaser_address
        if self.purchaser_bank_name is not None:
            result['purchaserBankName'] = self.purchaser_bank_name
        if self.purchaser_name is not None:
            result['purchaserName'] = self.purchaser_name
        if self.purchaser_tax_no is not None:
            result['purchaserTaxNo'] = self.purchaser_tax_no
        if self.purchaser_tel is not None:
            result['purchaserTel'] = self.purchaser_tel
        if self.receipt_id is not None:
            result['receiptId'] = self.receipt_id
        if self.record_time is not None:
            result['recordTime'] = self.record_time
        if self.remark is not None:
            result['remark'] = self.remark
        if self.source is not None:
            result['source'] = self.source
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('applyStatus') is not None:
            self.apply_status = m.get('applyStatus')
        if m.get('creator') is not None:
            temp_model = QueryReceiptForInvoiceResponseBodyListCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('customer') is not None:
            temp_model = QueryReceiptForInvoiceResponseBodyListCustomer()
            self.customer = temp_model.from_map(m['customer'])
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('modelId') is not None:
            self.model_id = m.get('modelId')
        if m.get('purchaserAccount') is not None:
            self.purchaser_account = m.get('purchaserAccount')
        if m.get('purchaserAddress') is not None:
            self.purchaser_address = m.get('purchaserAddress')
        if m.get('purchaserBankName') is not None:
            self.purchaser_bank_name = m.get('purchaserBankName')
        if m.get('purchaserName') is not None:
            self.purchaser_name = m.get('purchaserName')
        if m.get('purchaserTaxNo') is not None:
            self.purchaser_tax_no = m.get('purchaserTaxNo')
        if m.get('purchaserTel') is not None:
            self.purchaser_tel = m.get('purchaserTel')
        if m.get('receiptId') is not None:
            self.receipt_id = m.get('receiptId')
        if m.get('recordTime') is not None:
            self.record_time = m.get('recordTime')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryReceiptForInvoiceResponseBody(TeaModel):
    def __init__(
        self,
        has_more: str = None,
        list: List[QueryReceiptForInvoiceResponseBodyList] = None,
        total_count: int = None,
    ):
        # 是否还有数据
        self.has_more = has_more
        # 分页数据
        self.list = list
        # 总数
        self.total_count = total_count

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryReceiptForInvoiceResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryReceiptForInvoiceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryReceiptForInvoiceResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryReceiptForInvoiceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryReceiptsBaseInfoHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryReceiptsBaseInfoRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        page_number: int = None,
        page_size: int = None,
        start_time: int = None,
        title: str = None,
        voucher_status: str = None,
    ):
        # 结束时间
        self.end_time = end_time
        # 分页参数，从1 开始
        self.page_number = page_number
        # 分页参数，每页查询个数
        self.page_size = page_size
        # 开始时间
        self.start_time = start_time
        # 单据标题
        self.title = title
        # 凭证状态
        self.voucher_status = voucher_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        if self.voucher_status is not None:
            result['voucherStatus'] = self.voucher_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('voucherStatus') is not None:
            self.voucher_status = m.get('voucherStatus')
        return self


class QueryReceiptsBaseInfoResponseBodyListCreator(TeaModel):
    def __init__(
        self,
        avatar_url: str = None,
        nick: str = None,
        user_id: str = None,
    ):
        # 创建人头像
        self.avatar_url = avatar_url
        # 创建人昵称
        self.nick = nick
        # 创建人工号
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_url is not None:
            result['avatarUrl'] = self.avatar_url
        if self.nick is not None:
            result['nick'] = self.nick
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarUrl') is not None:
            self.avatar_url = m.get('avatarUrl')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryReceiptsBaseInfoResponseBodyListCustomer(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
    ):
        # 客户code
        self.code = code
        # 客户名字
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryReceiptsBaseInfoResponseBodyListPrincipal(TeaModel):
    def __init__(
        self,
        avatar_url: str = None,
        nick: str = None,
        user_id: str = None,
    ):
        self.avatar_url = avatar_url
        self.nick = nick
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_url is not None:
            result['avatarUrl'] = self.avatar_url
        if self.nick is not None:
            result['nick'] = self.nick
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarUrl') is not None:
            self.avatar_url = m.get('avatarUrl')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryReceiptsBaseInfoResponseBodyListProject(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
    ):
        self.code = code
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryReceiptsBaseInfoResponseBodyListSupplier(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
    ):
        self.code = code
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryReceiptsBaseInfoResponseBodyList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        creator: QueryReceiptsBaseInfoResponseBodyListCreator = None,
        customer: QueryReceiptsBaseInfoResponseBodyListCustomer = None,
        model_id: str = None,
        principal: QueryReceiptsBaseInfoResponseBodyListPrincipal = None,
        project: QueryReceiptsBaseInfoResponseBodyListProject = None,
        receipt_id: str = None,
        record_time: str = None,
        remark: str = None,
        source: str = None,
        status: str = None,
        supplier: QueryReceiptsBaseInfoResponseBodyListSupplier = None,
        title: str = None,
        voucher_status: str = None,
    ):
        # 金额
        self.amount = amount
        # 创建人
        self.creator = creator
        # 客户
        self.customer = customer
        # 主数据modelId
        self.model_id = model_id
        self.principal = principal
        self.project = project
        # 单据ID
        self.receipt_id = receipt_id
        # 记录时间，默认为审批通过时间
        self.record_time = record_time
        # 备注
        self.remark = remark
        # 来源
        self.source = source
        # 状态 agree running
        self.status = status
        self.supplier = supplier
        # 单据标题
        self.title = title
        self.voucher_status = voucher_status

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.customer:
            self.customer.validate()
        if self.principal:
            self.principal.validate()
        if self.project:
            self.project.validate()
        if self.supplier:
            self.supplier.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.customer is not None:
            result['customer'] = self.customer.to_map()
        if self.model_id is not None:
            result['modelId'] = self.model_id
        if self.principal is not None:
            result['principal'] = self.principal.to_map()
        if self.project is not None:
            result['project'] = self.project.to_map()
        if self.receipt_id is not None:
            result['receiptId'] = self.receipt_id
        if self.record_time is not None:
            result['recordTime'] = self.record_time
        if self.remark is not None:
            result['remark'] = self.remark
        if self.source is not None:
            result['source'] = self.source
        if self.status is not None:
            result['status'] = self.status
        if self.supplier is not None:
            result['supplier'] = self.supplier.to_map()
        if self.title is not None:
            result['title'] = self.title
        if self.voucher_status is not None:
            result['voucherStatus'] = self.voucher_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('creator') is not None:
            temp_model = QueryReceiptsBaseInfoResponseBodyListCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('customer') is not None:
            temp_model = QueryReceiptsBaseInfoResponseBodyListCustomer()
            self.customer = temp_model.from_map(m['customer'])
        if m.get('modelId') is not None:
            self.model_id = m.get('modelId')
        if m.get('principal') is not None:
            temp_model = QueryReceiptsBaseInfoResponseBodyListPrincipal()
            self.principal = temp_model.from_map(m['principal'])
        if m.get('project') is not None:
            temp_model = QueryReceiptsBaseInfoResponseBodyListProject()
            self.project = temp_model.from_map(m['project'])
        if m.get('receiptId') is not None:
            self.receipt_id = m.get('receiptId')
        if m.get('recordTime') is not None:
            self.record_time = m.get('recordTime')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('supplier') is not None:
            temp_model = QueryReceiptsBaseInfoResponseBodyListSupplier()
            self.supplier = temp_model.from_map(m['supplier'])
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('voucherStatus') is not None:
            self.voucher_status = m.get('voucherStatus')
        return self


class QueryReceiptsBaseInfoResponseBody(TeaModel):
    def __init__(
        self,
        has_more: str = None,
        list: List[QueryReceiptsBaseInfoResponseBodyList] = None,
        total_count: int = None,
    ):
        # 是否还有数据
        self.has_more = has_more
        # 分页数据
        self.list = list
        # 总数
        self.total_count = total_count

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryReceiptsBaseInfoResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryReceiptsBaseInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryReceiptsBaseInfoResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryReceiptsBaseInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryReceiptsByPageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryReceiptsByPageRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        model_id: str = None,
        page_number: int = None,
        page_size: int = None,
        start_time: int = None,
        time_filter_field: str = None,
    ):
        # 检索结束时间，默认当前时间，离开始时间最长不超过180天
        self.end_time = end_time
        # 数据模型id
        self.model_id = model_id
        # 分页，从1开始
        self.page_number = page_number
        # 分页大小，默认10，最大100
        self.page_size = page_size
        # 检索开始时间
        self.start_time = start_time
        # 检索排序时间类型：创建时间(gmt_create)，更新时间(gmt_modified)
        self.time_filter_field = time_filter_field

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.model_id is not None:
            result['modelId'] = self.model_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.time_filter_field is not None:
            result['timeFilterField'] = self.time_filter_field
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('modelId') is not None:
            self.model_id = m.get('modelId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('timeFilterField') is not None:
            self.time_filter_field = m.get('timeFilterField')
        return self


class QueryReceiptsByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        data: str = None,
        model_id: str = None,
        source: str = None,
    ):
        # 数据来源于开放时，对应的微应用id
        self.app_id = app_id
        # 单据数据体json
        self.data = data
        # 模型id
        self.model_id = model_id
        # 数据来源：审批(approval)，开放接口(openapi)
        self.source = source

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.data is not None:
            result['data'] = self.data
        if self.model_id is not None:
            result['modelId'] = self.model_id
        if self.source is not None:
            result['source'] = self.source
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('modelId') is not None:
            self.model_id = m.get('modelId')
        if m.get('source') is not None:
            self.source = m.get('source')
        return self


class QueryReceiptsByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: str = None,
        list: List[QueryReceiptsByPageResponseBodyList] = None,
    ):
        # 是否还有更多数据
        self.has_more = has_more
        # 数据列表
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryReceiptsByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryReceiptsByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryReceiptsByPageResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryReceiptsByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySupplierByPageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QuerySupplierByPageRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # 分页，从1开始
        self.page_number = page_number
        # 分页大小，默认10
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QuerySupplierByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        code: str = None,
        create_time: int = None,
        description: str = None,
        name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        # 供应商Code
        self.code = code
        # 创建时间(单位MS)
        self.create_time = create_time
        # 供应商描述
        self.description = description
        # 供应商名称
        self.name = name
        # 状态：启用(valid), 停用(invalid), 删除(deleted)
        self.status = status
        # 用户自定义code
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.status is not None:
            result['status'] = self.status
        if self.user_define_code is not None:
            result['userDefineCode'] = self.user_define_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class QuerySupplierByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QuerySupplierByPageResponseBodyList] = None,
    ):
        # 是否还有更多数据
        self.has_more = has_more
        # resultList
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QuerySupplierByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QuerySupplierByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QuerySupplierByPageResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QuerySupplierByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateApplyReceiptAndInvoiceRelatedHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        good_name: str = None,
        quantity: str = None,
        revenue_code: str = None,
        row_no: str = None,
        specification: str = None,
        tax_amount: str = None,
        tax_pre: str = None,
        tax_pre_type: str = None,
        tax_rate: str = None,
        unit: str = None,
        unit_price: str = None,
    ):
        # 金额
        self.amount = amount
        # 商品名称
        self.good_name = good_name
        # 数量
        self.quantity = quantity
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 规格型号
        self.specification = specification
        # 税额
        self.tax_amount = tax_amount
        # 是否享受税收优惠：0-不享受，1-享受
        self.tax_pre = tax_pre
        # 优惠政策类型
        self.tax_pre_type = tax_pre_type
        # 税率
        self.tax_rate = tax_rate
        # 单位
        self.unit = unit
        # 单价
        self.unit_price = unit_price

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.good_name is not None:
            result['goodName'] = self.good_name
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.specification is not None:
            result['specification'] = self.specification
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_pre is not None:
            result['taxPre'] = self.tax_pre
        if self.tax_pre_type is not None:
            result['taxPreType'] = self.tax_pre_type
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.unit is not None:
            result['unit'] = self.unit
        if self.unit_price is not None:
            result['unitPrice'] = self.unit_price
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('goodName') is not None:
            self.good_name = m.get('goodName')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxPre') is not None:
            self.tax_pre = m.get('taxPre')
        if m.get('taxPreType') is not None:
            self.tax_pre_type = m.get('taxPreType')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('unitPrice') is not None:
            self.unit_price = m.get('unitPrice')
        return self


class UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        card_no: str = None,
        end_date: str = None,
        goods_name: str = None,
        revenue_code: str = None,
        row_no: str = None,
        start_date: str = None,
        tax_amount: str = None,
        tax_rate: str = None,
        vehicle_type: str = None,
    ):
        # 金额
        self.amount = amount
        # 车牌号
        self.card_no = card_no
        # 通行日期止
        self.end_date = end_date
        # 商品名称
        self.goods_name = goods_name
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 通行日期起
        self.start_date = start_date
        # 税额
        self.tax_amount = tax_amount
        # 税率
        self.tax_rate = tax_rate
        # 类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        auction_unit: str = None,
        auction_unit_address: str = None,
        auction_unit_bank: str = None,
        auction_unit_tax_no: str = None,
        auction_util_tel: str = None,
        car_model: str = None,
        card_no: str = None,
        registration: str = None,
        transfer_vehicle: str = None,
        used_car_address: str = None,
        used_car_market: str = None,
        used_car_market_bank: str = None,
        used_car_market_phone: str = None,
        used_car_market_tax_no: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 经营、拍卖单位
        self.auction_unit = auction_unit
        # 经营、拍卖单位地址
        self.auction_unit_address = auction_unit_address
        # 经营、拍卖单位银行
        self.auction_unit_bank = auction_unit_bank
        # 经营、拍卖单位税号
        self.auction_unit_tax_no = auction_unit_tax_no
        # 经营、拍卖单位电话
        self.auction_util_tel = auction_util_tel
        # 厂牌型号
        self.car_model = car_model
        # 车牌照号
        self.card_no = card_no
        # 登记证号
        self.registration = registration
        # 转入地车辆管理所名称
        self.transfer_vehicle = transfer_vehicle
        # 二手车市场地址
        self.used_car_address = used_car_address
        # 二手车市场
        self.used_car_market = used_car_market
        # 二手车市场开户银行、账号
        self.used_car_market_bank = used_car_market_bank
        # 二手车市场电话
        self.used_car_market_phone = used_car_market_phone
        # 二手车市场纳税人识别号
        self.used_car_market_tax_no = used_car_market_tax_no
        # 车架号/车辆识别号
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auction_unit is not None:
            result['auctionUnit'] = self.auction_unit
        if self.auction_unit_address is not None:
            result['auctionUnitAddress'] = self.auction_unit_address
        if self.auction_unit_bank is not None:
            result['auctionUnitBank'] = self.auction_unit_bank
        if self.auction_unit_tax_no is not None:
            result['auctionUnitTaxNo'] = self.auction_unit_tax_no
        if self.auction_util_tel is not None:
            result['auctionUtilTel'] = self.auction_util_tel
        if self.car_model is not None:
            result['carModel'] = self.car_model
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.registration is not None:
            result['registration'] = self.registration
        if self.transfer_vehicle is not None:
            result['transferVehicle'] = self.transfer_vehicle
        if self.used_car_address is not None:
            result['usedCarAddress'] = self.used_car_address
        if self.used_car_market is not None:
            result['usedCarMarket'] = self.used_car_market
        if self.used_car_market_bank is not None:
            result['usedCarMarketBank'] = self.used_car_market_bank
        if self.used_car_market_phone is not None:
            result['usedCarMarketPhone'] = self.used_car_market_phone
        if self.used_car_market_tax_no is not None:
            result['usedCarMarketTaxNo'] = self.used_car_market_tax_no
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('auctionUnit') is not None:
            self.auction_unit = m.get('auctionUnit')
        if m.get('auctionUnitAddress') is not None:
            self.auction_unit_address = m.get('auctionUnitAddress')
        if m.get('auctionUnitBank') is not None:
            self.auction_unit_bank = m.get('auctionUnitBank')
        if m.get('auctionUnitTaxNo') is not None:
            self.auction_unit_tax_no = m.get('auctionUnitTaxNo')
        if m.get('auctionUtilTel') is not None:
            self.auction_util_tel = m.get('auctionUtilTel')
        if m.get('carModel') is not None:
            self.car_model = m.get('carModel')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('registration') is not None:
            self.registration = m.get('registration')
        if m.get('transferVehicle') is not None:
            self.transfer_vehicle = m.get('transferVehicle')
        if m.get('usedCarAddress') is not None:
            self.used_car_address = m.get('usedCarAddress')
        if m.get('usedCarMarket') is not None:
            self.used_car_market = m.get('usedCarMarket')
        if m.get('usedCarMarketBank') is not None:
            self.used_car_market_bank = m.get('usedCarMarketBank')
        if m.get('usedCarMarketPhone') is not None:
            self.used_car_market_phone = m.get('usedCarMarketPhone')
        if m.get('usedCarMarketTaxNo') is not None:
            self.used_car_market_tax_no = m.get('usedCarMarketTaxNo')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        brand: str = None,
        certificate_no: str = None,
        engine_no: str = None,
        id_card_no: str = None,
        import_certificate_no: str = None,
        inspection_list_no: str = None,
        max_passengers: str = None,
        origin_place: str = None,
        payment_voucher_no: str = None,
        tax_authority_name: str = None,
        tax_authority_no: str = None,
        tax_rate: str = None,
        tonnage: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 品牌
        self.brand = brand
        # 合格证号
        self.certificate_no = certificate_no
        # 发动机号
        self.engine_no = engine_no
        # 身份证号/组织机构代码
        self.id_card_no = id_card_no
        # 进口证书号
        self.import_certificate_no = import_certificate_no
        # 商检单号
        self.inspection_list_no = inspection_list_no
        # 限乘人数
        self.max_passengers = max_passengers
        # 产地
        self.origin_place = origin_place
        # 完税凭证号码
        self.payment_voucher_no = payment_voucher_no
        # 主管税务机关名称
        self.tax_authority_name = tax_authority_name
        # 主管税务机关代码
        self.tax_authority_no = tax_authority_no
        # 税率
        self.tax_rate = tax_rate
        # 吨位
        self.tonnage = tonnage
        # 车架号码
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.brand is not None:
            result['brand'] = self.brand
        if self.certificate_no is not None:
            result['certificateNo'] = self.certificate_no
        if self.engine_no is not None:
            result['engineNo'] = self.engine_no
        if self.id_card_no is not None:
            result['idCardNo'] = self.id_card_no
        if self.import_certificate_no is not None:
            result['importCertificateNo'] = self.import_certificate_no
        if self.inspection_list_no is not None:
            result['inspectionListNo'] = self.inspection_list_no
        if self.max_passengers is not None:
            result['maxPassengers'] = self.max_passengers
        if self.origin_place is not None:
            result['originPlace'] = self.origin_place
        if self.payment_voucher_no is not None:
            result['paymentVoucherNo'] = self.payment_voucher_no
        if self.tax_authority_name is not None:
            result['taxAuthorityName'] = self.tax_authority_name
        if self.tax_authority_no is not None:
            result['taxAuthorityNo'] = self.tax_authority_no
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.tonnage is not None:
            result['tonnage'] = self.tonnage
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('brand') is not None:
            self.brand = m.get('brand')
        if m.get('certificateNo') is not None:
            self.certificate_no = m.get('certificateNo')
        if m.get('engineNo') is not None:
            self.engine_no = m.get('engineNo')
        if m.get('idCardNo') is not None:
            self.id_card_no = m.get('idCardNo')
        if m.get('importCertificateNo') is not None:
            self.import_certificate_no = m.get('importCertificateNo')
        if m.get('inspectionListNo') is not None:
            self.inspection_list_no = m.get('inspectionListNo')
        if m.get('maxPassengers') is not None:
            self.max_passengers = m.get('maxPassengers')
        if m.get('originPlace') is not None:
            self.origin_place = m.get('originPlace')
        if m.get('paymentVoucherNo') is not None:
            self.payment_voucher_no = m.get('paymentVoucherNo')
        if m.get('taxAuthorityName') is not None:
            self.tax_authority_name = m.get('taxAuthorityName')
        if m.get('taxAuthorityNo') is not None:
            self.tax_authority_no = m.get('taxAuthorityNo')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('tonnage') is not None:
            self.tonnage = m.get('tonnage')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList(TeaModel):
    def __init__(
        self,
        account_period: str = None,
        amount: str = None,
        amount_with_tax: str = None,
        check_code: str = None,
        check_time: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        finance_type: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList] = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_type: str = None,
        machine_code: str = None,
        oil_flag: str = None,
        payee: str = None,
        process_inst_code: str = None,
        process_inst_type: str = None,
        purchaser_address: str = None,
        purchaser_bank_account: str = None,
        purchaser_bank_name_account: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
        remark: str = None,
        second_hand_car_invoice_detail_list: List[UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList] = None,
        seller_address: str = None,
        seller_bank_account: str = None,
        seller_bank_name_account: str = None,
        seller_name: str = None,
        seller_tax_no: str = None,
        seller_tel: str = None,
        status: str = None,
        supply_sign: str = None,
        tax_amount: str = None,
        used_vehicle_sale_detail_volist: List[UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        # 账期时间
        self.account_period = account_period
        # 不含税金额
        self.amount = amount
        # 含税金额
        self.amount_with_tax = amount_with_tax
        # 校验码
        self.check_code = check_code
        # 查验时间
        self.check_time = check_time
        # 开票日期
        self.drew_date = drew_date
        # 电票版式文件下载地址
        self.electronic_url = electronic_url
        # 财务类型，INPUT-VAT(进项),OUTPUT_VAT(销项)
        self.finance_type = finance_type
        # 资金类型 ，RED（红票），（BLUE）蓝票
        self.fund_type = fund_type
        # 常规发票明细
        self.general_invoice_detail_volist = general_invoice_detail_volist
        # 发票代码
        self.invoice_code = invoice_code
        # 发票号码
        self.invoice_no = invoice_no
        # 发票类型
        self.invoice_type = invoice_type
        # 机器码
        self.machine_code = machine_code
        # 成品油标识
        self.oil_flag = oil_flag
        # 收款人
        self.payee = payee
        # 审批单实例
        self.process_inst_code = process_inst_code
        # 审批单类型
        self.process_inst_type = process_inst_type
        # 购方地址
        self.purchaser_address = purchaser_address
        # 购方银行账户
        self.purchaser_bank_account = purchaser_bank_account
        # 购方银行名称
        self.purchaser_bank_name_account = purchaser_bank_name_account
        # 购方名称
        self.purchaser_name = purchaser_name
        # 购方税号
        self.purchaser_tax_no = purchaser_tax_no
        # 购方电话
        self.purchaser_tel = purchaser_tel
        # 备注
        self.remark = remark
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        # 销方地址
        self.seller_address = seller_address
        # 销方银行账户
        self.seller_bank_account = seller_bank_account
        # 销方银行名称
        self.seller_bank_name_account = seller_bank_name_account
        # 销方名称
        self.seller_name = seller_name
        # 销方税号
        self.seller_tax_no = seller_tax_no
        # 销方电话
        self.seller_tel = seller_tel
        # 发票状态
        self.status = status
        # 代开发票标识 1-自开，2-代开
        self.supply_sign = supply_sign
        # 税额
        self.tax_amount = tax_amount
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        # 发票查验状态
        self.verify_status = verify_status
        # 凭证code
        self.voucher_code = voucher_code
        # 生成凭证状态
        self.voucher_status = voucher_status

    def validate(self):
        if self.general_invoice_detail_volist:
            for k in self.general_invoice_detail_volist:
                if k:
                    k.validate()
        if self.second_hand_car_invoice_detail_list:
            for k in self.second_hand_car_invoice_detail_list:
                if k:
                    k.validate()
        if self.used_vehicle_sale_detail_volist:
            for k in self.used_vehicle_sale_detail_volist:
                if k:
                    k.validate()
        if self.vehicle_sale_detail_volist:
            for k in self.vehicle_sale_detail_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_period is not None:
            result['accountPeriod'] = self.account_period
        if self.amount is not None:
            result['amount'] = self.amount
        if self.amount_with_tax is not None:
            result['amountWithTax'] = self.amount_with_tax
        if self.check_code is not None:
            result['checkCode'] = self.check_code
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.drew_date is not None:
            result['drewDate'] = self.drew_date
        if self.electronic_url is not None:
            result['electronicUrl'] = self.electronic_url
        if self.finance_type is not None:
            result['financeType'] = self.finance_type
        if self.fund_type is not None:
            result['fundType'] = self.fund_type
        result['generalInvoiceDetailVOList'] = []
        if self.general_invoice_detail_volist is not None:
            for k in self.general_invoice_detail_volist:
                result['generalInvoiceDetailVOList'].append(k.to_map() if k else None)
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.machine_code is not None:
            result['machineCode'] = self.machine_code
        if self.oil_flag is not None:
            result['oilFlag'] = self.oil_flag
        if self.payee is not None:
            result['payee'] = self.payee
        if self.process_inst_code is not None:
            result['processInstCode'] = self.process_inst_code
        if self.process_inst_type is not None:
            result['processInstType'] = self.process_inst_type
        if self.purchaser_address is not None:
            result['purchaserAddress'] = self.purchaser_address
        if self.purchaser_bank_account is not None:
            result['purchaserBankAccount'] = self.purchaser_bank_account
        if self.purchaser_bank_name_account is not None:
            result['purchaserBankNameAccount'] = self.purchaser_bank_name_account
        if self.purchaser_name is not None:
            result['purchaserName'] = self.purchaser_name
        if self.purchaser_tax_no is not None:
            result['purchaserTaxNo'] = self.purchaser_tax_no
        if self.purchaser_tel is not None:
            result['purchaserTel'] = self.purchaser_tel
        if self.remark is not None:
            result['remark'] = self.remark
        result['secondHandCarInvoiceDetailList'] = []
        if self.second_hand_car_invoice_detail_list is not None:
            for k in self.second_hand_car_invoice_detail_list:
                result['secondHandCarInvoiceDetailList'].append(k.to_map() if k else None)
        if self.seller_address is not None:
            result['sellerAddress'] = self.seller_address
        if self.seller_bank_account is not None:
            result['sellerBankAccount'] = self.seller_bank_account
        if self.seller_bank_name_account is not None:
            result['sellerBankNameAccount'] = self.seller_bank_name_account
        if self.seller_name is not None:
            result['sellerName'] = self.seller_name
        if self.seller_tax_no is not None:
            result['sellerTaxNo'] = self.seller_tax_no
        if self.seller_tel is not None:
            result['sellerTel'] = self.seller_tel
        if self.status is not None:
            result['status'] = self.status
        if self.supply_sign is not None:
            result['supplySign'] = self.supply_sign
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        result['usedVehicleSaleDetailVOList'] = []
        if self.used_vehicle_sale_detail_volist is not None:
            for k in self.used_vehicle_sale_detail_volist:
                result['usedVehicleSaleDetailVOList'].append(k.to_map() if k else None)
        result['vehicleSaleDetailVOList'] = []
        if self.vehicle_sale_detail_volist is not None:
            for k in self.vehicle_sale_detail_volist:
                result['vehicleSaleDetailVOList'].append(k.to_map() if k else None)
        if self.verify_status is not None:
            result['verifyStatus'] = self.verify_status
        if self.voucher_code is not None:
            result['voucherCode'] = self.voucher_code
        if self.voucher_status is not None:
            result['voucherStatus'] = self.voucher_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountPeriod') is not None:
            self.account_period = m.get('accountPeriod')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('amountWithTax') is not None:
            self.amount_with_tax = m.get('amountWithTax')
        if m.get('checkCode') is not None:
            self.check_code = m.get('checkCode')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('drewDate') is not None:
            self.drew_date = m.get('drewDate')
        if m.get('electronicUrl') is not None:
            self.electronic_url = m.get('electronicUrl')
        if m.get('financeType') is not None:
            self.finance_type = m.get('financeType')
        if m.get('fundType') is not None:
            self.fund_type = m.get('fundType')
        self.general_invoice_detail_volist = []
        if m.get('generalInvoiceDetailVOList') is not None:
            for k in m.get('generalInvoiceDetailVOList'):
                temp_model = UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList()
                self.general_invoice_detail_volist.append(temp_model.from_map(k))
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('machineCode') is not None:
            self.machine_code = m.get('machineCode')
        if m.get('oilFlag') is not None:
            self.oil_flag = m.get('oilFlag')
        if m.get('payee') is not None:
            self.payee = m.get('payee')
        if m.get('processInstCode') is not None:
            self.process_inst_code = m.get('processInstCode')
        if m.get('processInstType') is not None:
            self.process_inst_type = m.get('processInstType')
        if m.get('purchaserAddress') is not None:
            self.purchaser_address = m.get('purchaserAddress')
        if m.get('purchaserBankAccount') is not None:
            self.purchaser_bank_account = m.get('purchaserBankAccount')
        if m.get('purchaserBankNameAccount') is not None:
            self.purchaser_bank_name_account = m.get('purchaserBankNameAccount')
        if m.get('purchaserName') is not None:
            self.purchaser_name = m.get('purchaserName')
        if m.get('purchaserTaxNo') is not None:
            self.purchaser_tax_no = m.get('purchaserTaxNo')
        if m.get('purchaserTel') is not None:
            self.purchaser_tel = m.get('purchaserTel')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        self.second_hand_car_invoice_detail_list = []
        if m.get('secondHandCarInvoiceDetailList') is not None:
            for k in m.get('secondHandCarInvoiceDetailList'):
                temp_model = UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList()
                self.second_hand_car_invoice_detail_list.append(temp_model.from_map(k))
        if m.get('sellerAddress') is not None:
            self.seller_address = m.get('sellerAddress')
        if m.get('sellerBankAccount') is not None:
            self.seller_bank_account = m.get('sellerBankAccount')
        if m.get('sellerBankNameAccount') is not None:
            self.seller_bank_name_account = m.get('sellerBankNameAccount')
        if m.get('sellerName') is not None:
            self.seller_name = m.get('sellerName')
        if m.get('sellerTaxNo') is not None:
            self.seller_tax_no = m.get('sellerTaxNo')
        if m.get('sellerTel') is not None:
            self.seller_tel = m.get('sellerTel')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('supplySign') is not None:
            self.supply_sign = m.get('supplySign')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        self.used_vehicle_sale_detail_volist = []
        if m.get('usedVehicleSaleDetailVOList') is not None:
            for k in m.get('usedVehicleSaleDetailVOList'):
                temp_model = UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList()
                self.used_vehicle_sale_detail_volist.append(temp_model.from_map(k))
        self.vehicle_sale_detail_volist = []
        if m.get('vehicleSaleDetailVOList') is not None:
            for k in m.get('vehicleSaleDetailVOList'):
                temp_model = UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList()
                self.vehicle_sale_detail_volist.append(temp_model.from_map(k))
        if m.get('verifyStatus') is not None:
            self.verify_status = m.get('verifyStatus')
        if m.get('voucherCode') is not None:
            self.voucher_code = m.get('voucherCode')
        if m.get('voucherStatus') is not None:
            self.voucher_status = m.get('voucherStatus')
        return self


class UpdateApplyReceiptAndInvoiceRelatedRequest(TeaModel):
    def __init__(
        self,
        general_invoice_volist: List[UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList] = None,
        instance_id: str = None,
        operator: str = None,
    ):
        # 发票模型
        self.general_invoice_volist = general_invoice_volist
        # 审批单id
        self.instance_id = instance_id
        # 操作员
        self.operator = operator

    def validate(self):
        if self.general_invoice_volist:
            for k in self.general_invoice_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['generalInvoiceVOList'] = []
        if self.general_invoice_volist is not None:
            for k in self.general_invoice_volist:
                result['generalInvoiceVOList'].append(k.to_map() if k else None)
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.general_invoice_volist = []
        if m.get('generalInvoiceVOList') is not None:
            for k in m.get('generalInvoiceVOList'):
                temp_model = UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList()
                self.general_invoice_volist.append(temp_model.from_map(k))
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList(TeaModel):
    def __init__(
        self,
        invoice_code: str = None,
        invoice_no: str = None,
    ):
        # 发票编码
        self.invoice_code = invoice_code
        # 发票号码
        self.invoice_no = invoice_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        return self


class UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse(TeaModel):
    def __init__(
        self,
        invoice_key_volist: List[UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList] = None,
    ):
        # 错误结果列表
        # 
        self.invoice_key_volist = invoice_key_volist

    def validate(self):
        if self.invoice_key_volist:
            for k in self.invoice_key_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['invoiceKeyVOList'] = []
        if self.invoice_key_volist is not None:
            for k in self.invoice_key_volist:
                result['invoiceKeyVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.invoice_key_volist = []
        if m.get('invoiceKeyVOList') is not None:
            for k in m.get('invoiceKeyVOList'):
                temp_model = UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList()
                self.invoice_key_volist.append(temp_model.from_map(k))
        return self


class UpdateApplyReceiptAndInvoiceRelatedResponseBody(TeaModel):
    def __init__(
        self,
        batch_update_invoice_response: UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse = None,
        success: bool = None,
    ):
        # 批量更新发票返回结果
        # 
        self.batch_update_invoice_response = batch_update_invoice_response
        # 是否成功
        self.success = success

    def validate(self):
        if self.batch_update_invoice_response:
            self.batch_update_invoice_response.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.batch_update_invoice_response is not None:
            result['batchUpdateInvoiceResponse'] = self.batch_update_invoice_response.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('batchUpdateInvoiceResponse') is not None:
            temp_model = UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse()
            self.batch_update_invoice_response = temp_model.from_map(m['batchUpdateInvoiceResponse'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateApplyReceiptAndInvoiceRelatedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateApplyReceiptAndInvoiceRelatedResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = UpdateApplyReceiptAndInvoiceRelatedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateFinanceCompanyInfoHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateFinanceCompanyInfoRequest(TeaModel):
    def __init__(
        self,
        company_name: str = None,
        tax_nature: str = None,
        tax_no: str = None,
        user_id: str = None,
    ):
        # 公司名字
        self.company_name = company_name
        # 纳税性质 小规模纳税人 一般纳税人
        self.tax_nature = tax_nature
        # 税号
        self.tax_no = tax_no
        # 用户ID
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_name is not None:
            result['companyName'] = self.company_name
        if self.tax_nature is not None:
            result['taxNature'] = self.tax_nature
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyName') is not None:
            self.company_name = m.get('companyName')
        if m.get('taxNature') is not None:
            self.tax_nature = m.get('taxNature')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateFinanceCompanyInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateFinanceCompanyInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateFinanceCompanyInfoResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = UpdateFinanceCompanyInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInvoiceAbandonStatusHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        good_name: str = None,
        quantity: str = None,
        revenue_code: str = None,
        row_no: str = None,
        specification: str = None,
        tax_amount: str = None,
        tax_pre: str = None,
        tax_pre_type: str = None,
        tax_rate: str = None,
        unit: str = None,
        unit_price: str = None,
    ):
        # 金额
        self.amount = amount
        # 商品名称
        self.good_name = good_name
        # 数量
        self.quantity = quantity
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 规格型号
        self.specification = specification
        # 税额
        self.tax_amount = tax_amount
        # 是否享受税收优惠：0-不享受，1-享受
        self.tax_pre = tax_pre
        # 优惠政策类型
        self.tax_pre_type = tax_pre_type
        # 税率
        self.tax_rate = tax_rate
        # 单位
        self.unit = unit
        # 单价
        self.unit_price = unit_price

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.good_name is not None:
            result['goodName'] = self.good_name
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.specification is not None:
            result['specification'] = self.specification
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_pre is not None:
            result['taxPre'] = self.tax_pre
        if self.tax_pre_type is not None:
            result['taxPreType'] = self.tax_pre_type
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.unit is not None:
            result['unit'] = self.unit
        if self.unit_price is not None:
            result['unitPrice'] = self.unit_price
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('goodName') is not None:
            self.good_name = m.get('goodName')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxPre') is not None:
            self.tax_pre = m.get('taxPre')
        if m.get('taxPreType') is not None:
            self.tax_pre_type = m.get('taxPreType')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('unitPrice') is not None:
            self.unit_price = m.get('unitPrice')
        return self


class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        card_no: str = None,
        end_date: str = None,
        goods_name: str = None,
        revenue_code: str = None,
        row_no: str = None,
        start_date: str = None,
        tax_amount: str = None,
        tax_rate: str = None,
        vehicle_type: str = None,
    ):
        # 金额
        self.amount = amount
        # 车牌号
        self.card_no = card_no
        # 通行日期止
        self.end_date = end_date
        # 商品名称
        self.goods_name = goods_name
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 通行日期起
        self.start_date = start_date
        # 税额
        self.tax_amount = tax_amount
        # 税率
        self.tax_rate = tax_rate
        # 类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        auction_unit: str = None,
        auction_unit_address: str = None,
        auction_unit_bank: str = None,
        auction_unit_tax_no: str = None,
        auction_util_tel: str = None,
        car_model: str = None,
        card_no: str = None,
        registration: str = None,
        transfer_vehicle: str = None,
        used_car_address: str = None,
        used_car_market: str = None,
        used_car_market_bank: str = None,
        used_car_market_phone: str = None,
        used_car_market_tax_no: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 经营、拍卖单位
        self.auction_unit = auction_unit
        # 经营、拍卖单位地址
        self.auction_unit_address = auction_unit_address
        # 经营、拍卖单位银行
        self.auction_unit_bank = auction_unit_bank
        # 经营、拍卖单位税号
        self.auction_unit_tax_no = auction_unit_tax_no
        # 经营、拍卖单位电话
        self.auction_util_tel = auction_util_tel
        # 厂牌型号
        self.car_model = car_model
        # 车牌照号
        self.card_no = card_no
        # 登记证号
        self.registration = registration
        # 转入地车辆管理所名称
        self.transfer_vehicle = transfer_vehicle
        # 二手车市场地址
        self.used_car_address = used_car_address
        # 二手车市场
        self.used_car_market = used_car_market
        # 二手车市场开户银行、账号
        self.used_car_market_bank = used_car_market_bank
        # 二手车市场电话
        self.used_car_market_phone = used_car_market_phone
        # 二手车市场纳税人识别号
        self.used_car_market_tax_no = used_car_market_tax_no
        # 车架号/车辆识别号
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auction_unit is not None:
            result['auctionUnit'] = self.auction_unit
        if self.auction_unit_address is not None:
            result['auctionUnitAddress'] = self.auction_unit_address
        if self.auction_unit_bank is not None:
            result['auctionUnitBank'] = self.auction_unit_bank
        if self.auction_unit_tax_no is not None:
            result['auctionUnitTaxNo'] = self.auction_unit_tax_no
        if self.auction_util_tel is not None:
            result['auctionUtilTel'] = self.auction_util_tel
        if self.car_model is not None:
            result['carModel'] = self.car_model
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.registration is not None:
            result['registration'] = self.registration
        if self.transfer_vehicle is not None:
            result['transferVehicle'] = self.transfer_vehicle
        if self.used_car_address is not None:
            result['usedCarAddress'] = self.used_car_address
        if self.used_car_market is not None:
            result['usedCarMarket'] = self.used_car_market
        if self.used_car_market_bank is not None:
            result['usedCarMarketBank'] = self.used_car_market_bank
        if self.used_car_market_phone is not None:
            result['usedCarMarketPhone'] = self.used_car_market_phone
        if self.used_car_market_tax_no is not None:
            result['usedCarMarketTaxNo'] = self.used_car_market_tax_no
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('auctionUnit') is not None:
            self.auction_unit = m.get('auctionUnit')
        if m.get('auctionUnitAddress') is not None:
            self.auction_unit_address = m.get('auctionUnitAddress')
        if m.get('auctionUnitBank') is not None:
            self.auction_unit_bank = m.get('auctionUnitBank')
        if m.get('auctionUnitTaxNo') is not None:
            self.auction_unit_tax_no = m.get('auctionUnitTaxNo')
        if m.get('auctionUtilTel') is not None:
            self.auction_util_tel = m.get('auctionUtilTel')
        if m.get('carModel') is not None:
            self.car_model = m.get('carModel')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('registration') is not None:
            self.registration = m.get('registration')
        if m.get('transferVehicle') is not None:
            self.transfer_vehicle = m.get('transferVehicle')
        if m.get('usedCarAddress') is not None:
            self.used_car_address = m.get('usedCarAddress')
        if m.get('usedCarMarket') is not None:
            self.used_car_market = m.get('usedCarMarket')
        if m.get('usedCarMarketBank') is not None:
            self.used_car_market_bank = m.get('usedCarMarketBank')
        if m.get('usedCarMarketPhone') is not None:
            self.used_car_market_phone = m.get('usedCarMarketPhone')
        if m.get('usedCarMarketTaxNo') is not None:
            self.used_car_market_tax_no = m.get('usedCarMarketTaxNo')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        brand: str = None,
        certificate_no: str = None,
        engine_no: str = None,
        id_card_no: str = None,
        import_certificate_no: str = None,
        inspection_list_no: str = None,
        max_passengers: str = None,
        origin_place: str = None,
        payment_voucher_no: str = None,
        tax_authority_name: str = None,
        tax_authority_no: str = None,
        tax_rate: str = None,
        tonnage: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 品牌
        self.brand = brand
        # 合格证号
        self.certificate_no = certificate_no
        # 发动机号
        self.engine_no = engine_no
        # 身份证号/组织机构代码
        self.id_card_no = id_card_no
        # 进口证书号
        self.import_certificate_no = import_certificate_no
        self.inspection_list_no = inspection_list_no
        # 限乘人数
        self.max_passengers = max_passengers
        # 产地
        self.origin_place = origin_place
        # 完税凭证号码
        self.payment_voucher_no = payment_voucher_no
        # 主管税务机关名称
        self.tax_authority_name = tax_authority_name
        # 主管税务机关代码
        self.tax_authority_no = tax_authority_no
        # 税率
        self.tax_rate = tax_rate
        # 吨位
        self.tonnage = tonnage
        # 车架号码
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.brand is not None:
            result['brand'] = self.brand
        if self.certificate_no is not None:
            result['certificateNo'] = self.certificate_no
        if self.engine_no is not None:
            result['engineNo'] = self.engine_no
        if self.id_card_no is not None:
            result['idCardNo'] = self.id_card_no
        if self.import_certificate_no is not None:
            result['importCertificateNo'] = self.import_certificate_no
        if self.inspection_list_no is not None:
            result['inspectionListNo'] = self.inspection_list_no
        if self.max_passengers is not None:
            result['maxPassengers'] = self.max_passengers
        if self.origin_place is not None:
            result['originPlace'] = self.origin_place
        if self.payment_voucher_no is not None:
            result['paymentVoucherNo'] = self.payment_voucher_no
        if self.tax_authority_name is not None:
            result['taxAuthorityName'] = self.tax_authority_name
        if self.tax_authority_no is not None:
            result['taxAuthorityNo'] = self.tax_authority_no
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.tonnage is not None:
            result['tonnage'] = self.tonnage
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('brand') is not None:
            self.brand = m.get('brand')
        if m.get('certificateNo') is not None:
            self.certificate_no = m.get('certificateNo')
        if m.get('engineNo') is not None:
            self.engine_no = m.get('engineNo')
        if m.get('idCardNo') is not None:
            self.id_card_no = m.get('idCardNo')
        if m.get('importCertificateNo') is not None:
            self.import_certificate_no = m.get('importCertificateNo')
        if m.get('inspectionListNo') is not None:
            self.inspection_list_no = m.get('inspectionListNo')
        if m.get('maxPassengers') is not None:
            self.max_passengers = m.get('maxPassengers')
        if m.get('originPlace') is not None:
            self.origin_place = m.get('originPlace')
        if m.get('paymentVoucherNo') is not None:
            self.payment_voucher_no = m.get('paymentVoucherNo')
        if m.get('taxAuthorityName') is not None:
            self.tax_authority_name = m.get('taxAuthorityName')
        if m.get('taxAuthorityNo') is not None:
            self.tax_authority_no = m.get('taxAuthorityNo')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('tonnage') is not None:
            self.tonnage = m.get('tonnage')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO(TeaModel):
    def __init__(
        self,
        account_period: str = None,
        amount: str = None,
        amount_with_tax: str = None,
        check_code: str = None,
        check_time: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        finance_type: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList] = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_type: str = None,
        machine_code: str = None,
        oil_flag: str = None,
        payee: str = None,
        process_inst_code: str = None,
        process_inst_type: str = None,
        purchaser_address: str = None,
        purchaser_bank_account: str = None,
        purchaser_bank_name_account: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
        remark: str = None,
        second_hand_car_invoice_detail_list: List[UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList] = None,
        seller_address: str = None,
        seller_bank_account: str = None,
        seller_bank_name_account: str = None,
        seller_name: str = None,
        seller_tax_no: str = None,
        seller_tel: str = None,
        status: str = None,
        supply_sign: str = None,
        tax_amount: str = None,
        used_vehicle_sale_detail_volist: List[UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        # 账期时间
        self.account_period = account_period
        # 不含税金额
        self.amount = amount
        # 含税金额
        self.amount_with_tax = amount_with_tax
        # 校验码
        self.check_code = check_code
        # 查验时间
        self.check_time = check_time
        # 开票日期
        self.drew_date = drew_date
        # 电票版式文件下载地址
        self.electronic_url = electronic_url
        # 财务类型，INPUT-VAT(进项),OUTPUT_VAT(销项)
        self.finance_type = finance_type
        # 资金类型 ，RED（红票），（BLUE）蓝票
        self.fund_type = fund_type
        # 常规发票明细
        self.general_invoice_detail_volist = general_invoice_detail_volist
        # 发票代码
        self.invoice_code = invoice_code
        # 发票号码
        self.invoice_no = invoice_no
        # 发票类型
        self.invoice_type = invoice_type
        # 机器码
        self.machine_code = machine_code
        # 成品油标识
        self.oil_flag = oil_flag
        # 收款人
        self.payee = payee
        # 审批单实例
        self.process_inst_code = process_inst_code
        # 审批单类型
        self.process_inst_type = process_inst_type
        # 购方地址
        self.purchaser_address = purchaser_address
        # 购方银行账户
        self.purchaser_bank_account = purchaser_bank_account
        # 购方银行名称
        self.purchaser_bank_name_account = purchaser_bank_name_account
        # 购方名称
        self.purchaser_name = purchaser_name
        # 购方税号
        self.purchaser_tax_no = purchaser_tax_no
        # 购方电话
        self.purchaser_tel = purchaser_tel
        # 备注
        self.remark = remark
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        # 销方地址
        self.seller_address = seller_address
        # 销方银行账户
        self.seller_bank_account = seller_bank_account
        # 销方银行
        self.seller_bank_name_account = seller_bank_name_account
        # 销方名称
        self.seller_name = seller_name
        # 销方税号
        self.seller_tax_no = seller_tax_no
        # 销方电话
        self.seller_tel = seller_tel
        # 发票状态
        self.status = status
        # 代开发票标识 1-自开，2-代开
        self.supply_sign = supply_sign
        # 税额
        self.tax_amount = tax_amount
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        # 发票查验状态
        self.verify_status = verify_status
        # 凭证code
        self.voucher_code = voucher_code
        # 生成凭证状态
        self.voucher_status = voucher_status

    def validate(self):
        if self.general_invoice_detail_volist:
            for k in self.general_invoice_detail_volist:
                if k:
                    k.validate()
        if self.second_hand_car_invoice_detail_list:
            for k in self.second_hand_car_invoice_detail_list:
                if k:
                    k.validate()
        if self.used_vehicle_sale_detail_volist:
            for k in self.used_vehicle_sale_detail_volist:
                if k:
                    k.validate()
        if self.vehicle_sale_detail_volist:
            for k in self.vehicle_sale_detail_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_period is not None:
            result['accountPeriod'] = self.account_period
        if self.amount is not None:
            result['amount'] = self.amount
        if self.amount_with_tax is not None:
            result['amountWithTax'] = self.amount_with_tax
        if self.check_code is not None:
            result['checkCode'] = self.check_code
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.drew_date is not None:
            result['drewDate'] = self.drew_date
        if self.electronic_url is not None:
            result['electronicUrl'] = self.electronic_url
        if self.finance_type is not None:
            result['financeType'] = self.finance_type
        if self.fund_type is not None:
            result['fundType'] = self.fund_type
        result['generalInvoiceDetailVOList'] = []
        if self.general_invoice_detail_volist is not None:
            for k in self.general_invoice_detail_volist:
                result['generalInvoiceDetailVOList'].append(k.to_map() if k else None)
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.machine_code is not None:
            result['machineCode'] = self.machine_code
        if self.oil_flag is not None:
            result['oilFlag'] = self.oil_flag
        if self.payee is not None:
            result['payee'] = self.payee
        if self.process_inst_code is not None:
            result['processInstCode'] = self.process_inst_code
        if self.process_inst_type is not None:
            result['processInstType'] = self.process_inst_type
        if self.purchaser_address is not None:
            result['purchaserAddress'] = self.purchaser_address
        if self.purchaser_bank_account is not None:
            result['purchaserBankAccount'] = self.purchaser_bank_account
        if self.purchaser_bank_name_account is not None:
            result['purchaserBankNameAccount'] = self.purchaser_bank_name_account
        if self.purchaser_name is not None:
            result['purchaserName'] = self.purchaser_name
        if self.purchaser_tax_no is not None:
            result['purchaserTaxNo'] = self.purchaser_tax_no
        if self.purchaser_tel is not None:
            result['purchaserTel'] = self.purchaser_tel
        if self.remark is not None:
            result['remark'] = self.remark
        result['secondHandCarInvoiceDetailList'] = []
        if self.second_hand_car_invoice_detail_list is not None:
            for k in self.second_hand_car_invoice_detail_list:
                result['secondHandCarInvoiceDetailList'].append(k.to_map() if k else None)
        if self.seller_address is not None:
            result['sellerAddress'] = self.seller_address
        if self.seller_bank_account is not None:
            result['sellerBankAccount'] = self.seller_bank_account
        if self.seller_bank_name_account is not None:
            result['sellerBankNameAccount'] = self.seller_bank_name_account
        if self.seller_name is not None:
            result['sellerName'] = self.seller_name
        if self.seller_tax_no is not None:
            result['sellerTaxNo'] = self.seller_tax_no
        if self.seller_tel is not None:
            result['sellerTel'] = self.seller_tel
        if self.status is not None:
            result['status'] = self.status
        if self.supply_sign is not None:
            result['supplySign'] = self.supply_sign
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        result['usedVehicleSaleDetailVOList'] = []
        if self.used_vehicle_sale_detail_volist is not None:
            for k in self.used_vehicle_sale_detail_volist:
                result['usedVehicleSaleDetailVOList'].append(k.to_map() if k else None)
        result['vehicleSaleDetailVOList'] = []
        if self.vehicle_sale_detail_volist is not None:
            for k in self.vehicle_sale_detail_volist:
                result['vehicleSaleDetailVOList'].append(k.to_map() if k else None)
        if self.verify_status is not None:
            result['verifyStatus'] = self.verify_status
        if self.voucher_code is not None:
            result['voucherCode'] = self.voucher_code
        if self.voucher_status is not None:
            result['voucherStatus'] = self.voucher_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountPeriod') is not None:
            self.account_period = m.get('accountPeriod')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('amountWithTax') is not None:
            self.amount_with_tax = m.get('amountWithTax')
        if m.get('checkCode') is not None:
            self.check_code = m.get('checkCode')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('drewDate') is not None:
            self.drew_date = m.get('drewDate')
        if m.get('electronicUrl') is not None:
            self.electronic_url = m.get('electronicUrl')
        if m.get('financeType') is not None:
            self.finance_type = m.get('financeType')
        if m.get('fundType') is not None:
            self.fund_type = m.get('fundType')
        self.general_invoice_detail_volist = []
        if m.get('generalInvoiceDetailVOList') is not None:
            for k in m.get('generalInvoiceDetailVOList'):
                temp_model = UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList()
                self.general_invoice_detail_volist.append(temp_model.from_map(k))
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('machineCode') is not None:
            self.machine_code = m.get('machineCode')
        if m.get('oilFlag') is not None:
            self.oil_flag = m.get('oilFlag')
        if m.get('payee') is not None:
            self.payee = m.get('payee')
        if m.get('processInstCode') is not None:
            self.process_inst_code = m.get('processInstCode')
        if m.get('processInstType') is not None:
            self.process_inst_type = m.get('processInstType')
        if m.get('purchaserAddress') is not None:
            self.purchaser_address = m.get('purchaserAddress')
        if m.get('purchaserBankAccount') is not None:
            self.purchaser_bank_account = m.get('purchaserBankAccount')
        if m.get('purchaserBankNameAccount') is not None:
            self.purchaser_bank_name_account = m.get('purchaserBankNameAccount')
        if m.get('purchaserName') is not None:
            self.purchaser_name = m.get('purchaserName')
        if m.get('purchaserTaxNo') is not None:
            self.purchaser_tax_no = m.get('purchaserTaxNo')
        if m.get('purchaserTel') is not None:
            self.purchaser_tel = m.get('purchaserTel')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        self.second_hand_car_invoice_detail_list = []
        if m.get('secondHandCarInvoiceDetailList') is not None:
            for k in m.get('secondHandCarInvoiceDetailList'):
                temp_model = UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList()
                self.second_hand_car_invoice_detail_list.append(temp_model.from_map(k))
        if m.get('sellerAddress') is not None:
            self.seller_address = m.get('sellerAddress')
        if m.get('sellerBankAccount') is not None:
            self.seller_bank_account = m.get('sellerBankAccount')
        if m.get('sellerBankNameAccount') is not None:
            self.seller_bank_name_account = m.get('sellerBankNameAccount')
        if m.get('sellerName') is not None:
            self.seller_name = m.get('sellerName')
        if m.get('sellerTaxNo') is not None:
            self.seller_tax_no = m.get('sellerTaxNo')
        if m.get('sellerTel') is not None:
            self.seller_tel = m.get('sellerTel')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('supplySign') is not None:
            self.supply_sign = m.get('supplySign')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        self.used_vehicle_sale_detail_volist = []
        if m.get('usedVehicleSaleDetailVOList') is not None:
            for k in m.get('usedVehicleSaleDetailVOList'):
                temp_model = UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList()
                self.used_vehicle_sale_detail_volist.append(temp_model.from_map(k))
        self.vehicle_sale_detail_volist = []
        if m.get('vehicleSaleDetailVOList') is not None:
            for k in m.get('vehicleSaleDetailVOList'):
                temp_model = UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList()
                self.vehicle_sale_detail_volist.append(temp_model.from_map(k))
        if m.get('verifyStatus') is not None:
            self.verify_status = m.get('verifyStatus')
        if m.get('voucherCode') is not None:
            self.voucher_code = m.get('voucherCode')
        if m.get('voucherStatus') is not None:
            self.voucher_status = m.get('voucherStatus')
        return self


class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        good_name: str = None,
        quantity: str = None,
        revenue_code: str = None,
        row_no: str = None,
        specification: str = None,
        tax_amount: str = None,
        tax_pre: str = None,
        tax_pre_type: str = None,
        tax_rate: str = None,
        unit: str = None,
        unit_price: str = None,
    ):
        # 金额
        self.amount = amount
        # 商品名称
        self.good_name = good_name
        # 数量
        self.quantity = quantity
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 规格型号
        self.specification = specification
        # 税额
        self.tax_amount = tax_amount
        # 是否享受税收优惠：0-不享受，1-享受
        self.tax_pre = tax_pre
        # 优惠政策类型
        self.tax_pre_type = tax_pre_type
        # 税率
        self.tax_rate = tax_rate
        # 单位
        self.unit = unit
        # 单价
        self.unit_price = unit_price

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.good_name is not None:
            result['goodName'] = self.good_name
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.specification is not None:
            result['specification'] = self.specification
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_pre is not None:
            result['taxPre'] = self.tax_pre
        if self.tax_pre_type is not None:
            result['taxPreType'] = self.tax_pre_type
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.unit is not None:
            result['unit'] = self.unit
        if self.unit_price is not None:
            result['unitPrice'] = self.unit_price
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('goodName') is not None:
            self.good_name = m.get('goodName')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxPre') is not None:
            self.tax_pre = m.get('taxPre')
        if m.get('taxPreType') is not None:
            self.tax_pre_type = m.get('taxPreType')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('unitPrice') is not None:
            self.unit_price = m.get('unitPrice')
        return self


class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        card_no: str = None,
        end_date: str = None,
        goods_name: str = None,
        revenue_code: str = None,
        row_no: str = None,
        start_date: str = None,
        tax_amount: str = None,
        tax_rate: str = None,
        vehicle_type: str = None,
    ):
        # 金额
        self.amount = amount
        # 车牌号
        self.card_no = card_no
        # 通行日期止
        self.end_date = end_date
        # 商品名称
        self.goods_name = goods_name
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 通行日期起
        self.start_date = start_date
        # 税额
        self.tax_amount = tax_amount
        # 税率
        self.tax_rate = tax_rate
        # 类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        auction_unit: str = None,
        auction_unit_address: str = None,
        auction_unit_bank: str = None,
        auction_unit_tax_no: str = None,
        auction_util_tel: str = None,
        car_model: str = None,
        card_no: str = None,
        registration: str = None,
        transfer_vehicle: str = None,
        used_car_address: str = None,
        used_car_market: str = None,
        used_car_market_bank: str = None,
        used_car_market_phone: str = None,
        used_car_market_tax_no: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 经营、拍卖单位
        self.auction_unit = auction_unit
        # 经营、拍卖单位地址
        self.auction_unit_address = auction_unit_address
        # 经营、拍卖单位银行
        self.auction_unit_bank = auction_unit_bank
        # 经营、拍卖单位税号
        self.auction_unit_tax_no = auction_unit_tax_no
        # 经营、拍卖单位电话
        self.auction_util_tel = auction_util_tel
        # 厂牌型号
        self.car_model = car_model
        # 车牌照号
        self.card_no = card_no
        # 登记证号
        self.registration = registration
        # 转入地车辆管理所名称
        self.transfer_vehicle = transfer_vehicle
        # 二手车市场地址
        self.used_car_address = used_car_address
        # 二手车市场
        self.used_car_market = used_car_market
        # 二手车市场开户银行、账号
        self.used_car_market_bank = used_car_market_bank
        # 二手车市场电话
        self.used_car_market_phone = used_car_market_phone
        # 二手车市场纳税人识别号
        self.used_car_market_tax_no = used_car_market_tax_no
        # 车架号/车辆识别号
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auction_unit is not None:
            result['auctionUnit'] = self.auction_unit
        if self.auction_unit_address is not None:
            result['auctionUnitAddress'] = self.auction_unit_address
        if self.auction_unit_bank is not None:
            result['auctionUnitBank'] = self.auction_unit_bank
        if self.auction_unit_tax_no is not None:
            result['auctionUnitTaxNo'] = self.auction_unit_tax_no
        if self.auction_util_tel is not None:
            result['auctionUtilTel'] = self.auction_util_tel
        if self.car_model is not None:
            result['carModel'] = self.car_model
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.registration is not None:
            result['registration'] = self.registration
        if self.transfer_vehicle is not None:
            result['transferVehicle'] = self.transfer_vehicle
        if self.used_car_address is not None:
            result['usedCarAddress'] = self.used_car_address
        if self.used_car_market is not None:
            result['usedCarMarket'] = self.used_car_market
        if self.used_car_market_bank is not None:
            result['usedCarMarketBank'] = self.used_car_market_bank
        if self.used_car_market_phone is not None:
            result['usedCarMarketPhone'] = self.used_car_market_phone
        if self.used_car_market_tax_no is not None:
            result['usedCarMarketTaxNo'] = self.used_car_market_tax_no
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('auctionUnit') is not None:
            self.auction_unit = m.get('auctionUnit')
        if m.get('auctionUnitAddress') is not None:
            self.auction_unit_address = m.get('auctionUnitAddress')
        if m.get('auctionUnitBank') is not None:
            self.auction_unit_bank = m.get('auctionUnitBank')
        if m.get('auctionUnitTaxNo') is not None:
            self.auction_unit_tax_no = m.get('auctionUnitTaxNo')
        if m.get('auctionUtilTel') is not None:
            self.auction_util_tel = m.get('auctionUtilTel')
        if m.get('carModel') is not None:
            self.car_model = m.get('carModel')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('registration') is not None:
            self.registration = m.get('registration')
        if m.get('transferVehicle') is not None:
            self.transfer_vehicle = m.get('transferVehicle')
        if m.get('usedCarAddress') is not None:
            self.used_car_address = m.get('usedCarAddress')
        if m.get('usedCarMarket') is not None:
            self.used_car_market = m.get('usedCarMarket')
        if m.get('usedCarMarketBank') is not None:
            self.used_car_market_bank = m.get('usedCarMarketBank')
        if m.get('usedCarMarketPhone') is not None:
            self.used_car_market_phone = m.get('usedCarMarketPhone')
        if m.get('usedCarMarketTaxNo') is not None:
            self.used_car_market_tax_no = m.get('usedCarMarketTaxNo')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        brand: str = None,
        certificate_no: str = None,
        engine_no: str = None,
        id_card_no: str = None,
        import_certificate_no: str = None,
        inspection_list_no: str = None,
        max_passengers: str = None,
        origin_place: str = None,
        payment_voucher_no: str = None,
        tax_authority_name: str = None,
        tax_authority_no: str = None,
        tax_rate: str = None,
        tonnage: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 品牌
        self.brand = brand
        # 合格证号
        self.certificate_no = certificate_no
        # 发动机号
        self.engine_no = engine_no
        # 身份证号/组织机构代码
        self.id_card_no = id_card_no
        # 进口证书号
        self.import_certificate_no = import_certificate_no
        # 商检单号
        self.inspection_list_no = inspection_list_no
        # 限乘人数
        self.max_passengers = max_passengers
        # 产地
        self.origin_place = origin_place
        # 完税凭证号码
        self.payment_voucher_no = payment_voucher_no
        # 主管税务机关名称
        self.tax_authority_name = tax_authority_name
        # 主管税务机关代码
        self.tax_authority_no = tax_authority_no
        # 税率
        self.tax_rate = tax_rate
        # 吨位
        self.tonnage = tonnage
        # 车架号码
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.brand is not None:
            result['brand'] = self.brand
        if self.certificate_no is not None:
            result['certificateNo'] = self.certificate_no
        if self.engine_no is not None:
            result['engineNo'] = self.engine_no
        if self.id_card_no is not None:
            result['idCardNo'] = self.id_card_no
        if self.import_certificate_no is not None:
            result['importCertificateNo'] = self.import_certificate_no
        if self.inspection_list_no is not None:
            result['inspectionListNo'] = self.inspection_list_no
        if self.max_passengers is not None:
            result['maxPassengers'] = self.max_passengers
        if self.origin_place is not None:
            result['originPlace'] = self.origin_place
        if self.payment_voucher_no is not None:
            result['paymentVoucherNo'] = self.payment_voucher_no
        if self.tax_authority_name is not None:
            result['taxAuthorityName'] = self.tax_authority_name
        if self.tax_authority_no is not None:
            result['taxAuthorityNo'] = self.tax_authority_no
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.tonnage is not None:
            result['tonnage'] = self.tonnage
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('brand') is not None:
            self.brand = m.get('brand')
        if m.get('certificateNo') is not None:
            self.certificate_no = m.get('certificateNo')
        if m.get('engineNo') is not None:
            self.engine_no = m.get('engineNo')
        if m.get('idCardNo') is not None:
            self.id_card_no = m.get('idCardNo')
        if m.get('importCertificateNo') is not None:
            self.import_certificate_no = m.get('importCertificateNo')
        if m.get('inspectionListNo') is not None:
            self.inspection_list_no = m.get('inspectionListNo')
        if m.get('maxPassengers') is not None:
            self.max_passengers = m.get('maxPassengers')
        if m.get('originPlace') is not None:
            self.origin_place = m.get('originPlace')
        if m.get('paymentVoucherNo') is not None:
            self.payment_voucher_no = m.get('paymentVoucherNo')
        if m.get('taxAuthorityName') is not None:
            self.tax_authority_name = m.get('taxAuthorityName')
        if m.get('taxAuthorityNo') is not None:
            self.tax_authority_no = m.get('taxAuthorityNo')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('tonnage') is not None:
            self.tonnage = m.get('tonnage')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO(TeaModel):
    def __init__(
        self,
        account_period: str = None,
        amount: str = None,
        amount_with_tax: str = None,
        check_code: str = None,
        check_time: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        finance_type: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList] = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_type: str = None,
        machine_code: str = None,
        oil_flag: str = None,
        payee: str = None,
        process_inst_code: str = None,
        process_inst_type: str = None,
        purchaser_address: str = None,
        purchaser_bank_account: str = None,
        purchaser_bank_name_account: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
        remark: str = None,
        second_hand_car_invoice_detail_list: List[UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList] = None,
        seller_address: str = None,
        seller_bank_account: str = None,
        seller_bank_name_account: str = None,
        seller_name: str = None,
        seller_tax_no: str = None,
        seller_tel: str = None,
        status: str = None,
        supply_sign: str = None,
        tax_amount: str = None,
        used_vehicle_sale_detail_volist: List[UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        # 账期时间
        self.account_period = account_period
        # 不含税金额
        self.amount = amount
        # 含税金额
        self.amount_with_tax = amount_with_tax
        # 校验码
        self.check_code = check_code
        # 查验时间
        self.check_time = check_time
        # 开票日期
        self.drew_date = drew_date
        # 电票版式文件下载地址
        self.electronic_url = electronic_url
        # 财务类型，INPUT-VAT(进项),OUTPUT_VAT(销项)
        self.finance_type = finance_type
        # 资金类型 ，RED（红票），（BLUE）蓝票
        self.fund_type = fund_type
        # 常规发票明细
        self.general_invoice_detail_volist = general_invoice_detail_volist
        # 发票代码
        self.invoice_code = invoice_code
        # 发票号码
        self.invoice_no = invoice_no
        # 发票类型
        self.invoice_type = invoice_type
        # 机器码
        self.machine_code = machine_code
        # 成品油标识
        self.oil_flag = oil_flag
        # 收款人
        self.payee = payee
        # 审批单实例
        self.process_inst_code = process_inst_code
        # 审批单类型
        self.process_inst_type = process_inst_type
        # 购方地址
        self.purchaser_address = purchaser_address
        # 购方银行账户
        self.purchaser_bank_account = purchaser_bank_account
        # 购方银行
        self.purchaser_bank_name_account = purchaser_bank_name_account
        # 购方名称
        self.purchaser_name = purchaser_name
        # 购方税号
        self.purchaser_tax_no = purchaser_tax_no
        # 购方电话
        self.purchaser_tel = purchaser_tel
        # 备注
        self.remark = remark
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        # 销方地址
        self.seller_address = seller_address
        # 购方银行账户
        self.seller_bank_account = seller_bank_account
        # 销方银行
        self.seller_bank_name_account = seller_bank_name_account
        # 销方名称
        self.seller_name = seller_name
        # 销方税号
        self.seller_tax_no = seller_tax_no
        # 销方电话
        self.seller_tel = seller_tel
        # 发票状态
        self.status = status
        # 代开发票标识 1-自开，2-代开
        self.supply_sign = supply_sign
        # 税额
        self.tax_amount = tax_amount
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        # 发票查验状态
        self.verify_status = verify_status
        # 凭证code
        self.voucher_code = voucher_code
        # 生成凭证状态
        self.voucher_status = voucher_status

    def validate(self):
        if self.general_invoice_detail_volist:
            for k in self.general_invoice_detail_volist:
                if k:
                    k.validate()
        if self.second_hand_car_invoice_detail_list:
            for k in self.second_hand_car_invoice_detail_list:
                if k:
                    k.validate()
        if self.used_vehicle_sale_detail_volist:
            for k in self.used_vehicle_sale_detail_volist:
                if k:
                    k.validate()
        if self.vehicle_sale_detail_volist:
            for k in self.vehicle_sale_detail_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_period is not None:
            result['accountPeriod'] = self.account_period
        if self.amount is not None:
            result['amount'] = self.amount
        if self.amount_with_tax is not None:
            result['amountWithTax'] = self.amount_with_tax
        if self.check_code is not None:
            result['checkCode'] = self.check_code
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.drew_date is not None:
            result['drewDate'] = self.drew_date
        if self.electronic_url is not None:
            result['electronicUrl'] = self.electronic_url
        if self.finance_type is not None:
            result['financeType'] = self.finance_type
        if self.fund_type is not None:
            result['fundType'] = self.fund_type
        result['generalInvoiceDetailVOList'] = []
        if self.general_invoice_detail_volist is not None:
            for k in self.general_invoice_detail_volist:
                result['generalInvoiceDetailVOList'].append(k.to_map() if k else None)
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.machine_code is not None:
            result['machineCode'] = self.machine_code
        if self.oil_flag is not None:
            result['oilFlag'] = self.oil_flag
        if self.payee is not None:
            result['payee'] = self.payee
        if self.process_inst_code is not None:
            result['processInstCode'] = self.process_inst_code
        if self.process_inst_type is not None:
            result['processInstType'] = self.process_inst_type
        if self.purchaser_address is not None:
            result['purchaserAddress'] = self.purchaser_address
        if self.purchaser_bank_account is not None:
            result['purchaserBankAccount'] = self.purchaser_bank_account
        if self.purchaser_bank_name_account is not None:
            result['purchaserBankNameAccount'] = self.purchaser_bank_name_account
        if self.purchaser_name is not None:
            result['purchaserName'] = self.purchaser_name
        if self.purchaser_tax_no is not None:
            result['purchaserTaxNo'] = self.purchaser_tax_no
        if self.purchaser_tel is not None:
            result['purchaserTel'] = self.purchaser_tel
        if self.remark is not None:
            result['remark'] = self.remark
        result['secondHandCarInvoiceDetailList'] = []
        if self.second_hand_car_invoice_detail_list is not None:
            for k in self.second_hand_car_invoice_detail_list:
                result['secondHandCarInvoiceDetailList'].append(k.to_map() if k else None)
        if self.seller_address is not None:
            result['sellerAddress'] = self.seller_address
        if self.seller_bank_account is not None:
            result['sellerBankAccount'] = self.seller_bank_account
        if self.seller_bank_name_account is not None:
            result['sellerBankNameAccount'] = self.seller_bank_name_account
        if self.seller_name is not None:
            result['sellerName'] = self.seller_name
        if self.seller_tax_no is not None:
            result['sellerTaxNo'] = self.seller_tax_no
        if self.seller_tel is not None:
            result['sellerTel'] = self.seller_tel
        if self.status is not None:
            result['status'] = self.status
        if self.supply_sign is not None:
            result['supplySign'] = self.supply_sign
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        result['usedVehicleSaleDetailVOList'] = []
        if self.used_vehicle_sale_detail_volist is not None:
            for k in self.used_vehicle_sale_detail_volist:
                result['usedVehicleSaleDetailVOList'].append(k.to_map() if k else None)
        result['vehicleSaleDetailVOList'] = []
        if self.vehicle_sale_detail_volist is not None:
            for k in self.vehicle_sale_detail_volist:
                result['vehicleSaleDetailVOList'].append(k.to_map() if k else None)
        if self.verify_status is not None:
            result['verifyStatus'] = self.verify_status
        if self.voucher_code is not None:
            result['voucherCode'] = self.voucher_code
        if self.voucher_status is not None:
            result['voucherStatus'] = self.voucher_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountPeriod') is not None:
            self.account_period = m.get('accountPeriod')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('amountWithTax') is not None:
            self.amount_with_tax = m.get('amountWithTax')
        if m.get('checkCode') is not None:
            self.check_code = m.get('checkCode')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('drewDate') is not None:
            self.drew_date = m.get('drewDate')
        if m.get('electronicUrl') is not None:
            self.electronic_url = m.get('electronicUrl')
        if m.get('financeType') is not None:
            self.finance_type = m.get('financeType')
        if m.get('fundType') is not None:
            self.fund_type = m.get('fundType')
        self.general_invoice_detail_volist = []
        if m.get('generalInvoiceDetailVOList') is not None:
            for k in m.get('generalInvoiceDetailVOList'):
                temp_model = UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList()
                self.general_invoice_detail_volist.append(temp_model.from_map(k))
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('machineCode') is not None:
            self.machine_code = m.get('machineCode')
        if m.get('oilFlag') is not None:
            self.oil_flag = m.get('oilFlag')
        if m.get('payee') is not None:
            self.payee = m.get('payee')
        if m.get('processInstCode') is not None:
            self.process_inst_code = m.get('processInstCode')
        if m.get('processInstType') is not None:
            self.process_inst_type = m.get('processInstType')
        if m.get('purchaserAddress') is not None:
            self.purchaser_address = m.get('purchaserAddress')
        if m.get('purchaserBankAccount') is not None:
            self.purchaser_bank_account = m.get('purchaserBankAccount')
        if m.get('purchaserBankNameAccount') is not None:
            self.purchaser_bank_name_account = m.get('purchaserBankNameAccount')
        if m.get('purchaserName') is not None:
            self.purchaser_name = m.get('purchaserName')
        if m.get('purchaserTaxNo') is not None:
            self.purchaser_tax_no = m.get('purchaserTaxNo')
        if m.get('purchaserTel') is not None:
            self.purchaser_tel = m.get('purchaserTel')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        self.second_hand_car_invoice_detail_list = []
        if m.get('secondHandCarInvoiceDetailList') is not None:
            for k in m.get('secondHandCarInvoiceDetailList'):
                temp_model = UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList()
                self.second_hand_car_invoice_detail_list.append(temp_model.from_map(k))
        if m.get('sellerAddress') is not None:
            self.seller_address = m.get('sellerAddress')
        if m.get('sellerBankAccount') is not None:
            self.seller_bank_account = m.get('sellerBankAccount')
        if m.get('sellerBankNameAccount') is not None:
            self.seller_bank_name_account = m.get('sellerBankNameAccount')
        if m.get('sellerName') is not None:
            self.seller_name = m.get('sellerName')
        if m.get('sellerTaxNo') is not None:
            self.seller_tax_no = m.get('sellerTaxNo')
        if m.get('sellerTel') is not None:
            self.seller_tel = m.get('sellerTel')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('supplySign') is not None:
            self.supply_sign = m.get('supplySign')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        self.used_vehicle_sale_detail_volist = []
        if m.get('usedVehicleSaleDetailVOList') is not None:
            for k in m.get('usedVehicleSaleDetailVOList'):
                temp_model = UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList()
                self.used_vehicle_sale_detail_volist.append(temp_model.from_map(k))
        self.vehicle_sale_detail_volist = []
        if m.get('vehicleSaleDetailVOList') is not None:
            for k in m.get('vehicleSaleDetailVOList'):
                temp_model = UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList()
                self.vehicle_sale_detail_volist.append(temp_model.from_map(k))
        if m.get('verifyStatus') is not None:
            self.verify_status = m.get('verifyStatus')
        if m.get('voucherCode') is not None:
            self.voucher_code = m.get('voucherCode')
        if m.get('voucherStatus') is not None:
            self.voucher_status = m.get('voucherStatus')
        return self


class UpdateInvoiceAbandonStatusRequest(TeaModel):
    def __init__(
        self,
        blue_general_invoice_vo: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO = None,
        blue_invoice_code: str = None,
        blue_invoice_no: str = None,
        blue_invoice_status: str = None,
        operator: str = None,
        red_general_invoice_vo: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO = None,
        red_invoice_code: str = None,
        red_invoice_no: str = None,
        red_invoice_status: str = None,
        target_invoice: str = None,
    ):
        # 发票全票面信息（蓝票）
        self.blue_general_invoice_vo = blue_general_invoice_vo
        # 发票编码（蓝票）
        self.blue_invoice_code = blue_invoice_code
        # 发票号码（蓝票）
        self.blue_invoice_no = blue_invoice_no
        # 状态-红冲、废弃
        self.blue_invoice_status = blue_invoice_status
        # 操作员
        self.operator = operator
        # 发票全票面信息（红票）
        self.red_general_invoice_vo = red_general_invoice_vo
        # 红字发票code
        self.red_invoice_code = red_invoice_code
        # 红字发票编码
        self.red_invoice_no = red_invoice_no
        # 红字发票状态
        self.red_invoice_status = red_invoice_status
        # 目标发票
        self.target_invoice = target_invoice

    def validate(self):
        if self.blue_general_invoice_vo:
            self.blue_general_invoice_vo.validate()
        if self.red_general_invoice_vo:
            self.red_general_invoice_vo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.blue_general_invoice_vo is not None:
            result['blueGeneralInvoiceVO'] = self.blue_general_invoice_vo.to_map()
        if self.blue_invoice_code is not None:
            result['blueInvoiceCode'] = self.blue_invoice_code
        if self.blue_invoice_no is not None:
            result['blueInvoiceNo'] = self.blue_invoice_no
        if self.blue_invoice_status is not None:
            result['blueInvoiceStatus'] = self.blue_invoice_status
        if self.operator is not None:
            result['operator'] = self.operator
        if self.red_general_invoice_vo is not None:
            result['redGeneralInvoiceVO'] = self.red_general_invoice_vo.to_map()
        if self.red_invoice_code is not None:
            result['redInvoiceCode'] = self.red_invoice_code
        if self.red_invoice_no is not None:
            result['redInvoiceNo'] = self.red_invoice_no
        if self.red_invoice_status is not None:
            result['redInvoiceStatus'] = self.red_invoice_status
        if self.target_invoice is not None:
            result['targetInvoice'] = self.target_invoice
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('blueGeneralInvoiceVO') is not None:
            temp_model = UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO()
            self.blue_general_invoice_vo = temp_model.from_map(m['blueGeneralInvoiceVO'])
        if m.get('blueInvoiceCode') is not None:
            self.blue_invoice_code = m.get('blueInvoiceCode')
        if m.get('blueInvoiceNo') is not None:
            self.blue_invoice_no = m.get('blueInvoiceNo')
        if m.get('blueInvoiceStatus') is not None:
            self.blue_invoice_status = m.get('blueInvoiceStatus')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('redGeneralInvoiceVO') is not None:
            temp_model = UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO()
            self.red_general_invoice_vo = temp_model.from_map(m['redGeneralInvoiceVO'])
        if m.get('redInvoiceCode') is not None:
            self.red_invoice_code = m.get('redInvoiceCode')
        if m.get('redInvoiceNo') is not None:
            self.red_invoice_no = m.get('redInvoiceNo')
        if m.get('redInvoiceStatus') is not None:
            self.red_invoice_status = m.get('redInvoiceStatus')
        if m.get('targetInvoice') is not None:
            self.target_invoice = m.get('targetInvoice')
        return self


class UpdateInvoiceAbandonStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateInvoiceAbandonStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateInvoiceAbandonStatusResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = UpdateInvoiceAbandonStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInvoiceAccountPeriodHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        good_name: str = None,
        quantity: str = None,
        revenue_code: str = None,
        row_no: str = None,
        specification: str = None,
        tax_amount: str = None,
        tax_pre: str = None,
        tax_pre_type: str = None,
        tax_rate: str = None,
        unit: str = None,
        unit_price: str = None,
    ):
        # 金额
        self.amount = amount
        # 商品名称
        self.good_name = good_name
        # 数量
        self.quantity = quantity
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 规格型号
        self.specification = specification
        # 税额
        self.tax_amount = tax_amount
        # 是否享受税收优惠：0-不享受，1-享受
        self.tax_pre = tax_pre
        # 优惠政策类型
        self.tax_pre_type = tax_pre_type
        # 税率
        self.tax_rate = tax_rate
        # 单位
        self.unit = unit
        # 单价
        self.unit_price = unit_price

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.good_name is not None:
            result['goodName'] = self.good_name
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.specification is not None:
            result['specification'] = self.specification
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_pre is not None:
            result['taxPre'] = self.tax_pre
        if self.tax_pre_type is not None:
            result['taxPreType'] = self.tax_pre_type
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.unit is not None:
            result['unit'] = self.unit
        if self.unit_price is not None:
            result['unitPrice'] = self.unit_price
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('goodName') is not None:
            self.good_name = m.get('goodName')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxPre') is not None:
            self.tax_pre = m.get('taxPre')
        if m.get('taxPreType') is not None:
            self.tax_pre_type = m.get('taxPreType')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('unitPrice') is not None:
            self.unit_price = m.get('unitPrice')
        return self


class UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        card_no: str = None,
        end_date: str = None,
        goods_name: str = None,
        revenue_code: str = None,
        row_no: str = None,
        start_date: str = None,
        tax_amount: str = None,
        tax_rate: str = None,
        vehicle_type: str = None,
    ):
        # 金额
        self.amount = amount
        # 车牌号
        self.card_no = card_no
        # 通行日期止
        self.end_date = end_date
        # 商品名称
        self.goods_name = goods_name
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 通行日期起
        self.start_date = start_date
        # 税额
        self.tax_amount = tax_amount
        # 税率
        self.tax_rate = tax_rate
        # 类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        auction_unit: str = None,
        auction_unit_address: str = None,
        auction_unit_bank: str = None,
        auction_unit_tax_no: str = None,
        auction_util_tel: str = None,
        car_model: str = None,
        card_no: str = None,
        registration: str = None,
        transfer_vehicle: str = None,
        used_car_address: str = None,
        used_car_market: str = None,
        used_car_market_bank: str = None,
        used_car_market_phone: str = None,
        used_car_market_tax_no: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 经营、拍卖单位
        self.auction_unit = auction_unit
        # 经营、拍卖单位地址
        self.auction_unit_address = auction_unit_address
        # 经营、拍卖单位银行
        self.auction_unit_bank = auction_unit_bank
        # 经营、拍卖单位税号
        self.auction_unit_tax_no = auction_unit_tax_no
        # 经营、拍卖单位电话
        self.auction_util_tel = auction_util_tel
        # 厂牌型号
        self.car_model = car_model
        # 车牌照号
        self.card_no = card_no
        # 登记证号
        self.registration = registration
        # 转入地车辆管理所名称
        self.transfer_vehicle = transfer_vehicle
        # 二手车市场地址
        self.used_car_address = used_car_address
        # 二手车市场
        self.used_car_market = used_car_market
        # 二手车市场开户银行、账号
        self.used_car_market_bank = used_car_market_bank
        # 二手车市场电话
        self.used_car_market_phone = used_car_market_phone
        # 二手车市场纳税人识别号
        self.used_car_market_tax_no = used_car_market_tax_no
        # 车架号/车辆识别号
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auction_unit is not None:
            result['auctionUnit'] = self.auction_unit
        if self.auction_unit_address is not None:
            result['auctionUnitAddress'] = self.auction_unit_address
        if self.auction_unit_bank is not None:
            result['auctionUnitBank'] = self.auction_unit_bank
        if self.auction_unit_tax_no is not None:
            result['auctionUnitTaxNo'] = self.auction_unit_tax_no
        if self.auction_util_tel is not None:
            result['auctionUtilTel'] = self.auction_util_tel
        if self.car_model is not None:
            result['carModel'] = self.car_model
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.registration is not None:
            result['registration'] = self.registration
        if self.transfer_vehicle is not None:
            result['transferVehicle'] = self.transfer_vehicle
        if self.used_car_address is not None:
            result['usedCarAddress'] = self.used_car_address
        if self.used_car_market is not None:
            result['usedCarMarket'] = self.used_car_market
        if self.used_car_market_bank is not None:
            result['usedCarMarketBank'] = self.used_car_market_bank
        if self.used_car_market_phone is not None:
            result['usedCarMarketPhone'] = self.used_car_market_phone
        if self.used_car_market_tax_no is not None:
            result['usedCarMarketTaxNo'] = self.used_car_market_tax_no
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('auctionUnit') is not None:
            self.auction_unit = m.get('auctionUnit')
        if m.get('auctionUnitAddress') is not None:
            self.auction_unit_address = m.get('auctionUnitAddress')
        if m.get('auctionUnitBank') is not None:
            self.auction_unit_bank = m.get('auctionUnitBank')
        if m.get('auctionUnitTaxNo') is not None:
            self.auction_unit_tax_no = m.get('auctionUnitTaxNo')
        if m.get('auctionUtilTel') is not None:
            self.auction_util_tel = m.get('auctionUtilTel')
        if m.get('carModel') is not None:
            self.car_model = m.get('carModel')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('registration') is not None:
            self.registration = m.get('registration')
        if m.get('transferVehicle') is not None:
            self.transfer_vehicle = m.get('transferVehicle')
        if m.get('usedCarAddress') is not None:
            self.used_car_address = m.get('usedCarAddress')
        if m.get('usedCarMarket') is not None:
            self.used_car_market = m.get('usedCarMarket')
        if m.get('usedCarMarketBank') is not None:
            self.used_car_market_bank = m.get('usedCarMarketBank')
        if m.get('usedCarMarketPhone') is not None:
            self.used_car_market_phone = m.get('usedCarMarketPhone')
        if m.get('usedCarMarketTaxNo') is not None:
            self.used_car_market_tax_no = m.get('usedCarMarketTaxNo')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        brand: str = None,
        certificate_no: str = None,
        engine_no: str = None,
        id_card_no: str = None,
        import_certificate_no: str = None,
        inspection_list_no: str = None,
        max_passengers: str = None,
        origin_place: str = None,
        payment_voucher_no: str = None,
        tax_authority_name: str = None,
        tax_authority_no: str = None,
        tax_rate: str = None,
        tonnage: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 品牌
        self.brand = brand
        # 合格证号
        self.certificate_no = certificate_no
        # 发动机号
        self.engine_no = engine_no
        # 身份证号/组织机构代码
        self.id_card_no = id_card_no
        # 进口证书号
        self.import_certificate_no = import_certificate_no
        # 商检单号
        self.inspection_list_no = inspection_list_no
        # 限乘人数
        self.max_passengers = max_passengers
        # 产地
        self.origin_place = origin_place
        # 完税凭证号码
        self.payment_voucher_no = payment_voucher_no
        # 主管税务机关名称
        self.tax_authority_name = tax_authority_name
        # 主管税务机关代码
        self.tax_authority_no = tax_authority_no
        # 税率
        self.tax_rate = tax_rate
        # 吨位
        self.tonnage = tonnage
        # 车架号码
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.brand is not None:
            result['brand'] = self.brand
        if self.certificate_no is not None:
            result['certificateNo'] = self.certificate_no
        if self.engine_no is not None:
            result['engineNo'] = self.engine_no
        if self.id_card_no is not None:
            result['idCardNo'] = self.id_card_no
        if self.import_certificate_no is not None:
            result['importCertificateNo'] = self.import_certificate_no
        if self.inspection_list_no is not None:
            result['inspectionListNo'] = self.inspection_list_no
        if self.max_passengers is not None:
            result['maxPassengers'] = self.max_passengers
        if self.origin_place is not None:
            result['originPlace'] = self.origin_place
        if self.payment_voucher_no is not None:
            result['paymentVoucherNo'] = self.payment_voucher_no
        if self.tax_authority_name is not None:
            result['taxAuthorityName'] = self.tax_authority_name
        if self.tax_authority_no is not None:
            result['taxAuthorityNo'] = self.tax_authority_no
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.tonnage is not None:
            result['tonnage'] = self.tonnage
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('brand') is not None:
            self.brand = m.get('brand')
        if m.get('certificateNo') is not None:
            self.certificate_no = m.get('certificateNo')
        if m.get('engineNo') is not None:
            self.engine_no = m.get('engineNo')
        if m.get('idCardNo') is not None:
            self.id_card_no = m.get('idCardNo')
        if m.get('importCertificateNo') is not None:
            self.import_certificate_no = m.get('importCertificateNo')
        if m.get('inspectionListNo') is not None:
            self.inspection_list_no = m.get('inspectionListNo')
        if m.get('maxPassengers') is not None:
            self.max_passengers = m.get('maxPassengers')
        if m.get('originPlace') is not None:
            self.origin_place = m.get('originPlace')
        if m.get('paymentVoucherNo') is not None:
            self.payment_voucher_no = m.get('paymentVoucherNo')
        if m.get('taxAuthorityName') is not None:
            self.tax_authority_name = m.get('taxAuthorityName')
        if m.get('taxAuthorityNo') is not None:
            self.tax_authority_no = m.get('taxAuthorityNo')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('tonnage') is not None:
            self.tonnage = m.get('tonnage')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList(TeaModel):
    def __init__(
        self,
        account_period: str = None,
        amount: str = None,
        amount_with_tax: str = None,
        check_code: str = None,
        check_time: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        finance_type: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList] = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_type: str = None,
        machine_code: str = None,
        oil_flag: str = None,
        payee: str = None,
        process_inst_code: str = None,
        process_inst_type: str = None,
        purchaser_address: str = None,
        purchaser_bank_account: str = None,
        purchaser_bank_name_account: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
        remark: str = None,
        second_hand_car_invoice_detail_list: List[UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList] = None,
        seller_address: str = None,
        seller_bank_account: str = None,
        seller_bank_name_account: str = None,
        seller_name: str = None,
        seller_tax_no: str = None,
        seller_tel: str = None,
        status: str = None,
        supply_sign: str = None,
        tax_amount: str = None,
        used_vehicle_sale_detail_volist: List[UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        # 账期时间
        self.account_period = account_period
        # 不含税金额
        self.amount = amount
        # 含税金额
        self.amount_with_tax = amount_with_tax
        # 校验码
        self.check_code = check_code
        # 查验时间
        self.check_time = check_time
        # 开票日期
        self.drew_date = drew_date
        # 电票版式文件下载地址
        self.electronic_url = electronic_url
        # 财务类型，INPUT-VAT(进项),OUTPUT_VAT(销项)
        self.finance_type = finance_type
        # 资金类型 ，RED（红票），（BLUE）蓝票
        self.fund_type = fund_type
        # 常规发票明细
        self.general_invoice_detail_volist = general_invoice_detail_volist
        # 发票代码
        self.invoice_code = invoice_code
        # 发票号码
        self.invoice_no = invoice_no
        # 发票类型
        self.invoice_type = invoice_type
        # 机器码
        self.machine_code = machine_code
        # 成品油标识
        self.oil_flag = oil_flag
        # 收款人
        self.payee = payee
        # 审批单实例
        self.process_inst_code = process_inst_code
        # 审批单类型
        self.process_inst_type = process_inst_type
        # 购方地址
        self.purchaser_address = purchaser_address
        # 购方银行账户
        self.purchaser_bank_account = purchaser_bank_account
        # 购方银行名称
        self.purchaser_bank_name_account = purchaser_bank_name_account
        # 购方名称
        self.purchaser_name = purchaser_name
        # 购方税号
        self.purchaser_tax_no = purchaser_tax_no
        # 购方电话
        self.purchaser_tel = purchaser_tel
        # 备注
        self.remark = remark
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        # 销方地址
        self.seller_address = seller_address
        # 销方银行账户
        self.seller_bank_account = seller_bank_account
        # 销方银行名称
        self.seller_bank_name_account = seller_bank_name_account
        # 销方名称
        self.seller_name = seller_name
        # 销方税号
        self.seller_tax_no = seller_tax_no
        # 销方电话
        self.seller_tel = seller_tel
        # 发票状态
        self.status = status
        # 代开发票标识 1-自开，2-代开
        self.supply_sign = supply_sign
        # 税额
        self.tax_amount = tax_amount
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        # 发票查验状态
        self.verify_status = verify_status
        # 凭证code
        self.voucher_code = voucher_code
        # 生成凭证状态
        self.voucher_status = voucher_status

    def validate(self):
        if self.general_invoice_detail_volist:
            for k in self.general_invoice_detail_volist:
                if k:
                    k.validate()
        if self.second_hand_car_invoice_detail_list:
            for k in self.second_hand_car_invoice_detail_list:
                if k:
                    k.validate()
        if self.used_vehicle_sale_detail_volist:
            for k in self.used_vehicle_sale_detail_volist:
                if k:
                    k.validate()
        if self.vehicle_sale_detail_volist:
            for k in self.vehicle_sale_detail_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_period is not None:
            result['accountPeriod'] = self.account_period
        if self.amount is not None:
            result['amount'] = self.amount
        if self.amount_with_tax is not None:
            result['amountWithTax'] = self.amount_with_tax
        if self.check_code is not None:
            result['checkCode'] = self.check_code
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.drew_date is not None:
            result['drewDate'] = self.drew_date
        if self.electronic_url is not None:
            result['electronicUrl'] = self.electronic_url
        if self.finance_type is not None:
            result['financeType'] = self.finance_type
        if self.fund_type is not None:
            result['fundType'] = self.fund_type
        result['generalInvoiceDetailVOList'] = []
        if self.general_invoice_detail_volist is not None:
            for k in self.general_invoice_detail_volist:
                result['generalInvoiceDetailVOList'].append(k.to_map() if k else None)
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.machine_code is not None:
            result['machineCode'] = self.machine_code
        if self.oil_flag is not None:
            result['oilFlag'] = self.oil_flag
        if self.payee is not None:
            result['payee'] = self.payee
        if self.process_inst_code is not None:
            result['processInstCode'] = self.process_inst_code
        if self.process_inst_type is not None:
            result['processInstType'] = self.process_inst_type
        if self.purchaser_address is not None:
            result['purchaserAddress'] = self.purchaser_address
        if self.purchaser_bank_account is not None:
            result['purchaserBankAccount'] = self.purchaser_bank_account
        if self.purchaser_bank_name_account is not None:
            result['purchaserBankNameAccount'] = self.purchaser_bank_name_account
        if self.purchaser_name is not None:
            result['purchaserName'] = self.purchaser_name
        if self.purchaser_tax_no is not None:
            result['purchaserTaxNo'] = self.purchaser_tax_no
        if self.purchaser_tel is not None:
            result['purchaserTel'] = self.purchaser_tel
        if self.remark is not None:
            result['remark'] = self.remark
        result['secondHandCarInvoiceDetailList'] = []
        if self.second_hand_car_invoice_detail_list is not None:
            for k in self.second_hand_car_invoice_detail_list:
                result['secondHandCarInvoiceDetailList'].append(k.to_map() if k else None)
        if self.seller_address is not None:
            result['sellerAddress'] = self.seller_address
        if self.seller_bank_account is not None:
            result['sellerBankAccount'] = self.seller_bank_account
        if self.seller_bank_name_account is not None:
            result['sellerBankNameAccount'] = self.seller_bank_name_account
        if self.seller_name is not None:
            result['sellerName'] = self.seller_name
        if self.seller_tax_no is not None:
            result['sellerTaxNo'] = self.seller_tax_no
        if self.seller_tel is not None:
            result['sellerTel'] = self.seller_tel
        if self.status is not None:
            result['status'] = self.status
        if self.supply_sign is not None:
            result['supplySign'] = self.supply_sign
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        result['usedVehicleSaleDetailVOList'] = []
        if self.used_vehicle_sale_detail_volist is not None:
            for k in self.used_vehicle_sale_detail_volist:
                result['usedVehicleSaleDetailVOList'].append(k.to_map() if k else None)
        result['vehicleSaleDetailVOList'] = []
        if self.vehicle_sale_detail_volist is not None:
            for k in self.vehicle_sale_detail_volist:
                result['vehicleSaleDetailVOList'].append(k.to_map() if k else None)
        if self.verify_status is not None:
            result['verifyStatus'] = self.verify_status
        if self.voucher_code is not None:
            result['voucherCode'] = self.voucher_code
        if self.voucher_status is not None:
            result['voucherStatus'] = self.voucher_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountPeriod') is not None:
            self.account_period = m.get('accountPeriod')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('amountWithTax') is not None:
            self.amount_with_tax = m.get('amountWithTax')
        if m.get('checkCode') is not None:
            self.check_code = m.get('checkCode')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('drewDate') is not None:
            self.drew_date = m.get('drewDate')
        if m.get('electronicUrl') is not None:
            self.electronic_url = m.get('electronicUrl')
        if m.get('financeType') is not None:
            self.finance_type = m.get('financeType')
        if m.get('fundType') is not None:
            self.fund_type = m.get('fundType')
        self.general_invoice_detail_volist = []
        if m.get('generalInvoiceDetailVOList') is not None:
            for k in m.get('generalInvoiceDetailVOList'):
                temp_model = UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList()
                self.general_invoice_detail_volist.append(temp_model.from_map(k))
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('machineCode') is not None:
            self.machine_code = m.get('machineCode')
        if m.get('oilFlag') is not None:
            self.oil_flag = m.get('oilFlag')
        if m.get('payee') is not None:
            self.payee = m.get('payee')
        if m.get('processInstCode') is not None:
            self.process_inst_code = m.get('processInstCode')
        if m.get('processInstType') is not None:
            self.process_inst_type = m.get('processInstType')
        if m.get('purchaserAddress') is not None:
            self.purchaser_address = m.get('purchaserAddress')
        if m.get('purchaserBankAccount') is not None:
            self.purchaser_bank_account = m.get('purchaserBankAccount')
        if m.get('purchaserBankNameAccount') is not None:
            self.purchaser_bank_name_account = m.get('purchaserBankNameAccount')
        if m.get('purchaserName') is not None:
            self.purchaser_name = m.get('purchaserName')
        if m.get('purchaserTaxNo') is not None:
            self.purchaser_tax_no = m.get('purchaserTaxNo')
        if m.get('purchaserTel') is not None:
            self.purchaser_tel = m.get('purchaserTel')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        self.second_hand_car_invoice_detail_list = []
        if m.get('secondHandCarInvoiceDetailList') is not None:
            for k in m.get('secondHandCarInvoiceDetailList'):
                temp_model = UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList()
                self.second_hand_car_invoice_detail_list.append(temp_model.from_map(k))
        if m.get('sellerAddress') is not None:
            self.seller_address = m.get('sellerAddress')
        if m.get('sellerBankAccount') is not None:
            self.seller_bank_account = m.get('sellerBankAccount')
        if m.get('sellerBankNameAccount') is not None:
            self.seller_bank_name_account = m.get('sellerBankNameAccount')
        if m.get('sellerName') is not None:
            self.seller_name = m.get('sellerName')
        if m.get('sellerTaxNo') is not None:
            self.seller_tax_no = m.get('sellerTaxNo')
        if m.get('sellerTel') is not None:
            self.seller_tel = m.get('sellerTel')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('supplySign') is not None:
            self.supply_sign = m.get('supplySign')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        self.used_vehicle_sale_detail_volist = []
        if m.get('usedVehicleSaleDetailVOList') is not None:
            for k in m.get('usedVehicleSaleDetailVOList'):
                temp_model = UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList()
                self.used_vehicle_sale_detail_volist.append(temp_model.from_map(k))
        self.vehicle_sale_detail_volist = []
        if m.get('vehicleSaleDetailVOList') is not None:
            for k in m.get('vehicleSaleDetailVOList'):
                temp_model = UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList()
                self.vehicle_sale_detail_volist.append(temp_model.from_map(k))
        if m.get('verifyStatus') is not None:
            self.verify_status = m.get('verifyStatus')
        if m.get('voucherCode') is not None:
            self.voucher_code = m.get('voucherCode')
        if m.get('voucherStatus') is not None:
            self.voucher_status = m.get('voucherStatus')
        return self


class UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList(TeaModel):
    def __init__(
        self,
        invoice_code: str = None,
        invoice_no: str = None,
    ):
        # 发票编码
        self.invoice_code = invoice_code
        # 发票号码
        self.invoice_no = invoice_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        return self


class UpdateInvoiceAccountPeriodRequest(TeaModel):
    def __init__(
        self,
        account_period: str = None,
        general_invoice_volist: List[UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList] = None,
        invoice_key_volist: List[UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList] = None,
        operator: str = None,
    ):
        # 认证状态
        self.account_period = account_period
        # 发票模型
        self.general_invoice_volist = general_invoice_volist
        # 发票主键列表
        self.invoice_key_volist = invoice_key_volist
        # 操作员
        self.operator = operator

    def validate(self):
        if self.general_invoice_volist:
            for k in self.general_invoice_volist:
                if k:
                    k.validate()
        if self.invoice_key_volist:
            for k in self.invoice_key_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_period is not None:
            result['accountPeriod'] = self.account_period
        result['generalInvoiceVOList'] = []
        if self.general_invoice_volist is not None:
            for k in self.general_invoice_volist:
                result['generalInvoiceVOList'].append(k.to_map() if k else None)
        result['invoiceKeyVOList'] = []
        if self.invoice_key_volist is not None:
            for k in self.invoice_key_volist:
                result['invoiceKeyVOList'].append(k.to_map() if k else None)
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountPeriod') is not None:
            self.account_period = m.get('accountPeriod')
        self.general_invoice_volist = []
        if m.get('generalInvoiceVOList') is not None:
            for k in m.get('generalInvoiceVOList'):
                temp_model = UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList()
                self.general_invoice_volist.append(temp_model.from_map(k))
        self.invoice_key_volist = []
        if m.get('invoiceKeyVOList') is not None:
            for k in m.get('invoiceKeyVOList'):
                temp_model = UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList()
                self.invoice_key_volist.append(temp_model.from_map(k))
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class UpdateInvoiceAccountPeriodResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateInvoiceAccountPeriodResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateInvoiceAccountPeriodResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = UpdateInvoiceAccountPeriodResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInvoiceAndReceiptRelatedHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        good_name: str = None,
        quantity: str = None,
        revenue_code: str = None,
        row_no: str = None,
        specification: str = None,
        tax_amount: str = None,
        tax_pre: str = None,
        tax_pre_type: str = None,
        tax_rate: str = None,
        unit: str = None,
        unit_price: str = None,
    ):
        # 金额
        self.amount = amount
        # 商品名称
        self.good_name = good_name
        # 数量
        self.quantity = quantity
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 规格型号
        self.specification = specification
        # 税额
        self.tax_amount = tax_amount
        # 是否享受税收优惠：0-不享受，1-享受
        self.tax_pre = tax_pre
        # 优惠政策类型
        self.tax_pre_type = tax_pre_type
        # 税率
        self.tax_rate = tax_rate
        # 单位
        self.unit = unit
        # 单价
        self.unit_price = unit_price

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.good_name is not None:
            result['goodName'] = self.good_name
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.specification is not None:
            result['specification'] = self.specification
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_pre is not None:
            result['taxPre'] = self.tax_pre
        if self.tax_pre_type is not None:
            result['taxPreType'] = self.tax_pre_type
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.unit is not None:
            result['unit'] = self.unit
        if self.unit_price is not None:
            result['unitPrice'] = self.unit_price
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('goodName') is not None:
            self.good_name = m.get('goodName')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxPre') is not None:
            self.tax_pre = m.get('taxPre')
        if m.get('taxPreType') is not None:
            self.tax_pre_type = m.get('taxPreType')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('unitPrice') is not None:
            self.unit_price = m.get('unitPrice')
        return self


class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        card_no: str = None,
        end_date: str = None,
        goods_name: str = None,
        revenue_code: str = None,
        row_no: str = None,
        start_date: str = None,
        tax_amount: str = None,
        tax_rate: str = None,
        vehicle_type: str = None,
    ):
        # 金额
        self.amount = amount
        # 车牌号
        self.card_no = card_no
        # 通行日期止
        self.end_date = end_date
        # 商品名称
        self.goods_name = goods_name
        # 税收分类编码
        self.revenue_code = revenue_code
        # 行号
        self.row_no = row_no
        # 通行日期起
        self.start_date = start_date
        # 税额
        self.tax_amount = tax_amount
        # 税率
        self.tax_rate = tax_rate
        # 类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
        if self.revenue_code is not None:
            result['revenueCode'] = self.revenue_code
        if self.row_no is not None:
            result['rowNo'] = self.row_no
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
        if m.get('revenueCode') is not None:
            self.revenue_code = m.get('revenueCode')
        if m.get('rowNo') is not None:
            self.row_no = m.get('rowNo')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        auction_unit: str = None,
        auction_unit_address: str = None,
        auction_unit_bank: str = None,
        auction_unit_tax_no: str = None,
        auction_util_tel: str = None,
        car_model: str = None,
        card_no: str = None,
        registration: str = None,
        transfer_vehicle: str = None,
        used_car_address: str = None,
        used_car_market: str = None,
        used_car_market_bank: str = None,
        used_car_market_phone: str = None,
        used_car_market_tax_no: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 经营、拍卖单位
        self.auction_unit = auction_unit
        # 经营、拍卖单位地址
        self.auction_unit_address = auction_unit_address
        # 经营、拍卖单位银行
        self.auction_unit_bank = auction_unit_bank
        # 经营、拍卖单位税号
        self.auction_unit_tax_no = auction_unit_tax_no
        # 经营、拍卖单位电话
        self.auction_util_tel = auction_util_tel
        # 厂牌型号
        self.car_model = car_model
        # 车牌照号
        self.card_no = card_no
        # 登记证号
        self.registration = registration
        # 转入地车辆管理所名称
        self.transfer_vehicle = transfer_vehicle
        # 二手车市场地址
        self.used_car_address = used_car_address
        # 二手车市场
        self.used_car_market = used_car_market
        # 二手车市场开户银行、账号
        self.used_car_market_bank = used_car_market_bank
        # 二手车市场电话
        self.used_car_market_phone = used_car_market_phone
        # 二手车市场纳税人识别号
        self.used_car_market_tax_no = used_car_market_tax_no
        # 车架号/车辆识别号
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auction_unit is not None:
            result['auctionUnit'] = self.auction_unit
        if self.auction_unit_address is not None:
            result['auctionUnitAddress'] = self.auction_unit_address
        if self.auction_unit_bank is not None:
            result['auctionUnitBank'] = self.auction_unit_bank
        if self.auction_unit_tax_no is not None:
            result['auctionUnitTaxNo'] = self.auction_unit_tax_no
        if self.auction_util_tel is not None:
            result['auctionUtilTel'] = self.auction_util_tel
        if self.car_model is not None:
            result['carModel'] = self.car_model
        if self.card_no is not None:
            result['cardNo'] = self.card_no
        if self.registration is not None:
            result['registration'] = self.registration
        if self.transfer_vehicle is not None:
            result['transferVehicle'] = self.transfer_vehicle
        if self.used_car_address is not None:
            result['usedCarAddress'] = self.used_car_address
        if self.used_car_market is not None:
            result['usedCarMarket'] = self.used_car_market
        if self.used_car_market_bank is not None:
            result['usedCarMarketBank'] = self.used_car_market_bank
        if self.used_car_market_phone is not None:
            result['usedCarMarketPhone'] = self.used_car_market_phone
        if self.used_car_market_tax_no is not None:
            result['usedCarMarketTaxNo'] = self.used_car_market_tax_no
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('auctionUnit') is not None:
            self.auction_unit = m.get('auctionUnit')
        if m.get('auctionUnitAddress') is not None:
            self.auction_unit_address = m.get('auctionUnitAddress')
        if m.get('auctionUnitBank') is not None:
            self.auction_unit_bank = m.get('auctionUnitBank')
        if m.get('auctionUnitTaxNo') is not None:
            self.auction_unit_tax_no = m.get('auctionUnitTaxNo')
        if m.get('auctionUtilTel') is not None:
            self.auction_util_tel = m.get('auctionUtilTel')
        if m.get('carModel') is not None:
            self.car_model = m.get('carModel')
        if m.get('cardNo') is not None:
            self.card_no = m.get('cardNo')
        if m.get('registration') is not None:
            self.registration = m.get('registration')
        if m.get('transferVehicle') is not None:
            self.transfer_vehicle = m.get('transferVehicle')
        if m.get('usedCarAddress') is not None:
            self.used_car_address = m.get('usedCarAddress')
        if m.get('usedCarMarket') is not None:
            self.used_car_market = m.get('usedCarMarket')
        if m.get('usedCarMarketBank') is not None:
            self.used_car_market_bank = m.get('usedCarMarketBank')
        if m.get('usedCarMarketPhone') is not None:
            self.used_car_market_phone = m.get('usedCarMarketPhone')
        if m.get('usedCarMarketTaxNo') is not None:
            self.used_car_market_tax_no = m.get('usedCarMarketTaxNo')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList(TeaModel):
    def __init__(
        self,
        brand: str = None,
        certificate_no: str = None,
        engine_no: str = None,
        id_card_no: str = None,
        import_certificate_no: str = None,
        inspection_list_no: str = None,
        max_passengers: str = None,
        origin_place: str = None,
        payment_voucher_no: str = None,
        tax_authority_name: str = None,
        tax_authority_no: str = None,
        tax_rate: str = None,
        tonnage: str = None,
        vehicle_no: str = None,
        vehicle_type: str = None,
    ):
        # 品牌
        self.brand = brand
        # 合格证号
        self.certificate_no = certificate_no
        # 发动机号
        self.engine_no = engine_no
        # 身份证号/组织机构代码
        self.id_card_no = id_card_no
        # 进口证书号
        self.import_certificate_no = import_certificate_no
        # 商检单号
        self.inspection_list_no = inspection_list_no
        # 限乘人数
        self.max_passengers = max_passengers
        # 产地
        self.origin_place = origin_place
        # 完税凭证号码
        self.payment_voucher_no = payment_voucher_no
        # 主管税务机关名称
        self.tax_authority_name = tax_authority_name
        # 主管税务机关代码
        self.tax_authority_no = tax_authority_no
        # 税率
        self.tax_rate = tax_rate
        # 吨位
        self.tonnage = tonnage
        # 车架号码
        self.vehicle_no = vehicle_no
        # 车辆类型
        self.vehicle_type = vehicle_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.brand is not None:
            result['brand'] = self.brand
        if self.certificate_no is not None:
            result['certificateNo'] = self.certificate_no
        if self.engine_no is not None:
            result['engineNo'] = self.engine_no
        if self.id_card_no is not None:
            result['idCardNo'] = self.id_card_no
        if self.import_certificate_no is not None:
            result['importCertificateNo'] = self.import_certificate_no
        if self.inspection_list_no is not None:
            result['inspectionListNo'] = self.inspection_list_no
        if self.max_passengers is not None:
            result['maxPassengers'] = self.max_passengers
        if self.origin_place is not None:
            result['originPlace'] = self.origin_place
        if self.payment_voucher_no is not None:
            result['paymentVoucherNo'] = self.payment_voucher_no
        if self.tax_authority_name is not None:
            result['taxAuthorityName'] = self.tax_authority_name
        if self.tax_authority_no is not None:
            result['taxAuthorityNo'] = self.tax_authority_no
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.tonnage is not None:
            result['tonnage'] = self.tonnage
        if self.vehicle_no is not None:
            result['vehicleNo'] = self.vehicle_no
        if self.vehicle_type is not None:
            result['vehicleType'] = self.vehicle_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('brand') is not None:
            self.brand = m.get('brand')
        if m.get('certificateNo') is not None:
            self.certificate_no = m.get('certificateNo')
        if m.get('engineNo') is not None:
            self.engine_no = m.get('engineNo')
        if m.get('idCardNo') is not None:
            self.id_card_no = m.get('idCardNo')
        if m.get('importCertificateNo') is not None:
            self.import_certificate_no = m.get('importCertificateNo')
        if m.get('inspectionListNo') is not None:
            self.inspection_list_no = m.get('inspectionListNo')
        if m.get('maxPassengers') is not None:
            self.max_passengers = m.get('maxPassengers')
        if m.get('originPlace') is not None:
            self.origin_place = m.get('originPlace')
        if m.get('paymentVoucherNo') is not None:
            self.payment_voucher_no = m.get('paymentVoucherNo')
        if m.get('taxAuthorityName') is not None:
            self.tax_authority_name = m.get('taxAuthorityName')
        if m.get('taxAuthorityNo') is not None:
            self.tax_authority_no = m.get('taxAuthorityNo')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('tonnage') is not None:
            self.tonnage = m.get('tonnage')
        if m.get('vehicleNo') is not None:
            self.vehicle_no = m.get('vehicleNo')
        if m.get('vehicleType') is not None:
            self.vehicle_type = m.get('vehicleType')
        return self


class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO(TeaModel):
    def __init__(
        self,
        account_period: str = None,
        amount: str = None,
        amount_with_tax: str = None,
        check_code: str = None,
        check_time: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        finance_type: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList] = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_type: str = None,
        machine_code: str = None,
        oil_flag: str = None,
        payee: str = None,
        process_inst_code: str = None,
        process_inst_type: str = None,
        purchaser_address: str = None,
        purchaser_bank_account: str = None,
        purchaser_bank_name_account: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
        remark: str = None,
        second_hand_car_invoice_detail_list: List[UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList] = None,
        seller_address: str = None,
        seller_bank_account: str = None,
        seller_bank_name_account: str = None,
        seller_name: str = None,
        seller_tax_no: str = None,
        seller_tel: str = None,
        status: str = None,
        supply_sign: str = None,
        tax_amount: str = None,
        used_vehicle_sale_detail_volist: List[UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        # 账期时间
        self.account_period = account_period
        # 不含税金额
        self.amount = amount
        # 含税金额
        self.amount_with_tax = amount_with_tax
        # 校验码
        self.check_code = check_code
        # 查验时间
        self.check_time = check_time
        # 开票日期
        self.drew_date = drew_date
        # 电票版式文件下载地址
        self.electronic_url = electronic_url
        # 财务类型，INPUT-VAT(进项),OUTPUT_VAT(销项)
        self.finance_type = finance_type
        # 资金类型 ，RED（红票），（BLUE）蓝票
        self.fund_type = fund_type
        # 常规发票明细
        self.general_invoice_detail_volist = general_invoice_detail_volist
        # 发票代码
        self.invoice_code = invoice_code
        # 发票号码
        self.invoice_no = invoice_no
        # 发票类型
        self.invoice_type = invoice_type
        # 机器码
        self.machine_code = machine_code
        # 成品油标识
        self.oil_flag = oil_flag
        # 收款人
        self.payee = payee
        # 审批单实例
        self.process_inst_code = process_inst_code
        # 审批单类型
        self.process_inst_type = process_inst_type
        # 购方地址
        self.purchaser_address = purchaser_address
        # 购方银行账户
        # 
        self.purchaser_bank_account = purchaser_bank_account
        self.purchaser_bank_name_account = purchaser_bank_name_account
        # 购方名称
        self.purchaser_name = purchaser_name
        # 购方税号
        self.purchaser_tax_no = purchaser_tax_no
        # 购方电话
        self.purchaser_tel = purchaser_tel
        # 备注
        self.remark = remark
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        # 销方地址
        self.seller_address = seller_address
        # 销方银行账户
        self.seller_bank_account = seller_bank_account
        self.seller_bank_name_account = seller_bank_name_account
        # 销方名称
        self.seller_name = seller_name
        # 销方税号
        self.seller_tax_no = seller_tax_no
        # 销方电话
        self.seller_tel = seller_tel
        # 发票状态
        self.status = status
        # 代开发票标识 1-自开，2-代开
        self.supply_sign = supply_sign
        # 税额
        self.tax_amount = tax_amount
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        # 发票查验状态
        self.verify_status = verify_status
        # 凭证code
        self.voucher_code = voucher_code
        # 生成凭证状态
        self.voucher_status = voucher_status

    def validate(self):
        if self.general_invoice_detail_volist:
            for k in self.general_invoice_detail_volist:
                if k:
                    k.validate()
        if self.second_hand_car_invoice_detail_list:
            for k in self.second_hand_car_invoice_detail_list:
                if k:
                    k.validate()
        if self.used_vehicle_sale_detail_volist:
            for k in self.used_vehicle_sale_detail_volist:
                if k:
                    k.validate()
        if self.vehicle_sale_detail_volist:
            for k in self.vehicle_sale_detail_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_period is not None:
            result['accountPeriod'] = self.account_period
        if self.amount is not None:
            result['amount'] = self.amount
        if self.amount_with_tax is not None:
            result['amountWithTax'] = self.amount_with_tax
        if self.check_code is not None:
            result['checkCode'] = self.check_code
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.drew_date is not None:
            result['drewDate'] = self.drew_date
        if self.electronic_url is not None:
            result['electronicUrl'] = self.electronic_url
        if self.finance_type is not None:
            result['financeType'] = self.finance_type
        if self.fund_type is not None:
            result['fundType'] = self.fund_type
        result['generalInvoiceDetailVOList'] = []
        if self.general_invoice_detail_volist is not None:
            for k in self.general_invoice_detail_volist:
                result['generalInvoiceDetailVOList'].append(k.to_map() if k else None)
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.machine_code is not None:
            result['machineCode'] = self.machine_code
        if self.oil_flag is not None:
            result['oilFlag'] = self.oil_flag
        if self.payee is not None:
            result['payee'] = self.payee
        if self.process_inst_code is not None:
            result['processInstCode'] = self.process_inst_code
        if self.process_inst_type is not None:
            result['processInstType'] = self.process_inst_type
        if self.purchaser_address is not None:
            result['purchaserAddress'] = self.purchaser_address
        if self.purchaser_bank_account is not None:
            result['purchaserBankAccount'] = self.purchaser_bank_account
        if self.purchaser_bank_name_account is not None:
            result['purchaserBankNameAccount'] = self.purchaser_bank_name_account
        if self.purchaser_name is not None:
            result['purchaserName'] = self.purchaser_name
        if self.purchaser_tax_no is not None:
            result['purchaserTaxNo'] = self.purchaser_tax_no
        if self.purchaser_tel is not None:
            result['purchaserTel'] = self.purchaser_tel
        if self.remark is not None:
            result['remark'] = self.remark
        result['secondHandCarInvoiceDetailList'] = []
        if self.second_hand_car_invoice_detail_list is not None:
            for k in self.second_hand_car_invoice_detail_list:
                result['secondHandCarInvoiceDetailList'].append(k.to_map() if k else None)
        if self.seller_address is not None:
            result['sellerAddress'] = self.seller_address
        if self.seller_bank_account is not None:
            result['sellerBankAccount'] = self.seller_bank_account
        if self.seller_bank_name_account is not None:
            result['sellerBankNameAccount'] = self.seller_bank_name_account
        if self.seller_name is not None:
            result['sellerName'] = self.seller_name
        if self.seller_tax_no is not None:
            result['sellerTaxNo'] = self.seller_tax_no
        if self.seller_tel is not None:
            result['sellerTel'] = self.seller_tel
        if self.status is not None:
            result['status'] = self.status
        if self.supply_sign is not None:
            result['supplySign'] = self.supply_sign
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        result['usedVehicleSaleDetailVOList'] = []
        if self.used_vehicle_sale_detail_volist is not None:
            for k in self.used_vehicle_sale_detail_volist:
                result['usedVehicleSaleDetailVOList'].append(k.to_map() if k else None)
        result['vehicleSaleDetailVOList'] = []
        if self.vehicle_sale_detail_volist is not None:
            for k in self.vehicle_sale_detail_volist:
                result['vehicleSaleDetailVOList'].append(k.to_map() if k else None)
        if self.verify_status is not None:
            result['verifyStatus'] = self.verify_status
        if self.voucher_code is not None:
            result['voucherCode'] = self.voucher_code
        if self.voucher_status is not None:
            result['voucherStatus'] = self.voucher_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountPeriod') is not None:
            self.account_period = m.get('accountPeriod')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('amountWithTax') is not None:
            self.amount_with_tax = m.get('amountWithTax')
        if m.get('checkCode') is not None:
            self.check_code = m.get('checkCode')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('drewDate') is not None:
            self.drew_date = m.get('drewDate')
        if m.get('electronicUrl') is not None:
            self.electronic_url = m.get('electronicUrl')
        if m.get('financeType') is not None:
            self.finance_type = m.get('financeType')
        if m.get('fundType') is not None:
            self.fund_type = m.get('fundType')
        self.general_invoice_detail_volist = []
        if m.get('generalInvoiceDetailVOList') is not None:
            for k in m.get('generalInvoiceDetailVOList'):
                temp_model = UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList()
                self.general_invoice_detail_volist.append(temp_model.from_map(k))
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('machineCode') is not None:
            self.machine_code = m.get('machineCode')
        if m.get('oilFlag') is not None:
            self.oil_flag = m.get('oilFlag')
        if m.get('payee') is not None:
            self.payee = m.get('payee')
        if m.get('processInstCode') is not None:
            self.process_inst_code = m.get('processInstCode')
        if m.get('processInstType') is not None:
            self.process_inst_type = m.get('processInstType')
        if m.get('purchaserAddress') is not None:
            self.purchaser_address = m.get('purchaserAddress')
        if m.get('purchaserBankAccount') is not None:
            self.purchaser_bank_account = m.get('purchaserBankAccount')
        if m.get('purchaserBankNameAccount') is not None:
            self.purchaser_bank_name_account = m.get('purchaserBankNameAccount')
        if m.get('purchaserName') is not None:
            self.purchaser_name = m.get('purchaserName')
        if m.get('purchaserTaxNo') is not None:
            self.purchaser_tax_no = m.get('purchaserTaxNo')
        if m.get('purchaserTel') is not None:
            self.purchaser_tel = m.get('purchaserTel')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        self.second_hand_car_invoice_detail_list = []
        if m.get('secondHandCarInvoiceDetailList') is not None:
            for k in m.get('secondHandCarInvoiceDetailList'):
                temp_model = UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList()
                self.second_hand_car_invoice_detail_list.append(temp_model.from_map(k))
        if m.get('sellerAddress') is not None:
            self.seller_address = m.get('sellerAddress')
        if m.get('sellerBankAccount') is not None:
            self.seller_bank_account = m.get('sellerBankAccount')
        if m.get('sellerBankNameAccount') is not None:
            self.seller_bank_name_account = m.get('sellerBankNameAccount')
        if m.get('sellerName') is not None:
            self.seller_name = m.get('sellerName')
        if m.get('sellerTaxNo') is not None:
            self.seller_tax_no = m.get('sellerTaxNo')
        if m.get('sellerTel') is not None:
            self.seller_tel = m.get('sellerTel')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('supplySign') is not None:
            self.supply_sign = m.get('supplySign')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        self.used_vehicle_sale_detail_volist = []
        if m.get('usedVehicleSaleDetailVOList') is not None:
            for k in m.get('usedVehicleSaleDetailVOList'):
                temp_model = UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList()
                self.used_vehicle_sale_detail_volist.append(temp_model.from_map(k))
        self.vehicle_sale_detail_volist = []
        if m.get('vehicleSaleDetailVOList') is not None:
            for k in m.get('vehicleSaleDetailVOList'):
                temp_model = UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList()
                self.vehicle_sale_detail_volist.append(temp_model.from_map(k))
        if m.get('verifyStatus') is not None:
            self.verify_status = m.get('verifyStatus')
        if m.get('voucherCode') is not None:
            self.voucher_code = m.get('voucherCode')
        if m.get('voucherStatus') is not None:
            self.voucher_status = m.get('voucherStatus')
        return self


class UpdateInvoiceAndReceiptRelatedRequest(TeaModel):
    def __init__(
        self,
        general_invoice_vo: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO = None,
        invoice_code: str = None,
        invoice_no: str = None,
        operator: str = None,
        receipt_code: str = None,
    ):
        # 发票全票面信息
        self.general_invoice_vo = general_invoice_vo
        # 发票代码
        self.invoice_code = invoice_code
        # 发票号码
        self.invoice_no = invoice_no
        # 操作员
        self.operator = operator
        # 钉钉审批单号
        self.receipt_code = receipt_code

    def validate(self):
        if self.general_invoice_vo:
            self.general_invoice_vo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.general_invoice_vo is not None:
            result['generalInvoiceVO'] = self.general_invoice_vo.to_map()
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.operator is not None:
            result['operator'] = self.operator
        if self.receipt_code is not None:
            result['receiptCode'] = self.receipt_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('generalInvoiceVO') is not None:
            temp_model = UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO()
            self.general_invoice_vo = temp_model.from_map(m['generalInvoiceVO'])
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('receiptCode') is not None:
            self.receipt_code = m.get('receiptCode')
        return self


class UpdateInvoiceAndReceiptRelatedResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateInvoiceAndReceiptRelatedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateInvoiceAndReceiptRelatedResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = UpdateInvoiceAndReceiptRelatedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInvoiceIgnoreStatusHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateInvoiceIgnoreStatusRequest(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
        operator: str = None,
        status: str = None,
    ):
        # 审批单id
        self.instance_id = instance_id
        # 操作员
        self.operator = operator
        # 状态
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.operator is not None:
            result['operator'] = self.operator
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class UpdateInvoiceIgnoreStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateInvoiceIgnoreStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateInvoiceIgnoreStatusResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = UpdateInvoiceIgnoreStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInvoiceVerifyStatusHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList(TeaModel):
    def __init__(
        self,
        invoice_code: str = None,
        invoice_no: str = None,
    ):
        # 发票编码
        self.invoice_code = invoice_code
        # 发票号码
        self.invoice_no = invoice_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        return self


class UpdateInvoiceVerifyStatusRequest(TeaModel):
    def __init__(
        self,
        deduct_status: str = None,
        invoice_key_volist: List[UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList] = None,
        operator: str = None,
        verify_status: str = None,
    ):
        # 抵扣状态
        # 
        self.deduct_status = deduct_status
        # 待更新
        self.invoice_key_volist = invoice_key_volist
        # 操作员
        self.operator = operator
        # 认证状态
        self.verify_status = verify_status

    def validate(self):
        if self.invoice_key_volist:
            for k in self.invoice_key_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.deduct_status is not None:
            result['deductStatus'] = self.deduct_status
        result['invoiceKeyVOList'] = []
        if self.invoice_key_volist is not None:
            for k in self.invoice_key_volist:
                result['invoiceKeyVOList'].append(k.to_map() if k else None)
        if self.operator is not None:
            result['operator'] = self.operator
        if self.verify_status is not None:
            result['verifyStatus'] = self.verify_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deductStatus') is not None:
            self.deduct_status = m.get('deductStatus')
        self.invoice_key_volist = []
        if m.get('invoiceKeyVOList') is not None:
            for k in m.get('invoiceKeyVOList'):
                temp_model = UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList()
                self.invoice_key_volist.append(temp_model.from_map(k))
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('verifyStatus') is not None:
            self.verify_status = m.get('verifyStatus')
        return self


class UpdateInvoiceVerifyStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateInvoiceVerifyStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateInvoiceVerifyStatusResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = UpdateInvoiceVerifyStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateReceiptHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateReceiptRequestReceipts(TeaModel):
    def __init__(
        self,
        amount: str = None,
        category_code: str = None,
        code: str = None,
        customer_code: str = None,
        enterprise_acount_code: str = None,
        occur_date: int = None,
        principal_id: str = None,
        project_code: str = None,
        receipt_type: int = None,
        remark: str = None,
        supplier_code: str = None,
        title: str = None,
        update_time: int = None,
        update_user_id: str = None,
    ):
        # 总金额，传空代表不修改
        self.amount = amount
        # 关联收支类别，传空代表不修改
        self.category_code = category_code
        # 单据唯一编号
        self.code = code
        # 关联客户code，传空代表不修改
        self.customer_code = customer_code
        # 关联企业账户code，传空代表不修改
        self.enterprise_acount_code = enterprise_acount_code
        # 业务发生时间，传空代表不修改
        self.occur_date = occur_date
        # 负责人工号，传空代表不修改
        self.principal_id = principal_id
        # 关联项目code，传空代表不修改
        self.project_code = project_code
        # 单据类型：1付款单，2收款单
        self.receipt_type = receipt_type
        # 备注，传空代表不修改
        self.remark = remark
        # 关联供应商code，传空代表不修改
        self.supplier_code = supplier_code
        # 单据标题，传空代表不修改
        self.title = title
        # 单据更新时间
        self.update_time = update_time
        # 修改者工号
        self.update_user_id = update_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.category_code is not None:
            result['categoryCode'] = self.category_code
        if self.code is not None:
            result['code'] = self.code
        if self.customer_code is not None:
            result['customerCode'] = self.customer_code
        if self.enterprise_acount_code is not None:
            result['enterpriseAcountCode'] = self.enterprise_acount_code
        if self.occur_date is not None:
            result['occurDate'] = self.occur_date
        if self.principal_id is not None:
            result['principalId'] = self.principal_id
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.receipt_type is not None:
            result['receiptType'] = self.receipt_type
        if self.remark is not None:
            result['remark'] = self.remark
        if self.supplier_code is not None:
            result['supplierCode'] = self.supplier_code
        if self.title is not None:
            result['title'] = self.title
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        if self.update_user_id is not None:
            result['updateUserId'] = self.update_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('categoryCode') is not None:
            self.category_code = m.get('categoryCode')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('customerCode') is not None:
            self.customer_code = m.get('customerCode')
        if m.get('enterpriseAcountCode') is not None:
            self.enterprise_acount_code = m.get('enterpriseAcountCode')
        if m.get('occurDate') is not None:
            self.occur_date = m.get('occurDate')
        if m.get('principalId') is not None:
            self.principal_id = m.get('principalId')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('receiptType') is not None:
            self.receipt_type = m.get('receiptType')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('supplierCode') is not None:
            self.supplier_code = m.get('supplierCode')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        if m.get('updateUserId') is not None:
            self.update_user_id = m.get('updateUserId')
        return self


class UpdateReceiptRequest(TeaModel):
    def __init__(
        self,
        receipts: List[UpdateReceiptRequestReceipts] = None,
    ):
        # 单据列表 ，最长10
        self.receipts = receipts

    def validate(self):
        if self.receipts:
            for k in self.receipts:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['receipts'] = []
        if self.receipts is not None:
            for k in self.receipts:
                result['receipts'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.receipts = []
        if m.get('receipts') is not None:
            for k in m.get('receipts'):
                temp_model = UpdateReceiptRequestReceipts()
                self.receipts.append(temp_model.from_map(k))
        return self


class UpdateReceiptResponseBodyResults(TeaModel):
    def __init__(
        self,
        code: str = None,
        error_code: str = None,
        error_msg: str = None,
        success: bool = None,
    ):
        # 数据唯一编号
        self.code = code
        # 错误码
        self.error_code = error_code
        # 错误信息
        self.error_msg = error_msg
        # 是否成功
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateReceiptResponseBody(TeaModel):
    def __init__(
        self,
        results: List[UpdateReceiptResponseBodyResults] = None,
    ):
        # 结果列表
        self.results = results

    def validate(self):
        if self.results:
            for k in self.results:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['results'] = []
        if self.results is not None:
            for k in self.results:
                result['results'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.results = []
        if m.get('results') is not None:
            for k in m.get('results'):
                temp_model = UpdateReceiptResponseBodyResults()
                self.results.append(temp_model.from_map(k))
        return self


class UpdateReceiptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateReceiptResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = UpdateReceiptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateReceiptVoucherStatusHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateReceiptVoucherStatusRequest(TeaModel):
    def __init__(
        self,
        account_period: str = None,
        action_type: str = None,
        operator_id: str = None,
        receipt_id: str = None,
        voucher_code: str = None,
        voucher_id: str = None,
    ):
        # 账期
        self.account_period = account_period
        # 操作类型 add 添加凭证关系、delete 删除凭证关系
        self.action_type = action_type
        # 操作人工号
        self.operator_id = operator_id
        # 审批单据ID
        self.receipt_id = receipt_id
        # 凭证CODE
        self.voucher_code = voucher_code
        # 凭证ID
        self.voucher_id = voucher_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_period is not None:
            result['accountPeriod'] = self.account_period
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.receipt_id is not None:
            result['receiptId'] = self.receipt_id
        if self.voucher_code is not None:
            result['voucherCode'] = self.voucher_code
        if self.voucher_id is not None:
            result['voucherId'] = self.voucher_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountPeriod') is not None:
            self.account_period = m.get('accountPeriod')
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('receiptId') is not None:
            self.receipt_id = m.get('receiptId')
        if m.get('voucherCode') is not None:
            self.voucher_code = m.get('voucherCode')
        if m.get('voucherId') is not None:
            self.voucher_id = m.get('voucherId')
        return self


class UpdateReceiptVoucherStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateReceiptVoucherStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateReceiptVoucherStatusResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = UpdateReceiptVoucherStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


