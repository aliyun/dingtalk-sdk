// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  thumbUrl?: string;
  fileName?: string;
  mediaId?: string;
  mediaTitle?: string;
  mcnId?: string;
  userId?: string;
  mediaIntroduction?: string;
  static names(): { [key: string]: string } {
    return {
      thumbUrl: 'thumbUrl',
      fileName: 'fileName',
      mediaId: 'mediaId',
      mediaTitle: 'mediaTitle',
      mcnId: 'mcnId',
      userId: 'userId',
      mediaIntroduction: 'mediaIntroduction',
    };
  }

  static types(): { [key: string]: any } {
    return {
      thumbUrl: 'string',
      fileName: 'string',
      mediaId: 'string',
      mediaTitle: 'string',
      mcnId: 'string',
      userId: 'string',
      mediaIntroduction: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaCerficateResponseBody extends $tea.Model {
  mediaId?: string;
  ossEndpoint?: string;
  ossAccessKeyId?: string;
  ossAccessKeySecret?: string;
  ossSecurityToken?: string;
  ossBucketName?: string;
  ossFileName?: string;
  ossExpiration?: string;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
      ossEndpoint: 'ossEndpoint',
      ossAccessKeyId: 'ossAccessKeyId',
      ossAccessKeySecret: 'ossAccessKeySecret',
      ossSecurityToken: 'ossSecurityToken',
      ossBucketName: 'ossBucketName',
      ossFileName: 'ossFileName',
      ossExpiration: 'ossExpiration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
      ossEndpoint: 'string',
      ossAccessKeyId: 'string',
      ossAccessKeySecret: 'string',
      ossSecurityToken: 'string',
      ossBucketName: 'string',
      ossFileName: 'string',
      ossExpiration: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaCerficateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetMediaCerficateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetMediaCerficateResponseBody,
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
  body: GetFeedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetFeedResponseBody,
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
  nextToken?: number;
  maxResults?: number;
  body?: string[];
  mcnId?: string;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      body: 'body',
      mcnId: 'mcnId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      maxResults: 'number',
      body: { 'type': 'array', 'itemType': 'string' },
      mcnId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFeedResponseBody extends $tea.Model {
  feedList?: PageFeedResponseBodyFeedList[];
  nextCursor?: number;
  hasNext?: boolean;
  static names(): { [key: string]: string } {
    return {
      feedList: 'feedList',
      nextCursor: 'nextCursor',
      hasNext: 'hasNext',
    };
  }

  static types(): { [key: string]: any } {
    return {
      feedList: { 'type': 'array', 'itemType': PageFeedResponseBodyFeedList },
      nextCursor: 'number',
      hasNext: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFeedResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: PageFeedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: PageFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  feedInfo?: CreateFeedRequestFeedInfo;
  createUserId?: string;
  static names(): { [key: string]: string } {
    return {
      courseInfo: 'courseInfo',
      feedInfo: 'feedInfo',
      createUserId: 'createUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      courseInfo: CreateFeedRequestCourseInfo,
      feedInfo: CreateFeedRequestFeedInfo,
      createUserId: 'string',
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
  body: CreateFeedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateFeedResponseBody,
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
  body: ListItemUserDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListItemUserDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFeedResponseBodyFeedItem extends $tea.Model {
  itemId?: string;
  title?: string;
  feedContentType?: number;
  durationMillis?: number;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      itemId: 'itemId',
      title: 'title',
      feedContentType: 'feedContentType',
      durationMillis: 'durationMillis',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemId: 'string',
      title: 'string',
      feedContentType: 'number',
      durationMillis: 'number',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PageFeedResponseBodyFeedList extends $tea.Model {
  feedId?: string;
  name?: string;
  url?: string;
  feedType?: number;
  thumbUrl?: string;
  feedCategory?: string;
  static names(): { [key: string]: string } {
    return {
      feedId: 'feedId',
      name: 'name',
      url: 'url',
      feedType: 'feedType',
      thumbUrl: 'thumbUrl',
      feedCategory: 'feedCategory',
    };
  }

  static types(): { [key: string]: any } {
    return {
      feedId: 'string',
      name: 'string',
      url: 'string',
      feedType: 'number',
      thumbUrl: 'string',
      feedCategory: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfoLectorUserInfo extends $tea.Model {
  avatar?: string;
  userId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      userId: 'userId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      userId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfoPayInfoCsUserInfo extends $tea.Model {
  avatar?: string;
  userId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      userId: 'userId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      userId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfoPayInfoDiscountInfo extends $tea.Model {
  startTimeMillis?: number;
  price?: number;
  endTimeMillis?: number;
  static names(): { [key: string]: string } {
    return {
      startTimeMillis: 'startTimeMillis',
      price: 'price',
      endTimeMillis: 'endTimeMillis',
    };
  }

  static types(): { [key: string]: any } {
    return {
      startTimeMillis: 'number',
      price: 'number',
      endTimeMillis: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfoPayInfo extends $tea.Model {
  csUserInfo?: CreateFeedRequestCourseInfoPayInfoCsUserInfo;
  price?: number;
  discountInfo?: CreateFeedRequestCourseInfoPayInfoDiscountInfo;
  static names(): { [key: string]: string } {
    return {
      csUserInfo: 'csUserInfo',
      price: 'price',
      discountInfo: 'discountInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      csUserInfo: CreateFeedRequestCourseInfoPayInfoCsUserInfo,
      price: 'number',
      discountInfo: CreateFeedRequestCourseInfoPayInfoDiscountInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestCourseInfo extends $tea.Model {
  studyGroupName?: string;
  lectorUserInfo?: CreateFeedRequestCourseInfoLectorUserInfo;
  payInfo?: CreateFeedRequestCourseInfoPayInfo;
  static names(): { [key: string]: string } {
    return {
      studyGroupName: 'studyGroupName',
      lectorUserInfo: 'lectorUserInfo',
      payInfo: 'payInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      studyGroupName: 'string',
      lectorUserInfo: CreateFeedRequestCourseInfoLectorUserInfo,
      payInfo: CreateFeedRequestCourseInfoPayInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestFeedInfoMediaContents extends $tea.Model {
  type?: number;
  mediaId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      mediaId: 'mediaId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'number',
      mediaId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestFeedInfoRecommends extends $tea.Model {
  type?: number;
  objectId?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      objectId: 'objectId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'number',
      objectId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFeedRequestFeedInfo extends $tea.Model {
  actionType?: number;
  mediaContents?: CreateFeedRequestFeedInfoMediaContents[];
  feedCategory?: number;
  belongsTo?: number;
  industryId?: number;
  thumbUrl?: string;
  recommends?: CreateFeedRequestFeedInfoRecommends[];
  feedId?: string;
  title?: string;
  feedType?: number;
  introduction?: string;
  feedTag?: string;
  mcnId?: string;
  introductionPicUrl?: string;
  static names(): { [key: string]: string } {
    return {
      actionType: 'actionType',
      mediaContents: 'mediaContents',
      feedCategory: 'feedCategory',
      belongsTo: 'belongsTo',
      industryId: 'industryId',
      thumbUrl: 'thumbUrl',
      recommends: 'recommends',
      feedId: 'feedId',
      title: 'title',
      feedType: 'feedType',
      introduction: 'introduction',
      feedTag: 'feedTag',
      mcnId: 'mcnId',
      introductionPicUrl: 'introductionPicUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionType: 'number',
      mediaContents: { 'type': 'array', 'itemType': CreateFeedRequestFeedInfoMediaContents },
      feedCategory: 'number',
      belongsTo: 'number',
      industryId: 'number',
      thumbUrl: 'string',
      recommends: { 'type': 'array', 'itemType': CreateFeedRequestFeedInfoRecommends },
      feedId: 'string',
      title: 'string',
      feedType: 'number',
      introduction: 'string',
      feedTag: 'string',
      mcnId: 'string',
      introductionPicUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListItemUserDataResponseBodyStudyInfos extends $tea.Model {
  uid?: string;
  durationMillis?: number;
  static names(): { [key: string]: string } {
    return {
      uid: 'uid',
      durationMillis: 'durationMillis',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uid: 'string',
      durationMillis: 'number',
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


  async getMediaCerficate(request: GetMediaCerficateRequest): Promise<GetMediaCerficateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMediaCerficateHeaders({ });
    return await this.getMediaCerficateWithOptions(request, headers, runtime);
  }

  async getMediaCerficateWithOptions(request: GetMediaCerficateRequest, headers: GetMediaCerficateHeaders, runtime: $Util.RuntimeOptions): Promise<GetMediaCerficateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.thumbUrl)) {
      query["thumbUrl"] = request.thumbUrl;
    }

    if (!Util.isUnset(request.fileName)) {
      query["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.mediaId)) {
      query["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.mediaTitle)) {
      query["mediaTitle"] = request.mediaTitle;
    }

    if (!Util.isUnset(request.mcnId)) {
      query["mcnId"] = request.mcnId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.mediaIntroduction)) {
      query["mediaIntroduction"] = request.mediaIntroduction;
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
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetMediaCerficateResponse>(await this.doROARequest("GetMediaCerficate", "content_1.0", "HTTP", "GET", "AK", `/v1.0/content/media/cerficates`, "json", req, runtime), new GetMediaCerficateResponse({}));
  }

  async getFeed(feedId: string, request: GetFeedRequest): Promise<GetFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFeedHeaders({ });
    return await this.getFeedWithOptions(feedId, request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetFeedResponse>(await this.doROARequest("GetFeed", "content_1.0", "HTTP", "GET", "AK", `/v1.0/content/feeds/${feedId}`, "json", req, runtime), new GetFeedResponse({}));
  }

  async pageFeed(request: PageFeedRequest): Promise<PageFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PageFeedHeaders({ });
    return await this.pageFeedWithOptions(request, headers, runtime);
  }

  async pageFeedWithOptions(request: PageFeedRequest, headers: PageFeedHeaders, runtime: $Util.RuntimeOptions): Promise<PageFeedResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.mcnId)) {
      query["mcnId"] = request.mcnId;
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
      query: OpenApiUtil.query(query),
      body: request.body,
    });
    return $tea.cast<PageFeedResponse>(await this.doROARequest("PageFeed", "content_1.0", "HTTP", "POST", "AK", `/v1.0/content/feeds/query`, "json", req, runtime), new PageFeedResponse({}));
  }

  async createFeed(request: CreateFeedRequest): Promise<CreateFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateFeedHeaders({ });
    return await this.createFeedWithOptions(request, headers, runtime);
  }

  async createFeedWithOptions(request: CreateFeedRequest, headers: CreateFeedHeaders, runtime: $Util.RuntimeOptions): Promise<CreateFeedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.courseInfo))) {
      body["courseInfo"] = request.courseInfo;
    }

    if (!Util.isUnset($tea.toMap(request.feedInfo))) {
      body["feedInfo"] = request.feedInfo;
    }

    if (!Util.isUnset(request.createUserId)) {
      body["createUserId"] = request.createUserId;
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
    return $tea.cast<CreateFeedResponse>(await this.doROARequest("CreateFeed", "content_1.0", "HTTP", "POST", "AK", `/v1.0/content/feeds`, "json", req, runtime), new CreateFeedResponse({}));
  }

  async listItemUserData(itemId: string, request: ListItemUserDataRequest): Promise<ListItemUserDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListItemUserDataHeaders({ });
    return await this.listItemUserDataWithOptions(itemId, request, headers, runtime);
  }

  async listItemUserDataWithOptions(itemId: string, request: ListItemUserDataRequest, headers: ListItemUserDataHeaders, runtime: $Util.RuntimeOptions): Promise<ListItemUserDataResponse> {
    Util.validateModel(request);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: request.body,
    });
    return $tea.cast<ListItemUserDataResponse>(await this.doROARequest("ListItemUserData", "content_1.0", "HTTP", "POST", "AK", `/v1.0/content/feeds/items/${itemId}/userStatistics/query`, "json", req, runtime), new ListItemUserDataResponse({}));
  }

}
