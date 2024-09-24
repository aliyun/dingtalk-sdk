# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import List, Dict


class RoleMemberMapValueMemberList(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        nick: str = None,
        avatar_url: str = None,
    ):
        self.user_id = user_id
        self.nick = nick
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
        company_code: str = None,
    ):
        self.role_code = role_code
        self.member_list = member_list
        self.company_code = company_code

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
        if self.company_code is not None:
            result['companyCode'] = self.company_code
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
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        return self


class AppendRolePermissionHeaders(TeaModel):
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


class AppendRolePermissionRequestRolePermissionItemListPermissionList(TeaModel):
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


class AppendRolePermissionRequestRolePermissionItemList(TeaModel):
    def __init__(
        self,
        permission_list: List[AppendRolePermissionRequestRolePermissionItemListPermissionList] = None,
        role_code: str = None,
    ):
        self.permission_list = permission_list
        self.role_code = role_code

    def validate(self):
        if self.permission_list:
            for k in self.permission_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['permissionList'] = []
        if self.permission_list is not None:
            for k in self.permission_list:
                result['permissionList'].append(k.to_map() if k else None)
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.permission_list = []
        if m.get('permissionList') is not None:
            for k in m.get('permissionList'):
                temp_model = AppendRolePermissionRequestRolePermissionItemListPermissionList()
                self.permission_list.append(temp_model.from_map(k))
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        return self


class AppendRolePermissionRequest(TeaModel):
    def __init__(
        self,
        role_permission_item_list: List[AppendRolePermissionRequestRolePermissionItemList] = None,
        user_id: str = None,
    ):
        self.role_permission_item_list = role_permission_item_list
        self.user_id = user_id

    def validate(self):
        if self.role_permission_item_list:
            for k in self.role_permission_item_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['rolePermissionItemList'] = []
        if self.role_permission_item_list is not None:
            for k in self.role_permission_item_list:
                result['rolePermissionItemList'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.role_permission_item_list = []
        if m.get('rolePermissionItemList') is not None:
            for k in m.get('rolePermissionItemList'):
                temp_model = AppendRolePermissionRequestRolePermissionItemList()
                self.role_permission_item_list.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AppendRolePermissionShrinkRequest(TeaModel):
    def __init__(
        self,
        role_permission_item_list_shrink: str = None,
        user_id: str = None,
    ):
        self.role_permission_item_list_shrink = role_permission_item_list_shrink
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_permission_item_list_shrink is not None:
            result['rolePermissionItemList'] = self.role_permission_item_list_shrink
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('rolePermissionItemList') is not None:
            self.role_permission_item_list_shrink = m.get('rolePermissionItemList')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AppendRolePermissionResponseBody(TeaModel):
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


class AppendRolePermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AppendRolePermissionResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = AppendRolePermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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
        goods_name: str = None,
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
        self.amount = amount
        self.goods_name = goods_name
        self.quantity = quantity
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.specification = specification
        self.tax_amount = tax_amount
        self.tax_pre = tax_pre
        self.tax_pre_type = tax_pre_type
        self.tax_rate = tax_rate
        self.unit = unit
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
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
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
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
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
        self.amount = amount
        self.card_no = card_no
        self.end_date = end_date
        self.goods_name = goods_name
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.start_date = start_date
        self.tax_amount = tax_amount
        self.tax_rate = tax_rate
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
        self.auction_unit = auction_unit
        self.auction_unit_address = auction_unit_address
        self.auction_unit_bank = auction_unit_bank
        self.auction_unit_tax_no = auction_unit_tax_no
        self.auction_util_tel = auction_util_tel
        self.car_model = car_model
        self.card_no = card_no
        self.registration = registration
        self.transfer_vehicle = transfer_vehicle
        self.used_car_address = used_car_address
        self.used_car_market = used_car_market
        self.used_car_market_bank = used_car_market_bank
        self.used_car_market_phone = used_car_market_phone
        self.used_car_market_tax_no = used_car_market_tax_no
        self.vehicle_no = vehicle_no
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
        self.brand = brand
        self.certificate_no = certificate_no
        self.engine_no = engine_no
        self.id_card_no = id_card_no
        self.import_certificate_no = import_certificate_no
        self.inspection_list_no = inspection_list_no
        self.max_passengers = max_passengers
        self.origin_place = origin_place
        self.payment_voucher_no = payment_voucher_no
        self.tax_authority_name = tax_authority_name
        self.tax_authority_no = tax_authority_no
        self.tax_rate = tax_rate
        self.tonnage = tonnage
        self.vehicle_no = vehicle_no
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
        drawer_name: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        file_id: str = None,
        finance_type: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList] = None,
        image_url: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_status: str = None,
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
        receiver_email: str = None,
        receiver_name: str = None,
        receiver_tel: str = None,
        remark: str = None,
        reviewer: str = None,
        second_hand_car_invoice_detail_list: List[BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList] = None,
        seller_address: str = None,
        seller_bank_account: str = None,
        seller_bank_name_account: str = None,
        seller_name: str = None,
        seller_tax_no: str = None,
        seller_tel: str = None,
        space_id: str = None,
        supply_sign: str = None,
        tax_amount: str = None,
        used_vehicle_sale_detail_volist: List[BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        self.account_period = account_period
        self.amount = amount
        self.amount_with_tax = amount_with_tax
        self.check_code = check_code
        self.check_time = check_time
        self.drawer_name = drawer_name
        self.drew_date = drew_date
        self.electronic_url = electronic_url
        self.file_id = file_id
        self.finance_type = finance_type
        self.fund_type = fund_type
        self.general_invoice_detail_volist = general_invoice_detail_volist
        self.image_url = image_url
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no
        self.invoice_status = invoice_status
        self.invoice_type = invoice_type
        self.machine_code = machine_code
        self.oil_flag = oil_flag
        self.payee = payee
        self.process_inst_code = process_inst_code
        self.process_inst_type = process_inst_type
        self.purchaser_address = purchaser_address
        self.purchaser_bank_account = purchaser_bank_account
        self.purchaser_bank_name_account = purchaser_bank_name_account
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel
        self.receiver_email = receiver_email
        self.receiver_name = receiver_name
        self.receiver_tel = receiver_tel
        self.remark = remark
        self.reviewer = reviewer
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        self.seller_address = seller_address
        self.seller_bank_account = seller_bank_account
        self.seller_bank_name_account = seller_bank_name_account
        self.seller_name = seller_name
        self.seller_tax_no = seller_tax_no
        self.seller_tel = seller_tel
        self.space_id = space_id
        self.supply_sign = supply_sign
        self.tax_amount = tax_amount
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        self.verify_status = verify_status
        self.voucher_code = voucher_code
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
        if self.drawer_name is not None:
            result['drawerName'] = self.drawer_name
        if self.drew_date is not None:
            result['drewDate'] = self.drew_date
        if self.electronic_url is not None:
            result['electronicUrl'] = self.electronic_url
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.finance_type is not None:
            result['financeType'] = self.finance_type
        if self.fund_type is not None:
            result['fundType'] = self.fund_type
        result['generalInvoiceDetailVOList'] = []
        if self.general_invoice_detail_volist is not None:
            for k in self.general_invoice_detail_volist:
                result['generalInvoiceDetailVOList'].append(k.to_map() if k else None)
        if self.image_url is not None:
            result['imageUrl'] = self.image_url
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_status is not None:
            result['invoiceStatus'] = self.invoice_status
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
        if self.receiver_email is not None:
            result['receiverEmail'] = self.receiver_email
        if self.receiver_name is not None:
            result['receiverName'] = self.receiver_name
        if self.receiver_tel is not None:
            result['receiverTel'] = self.receiver_tel
        if self.remark is not None:
            result['remark'] = self.remark
        if self.reviewer is not None:
            result['reviewer'] = self.reviewer
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
        if self.space_id is not None:
            result['spaceId'] = self.space_id
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
        if m.get('drawerName') is not None:
            self.drawer_name = m.get('drawerName')
        if m.get('drewDate') is not None:
            self.drew_date = m.get('drewDate')
        if m.get('electronicUrl') is not None:
            self.electronic_url = m.get('electronicUrl')
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('financeType') is not None:
            self.finance_type = m.get('financeType')
        if m.get('fundType') is not None:
            self.fund_type = m.get('fundType')
        self.general_invoice_detail_volist = []
        if m.get('generalInvoiceDetailVOList') is not None:
            for k in m.get('generalInvoiceDetailVOList'):
                temp_model = BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList()
                self.general_invoice_detail_volist.append(temp_model.from_map(k))
        if m.get('imageUrl') is not None:
            self.image_url = m.get('imageUrl')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceStatus') is not None:
            self.invoice_status = m.get('invoiceStatus')
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
        if m.get('receiverEmail') is not None:
            self.receiver_email = m.get('receiverEmail')
        if m.get('receiverName') is not None:
            self.receiver_name = m.get('receiverName')
        if m.get('receiverTel') is not None:
            self.receiver_tel = m.get('receiverTel')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('reviewer') is not None:
            self.reviewer = m.get('reviewer')
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
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
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
        company_code: str = None,
        general_invoice_volist: List[BatchAddInvoiceRequestGeneralInvoiceVOList] = None,
        operator: str = None,
        order_id: str = None,
        source: str = None,
    ):
        self.company_code = company_code
        self.general_invoice_volist = general_invoice_volist
        self.operator = operator
        self.order_id = order_id
        self.source = source

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
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        result['generalInvoiceVOList'] = []
        if self.general_invoice_volist is not None:
            for k in self.general_invoice_volist:
                result['generalInvoiceVOList'].append(k.to_map() if k else None)
        if self.operator is not None:
            result['operator'] = self.operator
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.source is not None:
            result['source'] = self.source
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        self.general_invoice_volist = []
        if m.get('generalInvoiceVOList') is not None:
            for k in m.get('generalInvoiceVOList'):
                temp_model = BatchAddInvoiceRequestGeneralInvoiceVOList()
                self.general_invoice_volist.append(temp_model.from_map(k))
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('source') is not None:
            self.source = m.get('source')
        return self


class BatchAddInvoiceResponseBodyErrorResult(TeaModel):
    def __init__(
        self,
        error_key: str = None,
        error_msg: str = None,
    ):
        self.error_key = error_key
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


class BatchAddInvoiceResponseBodySuccessResult(TeaModel):
    def __init__(
        self,
        invoice_code: str = None,
        invoice_no: str = None,
    ):
        self.invoice_code = invoice_code
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


class BatchAddInvoiceResponseBody(TeaModel):
    def __init__(
        self,
        error_result: List[BatchAddInvoiceResponseBodyErrorResult] = None,
        success_result: List[BatchAddInvoiceResponseBodySuccessResult] = None,
    ):
        self.error_result = error_result
        self.success_result = success_result

    def validate(self):
        if self.error_result:
            for k in self.error_result:
                if k:
                    k.validate()
        if self.success_result:
            for k in self.success_result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['errorResult'] = []
        if self.error_result is not None:
            for k in self.error_result:
                result['errorResult'].append(k.to_map() if k else None)
        result['successResult'] = []
        if self.success_result is not None:
            for k in self.success_result:
                result['successResult'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.error_result = []
        if m.get('errorResult') is not None:
            for k in m.get('errorResult'):
                temp_model = BatchAddInvoiceResponseBodyErrorResult()
                self.error_result.append(temp_model.from_map(k))
        self.success_result = []
        if m.get('successResult') is not None:
            for k in m.get('successResult'):
                temp_model = BatchAddInvoiceResponseBodySuccessResult()
                self.success_result.append(temp_model.from_map(k))
        return self


class BatchAddInvoiceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchAddInvoiceResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = BatchAddInvoiceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchCreateCustomerHeaders(TeaModel):
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


class BatchCreateCustomerRequestCreateCustomerRequestList(TeaModel):
    def __init__(
        self,
        description: str = None,
        drawer_email: str = None,
        drawer_telephone: str = None,
        name: str = None,
        purchaser_account: str = None,
        purchaser_address: str = None,
        purchaser_bank_name: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
    ):
        self.description = description
        self.drawer_email = drawer_email
        self.drawer_telephone = drawer_telephone
        # This parameter is required.
        self.name = name
        self.purchaser_account = purchaser_account
        self.purchaser_address = purchaser_address
        self.purchaser_bank_name = purchaser_bank_name
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.drawer_email is not None:
            result['drawerEmail'] = self.drawer_email
        if self.drawer_telephone is not None:
            result['drawerTelephone'] = self.drawer_telephone
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
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('drawerEmail') is not None:
            self.drawer_email = m.get('drawerEmail')
        if m.get('drawerTelephone') is not None:
            self.drawer_telephone = m.get('drawerTelephone')
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


class BatchCreateCustomerRequest(TeaModel):
    def __init__(
        self,
        create_customer_request_list: List[BatchCreateCustomerRequestCreateCustomerRequestList] = None,
        operator: str = None,
    ):
        self.create_customer_request_list = create_customer_request_list
        # This parameter is required.
        self.operator = operator

    def validate(self):
        if self.create_customer_request_list:
            for k in self.create_customer_request_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['createCustomerRequestList'] = []
        if self.create_customer_request_list is not None:
            for k in self.create_customer_request_list:
                result['createCustomerRequestList'].append(k.to_map() if k else None)
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.create_customer_request_list = []
        if m.get('createCustomerRequestList') is not None:
            for k in m.get('createCustomerRequestList'):
                temp_model = BatchCreateCustomerRequestCreateCustomerRequestList()
                self.create_customer_request_list.append(temp_model.from_map(k))
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class BatchCreateCustomerResponseBodyErrorResult(TeaModel):
    def __init__(
        self,
        error_key: str = None,
        error_msg: str = None,
    ):
        self.error_key = error_key
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


class BatchCreateCustomerResponseBody(TeaModel):
    def __init__(
        self,
        error_result: List[BatchCreateCustomerResponseBodyErrorResult] = None,
        success: bool = None,
    ):
        self.error_result = error_result
        self.success = success

    def validate(self):
        if self.error_result:
            for k in self.error_result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['errorResult'] = []
        if self.error_result is not None:
            for k in self.error_result:
                result['errorResult'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.error_result = []
        if m.get('errorResult') is not None:
            for k in m.get('errorResult'):
                temp_model = BatchCreateCustomerResponseBodyErrorResult()
                self.error_result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class BatchCreateCustomerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchCreateCustomerResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = BatchCreateCustomerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BeginConsumeHeaders(TeaModel):
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


class BeginConsumeRequest(TeaModel):
    def __init__(
        self,
        benefit_code: str = None,
        biz_request_id: str = None,
        quota: int = None,
        user_id: str = None,
    ):
        self.benefit_code = benefit_code
        self.biz_request_id = biz_request_id
        self.quota = quota
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.benefit_code is not None:
            result['benefitCode'] = self.benefit_code
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.quota is not None:
            result['quota'] = self.quota
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('benefitCode') is not None:
            self.benefit_code = m.get('benefitCode')
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('quota') is not None:
            self.quota = m.get('quota')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BeginConsumeResponseBodyResult(TeaModel):
    def __init__(
        self,
        is_success: bool = None,
    ):
        self.is_success = is_success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_success is not None:
            result['isSuccess'] = self.is_success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSuccess') is not None:
            self.is_success = m.get('isSuccess')
        return self


class BeginConsumeResponseBody(TeaModel):
    def __init__(
        self,
        result: BeginConsumeResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = BeginConsumeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class BeginConsumeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BeginConsumeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = BeginConsumeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BindCompanyAccountantBookHeaders(TeaModel):
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


class BindCompanyAccountantBookRequest(TeaModel):
    def __init__(
        self,
        accountant_book_id: str = None,
        company_code: str = None,
    ):
        # This parameter is required.
        self.accountant_book_id = accountant_book_id
        self.company_code = company_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id is not None:
            result['accountantBookId'] = self.accountant_book_id
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountantBookId') is not None:
            self.accountant_book_id = m.get('accountantBookId')
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        return self


class BindCompanyAccountantBookResponseBody(TeaModel):
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


class BindCompanyAccountantBookResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BindCompanyAccountantBookResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = BindCompanyAccountantBookResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CancelConsumeHeaders(TeaModel):
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


class CancelConsumeRequest(TeaModel):
    def __init__(
        self,
        benefit_code: str = None,
        biz_request_id: str = None,
        quota: int = None,
        user_id: str = None,
    ):
        self.benefit_code = benefit_code
        self.biz_request_id = biz_request_id
        self.quota = quota
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.benefit_code is not None:
            result['benefitCode'] = self.benefit_code
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.quota is not None:
            result['quota'] = self.quota
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('benefitCode') is not None:
            self.benefit_code = m.get('benefitCode')
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('quota') is not None:
            self.quota = m.get('quota')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CancelConsumeResponseBodyResult(TeaModel):
    def __init__(
        self,
        is_success: bool = None,
    ):
        self.is_success = is_success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_success is not None:
            result['isSuccess'] = self.is_success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSuccess') is not None:
            self.is_success = m.get('isSuccess')
        return self


class CancelConsumeResponseBody(TeaModel):
    def __init__(
        self,
        result: CancelConsumeResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = CancelConsumeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CancelConsumeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CancelConsumeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = CancelConsumeResponseBody()
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
        company_code: str = None,
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
        self.company_code = company_code
        self.end_time = end_time
        self.finance_type = finance_type
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no
        self.page_number = page_number
        self.page_size = page_size
        self.start_time = start_time
        self.tax_no = tax_no
        self.verify_status = verify_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_code is not None:
            result['companyCode'] = self.company_code
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
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
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
        status_code: int = None,
        body: CheckVoucherStatusResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = CheckVoucherStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CommitConsumeHeaders(TeaModel):
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


class CommitConsumeRequest(TeaModel):
    def __init__(
        self,
        benefit_code: str = None,
        biz_request_id: str = None,
        quota: int = None,
        user_id: str = None,
    ):
        self.benefit_code = benefit_code
        self.biz_request_id = biz_request_id
        self.quota = quota
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.benefit_code is not None:
            result['benefitCode'] = self.benefit_code
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.quota is not None:
            result['quota'] = self.quota
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('benefitCode') is not None:
            self.benefit_code = m.get('benefitCode')
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('quota') is not None:
            self.quota = m.get('quota')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CommitConsumeResponseBodyResult(TeaModel):
    def __init__(
        self,
        is_success: bool = None,
    ):
        self.is_success = is_success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_success is not None:
            result['isSuccess'] = self.is_success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSuccess') is not None:
            self.is_success = m.get('isSuccess')
        return self


class CommitConsumeResponseBody(TeaModel):
    def __init__(
        self,
        result: CommitConsumeResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = CommitConsumeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CommitConsumeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CommitConsumeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = CommitConsumeResponseBody()
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
        drawer_email: str = None,
        drawer_telephone: str = None,
        name: str = None,
        purchaser_account: str = None,
        purchaser_address: str = None,
        purchaser_bank_name: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
    ):
        # This parameter is required.
        self.creator = creator
        self.description = description
        self.drawer_email = drawer_email
        self.drawer_telephone = drawer_telephone
        # This parameter is required.
        self.name = name
        self.purchaser_account = purchaser_account
        self.purchaser_address = purchaser_address
        self.purchaser_bank_name = purchaser_bank_name
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
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
        if self.drawer_email is not None:
            result['drawerEmail'] = self.drawer_email
        if self.drawer_telephone is not None:
            result['drawerTelephone'] = self.drawer_telephone
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
        if m.get('drawerEmail') is not None:
            self.drawer_email = m.get('drawerEmail')
        if m.get('drawerTelephone') is not None:
            self.drawer_telephone = m.get('drawerTelephone')
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
        status_code: int = None,
        body: CreateCustomerResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.category_code = category_code
        # This parameter is required.
        self.code = code
        self.create_time = create_time
        # This parameter is required.
        self.create_user_id = create_user_id
        self.customer_code = customer_code
        self.enterprise_acount_code = enterprise_acount_code
        self.occur_date = occur_date
        self.principal_id = principal_id
        self.project_code = project_code
        # This parameter is required.
        self.receipt_type = receipt_type
        self.remark = remark
        self.supplier_code = supplier_code
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
        # This parameter is required.
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
        # This parameter is required.
        self.code = code
        self.error_code = error_code
        self.error_msg = error_msg
        # This parameter is required.
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
        # This parameter is required.
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
        status_code: int = None,
        body: CreateReceiptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.delete_user_id = delete_user_id
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
        self.code = code
        self.error_code = error_code
        self.error_msg = error_msg
        # This parameter is required.
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
        # This parameter is required.
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
        status_code: int = None,
        body: DeleteReceiptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        # This parameter is required.
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
        status_code: int = None,
        body: GetBookkeepingUserListResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        # This parameter is required.
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
        accountant_book_id_list: List[str] = None,
        code: str = None,
        is_dir: bool = None,
        name: str = None,
        parent_code: str = None,
        remark: str = None,
        status: str = None,
        type: str = None,
    ):
        self.accountant_book_id_list = accountant_book_id_list
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.is_dir = is_dir
        # This parameter is required.
        self.name = name
        self.parent_code = parent_code
        self.remark = remark
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id_list is not None:
            result['accountantBookIdList'] = self.accountant_book_id_list
        if self.code is not None:
            result['code'] = self.code
        if self.is_dir is not None:
            result['isDir'] = self.is_dir
        if self.name is not None:
            result['name'] = self.name
        if self.parent_code is not None:
            result['parentCode'] = self.parent_code
        if self.remark is not None:
            result['remark'] = self.remark
        if self.status is not None:
            result['status'] = self.status
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountantBookIdList') is not None:
            self.accountant_book_id_list = m.get('accountantBookIdList')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('isDir') is not None:
            self.is_dir = m.get('isDir')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentCode') is not None:
            self.parent_code = m.get('parentCode')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetCategoryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCategoryResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        # This parameter is required.
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
        accountant_book_id_list: List[str] = None,
        code: str = None,
        create_time: int = None,
        description: str = None,
        name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        self.accountant_book_id_list = accountant_book_id_list
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.description = description
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.status = status
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id_list is not None:
            result['accountantBookIdList'] = self.accountant_book_id_list
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
        if m.get('accountantBookIdList') is not None:
            self.accountant_book_id_list = m.get('accountantBookIdList')
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
        status_code: int = None,
        body: GetCustomerResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        # This parameter is required.
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
        accountant_book_id_list: List[str] = None,
        amount: str = None,
        bank_code: str = None,
        bank_name: str = None,
        create_time: int = None,
        creator: str = None,
    ):
        # This parameter is required.
        self.account_code = account_code
        self.account_id = account_id
        # This parameter is required.
        self.account_name = account_name
        self.account_remark = account_remark
        # This parameter is required.
        self.account_type = account_type
        self.accountant_book_id_list = accountant_book_id_list
        self.amount = amount
        self.bank_code = bank_code
        self.bank_name = bank_name
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
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
        if self.accountant_book_id_list is not None:
            result['accountantBookIdList'] = self.accountant_book_id_list
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
        if m.get('accountantBookIdList') is not None:
            self.accountant_book_id_list = m.get('accountantBookIdList')
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
        status_code: int = None,
        body: GetFinanceAccountResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = GetFinanceAccountResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFormTemplateInfoHeaders(TeaModel):
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


class GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList(TeaModel):
    def __init__(
        self,
        binding_val: str = None,
        code: str = None,
        name: str = None,
        type: str = None,
    ):
        self.binding_val = binding_val
        self.code = code
        self.name = name
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.binding_val is not None:
            result['bindingVal'] = self.binding_val
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bindingVal') is not None:
            self.binding_val = m.get('bindingVal')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList(TeaModel):
    def __init__(
        self,
        component_list: List[GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList] = None,
        name: str = None,
        process_code: str = None,
        status: str = None,
        suite_id: str = None,
    ):
        self.component_list = component_list
        self.name = name
        self.process_code = process_code
        self.status = status
        self.suite_id = suite_id

    def validate(self):
        if self.component_list:
            for k in self.component_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['componentList'] = []
        if self.component_list is not None:
            for k in self.component_list:
                result['componentList'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.status is not None:
            result['status'] = self.status
        if self.suite_id is not None:
            result['suiteId'] = self.suite_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.component_list = []
        if m.get('componentList') is not None:
            for k in m.get('componentList'):
                temp_model = GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList()
                self.component_list.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('suiteId') is not None:
            self.suite_id = m.get('suiteId')
        return self


class GetFormTemplateInfoResponseBody(TeaModel):
    def __init__(
        self,
        receipt_form_template_info_list: List[GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList] = None,
    ):
        # This parameter is required.
        self.receipt_form_template_info_list = receipt_form_template_info_list

    def validate(self):
        if self.receipt_form_template_info_list:
            for k in self.receipt_form_template_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['receiptFormTemplateInfoList'] = []
        if self.receipt_form_template_info_list is not None:
            for k in self.receipt_form_template_info_list:
                result['receiptFormTemplateInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.receipt_form_template_info_list = []
        if m.get('receiptFormTemplateInfoList') is not None:
            for k in m.get('receiptFormTemplateInfoList'):
                temp_model = GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList()
                self.receipt_form_template_info_list.append(temp_model.from_map(k))
        return self


class GetFormTemplateInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFormTemplateInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = GetFormTemplateInfoResponseBody()
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
        accountant_book_id: str = None,
        company_code: str = None,
        end_time: int = None,
        finance_type: str = None,
        page_number: int = None,
        page_size: int = None,
        start_time: int = None,
        tax_no: str = None,
        verify_status: str = None,
    ):
        self.accountant_book_id = accountant_book_id
        self.company_code = company_code
        self.end_time = end_time
        self.finance_type = finance_type
        self.page_number = page_number
        self.page_size = page_size
        self.start_time = start_time
        self.tax_no = tax_no
        self.verify_status = verify_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id is not None:
            result['accountantBookId'] = self.accountant_book_id
        if self.company_code is not None:
            result['companyCode'] = self.company_code
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
        if m.get('accountantBookId') is not None:
            self.accountant_book_id = m.get('accountantBookId')
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
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
        goods_name: str = None,
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
        self.amount = amount
        self.goods_name = goods_name
        self.quantity = quantity
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.specification = specification
        self.tax_amount = tax_amount
        self.tax_pre = tax_pre
        self.tax_rate = tax_rate
        self.unit = unit
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
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
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
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
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


class GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList(TeaModel):
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
        self.amount = amount
        self.card_no = card_no
        self.end_date = end_date
        self.goods_name = goods_name
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.start_date = start_date
        self.tax_amount = tax_amount
        self.tax_rate = tax_rate
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
        self.auction_unit = auction_unit
        self.auction_unit_address = auction_unit_address
        self.auction_unit_bank = auction_unit_bank
        self.auction_unit_tax_no = auction_unit_tax_no
        self.auction_util_tel = auction_util_tel
        self.car_model = car_model
        self.card_no = card_no
        self.registration = registration
        self.transfer_vehicle = transfer_vehicle
        self.used_car_address = used_car_address
        self.used_car_market = used_car_market
        self.used_car_market_bank = used_car_market_bank
        self.used_car_market_phone = used_car_market_phone
        self.used_car_market_tax_no = used_car_market_tax_no
        self.vehicle_no = vehicle_no
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
        self.brand = brand
        self.certificate_no = certificate_no
        self.engine_no = engine_no
        self.id_card_no = id_card_no
        self.import_certificate_no = import_certificate_no
        self.max_passengers = max_passengers
        self.origin_place = origin_place
        self.payment_voucher_no = payment_voucher_no
        self.tax_authority_name = tax_authority_name
        self.tax_authority_no = tax_authority_no
        self.tax_rate = tax_rate
        self.tonnage = tonnage
        self.vehicle_no = vehicle_no
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
        image_url: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_status: str = None,
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
        seller_address: str = None,
        seller_bank_name_account: str = None,
        seller_name: str = None,
        seller_tax_no: str = None,
        seller_tel: str = None,
        status: str = None,
        supply_sign: str = None,
        tax_amount: str = None,
        transport_fee_detail_volist: List[GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList] = None,
        used_vehicle_sale_detail_volist: List[GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        self.account_period = account_period
        self.amount = amount
        self.amount_with_tax = amount_with_tax
        self.check_code = check_code
        self.check_time = check_time
        self.drew_date = drew_date
        self.electronic_url = electronic_url
        self.finance_type = finance_type
        self.fund_type = fund_type
        self.general_invoice_detail_volist = general_invoice_detail_volist
        self.image_url = image_url
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no
        self.invoice_status = invoice_status
        self.invoice_type = invoice_type
        self.machine_code = machine_code
        self.oil_flag = oil_flag
        self.payee = payee
        self.process_inst_code = process_inst_code
        self.process_inst_type = process_inst_type
        self.purchaser_address = purchaser_address
        self.purchaser_bank_name_account = purchaser_bank_name_account
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel
        self.remark = remark
        self.seller_address = seller_address
        self.seller_bank_name_account = seller_bank_name_account
        self.seller_name = seller_name
        self.seller_tax_no = seller_tax_no
        self.seller_tel = seller_tel
        self.status = status
        self.supply_sign = supply_sign
        self.tax_amount = tax_amount
        self.transport_fee_detail_volist = transport_fee_detail_volist
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        self.verify_status = verify_status
        self.voucher_code = voucher_code
        self.voucher_status = voucher_status

    def validate(self):
        if self.general_invoice_detail_volist:
            for k in self.general_invoice_detail_volist:
                if k:
                    k.validate()
        if self.transport_fee_detail_volist:
            for k in self.transport_fee_detail_volist:
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
        if self.image_url is not None:
            result['imageUrl'] = self.image_url
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_status is not None:
            result['invoiceStatus'] = self.invoice_status
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
        result['transportFeeDetailVOList'] = []
        if self.transport_fee_detail_volist is not None:
            for k in self.transport_fee_detail_volist:
                result['transportFeeDetailVOList'].append(k.to_map() if k else None)
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
        if m.get('imageUrl') is not None:
            self.image_url = m.get('imageUrl')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceStatus') is not None:
            self.invoice_status = m.get('invoiceStatus')
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
        self.transport_fee_detail_volist = []
        if m.get('transportFeeDetailVOList') is not None:
            for k in m.get('transportFeeDetailVOList'):
                temp_model = GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList()
                self.transport_fee_detail_volist.append(temp_model.from_map(k))
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
        status_code: int = None,
        body: GetInvoiceByPageResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        status_code: int = None,
        body: GetIsNewVersionResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = GetIsNewVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetMultiCompanyInfoByCodeHeaders(TeaModel):
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


class GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList(TeaModel):
    def __init__(
        self,
        advanced_setting_key: str = None,
        advanced_setting_name: str = None,
        end_date: int = None,
        value: bool = None,
    ):
        self.advanced_setting_key = advanced_setting_key
        self.advanced_setting_name = advanced_setting_name
        self.end_date = end_date
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.advanced_setting_key is not None:
            result['advancedSettingKey'] = self.advanced_setting_key
        if self.advanced_setting_name is not None:
            result['advancedSettingName'] = self.advanced_setting_name
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('advancedSettingKey') is not None:
            self.advanced_setting_key = m.get('advancedSettingKey')
        if m.get('advancedSettingName') is not None:
            self.advanced_setting_name = m.get('advancedSettingName')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetMultiCompanyInfoByCodeResponseBody(TeaModel):
    def __init__(
        self,
        advanced_setting_list: List[GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList] = None,
        company_code: str = None,
        company_name: str = None,
        remark: str = None,
        status: str = None,
        tax_nature: str = None,
        tax_no: str = None,
    ):
        self.advanced_setting_list = advanced_setting_list
        self.company_code = company_code
        self.company_name = company_name
        self.remark = remark
        self.status = status
        self.tax_nature = tax_nature
        self.tax_no = tax_no

    def validate(self):
        if self.advanced_setting_list:
            for k in self.advanced_setting_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['advancedSettingList'] = []
        if self.advanced_setting_list is not None:
            for k in self.advanced_setting_list:
                result['advancedSettingList'].append(k.to_map() if k else None)
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.company_name is not None:
            result['companyName'] = self.company_name
        if self.remark is not None:
            result['remark'] = self.remark
        if self.status is not None:
            result['status'] = self.status
        if self.tax_nature is not None:
            result['taxNature'] = self.tax_nature
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.advanced_setting_list = []
        if m.get('advancedSettingList') is not None:
            for k in m.get('advancedSettingList'):
                temp_model = GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList()
                self.advanced_setting_list.append(temp_model.from_map(k))
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('companyName') is not None:
            self.company_name = m.get('companyName')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taxNature') is not None:
            self.tax_nature = m.get('taxNature')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        return self


class GetMultiCompanyInfoByCodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetMultiCompanyInfoByCodeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = GetMultiCompanyInfoByCodeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProductHeaders(TeaModel):
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


class GetProductRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        # This parameter is required.
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


class GetProductResponseBody(TeaModel):
    def __init__(
        self,
        accountant_book_id_list: List[str] = None,
        code: str = None,
        create_time: int = None,
        description: str = None,
        information: str = None,
        name: str = None,
        specification: str = None,
        status: str = None,
        unit: str = None,
        user_define_code: str = None,
    ):
        self.accountant_book_id_list = accountant_book_id_list
        self.code = code
        self.create_time = create_time
        self.description = description
        self.information = information
        self.name = name
        self.specification = specification
        self.status = status
        self.unit = unit
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id_list is not None:
            result['accountantBookIdList'] = self.accountant_book_id_list
        if self.code is not None:
            result['code'] = self.code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.information is not None:
            result['information'] = self.information
        if self.name is not None:
            result['name'] = self.name
        if self.specification is not None:
            result['specification'] = self.specification
        if self.status is not None:
            result['status'] = self.status
        if self.unit is not None:
            result['unit'] = self.unit
        if self.user_define_code is not None:
            result['userDefineCode'] = self.user_define_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountantBookIdList') is not None:
            self.accountant_book_id_list = m.get('accountantBookIdList')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('information') is not None:
            self.information = m.get('information')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class GetProductResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetProductResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = GetProductResponseBody()
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
        # This parameter is required.
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
        accountant_book_id_list: List[str] = None,
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
        self.accountant_book_id_list = accountant_book_id_list
        self.code = code
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.creator = creator
        # This parameter is required.
        self.description = description
        self.name = name
        # This parameter is required.
        self.project_code = project_code
        # This parameter is required.
        self.project_name = project_name
        # This parameter is required.
        self.status = status
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id_list is not None:
            result['accountantBookIdList'] = self.accountant_book_id_list
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
        if m.get('accountantBookIdList') is not None:
            self.accountant_book_id_list = m.get('accountantBookIdList')
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
        status_code: int = None,
        body: GetProjectResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        # This parameter is required.
        self.code = code
        # This parameter is required.
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
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.data = data
        # This parameter is required.
        self.model_id = model_id
        # This parameter is required.
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
        status_code: int = None,
        body: GetReceiptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        # This parameter is required.
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
        accountant_book_id_list: List[str] = None,
        code: str = None,
        create_time: int = None,
        description: str = None,
        name: str = None,
        status: str = None,
        user_define_code: str = None,
    ):
        self.accountant_book_id_list = accountant_book_id_list
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.description = description
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.status = status
        self.user_define_code = user_define_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id_list is not None:
            result['accountantBookIdList'] = self.accountant_book_id_list
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
        if m.get('accountantBookIdList') is not None:
            self.accountant_book_id_list = m.get('accountantBookIdList')
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
        status_code: int = None,
        body: GetSupplierResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = GetSupplierResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetYongYouOpenApiTokenHeaders(TeaModel):
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


class GetYongYouOpenApiTokenRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # This parameter is required.
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


class GetYongYouOpenApiTokenResponseBody(TeaModel):
    def __init__(
        self,
        access_token: str = None,
        app_name: str = None,
        expires_in: str = None,
        refresh_expires_in: str = None,
        refresh_token: str = None,
        scope: str = None,
        sid: str = None,
        yongyou_org_id: str = None,
        yongyou_user_id: str = None,
    ):
        self.access_token = access_token
        self.app_name = app_name
        self.expires_in = expires_in
        self.refresh_expires_in = refresh_expires_in
        self.refresh_token = refresh_token
        self.scope = scope
        self.sid = sid
        self.yongyou_org_id = yongyou_org_id
        self.yongyou_user_id = yongyou_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_token is not None:
            result['accessToken'] = self.access_token
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.expires_in is not None:
            result['expiresIn'] = self.expires_in
        if self.refresh_expires_in is not None:
            result['refreshExpiresIn'] = self.refresh_expires_in
        if self.refresh_token is not None:
            result['refreshToken'] = self.refresh_token
        if self.scope is not None:
            result['scope'] = self.scope
        if self.sid is not None:
            result['sid'] = self.sid
        if self.yongyou_org_id is not None:
            result['yongyouOrgId'] = self.yongyou_org_id
        if self.yongyou_user_id is not None:
            result['yongyouUserId'] = self.yongyou_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessToken') is not None:
            self.access_token = m.get('accessToken')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('expiresIn') is not None:
            self.expires_in = m.get('expiresIn')
        if m.get('refreshExpiresIn') is not None:
            self.refresh_expires_in = m.get('refreshExpiresIn')
        if m.get('refreshToken') is not None:
            self.refresh_token = m.get('refreshToken')
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('sid') is not None:
            self.sid = m.get('sid')
        if m.get('yongyouOrgId') is not None:
            self.yongyou_org_id = m.get('yongyouOrgId')
        if m.get('yongyouUserId') is not None:
            self.yongyou_user_id = m.get('yongyouUserId')
        return self


class GetYongYouOpenApiTokenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetYongYouOpenApiTokenResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = GetYongYouOpenApiTokenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetYongYouOrgRelationHeaders(TeaModel):
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


class GetYongYouOrgRelationResponseBody(TeaModel):
    def __init__(
        self,
        chanjet_corp_id: str = None,
        chanjet_user_id: str = None,
        corp_id: str = None,
        user_id: str = None,
    ):
        self.chanjet_corp_id = chanjet_corp_id
        self.chanjet_user_id = chanjet_user_id
        self.corp_id = corp_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chanjet_corp_id is not None:
            result['chanjetCorpId'] = self.chanjet_corp_id
        if self.chanjet_user_id is not None:
            result['chanjetUserId'] = self.chanjet_user_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chanjetCorpId') is not None:
            self.chanjet_corp_id = m.get('chanjetCorpId')
        if m.get('chanjetUserId') is not None:
            self.chanjet_user_id = m.get('chanjetUserId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetYongYouOrgRelationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetYongYouOrgRelationResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = GetYongYouOrgRelationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ProfessionBenefitConsumeHeaders(TeaModel):
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


class ProfessionBenefitConsumeRequest(TeaModel):
    def __init__(
        self,
        benefit_code: str = None,
        biz_request_id: str = None,
        quota: int = None,
    ):
        self.benefit_code = benefit_code
        self.biz_request_id = biz_request_id
        self.quota = quota

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.benefit_code is not None:
            result['benefitCode'] = self.benefit_code
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.quota is not None:
            result['quota'] = self.quota
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('benefitCode') is not None:
            self.benefit_code = m.get('benefitCode')
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('quota') is not None:
            self.quota = m.get('quota')
        return self


class ProfessionBenefitConsumeResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ProfessionBenefitConsumeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ProfessionBenefitConsumeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = ProfessionBenefitConsumeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PushHistoricalReceiptsHeaders(TeaModel):
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


class PushHistoricalReceiptsRequest(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        end_time: int = None,
        forced_ignore_dup: bool = None,
        form_code_list: List[str] = None,
        start_time: int = None,
    ):
        # This parameter is required.
        self.biz_id = biz_id
        self.end_time = end_time
        self.forced_ignore_dup = forced_ignore_dup
        # This parameter is required.
        self.form_code_list = form_code_list
        # This parameter is required.
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.forced_ignore_dup is not None:
            result['forcedIgnoreDup'] = self.forced_ignore_dup
        if self.form_code_list is not None:
            result['formCodeList'] = self.form_code_list
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('forcedIgnoreDup') is not None:
            self.forced_ignore_dup = m.get('forcedIgnoreDup')
        if m.get('formCodeList') is not None:
            self.form_code_list = m.get('formCodeList')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class PushHistoricalReceiptsResponseBody(TeaModel):
    def __init__(
        self,
        task_id: str = None,
    ):
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class PushHistoricalReceiptsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PushHistoricalReceiptsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = PushHistoricalReceiptsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryBenefitHeaders(TeaModel):
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


class QueryBenefitRequest(TeaModel):
    def __init__(
        self,
        benefit_code: str = None,
    ):
        self.benefit_code = benefit_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.benefit_code is not None:
            result['benefitCode'] = self.benefit_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('benefitCode') is not None:
            self.benefit_code = m.get('benefitCode')
        return self


class QueryBenefitResponseBodyResult(TeaModel):
    def __init__(
        self,
        remain_quota: int = None,
        total_quota: int = None,
    ):
        self.remain_quota = remain_quota
        self.total_quota = total_quota

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.remain_quota is not None:
            result['remainQuota'] = self.remain_quota
        if self.total_quota is not None:
            result['totalQuota'] = self.total_quota
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('remainQuota') is not None:
            self.remain_quota = m.get('remainQuota')
        if m.get('totalQuota') is not None:
            self.total_quota = m.get('totalQuota')
        return self


class QueryBenefitResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryBenefitResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryBenefitResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryBenefitResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryBenefitResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryBenefitResponseBody()
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
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
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
        remark: str = None,
        status: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.is_dir = is_dir
        # This parameter is required.
        self.name = name
        self.parent_code = parent_code
        self.remark = remark
        # This parameter is required.
        self.status = status
        # This parameter is required.
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
        if self.remark is not None:
            result['remark'] = self.remark
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
        if m.get('remark') is not None:
            self.remark = m.get('remark')
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
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
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
        status_code: int = None,
        body: QueryCategoryByPageResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryCategoryByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCompanyInvoiceRelationCountHeaders(TeaModel):
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


class QueryCompanyInvoiceRelationCountRequest(TeaModel):
    def __init__(
        self,
        company_code: str = None,
    ):
        self.company_code = company_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        return self


class QueryCompanyInvoiceRelationCountResponseBody(TeaModel):
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


class QueryCompanyInvoiceRelationCountResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCompanyInvoiceRelationCountResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryCompanyInvoiceRelationCountResponseBody()
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
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
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
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.description = description
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.status = status
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
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
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
        status_code: int = None,
        body: QueryCustomerByPageResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        self.keyword = keyword
        self.page_number = page_number
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
        drawer_email: str = None,
        drawer_telephone: str = None,
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
        self.code = code
        self.contact_address = contact_address
        self.contact_company_telephone = contact_company_telephone
        self.contact_email = contact_email
        self.contact_name = contact_name
        self.contact_telephone = contact_telephone
        self.description = description
        self.drawer_email = drawer_email
        self.drawer_telephone = drawer_telephone
        self.name = name
        self.purchaser_account = purchaser_account
        self.purchaser_address = purchaser_address
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel
        self.purchaserr_bank_name = purchaserr_bank_name
        self.status = status
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
        if self.drawer_email is not None:
            result['drawerEmail'] = self.drawer_email
        if self.drawer_telephone is not None:
            result['drawerTelephone'] = self.drawer_telephone
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
        if m.get('drawerEmail') is not None:
            self.drawer_email = m.get('drawerEmail')
        if m.get('drawerTelephone') is not None:
            self.drawer_telephone = m.get('drawerTelephone')
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
        self.has_more = has_more
        self.list = list
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
        status_code: int = None,
        body: QueryCustomerInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
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
        # This parameter is required.
        self.account_code = account_code
        self.account_id = account_id
        # This parameter is required.
        self.account_name = account_name
        self.account_remark = account_remark
        # This parameter is required.
        self.account_type = account_type
        self.amount = amount
        self.bank_code = bank_code
        self.bank_name = bank_name
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
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
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
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
        status_code: int = None,
        body: QueryEnterpriseAccountByPageResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        status_code: int = None,
        body: QueryFinanceCompanyInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        status_code: int = None,
        body: QueryInvoiceRelationCountResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryInvoiceRelationCountResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMultiCompanyInfoHeaders(TeaModel):
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


class QueryMultiCompanyInfoResponseBodyListAdvancedSettingList(TeaModel):
    def __init__(
        self,
        advanced_setting_key: str = None,
        advanced_setting_name: str = None,
        end_date: int = None,
        valid: bool = None,
        value: bool = None,
    ):
        self.advanced_setting_key = advanced_setting_key
        self.advanced_setting_name = advanced_setting_name
        self.end_date = end_date
        self.valid = valid
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.advanced_setting_key is not None:
            result['advancedSettingKey'] = self.advanced_setting_key
        if self.advanced_setting_name is not None:
            result['advancedSettingName'] = self.advanced_setting_name
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.valid is not None:
            result['valid'] = self.valid
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('advancedSettingKey') is not None:
            self.advanced_setting_key = m.get('advancedSettingKey')
        if m.get('advancedSettingName') is not None:
            self.advanced_setting_name = m.get('advancedSettingName')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('valid') is not None:
            self.valid = m.get('valid')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QueryMultiCompanyInfoResponseBodyList(TeaModel):
    def __init__(
        self,
        advanced_setting_list: List[QueryMultiCompanyInfoResponseBodyListAdvancedSettingList] = None,
        company_code: str = None,
        company_name: str = None,
        create_time: str = None,
        remark: str = None,
        status: str = None,
        tax_nature: str = None,
        tax_no: str = None,
    ):
        self.advanced_setting_list = advanced_setting_list
        self.company_code = company_code
        self.company_name = company_name
        self.create_time = create_time
        self.remark = remark
        self.status = status
        self.tax_nature = tax_nature
        self.tax_no = tax_no

    def validate(self):
        if self.advanced_setting_list:
            for k in self.advanced_setting_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['advancedSettingList'] = []
        if self.advanced_setting_list is not None:
            for k in self.advanced_setting_list:
                result['advancedSettingList'].append(k.to_map() if k else None)
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.company_name is not None:
            result['companyName'] = self.company_name
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.remark is not None:
            result['remark'] = self.remark
        if self.status is not None:
            result['status'] = self.status
        if self.tax_nature is not None:
            result['taxNature'] = self.tax_nature
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.advanced_setting_list = []
        if m.get('advancedSettingList') is not None:
            for k in m.get('advancedSettingList'):
                temp_model = QueryMultiCompanyInfoResponseBodyListAdvancedSettingList()
                self.advanced_setting_list.append(temp_model.from_map(k))
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('companyName') is not None:
            self.company_name = m.get('companyName')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taxNature') is not None:
            self.tax_nature = m.get('taxNature')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        return self


class QueryMultiCompanyInfoResponseBody(TeaModel):
    def __init__(
        self,
        list: List[QueryMultiCompanyInfoResponseBodyList] = None,
    ):
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
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryMultiCompanyInfoResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryMultiCompanyInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMultiCompanyInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryMultiCompanyInfoResponseBody()
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
        company_code: str = None,
        user_id: str = None,
    ):
        self.company_code = company_code
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
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
        company_code: str = None,
        permission_dtolist: List[QueryPermissionByUserIdResponseBodyPermissionDTOList] = None,
        user_id: str = None,
    ):
        self.company_code = company_code
        self.permission_dtolist = permission_dtolist
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
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        result['permissionDTOList'] = []
        if self.permission_dtolist is not None:
            for k in self.permission_dtolist:
                result['permissionDTOList'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
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
        status_code: int = None,
        body: QueryPermissionByUserIdResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        company_code: str = None,
        role_code_list: List[str] = None,
    ):
        self.company_code = company_code
        # This parameter is required.
        self.role_code_list = role_code_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.role_code_list is not None:
            result['roleCodeList'] = self.role_code_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('roleCodeList') is not None:
            self.role_code_list = m.get('roleCodeList')
        return self


class QueryPermissionRoleMemberResponseBody(TeaModel):
    def __init__(
        self,
        role_member_map: Dict[str, RoleMemberMapValue] = None,
    ):
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
        status_code: int = None,
        body: QueryPermissionRoleMemberResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryPermissionRoleMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryProductByPageHeaders(TeaModel):
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


class QueryProductByPageRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
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


class QueryProductByPageResponseBodyList(TeaModel):
    def __init__(
        self,
        code: str = None,
        create_time: int = None,
        description: str = None,
        information: str = None,
        name: str = None,
        specification: str = None,
        status: str = None,
        unit: str = None,
        user_define_code: str = None,
    ):
        self.code = code
        self.create_time = create_time
        self.description = description
        self.information = information
        self.name = name
        self.specification = specification
        self.status = status
        self.unit = unit
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
        if self.information is not None:
            result['information'] = self.information
        if self.name is not None:
            result['name'] = self.name
        if self.specification is not None:
            result['specification'] = self.specification
        if self.status is not None:
            result['status'] = self.status
        if self.unit is not None:
            result['unit'] = self.unit
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
        if m.get('information') is not None:
            self.information = m.get('information')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('userDefineCode') is not None:
            self.user_define_code = m.get('userDefineCode')
        return self


class QueryProductByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryProductByPageResponseBodyList] = None,
    ):
        self.has_more = has_more
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
                temp_model = QueryProductByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryProductByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryProductByPageResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryProductByPageResponseBody()
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
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
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
        self.caode = caode
        self.code = code
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.creator = creator
        self.description = description
        self.name = name
        # This parameter is required.
        self.project_code = project_code
        # This parameter is required.
        self.project_name = project_name
        # This parameter is required.
        self.status = status
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
        if m.get('caode') is not None:
            self.caode = m.get('caode')
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


class QueryProjectByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryProjectByPageResponseBodyList] = None,
    ):
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
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
        status_code: int = None,
        body: QueryProjectByPageResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryProjectByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryReceiptDetailForInvoiceHeaders(TeaModel):
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


class QueryReceiptDetailForInvoiceRequest(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
    ):
        self.instance_id = instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        return self


class QueryReceiptDetailForInvoiceResponseBodyResultCreator(TeaModel):
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


class QueryReceiptDetailForInvoiceResponseBodyResultCustomer(TeaModel):
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


class QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList(TeaModel):
    def __init__(
        self,
        amount_with_tax: str = None,
        amount_without_tax: str = None,
        discount_amount: str = None,
        name: str = None,
        quantity: str = None,
        specification: str = None,
        tax_classification_code: str = None,
        tax_rate: str = None,
        unit: str = None,
        unit_price_with_tax: str = None,
        unit_price_without_tax: str = None,
        with_tax: bool = None,
    ):
        self.amount_with_tax = amount_with_tax
        self.amount_without_tax = amount_without_tax
        self.discount_amount = discount_amount
        self.name = name
        self.quantity = quantity
        self.specification = specification
        self.tax_classification_code = tax_classification_code
        self.tax_rate = tax_rate
        self.unit = unit
        self.unit_price_with_tax = unit_price_with_tax
        self.unit_price_without_tax = unit_price_without_tax
        self.with_tax = with_tax

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount_with_tax is not None:
            result['amountWithTax'] = self.amount_with_tax
        if self.amount_without_tax is not None:
            result['amountWithoutTax'] = self.amount_without_tax
        if self.discount_amount is not None:
            result['discountAmount'] = self.discount_amount
        if self.name is not None:
            result['name'] = self.name
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.specification is not None:
            result['specification'] = self.specification
        if self.tax_classification_code is not None:
            result['taxClassificationCode'] = self.tax_classification_code
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.unit is not None:
            result['unit'] = self.unit
        if self.unit_price_with_tax is not None:
            result['unitPriceWithTax'] = self.unit_price_with_tax
        if self.unit_price_without_tax is not None:
            result['unitPriceWithoutTax'] = self.unit_price_without_tax
        if self.with_tax is not None:
            result['withTax'] = self.with_tax
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amountWithTax') is not None:
            self.amount_with_tax = m.get('amountWithTax')
        if m.get('amountWithoutTax') is not None:
            self.amount_without_tax = m.get('amountWithoutTax')
        if m.get('discountAmount') is not None:
            self.discount_amount = m.get('discountAmount')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('taxClassificationCode') is not None:
            self.tax_classification_code = m.get('taxClassificationCode')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('unitPriceWithTax') is not None:
            self.unit_price_with_tax = m.get('unitPriceWithTax')
        if m.get('unitPriceWithoutTax') is not None:
            self.unit_price_without_tax = m.get('unitPriceWithoutTax')
        if m.get('withTax') is not None:
            self.with_tax = m.get('withTax')
        return self


class QueryReceiptDetailForInvoiceResponseBodyResult(TeaModel):
    def __init__(
        self,
        accountant_book_id: str = None,
        amount: str = None,
        apply_status: str = None,
        biz_status: str = None,
        business_id: str = None,
        company_code: str = None,
        create_time: str = None,
        creator: QueryReceiptDetailForInvoiceResponseBodyResultCreator = None,
        customer: QueryReceiptDetailForInvoiceResponseBodyResultCustomer = None,
        drawer_email: str = None,
        drawer_telephone: str = None,
        invoice_type: str = None,
        model_id: str = None,
        product_info_list: List[QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList] = None,
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
        self.accountant_book_id = accountant_book_id
        self.amount = amount
        self.apply_status = apply_status
        self.biz_status = biz_status
        self.business_id = business_id
        self.company_code = company_code
        self.create_time = create_time
        self.creator = creator
        self.customer = customer
        self.drawer_email = drawer_email
        self.drawer_telephone = drawer_telephone
        self.invoice_type = invoice_type
        self.model_id = model_id
        self.product_info_list = product_info_list
        self.purchaser_account = purchaser_account
        self.purchaser_address = purchaser_address
        self.purchaser_bank_name = purchaser_bank_name
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel
        self.receipt_id = receipt_id
        self.record_time = record_time
        self.remark = remark
        self.source = source
        self.status = status
        self.title = title

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.customer:
            self.customer.validate()
        if self.product_info_list:
            for k in self.product_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id is not None:
            result['accountantBookId'] = self.accountant_book_id
        if self.amount is not None:
            result['amount'] = self.amount
        if self.apply_status is not None:
            result['applyStatus'] = self.apply_status
        if self.biz_status is not None:
            result['bizStatus'] = self.biz_status
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.customer is not None:
            result['customer'] = self.customer.to_map()
        if self.drawer_email is not None:
            result['drawerEmail'] = self.drawer_email
        if self.drawer_telephone is not None:
            result['drawerTelephone'] = self.drawer_telephone
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.model_id is not None:
            result['modelId'] = self.model_id
        result['productInfoList'] = []
        if self.product_info_list is not None:
            for k in self.product_info_list:
                result['productInfoList'].append(k.to_map() if k else None)
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
        if m.get('accountantBookId') is not None:
            self.accountant_book_id = m.get('accountantBookId')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('applyStatus') is not None:
            self.apply_status = m.get('applyStatus')
        if m.get('bizStatus') is not None:
            self.biz_status = m.get('bizStatus')
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            temp_model = QueryReceiptDetailForInvoiceResponseBodyResultCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('customer') is not None:
            temp_model = QueryReceiptDetailForInvoiceResponseBodyResultCustomer()
            self.customer = temp_model.from_map(m['customer'])
        if m.get('drawerEmail') is not None:
            self.drawer_email = m.get('drawerEmail')
        if m.get('drawerTelephone') is not None:
            self.drawer_telephone = m.get('drawerTelephone')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('modelId') is not None:
            self.model_id = m.get('modelId')
        self.product_info_list = []
        if m.get('productInfoList') is not None:
            for k in m.get('productInfoList'):
                temp_model = QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList()
                self.product_info_list.append(temp_model.from_map(k))
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


class QueryReceiptDetailForInvoiceResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryReceiptDetailForInvoiceResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryReceiptDetailForInvoiceResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryReceiptDetailForInvoiceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryReceiptDetailForInvoiceResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryReceiptDetailForInvoiceResponseBody()
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
        accountant_book_id: str = None,
        apply_status_list: List[str] = None,
        biz_status_list: List[str] = None,
        company_code: str = None,
        end_time: int = None,
        page_number: int = None,
        page_size: int = None,
        receipt_status_list: List[str] = None,
        search_params: Dict[str, str] = None,
        start_time: int = None,
        title: str = None,
    ):
        self.accountant_book_id = accountant_book_id
        self.apply_status_list = apply_status_list
        self.biz_status_list = biz_status_list
        self.company_code = company_code
        self.end_time = end_time
        self.page_number = page_number
        self.page_size = page_size
        self.receipt_status_list = receipt_status_list
        self.search_params = search_params
        self.start_time = start_time
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id is not None:
            result['accountantBookId'] = self.accountant_book_id
        if self.apply_status_list is not None:
            result['applyStatusList'] = self.apply_status_list
        if self.biz_status_list is not None:
            result['bizStatusList'] = self.biz_status_list
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.receipt_status_list is not None:
            result['receiptStatusList'] = self.receipt_status_list
        if self.search_params is not None:
            result['searchParams'] = self.search_params
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountantBookId') is not None:
            self.accountant_book_id = m.get('accountantBookId')
        if m.get('applyStatusList') is not None:
            self.apply_status_list = m.get('applyStatusList')
        if m.get('bizStatusList') is not None:
            self.biz_status_list = m.get('bizStatusList')
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('receiptStatusList') is not None:
            self.receipt_status_list = m.get('receiptStatusList')
        if m.get('searchParams') is not None:
            self.search_params = m.get('searchParams')
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


class QueryReceiptForInvoiceResponseBodyListCustomer(TeaModel):
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


class QueryReceiptForInvoiceResponseBodyListProductInfoList(TeaModel):
    def __init__(
        self,
        amount_with_tax: str = None,
        amount_without_tax: str = None,
        discount_amount: str = None,
        name: str = None,
        quantity: str = None,
        specification: str = None,
        tax_classification_code: str = None,
        tax_rate: str = None,
        unit: str = None,
        unit_price_with_tax: str = None,
        unit_price_without_tax: str = None,
        with_tax: bool = None,
    ):
        self.amount_with_tax = amount_with_tax
        self.amount_without_tax = amount_without_tax
        self.discount_amount = discount_amount
        self.name = name
        self.quantity = quantity
        self.specification = specification
        self.tax_classification_code = tax_classification_code
        self.tax_rate = tax_rate
        self.unit = unit
        self.unit_price_with_tax = unit_price_with_tax
        self.unit_price_without_tax = unit_price_without_tax
        self.with_tax = with_tax

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount_with_tax is not None:
            result['amountWithTax'] = self.amount_with_tax
        if self.amount_without_tax is not None:
            result['amountWithoutTax'] = self.amount_without_tax
        if self.discount_amount is not None:
            result['discountAmount'] = self.discount_amount
        if self.name is not None:
            result['name'] = self.name
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.specification is not None:
            result['specification'] = self.specification
        if self.tax_classification_code is not None:
            result['taxClassificationCode'] = self.tax_classification_code
        if self.tax_rate is not None:
            result['taxRate'] = self.tax_rate
        if self.unit is not None:
            result['unit'] = self.unit
        if self.unit_price_with_tax is not None:
            result['unitPriceWithTax'] = self.unit_price_with_tax
        if self.unit_price_without_tax is not None:
            result['unitPriceWithoutTax'] = self.unit_price_without_tax
        if self.with_tax is not None:
            result['withTax'] = self.with_tax
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amountWithTax') is not None:
            self.amount_with_tax = m.get('amountWithTax')
        if m.get('amountWithoutTax') is not None:
            self.amount_without_tax = m.get('amountWithoutTax')
        if m.get('discountAmount') is not None:
            self.discount_amount = m.get('discountAmount')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('taxClassificationCode') is not None:
            self.tax_classification_code = m.get('taxClassificationCode')
        if m.get('taxRate') is not None:
            self.tax_rate = m.get('taxRate')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('unitPriceWithTax') is not None:
            self.unit_price_with_tax = m.get('unitPriceWithTax')
        if m.get('unitPriceWithoutTax') is not None:
            self.unit_price_without_tax = m.get('unitPriceWithoutTax')
        if m.get('withTax') is not None:
            self.with_tax = m.get('withTax')
        return self


class QueryReceiptForInvoiceResponseBodyList(TeaModel):
    def __init__(
        self,
        accountant_book_id: str = None,
        amount: str = None,
        apply_status: str = None,
        biz_status: str = None,
        business_id: str = None,
        company_code: str = None,
        create_time: str = None,
        creator: QueryReceiptForInvoiceResponseBodyListCreator = None,
        customer: QueryReceiptForInvoiceResponseBodyListCustomer = None,
        drawer_email: str = None,
        drawer_telephone: str = None,
        invoice_type: str = None,
        model_id: str = None,
        product_info_list: List[QueryReceiptForInvoiceResponseBodyListProductInfoList] = None,
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
        self.accountant_book_id = accountant_book_id
        self.amount = amount
        self.apply_status = apply_status
        self.biz_status = biz_status
        self.business_id = business_id
        self.company_code = company_code
        self.create_time = create_time
        self.creator = creator
        self.customer = customer
        self.drawer_email = drawer_email
        self.drawer_telephone = drawer_telephone
        self.invoice_type = invoice_type
        self.model_id = model_id
        self.product_info_list = product_info_list
        self.purchaser_account = purchaser_account
        self.purchaser_address = purchaser_address
        self.purchaser_bank_name = purchaser_bank_name
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel
        self.receipt_id = receipt_id
        self.record_time = record_time
        self.remark = remark
        self.source = source
        self.status = status
        self.title = title

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.customer:
            self.customer.validate()
        if self.product_info_list:
            for k in self.product_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id is not None:
            result['accountantBookId'] = self.accountant_book_id
        if self.amount is not None:
            result['amount'] = self.amount
        if self.apply_status is not None:
            result['applyStatus'] = self.apply_status
        if self.biz_status is not None:
            result['bizStatus'] = self.biz_status
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.customer is not None:
            result['customer'] = self.customer.to_map()
        if self.drawer_email is not None:
            result['drawerEmail'] = self.drawer_email
        if self.drawer_telephone is not None:
            result['drawerTelephone'] = self.drawer_telephone
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.model_id is not None:
            result['modelId'] = self.model_id
        result['productInfoList'] = []
        if self.product_info_list is not None:
            for k in self.product_info_list:
                result['productInfoList'].append(k.to_map() if k else None)
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
        if m.get('accountantBookId') is not None:
            self.accountant_book_id = m.get('accountantBookId')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('applyStatus') is not None:
            self.apply_status = m.get('applyStatus')
        if m.get('bizStatus') is not None:
            self.biz_status = m.get('bizStatus')
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            temp_model = QueryReceiptForInvoiceResponseBodyListCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('customer') is not None:
            temp_model = QueryReceiptForInvoiceResponseBodyListCustomer()
            self.customer = temp_model.from_map(m['customer'])
        if m.get('drawerEmail') is not None:
            self.drawer_email = m.get('drawerEmail')
        if m.get('drawerTelephone') is not None:
            self.drawer_telephone = m.get('drawerTelephone')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('modelId') is not None:
            self.model_id = m.get('modelId')
        self.product_info_list = []
        if m.get('productInfoList') is not None:
            for k in m.get('productInfoList'):
                temp_model = QueryReceiptForInvoiceResponseBodyListProductInfoList()
                self.product_info_list.append(temp_model.from_map(k))
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
        self.has_more = has_more
        self.list = list
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
        status_code: int = None,
        body: QueryReceiptForInvoiceResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        accountant_book_id: str = None,
        amount_end: float = None,
        amount_start: float = None,
        company_code: str = None,
        end_time: int = None,
        page_number: int = None,
        page_size: int = None,
        start_time: int = None,
        time_filter_field: str = None,
        title: str = None,
        voucher_status: str = None,
    ):
        self.accountant_book_id = accountant_book_id
        self.amount_end = amount_end
        self.amount_start = amount_start
        self.company_code = company_code
        self.end_time = end_time
        self.page_number = page_number
        self.page_size = page_size
        self.start_time = start_time
        self.time_filter_field = time_filter_field
        self.title = title
        self.voucher_status = voucher_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id is not None:
            result['accountantBookId'] = self.accountant_book_id
        if self.amount_end is not None:
            result['amountEnd'] = self.amount_end
        if self.amount_start is not None:
            result['amountStart'] = self.amount_start
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.time_filter_field is not None:
            result['timeFilterField'] = self.time_filter_field
        if self.title is not None:
            result['title'] = self.title
        if self.voucher_status is not None:
            result['voucherStatus'] = self.voucher_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountantBookId') is not None:
            self.accountant_book_id = m.get('accountantBookId')
        if m.get('amountEnd') is not None:
            self.amount_end = m.get('amountEnd')
        if m.get('amountStart') is not None:
            self.amount_start = m.get('amountStart')
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('timeFilterField') is not None:
            self.time_filter_field = m.get('timeFilterField')
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


class QueryReceiptsBaseInfoResponseBodyListCustomer(TeaModel):
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
        accountant_book_id: str = None,
        amount: str = None,
        approved_at: str = None,
        business_id: str = None,
        company_code: str = None,
        create_time: str = None,
        creator: QueryReceiptsBaseInfoResponseBodyListCreator = None,
        customer: QueryReceiptsBaseInfoResponseBodyListCustomer = None,
        instance_jump_url: str = None,
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
        self.accountant_book_id = accountant_book_id
        self.amount = amount
        self.approved_at = approved_at
        self.business_id = business_id
        self.company_code = company_code
        self.create_time = create_time
        self.creator = creator
        self.customer = customer
        self.instance_jump_url = instance_jump_url
        self.model_id = model_id
        self.principal = principal
        self.project = project
        self.receipt_id = receipt_id
        self.record_time = record_time
        self.remark = remark
        self.source = source
        self.status = status
        self.supplier = supplier
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
        if self.accountant_book_id is not None:
            result['accountantBookId'] = self.accountant_book_id
        if self.amount is not None:
            result['amount'] = self.amount
        if self.approved_at is not None:
            result['approvedAt'] = self.approved_at
        if self.business_id is not None:
            result['businessId'] = self.business_id
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.customer is not None:
            result['customer'] = self.customer.to_map()
        if self.instance_jump_url is not None:
            result['instanceJumpUrl'] = self.instance_jump_url
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
        if m.get('accountantBookId') is not None:
            self.accountant_book_id = m.get('accountantBookId')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('approvedAt') is not None:
            self.approved_at = m.get('approvedAt')
        if m.get('businessId') is not None:
            self.business_id = m.get('businessId')
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            temp_model = QueryReceiptsBaseInfoResponseBodyListCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('customer') is not None:
            temp_model = QueryReceiptsBaseInfoResponseBodyListCustomer()
            self.customer = temp_model.from_map(m['customer'])
        if m.get('instanceJumpUrl') is not None:
            self.instance_jump_url = m.get('instanceJumpUrl')
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
        self.has_more = has_more
        self.list = list
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
        status_code: int = None,
        body: QueryReceiptsBaseInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        self.end_time = end_time
        # This parameter is required.
        self.model_id = model_id
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.start_time = start_time
        # This parameter is required.
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
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.data = data
        # This parameter is required.
        self.model_id = model_id
        # This parameter is required.
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
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
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
        status_code: int = None,
        body: QueryReceiptsByPageResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryReceiptsByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryRoleMemberByPageHeaders(TeaModel):
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


class QueryRoleMemberByPageRequest(TeaModel):
    def __init__(
        self,
        company_code: str = None,
        max_results: str = None,
        next_token: str = None,
        role_code: str = None,
    ):
        self.company_code = company_code
        self.max_results = max_results
        self.next_token = next_token
        self.role_code = role_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        return self


class QueryRoleMemberByPageResponseBodyList(TeaModel):
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


class QueryRoleMemberByPageResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryRoleMemberByPageResponseBodyList] = None,
        next_token: int = None,
        total_count: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_token = next_token
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
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
                temp_model = QueryRoleMemberByPageResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryRoleMemberByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryRoleMemberByPageResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryRoleMemberByPageResponseBody()
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
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
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
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.description = description
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.status = status
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
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
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
        status_code: int = None,
        body: QuerySupplierByPageResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QuerySupplierByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserRoleListHeaders(TeaModel):
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


class QueryUserRoleListRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
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


class QueryUserRoleListResponseBodyFinanceEmpDeptOpenList(TeaModel):
    def __init__(
        self,
        cascade_dept_id: str = None,
        dept_id: int = None,
        name: str = None,
        super_dept_id: int = None,
    ):
        self.cascade_dept_id = cascade_dept_id
        self.dept_id = dept_id
        self.name = name
        self.super_dept_id = super_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cascade_dept_id is not None:
            result['cascadeDeptId'] = self.cascade_dept_id
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.name is not None:
            result['name'] = self.name
        if self.super_dept_id is not None:
            result['superDeptId'] = self.super_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cascadeDeptId') is not None:
            self.cascade_dept_id = m.get('cascadeDeptId')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('superDeptId') is not None:
            self.super_dept_id = m.get('superDeptId')
        return self


class QueryUserRoleListResponseBodyRoleVOList(TeaModel):
    def __init__(
        self,
        role_code: str = None,
        role_name: str = None,
    ):
        self.role_code = role_code
        self.role_name = role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.role_name is not None:
            result['roleName'] = self.role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        return self


class QueryUserRoleListResponseBody(TeaModel):
    def __init__(
        self,
        finance_emp_dept_open_list: List[QueryUserRoleListResponseBodyFinanceEmpDeptOpenList] = None,
        role_volist: List[QueryUserRoleListResponseBodyRoleVOList] = None,
    ):
        self.finance_emp_dept_open_list = finance_emp_dept_open_list
        self.role_volist = role_volist

    def validate(self):
        if self.finance_emp_dept_open_list:
            for k in self.finance_emp_dept_open_list:
                if k:
                    k.validate()
        if self.role_volist:
            for k in self.role_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['financeEmpDeptOpenList'] = []
        if self.finance_emp_dept_open_list is not None:
            for k in self.finance_emp_dept_open_list:
                result['financeEmpDeptOpenList'].append(k.to_map() if k else None)
        result['roleVOList'] = []
        if self.role_volist is not None:
            for k in self.role_volist:
                result['roleVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.finance_emp_dept_open_list = []
        if m.get('financeEmpDeptOpenList') is not None:
            for k in m.get('financeEmpDeptOpenList'):
                temp_model = QueryUserRoleListResponseBodyFinanceEmpDeptOpenList()
                self.finance_emp_dept_open_list.append(temp_model.from_map(k))
        self.role_volist = []
        if m.get('roleVOList') is not None:
            for k in m.get('roleVOList'):
                temp_model = QueryUserRoleListResponseBodyRoleVOList()
                self.role_volist.append(temp_model.from_map(k))
        return self


class QueryUserRoleListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUserRoleListResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryUserRoleListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UnbindApplyReceiptAndInvoiceRelatedHeaders(TeaModel):
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


class UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList(TeaModel):
    def __init__(
        self,
        invoice_code: str = None,
        invoice_no: str = None,
    ):
        self.invoice_code = invoice_code
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


class UnbindApplyReceiptAndInvoiceRelatedRequest(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
        invoice_key_volist: List[UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList] = None,
        operator: str = None,
    ):
        self.instance_id = instance_id
        self.invoice_key_volist = invoice_key_volist
        self.operator = operator

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
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        result['invoiceKeyVOList'] = []
        if self.invoice_key_volist is not None:
            for k in self.invoice_key_volist:
                result['invoiceKeyVOList'].append(k.to_map() if k else None)
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        self.invoice_key_volist = []
        if m.get('invoiceKeyVOList') is not None:
            for k in m.get('invoiceKeyVOList'):
                temp_model = UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList()
                self.invoice_key_volist.append(temp_model.from_map(k))
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList(TeaModel):
    def __init__(
        self,
        invoice_code: str = None,
        invoice_no: str = None,
    ):
        self.invoice_code = invoice_code
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


class UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse(TeaModel):
    def __init__(
        self,
        invoice_key_volist: List[UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList] = None,
    ):
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
                temp_model = UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList()
                self.invoice_key_volist.append(temp_model.from_map(k))
        return self


class UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList(TeaModel):
    def __init__(
        self,
        invoice_code: str = None,
        invoice_no: str = None,
    ):
        self.invoice_code = invoice_code
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


class UnbindApplyReceiptAndInvoiceRelatedResponseBody(TeaModel):
    def __init__(
        self,
        batch_update_invoice_response: UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse = None,
        error_invoice_key_volist: List[UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList] = None,
        success: bool = None,
    ):
        self.batch_update_invoice_response = batch_update_invoice_response
        self.error_invoice_key_volist = error_invoice_key_volist
        self.success = success

    def validate(self):
        if self.batch_update_invoice_response:
            self.batch_update_invoice_response.validate()
        if self.error_invoice_key_volist:
            for k in self.error_invoice_key_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.batch_update_invoice_response is not None:
            result['batchUpdateInvoiceResponse'] = self.batch_update_invoice_response.to_map()
        result['errorInvoiceKeyVOList'] = []
        if self.error_invoice_key_volist is not None:
            for k in self.error_invoice_key_volist:
                result['errorInvoiceKeyVOList'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('batchUpdateInvoiceResponse') is not None:
            temp_model = UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse()
            self.batch_update_invoice_response = temp_model.from_map(m['batchUpdateInvoiceResponse'])
        self.error_invoice_key_volist = []
        if m.get('errorInvoiceKeyVOList') is not None:
            for k in m.get('errorInvoiceKeyVOList'):
                temp_model = UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList()
                self.error_invoice_key_volist.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UnbindApplyReceiptAndInvoiceRelatedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UnbindApplyReceiptAndInvoiceRelatedResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UnbindApplyReceiptAndInvoiceRelatedResponseBody()
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
        goods_name: str = None,
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
        self.amount = amount
        self.goods_name = goods_name
        self.quantity = quantity
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.specification = specification
        self.tax_amount = tax_amount
        self.tax_pre = tax_pre
        self.tax_pre_type = tax_pre_type
        self.tax_rate = tax_rate
        self.unit = unit
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
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
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
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
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
        self.amount = amount
        self.card_no = card_no
        self.end_date = end_date
        self.goods_name = goods_name
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.start_date = start_date
        self.tax_amount = tax_amount
        self.tax_rate = tax_rate
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
        self.auction_unit = auction_unit
        self.auction_unit_address = auction_unit_address
        self.auction_unit_bank = auction_unit_bank
        self.auction_unit_tax_no = auction_unit_tax_no
        self.auction_util_tel = auction_util_tel
        self.car_model = car_model
        self.card_no = card_no
        self.registration = registration
        self.transfer_vehicle = transfer_vehicle
        self.used_car_address = used_car_address
        self.used_car_market = used_car_market
        self.used_car_market_bank = used_car_market_bank
        self.used_car_market_phone = used_car_market_phone
        self.used_car_market_tax_no = used_car_market_tax_no
        self.vehicle_no = vehicle_no
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
        self.brand = brand
        self.certificate_no = certificate_no
        self.engine_no = engine_no
        self.id_card_no = id_card_no
        self.import_certificate_no = import_certificate_no
        self.inspection_list_no = inspection_list_no
        self.max_passengers = max_passengers
        self.origin_place = origin_place
        self.payment_voucher_no = payment_voucher_no
        self.tax_authority_name = tax_authority_name
        self.tax_authority_no = tax_authority_no
        self.tax_rate = tax_rate
        self.tonnage = tonnage
        self.vehicle_no = vehicle_no
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
        drawer_name: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        finance_type: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList] = None,
        image_url: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_status: str = None,
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
        receiver_email: str = None,
        receiver_name: str = None,
        receiver_tel: str = None,
        remark: str = None,
        second_hand_car_invoice_detail_list: List[UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList] = None,
        seller_address: str = None,
        seller_bank_account: str = None,
        seller_bank_name_account: str = None,
        seller_name: str = None,
        seller_tax_no: str = None,
        seller_tel: str = None,
        supply_sign: str = None,
        tax_amount: str = None,
        used_vehicle_sale_detail_volist: List[UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        self.account_period = account_period
        self.amount = amount
        self.amount_with_tax = amount_with_tax
        self.check_code = check_code
        self.check_time = check_time
        self.drawer_name = drawer_name
        self.drew_date = drew_date
        self.electronic_url = electronic_url
        self.finance_type = finance_type
        self.fund_type = fund_type
        self.general_invoice_detail_volist = general_invoice_detail_volist
        self.image_url = image_url
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no
        self.invoice_status = invoice_status
        self.invoice_type = invoice_type
        self.machine_code = machine_code
        self.oil_flag = oil_flag
        self.payee = payee
        self.process_inst_code = process_inst_code
        self.process_inst_type = process_inst_type
        self.purchaser_address = purchaser_address
        self.purchaser_bank_account = purchaser_bank_account
        self.purchaser_bank_name_account = purchaser_bank_name_account
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel
        self.receiver_email = receiver_email
        self.receiver_name = receiver_name
        self.receiver_tel = receiver_tel
        self.remark = remark
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        self.seller_address = seller_address
        self.seller_bank_account = seller_bank_account
        self.seller_bank_name_account = seller_bank_name_account
        self.seller_name = seller_name
        self.seller_tax_no = seller_tax_no
        self.seller_tel = seller_tel
        self.supply_sign = supply_sign
        self.tax_amount = tax_amount
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        self.verify_status = verify_status
        self.voucher_code = voucher_code
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
        if self.drawer_name is not None:
            result['drawerName'] = self.drawer_name
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
        if self.image_url is not None:
            result['imageUrl'] = self.image_url
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_status is not None:
            result['invoiceStatus'] = self.invoice_status
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
        if self.receiver_email is not None:
            result['receiverEmail'] = self.receiver_email
        if self.receiver_name is not None:
            result['receiverName'] = self.receiver_name
        if self.receiver_tel is not None:
            result['receiverTel'] = self.receiver_tel
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
        if m.get('drawerName') is not None:
            self.drawer_name = m.get('drawerName')
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
        if m.get('imageUrl') is not None:
            self.image_url = m.get('imageUrl')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceStatus') is not None:
            self.invoice_status = m.get('invoiceStatus')
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
        if m.get('receiverEmail') is not None:
            self.receiver_email = m.get('receiverEmail')
        if m.get('receiverName') is not None:
            self.receiver_name = m.get('receiverName')
        if m.get('receiverTel') is not None:
            self.receiver_tel = m.get('receiverTel')
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
        self.general_invoice_volist = general_invoice_volist
        self.instance_id = instance_id
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
        self.invoice_code = invoice_code
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


class UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList(TeaModel):
    def __init__(
        self,
        invoice_code: str = None,
        invoice_no: str = None,
    ):
        self.invoice_code = invoice_code
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


class UpdateApplyReceiptAndInvoiceRelatedResponseBody(TeaModel):
    def __init__(
        self,
        batch_update_invoice_response: UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse = None,
        error_invoice_key_volist: List[UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList] = None,
        success: bool = None,
    ):
        self.batch_update_invoice_response = batch_update_invoice_response
        self.error_invoice_key_volist = error_invoice_key_volist
        self.success = success

    def validate(self):
        if self.batch_update_invoice_response:
            self.batch_update_invoice_response.validate()
        if self.error_invoice_key_volist:
            for k in self.error_invoice_key_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.batch_update_invoice_response is not None:
            result['batchUpdateInvoiceResponse'] = self.batch_update_invoice_response.to_map()
        result['errorInvoiceKeyVOList'] = []
        if self.error_invoice_key_volist is not None:
            for k in self.error_invoice_key_volist:
                result['errorInvoiceKeyVOList'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('batchUpdateInvoiceResponse') is not None:
            temp_model = UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse()
            self.batch_update_invoice_response = temp_model.from_map(m['batchUpdateInvoiceResponse'])
        self.error_invoice_key_volist = []
        if m.get('errorInvoiceKeyVOList') is not None:
            for k in m.get('errorInvoiceKeyVOList'):
                temp_model = UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList()
                self.error_invoice_key_volist.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateApplyReceiptAndInvoiceRelatedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateApplyReceiptAndInvoiceRelatedResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UpdateApplyReceiptAndInvoiceRelatedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateDigitalInvoiceOrgInfoHeaders(TeaModel):
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


class UpdateDigitalInvoiceOrgInfoRequest(TeaModel):
    def __init__(
        self,
        digital_invoice_type: List[str] = None,
        is_digital_org: bool = None,
        location: str = None,
        operator: str = None,
    ):
        self.digital_invoice_type = digital_invoice_type
        self.is_digital_org = is_digital_org
        self.location = location
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.digital_invoice_type is not None:
            result['digitalInvoiceType'] = self.digital_invoice_type
        if self.is_digital_org is not None:
            result['isDigitalOrg'] = self.is_digital_org
        if self.location is not None:
            result['location'] = self.location
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('digitalInvoiceType') is not None:
            self.digital_invoice_type = m.get('digitalInvoiceType')
        if m.get('isDigitalOrg') is not None:
            self.is_digital_org = m.get('isDigitalOrg')
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class UpdateDigitalInvoiceOrgInfoResponseBody(TeaModel):
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


class UpdateDigitalInvoiceOrgInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateDigitalInvoiceOrgInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UpdateDigitalInvoiceOrgInfoResponseBody()
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
        tax_or_invoice_has_init: bool = None,
        user_id: str = None,
    ):
        self.company_name = company_name
        self.tax_nature = tax_nature
        self.tax_no = tax_no
        self.tax_or_invoice_has_init = tax_or_invoice_has_init
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
        if self.tax_or_invoice_has_init is not None:
            result['taxOrInvoiceHasInit'] = self.tax_or_invoice_has_init
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
        if m.get('taxOrInvoiceHasInit') is not None:
            self.tax_or_invoice_has_init = m.get('taxOrInvoiceHasInit')
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
        status_code: int = None,
        body: UpdateFinanceCompanyInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UpdateFinanceCompanyInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateFinanceMultiCompanyInfoHeaders(TeaModel):
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


class UpdateFinanceMultiCompanyInfoRequest(TeaModel):
    def __init__(
        self,
        company_code: str = None,
        company_name: str = None,
        tax_nature: str = None,
        tax_no: str = None,
        tax_or_invoice_has_init: bool = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.company_code = company_code
        # This parameter is required.
        self.company_name = company_name
        self.tax_nature = tax_nature
        self.tax_no = tax_no
        self.tax_or_invoice_has_init = tax_or_invoice_has_init
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.company_name is not None:
            result['companyName'] = self.company_name
        if self.tax_nature is not None:
            result['taxNature'] = self.tax_nature
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        if self.tax_or_invoice_has_init is not None:
            result['taxOrInvoiceHasInit'] = self.tax_or_invoice_has_init
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('companyName') is not None:
            self.company_name = m.get('companyName')
        if m.get('taxNature') is not None:
            self.tax_nature = m.get('taxNature')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        if m.get('taxOrInvoiceHasInit') is not None:
            self.tax_or_invoice_has_init = m.get('taxOrInvoiceHasInit')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateFinanceMultiCompanyInfoResponseBody(TeaModel):
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


class UpdateFinanceMultiCompanyInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateFinanceMultiCompanyInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UpdateFinanceMultiCompanyInfoResponseBody()
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
        goods_name: str = None,
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
        self.amount = amount
        self.goods_name = goods_name
        self.quantity = quantity
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.specification = specification
        self.tax_amount = tax_amount
        self.tax_pre = tax_pre
        self.tax_pre_type = tax_pre_type
        self.tax_rate = tax_rate
        self.unit = unit
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
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
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
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
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
        self.amount = amount
        self.card_no = card_no
        self.end_date = end_date
        self.goods_name = goods_name
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.start_date = start_date
        self.tax_amount = tax_amount
        self.tax_rate = tax_rate
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
        self.auction_unit = auction_unit
        self.auction_unit_address = auction_unit_address
        self.auction_unit_bank = auction_unit_bank
        self.auction_unit_tax_no = auction_unit_tax_no
        self.auction_util_tel = auction_util_tel
        self.car_model = car_model
        self.card_no = card_no
        self.registration = registration
        self.transfer_vehicle = transfer_vehicle
        self.used_car_address = used_car_address
        self.used_car_market = used_car_market
        self.used_car_market_bank = used_car_market_bank
        self.used_car_market_phone = used_car_market_phone
        self.used_car_market_tax_no = used_car_market_tax_no
        self.vehicle_no = vehicle_no
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
        self.brand = brand
        self.certificate_no = certificate_no
        self.engine_no = engine_no
        self.id_card_no = id_card_no
        self.import_certificate_no = import_certificate_no
        self.inspection_list_no = inspection_list_no
        self.max_passengers = max_passengers
        self.origin_place = origin_place
        self.payment_voucher_no = payment_voucher_no
        self.tax_authority_name = tax_authority_name
        self.tax_authority_no = tax_authority_no
        self.tax_rate = tax_rate
        self.tonnage = tonnage
        self.vehicle_no = vehicle_no
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
        drawer_name: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        finance_type: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList] = None,
        image_url: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_status: str = None,
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
        supply_sign: str = None,
        tax_amount: str = None,
        used_vehicle_sale_detail_volist: List[UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        self.account_period = account_period
        self.amount = amount
        self.amount_with_tax = amount_with_tax
        self.check_code = check_code
        self.check_time = check_time
        self.drawer_name = drawer_name
        self.drew_date = drew_date
        self.electronic_url = electronic_url
        self.finance_type = finance_type
        self.fund_type = fund_type
        self.general_invoice_detail_volist = general_invoice_detail_volist
        self.image_url = image_url
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no
        self.invoice_status = invoice_status
        self.invoice_type = invoice_type
        self.machine_code = machine_code
        self.oil_flag = oil_flag
        self.payee = payee
        self.process_inst_code = process_inst_code
        self.process_inst_type = process_inst_type
        self.purchaser_address = purchaser_address
        self.purchaser_bank_account = purchaser_bank_account
        self.purchaser_bank_name_account = purchaser_bank_name_account
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel
        self.remark = remark
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        self.seller_address = seller_address
        self.seller_bank_account = seller_bank_account
        self.seller_bank_name_account = seller_bank_name_account
        self.seller_name = seller_name
        self.seller_tax_no = seller_tax_no
        self.seller_tel = seller_tel
        self.supply_sign = supply_sign
        self.tax_amount = tax_amount
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        self.verify_status = verify_status
        self.voucher_code = voucher_code
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
        if self.drawer_name is not None:
            result['drawerName'] = self.drawer_name
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
        if self.image_url is not None:
            result['imageUrl'] = self.image_url
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_status is not None:
            result['invoiceStatus'] = self.invoice_status
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
        if m.get('drawerName') is not None:
            self.drawer_name = m.get('drawerName')
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
        if m.get('imageUrl') is not None:
            self.image_url = m.get('imageUrl')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceStatus') is not None:
            self.invoice_status = m.get('invoiceStatus')
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
        goods_name: str = None,
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
        self.amount = amount
        self.goods_name = goods_name
        self.quantity = quantity
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.specification = specification
        self.tax_amount = tax_amount
        self.tax_pre = tax_pre
        self.tax_pre_type = tax_pre_type
        self.tax_rate = tax_rate
        self.unit = unit
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
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
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
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
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
        self.amount = amount
        self.card_no = card_no
        self.end_date = end_date
        self.goods_name = goods_name
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.start_date = start_date
        self.tax_amount = tax_amount
        self.tax_rate = tax_rate
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
        self.auction_unit = auction_unit
        self.auction_unit_address = auction_unit_address
        self.auction_unit_bank = auction_unit_bank
        self.auction_unit_tax_no = auction_unit_tax_no
        self.auction_util_tel = auction_util_tel
        self.car_model = car_model
        self.card_no = card_no
        self.registration = registration
        self.transfer_vehicle = transfer_vehicle
        self.used_car_address = used_car_address
        self.used_car_market = used_car_market
        self.used_car_market_bank = used_car_market_bank
        self.used_car_market_phone = used_car_market_phone
        self.used_car_market_tax_no = used_car_market_tax_no
        self.vehicle_no = vehicle_no
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
        self.brand = brand
        self.certificate_no = certificate_no
        self.engine_no = engine_no
        self.id_card_no = id_card_no
        self.import_certificate_no = import_certificate_no
        self.inspection_list_no = inspection_list_no
        self.max_passengers = max_passengers
        self.origin_place = origin_place
        self.payment_voucher_no = payment_voucher_no
        self.tax_authority_name = tax_authority_name
        self.tax_authority_no = tax_authority_no
        self.tax_rate = tax_rate
        self.tonnage = tonnage
        self.vehicle_no = vehicle_no
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
        drawer_name: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        finance_type: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList] = None,
        image_url: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_status: str = None,
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
        supply_sign: str = None,
        tax_amount: str = None,
        used_vehicle_sale_detail_volist: List[UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        self.account_period = account_period
        self.amount = amount
        self.amount_with_tax = amount_with_tax
        self.check_code = check_code
        self.check_time = check_time
        self.drawer_name = drawer_name
        self.drew_date = drew_date
        self.electronic_url = electronic_url
        self.finance_type = finance_type
        self.fund_type = fund_type
        self.general_invoice_detail_volist = general_invoice_detail_volist
        self.image_url = image_url
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no
        self.invoice_status = invoice_status
        self.invoice_type = invoice_type
        self.machine_code = machine_code
        self.oil_flag = oil_flag
        self.payee = payee
        self.process_inst_code = process_inst_code
        self.process_inst_type = process_inst_type
        self.purchaser_address = purchaser_address
        self.purchaser_bank_account = purchaser_bank_account
        self.purchaser_bank_name_account = purchaser_bank_name_account
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel
        self.remark = remark
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        self.seller_address = seller_address
        self.seller_bank_account = seller_bank_account
        self.seller_bank_name_account = seller_bank_name_account
        self.seller_name = seller_name
        self.seller_tax_no = seller_tax_no
        self.seller_tel = seller_tel
        self.supply_sign = supply_sign
        self.tax_amount = tax_amount
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        self.verify_status = verify_status
        self.voucher_code = voucher_code
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
        if self.drawer_name is not None:
            result['drawerName'] = self.drawer_name
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
        if self.image_url is not None:
            result['imageUrl'] = self.image_url
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_status is not None:
            result['invoiceStatus'] = self.invoice_status
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
        if m.get('drawerName') is not None:
            self.drawer_name = m.get('drawerName')
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
        if m.get('imageUrl') is not None:
            self.image_url = m.get('imageUrl')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceStatus') is not None:
            self.invoice_status = m.get('invoiceStatus')
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
        company_code: str = None,
        operator: str = None,
        red_general_invoice_vo: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO = None,
        red_invoice_code: str = None,
        red_invoice_no: str = None,
        red_invoice_status: str = None,
        target_invoice: str = None,
    ):
        self.blue_general_invoice_vo = blue_general_invoice_vo
        self.blue_invoice_code = blue_invoice_code
        self.blue_invoice_no = blue_invoice_no
        self.blue_invoice_status = blue_invoice_status
        self.company_code = company_code
        self.operator = operator
        self.red_general_invoice_vo = red_general_invoice_vo
        self.red_invoice_code = red_invoice_code
        self.red_invoice_no = red_invoice_no
        self.red_invoice_status = red_invoice_status
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
        if self.company_code is not None:
            result['companyCode'] = self.company_code
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
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
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
        status_code: int = None,
        body: UpdateInvoiceAbandonStatusResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        goods_name: str = None,
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
        self.amount = amount
        self.goods_name = goods_name
        self.quantity = quantity
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.specification = specification
        self.tax_amount = tax_amount
        self.tax_pre = tax_pre
        self.tax_pre_type = tax_pre_type
        self.tax_rate = tax_rate
        self.unit = unit
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
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
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
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
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
        self.amount = amount
        self.card_no = card_no
        self.end_date = end_date
        self.goods_name = goods_name
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.start_date = start_date
        self.tax_amount = tax_amount
        self.tax_rate = tax_rate
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
        self.auction_unit = auction_unit
        self.auction_unit_address = auction_unit_address
        self.auction_unit_bank = auction_unit_bank
        self.auction_unit_tax_no = auction_unit_tax_no
        self.auction_util_tel = auction_util_tel
        self.car_model = car_model
        self.card_no = card_no
        self.registration = registration
        self.transfer_vehicle = transfer_vehicle
        self.used_car_address = used_car_address
        self.used_car_market = used_car_market
        self.used_car_market_bank = used_car_market_bank
        self.used_car_market_phone = used_car_market_phone
        self.used_car_market_tax_no = used_car_market_tax_no
        self.vehicle_no = vehicle_no
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
        self.brand = brand
        self.certificate_no = certificate_no
        self.engine_no = engine_no
        self.id_card_no = id_card_no
        self.import_certificate_no = import_certificate_no
        self.inspection_list_no = inspection_list_no
        self.max_passengers = max_passengers
        self.origin_place = origin_place
        self.payment_voucher_no = payment_voucher_no
        self.tax_authority_name = tax_authority_name
        self.tax_authority_no = tax_authority_no
        self.tax_rate = tax_rate
        self.tonnage = tonnage
        self.vehicle_no = vehicle_no
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
        drawer_name: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        finance_type: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList] = None,
        image_url: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_status: str = None,
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
        supply_sign: str = None,
        tax_amount: str = None,
        used_vehicle_sale_detail_volist: List[UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        self.account_period = account_period
        self.amount = amount
        self.amount_with_tax = amount_with_tax
        self.check_code = check_code
        self.check_time = check_time
        self.drawer_name = drawer_name
        self.drew_date = drew_date
        self.electronic_url = electronic_url
        self.finance_type = finance_type
        self.fund_type = fund_type
        self.general_invoice_detail_volist = general_invoice_detail_volist
        self.image_url = image_url
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no
        self.invoice_status = invoice_status
        self.invoice_type = invoice_type
        self.machine_code = machine_code
        self.oil_flag = oil_flag
        self.payee = payee
        self.process_inst_code = process_inst_code
        self.process_inst_type = process_inst_type
        self.purchaser_address = purchaser_address
        self.purchaser_bank_account = purchaser_bank_account
        self.purchaser_bank_name_account = purchaser_bank_name_account
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel
        self.remark = remark
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        self.seller_address = seller_address
        self.seller_bank_account = seller_bank_account
        self.seller_bank_name_account = seller_bank_name_account
        self.seller_name = seller_name
        self.seller_tax_no = seller_tax_no
        self.seller_tel = seller_tel
        self.supply_sign = supply_sign
        self.tax_amount = tax_amount
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        self.verify_status = verify_status
        self.voucher_code = voucher_code
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
        if self.drawer_name is not None:
            result['drawerName'] = self.drawer_name
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
        if self.image_url is not None:
            result['imageUrl'] = self.image_url
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_status is not None:
            result['invoiceStatus'] = self.invoice_status
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
        if m.get('drawerName') is not None:
            self.drawer_name = m.get('drawerName')
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
        if m.get('imageUrl') is not None:
            self.image_url = m.get('imageUrl')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceStatus') is not None:
            self.invoice_status = m.get('invoiceStatus')
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
        self.invoice_code = invoice_code
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
        company_code: str = None,
        general_invoice_volist: List[UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList] = None,
        invoice_key_volist: List[UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList] = None,
        operator: str = None,
    ):
        self.account_period = account_period
        self.company_code = company_code
        self.general_invoice_volist = general_invoice_volist
        self.invoice_key_volist = invoice_key_volist
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
        if self.company_code is not None:
            result['companyCode'] = self.company_code
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
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
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


class UpdateInvoiceAccountPeriodResponseBodyErrorResult(TeaModel):
    def __init__(
        self,
        error_key: str = None,
        error_msg: str = None,
    ):
        self.error_key = error_key
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


class UpdateInvoiceAccountPeriodResponseBodySuccessResult(TeaModel):
    def __init__(
        self,
        invoice_code: str = None,
        invoice_no: str = None,
    ):
        self.invoice_code = invoice_code
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


class UpdateInvoiceAccountPeriodResponseBody(TeaModel):
    def __init__(
        self,
        error_result: List[UpdateInvoiceAccountPeriodResponseBodyErrorResult] = None,
        success_result: List[UpdateInvoiceAccountPeriodResponseBodySuccessResult] = None,
    ):
        self.error_result = error_result
        self.success_result = success_result

    def validate(self):
        if self.error_result:
            for k in self.error_result:
                if k:
                    k.validate()
        if self.success_result:
            for k in self.success_result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['errorResult'] = []
        if self.error_result is not None:
            for k in self.error_result:
                result['errorResult'].append(k.to_map() if k else None)
        result['successResult'] = []
        if self.success_result is not None:
            for k in self.success_result:
                result['successResult'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.error_result = []
        if m.get('errorResult') is not None:
            for k in m.get('errorResult'):
                temp_model = UpdateInvoiceAccountPeriodResponseBodyErrorResult()
                self.error_result.append(temp_model.from_map(k))
        self.success_result = []
        if m.get('successResult') is not None:
            for k in m.get('successResult'):
                temp_model = UpdateInvoiceAccountPeriodResponseBodySuccessResult()
                self.success_result.append(temp_model.from_map(k))
        return self


class UpdateInvoiceAccountPeriodResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateInvoiceAccountPeriodResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UpdateInvoiceAccountPeriodResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInvoiceAccountingPeriodDateHeaders(TeaModel):
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


class UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList(TeaModel):
    def __init__(
        self,
        accounting_period_data: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_type: str = None,
    ):
        self.accounting_period_data = accounting_period_data
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no
        self.invoice_type = invoice_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accounting_period_data is not None:
            result['accountingPeriodData'] = self.accounting_period_data
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountingPeriodData') is not None:
            self.accounting_period_data = m.get('accountingPeriodData')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        return self


class UpdateInvoiceAccountingPeriodDateRequest(TeaModel):
    def __init__(
        self,
        company_code: str = None,
        invoice_finance_info_volist: List[UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList] = None,
        operator: str = None,
    ):
        self.company_code = company_code
        self.invoice_finance_info_volist = invoice_finance_info_volist
        self.operator = operator

    def validate(self):
        if self.invoice_finance_info_volist:
            for k in self.invoice_finance_info_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        result['invoiceFinanceInfoVOList'] = []
        if self.invoice_finance_info_volist is not None:
            for k in self.invoice_finance_info_volist:
                result['invoiceFinanceInfoVOList'].append(k.to_map() if k else None)
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        self.invoice_finance_info_volist = []
        if m.get('invoiceFinanceInfoVOList') is not None:
            for k in m.get('invoiceFinanceInfoVOList'):
                temp_model = UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList()
                self.invoice_finance_info_volist.append(temp_model.from_map(k))
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        return self


class UpdateInvoiceAccountingPeriodDateResponseBodyResult(TeaModel):
    def __init__(
        self,
        fail_count: int = None,
        fail_invoices: List[UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices] = None,
        success: bool = None,
    ):
        self.fail_count = fail_count
        self.fail_invoices = fail_invoices
        self.success = success

    def validate(self):
        if self.fail_invoices:
            for k in self.fail_invoices:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fail_count is not None:
            result['failCount'] = self.fail_count
        result['failInvoices'] = []
        if self.fail_invoices is not None:
            for k in self.fail_invoices:
                result['failInvoices'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failCount') is not None:
            self.fail_count = m.get('failCount')
        self.fail_invoices = []
        if m.get('failInvoices') is not None:
            for k in m.get('failInvoices'):
                temp_model = UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices()
                self.fail_invoices.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateInvoiceAccountingPeriodDateResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateInvoiceAccountingPeriodDateResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = UpdateInvoiceAccountingPeriodDateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateInvoiceAccountingPeriodDateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateInvoiceAccountingPeriodDateResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UpdateInvoiceAccountingPeriodDateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInvoiceAccountingStatusHeaders(TeaModel):
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


class UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList(TeaModel):
    def __init__(
        self,
        accounting_status: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_type: str = None,
    ):
        self.accounting_status = accounting_status
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no
        self.invoice_type = invoice_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accounting_status is not None:
            result['accountingStatus'] = self.accounting_status
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountingStatus') is not None:
            self.accounting_status = m.get('accountingStatus')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        return self


class UpdateInvoiceAccountingStatusRequest(TeaModel):
    def __init__(
        self,
        company_code: str = None,
        invoice_finance_info_volist: List[UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList] = None,
        operator: str = None,
    ):
        self.company_code = company_code
        self.invoice_finance_info_volist = invoice_finance_info_volist
        self.operator = operator

    def validate(self):
        if self.invoice_finance_info_volist:
            for k in self.invoice_finance_info_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        result['invoiceFinanceInfoVOList'] = []
        if self.invoice_finance_info_volist is not None:
            for k in self.invoice_finance_info_volist:
                result['invoiceFinanceInfoVOList'].append(k.to_map() if k else None)
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        self.invoice_finance_info_volist = []
        if m.get('invoiceFinanceInfoVOList') is not None:
            for k in m.get('invoiceFinanceInfoVOList'):
                temp_model = UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList()
                self.invoice_finance_info_volist.append(temp_model.from_map(k))
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        return self


class UpdateInvoiceAccountingStatusResponseBodyResult(TeaModel):
    def __init__(
        self,
        fail_count: int = None,
        fail_invoices: List[UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices] = None,
        success: bool = None,
    ):
        self.fail_count = fail_count
        self.fail_invoices = fail_invoices
        self.success = success

    def validate(self):
        if self.fail_invoices:
            for k in self.fail_invoices:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fail_count is not None:
            result['failCount'] = self.fail_count
        result['failInvoices'] = []
        if self.fail_invoices is not None:
            for k in self.fail_invoices:
                result['failInvoices'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failCount') is not None:
            self.fail_count = m.get('failCount')
        self.fail_invoices = []
        if m.get('failInvoices') is not None:
            for k in m.get('failInvoices'):
                temp_model = UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices()
                self.fail_invoices.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateInvoiceAccountingStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateInvoiceAccountingStatusResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = UpdateInvoiceAccountingStatusResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateInvoiceAccountingStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateInvoiceAccountingStatusResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UpdateInvoiceAccountingStatusResponseBody()
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


class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails(TeaModel):
    def __init__(
        self,
        carrier: str = None,
        flight_number: str = None,
        fly_date: str = None,
        fly_from: str = None,
        fly_time: str = None,
        fly_to: str = None,
        seat: str = None,
    ):
        self.carrier = carrier
        self.flight_number = flight_number
        self.fly_date = fly_date
        self.fly_from = fly_from
        self.fly_time = fly_time
        self.fly_to = fly_to
        self.seat = seat

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.carrier is not None:
            result['carrier'] = self.carrier
        if self.flight_number is not None:
            result['flightNumber'] = self.flight_number
        if self.fly_date is not None:
            result['flyDate'] = self.fly_date
        if self.fly_from is not None:
            result['flyFrom'] = self.fly_from
        if self.fly_time is not None:
            result['flyTime'] = self.fly_time
        if self.fly_to is not None:
            result['flyTo'] = self.fly_to
        if self.seat is not None:
            result['seat'] = self.seat
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('carrier') is not None:
            self.carrier = m.get('carrier')
        if m.get('flightNumber') is not None:
            self.flight_number = m.get('flightNumber')
        if m.get('flyDate') is not None:
            self.fly_date = m.get('flyDate')
        if m.get('flyFrom') is not None:
            self.fly_from = m.get('flyFrom')
        if m.get('flyTime') is not None:
            self.fly_time = m.get('flyTime')
        if m.get('flyTo') is not None:
            self.fly_to = m.get('flyTo')
        if m.get('seat') is not None:
            self.seat = m.get('seat')
        return self


class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        goods_name: str = None,
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
        self.amount = amount
        self.goods_name = goods_name
        self.quantity = quantity
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.specification = specification
        self.tax_amount = tax_amount
        self.tax_pre = tax_pre
        self.tax_pre_type = tax_pre_type
        self.tax_rate = tax_rate
        self.unit = unit
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
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
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
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
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
        self.amount = amount
        self.card_no = card_no
        self.end_date = end_date
        self.goods_name = goods_name
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.start_date = start_date
        self.tax_amount = tax_amount
        self.tax_rate = tax_rate
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
        self.auction_unit = auction_unit
        self.auction_unit_address = auction_unit_address
        self.auction_unit_bank = auction_unit_bank
        self.auction_unit_tax_no = auction_unit_tax_no
        self.auction_util_tel = auction_util_tel
        self.car_model = car_model
        self.card_no = card_no
        self.registration = registration
        self.transfer_vehicle = transfer_vehicle
        self.used_car_address = used_car_address
        self.used_car_market = used_car_market
        self.used_car_market_bank = used_car_market_bank
        self.used_car_market_phone = used_car_market_phone
        self.used_car_market_tax_no = used_car_market_tax_no
        self.vehicle_no = vehicle_no
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
        self.brand = brand
        self.certificate_no = certificate_no
        self.engine_no = engine_no
        self.id_card_no = id_card_no
        self.import_certificate_no = import_certificate_no
        self.inspection_list_no = inspection_list_no
        self.max_passengers = max_passengers
        self.origin_place = origin_place
        self.payment_voucher_no = payment_voucher_no
        self.tax_authority_name = tax_authority_name
        self.tax_authority_no = tax_authority_no
        self.tax_rate = tax_rate
        self.tonnage = tonnage
        self.vehicle_no = vehicle_no
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
        agent_code: str = None,
        amount: str = None,
        amount_with_tax: str = None,
        caac_development_fund: str = None,
        check_code: str = None,
        check_time: str = None,
        city: str = None,
        destination: str = None,
        distance: str = None,
        drawer_name: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        entrance: str = None,
        exit: str = None,
        finance_type: str = None,
        flight_itinerary_details: List[UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails] = None,
        fuel_surcharge: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList] = None,
        get_off_time: str = None,
        get_on_time: str = None,
        image_url: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_status: str = None,
        invoice_type: str = None,
        issue_by: str = None,
        machine_code: str = None,
        oil_flag: str = None,
        origin: str = None,
        passenger: str = None,
        passenger_user_id: str = None,
        payee: str = None,
        print_serial_number: str = None,
        process_inst_code: str = None,
        process_inst_type: str = None,
        purchaser_address: str = None,
        purchaser_bank_account: str = None,
        purchaser_bank_name_account: str = None,
        purchaser_name: str = None,
        purchaser_tax_no: str = None,
        purchaser_tel: str = None,
        receiver_email: str = None,
        receiver_name: str = None,
        receiver_tel: str = None,
        remark: str = None,
        seat_class: str = None,
        second_hand_car_invoice_detail_list: List[UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList] = None,
        seller_address: str = None,
        seller_bank_account: str = None,
        seller_bank_name_account: str = None,
        seller_name: str = None,
        seller_tax_no: str = None,
        seller_tel: str = None,
        serial_no: str = None,
        start_time: str = None,
        supply_sign: str = None,
        surcharge: str = None,
        tax_amount: str = None,
        train_no: str = None,
        travel_date: str = None,
        used_vehicle_sale_detail_volist: List[UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        self.account_period = account_period
        self.agent_code = agent_code
        self.amount = amount
        self.amount_with_tax = amount_with_tax
        self.caac_development_fund = caac_development_fund
        self.check_code = check_code
        self.check_time = check_time
        self.city = city
        self.destination = destination
        self.distance = distance
        self.drawer_name = drawer_name
        self.drew_date = drew_date
        self.electronic_url = electronic_url
        self.entrance = entrance
        self.exit = exit
        self.finance_type = finance_type
        self.flight_itinerary_details = flight_itinerary_details
        self.fuel_surcharge = fuel_surcharge
        self.fund_type = fund_type
        self.general_invoice_detail_volist = general_invoice_detail_volist
        self.get_off_time = get_off_time
        self.get_on_time = get_on_time
        self.image_url = image_url
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no
        self.invoice_status = invoice_status
        self.invoice_type = invoice_type
        self.issue_by = issue_by
        self.machine_code = machine_code
        self.oil_flag = oil_flag
        self.origin = origin
        self.passenger = passenger
        self.passenger_user_id = passenger_user_id
        self.payee = payee
        self.print_serial_number = print_serial_number
        self.process_inst_code = process_inst_code
        self.process_inst_type = process_inst_type
        self.purchaser_address = purchaser_address
        self.purchaser_bank_account = purchaser_bank_account
        self.purchaser_bank_name_account = purchaser_bank_name_account
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel
        self.receiver_email = receiver_email
        self.receiver_name = receiver_name
        self.receiver_tel = receiver_tel
        self.remark = remark
        self.seat_class = seat_class
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        self.seller_address = seller_address
        self.seller_bank_account = seller_bank_account
        self.seller_bank_name_account = seller_bank_name_account
        self.seller_name = seller_name
        self.seller_tax_no = seller_tax_no
        self.seller_tel = seller_tel
        self.serial_no = serial_no
        self.start_time = start_time
        self.supply_sign = supply_sign
        self.surcharge = surcharge
        self.tax_amount = tax_amount
        self.train_no = train_no
        self.travel_date = travel_date
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        self.verify_status = verify_status
        self.voucher_code = voucher_code
        self.voucher_status = voucher_status

    def validate(self):
        if self.flight_itinerary_details:
            for k in self.flight_itinerary_details:
                if k:
                    k.validate()
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
        if self.agent_code is not None:
            result['agentCode'] = self.agent_code
        if self.amount is not None:
            result['amount'] = self.amount
        if self.amount_with_tax is not None:
            result['amountWithTax'] = self.amount_with_tax
        if self.caac_development_fund is not None:
            result['caacDevelopmentFund'] = self.caac_development_fund
        if self.check_code is not None:
            result['checkCode'] = self.check_code
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.city is not None:
            result['city'] = self.city
        if self.destination is not None:
            result['destination'] = self.destination
        if self.distance is not None:
            result['distance'] = self.distance
        if self.drawer_name is not None:
            result['drawerName'] = self.drawer_name
        if self.drew_date is not None:
            result['drewDate'] = self.drew_date
        if self.electronic_url is not None:
            result['electronicUrl'] = self.electronic_url
        if self.entrance is not None:
            result['entrance'] = self.entrance
        if self.exit is not None:
            result['exit'] = self.exit
        if self.finance_type is not None:
            result['financeType'] = self.finance_type
        result['flightItineraryDetails'] = []
        if self.flight_itinerary_details is not None:
            for k in self.flight_itinerary_details:
                result['flightItineraryDetails'].append(k.to_map() if k else None)
        if self.fuel_surcharge is not None:
            result['fuelSurcharge'] = self.fuel_surcharge
        if self.fund_type is not None:
            result['fundType'] = self.fund_type
        result['generalInvoiceDetailVOList'] = []
        if self.general_invoice_detail_volist is not None:
            for k in self.general_invoice_detail_volist:
                result['generalInvoiceDetailVOList'].append(k.to_map() if k else None)
        if self.get_off_time is not None:
            result['getOffTime'] = self.get_off_time
        if self.get_on_time is not None:
            result['getOnTime'] = self.get_on_time
        if self.image_url is not None:
            result['imageUrl'] = self.image_url
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_status is not None:
            result['invoiceStatus'] = self.invoice_status
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.issue_by is not None:
            result['issueBy'] = self.issue_by
        if self.machine_code is not None:
            result['machineCode'] = self.machine_code
        if self.oil_flag is not None:
            result['oilFlag'] = self.oil_flag
        if self.origin is not None:
            result['origin'] = self.origin
        if self.passenger is not None:
            result['passenger'] = self.passenger
        if self.passenger_user_id is not None:
            result['passengerUserId'] = self.passenger_user_id
        if self.payee is not None:
            result['payee'] = self.payee
        if self.print_serial_number is not None:
            result['printSerialNumber'] = self.print_serial_number
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
        if self.receiver_email is not None:
            result['receiverEmail'] = self.receiver_email
        if self.receiver_name is not None:
            result['receiverName'] = self.receiver_name
        if self.receiver_tel is not None:
            result['receiverTel'] = self.receiver_tel
        if self.remark is not None:
            result['remark'] = self.remark
        if self.seat_class is not None:
            result['seatClass'] = self.seat_class
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
        if self.serial_no is not None:
            result['serialNo'] = self.serial_no
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.supply_sign is not None:
            result['supplySign'] = self.supply_sign
        if self.surcharge is not None:
            result['surcharge'] = self.surcharge
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.train_no is not None:
            result['trainNo'] = self.train_no
        if self.travel_date is not None:
            result['travelDate'] = self.travel_date
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
        if m.get('agentCode') is not None:
            self.agent_code = m.get('agentCode')
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('amountWithTax') is not None:
            self.amount_with_tax = m.get('amountWithTax')
        if m.get('caacDevelopmentFund') is not None:
            self.caac_development_fund = m.get('caacDevelopmentFund')
        if m.get('checkCode') is not None:
            self.check_code = m.get('checkCode')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('city') is not None:
            self.city = m.get('city')
        if m.get('destination') is not None:
            self.destination = m.get('destination')
        if m.get('distance') is not None:
            self.distance = m.get('distance')
        if m.get('drawerName') is not None:
            self.drawer_name = m.get('drawerName')
        if m.get('drewDate') is not None:
            self.drew_date = m.get('drewDate')
        if m.get('electronicUrl') is not None:
            self.electronic_url = m.get('electronicUrl')
        if m.get('entrance') is not None:
            self.entrance = m.get('entrance')
        if m.get('exit') is not None:
            self.exit = m.get('exit')
        if m.get('financeType') is not None:
            self.finance_type = m.get('financeType')
        self.flight_itinerary_details = []
        if m.get('flightItineraryDetails') is not None:
            for k in m.get('flightItineraryDetails'):
                temp_model = UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails()
                self.flight_itinerary_details.append(temp_model.from_map(k))
        if m.get('fuelSurcharge') is not None:
            self.fuel_surcharge = m.get('fuelSurcharge')
        if m.get('fundType') is not None:
            self.fund_type = m.get('fundType')
        self.general_invoice_detail_volist = []
        if m.get('generalInvoiceDetailVOList') is not None:
            for k in m.get('generalInvoiceDetailVOList'):
                temp_model = UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList()
                self.general_invoice_detail_volist.append(temp_model.from_map(k))
        if m.get('getOffTime') is not None:
            self.get_off_time = m.get('getOffTime')
        if m.get('getOnTime') is not None:
            self.get_on_time = m.get('getOnTime')
        if m.get('imageUrl') is not None:
            self.image_url = m.get('imageUrl')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceStatus') is not None:
            self.invoice_status = m.get('invoiceStatus')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('issueBy') is not None:
            self.issue_by = m.get('issueBy')
        if m.get('machineCode') is not None:
            self.machine_code = m.get('machineCode')
        if m.get('oilFlag') is not None:
            self.oil_flag = m.get('oilFlag')
        if m.get('origin') is not None:
            self.origin = m.get('origin')
        if m.get('passenger') is not None:
            self.passenger = m.get('passenger')
        if m.get('passengerUserId') is not None:
            self.passenger_user_id = m.get('passengerUserId')
        if m.get('payee') is not None:
            self.payee = m.get('payee')
        if m.get('printSerialNumber') is not None:
            self.print_serial_number = m.get('printSerialNumber')
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
        if m.get('receiverEmail') is not None:
            self.receiver_email = m.get('receiverEmail')
        if m.get('receiverName') is not None:
            self.receiver_name = m.get('receiverName')
        if m.get('receiverTel') is not None:
            self.receiver_tel = m.get('receiverTel')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('seatClass') is not None:
            self.seat_class = m.get('seatClass')
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
        if m.get('serialNo') is not None:
            self.serial_no = m.get('serialNo')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('supplySign') is not None:
            self.supply_sign = m.get('supplySign')
        if m.get('surcharge') is not None:
            self.surcharge = m.get('surcharge')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('trainNo') is not None:
            self.train_no = m.get('trainNo')
        if m.get('travelDate') is not None:
            self.travel_date = m.get('travelDate')
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
        self.general_invoice_vo = general_invoice_vo
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no
        self.operator = operator
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
        status_code: int = None,
        body: UpdateInvoiceAndReceiptRelatedResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        self.instance_id = instance_id
        self.operator = operator
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
        status_code: int = None,
        body: UpdateInvoiceIgnoreStatusResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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


class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        goods_name: str = None,
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
        self.amount = amount
        self.goods_name = goods_name
        self.quantity = quantity
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.specification = specification
        self.tax_amount = tax_amount
        self.tax_pre = tax_pre
        self.tax_pre_type = tax_pre_type
        self.tax_rate = tax_rate
        self.unit = unit
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
        if self.goods_name is not None:
            result['goodsName'] = self.goods_name
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
        if m.get('goodsName') is not None:
            self.goods_name = m.get('goodsName')
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


class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList(TeaModel):
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
        self.amount = amount
        self.card_no = card_no
        self.end_date = end_date
        self.goods_name = goods_name
        self.revenue_code = revenue_code
        self.row_no = row_no
        self.start_date = start_date
        self.tax_amount = tax_amount
        self.tax_rate = tax_rate
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


class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList(TeaModel):
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
        self.auction_unit = auction_unit
        self.auction_unit_address = auction_unit_address
        self.auction_unit_bank = auction_unit_bank
        self.auction_unit_tax_no = auction_unit_tax_no
        self.auction_util_tel = auction_util_tel
        self.car_model = car_model
        self.card_no = card_no
        self.registration = registration
        self.transfer_vehicle = transfer_vehicle
        self.used_car_address = used_car_address
        self.used_car_market = used_car_market
        self.used_car_market_bank = used_car_market_bank
        self.used_car_market_phone = used_car_market_phone
        self.used_car_market_tax_no = used_car_market_tax_no
        self.vehicle_no = vehicle_no
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


class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList(TeaModel):
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
        self.brand = brand
        self.certificate_no = certificate_no
        self.engine_no = engine_no
        self.id_card_no = id_card_no
        self.import_certificate_no = import_certificate_no
        self.inspection_list_no = inspection_list_no
        self.max_passengers = max_passengers
        self.origin_place = origin_place
        self.payment_voucher_no = payment_voucher_no
        self.tax_authority_name = tax_authority_name
        self.tax_authority_no = tax_authority_no
        self.tax_rate = tax_rate
        self.tonnage = tonnage
        self.vehicle_no = vehicle_no
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


class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList(TeaModel):
    def __init__(
        self,
        account_period: str = None,
        amount: str = None,
        amount_with_tax: str = None,
        check_code: str = None,
        check_time: str = None,
        drawer_name: str = None,
        drew_date: str = None,
        electronic_url: str = None,
        finance_type: str = None,
        fund_type: str = None,
        general_invoice_detail_volist: List[UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList] = None,
        image_url: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_status: str = None,
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
        second_hand_car_invoice_detail_list: List[UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList] = None,
        seller_address: str = None,
        seller_bank_account: str = None,
        seller_bank_name_account: str = None,
        seller_name: str = None,
        seller_tax_no: str = None,
        seller_tel: str = None,
        supply_sign: str = None,
        tax_amount: str = None,
        used_vehicle_sale_detail_volist: List[UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList] = None,
        vehicle_sale_detail_volist: List[UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList] = None,
        verify_status: str = None,
        voucher_code: str = None,
        voucher_status: str = None,
    ):
        self.account_period = account_period
        self.amount = amount
        self.amount_with_tax = amount_with_tax
        self.check_code = check_code
        self.check_time = check_time
        self.drawer_name = drawer_name
        self.drew_date = drew_date
        self.electronic_url = electronic_url
        self.finance_type = finance_type
        self.fund_type = fund_type
        self.general_invoice_detail_volist = general_invoice_detail_volist
        self.image_url = image_url
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no
        self.invoice_status = invoice_status
        self.invoice_type = invoice_type
        self.machine_code = machine_code
        self.oil_flag = oil_flag
        self.payee = payee
        self.process_inst_code = process_inst_code
        self.process_inst_type = process_inst_type
        self.purchaser_address = purchaser_address
        self.purchaser_bank_account = purchaser_bank_account
        self.purchaser_bank_name_account = purchaser_bank_name_account
        self.purchaser_name = purchaser_name
        self.purchaser_tax_no = purchaser_tax_no
        self.purchaser_tel = purchaser_tel
        self.remark = remark
        self.second_hand_car_invoice_detail_list = second_hand_car_invoice_detail_list
        self.seller_address = seller_address
        self.seller_bank_account = seller_bank_account
        self.seller_bank_name_account = seller_bank_name_account
        self.seller_name = seller_name
        self.seller_tax_no = seller_tax_no
        self.seller_tel = seller_tel
        self.supply_sign = supply_sign
        self.tax_amount = tax_amount
        self.used_vehicle_sale_detail_volist = used_vehicle_sale_detail_volist
        self.vehicle_sale_detail_volist = vehicle_sale_detail_volist
        self.verify_status = verify_status
        self.voucher_code = voucher_code
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
        if self.drawer_name is not None:
            result['drawerName'] = self.drawer_name
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
        if self.image_url is not None:
            result['imageUrl'] = self.image_url
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_status is not None:
            result['invoiceStatus'] = self.invoice_status
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
        if m.get('drawerName') is not None:
            self.drawer_name = m.get('drawerName')
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
                temp_model = UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList()
                self.general_invoice_detail_volist.append(temp_model.from_map(k))
        if m.get('imageUrl') is not None:
            self.image_url = m.get('imageUrl')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceStatus') is not None:
            self.invoice_status = m.get('invoiceStatus')
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
                temp_model = UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList()
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
        if m.get('supplySign') is not None:
            self.supply_sign = m.get('supplySign')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        self.used_vehicle_sale_detail_volist = []
        if m.get('usedVehicleSaleDetailVOList') is not None:
            for k in m.get('usedVehicleSaleDetailVOList'):
                temp_model = UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList()
                self.used_vehicle_sale_detail_volist.append(temp_model.from_map(k))
        self.vehicle_sale_detail_volist = []
        if m.get('vehicleSaleDetailVOList') is not None:
            for k in m.get('vehicleSaleDetailVOList'):
                temp_model = UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList()
                self.vehicle_sale_detail_volist.append(temp_model.from_map(k))
        if m.get('verifyStatus') is not None:
            self.verify_status = m.get('verifyStatus')
        if m.get('voucherCode') is not None:
            self.voucher_code = m.get('voucherCode')
        if m.get('voucherStatus') is not None:
            self.voucher_status = m.get('voucherStatus')
        return self


class UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList(TeaModel):
    def __init__(
        self,
        invoice_code: str = None,
        invoice_no: str = None,
    ):
        self.invoice_code = invoice_code
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
        company_code: str = None,
        deduct_status: str = None,
        general_invoice_volist: List[UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList] = None,
        invoice_key_volist: List[UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList] = None,
        operator: str = None,
        verify_status: str = None,
    ):
        self.company_code = company_code
        self.deduct_status = deduct_status
        self.general_invoice_volist = general_invoice_volist
        self.invoice_key_volist = invoice_key_volist
        self.operator = operator
        self.verify_status = verify_status

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
        if self.company_code is not None:
            result['companyCode'] = self.company_code
        if self.deduct_status is not None:
            result['deductStatus'] = self.deduct_status
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
        if self.verify_status is not None:
            result['verifyStatus'] = self.verify_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('companyCode') is not None:
            self.company_code = m.get('companyCode')
        if m.get('deductStatus') is not None:
            self.deduct_status = m.get('deductStatus')
        self.general_invoice_volist = []
        if m.get('generalInvoiceVOList') is not None:
            for k in m.get('generalInvoiceVOList'):
                temp_model = UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList()
                self.general_invoice_volist.append(temp_model.from_map(k))
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
        status_code: int = None,
        body: UpdateInvoiceVerifyStatusResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UpdateInvoiceVerifyStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInvoiceVoucherStatusHeaders(TeaModel):
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


class UpdateInvoiceVoucherStatusRequest(TeaModel):
    def __init__(
        self,
        accountant_book_id: str = None,
        action_type: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        operator: str = None,
        voucher_id: str = None,
    ):
        self.accountant_book_id = accountant_book_id
        self.action_type = action_type
        self.invoice_code = invoice_code
        self.invoice_no = invoice_no
        self.operator = operator
        self.voucher_id = voucher_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accountant_book_id is not None:
            result['accountantBookId'] = self.accountant_book_id
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.operator is not None:
            result['operator'] = self.operator
        if self.voucher_id is not None:
            result['voucherId'] = self.voucher_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountantBookId') is not None:
            self.accountant_book_id = m.get('accountantBookId')
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('voucherId') is not None:
            self.voucher_id = m.get('voucherId')
        return self


class UpdateInvoiceVoucherStatusResponseBody(TeaModel):
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


class UpdateInvoiceVoucherStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateInvoiceVoucherStatusResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UpdateInvoiceVoucherStatusResponseBody()
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
        self.amount = amount
        self.category_code = category_code
        # This parameter is required.
        self.code = code
        self.customer_code = customer_code
        self.enterprise_acount_code = enterprise_acount_code
        self.occur_date = occur_date
        self.principal_id = principal_id
        self.project_code = project_code
        # This parameter is required.
        self.receipt_type = receipt_type
        self.remark = remark
        self.supplier_code = supplier_code
        self.title = title
        # This parameter is required.
        self.update_time = update_time
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
        self.code = code
        self.error_code = error_code
        self.error_msg = error_msg
        # This parameter is required.
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
        status_code: int = None,
        body: UpdateReceiptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        voucher_no: str = None,
    ):
        self.account_period = account_period
        self.action_type = action_type
        self.operator_id = operator_id
        self.receipt_id = receipt_id
        self.voucher_code = voucher_code
        self.voucher_id = voucher_id
        self.voucher_no = voucher_no

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
        if self.voucher_no is not None:
            result['voucherNo'] = self.voucher_no
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
        if m.get('voucherNo') is not None:
            self.voucher_no = m.get('voucherNo')
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
        status_code: int = None,
        body: UpdateReceiptVoucherStatusResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UpdateReceiptVoucherStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


