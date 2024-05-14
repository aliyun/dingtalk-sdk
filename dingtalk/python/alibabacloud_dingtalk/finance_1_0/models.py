# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, Any, List


class ApplyBatchPayHeaders(TeaModel):
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


class ApplyBatchPayRequest(TeaModel):
    def __init__(
        self,
        account_id: str = None,
        order_no: str = None,
        pass_back_params: Dict[str, Any] = None,
        pay_terminal: str = None,
        return_url: str = None,
        staff_id: str = None,
        trans_amount: str = None,
        trans_expire_time: str = None,
    ):
        # This parameter is required.
        self.account_id = account_id
        # This parameter is required.
        self.order_no = order_no
        self.pass_back_params = pass_back_params
        # This parameter is required.
        self.pay_terminal = pay_terminal
        self.return_url = return_url
        # This parameter is required.
        self.staff_id = staff_id
        # This parameter is required.
        self.trans_amount = trans_amount
        self.trans_expire_time = trans_expire_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.pass_back_params is not None:
            result['passBackParams'] = self.pass_back_params
        if self.pay_terminal is not None:
            result['payTerminal'] = self.pay_terminal
        if self.return_url is not None:
            result['returnUrl'] = self.return_url
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        if self.trans_amount is not None:
            result['transAmount'] = self.trans_amount
        if self.trans_expire_time is not None:
            result['transExpireTime'] = self.trans_expire_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('passBackParams') is not None:
            self.pass_back_params = m.get('passBackParams')
        if m.get('payTerminal') is not None:
            self.pay_terminal = m.get('payTerminal')
        if m.get('returnUrl') is not None:
            self.return_url = m.get('returnUrl')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        if m.get('transAmount') is not None:
            self.trans_amount = m.get('transAmount')
        if m.get('transExpireTime') is not None:
            self.trans_expire_time = m.get('transExpireTime')
        return self


class ApplyBatchPayResponseBody(TeaModel):
    def __init__(
        self,
        order_no: str = None,
        pay_data: str = None,
    ):
        # This parameter is required.
        self.order_no = order_no
        # This parameter is required.
        self.pay_data = pay_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.pay_data is not None:
            result['payData'] = self.pay_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('payData') is not None:
            self.pay_data = m.get('payData')
        return self


class ApplyBatchPayResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ApplyBatchPayResponseBody = None,
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
            temp_model = ApplyBatchPayResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CloseLoanEntranceHeaders(TeaModel):
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


class CloseLoanEntranceRequest(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # This parameter is required.
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class CloseLoanEntranceResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: str = None,
    ):
        # This parameter is required.
        self.request_id = request_id
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class CloseLoanEntranceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CloseLoanEntranceResponseBody = None,
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
            temp_model = CloseLoanEntranceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ConsultCreateSubInstitutionHeaders(TeaModel):
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


class ConsultCreateSubInstitutionRequestContactInfo(TeaModel):
    def __init__(
        self,
        contact_name: str = None,
        mobile: str = None,
    ):
        # This parameter is required.
        self.contact_name = contact_name
        # This parameter is required.
        self.mobile = mobile

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contact_name is not None:
            result['contactName'] = self.contact_name
        if self.mobile is not None:
            result['mobile'] = self.mobile
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contactName') is not None:
            self.contact_name = m.get('contactName')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        return self


class ConsultCreateSubInstitutionRequestLegalPersonCertInfo(TeaModel):
    def __init__(
        self,
        cert_back_image: str = None,
        cert_front_image: str = None,
        cert_name: str = None,
        cert_type: str = None,
        id_card_no: str = None,
    ):
        self.cert_back_image = cert_back_image
        self.cert_front_image = cert_front_image
        # This parameter is required.
        self.cert_name = cert_name
        self.cert_type = cert_type
        # This parameter is required.
        self.id_card_no = id_card_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_back_image is not None:
            result['certBackImage'] = self.cert_back_image
        if self.cert_front_image is not None:
            result['certFrontImage'] = self.cert_front_image
        if self.cert_name is not None:
            result['certName'] = self.cert_name
        if self.cert_type is not None:
            result['certType'] = self.cert_type
        if self.id_card_no is not None:
            result['idCardNo'] = self.id_card_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certBackImage') is not None:
            self.cert_back_image = m.get('certBackImage')
        if m.get('certFrontImage') is not None:
            self.cert_front_image = m.get('certFrontImage')
        if m.get('certName') is not None:
            self.cert_name = m.get('certName')
        if m.get('certType') is not None:
            self.cert_type = m.get('certType')
        if m.get('idCardNo') is not None:
            self.id_card_no = m.get('idCardNo')
        return self


class ConsultCreateSubInstitutionRequestQualificationInfos(TeaModel):
    def __init__(
        self,
        qualification_image: str = None,
        qualification_type: str = None,
    ):
        # This parameter is required.
        self.qualification_image = qualification_image
        # This parameter is required.
        self.qualification_type = qualification_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.qualification_image is not None:
            result['qualificationImage'] = self.qualification_image
        if self.qualification_type is not None:
            result['qualificationType'] = self.qualification_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('qualificationImage') is not None:
            self.qualification_image = m.get('qualificationImage')
        if m.get('qualificationType') is not None:
            self.qualification_type = m.get('qualificationType')
        return self


class ConsultCreateSubInstitutionRequestSettleInfo(TeaModel):
    def __init__(
        self,
        account_id: str = None,
        account_name: str = None,
        account_type: str = None,
        bank_branch_name: str = None,
        bank_city: str = None,
        bank_code: str = None,
        bank_name: str = None,
        bank_province: str = None,
        bank_short_name_code: str = None,
        type: str = None,
        usage_type: str = None,
    ):
        # This parameter is required.
        self.account_id = account_id
        self.account_name = account_name
        self.account_type = account_type
        self.bank_branch_name = bank_branch_name
        self.bank_city = bank_city
        self.bank_code = bank_code
        self.bank_name = bank_name
        self.bank_province = bank_province
        self.bank_short_name_code = bank_short_name_code
        # This parameter is required.
        self.type = type
        self.usage_type = usage_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.bank_branch_name is not None:
            result['bankBranchName'] = self.bank_branch_name
        if self.bank_city is not None:
            result['bankCity'] = self.bank_city
        if self.bank_code is not None:
            result['bankCode'] = self.bank_code
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.bank_province is not None:
            result['bankProvince'] = self.bank_province
        if self.bank_short_name_code is not None:
            result['bankShortNameCode'] = self.bank_short_name_code
        if self.type is not None:
            result['type'] = self.type
        if self.usage_type is not None:
            result['usageType'] = self.usage_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('bankBranchName') is not None:
            self.bank_branch_name = m.get('bankBranchName')
        if m.get('bankCity') is not None:
            self.bank_city = m.get('bankCity')
        if m.get('bankCode') is not None:
            self.bank_code = m.get('bankCode')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('bankProvince') is not None:
            self.bank_province = m.get('bankProvince')
        if m.get('bankShortNameCode') is not None:
            self.bank_short_name_code = m.get('bankShortNameCode')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('usageType') is not None:
            self.usage_type = m.get('usageType')
        return self


class ConsultCreateSubInstitutionRequestSubInstAddressInfo(TeaModel):
    def __init__(
        self,
        address: str = None,
        city_code: str = None,
        district_code: str = None,
        province_code: str = None,
    ):
        self.address = address
        self.city_code = city_code
        self.district_code = district_code
        self.province_code = province_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.district_code is not None:
            result['districtCode'] = self.district_code
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('districtCode') is not None:
            self.district_code = m.get('districtCode')
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        return self


class ConsultCreateSubInstitutionRequestSubInstAuthInfo(TeaModel):
    def __init__(
        self,
        authorization_letter_url: str = None,
    ):
        self.authorization_letter_url = authorization_letter_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.authorization_letter_url is not None:
            result['authorizationLetterUrl'] = self.authorization_letter_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authorizationLetterUrl') is not None:
            self.authorization_letter_url = m.get('authorizationLetterUrl')
        return self


class ConsultCreateSubInstitutionRequestSubInstBasicInfo(TeaModel):
    def __init__(
        self,
        alias_name: str = None,
        mcc: str = None,
        sub_inst_name: str = None,
        type: str = None,
    ):
        self.alias_name = alias_name
        # This parameter is required.
        self.mcc = mcc
        # This parameter is required.
        self.sub_inst_name = sub_inst_name
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alias_name is not None:
            result['aliasName'] = self.alias_name
        if self.mcc is not None:
            result['mcc'] = self.mcc
        if self.sub_inst_name is not None:
            result['subInstName'] = self.sub_inst_name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('aliasName') is not None:
            self.alias_name = m.get('aliasName')
        if m.get('mcc') is not None:
            self.mcc = m.get('mcc')
        if m.get('subInstName') is not None:
            self.sub_inst_name = m.get('subInstName')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ConsultCreateSubInstitutionRequestSubInstCertifyInfo(TeaModel):
    def __init__(
        self,
        cert_image: str = None,
        cert_no: str = None,
        cert_type: str = None,
    ):
        self.cert_image = cert_image
        # This parameter is required.
        self.cert_no = cert_no
        # This parameter is required.
        self.cert_type = cert_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_image is not None:
            result['certImage'] = self.cert_image
        if self.cert_no is not None:
            result['certNo'] = self.cert_no
        if self.cert_type is not None:
            result['certType'] = self.cert_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certImage') is not None:
            self.cert_image = m.get('certImage')
        if m.get('certNo') is not None:
            self.cert_no = m.get('certNo')
        if m.get('certType') is not None:
            self.cert_type = m.get('certType')
        return self


class ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress(TeaModel):
    def __init__(
        self,
        address: str = None,
        city_code: str = None,
        district_code: str = None,
        province_code: str = None,
    ):
        self.address = address
        self.city_code = city_code
        self.district_code = district_code
        self.province_code = province_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.district_code is not None:
            result['districtCode'] = self.district_code
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('districtCode') is not None:
            self.district_code = m.get('districtCode')
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        return self


class ConsultCreateSubInstitutionRequestSubInstInvoiceInfo(TeaModel):
    def __init__(
        self,
        accept_electronic: bool = None,
        address: str = None,
        auto_invoice: bool = None,
        bank_account: str = None,
        bank_name: str = None,
        mail_address: ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress = None,
        mail_name: str = None,
        mail_phone: str = None,
        tax_no: str = None,
        tax_payer_qualification: str = None,
        tax_payer_valid_date: str = None,
        telephone: str = None,
        title: str = None,
    ):
        self.accept_electronic = accept_electronic
        self.address = address
        self.auto_invoice = auto_invoice
        self.bank_account = bank_account
        self.bank_name = bank_name
        self.mail_address = mail_address
        self.mail_name = mail_name
        self.mail_phone = mail_phone
        self.tax_no = tax_no
        self.tax_payer_qualification = tax_payer_qualification
        self.tax_payer_valid_date = tax_payer_valid_date
        self.telephone = telephone
        self.title = title

    def validate(self):
        if self.mail_address:
            self.mail_address.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accept_electronic is not None:
            result['acceptElectronic'] = self.accept_electronic
        if self.address is not None:
            result['address'] = self.address
        if self.auto_invoice is not None:
            result['autoInvoice'] = self.auto_invoice
        if self.bank_account is not None:
            result['bankAccount'] = self.bank_account
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.mail_address is not None:
            result['mailAddress'] = self.mail_address.to_map()
        if self.mail_name is not None:
            result['mailName'] = self.mail_name
        if self.mail_phone is not None:
            result['mailPhone'] = self.mail_phone
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        if self.tax_payer_qualification is not None:
            result['taxPayerQualification'] = self.tax_payer_qualification
        if self.tax_payer_valid_date is not None:
            result['taxPayerValidDate'] = self.tax_payer_valid_date
        if self.telephone is not None:
            result['telephone'] = self.telephone
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('acceptElectronic') is not None:
            self.accept_electronic = m.get('acceptElectronic')
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('autoInvoice') is not None:
            self.auto_invoice = m.get('autoInvoice')
        if m.get('bankAccount') is not None:
            self.bank_account = m.get('bankAccount')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('mailAddress') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress()
            self.mail_address = temp_model.from_map(m['mailAddress'])
        if m.get('mailName') is not None:
            self.mail_name = m.get('mailName')
        if m.get('mailPhone') is not None:
            self.mail_phone = m.get('mailPhone')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        if m.get('taxPayerQualification') is not None:
            self.tax_payer_qualification = m.get('taxPayerQualification')
        if m.get('taxPayerValidDate') is not None:
            self.tax_payer_valid_date = m.get('taxPayerValidDate')
        if m.get('telephone') is not None:
            self.telephone = m.get('telephone')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class ConsultCreateSubInstitutionRequestSubInstShopInfo(TeaModel):
    def __init__(
        self,
        in_door_images: List[str] = None,
        out_door_images: List[str] = None,
    ):
        self.in_door_images = in_door_images
        self.out_door_images = out_door_images

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.in_door_images is not None:
            result['inDoorImages'] = self.in_door_images
        if self.out_door_images is not None:
            result['outDoorImages'] = self.out_door_images
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inDoorImages') is not None:
            self.in_door_images = m.get('inDoorImages')
        if m.get('outDoorImages') is not None:
            self.out_door_images = m.get('outDoorImages')
        return self


class ConsultCreateSubInstitutionRequest(TeaModel):
    def __init__(
        self,
        binding_alipay_logon_id: str = None,
        contact_info: ConsultCreateSubInstitutionRequestContactInfo = None,
        inst_id: str = None,
        legal_person_cert_info: ConsultCreateSubInstitutionRequestLegalPersonCertInfo = None,
        out_trade_no: str = None,
        pay_channel: str = None,
        qualification_infos: List[ConsultCreateSubInstitutionRequestQualificationInfos] = None,
        services: List[str] = None,
        settle_info: ConsultCreateSubInstitutionRequestSettleInfo = None,
        solution: str = None,
        sub_inst_address_info: ConsultCreateSubInstitutionRequestSubInstAddressInfo = None,
        sub_inst_auth_info: ConsultCreateSubInstitutionRequestSubInstAuthInfo = None,
        sub_inst_basic_info: ConsultCreateSubInstitutionRequestSubInstBasicInfo = None,
        sub_inst_certify_info: ConsultCreateSubInstitutionRequestSubInstCertifyInfo = None,
        sub_inst_id: str = None,
        sub_inst_invoice_info: ConsultCreateSubInstitutionRequestSubInstInvoiceInfo = None,
        sub_inst_shop_info: ConsultCreateSubInstitutionRequestSubInstShopInfo = None,
    ):
        self.binding_alipay_logon_id = binding_alipay_logon_id
        # This parameter is required.
        self.contact_info = contact_info
        # This parameter is required.
        self.inst_id = inst_id
        # This parameter is required.
        self.legal_person_cert_info = legal_person_cert_info
        # This parameter is required.
        self.out_trade_no = out_trade_no
        # This parameter is required.
        self.pay_channel = pay_channel
        self.qualification_infos = qualification_infos
        # This parameter is required.
        self.services = services
        # This parameter is required.
        self.settle_info = settle_info
        # This parameter is required.
        self.solution = solution
        self.sub_inst_address_info = sub_inst_address_info
        self.sub_inst_auth_info = sub_inst_auth_info
        # This parameter is required.
        self.sub_inst_basic_info = sub_inst_basic_info
        # This parameter is required.
        self.sub_inst_certify_info = sub_inst_certify_info
        # This parameter is required.
        self.sub_inst_id = sub_inst_id
        self.sub_inst_invoice_info = sub_inst_invoice_info
        self.sub_inst_shop_info = sub_inst_shop_info

    def validate(self):
        if self.contact_info:
            self.contact_info.validate()
        if self.legal_person_cert_info:
            self.legal_person_cert_info.validate()
        if self.qualification_infos:
            for k in self.qualification_infos:
                if k:
                    k.validate()
        if self.settle_info:
            self.settle_info.validate()
        if self.sub_inst_address_info:
            self.sub_inst_address_info.validate()
        if self.sub_inst_auth_info:
            self.sub_inst_auth_info.validate()
        if self.sub_inst_basic_info:
            self.sub_inst_basic_info.validate()
        if self.sub_inst_certify_info:
            self.sub_inst_certify_info.validate()
        if self.sub_inst_invoice_info:
            self.sub_inst_invoice_info.validate()
        if self.sub_inst_shop_info:
            self.sub_inst_shop_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.binding_alipay_logon_id is not None:
            result['bindingAlipayLogonId'] = self.binding_alipay_logon_id
        if self.contact_info is not None:
            result['contactInfo'] = self.contact_info.to_map()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.legal_person_cert_info is not None:
            result['legalPersonCertInfo'] = self.legal_person_cert_info.to_map()
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        result['qualificationInfos'] = []
        if self.qualification_infos is not None:
            for k in self.qualification_infos:
                result['qualificationInfos'].append(k.to_map() if k else None)
        if self.services is not None:
            result['services'] = self.services
        if self.settle_info is not None:
            result['settleInfo'] = self.settle_info.to_map()
        if self.solution is not None:
            result['solution'] = self.solution
        if self.sub_inst_address_info is not None:
            result['subInstAddressInfo'] = self.sub_inst_address_info.to_map()
        if self.sub_inst_auth_info is not None:
            result['subInstAuthInfo'] = self.sub_inst_auth_info.to_map()
        if self.sub_inst_basic_info is not None:
            result['subInstBasicInfo'] = self.sub_inst_basic_info.to_map()
        if self.sub_inst_certify_info is not None:
            result['subInstCertifyInfo'] = self.sub_inst_certify_info.to_map()
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.sub_inst_invoice_info is not None:
            result['subInstInvoiceInfo'] = self.sub_inst_invoice_info.to_map()
        if self.sub_inst_shop_info is not None:
            result['subInstShopInfo'] = self.sub_inst_shop_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bindingAlipayLogonId') is not None:
            self.binding_alipay_logon_id = m.get('bindingAlipayLogonId')
        if m.get('contactInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestContactInfo()
            self.contact_info = temp_model.from_map(m['contactInfo'])
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('legalPersonCertInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestLegalPersonCertInfo()
            self.legal_person_cert_info = temp_model.from_map(m['legalPersonCertInfo'])
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        self.qualification_infos = []
        if m.get('qualificationInfos') is not None:
            for k in m.get('qualificationInfos'):
                temp_model = ConsultCreateSubInstitutionRequestQualificationInfos()
                self.qualification_infos.append(temp_model.from_map(k))
        if m.get('services') is not None:
            self.services = m.get('services')
        if m.get('settleInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSettleInfo()
            self.settle_info = temp_model.from_map(m['settleInfo'])
        if m.get('solution') is not None:
            self.solution = m.get('solution')
        if m.get('subInstAddressInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstAddressInfo()
            self.sub_inst_address_info = temp_model.from_map(m['subInstAddressInfo'])
        if m.get('subInstAuthInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstAuthInfo()
            self.sub_inst_auth_info = temp_model.from_map(m['subInstAuthInfo'])
        if m.get('subInstBasicInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstBasicInfo()
            self.sub_inst_basic_info = temp_model.from_map(m['subInstBasicInfo'])
        if m.get('subInstCertifyInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstCertifyInfo()
            self.sub_inst_certify_info = temp_model.from_map(m['subInstCertifyInfo'])
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('subInstInvoiceInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstInvoiceInfo()
            self.sub_inst_invoice_info = temp_model.from_map(m['subInstInvoiceInfo'])
        if m.get('subInstShopInfo') is not None:
            temp_model = ConsultCreateSubInstitutionRequestSubInstShopInfo()
            self.sub_inst_shop_info = temp_model.from_map(m['subInstShopInfo'])
        return self


class ConsultCreateSubInstitutionResponseBody(TeaModel):
    def __init__(
        self,
        order_id: str = None,
    ):
        # This parameter is required.
        self.order_id = order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_id is not None:
            result['orderId'] = self.order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        return self


class ConsultCreateSubInstitutionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ConsultCreateSubInstitutionResponseBody = None,
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
            temp_model = ConsultCreateSubInstitutionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreatWithholdingOrderAndPayHeaders(TeaModel):
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


class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        ext_info: str = None,
        fund_tool_name: str = None,
        gmt_create: str = None,
        gmt_finish: str = None,
        promotion_fund_tool: bool = None,
    ):
        # This parameter is required.
        self.amount = amount
        self.ext_info = ext_info
        # This parameter is required.
        self.fund_tool_name = fund_tool_name
        # This parameter is required.
        self.gmt_create = gmt_create
        # This parameter is required.
        self.gmt_finish = gmt_finish
        # This parameter is required.
        self.promotion_fund_tool = promotion_fund_tool

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.fund_tool_name is not None:
            result['fundToolName'] = self.fund_tool_name
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.promotion_fund_tool is not None:
            result['promotionFundTool'] = self.promotion_fund_tool
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('fundToolName') is not None:
            self.fund_tool_name = m.get('fundToolName')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('promotionFundTool') is not None:
            self.promotion_fund_tool = m.get('promotionFundTool')
        return self


class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        fund_tool_detail_info_list: List[CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList] = None,
        pay_channel_name: str = None,
        pay_channel_order_no: str = None,
        pay_channel_type: str = None,
        promotion_amount: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.fund_tool_detail_info_list = fund_tool_detail_info_list
        # This parameter is required.
        self.pay_channel_name = pay_channel_name
        # This parameter is required.
        self.pay_channel_order_no = pay_channel_order_no
        # This parameter is required.
        self.pay_channel_type = pay_channel_type
        # This parameter is required.
        self.promotion_amount = promotion_amount

    def validate(self):
        if self.fund_tool_detail_info_list:
            for k in self.fund_tool_detail_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        result['fundToolDetailInfoList'] = []
        if self.fund_tool_detail_info_list is not None:
            for k in self.fund_tool_detail_info_list:
                result['fundToolDetailInfoList'].append(k.to_map() if k else None)
        if self.pay_channel_name is not None:
            result['payChannelName'] = self.pay_channel_name
        if self.pay_channel_order_no is not None:
            result['payChannelOrderNo'] = self.pay_channel_order_no
        if self.pay_channel_type is not None:
            result['payChannelType'] = self.pay_channel_type
        if self.promotion_amount is not None:
            result['promotionAmount'] = self.promotion_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        self.fund_tool_detail_info_list = []
        if m.get('fundToolDetailInfoList') is not None:
            for k in m.get('fundToolDetailInfoList'):
                temp_model = CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList()
                self.fund_tool_detail_info_list.append(temp_model.from_map(k))
        if m.get('payChannelName') is not None:
            self.pay_channel_name = m.get('payChannelName')
        if m.get('payChannelOrderNo') is not None:
            self.pay_channel_order_no = m.get('payChannelOrderNo')
        if m.get('payChannelType') is not None:
            self.pay_channel_type = m.get('payChannelType')
        if m.get('promotionAmount') is not None:
            self.promotion_amount = m.get('promotionAmount')
        return self


class CreatWithholdingOrderAndPayRequest(TeaModel):
    def __init__(
        self,
        amount: str = None,
        inst_id: str = None,
        other_pay_channel_detail_info_list: List[CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList] = None,
        out_trade_no: str = None,
        pay_channel: str = None,
        payer_user_id: str = None,
        remark: str = None,
        sub_inst_id: str = None,
        time_out_express: str = None,
        title: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.inst_id = inst_id
        self.other_pay_channel_detail_info_list = other_pay_channel_detail_info_list
        # This parameter is required.
        self.out_trade_no = out_trade_no
        # This parameter is required.
        self.pay_channel = pay_channel
        # This parameter is required.
        self.payer_user_id = payer_user_id
        self.remark = remark
        # This parameter is required.
        self.sub_inst_id = sub_inst_id
        self.time_out_express = time_out_express
        # This parameter is required.
        self.title = title

    def validate(self):
        if self.other_pay_channel_detail_info_list:
            for k in self.other_pay_channel_detail_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        result['otherPayChannelDetailInfoList'] = []
        if self.other_pay_channel_detail_info_list is not None:
            for k in self.other_pay_channel_detail_info_list:
                result['otherPayChannelDetailInfoList'].append(k.to_map() if k else None)
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.payer_user_id is not None:
            result['payerUserId'] = self.payer_user_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.time_out_express is not None:
            result['timeOutExpress'] = self.time_out_express
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        self.other_pay_channel_detail_info_list = []
        if m.get('otherPayChannelDetailInfoList') is not None:
            for k in m.get('otherPayChannelDetailInfoList'):
                temp_model = CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList()
                self.other_pay_channel_detail_info_list.append(temp_model.from_map(k))
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('payerUserId') is not None:
            self.payer_user_id = m.get('payerUserId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('timeOutExpress') is not None:
            self.time_out_express = m.get('timeOutExpress')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreatWithholdingOrderAndPayResponseBody(TeaModel):
    def __init__(
        self,
        amount: str = None,
        gmt_pay: str = None,
        inst_id: str = None,
        order_no: str = None,
        out_trade_no: str = None,
        pay_channel: str = None,
        pay_channel_account_no: str = None,
        payer_staff_id: str = None,
        remark: str = None,
        status: str = None,
        sub_inst_id: str = None,
        title: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        self.gmt_pay = gmt_pay
        # This parameter is required.
        self.inst_id = inst_id
        # This parameter is required.
        self.order_no = order_no
        # This parameter is required.
        self.out_trade_no = out_trade_no
        # This parameter is required.
        self.pay_channel = pay_channel
        # This parameter is required.
        self.pay_channel_account_no = pay_channel_account_no
        # This parameter is required.
        self.payer_staff_id = payer_staff_id
        self.remark = remark
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.sub_inst_id = sub_inst_id
        # This parameter is required.
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
        if self.gmt_pay is not None:
            result['gmtPay'] = self.gmt_pay
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.pay_channel_account_no is not None:
            result['payChannelAccountNo'] = self.pay_channel_account_no
        if self.payer_staff_id is not None:
            result['payerStaffId'] = self.payer_staff_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.status is not None:
            result['status'] = self.status
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('gmtPay') is not None:
            self.gmt_pay = m.get('gmtPay')
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('payChannelAccountNo') is not None:
            self.pay_channel_account_no = m.get('payChannelAccountNo')
        if m.get('payerStaffId') is not None:
            self.payer_staff_id = m.get('payerStaffId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreatWithholdingOrderAndPayResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreatWithholdingOrderAndPayResponseBody = None,
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
            temp_model = CreatWithholdingOrderAndPayResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateAcquireRefundOrderHeaders(TeaModel):
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


class CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        ext_info: str = None,
        fund_tool_name: str = None,
        gmt_create: str = None,
        gmt_finish: str = None,
        promotion_fund_tool: bool = None,
    ):
        # This parameter is required.
        self.amount = amount
        self.ext_info = ext_info
        # This parameter is required.
        self.fund_tool_name = fund_tool_name
        # This parameter is required.
        self.gmt_create = gmt_create
        # This parameter is required.
        self.gmt_finish = gmt_finish
        # This parameter is required.
        self.promotion_fund_tool = promotion_fund_tool

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.fund_tool_name is not None:
            result['fundToolName'] = self.fund_tool_name
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.promotion_fund_tool is not None:
            result['promotionFundTool'] = self.promotion_fund_tool
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('fundToolName') is not None:
            self.fund_tool_name = m.get('fundToolName')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('promotionFundTool') is not None:
            self.promotion_fund_tool = m.get('promotionFundTool')
        return self


class CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        fund_tool_detail_info_list: List[CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList] = None,
        pay_channel_name: str = None,
        pay_channel_order_no: str = None,
        pay_channel_type: str = None,
        promotion_amount: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.fund_tool_detail_info_list = fund_tool_detail_info_list
        # This parameter is required.
        self.pay_channel_name = pay_channel_name
        # This parameter is required.
        self.pay_channel_order_no = pay_channel_order_no
        # This parameter is required.
        self.pay_channel_type = pay_channel_type
        # This parameter is required.
        self.promotion_amount = promotion_amount

    def validate(self):
        if self.fund_tool_detail_info_list:
            for k in self.fund_tool_detail_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        result['fundToolDetailInfoList'] = []
        if self.fund_tool_detail_info_list is not None:
            for k in self.fund_tool_detail_info_list:
                result['fundToolDetailInfoList'].append(k.to_map() if k else None)
        if self.pay_channel_name is not None:
            result['payChannelName'] = self.pay_channel_name
        if self.pay_channel_order_no is not None:
            result['payChannelOrderNo'] = self.pay_channel_order_no
        if self.pay_channel_type is not None:
            result['payChannelType'] = self.pay_channel_type
        if self.promotion_amount is not None:
            result['promotionAmount'] = self.promotion_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        self.fund_tool_detail_info_list = []
        if m.get('fundToolDetailInfoList') is not None:
            for k in m.get('fundToolDetailInfoList'):
                temp_model = CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList()
                self.fund_tool_detail_info_list.append(temp_model.from_map(k))
        if m.get('payChannelName') is not None:
            self.pay_channel_name = m.get('payChannelName')
        if m.get('payChannelOrderNo') is not None:
            self.pay_channel_order_no = m.get('payChannelOrderNo')
        if m.get('payChannelType') is not None:
            self.pay_channel_type = m.get('payChannelType')
        if m.get('promotionAmount') is not None:
            self.promotion_amount = m.get('promotionAmount')
        return self


class CreateAcquireRefundOrderRequest(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        operator_user_id: str = None,
        origin_out_trade_no: str = None,
        other_pay_channel_detail_info_list: List[CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList] = None,
        out_refund_no: str = None,
        refund_amount: str = None,
        remark: str = None,
        sub_inst_id: str = None,
        title: str = None,
    ):
        # This parameter is required.
        self.inst_id = inst_id
        self.operator_user_id = operator_user_id
        # This parameter is required.
        self.origin_out_trade_no = origin_out_trade_no
        self.other_pay_channel_detail_info_list = other_pay_channel_detail_info_list
        # This parameter is required.
        self.out_refund_no = out_refund_no
        # This parameter is required.
        self.refund_amount = refund_amount
        self.remark = remark
        # This parameter is required.
        self.sub_inst_id = sub_inst_id
        # This parameter is required.
        self.title = title

    def validate(self):
        if self.other_pay_channel_detail_info_list:
            for k in self.other_pay_channel_detail_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.origin_out_trade_no is not None:
            result['originOutTradeNo'] = self.origin_out_trade_no
        result['otherPayChannelDetailInfoList'] = []
        if self.other_pay_channel_detail_info_list is not None:
            for k in self.other_pay_channel_detail_info_list:
                result['otherPayChannelDetailInfoList'].append(k.to_map() if k else None)
        if self.out_refund_no is not None:
            result['outRefundNo'] = self.out_refund_no
        if self.refund_amount is not None:
            result['refundAmount'] = self.refund_amount
        if self.remark is not None:
            result['remark'] = self.remark
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('originOutTradeNo') is not None:
            self.origin_out_trade_no = m.get('originOutTradeNo')
        self.other_pay_channel_detail_info_list = []
        if m.get('otherPayChannelDetailInfoList') is not None:
            for k in m.get('otherPayChannelDetailInfoList'):
                temp_model = CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList()
                self.other_pay_channel_detail_info_list.append(temp_model.from_map(k))
        if m.get('outRefundNo') is not None:
            self.out_refund_no = m.get('outRefundNo')
        if m.get('refundAmount') is not None:
            self.refund_amount = m.get('refundAmount')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateAcquireRefundOrderResponseBody(TeaModel):
    def __init__(
        self,
        out_refund_no: str = None,
        refund_order_no: str = None,
        status: str = None,
    ):
        # This parameter is required.
        self.out_refund_no = out_refund_no
        # This parameter is required.
        self.refund_order_no = refund_order_no
        # This parameter is required.
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_refund_no is not None:
            result['outRefundNo'] = self.out_refund_no
        if self.refund_order_no is not None:
            result['refundOrderNo'] = self.refund_order_no
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outRefundNo') is not None:
            self.out_refund_no = m.get('outRefundNo')
        if m.get('refundOrderNo') is not None:
            self.refund_order_no = m.get('refundOrderNo')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class CreateAcquireRefundOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateAcquireRefundOrderResponseBody = None,
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
            temp_model = CreateAcquireRefundOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateBatchTradeOrderHeaders(TeaModel):
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


class CreateBatchTradeOrderRequestBatchTradeDetails(TeaModel):
    def __init__(
        self,
        amount: str = None,
        memo: str = None,
        payee_account_name: str = None,
        payee_account_no: str = None,
        payee_account_type: str = None,
        serial_no: int = None,
    ):
        # This parameter is required.
        self.amount = amount
        self.memo = memo
        # This parameter is required.
        self.payee_account_name = payee_account_name
        # This parameter is required.
        self.payee_account_no = payee_account_no
        # This parameter is required.
        self.payee_account_type = payee_account_type
        # This parameter is required.
        self.serial_no = serial_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.memo is not None:
            result['memo'] = self.memo
        if self.payee_account_name is not None:
            result['payeeAccountName'] = self.payee_account_name
        if self.payee_account_no is not None:
            result['payeeAccountNo'] = self.payee_account_no
        if self.payee_account_type is not None:
            result['payeeAccountType'] = self.payee_account_type
        if self.serial_no is not None:
            result['serialNo'] = self.serial_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('payeeAccountName') is not None:
            self.payee_account_name = m.get('payeeAccountName')
        if m.get('payeeAccountNo') is not None:
            self.payee_account_no = m.get('payeeAccountNo')
        if m.get('payeeAccountType') is not None:
            self.payee_account_type = m.get('payeeAccountType')
        if m.get('serialNo') is not None:
            self.serial_no = m.get('serialNo')
        return self


class CreateBatchTradeOrderRequest(TeaModel):
    def __init__(
        self,
        account_id: str = None,
        account_no: str = None,
        batch_remark: str = None,
        batch_trade_details: List[CreateBatchTradeOrderRequestBatchTradeDetails] = None,
        out_batch_no: str = None,
        staff_id: str = None,
        total_amount: str = None,
        total_count: int = None,
        trade_title: str = None,
    ):
        # This parameter is required.
        self.account_id = account_id
        # This parameter is required.
        self.account_no = account_no
        self.batch_remark = batch_remark
        # This parameter is required.
        self.batch_trade_details = batch_trade_details
        # This parameter is required.
        self.out_batch_no = out_batch_no
        # This parameter is required.
        self.staff_id = staff_id
        # This parameter is required.
        self.total_amount = total_amount
        # This parameter is required.
        self.total_count = total_count
        # This parameter is required.
        self.trade_title = trade_title

    def validate(self):
        if self.batch_trade_details:
            for k in self.batch_trade_details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.account_no is not None:
            result['accountNo'] = self.account_no
        if self.batch_remark is not None:
            result['batchRemark'] = self.batch_remark
        result['batchTradeDetails'] = []
        if self.batch_trade_details is not None:
            for k in self.batch_trade_details:
                result['batchTradeDetails'].append(k.to_map() if k else None)
        if self.out_batch_no is not None:
            result['outBatchNo'] = self.out_batch_no
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        if self.total_amount is not None:
            result['totalAmount'] = self.total_amount
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.trade_title is not None:
            result['tradeTitle'] = self.trade_title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('accountNo') is not None:
            self.account_no = m.get('accountNo')
        if m.get('batchRemark') is not None:
            self.batch_remark = m.get('batchRemark')
        self.batch_trade_details = []
        if m.get('batchTradeDetails') is not None:
            for k in m.get('batchTradeDetails'):
                temp_model = CreateBatchTradeOrderRequestBatchTradeDetails()
                self.batch_trade_details.append(temp_model.from_map(k))
        if m.get('outBatchNo') is not None:
            self.out_batch_no = m.get('outBatchNo')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        if m.get('totalAmount') is not None:
            self.total_amount = m.get('totalAmount')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('tradeTitle') is not None:
            self.trade_title = m.get('tradeTitle')
        return self


class CreateBatchTradeOrderResponseBody(TeaModel):
    def __init__(
        self,
        order_no: str = None,
        order_status: str = None,
        out_batch_no: str = None,
    ):
        self.order_no = order_no
        # This parameter is required.
        self.order_status = order_status
        # This parameter is required.
        self.out_batch_no = out_batch_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.order_status is not None:
            result['orderStatus'] = self.order_status
        if self.out_batch_no is not None:
            result['outBatchNo'] = self.out_batch_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('orderStatus') is not None:
            self.order_status = m.get('orderStatus')
        if m.get('outBatchNo') is not None:
            self.out_batch_no = m.get('outBatchNo')
        return self


class CreateBatchTradeOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateBatchTradeOrderResponseBody = None,
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
            temp_model = CreateBatchTradeOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateSubInstitutionHeaders(TeaModel):
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


class CreateSubInstitutionRequestContactInfo(TeaModel):
    def __init__(
        self,
        contact_name: str = None,
        mobile: str = None,
    ):
        # This parameter is required.
        self.contact_name = contact_name
        # This parameter is required.
        self.mobile = mobile

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contact_name is not None:
            result['contactName'] = self.contact_name
        if self.mobile is not None:
            result['mobile'] = self.mobile
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contactName') is not None:
            self.contact_name = m.get('contactName')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        return self


class CreateSubInstitutionRequestLegalPersonCertInfo(TeaModel):
    def __init__(
        self,
        cert_back_image: str = None,
        cert_front_image: str = None,
        cert_name: str = None,
        cert_type: str = None,
        id_card_no: str = None,
    ):
        self.cert_back_image = cert_back_image
        self.cert_front_image = cert_front_image
        # This parameter is required.
        self.cert_name = cert_name
        self.cert_type = cert_type
        # This parameter is required.
        self.id_card_no = id_card_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_back_image is not None:
            result['certBackImage'] = self.cert_back_image
        if self.cert_front_image is not None:
            result['certFrontImage'] = self.cert_front_image
        if self.cert_name is not None:
            result['certName'] = self.cert_name
        if self.cert_type is not None:
            result['certType'] = self.cert_type
        if self.id_card_no is not None:
            result['idCardNo'] = self.id_card_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certBackImage') is not None:
            self.cert_back_image = m.get('certBackImage')
        if m.get('certFrontImage') is not None:
            self.cert_front_image = m.get('certFrontImage')
        if m.get('certName') is not None:
            self.cert_name = m.get('certName')
        if m.get('certType') is not None:
            self.cert_type = m.get('certType')
        if m.get('idCardNo') is not None:
            self.id_card_no = m.get('idCardNo')
        return self


class CreateSubInstitutionRequestQualificationInfos(TeaModel):
    def __init__(
        self,
        qualification_image: str = None,
        qualification_type: str = None,
    ):
        # This parameter is required.
        self.qualification_image = qualification_image
        # This parameter is required.
        self.qualification_type = qualification_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.qualification_image is not None:
            result['qualificationImage'] = self.qualification_image
        if self.qualification_type is not None:
            result['qualificationType'] = self.qualification_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('qualificationImage') is not None:
            self.qualification_image = m.get('qualificationImage')
        if m.get('qualificationType') is not None:
            self.qualification_type = m.get('qualificationType')
        return self


class CreateSubInstitutionRequestSettleInfo(TeaModel):
    def __init__(
        self,
        account_id: str = None,
        account_name: str = None,
        account_type: str = None,
        bank_branch_name: str = None,
        bank_city: str = None,
        bank_code: str = None,
        bank_name: str = None,
        bank_province: str = None,
        bank_short_name_code: str = None,
        type: str = None,
        usage_type: str = None,
    ):
        # This parameter is required.
        self.account_id = account_id
        self.account_name = account_name
        self.account_type = account_type
        self.bank_branch_name = bank_branch_name
        self.bank_city = bank_city
        self.bank_code = bank_code
        self.bank_name = bank_name
        self.bank_province = bank_province
        self.bank_short_name_code = bank_short_name_code
        # This parameter is required.
        self.type = type
        self.usage_type = usage_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.bank_branch_name is not None:
            result['bankBranchName'] = self.bank_branch_name
        if self.bank_city is not None:
            result['bankCity'] = self.bank_city
        if self.bank_code is not None:
            result['bankCode'] = self.bank_code
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.bank_province is not None:
            result['bankProvince'] = self.bank_province
        if self.bank_short_name_code is not None:
            result['bankShortNameCode'] = self.bank_short_name_code
        if self.type is not None:
            result['type'] = self.type
        if self.usage_type is not None:
            result['usageType'] = self.usage_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('bankBranchName') is not None:
            self.bank_branch_name = m.get('bankBranchName')
        if m.get('bankCity') is not None:
            self.bank_city = m.get('bankCity')
        if m.get('bankCode') is not None:
            self.bank_code = m.get('bankCode')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('bankProvince') is not None:
            self.bank_province = m.get('bankProvince')
        if m.get('bankShortNameCode') is not None:
            self.bank_short_name_code = m.get('bankShortNameCode')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('usageType') is not None:
            self.usage_type = m.get('usageType')
        return self


class CreateSubInstitutionRequestSubInstAddressInfo(TeaModel):
    def __init__(
        self,
        address: str = None,
        city_code: str = None,
        district_code: str = None,
        province_code: str = None,
    ):
        self.address = address
        self.city_code = city_code
        self.district_code = district_code
        self.province_code = province_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.district_code is not None:
            result['districtCode'] = self.district_code
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('districtCode') is not None:
            self.district_code = m.get('districtCode')
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        return self


class CreateSubInstitutionRequestSubInstAuthInfo(TeaModel):
    def __init__(
        self,
        authorization_letter_url: str = None,
    ):
        self.authorization_letter_url = authorization_letter_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.authorization_letter_url is not None:
            result['authorizationLetterUrl'] = self.authorization_letter_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authorizationLetterUrl') is not None:
            self.authorization_letter_url = m.get('authorizationLetterUrl')
        return self


class CreateSubInstitutionRequestSubInstBasicInfo(TeaModel):
    def __init__(
        self,
        alias_name: str = None,
        mcc: str = None,
        sub_inst_name: str = None,
        type: str = None,
    ):
        self.alias_name = alias_name
        # This parameter is required.
        self.mcc = mcc
        # This parameter is required.
        self.sub_inst_name = sub_inst_name
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alias_name is not None:
            result['aliasName'] = self.alias_name
        if self.mcc is not None:
            result['mcc'] = self.mcc
        if self.sub_inst_name is not None:
            result['subInstName'] = self.sub_inst_name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('aliasName') is not None:
            self.alias_name = m.get('aliasName')
        if m.get('mcc') is not None:
            self.mcc = m.get('mcc')
        if m.get('subInstName') is not None:
            self.sub_inst_name = m.get('subInstName')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateSubInstitutionRequestSubInstCertifyInfo(TeaModel):
    def __init__(
        self,
        cert_image: str = None,
        cert_no: str = None,
        cert_type: str = None,
    ):
        self.cert_image = cert_image
        # This parameter is required.
        self.cert_no = cert_no
        # This parameter is required.
        self.cert_type = cert_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_image is not None:
            result['certImage'] = self.cert_image
        if self.cert_no is not None:
            result['certNo'] = self.cert_no
        if self.cert_type is not None:
            result['certType'] = self.cert_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certImage') is not None:
            self.cert_image = m.get('certImage')
        if m.get('certNo') is not None:
            self.cert_no = m.get('certNo')
        if m.get('certType') is not None:
            self.cert_type = m.get('certType')
        return self


class CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress(TeaModel):
    def __init__(
        self,
        address: str = None,
        city_code: str = None,
        district_code: str = None,
        province_code: str = None,
    ):
        self.address = address
        self.city_code = city_code
        self.district_code = district_code
        self.province_code = province_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.district_code is not None:
            result['districtCode'] = self.district_code
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('districtCode') is not None:
            self.district_code = m.get('districtCode')
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        return self


class CreateSubInstitutionRequestSubInstInvoiceInfo(TeaModel):
    def __init__(
        self,
        accept_electronic: bool = None,
        address: str = None,
        auto_invoice: bool = None,
        bank_account: str = None,
        bank_name: str = None,
        mail_address: CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress = None,
        mail_name: str = None,
        mail_phone: str = None,
        tax_no: str = None,
        tax_payer_qualification: str = None,
        tax_payer_valid_date: str = None,
        telephone: str = None,
        title: str = None,
    ):
        self.accept_electronic = accept_electronic
        self.address = address
        self.auto_invoice = auto_invoice
        self.bank_account = bank_account
        self.bank_name = bank_name
        self.mail_address = mail_address
        self.mail_name = mail_name
        self.mail_phone = mail_phone
        self.tax_no = tax_no
        self.tax_payer_qualification = tax_payer_qualification
        self.tax_payer_valid_date = tax_payer_valid_date
        self.telephone = telephone
        self.title = title

    def validate(self):
        if self.mail_address:
            self.mail_address.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accept_electronic is not None:
            result['acceptElectronic'] = self.accept_electronic
        if self.address is not None:
            result['address'] = self.address
        if self.auto_invoice is not None:
            result['autoInvoice'] = self.auto_invoice
        if self.bank_account is not None:
            result['bankAccount'] = self.bank_account
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.mail_address is not None:
            result['mailAddress'] = self.mail_address.to_map()
        if self.mail_name is not None:
            result['mailName'] = self.mail_name
        if self.mail_phone is not None:
            result['mailPhone'] = self.mail_phone
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        if self.tax_payer_qualification is not None:
            result['taxPayerQualification'] = self.tax_payer_qualification
        if self.tax_payer_valid_date is not None:
            result['taxPayerValidDate'] = self.tax_payer_valid_date
        if self.telephone is not None:
            result['telephone'] = self.telephone
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('acceptElectronic') is not None:
            self.accept_electronic = m.get('acceptElectronic')
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('autoInvoice') is not None:
            self.auto_invoice = m.get('autoInvoice')
        if m.get('bankAccount') is not None:
            self.bank_account = m.get('bankAccount')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('mailAddress') is not None:
            temp_model = CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress()
            self.mail_address = temp_model.from_map(m['mailAddress'])
        if m.get('mailName') is not None:
            self.mail_name = m.get('mailName')
        if m.get('mailPhone') is not None:
            self.mail_phone = m.get('mailPhone')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        if m.get('taxPayerQualification') is not None:
            self.tax_payer_qualification = m.get('taxPayerQualification')
        if m.get('taxPayerValidDate') is not None:
            self.tax_payer_valid_date = m.get('taxPayerValidDate')
        if m.get('telephone') is not None:
            self.telephone = m.get('telephone')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateSubInstitutionRequestSubInstShopInfo(TeaModel):
    def __init__(
        self,
        in_door_images: List[str] = None,
        out_door_images: List[str] = None,
    ):
        self.in_door_images = in_door_images
        self.out_door_images = out_door_images

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.in_door_images is not None:
            result['inDoorImages'] = self.in_door_images
        if self.out_door_images is not None:
            result['outDoorImages'] = self.out_door_images
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inDoorImages') is not None:
            self.in_door_images = m.get('inDoorImages')
        if m.get('outDoorImages') is not None:
            self.out_door_images = m.get('outDoorImages')
        return self


class CreateSubInstitutionRequest(TeaModel):
    def __init__(
        self,
        binding_alipay_logon_id: str = None,
        contact_info: CreateSubInstitutionRequestContactInfo = None,
        inst_id: str = None,
        legal_person_cert_info: CreateSubInstitutionRequestLegalPersonCertInfo = None,
        out_trade_no: str = None,
        pay_channel: str = None,
        qualification_infos: List[CreateSubInstitutionRequestQualificationInfos] = None,
        services: List[str] = None,
        settle_info: CreateSubInstitutionRequestSettleInfo = None,
        solution: str = None,
        sub_inst_address_info: CreateSubInstitutionRequestSubInstAddressInfo = None,
        sub_inst_auth_info: CreateSubInstitutionRequestSubInstAuthInfo = None,
        sub_inst_basic_info: CreateSubInstitutionRequestSubInstBasicInfo = None,
        sub_inst_certify_info: CreateSubInstitutionRequestSubInstCertifyInfo = None,
        sub_inst_id: str = None,
        sub_inst_invoice_info: CreateSubInstitutionRequestSubInstInvoiceInfo = None,
        sub_inst_shop_info: CreateSubInstitutionRequestSubInstShopInfo = None,
    ):
        self.binding_alipay_logon_id = binding_alipay_logon_id
        # This parameter is required.
        self.contact_info = contact_info
        # This parameter is required.
        self.inst_id = inst_id
        # This parameter is required.
        self.legal_person_cert_info = legal_person_cert_info
        # This parameter is required.
        self.out_trade_no = out_trade_no
        # This parameter is required.
        self.pay_channel = pay_channel
        self.qualification_infos = qualification_infos
        # This parameter is required.
        self.services = services
        # This parameter is required.
        self.settle_info = settle_info
        # This parameter is required.
        self.solution = solution
        self.sub_inst_address_info = sub_inst_address_info
        self.sub_inst_auth_info = sub_inst_auth_info
        # This parameter is required.
        self.sub_inst_basic_info = sub_inst_basic_info
        # This parameter is required.
        self.sub_inst_certify_info = sub_inst_certify_info
        # This parameter is required.
        self.sub_inst_id = sub_inst_id
        self.sub_inst_invoice_info = sub_inst_invoice_info
        self.sub_inst_shop_info = sub_inst_shop_info

    def validate(self):
        if self.contact_info:
            self.contact_info.validate()
        if self.legal_person_cert_info:
            self.legal_person_cert_info.validate()
        if self.qualification_infos:
            for k in self.qualification_infos:
                if k:
                    k.validate()
        if self.settle_info:
            self.settle_info.validate()
        if self.sub_inst_address_info:
            self.sub_inst_address_info.validate()
        if self.sub_inst_auth_info:
            self.sub_inst_auth_info.validate()
        if self.sub_inst_basic_info:
            self.sub_inst_basic_info.validate()
        if self.sub_inst_certify_info:
            self.sub_inst_certify_info.validate()
        if self.sub_inst_invoice_info:
            self.sub_inst_invoice_info.validate()
        if self.sub_inst_shop_info:
            self.sub_inst_shop_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.binding_alipay_logon_id is not None:
            result['bindingAlipayLogonId'] = self.binding_alipay_logon_id
        if self.contact_info is not None:
            result['contactInfo'] = self.contact_info.to_map()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.legal_person_cert_info is not None:
            result['legalPersonCertInfo'] = self.legal_person_cert_info.to_map()
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        result['qualificationInfos'] = []
        if self.qualification_infos is not None:
            for k in self.qualification_infos:
                result['qualificationInfos'].append(k.to_map() if k else None)
        if self.services is not None:
            result['services'] = self.services
        if self.settle_info is not None:
            result['settleInfo'] = self.settle_info.to_map()
        if self.solution is not None:
            result['solution'] = self.solution
        if self.sub_inst_address_info is not None:
            result['subInstAddressInfo'] = self.sub_inst_address_info.to_map()
        if self.sub_inst_auth_info is not None:
            result['subInstAuthInfo'] = self.sub_inst_auth_info.to_map()
        if self.sub_inst_basic_info is not None:
            result['subInstBasicInfo'] = self.sub_inst_basic_info.to_map()
        if self.sub_inst_certify_info is not None:
            result['subInstCertifyInfo'] = self.sub_inst_certify_info.to_map()
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.sub_inst_invoice_info is not None:
            result['subInstInvoiceInfo'] = self.sub_inst_invoice_info.to_map()
        if self.sub_inst_shop_info is not None:
            result['subInstShopInfo'] = self.sub_inst_shop_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bindingAlipayLogonId') is not None:
            self.binding_alipay_logon_id = m.get('bindingAlipayLogonId')
        if m.get('contactInfo') is not None:
            temp_model = CreateSubInstitutionRequestContactInfo()
            self.contact_info = temp_model.from_map(m['contactInfo'])
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('legalPersonCertInfo') is not None:
            temp_model = CreateSubInstitutionRequestLegalPersonCertInfo()
            self.legal_person_cert_info = temp_model.from_map(m['legalPersonCertInfo'])
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        self.qualification_infos = []
        if m.get('qualificationInfos') is not None:
            for k in m.get('qualificationInfos'):
                temp_model = CreateSubInstitutionRequestQualificationInfos()
                self.qualification_infos.append(temp_model.from_map(k))
        if m.get('services') is not None:
            self.services = m.get('services')
        if m.get('settleInfo') is not None:
            temp_model = CreateSubInstitutionRequestSettleInfo()
            self.settle_info = temp_model.from_map(m['settleInfo'])
        if m.get('solution') is not None:
            self.solution = m.get('solution')
        if m.get('subInstAddressInfo') is not None:
            temp_model = CreateSubInstitutionRequestSubInstAddressInfo()
            self.sub_inst_address_info = temp_model.from_map(m['subInstAddressInfo'])
        if m.get('subInstAuthInfo') is not None:
            temp_model = CreateSubInstitutionRequestSubInstAuthInfo()
            self.sub_inst_auth_info = temp_model.from_map(m['subInstAuthInfo'])
        if m.get('subInstBasicInfo') is not None:
            temp_model = CreateSubInstitutionRequestSubInstBasicInfo()
            self.sub_inst_basic_info = temp_model.from_map(m['subInstBasicInfo'])
        if m.get('subInstCertifyInfo') is not None:
            temp_model = CreateSubInstitutionRequestSubInstCertifyInfo()
            self.sub_inst_certify_info = temp_model.from_map(m['subInstCertifyInfo'])
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('subInstInvoiceInfo') is not None:
            temp_model = CreateSubInstitutionRequestSubInstInvoiceInfo()
            self.sub_inst_invoice_info = temp_model.from_map(m['subInstInvoiceInfo'])
        if m.get('subInstShopInfo') is not None:
            temp_model = CreateSubInstitutionRequestSubInstShopInfo()
            self.sub_inst_shop_info = temp_model.from_map(m['subInstShopInfo'])
        return self


class CreateSubInstitutionResponseBody(TeaModel):
    def __init__(
        self,
        order_id: str = None,
    ):
        # This parameter is required.
        self.order_id = order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_id is not None:
            result['orderId'] = self.order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        return self


class CreateSubInstitutionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateSubInstitutionResponseBody = None,
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
            temp_model = CreateSubInstitutionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateUserCodeInstanceHeaders(TeaModel):
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


class CreateUserCodeInstanceRequestAvailableTimes(TeaModel):
    def __init__(
        self,
        gmt_end: str = None,
        gmt_start: str = None,
    ):
        # This parameter is required.
        self.gmt_end = gmt_end
        # This parameter is required.
        self.gmt_start = gmt_start

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_end is not None:
            result['gmtEnd'] = self.gmt_end
        if self.gmt_start is not None:
            result['gmtStart'] = self.gmt_start
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtEnd') is not None:
            self.gmt_end = m.get('gmtEnd')
        if m.get('gmtStart') is not None:
            self.gmt_start = m.get('gmtStart')
        return self


class CreateUserCodeInstanceRequest(TeaModel):
    def __init__(
        self,
        available_times: List[CreateUserCodeInstanceRequestAvailableTimes] = None,
        code_identity: str = None,
        code_value: str = None,
        code_value_type: str = None,
        corp_id: str = None,
        ext_info: Dict[str, Any] = None,
        gmt_expired: str = None,
        request_id: str = None,
        status: str = None,
        user_corp_relation_type: str = None,
        user_identity: str = None,
    ):
        # This parameter is required.
        self.available_times = available_times
        # This parameter is required.
        self.code_identity = code_identity
        self.code_value = code_value
        self.code_value_type = code_value_type
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.ext_info = ext_info
        # This parameter is required.
        self.gmt_expired = gmt_expired
        # This parameter is required.
        self.request_id = request_id
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.user_corp_relation_type = user_corp_relation_type
        # This parameter is required.
        self.user_identity = user_identity

    def validate(self):
        if self.available_times:
            for k in self.available_times:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['availableTimes'] = []
        if self.available_times is not None:
            for k in self.available_times:
                result['availableTimes'].append(k.to_map() if k else None)
        if self.code_identity is not None:
            result['codeIdentity'] = self.code_identity
        if self.code_value is not None:
            result['codeValue'] = self.code_value
        if self.code_value_type is not None:
            result['codeValueType'] = self.code_value_type
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.gmt_expired is not None:
            result['gmtExpired'] = self.gmt_expired
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.status is not None:
            result['status'] = self.status
        if self.user_corp_relation_type is not None:
            result['userCorpRelationType'] = self.user_corp_relation_type
        if self.user_identity is not None:
            result['userIdentity'] = self.user_identity
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.available_times = []
        if m.get('availableTimes') is not None:
            for k in m.get('availableTimes'):
                temp_model = CreateUserCodeInstanceRequestAvailableTimes()
                self.available_times.append(temp_model.from_map(k))
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('codeValue') is not None:
            self.code_value = m.get('codeValue')
        if m.get('codeValueType') is not None:
            self.code_value_type = m.get('codeValueType')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('gmtExpired') is not None:
            self.gmt_expired = m.get('gmtExpired')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userCorpRelationType') is not None:
            self.user_corp_relation_type = m.get('userCorpRelationType')
        if m.get('userIdentity') is not None:
            self.user_identity = m.get('userIdentity')
        return self


class CreateUserCodeInstanceResponseBody(TeaModel):
    def __init__(
        self,
        code_detail_url: str = None,
        code_id: str = None,
    ):
        self.code_detail_url = code_detail_url
        # This parameter is required.
        self.code_id = code_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code_detail_url is not None:
            result['codeDetailUrl'] = self.code_detail_url
        if self.code_id is not None:
            result['codeId'] = self.code_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('codeDetailUrl') is not None:
            self.code_detail_url = m.get('codeDetailUrl')
        if m.get('codeId') is not None:
            self.code_id = m.get('codeId')
        return self


class CreateUserCodeInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateUserCodeInstanceResponseBody = None,
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
            temp_model = CreateUserCodeInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DecodePayCodeHeaders(TeaModel):
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


class DecodePayCodeRequest(TeaModel):
    def __init__(
        self,
        pay_code: str = None,
        request_id: str = None,
    ):
        self.pay_code = pay_code
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pay_code is not None:
            result['payCode'] = self.pay_code
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('payCode') is not None:
            self.pay_code = m.get('payCode')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class DecodePayCodeResponseBody(TeaModel):
    def __init__(
        self,
        alipay_code: str = None,
        code_id: str = None,
        code_identity: str = None,
        code_type: str = None,
        corp_id: str = None,
        ext_info: str = None,
        out_biz_id: str = None,
        user_corp_relation_type: str = None,
        user_id: str = None,
        user_in_corp: bool = None,
    ):
        self.alipay_code = alipay_code
        self.code_id = code_id
        self.code_identity = code_identity
        self.code_type = code_type
        self.corp_id = corp_id
        self.ext_info = ext_info
        self.out_biz_id = out_biz_id
        self.user_corp_relation_type = user_corp_relation_type
        self.user_id = user_id
        self.user_in_corp = user_in_corp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_code is not None:
            result['alipayCode'] = self.alipay_code
        if self.code_id is not None:
            result['codeId'] = self.code_id
        if self.code_identity is not None:
            result['codeIdentity'] = self.code_identity
        if self.code_type is not None:
            result['codeType'] = self.code_type
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.out_biz_id is not None:
            result['outBizId'] = self.out_biz_id
        if self.user_corp_relation_type is not None:
            result['userCorpRelationType'] = self.user_corp_relation_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_in_corp is not None:
            result['userInCorp'] = self.user_in_corp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayCode') is not None:
            self.alipay_code = m.get('alipayCode')
        if m.get('codeId') is not None:
            self.code_id = m.get('codeId')
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('codeType') is not None:
            self.code_type = m.get('codeType')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('outBizId') is not None:
            self.out_biz_id = m.get('outBizId')
        if m.get('userCorpRelationType') is not None:
            self.user_corp_relation_type = m.get('userCorpRelationType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userInCorp') is not None:
            self.user_in_corp = m.get('userInCorp')
        return self


class DecodePayCodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DecodePayCodeResponseBody = None,
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
            temp_model = DecodePayCodeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ModifySubInstitutionHeaders(TeaModel):
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


class ModifySubInstitutionRequestContactInfo(TeaModel):
    def __init__(
        self,
        contact_name: str = None,
        mobile: str = None,
    ):
        # This parameter is required.
        self.contact_name = contact_name
        # This parameter is required.
        self.mobile = mobile

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contact_name is not None:
            result['contactName'] = self.contact_name
        if self.mobile is not None:
            result['mobile'] = self.mobile
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contactName') is not None:
            self.contact_name = m.get('contactName')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        return self


class ModifySubInstitutionRequestLegalPersonCertInfo(TeaModel):
    def __init__(
        self,
        cert_back_image: str = None,
        cert_front_image: str = None,
        cert_name: str = None,
        cert_type: str = None,
        id_card_no: str = None,
    ):
        self.cert_back_image = cert_back_image
        self.cert_front_image = cert_front_image
        # This parameter is required.
        self.cert_name = cert_name
        self.cert_type = cert_type
        # This parameter is required.
        self.id_card_no = id_card_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_back_image is not None:
            result['certBackImage'] = self.cert_back_image
        if self.cert_front_image is not None:
            result['certFrontImage'] = self.cert_front_image
        if self.cert_name is not None:
            result['certName'] = self.cert_name
        if self.cert_type is not None:
            result['certType'] = self.cert_type
        if self.id_card_no is not None:
            result['idCardNo'] = self.id_card_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certBackImage') is not None:
            self.cert_back_image = m.get('certBackImage')
        if m.get('certFrontImage') is not None:
            self.cert_front_image = m.get('certFrontImage')
        if m.get('certName') is not None:
            self.cert_name = m.get('certName')
        if m.get('certType') is not None:
            self.cert_type = m.get('certType')
        if m.get('idCardNo') is not None:
            self.id_card_no = m.get('idCardNo')
        return self


class ModifySubInstitutionRequestQualificationInfos(TeaModel):
    def __init__(
        self,
        qualification_image: str = None,
        qualification_type: str = None,
    ):
        # This parameter is required.
        self.qualification_image = qualification_image
        # This parameter is required.
        self.qualification_type = qualification_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.qualification_image is not None:
            result['qualificationImage'] = self.qualification_image
        if self.qualification_type is not None:
            result['qualificationType'] = self.qualification_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('qualificationImage') is not None:
            self.qualification_image = m.get('qualificationImage')
        if m.get('qualificationType') is not None:
            self.qualification_type = m.get('qualificationType')
        return self


class ModifySubInstitutionRequestSettleInfo(TeaModel):
    def __init__(
        self,
        account_id: str = None,
        account_name: str = None,
        account_type: str = None,
        bank_branch_name: str = None,
        bank_city: str = None,
        bank_code: str = None,
        bank_name: str = None,
        bank_province: str = None,
        bank_short_name_code: str = None,
        type: str = None,
        usage_type: str = None,
    ):
        # This parameter is required.
        self.account_id = account_id
        self.account_name = account_name
        self.account_type = account_type
        self.bank_branch_name = bank_branch_name
        self.bank_city = bank_city
        self.bank_code = bank_code
        self.bank_name = bank_name
        self.bank_province = bank_province
        self.bank_short_name_code = bank_short_name_code
        # This parameter is required.
        self.type = type
        self.usage_type = usage_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.bank_branch_name is not None:
            result['bankBranchName'] = self.bank_branch_name
        if self.bank_city is not None:
            result['bankCity'] = self.bank_city
        if self.bank_code is not None:
            result['bankCode'] = self.bank_code
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.bank_province is not None:
            result['bankProvince'] = self.bank_province
        if self.bank_short_name_code is not None:
            result['bankShortNameCode'] = self.bank_short_name_code
        if self.type is not None:
            result['type'] = self.type
        if self.usage_type is not None:
            result['usageType'] = self.usage_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('bankBranchName') is not None:
            self.bank_branch_name = m.get('bankBranchName')
        if m.get('bankCity') is not None:
            self.bank_city = m.get('bankCity')
        if m.get('bankCode') is not None:
            self.bank_code = m.get('bankCode')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('bankProvince') is not None:
            self.bank_province = m.get('bankProvince')
        if m.get('bankShortNameCode') is not None:
            self.bank_short_name_code = m.get('bankShortNameCode')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('usageType') is not None:
            self.usage_type = m.get('usageType')
        return self


class ModifySubInstitutionRequestSubInstAddressInfo(TeaModel):
    def __init__(
        self,
        address: str = None,
        city_code: str = None,
        district_code: str = None,
        province_code: str = None,
    ):
        self.address = address
        self.city_code = city_code
        self.district_code = district_code
        self.province_code = province_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.district_code is not None:
            result['districtCode'] = self.district_code
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('districtCode') is not None:
            self.district_code = m.get('districtCode')
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        return self


class ModifySubInstitutionRequestSubInstAuthInfo(TeaModel):
    def __init__(
        self,
        authorization_letter_url: str = None,
    ):
        self.authorization_letter_url = authorization_letter_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.authorization_letter_url is not None:
            result['authorizationLetterUrl'] = self.authorization_letter_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authorizationLetterUrl') is not None:
            self.authorization_letter_url = m.get('authorizationLetterUrl')
        return self


class ModifySubInstitutionRequestSubInstBasicInfo(TeaModel):
    def __init__(
        self,
        alias_name: str = None,
        mcc: str = None,
        sub_inst_name: str = None,
        type: str = None,
    ):
        self.alias_name = alias_name
        # This parameter is required.
        self.mcc = mcc
        # This parameter is required.
        self.sub_inst_name = sub_inst_name
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alias_name is not None:
            result['aliasName'] = self.alias_name
        if self.mcc is not None:
            result['mcc'] = self.mcc
        if self.sub_inst_name is not None:
            result['subInstName'] = self.sub_inst_name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('aliasName') is not None:
            self.alias_name = m.get('aliasName')
        if m.get('mcc') is not None:
            self.mcc = m.get('mcc')
        if m.get('subInstName') is not None:
            self.sub_inst_name = m.get('subInstName')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ModifySubInstitutionRequestSubInstCertifyInfo(TeaModel):
    def __init__(
        self,
        cert_image: str = None,
        cert_no: str = None,
        cert_type: str = None,
    ):
        self.cert_image = cert_image
        # This parameter is required.
        self.cert_no = cert_no
        # This parameter is required.
        self.cert_type = cert_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_image is not None:
            result['certImage'] = self.cert_image
        if self.cert_no is not None:
            result['certNo'] = self.cert_no
        if self.cert_type is not None:
            result['certType'] = self.cert_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certImage') is not None:
            self.cert_image = m.get('certImage')
        if m.get('certNo') is not None:
            self.cert_no = m.get('certNo')
        if m.get('certType') is not None:
            self.cert_type = m.get('certType')
        return self


class ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress(TeaModel):
    def __init__(
        self,
        address: str = None,
        city_code: str = None,
        district_code: str = None,
        province_code: str = None,
    ):
        self.address = address
        self.city_code = city_code
        self.district_code = district_code
        self.province_code = province_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.city_code is not None:
            result['cityCode'] = self.city_code
        if self.district_code is not None:
            result['districtCode'] = self.district_code
        if self.province_code is not None:
            result['provinceCode'] = self.province_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('cityCode') is not None:
            self.city_code = m.get('cityCode')
        if m.get('districtCode') is not None:
            self.district_code = m.get('districtCode')
        if m.get('provinceCode') is not None:
            self.province_code = m.get('provinceCode')
        return self


class ModifySubInstitutionRequestSubInstInvoiceInfo(TeaModel):
    def __init__(
        self,
        accept_electronic: bool = None,
        address: str = None,
        auto_invoice: bool = None,
        bank_account: str = None,
        bank_name: str = None,
        mail_address: ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress = None,
        mail_name: str = None,
        mail_phone: str = None,
        tax_no: str = None,
        tax_payer_qualification: str = None,
        tax_payer_valid_date: str = None,
        telephone: str = None,
        title: str = None,
    ):
        self.accept_electronic = accept_electronic
        self.address = address
        self.auto_invoice = auto_invoice
        self.bank_account = bank_account
        self.bank_name = bank_name
        self.mail_address = mail_address
        self.mail_name = mail_name
        self.mail_phone = mail_phone
        self.tax_no = tax_no
        self.tax_payer_qualification = tax_payer_qualification
        self.tax_payer_valid_date = tax_payer_valid_date
        self.telephone = telephone
        self.title = title

    def validate(self):
        if self.mail_address:
            self.mail_address.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accept_electronic is not None:
            result['acceptElectronic'] = self.accept_electronic
        if self.address is not None:
            result['address'] = self.address
        if self.auto_invoice is not None:
            result['autoInvoice'] = self.auto_invoice
        if self.bank_account is not None:
            result['bankAccount'] = self.bank_account
        if self.bank_name is not None:
            result['bankName'] = self.bank_name
        if self.mail_address is not None:
            result['mailAddress'] = self.mail_address.to_map()
        if self.mail_name is not None:
            result['mailName'] = self.mail_name
        if self.mail_phone is not None:
            result['mailPhone'] = self.mail_phone
        if self.tax_no is not None:
            result['taxNo'] = self.tax_no
        if self.tax_payer_qualification is not None:
            result['taxPayerQualification'] = self.tax_payer_qualification
        if self.tax_payer_valid_date is not None:
            result['taxPayerValidDate'] = self.tax_payer_valid_date
        if self.telephone is not None:
            result['telephone'] = self.telephone
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('acceptElectronic') is not None:
            self.accept_electronic = m.get('acceptElectronic')
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('autoInvoice') is not None:
            self.auto_invoice = m.get('autoInvoice')
        if m.get('bankAccount') is not None:
            self.bank_account = m.get('bankAccount')
        if m.get('bankName') is not None:
            self.bank_name = m.get('bankName')
        if m.get('mailAddress') is not None:
            temp_model = ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress()
            self.mail_address = temp_model.from_map(m['mailAddress'])
        if m.get('mailName') is not None:
            self.mail_name = m.get('mailName')
        if m.get('mailPhone') is not None:
            self.mail_phone = m.get('mailPhone')
        if m.get('taxNo') is not None:
            self.tax_no = m.get('taxNo')
        if m.get('taxPayerQualification') is not None:
            self.tax_payer_qualification = m.get('taxPayerQualification')
        if m.get('taxPayerValidDate') is not None:
            self.tax_payer_valid_date = m.get('taxPayerValidDate')
        if m.get('telephone') is not None:
            self.telephone = m.get('telephone')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class ModifySubInstitutionRequestSubInstShopInfo(TeaModel):
    def __init__(
        self,
        in_door_images: List[str] = None,
        out_door_images: List[str] = None,
    ):
        self.in_door_images = in_door_images
        self.out_door_images = out_door_images

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.in_door_images is not None:
            result['inDoorImages'] = self.in_door_images
        if self.out_door_images is not None:
            result['outDoorImages'] = self.out_door_images
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inDoorImages') is not None:
            self.in_door_images = m.get('inDoorImages')
        if m.get('outDoorImages') is not None:
            self.out_door_images = m.get('outDoorImages')
        return self


class ModifySubInstitutionRequest(TeaModel):
    def __init__(
        self,
        binding_alipay_logon_id: str = None,
        contact_info: ModifySubInstitutionRequestContactInfo = None,
        inst_id: str = None,
        legal_person_cert_info: ModifySubInstitutionRequestLegalPersonCertInfo = None,
        out_trade_no: str = None,
        pay_channel: str = None,
        qualification_infos: List[ModifySubInstitutionRequestQualificationInfos] = None,
        services: List[str] = None,
        settle_info: ModifySubInstitutionRequestSettleInfo = None,
        sub_inst_address_info: ModifySubInstitutionRequestSubInstAddressInfo = None,
        sub_inst_auth_info: ModifySubInstitutionRequestSubInstAuthInfo = None,
        sub_inst_basic_info: ModifySubInstitutionRequestSubInstBasicInfo = None,
        sub_inst_certify_info: ModifySubInstitutionRequestSubInstCertifyInfo = None,
        sub_inst_id: str = None,
        sub_inst_invoice_info: ModifySubInstitutionRequestSubInstInvoiceInfo = None,
        sub_inst_shop_info: ModifySubInstitutionRequestSubInstShopInfo = None,
    ):
        self.binding_alipay_logon_id = binding_alipay_logon_id
        # This parameter is required.
        self.contact_info = contact_info
        # This parameter is required.
        self.inst_id = inst_id
        # This parameter is required.
        self.legal_person_cert_info = legal_person_cert_info
        # This parameter is required.
        self.out_trade_no = out_trade_no
        # This parameter is required.
        self.pay_channel = pay_channel
        self.qualification_infos = qualification_infos
        # This parameter is required.
        self.services = services
        # This parameter is required.
        self.settle_info = settle_info
        self.sub_inst_address_info = sub_inst_address_info
        self.sub_inst_auth_info = sub_inst_auth_info
        # This parameter is required.
        self.sub_inst_basic_info = sub_inst_basic_info
        # This parameter is required.
        self.sub_inst_certify_info = sub_inst_certify_info
        # This parameter is required.
        self.sub_inst_id = sub_inst_id
        self.sub_inst_invoice_info = sub_inst_invoice_info
        self.sub_inst_shop_info = sub_inst_shop_info

    def validate(self):
        if self.contact_info:
            self.contact_info.validate()
        if self.legal_person_cert_info:
            self.legal_person_cert_info.validate()
        if self.qualification_infos:
            for k in self.qualification_infos:
                if k:
                    k.validate()
        if self.settle_info:
            self.settle_info.validate()
        if self.sub_inst_address_info:
            self.sub_inst_address_info.validate()
        if self.sub_inst_auth_info:
            self.sub_inst_auth_info.validate()
        if self.sub_inst_basic_info:
            self.sub_inst_basic_info.validate()
        if self.sub_inst_certify_info:
            self.sub_inst_certify_info.validate()
        if self.sub_inst_invoice_info:
            self.sub_inst_invoice_info.validate()
        if self.sub_inst_shop_info:
            self.sub_inst_shop_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.binding_alipay_logon_id is not None:
            result['bindingAlipayLogonId'] = self.binding_alipay_logon_id
        if self.contact_info is not None:
            result['contactInfo'] = self.contact_info.to_map()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.legal_person_cert_info is not None:
            result['legalPersonCertInfo'] = self.legal_person_cert_info.to_map()
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        result['qualificationInfos'] = []
        if self.qualification_infos is not None:
            for k in self.qualification_infos:
                result['qualificationInfos'].append(k.to_map() if k else None)
        if self.services is not None:
            result['services'] = self.services
        if self.settle_info is not None:
            result['settleInfo'] = self.settle_info.to_map()
        if self.sub_inst_address_info is not None:
            result['subInstAddressInfo'] = self.sub_inst_address_info.to_map()
        if self.sub_inst_auth_info is not None:
            result['subInstAuthInfo'] = self.sub_inst_auth_info.to_map()
        if self.sub_inst_basic_info is not None:
            result['subInstBasicInfo'] = self.sub_inst_basic_info.to_map()
        if self.sub_inst_certify_info is not None:
            result['subInstCertifyInfo'] = self.sub_inst_certify_info.to_map()
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.sub_inst_invoice_info is not None:
            result['subInstInvoiceInfo'] = self.sub_inst_invoice_info.to_map()
        if self.sub_inst_shop_info is not None:
            result['subInstShopInfo'] = self.sub_inst_shop_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bindingAlipayLogonId') is not None:
            self.binding_alipay_logon_id = m.get('bindingAlipayLogonId')
        if m.get('contactInfo') is not None:
            temp_model = ModifySubInstitutionRequestContactInfo()
            self.contact_info = temp_model.from_map(m['contactInfo'])
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('legalPersonCertInfo') is not None:
            temp_model = ModifySubInstitutionRequestLegalPersonCertInfo()
            self.legal_person_cert_info = temp_model.from_map(m['legalPersonCertInfo'])
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        self.qualification_infos = []
        if m.get('qualificationInfos') is not None:
            for k in m.get('qualificationInfos'):
                temp_model = ModifySubInstitutionRequestQualificationInfos()
                self.qualification_infos.append(temp_model.from_map(k))
        if m.get('services') is not None:
            self.services = m.get('services')
        if m.get('settleInfo') is not None:
            temp_model = ModifySubInstitutionRequestSettleInfo()
            self.settle_info = temp_model.from_map(m['settleInfo'])
        if m.get('subInstAddressInfo') is not None:
            temp_model = ModifySubInstitutionRequestSubInstAddressInfo()
            self.sub_inst_address_info = temp_model.from_map(m['subInstAddressInfo'])
        if m.get('subInstAuthInfo') is not None:
            temp_model = ModifySubInstitutionRequestSubInstAuthInfo()
            self.sub_inst_auth_info = temp_model.from_map(m['subInstAuthInfo'])
        if m.get('subInstBasicInfo') is not None:
            temp_model = ModifySubInstitutionRequestSubInstBasicInfo()
            self.sub_inst_basic_info = temp_model.from_map(m['subInstBasicInfo'])
        if m.get('subInstCertifyInfo') is not None:
            temp_model = ModifySubInstitutionRequestSubInstCertifyInfo()
            self.sub_inst_certify_info = temp_model.from_map(m['subInstCertifyInfo'])
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('subInstInvoiceInfo') is not None:
            temp_model = ModifySubInstitutionRequestSubInstInvoiceInfo()
            self.sub_inst_invoice_info = temp_model.from_map(m['subInstInvoiceInfo'])
        if m.get('subInstShopInfo') is not None:
            temp_model = ModifySubInstitutionRequestSubInstShopInfo()
            self.sub_inst_shop_info = temp_model.from_map(m['subInstShopInfo'])
        return self


class ModifySubInstitutionResponseBody(TeaModel):
    def __init__(
        self,
        order_id: str = None,
    ):
        self.order_id = order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_id is not None:
            result['orderId'] = self.order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        return self


class ModifySubInstitutionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ModifySubInstitutionResponseBody = None,
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
            temp_model = ModifySubInstitutionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class NotifyPayCodePayResultHeaders(TeaModel):
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


class NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        ext_info: str = None,
        fund_tool_name: str = None,
        gmt_create: str = None,
        gmt_finish: str = None,
        promotion_fund_tool: bool = None,
    ):
        # This parameter is required.
        self.amount = amount
        self.ext_info = ext_info
        # This parameter is required.
        self.fund_tool_name = fund_tool_name
        # This parameter is required.
        self.gmt_create = gmt_create
        # This parameter is required.
        self.gmt_finish = gmt_finish
        # This parameter is required.
        self.promotion_fund_tool = promotion_fund_tool

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.fund_tool_name is not None:
            result['fundToolName'] = self.fund_tool_name
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.promotion_fund_tool is not None:
            result['promotionFundTool'] = self.promotion_fund_tool
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('fundToolName') is not None:
            self.fund_tool_name = m.get('fundToolName')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('promotionFundTool') is not None:
            self.promotion_fund_tool = m.get('promotionFundTool')
        return self


class NotifyPayCodePayResultRequestPayChannelDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        fund_tool_detail_list: List[NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList] = None,
        gmt_create: str = None,
        gmt_finish: str = None,
        pay_channel_name: str = None,
        pay_channel_order_no: str = None,
        pay_channel_type: str = None,
        promotion_amount: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.fund_tool_detail_list = fund_tool_detail_list
        self.gmt_create = gmt_create
        self.gmt_finish = gmt_finish
        # This parameter is required.
        self.pay_channel_name = pay_channel_name
        # This parameter is required.
        self.pay_channel_order_no = pay_channel_order_no
        # This parameter is required.
        self.pay_channel_type = pay_channel_type
        # This parameter is required.
        self.promotion_amount = promotion_amount

    def validate(self):
        if self.fund_tool_detail_list:
            for k in self.fund_tool_detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        result['fundToolDetailList'] = []
        if self.fund_tool_detail_list is not None:
            for k in self.fund_tool_detail_list:
                result['fundToolDetailList'].append(k.to_map() if k else None)
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.pay_channel_name is not None:
            result['payChannelName'] = self.pay_channel_name
        if self.pay_channel_order_no is not None:
            result['payChannelOrderNo'] = self.pay_channel_order_no
        if self.pay_channel_type is not None:
            result['payChannelType'] = self.pay_channel_type
        if self.promotion_amount is not None:
            result['promotionAmount'] = self.promotion_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        self.fund_tool_detail_list = []
        if m.get('fundToolDetailList') is not None:
            for k in m.get('fundToolDetailList'):
                temp_model = NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList()
                self.fund_tool_detail_list.append(temp_model.from_map(k))
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('payChannelName') is not None:
            self.pay_channel_name = m.get('payChannelName')
        if m.get('payChannelOrderNo') is not None:
            self.pay_channel_order_no = m.get('payChannelOrderNo')
        if m.get('payChannelType') is not None:
            self.pay_channel_type = m.get('payChannelType')
        if m.get('promotionAmount') is not None:
            self.promotion_amount = m.get('promotionAmount')
        return self


class NotifyPayCodePayResultRequest(TeaModel):
    def __init__(
        self,
        amount: str = None,
        charge_amount: str = None,
        corp_id: str = None,
        ext_info: str = None,
        gmt_trade_create: str = None,
        gmt_trade_finish: str = None,
        merchant_name: str = None,
        pay_channel_detail_list: List[NotifyPayCodePayResultRequestPayChannelDetailList] = None,
        pay_code: str = None,
        promotion_amount: str = None,
        remark: str = None,
        title: str = None,
        trade_error_code: str = None,
        trade_error_msg: str = None,
        trade_no: str = None,
        trade_status: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.charge_amount = charge_amount
        # This parameter is required.
        self.corp_id = corp_id
        self.ext_info = ext_info
        # This parameter is required.
        self.gmt_trade_create = gmt_trade_create
        # This parameter is required.
        self.gmt_trade_finish = gmt_trade_finish
        # This parameter is required.
        self.merchant_name = merchant_name
        # This parameter is required.
        self.pay_channel_detail_list = pay_channel_detail_list
        # This parameter is required.
        self.pay_code = pay_code
        # This parameter is required.
        self.promotion_amount = promotion_amount
        # This parameter is required.
        self.remark = remark
        # This parameter is required.
        self.title = title
        self.trade_error_code = trade_error_code
        self.trade_error_msg = trade_error_msg
        # This parameter is required.
        self.trade_no = trade_no
        # This parameter is required.
        self.trade_status = trade_status
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        if self.pay_channel_detail_list:
            for k in self.pay_channel_detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.charge_amount is not None:
            result['chargeAmount'] = self.charge_amount
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.gmt_trade_create is not None:
            result['gmtTradeCreate'] = self.gmt_trade_create
        if self.gmt_trade_finish is not None:
            result['gmtTradeFinish'] = self.gmt_trade_finish
        if self.merchant_name is not None:
            result['merchantName'] = self.merchant_name
        result['payChannelDetailList'] = []
        if self.pay_channel_detail_list is not None:
            for k in self.pay_channel_detail_list:
                result['payChannelDetailList'].append(k.to_map() if k else None)
        if self.pay_code is not None:
            result['payCode'] = self.pay_code
        if self.promotion_amount is not None:
            result['promotionAmount'] = self.promotion_amount
        if self.remark is not None:
            result['remark'] = self.remark
        if self.title is not None:
            result['title'] = self.title
        if self.trade_error_code is not None:
            result['tradeErrorCode'] = self.trade_error_code
        if self.trade_error_msg is not None:
            result['tradeErrorMsg'] = self.trade_error_msg
        if self.trade_no is not None:
            result['tradeNo'] = self.trade_no
        if self.trade_status is not None:
            result['tradeStatus'] = self.trade_status
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('chargeAmount') is not None:
            self.charge_amount = m.get('chargeAmount')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('gmtTradeCreate') is not None:
            self.gmt_trade_create = m.get('gmtTradeCreate')
        if m.get('gmtTradeFinish') is not None:
            self.gmt_trade_finish = m.get('gmtTradeFinish')
        if m.get('merchantName') is not None:
            self.merchant_name = m.get('merchantName')
        self.pay_channel_detail_list = []
        if m.get('payChannelDetailList') is not None:
            for k in m.get('payChannelDetailList'):
                temp_model = NotifyPayCodePayResultRequestPayChannelDetailList()
                self.pay_channel_detail_list.append(temp_model.from_map(k))
        if m.get('payCode') is not None:
            self.pay_code = m.get('payCode')
        if m.get('promotionAmount') is not None:
            self.promotion_amount = m.get('promotionAmount')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('tradeErrorCode') is not None:
            self.trade_error_code = m.get('tradeErrorCode')
        if m.get('tradeErrorMsg') is not None:
            self.trade_error_msg = m.get('tradeErrorMsg')
        if m.get('tradeNo') is not None:
            self.trade_no = m.get('tradeNo')
        if m.get('tradeStatus') is not None:
            self.trade_status = m.get('tradeStatus')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class NotifyPayCodePayResultResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
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


class NotifyPayCodePayResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: NotifyPayCodePayResultResponseBody = None,
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
            temp_model = NotifyPayCodePayResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class NotifyPayCodeRefundResultHeaders(TeaModel):
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


class NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        ext_info: str = None,
        fund_tool_name: str = None,
        gmt_create: str = None,
        gmt_finish: str = None,
        promotion_fund_tool: bool = None,
    ):
        # This parameter is required.
        self.amount = amount
        self.ext_info = ext_info
        # This parameter is required.
        self.fund_tool_name = fund_tool_name
        # This parameter is required.
        self.gmt_create = gmt_create
        # This parameter is required.
        self.gmt_finish = gmt_finish
        # This parameter is required.
        self.promotion_fund_tool = promotion_fund_tool

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.fund_tool_name is not None:
            result['fundToolName'] = self.fund_tool_name
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.promotion_fund_tool is not None:
            result['promotionFundTool'] = self.promotion_fund_tool
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('fundToolName') is not None:
            self.fund_tool_name = m.get('fundToolName')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('promotionFundTool') is not None:
            self.promotion_fund_tool = m.get('promotionFundTool')
        return self


class NotifyPayCodeRefundResultRequestPayChannelDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        fund_tool_detail_list: List[NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList] = None,
        pay_channel_name: str = None,
        pay_channel_order_no: str = None,
        pay_channel_refund_order_no: str = None,
        pay_channel_type: str = None,
        promotion_amount: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.fund_tool_detail_list = fund_tool_detail_list
        # This parameter is required.
        self.pay_channel_name = pay_channel_name
        # This parameter is required.
        self.pay_channel_order_no = pay_channel_order_no
        # This parameter is required.
        self.pay_channel_refund_order_no = pay_channel_refund_order_no
        # This parameter is required.
        self.pay_channel_type = pay_channel_type
        # This parameter is required.
        self.promotion_amount = promotion_amount

    def validate(self):
        if self.fund_tool_detail_list:
            for k in self.fund_tool_detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        result['fundToolDetailList'] = []
        if self.fund_tool_detail_list is not None:
            for k in self.fund_tool_detail_list:
                result['fundToolDetailList'].append(k.to_map() if k else None)
        if self.pay_channel_name is not None:
            result['payChannelName'] = self.pay_channel_name
        if self.pay_channel_order_no is not None:
            result['payChannelOrderNo'] = self.pay_channel_order_no
        if self.pay_channel_refund_order_no is not None:
            result['payChannelRefundOrderNo'] = self.pay_channel_refund_order_no
        if self.pay_channel_type is not None:
            result['payChannelType'] = self.pay_channel_type
        if self.promotion_amount is not None:
            result['promotionAmount'] = self.promotion_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        self.fund_tool_detail_list = []
        if m.get('fundToolDetailList') is not None:
            for k in m.get('fundToolDetailList'):
                temp_model = NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList()
                self.fund_tool_detail_list.append(temp_model.from_map(k))
        if m.get('payChannelName') is not None:
            self.pay_channel_name = m.get('payChannelName')
        if m.get('payChannelOrderNo') is not None:
            self.pay_channel_order_no = m.get('payChannelOrderNo')
        if m.get('payChannelRefundOrderNo') is not None:
            self.pay_channel_refund_order_no = m.get('payChannelRefundOrderNo')
        if m.get('payChannelType') is not None:
            self.pay_channel_type = m.get('payChannelType')
        if m.get('promotionAmount') is not None:
            self.promotion_amount = m.get('promotionAmount')
        return self


class NotifyPayCodeRefundResultRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        gmt_refund: str = None,
        pay_channel_detail_list: List[NotifyPayCodeRefundResultRequestPayChannelDetailList] = None,
        pay_code: str = None,
        refund_amount: str = None,
        refund_order_no: str = None,
        refund_promotion_amount: str = None,
        remark: str = None,
        trade_no: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.gmt_refund = gmt_refund
        # This parameter is required.
        self.pay_channel_detail_list = pay_channel_detail_list
        # This parameter is required.
        self.pay_code = pay_code
        # This parameter is required.
        self.refund_amount = refund_amount
        # This parameter is required.
        self.refund_order_no = refund_order_no
        # This parameter is required.
        self.refund_promotion_amount = refund_promotion_amount
        # This parameter is required.
        self.remark = remark
        # This parameter is required.
        self.trade_no = trade_no
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        if self.pay_channel_detail_list:
            for k in self.pay_channel_detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.gmt_refund is not None:
            result['gmtRefund'] = self.gmt_refund
        result['payChannelDetailList'] = []
        if self.pay_channel_detail_list is not None:
            for k in self.pay_channel_detail_list:
                result['payChannelDetailList'].append(k.to_map() if k else None)
        if self.pay_code is not None:
            result['payCode'] = self.pay_code
        if self.refund_amount is not None:
            result['refundAmount'] = self.refund_amount
        if self.refund_order_no is not None:
            result['refundOrderNo'] = self.refund_order_no
        if self.refund_promotion_amount is not None:
            result['refundPromotionAmount'] = self.refund_promotion_amount
        if self.remark is not None:
            result['remark'] = self.remark
        if self.trade_no is not None:
            result['tradeNo'] = self.trade_no
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('gmtRefund') is not None:
            self.gmt_refund = m.get('gmtRefund')
        self.pay_channel_detail_list = []
        if m.get('payChannelDetailList') is not None:
            for k in m.get('payChannelDetailList'):
                temp_model = NotifyPayCodeRefundResultRequestPayChannelDetailList()
                self.pay_channel_detail_list.append(temp_model.from_map(k))
        if m.get('payCode') is not None:
            self.pay_code = m.get('payCode')
        if m.get('refundAmount') is not None:
            self.refund_amount = m.get('refundAmount')
        if m.get('refundOrderNo') is not None:
            self.refund_order_no = m.get('refundOrderNo')
        if m.get('refundPromotionAmount') is not None:
            self.refund_promotion_amount = m.get('refundPromotionAmount')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('tradeNo') is not None:
            self.trade_no = m.get('tradeNo')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class NotifyPayCodeRefundResultResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
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


class NotifyPayCodeRefundResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: NotifyPayCodeRefundResultResponseBody = None,
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
            temp_model = NotifyPayCodeRefundResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class NotifyVerifyResultHeaders(TeaModel):
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


class NotifyVerifyResultRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        pay_code: str = None,
        remark: str = None,
        user_corp_relation_type: str = None,
        user_identity: str = None,
        verify_event: str = None,
        verify_location: str = None,
        verify_no: str = None,
        verify_result: bool = None,
        verify_time: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.pay_code = pay_code
        self.remark = remark
        # This parameter is required.
        self.user_corp_relation_type = user_corp_relation_type
        # This parameter is required.
        self.user_identity = user_identity
        self.verify_event = verify_event
        self.verify_location = verify_location
        self.verify_no = verify_no
        # This parameter is required.
        self.verify_result = verify_result
        # This parameter is required.
        self.verify_time = verify_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.pay_code is not None:
            result['payCode'] = self.pay_code
        if self.remark is not None:
            result['remark'] = self.remark
        if self.user_corp_relation_type is not None:
            result['userCorpRelationType'] = self.user_corp_relation_type
        if self.user_identity is not None:
            result['userIdentity'] = self.user_identity
        if self.verify_event is not None:
            result['verifyEvent'] = self.verify_event
        if self.verify_location is not None:
            result['verifyLocation'] = self.verify_location
        if self.verify_no is not None:
            result['verifyNo'] = self.verify_no
        if self.verify_result is not None:
            result['verifyResult'] = self.verify_result
        if self.verify_time is not None:
            result['verifyTime'] = self.verify_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('payCode') is not None:
            self.pay_code = m.get('payCode')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('userCorpRelationType') is not None:
            self.user_corp_relation_type = m.get('userCorpRelationType')
        if m.get('userIdentity') is not None:
            self.user_identity = m.get('userIdentity')
        if m.get('verifyEvent') is not None:
            self.verify_event = m.get('verifyEvent')
        if m.get('verifyLocation') is not None:
            self.verify_location = m.get('verifyLocation')
        if m.get('verifyNo') is not None:
            self.verify_no = m.get('verifyNo')
        if m.get('verifyResult') is not None:
            self.verify_result = m.get('verifyResult')
        if m.get('verifyTime') is not None:
            self.verify_time = m.get('verifyTime')
        return self


class NotifyVerifyResultResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
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


class NotifyVerifyResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: NotifyVerifyResultResponseBody = None,
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
            temp_model = NotifyVerifyResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PreCreateGroupBillOrderHeaders(TeaModel):
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


class PreCreateGroupBillOrderRequestBillItemList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        payer_union_id: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.payer_union_id = payer_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.payer_union_id is not None:
            result['payerUnionId'] = self.payer_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('payerUnionId') is not None:
            self.payer_union_id = m.get('payerUnionId')
        return self


class PreCreateGroupBillOrderRequest(TeaModel):
    def __init__(
        self,
        bill_item_list: List[PreCreateGroupBillOrderRequestBillItemList] = None,
        ext_params: Dict[str, str] = None,
        head_count: int = None,
        is_average_amount: int = None,
        merchant_id: str = None,
        open_cid: str = None,
        out_biz_no: str = None,
        payee_corp_id: str = None,
        payee_union_id: str = None,
        remark: str = None,
        total_amount: str = None,
    ):
        # This parameter is required.
        self.bill_item_list = bill_item_list
        self.ext_params = ext_params
        # This parameter is required.
        self.head_count = head_count
        # This parameter is required.
        self.is_average_amount = is_average_amount
        # This parameter is required.
        self.merchant_id = merchant_id
        self.open_cid = open_cid
        # This parameter is required.
        self.out_biz_no = out_biz_no
        self.payee_corp_id = payee_corp_id
        # This parameter is required.
        self.payee_union_id = payee_union_id
        self.remark = remark
        # This parameter is required.
        self.total_amount = total_amount

    def validate(self):
        if self.bill_item_list:
            for k in self.bill_item_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['billItemList'] = []
        if self.bill_item_list is not None:
            for k in self.bill_item_list:
                result['billItemList'].append(k.to_map() if k else None)
        if self.ext_params is not None:
            result['extParams'] = self.ext_params
        if self.head_count is not None:
            result['headCount'] = self.head_count
        if self.is_average_amount is not None:
            result['isAverageAmount'] = self.is_average_amount
        if self.merchant_id is not None:
            result['merchantId'] = self.merchant_id
        if self.open_cid is not None:
            result['openCid'] = self.open_cid
        if self.out_biz_no is not None:
            result['outBizNo'] = self.out_biz_no
        if self.payee_corp_id is not None:
            result['payeeCorpId'] = self.payee_corp_id
        if self.payee_union_id is not None:
            result['payeeUnionId'] = self.payee_union_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.total_amount is not None:
            result['totalAmount'] = self.total_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.bill_item_list = []
        if m.get('billItemList') is not None:
            for k in m.get('billItemList'):
                temp_model = PreCreateGroupBillOrderRequestBillItemList()
                self.bill_item_list.append(temp_model.from_map(k))
        if m.get('extParams') is not None:
            self.ext_params = m.get('extParams')
        if m.get('headCount') is not None:
            self.head_count = m.get('headCount')
        if m.get('isAverageAmount') is not None:
            self.is_average_amount = m.get('isAverageAmount')
        if m.get('merchantId') is not None:
            self.merchant_id = m.get('merchantId')
        if m.get('openCid') is not None:
            self.open_cid = m.get('openCid')
        if m.get('outBizNo') is not None:
            self.out_biz_no = m.get('outBizNo')
        if m.get('payeeCorpId') is not None:
            self.payee_corp_id = m.get('payeeCorpId')
        if m.get('payeeUnionId') is not None:
            self.payee_union_id = m.get('payeeUnionId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('totalAmount') is not None:
            self.total_amount = m.get('totalAmount')
        return self


class PreCreateGroupBillOrderResponseBodyResult(TeaModel):
    def __init__(
        self,
        order_no: str = None,
    ):
        self.order_no = order_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        return self


class PreCreateGroupBillOrderResponseBody(TeaModel):
    def __init__(
        self,
        result: PreCreateGroupBillOrderResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = PreCreateGroupBillOrderResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PreCreateGroupBillOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PreCreateGroupBillOrderResponseBody = None,
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
            temp_model = PreCreateGroupBillOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAcquireRefundOrderHeaders(TeaModel):
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


class QueryAcquireRefundOrderRequest(TeaModel):
    def __init__(
        self,
        out_refund_no: str = None,
    ):
        # This parameter is required.
        self.out_refund_no = out_refund_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_refund_no is not None:
            result['outRefundNo'] = self.out_refund_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outRefundNo') is not None:
            self.out_refund_no = m.get('outRefundNo')
        return self


class QueryAcquireRefundOrderResponseBody(TeaModel):
    def __init__(
        self,
        amount: str = None,
        gmt_create: str = None,
        gmt_refund: str = None,
        inst_id: str = None,
        order_no: str = None,
        origin_out_trade_no: str = None,
        out_refund_no: str = None,
        pay_channel: str = None,
        pay_channel_account_no: str = None,
        payer_user_id: str = None,
        remark: str = None,
        status: str = None,
        sub_inst_id: str = None,
        title: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.gmt_create = gmt_create
        self.gmt_refund = gmt_refund
        # This parameter is required.
        self.inst_id = inst_id
        # This parameter is required.
        self.order_no = order_no
        # This parameter is required.
        self.origin_out_trade_no = origin_out_trade_no
        # This parameter is required.
        self.out_refund_no = out_refund_no
        # This parameter is required.
        self.pay_channel = pay_channel
        # This parameter is required.
        self.pay_channel_account_no = pay_channel_account_no
        # This parameter is required.
        self.payer_user_id = payer_user_id
        self.remark = remark
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.sub_inst_id = sub_inst_id
        # This parameter is required.
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
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_refund is not None:
            result['gmtRefund'] = self.gmt_refund
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.origin_out_trade_no is not None:
            result['originOutTradeNo'] = self.origin_out_trade_no
        if self.out_refund_no is not None:
            result['outRefundNo'] = self.out_refund_no
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.pay_channel_account_no is not None:
            result['payChannelAccountNo'] = self.pay_channel_account_no
        if self.payer_user_id is not None:
            result['payerUserId'] = self.payer_user_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.status is not None:
            result['status'] = self.status
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtRefund') is not None:
            self.gmt_refund = m.get('gmtRefund')
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('originOutTradeNo') is not None:
            self.origin_out_trade_no = m.get('originOutTradeNo')
        if m.get('outRefundNo') is not None:
            self.out_refund_no = m.get('outRefundNo')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('payChannelAccountNo') is not None:
            self.pay_channel_account_no = m.get('payChannelAccountNo')
        if m.get('payerUserId') is not None:
            self.payer_user_id = m.get('payerUserId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryAcquireRefundOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryAcquireRefundOrderResponseBody = None,
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
            temp_model = QueryAcquireRefundOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryBatchTradeDetailListHeaders(TeaModel):
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


class QueryBatchTradeDetailListRequest(TeaModel):
    def __init__(
        self,
        out_batch_no: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # This parameter is required.
        self.out_batch_no = out_batch_no
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
        if self.out_batch_no is not None:
            result['outBatchNo'] = self.out_batch_no
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outBatchNo') is not None:
            self.out_batch_no = m.get('outBatchNo')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryBatchTradeDetailListResponseBodyBatchTradeDetailList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        detail_no: str = None,
        gmt_create: str = None,
        gmt_finish: str = None,
        memo: str = None,
        payee_account_name: str = None,
        payee_account_no: str = None,
        payee_account_type: str = None,
        serial_no: int = None,
        status: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.detail_no = detail_no
        # This parameter is required.
        self.gmt_create = gmt_create
        # This parameter is required.
        self.gmt_finish = gmt_finish
        # This parameter is required.
        self.memo = memo
        # This parameter is required.
        self.payee_account_name = payee_account_name
        # This parameter is required.
        self.payee_account_no = payee_account_no
        # This parameter is required.
        self.payee_account_type = payee_account_type
        # This parameter is required.
        self.serial_no = serial_no
        # This parameter is required.
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.detail_no is not None:
            result['detailNo'] = self.detail_no
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.memo is not None:
            result['memo'] = self.memo
        if self.payee_account_name is not None:
            result['payeeAccountName'] = self.payee_account_name
        if self.payee_account_no is not None:
            result['payeeAccountNo'] = self.payee_account_no
        if self.payee_account_type is not None:
            result['payeeAccountType'] = self.payee_account_type
        if self.serial_no is not None:
            result['serialNo'] = self.serial_no
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('detailNo') is not None:
            self.detail_no = m.get('detailNo')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('payeeAccountName') is not None:
            self.payee_account_name = m.get('payeeAccountName')
        if m.get('payeeAccountNo') is not None:
            self.payee_account_no = m.get('payeeAccountNo')
        if m.get('payeeAccountType') is not None:
            self.payee_account_type = m.get('payeeAccountType')
        if m.get('serialNo') is not None:
            self.serial_no = m.get('serialNo')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryBatchTradeDetailListResponseBody(TeaModel):
    def __init__(
        self,
        batch_trade_detail_list: List[QueryBatchTradeDetailListResponseBodyBatchTradeDetailList] = None,
        page_number: int = None,
        page_size: int = None,
        total: int = None,
        total_page_number: int = None,
    ):
        # This parameter is required.
        self.batch_trade_detail_list = batch_trade_detail_list
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        self.total = total
        # This parameter is required.
        self.total_page_number = total_page_number

    def validate(self):
        if self.batch_trade_detail_list:
            for k in self.batch_trade_detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['batchTradeDetailList'] = []
        if self.batch_trade_detail_list is not None:
            for k in self.batch_trade_detail_list:
                result['batchTradeDetailList'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total is not None:
            result['total'] = self.total
        if self.total_page_number is not None:
            result['totalPageNumber'] = self.total_page_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.batch_trade_detail_list = []
        if m.get('batchTradeDetailList') is not None:
            for k in m.get('batchTradeDetailList'):
                temp_model = QueryBatchTradeDetailListResponseBodyBatchTradeDetailList()
                self.batch_trade_detail_list.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('total') is not None:
            self.total = m.get('total')
        if m.get('totalPageNumber') is not None:
            self.total_page_number = m.get('totalPageNumber')
        return self


class QueryBatchTradeDetailListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryBatchTradeDetailListResponseBody = None,
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
            temp_model = QueryBatchTradeDetailListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryBatchTradeOrderHeaders(TeaModel):
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


class QueryBatchTradeOrderRequest(TeaModel):
    def __init__(
        self,
        out_batch_nos: List[str] = None,
    ):
        # This parameter is required.
        self.out_batch_nos = out_batch_nos

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_batch_nos is not None:
            result['outBatchNos'] = self.out_batch_nos
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outBatchNos') is not None:
            self.out_batch_nos = m.get('outBatchNos')
        return self


class QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs(TeaModel):
    def __init__(
        self,
        alipay_trans_id: str = None,
        fail_amount: str = None,
        fail_count: int = None,
        fail_reason: str = None,
        gmt_finish: str = None,
        gmt_submit: str = None,
        out_batch_no: str = None,
        payer_staff_id: str = None,
        payment_amount: str = None,
        payment_currency: str = None,
        status: str = None,
        success_amount: str = None,
        success_count: int = None,
        total_amount: str = None,
    ):
        # This parameter is required.
        self.alipay_trans_id = alipay_trans_id
        # This parameter is required.
        self.fail_amount = fail_amount
        # This parameter is required.
        self.fail_count = fail_count
        # This parameter is required.
        self.fail_reason = fail_reason
        # This parameter is required.
        self.gmt_finish = gmt_finish
        # This parameter is required.
        self.gmt_submit = gmt_submit
        # This parameter is required.
        self.out_batch_no = out_batch_no
        # This parameter is required.
        self.payer_staff_id = payer_staff_id
        # This parameter is required.
        self.payment_amount = payment_amount
        # This parameter is required.
        self.payment_currency = payment_currency
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.success_amount = success_amount
        # This parameter is required.
        self.success_count = success_count
        # This parameter is required.
        self.total_amount = total_amount

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_trans_id is not None:
            result['alipayTransId'] = self.alipay_trans_id
        if self.fail_amount is not None:
            result['failAmount'] = self.fail_amount
        if self.fail_count is not None:
            result['failCount'] = self.fail_count
        if self.fail_reason is not None:
            result['failReason'] = self.fail_reason
        if self.gmt_finish is not None:
            result['gmtFinish'] = self.gmt_finish
        if self.gmt_submit is not None:
            result['gmtSubmit'] = self.gmt_submit
        if self.out_batch_no is not None:
            result['outBatchNo'] = self.out_batch_no
        if self.payer_staff_id is not None:
            result['payerStaffId'] = self.payer_staff_id
        if self.payment_amount is not None:
            result['paymentAmount'] = self.payment_amount
        if self.payment_currency is not None:
            result['paymentCurrency'] = self.payment_currency
        if self.status is not None:
            result['status'] = self.status
        if self.success_amount is not None:
            result['successAmount'] = self.success_amount
        if self.success_count is not None:
            result['successCount'] = self.success_count
        if self.total_amount is not None:
            result['totalAmount'] = self.total_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayTransId') is not None:
            self.alipay_trans_id = m.get('alipayTransId')
        if m.get('failAmount') is not None:
            self.fail_amount = m.get('failAmount')
        if m.get('failCount') is not None:
            self.fail_count = m.get('failCount')
        if m.get('failReason') is not None:
            self.fail_reason = m.get('failReason')
        if m.get('gmtFinish') is not None:
            self.gmt_finish = m.get('gmtFinish')
        if m.get('gmtSubmit') is not None:
            self.gmt_submit = m.get('gmtSubmit')
        if m.get('outBatchNo') is not None:
            self.out_batch_no = m.get('outBatchNo')
        if m.get('payerStaffId') is not None:
            self.payer_staff_id = m.get('payerStaffId')
        if m.get('paymentAmount') is not None:
            self.payment_amount = m.get('paymentAmount')
        if m.get('paymentCurrency') is not None:
            self.payment_currency = m.get('paymentCurrency')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('successAmount') is not None:
            self.success_amount = m.get('successAmount')
        if m.get('successCount') is not None:
            self.success_count = m.get('successCount')
        if m.get('totalAmount') is not None:
            self.total_amount = m.get('totalAmount')
        return self


class QueryBatchTradeOrderResponseBody(TeaModel):
    def __init__(
        self,
        batch_trade_order_vos: List[QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs] = None,
    ):
        # This parameter is required.
        self.batch_trade_order_vos = batch_trade_order_vos

    def validate(self):
        if self.batch_trade_order_vos:
            for k in self.batch_trade_order_vos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['batchTradeOrderVOs'] = []
        if self.batch_trade_order_vos is not None:
            for k in self.batch_trade_order_vos:
                result['batchTradeOrderVOs'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.batch_trade_order_vos = []
        if m.get('batchTradeOrderVOs') is not None:
            for k in m.get('batchTradeOrderVOs'):
                temp_model = QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs()
                self.batch_trade_order_vos.append(temp_model.from_map(k))
        return self


class QueryBatchTradeOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryBatchTradeOrderResponseBody = None,
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
            temp_model = QueryBatchTradeOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPayAccountListHeaders(TeaModel):
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


class QueryPayAccountListResponseBodyPayAccountVOList(TeaModel):
    def __init__(
        self,
        account_class: str = None,
        account_id: str = None,
        account_name: str = None,
        account_no: str = None,
        account_remark: str = None,
        account_type: str = None,
    ):
        # This parameter is required.
        self.account_class = account_class
        # This parameter is required.
        self.account_id = account_id
        # This parameter is required.
        self.account_name = account_name
        # This parameter is required.
        self.account_no = account_no
        # This parameter is required.
        self.account_remark = account_remark
        # This parameter is required.
        self.account_type = account_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_class is not None:
            result['accountClass'] = self.account_class
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.account_no is not None:
            result['accountNo'] = self.account_no
        if self.account_remark is not None:
            result['accountRemark'] = self.account_remark
        if self.account_type is not None:
            result['accountType'] = self.account_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountClass') is not None:
            self.account_class = m.get('accountClass')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('accountNo') is not None:
            self.account_no = m.get('accountNo')
        if m.get('accountRemark') is not None:
            self.account_remark = m.get('accountRemark')
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        return self


class QueryPayAccountListResponseBody(TeaModel):
    def __init__(
        self,
        pay_account_volist: List[QueryPayAccountListResponseBodyPayAccountVOList] = None,
    ):
        # This parameter is required.
        self.pay_account_volist = pay_account_volist

    def validate(self):
        if self.pay_account_volist:
            for k in self.pay_account_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['payAccountVOList'] = []
        if self.pay_account_volist is not None:
            for k in self.pay_account_volist:
                result['payAccountVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.pay_account_volist = []
        if m.get('payAccountVOList') is not None:
            for k in m.get('payAccountVOList'):
                temp_model = QueryPayAccountListResponseBodyPayAccountVOList()
                self.pay_account_volist.append(temp_model.from_map(k))
        return self


class QueryPayAccountListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryPayAccountListResponseBody = None,
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
            temp_model = QueryPayAccountListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryRegisterOrderHeaders(TeaModel):
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


class QueryRegisterOrderRequest(TeaModel):
    def __init__(
        self,
        inst_id: str = None,
        order_id: str = None,
        out_trade_no: str = None,
        sub_inst_id: str = None,
    ):
        # This parameter is required.
        self.inst_id = inst_id
        self.order_id = order_id
        self.out_trade_no = out_trade_no
        # This parameter is required.
        self.sub_inst_id = sub_inst_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        return self


class QueryRegisterOrderResponseBody(TeaModel):
    def __init__(
        self,
        fail_reason: str = None,
        gmt_audit: str = None,
        inst_id: str = None,
        order_id: str = None,
        out_trade_no: str = None,
        status: str = None,
        sub_inst_id: str = None,
        sub_inst_name: str = None,
    ):
        self.fail_reason = fail_reason
        self.gmt_audit = gmt_audit
        self.inst_id = inst_id
        self.order_id = order_id
        self.out_trade_no = out_trade_no
        self.status = status
        self.sub_inst_id = sub_inst_id
        self.sub_inst_name = sub_inst_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fail_reason is not None:
            result['failReason'] = self.fail_reason
        if self.gmt_audit is not None:
            result['gmtAudit'] = self.gmt_audit
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.status is not None:
            result['status'] = self.status
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.sub_inst_name is not None:
            result['subInstName'] = self.sub_inst_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failReason') is not None:
            self.fail_reason = m.get('failReason')
        if m.get('gmtAudit') is not None:
            self.gmt_audit = m.get('gmtAudit')
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('subInstName') is not None:
            self.sub_inst_name = m.get('subInstName')
        return self


class QueryRegisterOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryRegisterOrderResponseBody = None,
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
            temp_model = QueryRegisterOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserAgreementHeaders(TeaModel):
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


class QueryUserAgreementRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        biz_scene: str = None,
        inst_id: str = None,
        sub_inst_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.biz_code = biz_code
        # This parameter is required.
        self.biz_scene = biz_scene
        # This parameter is required.
        self.inst_id = inst_id
        # This parameter is required.
        self.sub_inst_id = sub_inst_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.biz_scene is not None:
            result['bizScene'] = self.biz_scene
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('bizScene') is not None:
            self.biz_scene = m.get('bizScene')
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryUserAgreementResponseBody(TeaModel):
    def __init__(
        self,
        agreement_no: str = None,
        corp_id: str = None,
        gmt_expire: str = None,
        gmt_sign: str = None,
        gmt_valid: str = None,
        inst_id: str = None,
        pay_channel: str = None,
        pay_channel_account_name: str = None,
        pay_channel_account_no: str = None,
        status: str = None,
        sub_inst_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.agreement_no = agreement_no
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.gmt_expire = gmt_expire
        # This parameter is required.
        self.gmt_sign = gmt_sign
        # This parameter is required.
        self.gmt_valid = gmt_valid
        # This parameter is required.
        self.inst_id = inst_id
        # This parameter is required.
        self.pay_channel = pay_channel
        # This parameter is required.
        self.pay_channel_account_name = pay_channel_account_name
        # This parameter is required.
        self.pay_channel_account_no = pay_channel_account_no
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.sub_inst_id = sub_inst_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agreement_no is not None:
            result['agreementNo'] = self.agreement_no
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.gmt_expire is not None:
            result['gmtExpire'] = self.gmt_expire
        if self.gmt_sign is not None:
            result['gmtSign'] = self.gmt_sign
        if self.gmt_valid is not None:
            result['gmtValid'] = self.gmt_valid
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.pay_channel_account_name is not None:
            result['payChannelAccountName'] = self.pay_channel_account_name
        if self.pay_channel_account_no is not None:
            result['payChannelAccountNo'] = self.pay_channel_account_no
        if self.status is not None:
            result['status'] = self.status
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agreementNo') is not None:
            self.agreement_no = m.get('agreementNo')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('gmtExpire') is not None:
            self.gmt_expire = m.get('gmtExpire')
        if m.get('gmtSign') is not None:
            self.gmt_sign = m.get('gmtSign')
        if m.get('gmtValid') is not None:
            self.gmt_valid = m.get('gmtValid')
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('payChannelAccountName') is not None:
            self.pay_channel_account_name = m.get('payChannelAccountName')
        if m.get('payChannelAccountNo') is not None:
            self.pay_channel_account_no = m.get('payChannelAccountNo')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryUserAgreementResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUserAgreementResponseBody = None,
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
            temp_model = QueryUserAgreementResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserAlipayAccountHeaders(TeaModel):
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


class QueryUserAlipayAccountResponseBody(TeaModel):
    def __init__(
        self,
        alipay_uid: str = None,
    ):
        # This parameter is required.
        self.alipay_uid = alipay_uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_uid is not None:
            result['alipayUid'] = self.alipay_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayUid') is not None:
            self.alipay_uid = m.get('alipayUid')
        return self


class QueryUserAlipayAccountResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUserAlipayAccountResponseBody = None,
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
            temp_model = QueryUserAlipayAccountResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryWithholdingOrderHeaders(TeaModel):
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


class QueryWithholdingOrderRequest(TeaModel):
    def __init__(
        self,
        out_trade_no: str = None,
    ):
        # This parameter is required.
        self.out_trade_no = out_trade_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        return self


class QueryWithholdingOrderResponseBody(TeaModel):
    def __init__(
        self,
        amount: str = None,
        gmt_create: str = None,
        gmt_pay: str = None,
        inst_id: str = None,
        order_no: str = None,
        out_trade_no: str = None,
        pay_channel: str = None,
        pay_channel_account_no: str = None,
        payer_user_id: str = None,
        remark: str = None,
        status: str = None,
        sub_inst_id: str = None,
        title: str = None,
    ):
        # This parameter is required.
        self.amount = amount
        # This parameter is required.
        self.gmt_create = gmt_create
        self.gmt_pay = gmt_pay
        # This parameter is required.
        self.inst_id = inst_id
        # This parameter is required.
        self.order_no = order_no
        # This parameter is required.
        self.out_trade_no = out_trade_no
        # This parameter is required.
        self.pay_channel = pay_channel
        # This parameter is required.
        self.pay_channel_account_no = pay_channel_account_no
        # This parameter is required.
        self.payer_user_id = payer_user_id
        self.remark = remark
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.sub_inst_id = sub_inst_id
        # This parameter is required.
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
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_pay is not None:
            result['gmtPay'] = self.gmt_pay
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.out_trade_no is not None:
            result['outTradeNo'] = self.out_trade_no
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.pay_channel_account_no is not None:
            result['payChannelAccountNo'] = self.pay_channel_account_no
        if self.payer_user_id is not None:
            result['payerUserId'] = self.payer_user_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.status is not None:
            result['status'] = self.status
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtPay') is not None:
            self.gmt_pay = m.get('gmtPay')
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('outTradeNo') is not None:
            self.out_trade_no = m.get('outTradeNo')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('payChannelAccountNo') is not None:
            self.pay_channel_account_no = m.get('payChannelAccountNo')
        if m.get('payerUserId') is not None:
            self.payer_user_id = m.get('payerUserId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryWithholdingOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryWithholdingOrderResponseBody = None,
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
            temp_model = QueryWithholdingOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveCorpPayCodeHeaders(TeaModel):
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


class SaveCorpPayCodeRequest(TeaModel):
    def __init__(
        self,
        code_identity: str = None,
        corp_id: str = None,
        ext_info: Dict[str, str] = None,
        status: str = None,
    ):
        # This parameter is required.
        self.code_identity = code_identity
        # This parameter is required.
        self.corp_id = corp_id
        self.ext_info = ext_info
        # This parameter is required.
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code_identity is not None:
            result['codeIdentity'] = self.code_identity
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class SaveCorpPayCodeResponseBody(TeaModel):
    def __init__(
        self,
        code_identity: str = None,
        corp_id: str = None,
        ext_info: Dict[str, str] = None,
        status: str = None,
    ):
        self.code_identity = code_identity
        self.corp_id = corp_id
        self.ext_info = ext_info
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code_identity is not None:
            result['codeIdentity'] = self.code_identity
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class SaveCorpPayCodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SaveCorpPayCodeResponseBody = None,
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
            temp_model = SaveCorpPayCodeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UnsignUserAgreementHeaders(TeaModel):
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


class UnsignUserAgreementRequest(TeaModel):
    def __init__(
        self,
        agreement_no: str = None,
        biz_code: str = None,
        biz_scene: str = None,
        inst_id: str = None,
        sub_inst_id: str = None,
        user_id: str = None,
    ):
        self.agreement_no = agreement_no
        self.biz_code = biz_code
        self.biz_scene = biz_scene
        # This parameter is required.
        self.inst_id = inst_id
        # This parameter is required.
        self.sub_inst_id = sub_inst_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agreement_no is not None:
            result['agreementNo'] = self.agreement_no
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.biz_scene is not None:
            result['bizScene'] = self.biz_scene
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agreementNo') is not None:
            self.agreement_no = m.get('agreementNo')
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('bizScene') is not None:
            self.biz_scene = m.get('bizScene')
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UnsignUserAgreementResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class UpateUserCodeInstanceHeaders(TeaModel):
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


class UpateUserCodeInstanceRequestAvailableTimes(TeaModel):
    def __init__(
        self,
        gmt_end: str = None,
        gmt_start: str = None,
    ):
        # This parameter is required.
        self.gmt_end = gmt_end
        # This parameter is required.
        self.gmt_start = gmt_start

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_end is not None:
            result['gmtEnd'] = self.gmt_end
        if self.gmt_start is not None:
            result['gmtStart'] = self.gmt_start
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtEnd') is not None:
            self.gmt_end = m.get('gmtEnd')
        if m.get('gmtStart') is not None:
            self.gmt_start = m.get('gmtStart')
        return self


class UpateUserCodeInstanceRequest(TeaModel):
    def __init__(
        self,
        available_times: List[UpateUserCodeInstanceRequestAvailableTimes] = None,
        code_id: str = None,
        code_identity: str = None,
        code_value: str = None,
        corp_id: str = None,
        ext_info: Dict[str, Any] = None,
        gmt_expired: str = None,
        status: str = None,
        user_corp_relation_type: str = None,
        user_identity: str = None,
    ):
        # This parameter is required.
        self.available_times = available_times
        # This parameter is required.
        self.code_id = code_id
        # This parameter is required.
        self.code_identity = code_identity
        self.code_value = code_value
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.ext_info = ext_info
        # This parameter is required.
        self.gmt_expired = gmt_expired
        self.status = status
        # This parameter is required.
        self.user_corp_relation_type = user_corp_relation_type
        # This parameter is required.
        self.user_identity = user_identity

    def validate(self):
        if self.available_times:
            for k in self.available_times:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['availableTimes'] = []
        if self.available_times is not None:
            for k in self.available_times:
                result['availableTimes'].append(k.to_map() if k else None)
        if self.code_id is not None:
            result['codeId'] = self.code_id
        if self.code_identity is not None:
            result['codeIdentity'] = self.code_identity
        if self.code_value is not None:
            result['codeValue'] = self.code_value
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.gmt_expired is not None:
            result['gmtExpired'] = self.gmt_expired
        if self.status is not None:
            result['status'] = self.status
        if self.user_corp_relation_type is not None:
            result['userCorpRelationType'] = self.user_corp_relation_type
        if self.user_identity is not None:
            result['userIdentity'] = self.user_identity
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.available_times = []
        if m.get('availableTimes') is not None:
            for k in m.get('availableTimes'):
                temp_model = UpateUserCodeInstanceRequestAvailableTimes()
                self.available_times.append(temp_model.from_map(k))
        if m.get('codeId') is not None:
            self.code_id = m.get('codeId')
        if m.get('codeIdentity') is not None:
            self.code_identity = m.get('codeIdentity')
        if m.get('codeValue') is not None:
            self.code_value = m.get('codeValue')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('gmtExpired') is not None:
            self.gmt_expired = m.get('gmtExpired')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userCorpRelationType') is not None:
            self.user_corp_relation_type = m.get('userCorpRelationType')
        if m.get('userIdentity') is not None:
            self.user_identity = m.get('userIdentity')
        return self


class UpateUserCodeInstanceResponseBody(TeaModel):
    def __init__(
        self,
        code_id: str = None,
    ):
        self.code_id = code_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code_id is not None:
            result['codeId'] = self.code_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('codeId') is not None:
            self.code_id = m.get('codeId')
        return self


class UpateUserCodeInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpateUserCodeInstanceResponseBody = None,
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
            temp_model = UpateUserCodeInstanceResponseBody()
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


class UpdateInvoiceVerifyStatusRequest(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        checking_result: int = None,
        checking_status: int = None,
        code: str = None,
        corp_id: str = None,
        extension: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        invoice_status: int = None,
        invoice_verify_id: str = None,
        msg: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.biz_id = biz_id
        self.checking_result = checking_result
        # This parameter is required.
        self.checking_status = checking_status
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.corp_id = corp_id
        self.extension = extension
        self.invoice_code = invoice_code
        # This parameter is required.
        self.invoice_no = invoice_no
        self.invoice_status = invoice_status
        # This parameter is required.
        self.invoice_verify_id = invoice_verify_id
        # This parameter is required.
        self.msg = msg
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.checking_result is not None:
            result['checkingResult'] = self.checking_result
        if self.checking_status is not None:
            result['checkingStatus'] = self.checking_status
        if self.code is not None:
            result['code'] = self.code
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.extension is not None:
            result['extension'] = self.extension
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_status is not None:
            result['invoiceStatus'] = self.invoice_status
        if self.invoice_verify_id is not None:
            result['invoiceVerifyId'] = self.invoice_verify_id
        if self.msg is not None:
            result['msg'] = self.msg
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('checkingResult') is not None:
            self.checking_result = m.get('checkingResult')
        if m.get('checkingStatus') is not None:
            self.checking_status = m.get('checkingStatus')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceStatus') is not None:
            self.invoice_status = m.get('invoiceStatus')
        if m.get('invoiceVerifyId') is not None:
            self.invoice_verify_id = m.get('invoiceVerifyId')
        if m.get('msg') is not None:
            self.msg = m.get('msg')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
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


class UploadInvoiceHeaders(TeaModel):
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


class UploadInvoiceRequestExtension(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        order_no: str = None,
        order_no_list: List[str] = None,
        order_type: str = None,
    ):
        # This parameter is required.
        self.biz_code = biz_code
        self.order_no = order_no
        self.order_no_list = order_no_list
        self.order_type = order_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.order_no_list is not None:
            result['orderNoList'] = self.order_no_list
        if self.order_type is not None:
            result['orderType'] = self.order_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('orderNoList') is not None:
            self.order_no_list = m.get('orderNoList')
        if m.get('orderType') is not None:
            self.order_type = m.get('orderType')
        return self


class UploadInvoiceRequestInvoices(TeaModel):
    def __init__(
        self,
        invoice_amount: str = None,
        invoice_code: str = None,
        invoice_date: str = None,
        invoice_no: str = None,
        invoice_type: str = None,
        logo_url: str = None,
        payee_name: str = None,
        payee_tax_no: str = None,
        payer_name: str = None,
        payer_tax_no: str = None,
        pdf_url: str = None,
        tax_amount: str = None,
        verify_code: str = None,
        without_tax_amount: str = None,
    ):
        # This parameter is required.
        self.invoice_amount = invoice_amount
        # This parameter is required.
        self.invoice_code = invoice_code
        # This parameter is required.
        self.invoice_date = invoice_date
        # This parameter is required.
        self.invoice_no = invoice_no
        # This parameter is required.
        self.invoice_type = invoice_type
        self.logo_url = logo_url
        # This parameter is required.
        self.payee_name = payee_name
        # This parameter is required.
        self.payee_tax_no = payee_tax_no
        # This parameter is required.
        self.payer_name = payer_name
        self.payer_tax_no = payer_tax_no
        # This parameter is required.
        self.pdf_url = pdf_url
        self.tax_amount = tax_amount
        self.verify_code = verify_code
        self.without_tax_amount = without_tax_amount

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invoice_amount is not None:
            result['invoiceAmount'] = self.invoice_amount
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_date is not None:
            result['invoiceDate'] = self.invoice_date
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.logo_url is not None:
            result['logoUrl'] = self.logo_url
        if self.payee_name is not None:
            result['payeeName'] = self.payee_name
        if self.payee_tax_no is not None:
            result['payeeTaxNo'] = self.payee_tax_no
        if self.payer_name is not None:
            result['payerName'] = self.payer_name
        if self.payer_tax_no is not None:
            result['payerTaxNo'] = self.payer_tax_no
        if self.pdf_url is not None:
            result['pdfUrl'] = self.pdf_url
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.verify_code is not None:
            result['verifyCode'] = self.verify_code
        if self.without_tax_amount is not None:
            result['withoutTaxAmount'] = self.without_tax_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('invoiceAmount') is not None:
            self.invoice_amount = m.get('invoiceAmount')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceDate') is not None:
            self.invoice_date = m.get('invoiceDate')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('logoUrl') is not None:
            self.logo_url = m.get('logoUrl')
        if m.get('payeeName') is not None:
            self.payee_name = m.get('payeeName')
        if m.get('payeeTaxNo') is not None:
            self.payee_tax_no = m.get('payeeTaxNo')
        if m.get('payerName') is not None:
            self.payer_name = m.get('payerName')
        if m.get('payerTaxNo') is not None:
            self.payer_tax_no = m.get('payerTaxNo')
        if m.get('pdfUrl') is not None:
            self.pdf_url = m.get('pdfUrl')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('verifyCode') is not None:
            self.verify_code = m.get('verifyCode')
        if m.get('withoutTaxAmount') is not None:
            self.without_tax_amount = m.get('withoutTaxAmount')
        return self


class UploadInvoiceRequestUserIdentity(TeaModel):
    def __init__(
        self,
        mobile: str = None,
        mobile_state_code: str = None,
        target_corp_id: str = None,
        type: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.mobile = mobile
        self.mobile_state_code = mobile_state_code
        self.target_corp_id = target_corp_id
        # This parameter is required.
        self.type = type
        self.union_id = union_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.mobile_state_code is not None:
            result['mobileStateCode'] = self.mobile_state_code
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.type is not None:
            result['type'] = self.type
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('mobileStateCode') is not None:
            self.mobile_state_code = m.get('mobileStateCode')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UploadInvoiceRequest(TeaModel):
    def __init__(
        self,
        extension: UploadInvoiceRequestExtension = None,
        invoices: List[UploadInvoiceRequestInvoices] = None,
        user_identity: UploadInvoiceRequestUserIdentity = None,
    ):
        self.extension = extension
        # This parameter is required.
        self.invoices = invoices
        self.user_identity = user_identity

    def validate(self):
        if self.extension:
            self.extension.validate()
        if self.invoices:
            for k in self.invoices:
                if k:
                    k.validate()
        if self.user_identity:
            self.user_identity.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extension is not None:
            result['extension'] = self.extension.to_map()
        result['invoices'] = []
        if self.invoices is not None:
            for k in self.invoices:
                result['invoices'].append(k.to_map() if k else None)
        if self.user_identity is not None:
            result['userIdentity'] = self.user_identity.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extension') is not None:
            temp_model = UploadInvoiceRequestExtension()
            self.extension = temp_model.from_map(m['extension'])
        self.invoices = []
        if m.get('invoices') is not None:
            for k in m.get('invoices'):
                temp_model = UploadInvoiceRequestInvoices()
                self.invoices.append(temp_model.from_map(k))
        if m.get('userIdentity') is not None:
            temp_model = UploadInvoiceRequestUserIdentity()
            self.user_identity = temp_model.from_map(m['userIdentity'])
        return self


class UploadInvoiceResponseBodyResultResults(TeaModel):
    def __init__(
        self,
        err_code: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        reason: str = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.err_code = err_code
        # This parameter is required.
        self.invoice_code = invoice_code
        # This parameter is required.
        self.invoice_no = invoice_no
        # This parameter is required.
        self.reason = reason
        # This parameter is required.
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.err_code is not None:
            result['errCode'] = self.err_code
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.reason is not None:
            result['reason'] = self.reason
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errCode') is not None:
            self.err_code = m.get('errCode')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('reason') is not None:
            self.reason = m.get('reason')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UploadInvoiceResponseBodyResult(TeaModel):
    def __init__(
        self,
        results: List[UploadInvoiceResponseBodyResultResults] = None,
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
                temp_model = UploadInvoiceResponseBodyResultResults()
                self.results.append(temp_model.from_map(k))
        return self


class UploadInvoiceResponseBody(TeaModel):
    def __init__(
        self,
        result: UploadInvoiceResponseBodyResult = None,
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
            temp_model = UploadInvoiceResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UploadInvoiceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UploadInvoiceResponseBody = None,
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
            temp_model = UploadInvoiceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UploadInvoiceByAuthHeaders(TeaModel):
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


class UploadInvoiceByAuthRequestExtension(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        order_no: str = None,
        order_type: str = None,
    ):
        # This parameter is required.
        self.biz_code = biz_code
        self.order_no = order_no
        self.order_type = order_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.order_type is not None:
            result['orderType'] = self.order_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('orderType') is not None:
            self.order_type = m.get('orderType')
        return self


class UploadInvoiceByAuthRequestInvoices(TeaModel):
    def __init__(
        self,
        invoice_amount: str = None,
        invoice_code: str = None,
        invoice_date: str = None,
        invoice_no: str = None,
        invoice_type: str = None,
        logo_url: str = None,
        payee_name: str = None,
        payee_tax_no: str = None,
        payer_name: str = None,
        payer_tax_no: str = None,
        pdf_url: str = None,
        tax_amount: str = None,
        verify_code: str = None,
        without_tax_amount: str = None,
    ):
        # This parameter is required.
        self.invoice_amount = invoice_amount
        # This parameter is required.
        self.invoice_code = invoice_code
        # This parameter is required.
        self.invoice_date = invoice_date
        # This parameter is required.
        self.invoice_no = invoice_no
        # This parameter is required.
        self.invoice_type = invoice_type
        self.logo_url = logo_url
        # This parameter is required.
        self.payee_name = payee_name
        # This parameter is required.
        self.payee_tax_no = payee_tax_no
        # This parameter is required.
        self.payer_name = payer_name
        self.payer_tax_no = payer_tax_no
        # This parameter is required.
        self.pdf_url = pdf_url
        # This parameter is required.
        self.tax_amount = tax_amount
        self.verify_code = verify_code
        # This parameter is required.
        self.without_tax_amount = without_tax_amount

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invoice_amount is not None:
            result['invoiceAmount'] = self.invoice_amount
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_date is not None:
            result['invoiceDate'] = self.invoice_date
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.logo_url is not None:
            result['logoUrl'] = self.logo_url
        if self.payee_name is not None:
            result['payeeName'] = self.payee_name
        if self.payee_tax_no is not None:
            result['payeeTaxNo'] = self.payee_tax_no
        if self.payer_name is not None:
            result['payerName'] = self.payer_name
        if self.payer_tax_no is not None:
            result['payerTaxNo'] = self.payer_tax_no
        if self.pdf_url is not None:
            result['pdfUrl'] = self.pdf_url
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.verify_code is not None:
            result['verifyCode'] = self.verify_code
        if self.without_tax_amount is not None:
            result['withoutTaxAmount'] = self.without_tax_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('invoiceAmount') is not None:
            self.invoice_amount = m.get('invoiceAmount')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceDate') is not None:
            self.invoice_date = m.get('invoiceDate')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('logoUrl') is not None:
            self.logo_url = m.get('logoUrl')
        if m.get('payeeName') is not None:
            self.payee_name = m.get('payeeName')
        if m.get('payeeTaxNo') is not None:
            self.payee_tax_no = m.get('payeeTaxNo')
        if m.get('payerName') is not None:
            self.payer_name = m.get('payerName')
        if m.get('payerTaxNo') is not None:
            self.payer_tax_no = m.get('payerTaxNo')
        if m.get('pdfUrl') is not None:
            self.pdf_url = m.get('pdfUrl')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('verifyCode') is not None:
            self.verify_code = m.get('verifyCode')
        if m.get('withoutTaxAmount') is not None:
            self.without_tax_amount = m.get('withoutTaxAmount')
        return self


class UploadInvoiceByAuthRequest(TeaModel):
    def __init__(
        self,
        extension: UploadInvoiceByAuthRequestExtension = None,
        invoices: List[UploadInvoiceByAuthRequestInvoices] = None,
    ):
        self.extension = extension
        # This parameter is required.
        self.invoices = invoices

    def validate(self):
        if self.extension:
            self.extension.validate()
        if self.invoices:
            for k in self.invoices:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extension is not None:
            result['extension'] = self.extension.to_map()
        result['invoices'] = []
        if self.invoices is not None:
            for k in self.invoices:
                result['invoices'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extension') is not None:
            temp_model = UploadInvoiceByAuthRequestExtension()
            self.extension = temp_model.from_map(m['extension'])
        self.invoices = []
        if m.get('invoices') is not None:
            for k in m.get('invoices'):
                temp_model = UploadInvoiceByAuthRequestInvoices()
                self.invoices.append(temp_model.from_map(k))
        return self


class UploadInvoiceByAuthResponseBodyResultResults(TeaModel):
    def __init__(
        self,
        err_code: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        reason: str = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.err_code = err_code
        # This parameter is required.
        self.invoice_code = invoice_code
        # This parameter is required.
        self.invoice_no = invoice_no
        # This parameter is required.
        self.reason = reason
        # This parameter is required.
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.err_code is not None:
            result['errCode'] = self.err_code
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.reason is not None:
            result['reason'] = self.reason
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errCode') is not None:
            self.err_code = m.get('errCode')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('reason') is not None:
            self.reason = m.get('reason')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UploadInvoiceByAuthResponseBodyResult(TeaModel):
    def __init__(
        self,
        results: List[UploadInvoiceByAuthResponseBodyResultResults] = None,
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
                temp_model = UploadInvoiceByAuthResponseBodyResultResults()
                self.results.append(temp_model.from_map(k))
        return self


class UploadInvoiceByAuthResponseBody(TeaModel):
    def __init__(
        self,
        result: UploadInvoiceByAuthResponseBodyResult = None,
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
            temp_model = UploadInvoiceByAuthResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UploadInvoiceByAuthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UploadInvoiceByAuthResponseBody = None,
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
            temp_model = UploadInvoiceByAuthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UploadInvoiceByMobileHeaders(TeaModel):
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


class UploadInvoiceByMobileRequestInvoices(TeaModel):
    def __init__(
        self,
        invoice_amount: str = None,
        invoice_code: str = None,
        invoice_date: str = None,
        invoice_no: str = None,
        invoice_type: str = None,
        logo_url: str = None,
        payee_name: str = None,
        payee_tax_no: str = None,
        payer_name: str = None,
        payer_tax_no: str = None,
        pdf_url: str = None,
        tax_amount: str = None,
        verify_code: str = None,
        without_tax_amount: str = None,
    ):
        # This parameter is required.
        self.invoice_amount = invoice_amount
        # This parameter is required.
        self.invoice_code = invoice_code
        # This parameter is required.
        self.invoice_date = invoice_date
        # This parameter is required.
        self.invoice_no = invoice_no
        # This parameter is required.
        self.invoice_type = invoice_type
        self.logo_url = logo_url
        # This parameter is required.
        self.payee_name = payee_name
        # This parameter is required.
        self.payee_tax_no = payee_tax_no
        # This parameter is required.
        self.payer_name = payer_name
        self.payer_tax_no = payer_tax_no
        # This parameter is required.
        self.pdf_url = pdf_url
        # This parameter is required.
        self.tax_amount = tax_amount
        self.verify_code = verify_code
        # This parameter is required.
        self.without_tax_amount = without_tax_amount

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invoice_amount is not None:
            result['invoiceAmount'] = self.invoice_amount
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_date is not None:
            result['invoiceDate'] = self.invoice_date
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.invoice_type is not None:
            result['invoiceType'] = self.invoice_type
        if self.logo_url is not None:
            result['logoUrl'] = self.logo_url
        if self.payee_name is not None:
            result['payeeName'] = self.payee_name
        if self.payee_tax_no is not None:
            result['payeeTaxNo'] = self.payee_tax_no
        if self.payer_name is not None:
            result['payerName'] = self.payer_name
        if self.payer_tax_no is not None:
            result['payerTaxNo'] = self.payer_tax_no
        if self.pdf_url is not None:
            result['pdfUrl'] = self.pdf_url
        if self.tax_amount is not None:
            result['taxAmount'] = self.tax_amount
        if self.verify_code is not None:
            result['verifyCode'] = self.verify_code
        if self.without_tax_amount is not None:
            result['withoutTaxAmount'] = self.without_tax_amount
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('invoiceAmount') is not None:
            self.invoice_amount = m.get('invoiceAmount')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceDate') is not None:
            self.invoice_date = m.get('invoiceDate')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('invoiceType') is not None:
            self.invoice_type = m.get('invoiceType')
        if m.get('logoUrl') is not None:
            self.logo_url = m.get('logoUrl')
        if m.get('payeeName') is not None:
            self.payee_name = m.get('payeeName')
        if m.get('payeeTaxNo') is not None:
            self.payee_tax_no = m.get('payeeTaxNo')
        if m.get('payerName') is not None:
            self.payer_name = m.get('payerName')
        if m.get('payerTaxNo') is not None:
            self.payer_tax_no = m.get('payerTaxNo')
        if m.get('pdfUrl') is not None:
            self.pdf_url = m.get('pdfUrl')
        if m.get('taxAmount') is not None:
            self.tax_amount = m.get('taxAmount')
        if m.get('verifyCode') is not None:
            self.verify_code = m.get('verifyCode')
        if m.get('withoutTaxAmount') is not None:
            self.without_tax_amount = m.get('withoutTaxAmount')
        return self


class UploadInvoiceByMobileRequest(TeaModel):
    def __init__(
        self,
        invoices: List[UploadInvoiceByMobileRequestInvoices] = None,
        mobile: str = None,
        mobile_state_code: str = None,
    ):
        # This parameter is required.
        self.invoices = invoices
        # This parameter is required.
        self.mobile = mobile
        # This parameter is required.
        self.mobile_state_code = mobile_state_code

    def validate(self):
        if self.invoices:
            for k in self.invoices:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['invoices'] = []
        if self.invoices is not None:
            for k in self.invoices:
                result['invoices'].append(k.to_map() if k else None)
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.mobile_state_code is not None:
            result['mobileStateCode'] = self.mobile_state_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.invoices = []
        if m.get('invoices') is not None:
            for k in m.get('invoices'):
                temp_model = UploadInvoiceByMobileRequestInvoices()
                self.invoices.append(temp_model.from_map(k))
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('mobileStateCode') is not None:
            self.mobile_state_code = m.get('mobileStateCode')
        return self


class UploadInvoiceByMobileResponseBodyResultResults(TeaModel):
    def __init__(
        self,
        err_code: str = None,
        invoice_code: str = None,
        invoice_no: str = None,
        reason: str = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.err_code = err_code
        # This parameter is required.
        self.invoice_code = invoice_code
        # This parameter is required.
        self.invoice_no = invoice_no
        # This parameter is required.
        self.reason = reason
        # This parameter is required.
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.err_code is not None:
            result['errCode'] = self.err_code
        if self.invoice_code is not None:
            result['invoiceCode'] = self.invoice_code
        if self.invoice_no is not None:
            result['invoiceNo'] = self.invoice_no
        if self.reason is not None:
            result['reason'] = self.reason
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errCode') is not None:
            self.err_code = m.get('errCode')
        if m.get('invoiceCode') is not None:
            self.invoice_code = m.get('invoiceCode')
        if m.get('invoiceNo') is not None:
            self.invoice_no = m.get('invoiceNo')
        if m.get('reason') is not None:
            self.reason = m.get('reason')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UploadInvoiceByMobileResponseBodyResult(TeaModel):
    def __init__(
        self,
        results: List[UploadInvoiceByMobileResponseBodyResultResults] = None,
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
                temp_model = UploadInvoiceByMobileResponseBodyResultResults()
                self.results.append(temp_model.from_map(k))
        return self


class UploadInvoiceByMobileResponseBody(TeaModel):
    def __init__(
        self,
        result: UploadInvoiceByMobileResponseBodyResult = None,
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
            temp_model = UploadInvoiceByMobileResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UploadInvoiceByMobileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UploadInvoiceByMobileResponseBody = None,
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
            temp_model = UploadInvoiceByMobileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UploadRegisterImageHeaders(TeaModel):
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


class UploadRegisterImageRequest(TeaModel):
    def __init__(
        self,
        image_content: str = None,
        image_name: str = None,
        image_type: str = None,
        inst_id: str = None,
        pay_channel: str = None,
    ):
        # This parameter is required.
        self.image_content = image_content
        # This parameter is required.
        self.image_name = image_name
        # This parameter is required.
        self.image_type = image_type
        # This parameter is required.
        self.inst_id = inst_id
        # This parameter is required.
        self.pay_channel = pay_channel

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.image_content is not None:
            result['imageContent'] = self.image_content
        if self.image_name is not None:
            result['imageName'] = self.image_name
        if self.image_type is not None:
            result['imageType'] = self.image_type
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('imageContent') is not None:
            self.image_content = m.get('imageContent')
        if m.get('imageName') is not None:
            self.image_name = m.get('imageName')
        if m.get('imageType') is not None:
            self.image_type = m.get('imageType')
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        return self


class UploadRegisterImageResponseBody(TeaModel):
    def __init__(
        self,
        oss_url: str = None,
    ):
        # This parameter is required.
        self.oss_url = oss_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.oss_url is not None:
            result['ossUrl'] = self.oss_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ossUrl') is not None:
            self.oss_url = m.get('ossUrl')
        return self


class UploadRegisterImageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UploadRegisterImageResponseBody = None,
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
            temp_model = UploadRegisterImageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UserAgreementPageSignHeaders(TeaModel):
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


class UserAgreementPageSignRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        biz_scene: str = None,
        inst_id: str = None,
        pay_channel: str = None,
        remark: str = None,
        return_url: str = None,
        sign_scene: str = None,
        sub_inst_id: str = None,
        sub_merchant_name: str = None,
        sub_merchant_service_desc: str = None,
        sub_merchant_service_name: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.biz_code = biz_code
        # This parameter is required.
        self.biz_scene = biz_scene
        # This parameter is required.
        self.inst_id = inst_id
        # This parameter is required.
        self.pay_channel = pay_channel
        self.remark = remark
        self.return_url = return_url
        # This parameter is required.
        self.sign_scene = sign_scene
        # This parameter is required.
        self.sub_inst_id = sub_inst_id
        # This parameter is required.
        self.sub_merchant_name = sub_merchant_name
        # This parameter is required.
        self.sub_merchant_service_desc = sub_merchant_service_desc
        # This parameter is required.
        self.sub_merchant_service_name = sub_merchant_service_name
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.biz_scene is not None:
            result['bizScene'] = self.biz_scene
        if self.inst_id is not None:
            result['instId'] = self.inst_id
        if self.pay_channel is not None:
            result['payChannel'] = self.pay_channel
        if self.remark is not None:
            result['remark'] = self.remark
        if self.return_url is not None:
            result['returnUrl'] = self.return_url
        if self.sign_scene is not None:
            result['signScene'] = self.sign_scene
        if self.sub_inst_id is not None:
            result['subInstId'] = self.sub_inst_id
        if self.sub_merchant_name is not None:
            result['subMerchantName'] = self.sub_merchant_name
        if self.sub_merchant_service_desc is not None:
            result['subMerchantServiceDesc'] = self.sub_merchant_service_desc
        if self.sub_merchant_service_name is not None:
            result['subMerchantServiceName'] = self.sub_merchant_service_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('bizScene') is not None:
            self.biz_scene = m.get('bizScene')
        if m.get('instId') is not None:
            self.inst_id = m.get('instId')
        if m.get('payChannel') is not None:
            self.pay_channel = m.get('payChannel')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('returnUrl') is not None:
            self.return_url = m.get('returnUrl')
        if m.get('signScene') is not None:
            self.sign_scene = m.get('signScene')
        if m.get('subInstId') is not None:
            self.sub_inst_id = m.get('subInstId')
        if m.get('subMerchantName') is not None:
            self.sub_merchant_name = m.get('subMerchantName')
        if m.get('subMerchantServiceDesc') is not None:
            self.sub_merchant_service_desc = m.get('subMerchantServiceDesc')
        if m.get('subMerchantServiceName') is not None:
            self.sub_merchant_service_name = m.get('subMerchantServiceName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UserAgreementPageSignResponseBody(TeaModel):
    def __init__(
        self,
        page_data: str = None,
    ):
        # This parameter is required.
        self.page_data = page_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_data is not None:
            result['pageData'] = self.page_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageData') is not None:
            self.page_data = m.get('pageData')
        return self


class UserAgreementPageSignResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UserAgreementPageSignResponseBody = None,
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
            temp_model = UserAgreementPageSignResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


