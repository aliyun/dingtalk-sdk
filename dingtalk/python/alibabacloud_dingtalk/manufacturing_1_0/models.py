# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class IndustrializeManufactureJobBookRequest(TeaModel):
    def __init__(
        self,
        scrapped_quantity: str = None,
        product_specification: str = None,
        qualified_quantity: str = None,
        reworkable_quantity: str = None,
        user_name: str = None,
        uuid: str = None,
        product_name: str = None,
        product_en_name: str = None,
        extend: str = None,
        product_code: str = None,
        process_name: str = None,
        process_en_name: str = None,
        mes_app_key: str = None,
        inst_no: str = None,
        manufacture_date: str = None,
        ding_corp_id: str = None,
    ):
        # 报废数量
        self.scrapped_quantity = scrapped_quantity
        # 产品规格
        self.product_specification = product_specification
        # 合格数量
        self.qualified_quantity = qualified_quantity
        # 可重工数量
        self.reworkable_quantity = reworkable_quantity
        # 员工姓名
        self.user_name = user_name
        # 随机串，唯一标识(用于幂等及更新)
        self.uuid = uuid
        # 产品名称，例如"双头螺柱001"
        self.product_name = product_name
        # 产品英文名称
        self.product_en_name = product_en_name
        # 扩展字段，用于增加自定义字段
        self.extend = extend
        # 产品唯一标识
        self.product_code = product_code
        # 制程名称
        self.process_name = process_name
        # 制程英文名称
        self.process_en_name = process_en_name
        # mes 系统唯一标识
        self.mes_app_key = mes_app_key
        # 工单编号
        self.inst_no = inst_no
        # 生产日期时间(到时分秒)
        self.manufacture_date = manufacture_date
        # 钉钉组织id
        self.ding_corp_id = ding_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scrapped_quantity is not None:
            result['scrappedQuantity'] = self.scrapped_quantity
        if self.product_specification is not None:
            result['productSpecification'] = self.product_specification
        if self.qualified_quantity is not None:
            result['qualifiedQuantity'] = self.qualified_quantity
        if self.reworkable_quantity is not None:
            result['reworkableQuantity'] = self.reworkable_quantity
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.product_en_name is not None:
            result['productEnName'] = self.product_en_name
        if self.extend is not None:
            result['extend'] = self.extend
        if self.product_code is not None:
            result['productCode'] = self.product_code
        if self.process_name is not None:
            result['processName'] = self.process_name
        if self.process_en_name is not None:
            result['processEnName'] = self.process_en_name
        if self.mes_app_key is not None:
            result['mesAppKey'] = self.mes_app_key
        if self.inst_no is not None:
            result['instNo'] = self.inst_no
        if self.manufacture_date is not None:
            result['manufactureDate'] = self.manufacture_date
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scrappedQuantity') is not None:
            self.scrapped_quantity = m.get('scrappedQuantity')
        if m.get('productSpecification') is not None:
            self.product_specification = m.get('productSpecification')
        if m.get('qualifiedQuantity') is not None:
            self.qualified_quantity = m.get('qualifiedQuantity')
        if m.get('reworkableQuantity') is not None:
            self.reworkable_quantity = m.get('reworkableQuantity')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('productEnName') is not None:
            self.product_en_name = m.get('productEnName')
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('productCode') is not None:
            self.product_code = m.get('productCode')
        if m.get('processName') is not None:
            self.process_name = m.get('processName')
        if m.get('processEnName') is not None:
            self.process_en_name = m.get('processEnName')
        if m.get('mesAppKey') is not None:
            self.mes_app_key = m.get('mesAppKey')
        if m.get('instNo') is not None:
            self.inst_no = m.get('instNo')
        if m.get('manufactureDate') is not None:
            self.manufacture_date = m.get('manufactureDate')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        return self


class IndustrializeManufactureJobBookResponseBody(TeaModel):
    def __init__(
        self,
        http_code: str = None,
        uuid: str = None,
        content: str = None,
        error_msg: str = None,
        error_level: int = None,
        error_code: str = None,
        success: bool = None,
    ):
        # httpCode
        self.http_code = http_code
        # 此次报工记录的唯一标识
        self.uuid = uuid
        # content
        self.content = content
        # errorMsg
        self.error_msg = error_msg
        # errorLevel
        self.error_level = error_level
        # errorCode
        self.error_code = error_code
        # success
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.http_code is not None:
            result['httpCode'] = self.http_code
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.content is not None:
            result['content'] = self.content
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.error_level is not None:
            result['errorLevel'] = self.error_level
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('httpCode') is not None:
            self.http_code = m.get('httpCode')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('errorLevel') is not None:
            self.error_level = m.get('errorLevel')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class IndustrializeManufactureJobBookResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustrializeManufactureJobBookResponseBody = None,
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
        product_name: str = None,
        page_size: int = None,
        qualified_quantity: str = None,
        manufacture_day: str = None,
        inst_no: str = None,
        user_name: str = None,
        product_code: str = None,
        product_specification: str = None,
        unit_price: str = None,
        uuid: str = None,
        current_page: int = None,
        user_id: str = None,
        mes_app_key: str = None,
    ):
        # 产品中文名称
        self.product_name = product_name
        # 每页显示记录条数
        self.page_size = page_size
        # 报工合格数量
        self.qualified_quantity = qualified_quantity
        # 生产日期
        self.manufacture_day = manufacture_day
        # 工单编号
        self.inst_no = inst_no
        # 员工姓名
        self.user_name = user_name
        # 产品唯一标识
        self.product_code = product_code
        # 产品规格
        self.product_specification = product_specification
        # 计件单价，单位：分
        self.unit_price = unit_price
        # 报工记录的唯一标识
        self.uuid = uuid
        # 当前页序号(从1开始)
        self.current_page = current_page
        # 员工钉钉userId
        self.user_id = user_id
        # MES系统唯一标识
        self.mes_app_key = mes_app_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.qualified_quantity is not None:
            result['qualifiedQuantity'] = self.qualified_quantity
        if self.manufacture_day is not None:
            result['manufactureDay'] = self.manufacture_day
        if self.inst_no is not None:
            result['instNo'] = self.inst_no
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.product_code is not None:
            result['productCode'] = self.product_code
        if self.product_specification is not None:
            result['productSpecification'] = self.product_specification
        if self.unit_price is not None:
            result['unitPrice'] = self.unit_price
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.mes_app_key is not None:
            result['mesAppKey'] = self.mes_app_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('qualifiedQuantity') is not None:
            self.qualified_quantity = m.get('qualifiedQuantity')
        if m.get('manufactureDay') is not None:
            self.manufacture_day = m.get('manufactureDay')
        if m.get('instNo') is not None:
            self.inst_no = m.get('instNo')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('productCode') is not None:
            self.product_code = m.get('productCode')
        if m.get('productSpecification') is not None:
            self.product_specification = m.get('productSpecification')
        if m.get('unitPrice') is not None:
            self.unit_price = m.get('unitPrice')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('mesAppKey') is not None:
            self.mes_app_key = m.get('mesAppKey')
        return self


class IndustrializeManufactureQueryJobsResponseBody(TeaModel):
    def __init__(
        self,
        http_code: str = None,
        content: str = None,
    ):
        # httpCode
        self.http_code = http_code
        # 查询的数据结果
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.http_code is not None:
            result['httpCode'] = self.http_code
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('httpCode') is not None:
            self.http_code = m.get('httpCode')
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class IndustrializeManufactureQueryJobsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustrializeManufactureQueryJobsResponseBody = None,
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
            temp_model = IndustrializeManufactureQueryJobsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


