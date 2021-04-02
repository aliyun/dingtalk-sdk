// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import * as $tea from '@alicloud/tea-typescript';

export class GetDownloadInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDownloadInfoResponseBody extends $tea.Model {
  presignedUrlDownloadInfo?: GetDownloadInfoResponseBodyPresignedUrlDownloadInfo;
  static names(): { [key: string]: string } {
    return {
      presignedUrlDownloadInfo: 'presignedUrlDownloadInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      presignedUrlDownloadInfo: GetDownloadInfoResponseBodyPresignedUrlDownloadInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDownloadInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDownloadInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDownloadInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDownloadInfoResponseBodyPresignedUrlDownloadInfo extends $tea.Model {
  resourceUrl?: string;
  expiration?: number;
  static names(): { [key: string]: string } {
    return {
      resourceUrl: 'resourceUrl',
      expiration: 'expiration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resourceUrl: 'string',
      expiration: 'number',
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


  async getDownloadInfo(userId: string, spaceId: string, fileId: string): Promise<GetDownloadInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDownloadInfoHeaders({ });
    return await this.getDownloadInfoWithOptions(userId, spaceId, fileId, headers, runtime);
  }

  async getDownloadInfoWithOptions(userId: string, spaceId: string, fileId: string, headers: GetDownloadInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetDownloadInfoResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<GetDownloadInfoResponse>(await this.doROARequest("GetDownloadInfo", "drive_1.0", "HTTP", "GET", "AK", `/v1.0/drive/users/${userId}/spaces/${spaceId}/files/${fileId}/downloadInfo`, "json", req, runtime), new GetDownloadInfoResponse({}));
  }

}
