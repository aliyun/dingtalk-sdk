// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateFlashMeetingHeaders extends $tea.Model {
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

export class CreateFlashMeetingRequest extends $tea.Model {
  eventId?: string;
  title?: string;
  creator?: string;
  static names(): { [key: string]: string } {
    return {
      eventId: 'eventId',
      title: 'title',
      creator: 'creator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      eventId: 'string',
      title: 'string',
      creator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFlashMeetingResponseBody extends $tea.Model {
  endTime?: number;
  startTime?: number;
  title?: string;
  url?: string;
  flashMeetingKey?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
      title: 'title',
      url: 'url',
      flashMeetingKey: 'flashMeetingKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      startTime: 'number',
      title: 'string',
      url: 'string',
      flashMeetingKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFlashMeetingResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateFlashMeetingResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateFlashMeetingResponseBody,
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


  async createFlashMeeting(request: CreateFlashMeetingRequest): Promise<CreateFlashMeetingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateFlashMeetingHeaders({ });
    return await this.createFlashMeetingWithOptions(request, headers, runtime);
  }

  async createFlashMeetingWithOptions(request: CreateFlashMeetingRequest, headers: CreateFlashMeetingHeaders, runtime: $Util.RuntimeOptions): Promise<CreateFlashMeetingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.eventId)) {
      body["eventId"] = request.eventId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.creator)) {
      body["creator"] = request.creator;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateFlashMeetingResponse>(await this.doROARequest("CreateFlashMeeting", "flashmeeting_1.0", "HTTP", "POST", "AK", `/v1.0/flashmeeting/meetings`, "json", req, runtime), new CreateFlashMeetingResponse({}));
  }

}