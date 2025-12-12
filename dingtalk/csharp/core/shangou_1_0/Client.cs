// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkshangou_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkshangou_1_0
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
        /// <para>新增餐饮评价数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCateringCommentRequest
        /// </param>
        /// <param name="headers">
        /// AddCateringCommentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCateringCommentResponse
        /// </returns>
        public AddCateringCommentResponse AddCateringCommentWithOptions(AddCateringCommentRequest request, AddCateringCommentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommentId))
            {
                body["commentId"] = request.CommentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RateContent))
            {
                body["rateContent"] = request.RateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RatedAt))
            {
                body["ratedAt"] = request.RatedAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rating))
            {
                body["rating"] = request.Rating;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShopId))
            {
                body["shopId"] = request.ShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "AddCateringComment",
                Version = "shangou_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/shangou/comment/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCateringCommentResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增餐饮评价数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCateringCommentRequest
        /// </param>
        /// <param name="headers">
        /// AddCateringCommentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCateringCommentResponse
        /// </returns>
        public async Task<AddCateringCommentResponse> AddCateringCommentWithOptionsAsync(AddCateringCommentRequest request, AddCateringCommentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommentId))
            {
                body["commentId"] = request.CommentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RateContent))
            {
                body["rateContent"] = request.RateContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RatedAt))
            {
                body["ratedAt"] = request.RatedAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rating))
            {
                body["rating"] = request.Rating;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShopId))
            {
                body["shopId"] = request.ShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "AddCateringComment",
                Version = "shangou_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/shangou/comment/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCateringCommentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增餐饮评价数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCateringCommentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCateringCommentResponse
        /// </returns>
        public AddCateringCommentResponse AddCateringComment(AddCateringCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCateringCommentHeaders headers = new AddCateringCommentHeaders();
            return AddCateringCommentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增餐饮评价数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddCateringCommentRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCateringCommentResponse
        /// </returns>
        public async Task<AddCateringCommentResponse> AddCateringCommentAsync(AddCateringCommentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCateringCommentHeaders headers = new AddCateringCommentHeaders();
            return await AddCateringCommentWithOptionsAsync(request, headers, runtime);
        }

    }
}
