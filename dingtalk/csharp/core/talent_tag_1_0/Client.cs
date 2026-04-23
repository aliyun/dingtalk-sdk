// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalktalent_tag_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalktalent_tag_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：添加员工自定义标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2AddCustomTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2AddCustomTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2AddCustomTagResponse
        /// </returns>
        public TalentV2AddCustomTagResponse TalentV2AddCustomTagWithOptions(TalentV2AddCustomTagRequest request, TalentV2AddCustomTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2AddCustomTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/addCustomTag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2AddCustomTagResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：添加员工自定义标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2AddCustomTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2AddCustomTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2AddCustomTagResponse
        /// </returns>
        public async Task<TalentV2AddCustomTagResponse> TalentV2AddCustomTagWithOptionsAsync(TalentV2AddCustomTagRequest request, TalentV2AddCustomTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2AddCustomTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/addCustomTag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2AddCustomTagResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：添加员工自定义标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2AddCustomTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2AddCustomTagResponse
        /// </returns>
        public TalentV2AddCustomTagResponse TalentV2AddCustomTag(TalentV2AddCustomTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2AddCustomTagHeaders headers = new TalentV2AddCustomTagHeaders();
            return TalentV2AddCustomTagWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：添加员工自定义标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2AddCustomTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2AddCustomTagResponse
        /// </returns>
        public async Task<TalentV2AddCustomTagResponse> TalentV2AddCustomTagAsync(TalentV2AddCustomTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2AddCustomTagHeaders headers = new TalentV2AddCustomTagHeaders();
            return await TalentV2AddCustomTagWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：添加员工客观标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2AddObjectiveTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2AddObjectiveTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2AddObjectiveTagResponse
        /// </returns>
        public TalentV2AddObjectiveTagResponse TalentV2AddObjectiveTagWithOptions(TalentV2AddObjectiveTagRequest request, TalentV2AddObjectiveTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2AddObjectiveTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/addObjectiveTag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2AddObjectiveTagResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：添加员工客观标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2AddObjectiveTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2AddObjectiveTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2AddObjectiveTagResponse
        /// </returns>
        public async Task<TalentV2AddObjectiveTagResponse> TalentV2AddObjectiveTagWithOptionsAsync(TalentV2AddObjectiveTagRequest request, TalentV2AddObjectiveTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2AddObjectiveTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/addObjectiveTag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2AddObjectiveTagResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：添加员工客观标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2AddObjectiveTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2AddObjectiveTagResponse
        /// </returns>
        public TalentV2AddObjectiveTagResponse TalentV2AddObjectiveTag(TalentV2AddObjectiveTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2AddObjectiveTagHeaders headers = new TalentV2AddObjectiveTagHeaders();
            return TalentV2AddObjectiveTagWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：添加员工客观标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2AddObjectiveTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2AddObjectiveTagResponse
        /// </returns>
        public async Task<TalentV2AddObjectiveTagResponse> TalentV2AddObjectiveTagAsync(TalentV2AddObjectiveTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2AddObjectiveTagHeaders headers = new TalentV2AddObjectiveTagHeaders();
            return await TalentV2AddObjectiveTagWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：添加企业个性标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2AddPersonalityTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2AddPersonalityTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2AddPersonalityTagResponse
        /// </returns>
        public TalentV2AddPersonalityTagResponse TalentV2AddPersonalityTagWithOptions(TalentV2AddPersonalityTagRequest request, TalentV2AddPersonalityTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryCode))
            {
                body["categoryCode"] = request.CategoryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["categoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategorySortOrder))
            {
                body["categorySortOrder"] = request.CategorySortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2AddPersonalityTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/addPersonalityTag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2AddPersonalityTagResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：添加企业个性标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2AddPersonalityTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2AddPersonalityTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2AddPersonalityTagResponse
        /// </returns>
        public async Task<TalentV2AddPersonalityTagResponse> TalentV2AddPersonalityTagWithOptionsAsync(TalentV2AddPersonalityTagRequest request, TalentV2AddPersonalityTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryCode))
            {
                body["categoryCode"] = request.CategoryCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["categoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategorySortOrder))
            {
                body["categorySortOrder"] = request.CategorySortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                body["sortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2AddPersonalityTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/addPersonalityTag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2AddPersonalityTagResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：添加企业个性标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2AddPersonalityTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2AddPersonalityTagResponse
        /// </returns>
        public TalentV2AddPersonalityTagResponse TalentV2AddPersonalityTag(TalentV2AddPersonalityTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2AddPersonalityTagHeaders headers = new TalentV2AddPersonalityTagHeaders();
            return TalentV2AddPersonalityTagWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：添加企业个性标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2AddPersonalityTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2AddPersonalityTagResponse
        /// </returns>
        public async Task<TalentV2AddPersonalityTagResponse> TalentV2AddPersonalityTagAsync(TalentV2AddPersonalityTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2AddPersonalityTagHeaders headers = new TalentV2AddPersonalityTagHeaders();
            return await TalentV2AddPersonalityTagWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：删除员工自定义标签并清除所有点赞记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2DeleteCustomTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2DeleteCustomTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2DeleteCustomTagResponse
        /// </returns>
        public TalentV2DeleteCustomTagResponse TalentV2DeleteCustomTagWithOptions(TalentV2DeleteCustomTagRequest request, TalentV2DeleteCustomTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2DeleteCustomTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/deleteCustomTagWithClearLike",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2DeleteCustomTagResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：删除员工自定义标签并清除所有点赞记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2DeleteCustomTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2DeleteCustomTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2DeleteCustomTagResponse
        /// </returns>
        public async Task<TalentV2DeleteCustomTagResponse> TalentV2DeleteCustomTagWithOptionsAsync(TalentV2DeleteCustomTagRequest request, TalentV2DeleteCustomTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2DeleteCustomTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/deleteCustomTagWithClearLike",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2DeleteCustomTagResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：删除员工自定义标签并清除所有点赞记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2DeleteCustomTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2DeleteCustomTagResponse
        /// </returns>
        public TalentV2DeleteCustomTagResponse TalentV2DeleteCustomTag(TalentV2DeleteCustomTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2DeleteCustomTagHeaders headers = new TalentV2DeleteCustomTagHeaders();
            return TalentV2DeleteCustomTagWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：删除员工自定义标签并清除所有点赞记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2DeleteCustomTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2DeleteCustomTagResponse
        /// </returns>
        public async Task<TalentV2DeleteCustomTagResponse> TalentV2DeleteCustomTagAsync(TalentV2DeleteCustomTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2DeleteCustomTagHeaders headers = new TalentV2DeleteCustomTagHeaders();
            return await TalentV2DeleteCustomTagWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：删除员工客观标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2DeleteObjectiveTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2DeleteObjectiveTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2DeleteObjectiveTagResponse
        /// </returns>
        public TalentV2DeleteObjectiveTagResponse TalentV2DeleteObjectiveTagWithOptions(TalentV2DeleteObjectiveTagRequest request, TalentV2DeleteObjectiveTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2DeleteObjectiveTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/deleteObjectiveTag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2DeleteObjectiveTagResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：删除员工客观标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2DeleteObjectiveTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2DeleteObjectiveTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2DeleteObjectiveTagResponse
        /// </returns>
        public async Task<TalentV2DeleteObjectiveTagResponse> TalentV2DeleteObjectiveTagWithOptionsAsync(TalentV2DeleteObjectiveTagRequest request, TalentV2DeleteObjectiveTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2DeleteObjectiveTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/deleteObjectiveTag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2DeleteObjectiveTagResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：删除员工客观标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2DeleteObjectiveTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2DeleteObjectiveTagResponse
        /// </returns>
        public TalentV2DeleteObjectiveTagResponse TalentV2DeleteObjectiveTag(TalentV2DeleteObjectiveTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2DeleteObjectiveTagHeaders headers = new TalentV2DeleteObjectiveTagHeaders();
            return TalentV2DeleteObjectiveTagWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：删除员工客观标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2DeleteObjectiveTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2DeleteObjectiveTagResponse
        /// </returns>
        public async Task<TalentV2DeleteObjectiveTagResponse> TalentV2DeleteObjectiveTagAsync(TalentV2DeleteObjectiveTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2DeleteObjectiveTagHeaders headers = new TalentV2DeleteObjectiveTagHeaders();
            return await TalentV2DeleteObjectiveTagWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：删除企业个性标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2DeletePersonalityTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2DeletePersonalityTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2DeletePersonalityTagResponse
        /// </returns>
        public TalentV2DeletePersonalityTagResponse TalentV2DeletePersonalityTagWithOptions(TalentV2DeletePersonalityTagRequest request, TalentV2DeletePersonalityTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2DeletePersonalityTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/deletePersonalityTag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2DeletePersonalityTagResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：删除企业个性标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2DeletePersonalityTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2DeletePersonalityTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2DeletePersonalityTagResponse
        /// </returns>
        public async Task<TalentV2DeletePersonalityTagResponse> TalentV2DeletePersonalityTagWithOptionsAsync(TalentV2DeletePersonalityTagRequest request, TalentV2DeletePersonalityTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2DeletePersonalityTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/deletePersonalityTag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2DeletePersonalityTagResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：删除企业个性标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2DeletePersonalityTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2DeletePersonalityTagResponse
        /// </returns>
        public TalentV2DeletePersonalityTagResponse TalentV2DeletePersonalityTag(TalentV2DeletePersonalityTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2DeletePersonalityTagHeaders headers = new TalentV2DeletePersonalityTagHeaders();
            return TalentV2DeletePersonalityTagWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：删除企业个性标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2DeletePersonalityTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2DeletePersonalityTagResponse
        /// </returns>
        public async Task<TalentV2DeletePersonalityTagResponse> TalentV2DeletePersonalityTagAsync(TalentV2DeletePersonalityTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2DeletePersonalityTagHeaders headers = new TalentV2DeletePersonalityTagHeaders();
            return await TalentV2DeletePersonalityTagWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：点赞/取消点赞标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2LikeTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2LikeTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2LikeTagResponse
        /// </returns>
        public TalentV2LikeTagResponse TalentV2LikeTagWithOptions(TalentV2LikeTagRequest request, TalentV2LikeTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2LikeTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/likeTag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2LikeTagResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：点赞/取消点赞标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2LikeTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2LikeTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2LikeTagResponse
        /// </returns>
        public async Task<TalentV2LikeTagResponse> TalentV2LikeTagWithOptionsAsync(TalentV2LikeTagRequest request, TalentV2LikeTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                body["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2LikeTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/likeTag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2LikeTagResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：点赞/取消点赞标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2LikeTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2LikeTagResponse
        /// </returns>
        public TalentV2LikeTagResponse TalentV2LikeTag(TalentV2LikeTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2LikeTagHeaders headers = new TalentV2LikeTagHeaders();
            return TalentV2LikeTagWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：点赞/取消点赞标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2LikeTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2LikeTagResponse
        /// </returns>
        public async Task<TalentV2LikeTagResponse> TalentV2LikeTagAsync(TalentV2LikeTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2LikeTagHeaders headers = new TalentV2LikeTagHeaders();
            return await TalentV2LikeTagWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询员工自定义标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryCustomTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2QueryCustomTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryCustomTagResponse
        /// </returns>
        public TalentV2QueryCustomTagResponse TalentV2QueryCustomTagWithOptions(TalentV2QueryCustomTagRequest request, TalentV2QueryCustomTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2QueryCustomTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/queryCustomTag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2QueryCustomTagResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询员工自定义标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryCustomTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2QueryCustomTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryCustomTagResponse
        /// </returns>
        public async Task<TalentV2QueryCustomTagResponse> TalentV2QueryCustomTagWithOptionsAsync(TalentV2QueryCustomTagRequest request, TalentV2QueryCustomTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2QueryCustomTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/queryCustomTag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2QueryCustomTagResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询员工自定义标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryCustomTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryCustomTagResponse
        /// </returns>
        public TalentV2QueryCustomTagResponse TalentV2QueryCustomTag(TalentV2QueryCustomTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2QueryCustomTagHeaders headers = new TalentV2QueryCustomTagHeaders();
            return TalentV2QueryCustomTagWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询员工自定义标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryCustomTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryCustomTagResponse
        /// </returns>
        public async Task<TalentV2QueryCustomTagResponse> TalentV2QueryCustomTagAsync(TalentV2QueryCustomTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2QueryCustomTagHeaders headers = new TalentV2QueryCustomTagHeaders();
            return await TalentV2QueryCustomTagWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询员工客观标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryObjectiveTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2QueryObjectiveTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryObjectiveTagResponse
        /// </returns>
        public TalentV2QueryObjectiveTagResponse TalentV2QueryObjectiveTagWithOptions(TalentV2QueryObjectiveTagRequest request, TalentV2QueryObjectiveTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2QueryObjectiveTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/queryObjectiveTag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2QueryObjectiveTagResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询员工客观标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryObjectiveTagRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2QueryObjectiveTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryObjectiveTagResponse
        /// </returns>
        public async Task<TalentV2QueryObjectiveTagResponse> TalentV2QueryObjectiveTagWithOptionsAsync(TalentV2QueryObjectiveTagRequest request, TalentV2QueryObjectiveTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2QueryObjectiveTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/queryObjectiveTag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2QueryObjectiveTagResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询员工客观标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryObjectiveTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryObjectiveTagResponse
        /// </returns>
        public TalentV2QueryObjectiveTagResponse TalentV2QueryObjectiveTag(TalentV2QueryObjectiveTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2QueryObjectiveTagHeaders headers = new TalentV2QueryObjectiveTagHeaders();
            return TalentV2QueryObjectiveTagWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询员工客观标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryObjectiveTagRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryObjectiveTagResponse
        /// </returns>
        public async Task<TalentV2QueryObjectiveTagResponse> TalentV2QueryObjectiveTagAsync(TalentV2QueryObjectiveTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2QueryObjectiveTagHeaders headers = new TalentV2QueryObjectiveTagHeaders();
            return await TalentV2QueryObjectiveTagWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询企业个性标签</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// TalentV2QueryPersonalityTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryPersonalityTagResponse
        /// </returns>
        public TalentV2QueryPersonalityTagResponse TalentV2QueryPersonalityTagWithOptions(TalentV2QueryPersonalityTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2QueryPersonalityTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/queryPersonalityTag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2QueryPersonalityTagResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询企业个性标签</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// TalentV2QueryPersonalityTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryPersonalityTagResponse
        /// </returns>
        public async Task<TalentV2QueryPersonalityTagResponse> TalentV2QueryPersonalityTagWithOptionsAsync(TalentV2QueryPersonalityTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2QueryPersonalityTag",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/queryPersonalityTag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2QueryPersonalityTagResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询企业个性标签</para>
        /// </summary>
        /// 
        /// <returns>
        /// TalentV2QueryPersonalityTagResponse
        /// </returns>
        public TalentV2QueryPersonalityTagResponse TalentV2QueryPersonalityTag()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2QueryPersonalityTagHeaders headers = new TalentV2QueryPersonalityTagHeaders();
            return TalentV2QueryPersonalityTagWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询企业个性标签</para>
        /// </summary>
        /// 
        /// <returns>
        /// TalentV2QueryPersonalityTagResponse
        /// </returns>
        public async Task<TalentV2QueryPersonalityTagResponse> TalentV2QueryPersonalityTagAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2QueryPersonalityTagHeaders headers = new TalentV2QueryPersonalityTagHeaders();
            return await TalentV2QueryPersonalityTagWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：分页查询指定标签的点赞记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryTagLikeDetailListRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2QueryTagLikeDetailListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryTagLikeDetailListResponse
        /// </returns>
        public TalentV2QueryTagLikeDetailListResponse TalentV2QueryTagLikeDetailListWithOptions(TalentV2QueryTagLikeDetailListRequest request, TalentV2QueryTagLikeDetailListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                query["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2QueryTagLikeDetailList",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/queryTagLikeDetailList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2QueryTagLikeDetailListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：分页查询指定标签的点赞记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryTagLikeDetailListRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2QueryTagLikeDetailListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryTagLikeDetailListResponse
        /// </returns>
        public async Task<TalentV2QueryTagLikeDetailListResponse> TalentV2QueryTagLikeDetailListWithOptionsAsync(TalentV2QueryTagLikeDetailListRequest request, TalentV2QueryTagLikeDetailListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagCode))
            {
                query["tagCode"] = request.TagCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2QueryTagLikeDetailList",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/queryTagLikeDetailList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2QueryTagLikeDetailListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：分页查询指定标签的点赞记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryTagLikeDetailListRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryTagLikeDetailListResponse
        /// </returns>
        public TalentV2QueryTagLikeDetailListResponse TalentV2QueryTagLikeDetailList(TalentV2QueryTagLikeDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2QueryTagLikeDetailListHeaders headers = new TalentV2QueryTagLikeDetailListHeaders();
            return TalentV2QueryTagLikeDetailListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：分页查询指定标签的点赞记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryTagLikeDetailListRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryTagLikeDetailListResponse
        /// </returns>
        public async Task<TalentV2QueryTagLikeDetailListResponse> TalentV2QueryTagLikeDetailListAsync(TalentV2QueryTagLikeDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2QueryTagLikeDetailListHeaders headers = new TalentV2QueryTagLikeDetailListHeaders();
            return await TalentV2QueryTagLikeDetailListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询点赞标签列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryTagLikeListRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2QueryTagLikeListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryTagLikeListResponse
        /// </returns>
        public TalentV2QueryTagLikeListResponse TalentV2QueryTagLikeListWithOptions(TalentV2QueryTagLikeListRequest request, TalentV2QueryTagLikeListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                query["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2QueryTagLikeList",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/queryTagLikeList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2QueryTagLikeListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询点赞标签列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryTagLikeListRequest
        /// </param>
        /// <param name="headers">
        /// TalentV2QueryTagLikeListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryTagLikeListResponse
        /// </returns>
        public async Task<TalentV2QueryTagLikeListResponse> TalentV2QueryTagLikeListWithOptionsAsync(TalentV2QueryTagLikeListRequest request, TalentV2QueryTagLikeListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                query["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TalentV2QueryTagLikeList",
                Version = "talentTag_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/talentTag/talentTags/queryTagLikeList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TalentV2QueryTagLikeListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询点赞标签列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryTagLikeListRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryTagLikeListResponse
        /// </returns>
        public TalentV2QueryTagLikeListResponse TalentV2QueryTagLikeList(TalentV2QueryTagLikeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2QueryTagLikeListHeaders headers = new TalentV2QueryTagLikeListHeaders();
            return TalentV2QueryTagLikeListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人才标签：查询点赞标签列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TalentV2QueryTagLikeListRequest
        /// </param>
        /// 
        /// <returns>
        /// TalentV2QueryTagLikeListResponse
        /// </returns>
        public async Task<TalentV2QueryTagLikeListResponse> TalentV2QueryTagLikeListAsync(TalentV2QueryTagLikeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TalentV2QueryTagLikeListHeaders headers = new TalentV2QueryTagLikeListHeaders();
            return await TalentV2QueryTagLikeListWithOptionsAsync(request, headers, runtime);
        }

    }
}
