// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateResumeHeaders extends $tea.Model {
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

export class CreateResumeRequest extends $tea.Model {
  bizCode?: string;
  ext?: string;
  resumeDataVO?: CreateResumeRequestResumeDataVO;
  scene?: string;
  types?: string[];
  /**
   * **if can be null:**
   * false
   */
  userIdentify?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      ext: 'ext',
      resumeDataVO: 'resumeDataVO',
      scene: 'scene',
      types: 'types',
      userIdentify: 'userIdentify',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      ext: 'string',
      resumeDataVO: CreateResumeRequestResumeDataVO,
      scene: 'string',
      types: { 'type': 'array', 'itemType': 'string' },
      userIdentify: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeResponseBody extends $tea.Model {
  result?: CreateResumeResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateResumeResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateResumeResponseBody;
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
      body: CreateResumeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostResumeHeaders extends $tea.Model {
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

export class PostResumeRequest extends $tea.Model {
  jobId?: number;
  userIdentify?: string;
  static names(): { [key: string]: string } {
    return {
      jobId: 'jobId',
      userIdentify: 'userIdentify',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobId: 'number',
      userIdentify: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostResumeResponseBody extends $tea.Model {
  jobId?: number;
  userIdentify?: string;
  static names(): { [key: string]: string } {
    return {
      jobId: 'jobId',
      userIdentify: 'userIdentify',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobId: 'number',
      userIdentify: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostResumeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PostResumeResponseBody;
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
      body: PostResumeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeRequestResumeDataVOBaseInfo extends $tea.Model {
  age?: number;
  avatar?: string;
  beginWorkTime?: string;
  birthday?: string;
  candidateBackground?: number;
  dingTalk?: string;
  email?: string;
  englishName?: string;
  ethnicity?: string;
  gaduateTime?: string;
  highestAcademic?: string;
  highestEducation?: number;
  identify?: string;
  industry?: string;
  industryCode?: string;
  jobTitle?: string;
  lastSchoolName?: string;
  married?: number;
  mbtiType?: number;
  name?: string;
  nationality?: string;
  nativePlace?: string;
  nativePlaceCode?: string;
  nowLocation?: string;
  nowLocationCode?: string;
  parentIndustry?: string;
  parentIndustryCode?: string;
  personalHonor?: string;
  personalUrls?: string[];
  phoneNum?: string;
  politicalStatus?: number;
  qq?: string;
  realAvatar?: number;
  selfEvaluation?: string;
  sex?: number;
  skillSummary?: string;
  stateCode?: string;
  status?: string;
  virtualPhoneNum?: string;
  weChat?: string;
  weibo?: string;
  workingYears?: number;
  static names(): { [key: string]: string } {
    return {
      age: 'age',
      avatar: 'avatar',
      beginWorkTime: 'beginWorkTime',
      birthday: 'birthday',
      candidateBackground: 'candidateBackground',
      dingTalk: 'dingTalk',
      email: 'email',
      englishName: 'englishName',
      ethnicity: 'ethnicity',
      gaduateTime: 'gaduateTime',
      highestAcademic: 'highestAcademic',
      highestEducation: 'highestEducation',
      identify: 'identify',
      industry: 'industry',
      industryCode: 'industryCode',
      jobTitle: 'jobTitle',
      lastSchoolName: 'lastSchoolName',
      married: 'married',
      mbtiType: 'mbtiType',
      name: 'name',
      nationality: 'nationality',
      nativePlace: 'nativePlace',
      nativePlaceCode: 'nativePlaceCode',
      nowLocation: 'nowLocation',
      nowLocationCode: 'nowLocationCode',
      parentIndustry: 'parentIndustry',
      parentIndustryCode: 'parentIndustryCode',
      personalHonor: 'personalHonor',
      personalUrls: 'personalUrls',
      phoneNum: 'phoneNum',
      politicalStatus: 'politicalStatus',
      qq: 'qq',
      realAvatar: 'realAvatar',
      selfEvaluation: 'selfEvaluation',
      sex: 'sex',
      skillSummary: 'skillSummary',
      stateCode: 'stateCode',
      status: 'status',
      virtualPhoneNum: 'virtualPhoneNum',
      weChat: 'weChat',
      weibo: 'weibo',
      workingYears: 'workingYears',
    };
  }

  static types(): { [key: string]: any } {
    return {
      age: 'number',
      avatar: 'string',
      beginWorkTime: 'string',
      birthday: 'string',
      candidateBackground: 'number',
      dingTalk: 'string',
      email: 'string',
      englishName: 'string',
      ethnicity: 'string',
      gaduateTime: 'string',
      highestAcademic: 'string',
      highestEducation: 'number',
      identify: 'string',
      industry: 'string',
      industryCode: 'string',
      jobTitle: 'string',
      lastSchoolName: 'string',
      married: 'number',
      mbtiType: 'number',
      name: 'string',
      nationality: 'string',
      nativePlace: 'string',
      nativePlaceCode: 'string',
      nowLocation: 'string',
      nowLocationCode: 'string',
      parentIndustry: 'string',
      parentIndustryCode: 'string',
      personalHonor: 'string',
      personalUrls: { 'type': 'array', 'itemType': 'string' },
      phoneNum: 'string',
      politicalStatus: 'number',
      qq: 'string',
      realAvatar: 'number',
      selfEvaluation: 'string',
      sex: 'number',
      skillSummary: 'string',
      stateCode: 'string',
      status: 'string',
      virtualPhoneNum: 'string',
      weChat: 'string',
      weibo: 'string',
      workingYears: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeRequestResumeDataVOCertificates extends $tea.Model {
  certificateId?: string;
  certificateName?: string;
  crantTime?: string;
  static names(): { [key: string]: string } {
    return {
      certificateId: 'certificateId',
      certificateName: 'certificateName',
      crantTime: 'crantTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certificateId: 'string',
      certificateName: 'string',
      crantTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeRequestResumeDataVOJobExpectsCityList extends $tea.Model {
  code?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeRequestResumeDataVOJobExpectsIndustryList extends $tea.Model {
  code?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeRequestResumeDataVOJobExpectsJobList extends $tea.Model {
  code?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeRequestResumeDataVOJobExpectsOtherCityList extends $tea.Model {
  code?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeRequestResumeDataVOJobExpects extends $tea.Model {
  cityList?: CreateResumeRequestResumeDataVOJobExpectsCityList[];
  gmtCreate?: number;
  gmtModified?: number;
  industryList?: CreateResumeRequestResumeDataVOJobExpectsIndustryList[];
  jobList?: CreateResumeRequestResumeDataVOJobExpectsJobList[];
  jobNature?: string;
  maxSalary?: string;
  minSalary?: string;
  otherCityList?: CreateResumeRequestResumeDataVOJobExpectsOtherCityList[];
  salaryDesc?: string;
  salarySettleType?: string;
  salaryType?: string;
  salaryYear?: string;
  static names(): { [key: string]: string } {
    return {
      cityList: 'cityList',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      industryList: 'industryList',
      jobList: 'jobList',
      jobNature: 'jobNature',
      maxSalary: 'maxSalary',
      minSalary: 'minSalary',
      otherCityList: 'otherCityList',
      salaryDesc: 'salaryDesc',
      salarySettleType: 'salarySettleType',
      salaryType: 'salaryType',
      salaryYear: 'salaryYear',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cityList: { 'type': 'array', 'itemType': CreateResumeRequestResumeDataVOJobExpectsCityList },
      gmtCreate: 'number',
      gmtModified: 'number',
      industryList: { 'type': 'array', 'itemType': CreateResumeRequestResumeDataVOJobExpectsIndustryList },
      jobList: { 'type': 'array', 'itemType': CreateResumeRequestResumeDataVOJobExpectsJobList },
      jobNature: 'string',
      maxSalary: 'string',
      minSalary: 'string',
      otherCityList: { 'type': 'array', 'itemType': CreateResumeRequestResumeDataVOJobExpectsOtherCityList },
      salaryDesc: 'string',
      salarySettleType: 'string',
      salaryType: 'string',
      salaryYear: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeRequestResumeDataVOPersonalHonors extends $tea.Model {
  description?: string;
  grantTime?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      grantTime: 'grantTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      grantTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeRequestResumeDataVOProjectExperiences extends $tea.Model {
  achievement?: string;
  description?: string;
  endDate?: string;
  name?: string;
  projectUrl?: string;
  responsibility?: string;
  startDate?: string;
  technology?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      achievement: 'achievement',
      description: 'description',
      endDate: 'endDate',
      name: 'name',
      projectUrl: 'projectUrl',
      responsibility: 'responsibility',
      startDate: 'startDate',
      technology: 'technology',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      achievement: 'string',
      description: 'string',
      endDate: 'string',
      name: 'string',
      projectUrl: 'string',
      responsibility: 'string',
      startDate: 'string',
      technology: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeRequestResumeDataVOTags extends $tea.Model {
  tag?: string;
  static names(): { [key: string]: string } {
    return {
      tag: 'tag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tag: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy extends $tea.Model {
  shieldedCompany?: boolean;
  shieldedRelatedCompany?: boolean;
  static names(): { [key: string]: string } {
    return {
      shieldedCompany: 'shieldedCompany',
      shieldedRelatedCompany: 'shieldedRelatedCompany',
    };
  }

  static types(): { [key: string]: any } {
    return {
      shieldedCompany: 'boolean',
      shieldedRelatedCompany: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeRequestResumeDataVOWorkExperiences extends $tea.Model {
  achievement?: string;
  companyCode?: string;
  companyName?: string;
  description?: string;
  endDate?: string;
  industry?: string;
  industryCode?: string;
  internship?: boolean;
  jobCode?: string;
  jobNature?: string;
  jobTitle?: string;
  leader?: string;
  location?: string;
  locationCode?: string;
  parentIndustry?: string;
  parentIndustryCode?: string;
  reasonOfLeaving?: string;
  responsibility?: string;
  resumePrivacy?: CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy;
  salary?: string;
  selectedSkillOptions?: string[];
  startDate?: string;
  underlingNumber?: string;
  static names(): { [key: string]: string } {
    return {
      achievement: 'achievement',
      companyCode: 'companyCode',
      companyName: 'companyName',
      description: 'description',
      endDate: 'endDate',
      industry: 'industry',
      industryCode: 'industryCode',
      internship: 'internship',
      jobCode: 'jobCode',
      jobNature: 'jobNature',
      jobTitle: 'jobTitle',
      leader: 'leader',
      location: 'location',
      locationCode: 'locationCode',
      parentIndustry: 'parentIndustry',
      parentIndustryCode: 'parentIndustryCode',
      reasonOfLeaving: 'reasonOfLeaving',
      responsibility: 'responsibility',
      resumePrivacy: 'resumePrivacy',
      salary: 'salary',
      selectedSkillOptions: 'selectedSkillOptions',
      startDate: 'startDate',
      underlingNumber: 'underlingNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      achievement: 'string',
      companyCode: 'string',
      companyName: 'string',
      description: 'string',
      endDate: 'string',
      industry: 'string',
      industryCode: 'string',
      internship: 'boolean',
      jobCode: 'string',
      jobNature: 'string',
      jobTitle: 'string',
      leader: 'string',
      location: 'string',
      locationCode: 'string',
      parentIndustry: 'string',
      parentIndustryCode: 'string',
      reasonOfLeaving: 'string',
      responsibility: 'string',
      resumePrivacy: CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy,
      salary: 'string',
      selectedSkillOptions: { 'type': 'array', 'itemType': 'string' },
      startDate: 'string',
      underlingNumber: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeRequestResumeDataVO extends $tea.Model {
  baseInfo?: CreateResumeRequestResumeDataVOBaseInfo;
  certificates?: CreateResumeRequestResumeDataVOCertificates[];
  jobExpects?: CreateResumeRequestResumeDataVOJobExpects[];
  personalHonors?: CreateResumeRequestResumeDataVOPersonalHonors[];
  projectExperiences?: CreateResumeRequestResumeDataVOProjectExperiences[];
  tags?: CreateResumeRequestResumeDataVOTags[];
  workExperiences?: CreateResumeRequestResumeDataVOWorkExperiences[];
  static names(): { [key: string]: string } {
    return {
      baseInfo: 'baseInfo',
      certificates: 'certificates',
      jobExpects: 'jobExpects',
      personalHonors: 'personalHonors',
      projectExperiences: 'projectExperiences',
      tags: 'tags',
      workExperiences: 'workExperiences',
    };
  }

  static types(): { [key: string]: any } {
    return {
      baseInfo: CreateResumeRequestResumeDataVOBaseInfo,
      certificates: { 'type': 'array', 'itemType': CreateResumeRequestResumeDataVOCertificates },
      jobExpects: { 'type': 'array', 'itemType': CreateResumeRequestResumeDataVOJobExpects },
      personalHonors: { 'type': 'array', 'itemType': CreateResumeRequestResumeDataVOPersonalHonors },
      projectExperiences: { 'type': 'array', 'itemType': CreateResumeRequestResumeDataVOProjectExperiences },
      tags: { 'type': 'array', 'itemType': CreateResumeRequestResumeDataVOTags },
      workExperiences: { 'type': 'array', 'itemType': CreateResumeRequestResumeDataVOWorkExperiences },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResumeResponseBodyResult extends $tea.Model {
  resumeId?: string;
  static names(): { [key: string]: string } {
    return {
      resumeId: 'resumeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resumeId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 创建简历
   * 
   * @param request - CreateResumeRequest
   * @param headers - CreateResumeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateResumeResponse
   */
  async createResumeWithOptions(request: CreateResumeRequest, headers: CreateResumeHeaders, runtime: $Util.RuntimeOptions): Promise<CreateResumeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.resumeDataVO)) {
      body["resumeDataVO"] = request.resumeDataVO;
    }

    if (!Util.isUnset(request.scene)) {
      body["scene"] = request.scene;
    }

    if (!Util.isUnset(request.types)) {
      body["types"] = request.types;
    }

    if (!Util.isUnset(request.userIdentify)) {
      body["userIdentify"] = request.userIdentify;
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
      action: "CreateResume",
      version: "jobs_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jobs/resumes`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateResumeResponse>(await this.execute(params, req, runtime), new CreateResumeResponse({}));
  }

  /**
   * 创建简历
   * 
   * @param request - CreateResumeRequest
   * @returns CreateResumeResponse
   */
  async createResume(request: CreateResumeRequest): Promise<CreateResumeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateResumeHeaders({ });
    return await this.createResumeWithOptions(request, headers, runtime);
  }

  /**
   * 投递简历
   * 
   * @param request - PostResumeRequest
   * @param headers - PostResumeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PostResumeResponse
   */
  async postResumeWithOptions(request: PostResumeRequest, headers: PostResumeHeaders, runtime: $Util.RuntimeOptions): Promise<PostResumeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.jobId)) {
      body["jobId"] = request.jobId;
    }

    if (!Util.isUnset(request.userIdentify)) {
      body["userIdentify"] = request.userIdentify;
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
      action: "PostResume",
      version: "jobs_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/jobs/resumes/post`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PostResumeResponse>(await this.execute(params, req, runtime), new PostResumeResponse({}));
  }

  /**
   * 投递简历
   * 
   * @param request - PostResumeRequest
   * @returns PostResumeResponse
   */
  async postResume(request: PostResumeRequest): Promise<PostResumeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PostResumeHeaders({ });
    return await this.postResumeWithOptions(request, headers, runtime);
  }

}
