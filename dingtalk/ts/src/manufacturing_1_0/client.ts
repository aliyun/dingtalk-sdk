// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class IndustrializeManufactureJobBookRequest extends $tea.Model {
  scrappedQuantity?: string;
  productSpecification?: string;
  qualifiedQuantity?: string;
  reworkableQuantity?: string;
  userName?: string;
  uuid?: string;
  productName?: string;
  productEnName?: string;
  extend?: string;
  productCode?: string;
  processName?: string;
  processEnName?: string;
  mesAppKey?: string;
  instNo?: string;
  manufactureDate?: string;
  dingCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      scrappedQuantity: 'scrappedQuantity',
      productSpecification: 'productSpecification',
      qualifiedQuantity: 'qualifiedQuantity',
      reworkableQuantity: 'reworkableQuantity',
      userName: 'userName',
      uuid: 'uuid',
      productName: 'productName',
      productEnName: 'productEnName',
      extend: 'extend',
      productCode: 'productCode',
      processName: 'processName',
      processEnName: 'processEnName',
      mesAppKey: 'mesAppKey',
      instNo: 'instNo',
      manufactureDate: 'manufactureDate',
      dingCorpId: 'dingCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scrappedQuantity: 'string',
      productSpecification: 'string',
      qualifiedQuantity: 'string',
      reworkableQuantity: 'string',
      userName: 'string',
      uuid: 'string',
      productName: 'string',
      productEnName: 'string',
      extend: 'string',
      productCode: 'string',
      processName: 'string',
      processEnName: 'string',
      mesAppKey: 'string',
      instNo: 'string',
      manufactureDate: 'string',
      dingCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustrializeManufactureJobBookResponseBody extends $tea.Model {
  content?: IndustrializeManufactureJobBookResponseBodyContent;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: IndustrializeManufactureJobBookResponseBodyContent,
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustrializeManufactureJobBookResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IndustrializeManufactureJobBookResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IndustrializeManufactureJobBookResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustrializeManufactureJobBookResponseBodyContent extends $tea.Model {
  id?: number;
  count?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      count: 'count',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      count: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async industrializeManufactureJobBook(userId: string, request: IndustrializeManufactureJobBookRequest): Promise<IndustrializeManufactureJobBookResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.industrializeManufactureJobBookWithOptions(userId, request, headers, runtime);
  }

  async industrializeManufactureJobBookWithOptions(userId: string, request: IndustrializeManufactureJobBookRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<IndustrializeManufactureJobBookResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.scrappedQuantity)) {
      body["scrappedQuantity"] = request.scrappedQuantity;
    }

    if (!Util.isUnset(request.productSpecification)) {
      body["productSpecification"] = request.productSpecification;
    }

    if (!Util.isUnset(request.qualifiedQuantity)) {
      body["qualifiedQuantity"] = request.qualifiedQuantity;
    }

    if (!Util.isUnset(request.reworkableQuantity)) {
      body["reworkableQuantity"] = request.reworkableQuantity;
    }

    if (!Util.isUnset(request.userName)) {
      body["userName"] = request.userName;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
    }

    if (!Util.isUnset(request.productName)) {
      body["productName"] = request.productName;
    }

    if (!Util.isUnset(request.productEnName)) {
      body["productEnName"] = request.productEnName;
    }

    if (!Util.isUnset(request.extend)) {
      body["extend"] = request.extend;
    }

    if (!Util.isUnset(request.productCode)) {
      body["productCode"] = request.productCode;
    }

    if (!Util.isUnset(request.processName)) {
      body["processName"] = request.processName;
    }

    if (!Util.isUnset(request.processEnName)) {
      body["processEnName"] = request.processEnName;
    }

    if (!Util.isUnset(request.mesAppKey)) {
      body["mesAppKey"] = request.mesAppKey;
    }

    if (!Util.isUnset(request.instNo)) {
      body["instNo"] = request.instNo;
    }

    if (!Util.isUnset(request.manufactureDate)) {
      body["manufactureDate"] = request.manufactureDate;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<IndustrializeManufactureJobBookResponse>(await this.doROARequest("IndustrializeManufactureJobBook", "manufacturing_1.0", "HTTP", "POST", "AK", `/v1.0/manufacturing/users/${userId}/jobs`, "json", req, runtime), new IndustrializeManufactureJobBookResponse({}));
  }

}
