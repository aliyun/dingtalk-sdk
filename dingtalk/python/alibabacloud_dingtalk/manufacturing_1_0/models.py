# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class IndustrializeManufactureJobBookRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        extend: str = None,
        inst_no: str = None,
        is_batch_job: str = None,
        manufacture_date: str = None,
        mes_app_key: str = None,
        process_en_name: str = None,
        process_name: str = None,
        product_code: str = None,
        product_en_name: str = None,
        product_name: str = None,
        product_specification: str = None,
        qualified_quantity: str = None,
        reworkable_quantity: str = None,
        scrapped_quantity: str = None,
        unit_price: str = None,
        user_id_list: str = None,
        user_name: str = None,
        user_name_list: str = None,
        uuid: str = None,
    ):
        self.corp_id = corp_id
        self.extend = extend
        # This parameter is required.
        self.inst_no = inst_no
        self.is_batch_job = is_batch_job
        # This parameter is required.
        self.manufacture_date = manufacture_date
        # This parameter is required.
        self.mes_app_key = mes_app_key
        self.process_en_name = process_en_name
        self.process_name = process_name
        self.product_code = product_code
        self.product_en_name = product_en_name
        self.product_name = product_name
        self.product_specification = product_specification
        # This parameter is required.
        self.qualified_quantity = qualified_quantity
        self.reworkable_quantity = reworkable_quantity
        self.scrapped_quantity = scrapped_quantity
        self.unit_price = unit_price
        self.user_id_list = user_id_list
        self.user_name = user_name
        self.user_name_list = user_name_list
        # This parameter is required.
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.extend is not None:
            result['extend'] = self.extend
        if self.inst_no is not None:
            result['instNo'] = self.inst_no
        if self.is_batch_job is not None:
            result['isBatchJob'] = self.is_batch_job
        if self.manufacture_date is not None:
            result['manufactureDate'] = self.manufacture_date
        if self.mes_app_key is not None:
            result['mesAppKey'] = self.mes_app_key
        if self.process_en_name is not None:
            result['processEnName'] = self.process_en_name
        if self.process_name is not None:
            result['processName'] = self.process_name
        if self.product_code is not None:
            result['productCode'] = self.product_code
        if self.product_en_name is not None:
            result['productEnName'] = self.product_en_name
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.product_specification is not None:
            result['productSpecification'] = self.product_specification
        if self.qualified_quantity is not None:
            result['qualifiedQuantity'] = self.qualified_quantity
        if self.reworkable_quantity is not None:
            result['reworkableQuantity'] = self.reworkable_quantity
        if self.scrapped_quantity is not None:
            result['scrappedQuantity'] = self.scrapped_quantity
        if self.unit_price is not None:
            result['unitPrice'] = self.unit_price
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.user_name_list is not None:
            result['userNameList'] = self.user_name_list
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('instNo') is not None:
            self.inst_no = m.get('instNo')
        if m.get('isBatchJob') is not None:
            self.is_batch_job = m.get('isBatchJob')
        if m.get('manufactureDate') is not None:
            self.manufacture_date = m.get('manufactureDate')
        if m.get('mesAppKey') is not None:
            self.mes_app_key = m.get('mesAppKey')
        if m.get('processEnName') is not None:
            self.process_en_name = m.get('processEnName')
        if m.get('processName') is not None:
            self.process_name = m.get('processName')
        if m.get('productCode') is not None:
            self.product_code = m.get('productCode')
        if m.get('productEnName') is not None:
            self.product_en_name = m.get('productEnName')
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('productSpecification') is not None:
            self.product_specification = m.get('productSpecification')
        if m.get('qualifiedQuantity') is not None:
            self.qualified_quantity = m.get('qualifiedQuantity')
        if m.get('reworkableQuantity') is not None:
            self.reworkable_quantity = m.get('reworkableQuantity')
        if m.get('scrappedQuantity') is not None:
            self.scrapped_quantity = m.get('scrappedQuantity')
        if m.get('unitPrice') is not None:
            self.unit_price = m.get('unitPrice')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('userNameList') is not None:
            self.user_name_list = m.get('userNameList')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class IndustrializeManufactureJobBookResponseBodyContent(TeaModel):
    def __init__(
        self,
        count: int = None,
        id: int = None,
    ):
        self.count = count
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class IndustrializeManufactureJobBookResponseBody(TeaModel):
    def __init__(
        self,
        content: IndustrializeManufactureJobBookResponseBodyContent = None,
        error_code: str = None,
        error_level: int = None,
        error_msg: str = None,
        http_code: str = None,
        success: bool = None,
        uuid: str = None,
    ):
        self.content = content
        self.error_code = error_code
        self.error_level = error_level
        self.error_msg = error_msg
        self.http_code = http_code
        # This parameter is required.
        self.success = success
        self.uuid = uuid

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_level is not None:
            result['errorLevel'] = self.error_level
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.http_code is not None:
            result['httpCode'] = self.http_code
        if self.success is not None:
            result['success'] = self.success
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = IndustrializeManufactureJobBookResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorLevel') is not None:
            self.error_level = m.get('errorLevel')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('httpCode') is not None:
            self.http_code = m.get('httpCode')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class IndustrializeManufactureJobBookResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: IndustrializeManufactureJobBookResponseBody = None,
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
            temp_model = IndustrializeManufactureJobBookResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustrializeManufactureQueryJobsHeaders(TeaModel):
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


class IndustrializeManufactureQueryJobsRequest(TeaModel):
    def __init__(
        self,
        current_page: int = None,
        inst_no: str = None,
        manufacture_day: str = None,
        mes_app_key: str = None,
        page_size: int = None,
        process_name: str = None,
        product_code: str = None,
        product_name: str = None,
        product_specification: str = None,
        qualified_quantity: str = None,
        unit_price: str = None,
        user_id: str = None,
        user_id_list: str = None,
        user_name: str = None,
        uuid: str = None,
    ):
        self.current_page = current_page
        self.inst_no = inst_no
        self.manufacture_day = manufacture_day
        self.mes_app_key = mes_app_key
        self.page_size = page_size
        self.process_name = process_name
        self.product_code = product_code
        self.product_name = product_name
        self.product_specification = product_specification
        self.qualified_quantity = qualified_quantity
        self.unit_price = unit_price
        self.user_id = user_id
        self.user_id_list = user_id_list
        self.user_name = user_name
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.inst_no is not None:
            result['instNo'] = self.inst_no
        if self.manufacture_day is not None:
            result['manufactureDay'] = self.manufacture_day
        if self.mes_app_key is not None:
            result['mesAppKey'] = self.mes_app_key
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.process_name is not None:
            result['processName'] = self.process_name
        if self.product_code is not None:
            result['productCode'] = self.product_code
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.product_specification is not None:
            result['productSpecification'] = self.product_specification
        if self.qualified_quantity is not None:
            result['qualifiedQuantity'] = self.qualified_quantity
        if self.unit_price is not None:
            result['unitPrice'] = self.unit_price
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('instNo') is not None:
            self.inst_no = m.get('instNo')
        if m.get('manufactureDay') is not None:
            self.manufacture_day = m.get('manufactureDay')
        if m.get('mesAppKey') is not None:
            self.mes_app_key = m.get('mesAppKey')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('processName') is not None:
            self.process_name = m.get('processName')
        if m.get('productCode') is not None:
            self.product_code = m.get('productCode')
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('productSpecification') is not None:
            self.product_specification = m.get('productSpecification')
        if m.get('qualifiedQuantity') is not None:
            self.qualified_quantity = m.get('qualifiedQuantity')
        if m.get('unitPrice') is not None:
            self.unit_price = m.get('unitPrice')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class IndustrializeManufactureQueryJobsResponseBodyContent(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        gmt_create: str = None,
        gmt_modified: str = None,
        id: int = None,
        inst_no: str = None,
        is_batch_job: str = None,
        manufacture_date: str = None,
        manufacture_day: str = None,
        mes_app_key: str = None,
        process_name: str = None,
        qualified_quantity: str = None,
        scrapped_quantity: str = None,
        unit_price: str = None,
        user_id: str = None,
        user_id_list: str = None,
        user_name_list: str = None,
        uuid: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.gmt_create = gmt_create
        # This parameter is required.
        self.gmt_modified = gmt_modified
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.inst_no = inst_no
        # This parameter is required.
        self.is_batch_job = is_batch_job
        # This parameter is required.
        self.manufacture_date = manufacture_date
        # This parameter is required.
        self.manufacture_day = manufacture_day
        # This parameter is required.
        self.mes_app_key = mes_app_key
        # This parameter is required.
        self.process_name = process_name
        # This parameter is required.
        self.qualified_quantity = qualified_quantity
        # This parameter is required.
        self.scrapped_quantity = scrapped_quantity
        # This parameter is required.
        self.unit_price = unit_price
        # This parameter is required.
        self.user_id = user_id
        # This parameter is required.
        self.user_id_list = user_id_list
        # This parameter is required.
        self.user_name_list = user_name_list
        # This parameter is required.
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.id is not None:
            result['id'] = self.id
        if self.inst_no is not None:
            result['instNo'] = self.inst_no
        if self.is_batch_job is not None:
            result['isBatchJob'] = self.is_batch_job
        if self.manufacture_date is not None:
            result['manufactureDate'] = self.manufacture_date
        if self.manufacture_day is not None:
            result['manufactureDay'] = self.manufacture_day
        if self.mes_app_key is not None:
            result['mesAppKey'] = self.mes_app_key
        if self.process_name is not None:
            result['processName'] = self.process_name
        if self.qualified_quantity is not None:
            result['qualifiedQuantity'] = self.qualified_quantity
        if self.scrapped_quantity is not None:
            result['scrappedQuantity'] = self.scrapped_quantity
        if self.unit_price is not None:
            result['unitPrice'] = self.unit_price
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        if self.user_name_list is not None:
            result['userNameList'] = self.user_name_list
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('instNo') is not None:
            self.inst_no = m.get('instNo')
        if m.get('isBatchJob') is not None:
            self.is_batch_job = m.get('isBatchJob')
        if m.get('manufactureDate') is not None:
            self.manufacture_date = m.get('manufactureDate')
        if m.get('manufactureDay') is not None:
            self.manufacture_day = m.get('manufactureDay')
        if m.get('mesAppKey') is not None:
            self.mes_app_key = m.get('mesAppKey')
        if m.get('processName') is not None:
            self.process_name = m.get('processName')
        if m.get('qualifiedQuantity') is not None:
            self.qualified_quantity = m.get('qualifiedQuantity')
        if m.get('scrappedQuantity') is not None:
            self.scrapped_quantity = m.get('scrappedQuantity')
        if m.get('unitPrice') is not None:
            self.unit_price = m.get('unitPrice')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        if m.get('userNameList') is not None:
            self.user_name_list = m.get('userNameList')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class IndustrializeManufactureQueryJobsResponseBody(TeaModel):
    def __init__(
        self,
        content: IndustrializeManufactureQueryJobsResponseBodyContent = None,
        http_code: str = None,
    ):
        self.content = content
        self.http_code = http_code

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        if self.http_code is not None:
            result['httpCode'] = self.http_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = IndustrializeManufactureQueryJobsResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('httpCode') is not None:
            self.http_code = m.get('httpCode')
        return self


class IndustrializeManufactureQueryJobsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: IndustrializeManufactureQueryJobsResponseBody = None,
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
            temp_model = IndustrializeManufactureQueryJobsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


