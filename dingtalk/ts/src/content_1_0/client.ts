// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import SPI from '@alicloud/gateway-spi';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateFeedHeaders extends $tea.Model {
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

export class CreateFeedRequest extends $tea.Model {
  courseInfo?: CreateFeedRequestCourseInfo;
  createUserId?: string;
  feedInfo?: CreateFeedRequestFeedInfo;
  static names(): { [key: string]: string } {
    return {
      courseInfo: 'courseInfo',
      createUserId: 'createUserId',
      feedInfo: 'feedInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseInfo: CreateFeedRequestCourseInfo,
      createUserId: 'string',
      feedInfo: CreateFeedRequestFeedInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedResponseBody extends $tea.Model {
  feedId?: string;
  static names(): { [key: string]: string } {
    return {
      feedId: 'feedId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      feedId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateFeedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFeedHeaders extends $tea.Model {
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

export class GetFeedRequest extends $tea.Model {
  mcnId?: string;
  static names(): { [key: string]: string } {
    return {
      mcnId: 'mcnId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mcnId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFeedResponseBody extends $tea.Model {
  feedId?: string;
  feedItem?: GetFeedResponseBodyFeedItem[];
  static names(): { [key: string]: string } {
    return {
      feedId: 'feedId',
      feedItem: 'feedItem',
    };
  }

  static types(): { [key: string]: any } {
    return {
      feedId: 'string',
      feedItem: { 'type': 'array', 'itemType': GetFeedResponseBodyFeedItem },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFeedResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFeedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaCerficateHeaders extends $tea.Model {
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

export class GetMediaCerficateRequest extends $tea.Model {
  fileName?: string;
  mcnId?: string;
  mediaId?: string;
  mediaIntroduction?: string;
  mediaTitle?: string;
  thumbUrl?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      mcnId: 'mcnId',
      mediaId: 'mediaId',
      mediaIntroduction: 'mediaIntroduction',
      mediaTitle: 'mediaTitle',
      thumbUrl: 'thumbUrl',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      mcnId: 'string',
      mediaId: 'string',
      mediaIntroduction: 'string',
      mediaTitle: 'string',
      thumbUrl: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaCerficateResponseBody extends $tea.Model {
  mediaId?: string;
  ossAccessKeyId?: string;
  ossAccessKeySecret?: string;
  ossBucketName?: string;
  ossEndpoint?: string;
  ossExpiration?: string;
  ossFileName?: string;
  ossSecurityToken?: string;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
      ossAccessKeyId: 'ossAccessKeyId',
      ossAccessKeySecret: 'ossAccessKeySecret',
      ossBucketName: 'ossBucketName',
      ossEndpoint: 'ossEndpoint',
      ossExpiration: 'ossExpiration',
      ossFileName: 'ossFileName',
      ossSecurityToken: 'ossSecurityToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
      ossAccessKeyId: 'string',
      ossAccessKeySecret: 'string',
      ossBucketName: 'string',
      ossEndpoint: 'string',
      ossExpiration: 'string',
      ossFileName: 'string',
      ossSecurityToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaCerficateResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetMediaCerficateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetMediaCerficateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListItemUserDataHeaders extends $tea.Model {
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

export class ListItemUserDataRequest extends $tea.Model {
  body?: string[];
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListItemUserDataResponseBody extends $tea.Model {
  studyInfos?: ListItemUserDataResponseBodyStudyInfos[];
  static names(): { [key: string]: string } {
    return {
      studyInfos: 'studyInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      studyInfos: { 'type': 'array', 'itemType': ListItemUserDataResponseBodyStudyInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListItemUserDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListItemUserDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListItemUserDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFeedHeaders extends $tea.Model {
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

export class PageFeedRequest extends $tea.Model {
  body?: string[];
  maxResults?: number;
  mcnId?: string;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      maxResults: 'maxResults',
      mcnId: 'mcnId',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': 'string' },
      maxResults: 'number',
      mcnId: 'string',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFeedResponseBody extends $tea.Model {
  feedList?: PageFeedResponseBodyFeedList[];
  hasNext?: boolean;
  nextCursor?: number;
  static names(): { [key: string]: string } {
    return {
      feedList: 'feedList',
      hasNext: 'hasNext',
      nextCursor: 'nextCursor',
    };
  }

  static types(): { [key: string]: any } {
    return {
      feedList: { 'type': 'array', 'itemType': PageFeedResponseBodyFeedList },
      hasNext: 'boolean',
      nextCursor: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFeedResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PageFeedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PageFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfoLectorUserInfo extends $tea.Model {
  avatar?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfoPayInfoCsUserInfo extends $tea.Model {
  avatar?: string;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfoPayInfoDiscountInfo extends $tea.Model {
  endTimeMillis?: number;
  price?: number;
  startTimeMillis?: number;
  static names(): { [key: string]: string } {
    return {
      endTimeMillis: 'endTimeMillis',
      price: 'price',
      startTimeMillis: 'startTimeMillis',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTimeMillis: 'number',
      price: 'number',
      startTimeMillis: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfoPayInfo extends $tea.Model {
  csUserInfo?: CreateFeedRequestCourseInfoPayInfoCsUserInfo;
  discountInfo?: CreateFeedRequestCourseInfoPayInfoDiscountInfo;
  price?: number;
  static names(): { [key: string]: string } {
    return {
      csUserInfo: 'csUserInfo',
      discountInfo: 'discountInfo',
      price: 'price',
    };
  }

  static types(): { [key: string]: any } {
    return {
      csUserInfo: CreateFeedRequestCourseInfoPayInfoCsUserInfo,
      discountInfo: CreateFeedRequestCourseInfoPayInfoDiscountInfo,
      price: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfo extends $tea.Model {
  lectorUserInfo?: CreateFeedRequestCourseInfoLectorUserInfo;
  payInfo?: CreateFeedRequestCourseInfoPayInfo;
  studyGroupName?: string;
  static names(): { [key: string]: string } {
    return {
      lectorUserInfo: 'lectorUserInfo',
      payInfo: 'payInfo',
      studyGroupName: 'studyGroupName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lectorUserInfo: CreateFeedRequestCourseInfoLectorUserInfo,
      payInfo: CreateFeedRequestCourseInfoPayInfo,
      studyGroupName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestFeedInfoMediaContents extends $tea.Model {
  mediaId?: string;
  title?: string;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
      title: 'title',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
      title: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestFeedInfoRecommends extends $tea.Model {
  objectId?: string;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      objectId: 'objectId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectId: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestFeedInfo extends $tea.Model {
  actionType?: number;
  belongsTo?: number;
  feedCategory?: number;
  feedId?: string;
  feedTag?: string;
  feedType?: number;
  industryId?: number;
  introduction?: string;
  introductionPicUrl?: string;
  mcnId?: string;
  mediaContents?: CreateFeedRequestFeedInfoMediaContents[];
  recommends?: CreateFeedRequestFeedInfoRecommends[];
  thumbUrl?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      actionType: 'actionType',
      belongsTo: 'belongsTo',
      feedCategory: 'feedCategory',
      feedId: 'feedId',
      feedTag: 'feedTag',
      feedType: 'feedType',
      industryId: 'industryId',
      introduction: 'introduction',
      introductionPicUrl: 'introductionPicUrl',
      mcnId: 'mcnId',
      mediaContents: 'mediaContents',
      recommends: 'recommends',
      thumbUrl: 'thumbUrl',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionType: 'number',
      belongsTo: 'number',
      feedCategory: 'number',
      feedId: 'string',
      feedTag: 'string',
      feedType: 'number',
      industryId: 'number',
      introduction: 'string',
      introductionPicUrl: 'string',
      mcnId: 'string',
      mediaContents: { 'type': 'array', 'itemType': CreateFeedRequestFeedInfoMediaContents },
      recommends: { 'type': 'array', 'itemType': CreateFeedRequestFeedInfoRecommends },
      thumbUrl: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFeedResponseBodyFeedItem extends $tea.Model {
  durationMillis?: number;
  feedContentType?: number;
  itemId?: string;
  title?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      durationMillis: 'durationMillis',
      feedContentType: 'feedContentType',
      itemId: 'itemId',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      durationMillis: 'number',
      feedContentType: 'number',
      itemId: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListItemUserDataResponseBodyStudyInfos extends $tea.Model {
  durationMillis?: number;
  uid?: string;
  static names(): { [key: string]: string } {
    return {
      durationMillis: 'durationMillis',
      uid: 'uid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      durationMillis: 'number',
      uid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFeedResponseBodyFeedList extends $tea.Model {
  feedCategory?: string;
  feedId?: string;
  feedType?: number;
  name?: string;
  thumbUrl?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      feedCategory: 'feedCategory',
      feedId: 'feedId',
      feedType: 'feedType',
      name: 'name',
      thumbUrl: 'thumbUrl',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      feedCategory: 'string',
      feedId: 'string',
      feedType: 'number',
      name: 'string',
      thumbUrl: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {
  _client: SPI;

  constructor(config: $OpenApi.Config) {
    super(config);
    this._client = new GatewayClient();
    this._spi = this._client;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async createFeedWithOptions(request: CreateFeedRequest, headers: CreateFeedHeaders, runtime: $Util.RuntimeOptions): Promise<CreateFeedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.courseInfo)) {
      body["courseInfo"] = request.courseInfo;
    }

    if (!Util.isUnset(request.createUserId)) {
      body["createUserId"] = request.createUserId;
    }

    if (!Util.isUnset(request.feedInfo)) {
      body["feedInfo"] = request.feedInfo;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateFeed",
      version: "content_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/content/feeds`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateFeedResponse>(await this.execute(params, req, runtime), new CreateFeedResponse({}));
  }

  async createFeed(request: CreateFeedRequest): Promise<CreateFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateFeedHeaders({ });
    return await this.createFeedWithOptions(request, headers, runtime);
  }

  async getFeedWithOptions(feedId: string, request: GetFeedRequest, headers: GetFeedHeaders, runtime: $Util.RuntimeOptions): Promise<GetFeedResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mcnId)) {
      query["mcnId"] = request.mcnId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetFeed",
      version: "content_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/content/feeds/${feedId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetFeedResponse>(await this.execute(params, req, runtime), new GetFeedResponse({}));
  }

  async getFeed(feedId: string, request: GetFeedRequest): Promise<GetFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFeedHeaders({ });
    return await this.getFeedWithOptions(feedId, request, headers, runtime);
  }

  async getMediaCerficateWithOptions(request: GetMediaCerficateRequest, headers: GetMediaCerficateHeaders, runtime: $Util.RuntimeOptions): Promise<GetMediaCerficateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fileName)) {
      query["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.mcnId)) {
      query["mcnId"] = request.mcnId;
    }

    if (!Util.isUnset(request.mediaId)) {
      query["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.mediaIntroduction)) {
      query["mediaIntroduction"] = request.mediaIntroduction;
    }

    if (!Util.isUnset(request.mediaTitle)) {
      query["mediaTitle"] = request.mediaTitle;
    }

    if (!Util.isUnset(request.thumbUrl)) {
      query["thumbUrl"] = request.thumbUrl;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetMediaCerficate",
      version: "content_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/content/media/cerficates`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetMediaCerficateResponse>(await this.execute(params, req, runtime), new GetMediaCerficateResponse({}));
  }

  async getMediaCerficate(request: GetMediaCerficateRequest): Promise<GetMediaCerficateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMediaCerficateHeaders({ });
    return await this.getMediaCerficateWithOptions(request, headers, runtime);
  }

  async listItemUserDataWithOptions(itemId: string, request: ListItemUserDataRequest, headers: ListItemUserDataHeaders, runtime: $Util.RuntimeOptions): Promise<ListItemUserDataResponse> {
    Util.validateModel(request);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: request.body,
    });
    let params = new $OpenApi.Params({
      action: "ListItemUserData",
      version: "content_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/content/feeds/items/${itemId}/userStatistics/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListItemUserDataResponse>(await this.execute(params, req, runtime), new ListItemUserDataResponse({}));
  }

  async listItemUserData(itemId: string, request: ListItemUserDataRequest): Promise<ListItemUserDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListItemUserDataHeaders({ });
    return await this.listItemUserDataWithOptions(itemId, request, headers, runtime);
  }

  async pageFeedWithOptions(request: PageFeedRequest, headers: PageFeedHeaders, runtime: $Util.RuntimeOptions): Promise<PageFeedResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.mcnId)) {
      query["mcnId"] = request.mcnId;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
      body: request.body,
    });
    let params = new $OpenApi.Params({
      action: "PageFeed",
      version: "content_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/content/feeds/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<PageFeedResponse>(await this.execute(params, req, runtime), new PageFeedResponse({}));
  }

  async pageFeed(request: PageFeedRequest): Promise<PageFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageFeedHeaders({ });
    return await this.pageFeedWithOptions(request, headers, runtime);
  }

}
