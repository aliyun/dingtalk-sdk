// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkmanufacturing_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkmanufacturing_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日清月结-计件报工接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IndustrializeManufactureJobBookRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IndustrializeManufactureJobBookResponse
        /// </returns>
        public IndustrializeManufactureJobBookResponse IndustrializeManufactureJobBookWithOptions(string userId, IndustrializeManufactureJobBookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstNo))
            {
                body["instNo"] = request.InstNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBatchJob))
            {
                body["isBatchJob"] = request.IsBatchJob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManufactureDate))
            {
                body["manufactureDate"] = request.ManufactureDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MesAppKey))
            {
                body["mesAppKey"] = request.MesAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessEnName))
            {
                body["processEnName"] = request.ProcessEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["processName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductEnName))
            {
                body["productEnName"] = request.ProductEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualifiedQuantity))
            {
                body["qualifiedQuantity"] = request.QualifiedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReworkableQuantity))
            {
                body["reworkableQuantity"] = request.ReworkableQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScrappedQuantity))
            {
                body["scrappedQuantity"] = request.ScrappedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitPrice))
            {
                body["unitPrice"] = request.UnitPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNameList))
            {
                body["userNameList"] = request.UserNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IndustrializeManufactureJobBook",
                Version = "manufacturing_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/manufacturing/users/" + userId + "/jobs",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustrializeManufactureJobBookResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日清月结-计件报工接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IndustrializeManufactureJobBookRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IndustrializeManufactureJobBookResponse
        /// </returns>
        public async Task<IndustrializeManufactureJobBookResponse> IndustrializeManufactureJobBookWithOptionsAsync(string userId, IndustrializeManufactureJobBookRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstNo))
            {
                body["instNo"] = request.InstNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBatchJob))
            {
                body["isBatchJob"] = request.IsBatchJob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManufactureDate))
            {
                body["manufactureDate"] = request.ManufactureDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MesAppKey))
            {
                body["mesAppKey"] = request.MesAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessEnName))
            {
                body["processEnName"] = request.ProcessEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["processName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductEnName))
            {
                body["productEnName"] = request.ProductEnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualifiedQuantity))
            {
                body["qualifiedQuantity"] = request.QualifiedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReworkableQuantity))
            {
                body["reworkableQuantity"] = request.ReworkableQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScrappedQuantity))
            {
                body["scrappedQuantity"] = request.ScrappedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitPrice))
            {
                body["unitPrice"] = request.UnitPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserNameList))
            {
                body["userNameList"] = request.UserNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IndustrializeManufactureJobBook",
                Version = "manufacturing_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/manufacturing/users/" + userId + "/jobs",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustrializeManufactureJobBookResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日清月结-计件报工接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IndustrializeManufactureJobBookRequest
        /// </param>
        /// 
        /// <returns>
        /// IndustrializeManufactureJobBookResponse
        /// </returns>
        public IndustrializeManufactureJobBookResponse IndustrializeManufactureJobBook(string userId, IndustrializeManufactureJobBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return IndustrializeManufactureJobBookWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日清月结-计件报工接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IndustrializeManufactureJobBookRequest
        /// </param>
        /// 
        /// <returns>
        /// IndustrializeManufactureJobBookResponse
        /// </returns>
        public async Task<IndustrializeManufactureJobBookResponse> IndustrializeManufactureJobBookAsync(string userId, IndustrializeManufactureJobBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await IndustrializeManufactureJobBookWithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日清月结-计件报工查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IndustrializeManufactureQueryJobsRequest
        /// </param>
        /// <param name="headers">
        /// IndustrializeManufactureQueryJobsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IndustrializeManufactureQueryJobsResponse
        /// </returns>
        public IndustrializeManufactureQueryJobsResponse IndustrializeManufactureQueryJobsWithOptions(IndustrializeManufactureQueryJobsRequest request, IndustrializeManufactureQueryJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstNo))
            {
                body["instNo"] = request.InstNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManufactureDay))
            {
                body["manufactureDay"] = request.ManufactureDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MesAppKey))
            {
                body["mesAppKey"] = request.MesAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["processName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualifiedQuantity))
            {
                body["qualifiedQuantity"] = request.QualifiedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitPrice))
            {
                body["unitPrice"] = request.UnitPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "IndustrializeManufactureQueryJobs",
                Version = "manufacturing_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/manufacturing/users/jobs/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustrializeManufactureQueryJobsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日清月结-计件报工查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IndustrializeManufactureQueryJobsRequest
        /// </param>
        /// <param name="headers">
        /// IndustrializeManufactureQueryJobsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IndustrializeManufactureQueryJobsResponse
        /// </returns>
        public async Task<IndustrializeManufactureQueryJobsResponse> IndustrializeManufactureQueryJobsWithOptionsAsync(IndustrializeManufactureQueryJobsRequest request, IndustrializeManufactureQueryJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstNo))
            {
                body["instNo"] = request.InstNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManufactureDay))
            {
                body["manufactureDay"] = request.ManufactureDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MesAppKey))
            {
                body["mesAppKey"] = request.MesAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["processName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualifiedQuantity))
            {
                body["qualifiedQuantity"] = request.QualifiedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnitPrice))
            {
                body["unitPrice"] = request.UnitPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "IndustrializeManufactureQueryJobs",
                Version = "manufacturing_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/manufacturing/users/jobs/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustrializeManufactureQueryJobsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日清月结-计件报工查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IndustrializeManufactureQueryJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// IndustrializeManufactureQueryJobsResponse
        /// </returns>
        public IndustrializeManufactureQueryJobsResponse IndustrializeManufactureQueryJobs(IndustrializeManufactureQueryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustrializeManufactureQueryJobsHeaders headers = new IndustrializeManufactureQueryJobsHeaders();
            return IndustrializeManufactureQueryJobsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>日清月结-计件报工查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IndustrializeManufactureQueryJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// IndustrializeManufactureQueryJobsResponse
        /// </returns>
        public async Task<IndustrializeManufactureQueryJobsResponse> IndustrializeManufactureQueryJobsAsync(IndustrializeManufactureQueryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustrializeManufactureQueryJobsHeaders headers = new IndustrializeManufactureQueryJobsHeaders();
            return await IndustrializeManufactureQueryJobsWithOptionsAsync(request, headers, runtime);
        }

    }
}
