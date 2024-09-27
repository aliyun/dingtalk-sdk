// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalknotable_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "dingtalk";
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
        /// <para>新增数据表字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFieldRequest
        /// </param>
        /// <param name="headers">
        /// CreateFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFieldResponse
        /// </returns>
        public CreateFieldResponse CreateFieldWithOptions(string baseId, string sheetIdOrName, CreateFieldRequest request, CreateFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Property))
            {
                body["property"] = request.Property;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateField",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/fields",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFieldResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增数据表字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFieldRequest
        /// </param>
        /// <param name="headers">
        /// CreateFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFieldResponse
        /// </returns>
        public async Task<CreateFieldResponse> CreateFieldWithOptionsAsync(string baseId, string sheetIdOrName, CreateFieldRequest request, CreateFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Property))
            {
                body["property"] = request.Property;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateField",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/fields",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFieldResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增数据表字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFieldResponse
        /// </returns>
        public CreateFieldResponse CreateField(string baseId, string sheetIdOrName, CreateFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFieldHeaders headers = new CreateFieldHeaders();
            return CreateFieldWithOptions(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增数据表字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFieldResponse
        /// </returns>
        public async Task<CreateFieldResponse> CreateFieldAsync(string baseId, string sheetIdOrName, CreateFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateFieldHeaders headers = new CreateFieldHeaders();
            return await CreateFieldWithOptionsAsync(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSheetRequest
        /// </param>
        /// <param name="headers">
        /// CreateSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSheetResponse
        /// </returns>
        public CreateSheetResponse CreateSheetWithOptions(string baseId, CreateSheetRequest request, CreateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSheet",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSheetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSheetRequest
        /// </param>
        /// <param name="headers">
        /// CreateSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSheetResponse
        /// </returns>
        public async Task<CreateSheetResponse> CreateSheetWithOptionsAsync(string baseId, CreateSheetRequest request, CreateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fields))
            {
                body["fields"] = request.Fields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSheet",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSheetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSheetResponse
        /// </returns>
        public CreateSheetResponse CreateSheet(string baseId, CreateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSheetHeaders headers = new CreateSheetHeaders();
            return CreateSheetWithOptions(baseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSheetResponse
        /// </returns>
        public async Task<CreateSheetResponse> CreateSheetAsync(string baseId, CreateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSheetHeaders headers = new CreateSheetHeaders();
            return await CreateSheetWithOptionsAsync(baseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFieldRequest
        /// </param>
        /// <param name="headers">
        /// DeleteFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFieldResponse
        /// </returns>
        public DeleteFieldResponse DeleteFieldWithOptions(string baseId, string sheetIdOrName, string fieldIdOrName, DeleteFieldRequest request, DeleteFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "DeleteField",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/fields/" + fieldIdOrName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFieldResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFieldRequest
        /// </param>
        /// <param name="headers">
        /// DeleteFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFieldResponse
        /// </returns>
        public async Task<DeleteFieldResponse> DeleteFieldWithOptionsAsync(string baseId, string sheetIdOrName, string fieldIdOrName, DeleteFieldRequest request, DeleteFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "DeleteField",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/fields/" + fieldIdOrName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFieldResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFieldResponse
        /// </returns>
        public DeleteFieldResponse DeleteField(string baseId, string sheetIdOrName, string fieldIdOrName, DeleteFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFieldHeaders headers = new DeleteFieldHeaders();
            return DeleteFieldWithOptions(baseId, sheetIdOrName, fieldIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFieldResponse
        /// </returns>
        public async Task<DeleteFieldResponse> DeleteFieldAsync(string baseId, string sheetIdOrName, string fieldIdOrName, DeleteFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteFieldHeaders headers = new DeleteFieldHeaders();
            return await DeleteFieldWithOptionsAsync(baseId, sheetIdOrName, fieldIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表多行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecordsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecordsResponse
        /// </returns>
        public DeleteRecordsResponse DeleteRecordsWithOptions(string baseId, string sheetIdOrName, DeleteRecordsRequest request, DeleteRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordIds))
            {
                body["recordIds"] = request.RecordIds;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecords",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecordsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表多行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecordsRequest
        /// </param>
        /// <param name="headers">
        /// DeleteRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecordsResponse
        /// </returns>
        public async Task<DeleteRecordsResponse> DeleteRecordsWithOptionsAsync(string baseId, string sheetIdOrName, DeleteRecordsRequest request, DeleteRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordIds))
            {
                body["recordIds"] = request.RecordIds;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecords",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records/delete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表多行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecordsResponse
        /// </returns>
        public DeleteRecordsResponse DeleteRecords(string baseId, string sheetIdOrName, DeleteRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecordsHeaders headers = new DeleteRecordsHeaders();
            return DeleteRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表多行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRecordsResponse
        /// </returns>
        public async Task<DeleteRecordsResponse> DeleteRecordsAsync(string baseId, string sheetIdOrName, DeleteRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteRecordsHeaders headers = new DeleteRecordsHeaders();
            return await DeleteRecordsWithOptionsAsync(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSheetRequest
        /// </param>
        /// <param name="headers">
        /// DeleteSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSheetResponse
        /// </returns>
        public DeleteSheetResponse DeleteSheetWithOptions(string baseId, string sheetIdOrName, DeleteSheetRequest request, DeleteSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "DeleteSheet",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSheetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSheetRequest
        /// </param>
        /// <param name="headers">
        /// DeleteSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSheetResponse
        /// </returns>
        public async Task<DeleteSheetResponse> DeleteSheetWithOptionsAsync(string baseId, string sheetIdOrName, DeleteSheetRequest request, DeleteSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "DeleteSheet",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSheetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSheetResponse
        /// </returns>
        public DeleteSheetResponse DeleteSheet(string baseId, string sheetIdOrName, DeleteSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSheetHeaders headers = new DeleteSheetHeaders();
            return DeleteSheetWithOptions(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSheetResponse
        /// </returns>
        public async Task<DeleteSheetResponse> DeleteSheetAsync(string baseId, string sheetIdOrName, DeleteSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSheetHeaders headers = new DeleteSheetHeaders();
            return await DeleteSheetWithOptionsAsync(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllFieldsRequest
        /// </param>
        /// <param name="headers">
        /// GetAllFieldsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllFieldsResponse
        /// </returns>
        public GetAllFieldsResponse GetAllFieldsWithOptions(string baseId, string sheetIdOrName, GetAllFieldsRequest request, GetAllFieldsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetAllFields",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/fields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllFieldsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllFieldsRequest
        /// </param>
        /// <param name="headers">
        /// GetAllFieldsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllFieldsResponse
        /// </returns>
        public async Task<GetAllFieldsResponse> GetAllFieldsWithOptionsAsync(string baseId, string sheetIdOrName, GetAllFieldsRequest request, GetAllFieldsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetAllFields",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/fields",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllFieldsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllFieldsResponse
        /// </returns>
        public GetAllFieldsResponse GetAllFields(string baseId, string sheetIdOrName, GetAllFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllFieldsHeaders headers = new GetAllFieldsHeaders();
            return GetAllFieldsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllFieldsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllFieldsResponse
        /// </returns>
        public async Task<GetAllFieldsResponse> GetAllFieldsAsync(string baseId, string sheetIdOrName, GetAllFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllFieldsHeaders headers = new GetAllFieldsHeaders();
            return await GetAllFieldsWithOptionsAsync(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllSheetsRequest
        /// </param>
        /// <param name="headers">
        /// GetAllSheetsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllSheetsResponse
        /// </returns>
        public GetAllSheetsResponse GetAllSheetsWithOptions(string baseId, GetAllSheetsRequest request, GetAllSheetsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetAllSheets",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllSheetsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllSheetsRequest
        /// </param>
        /// <param name="headers">
        /// GetAllSheetsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAllSheetsResponse
        /// </returns>
        public async Task<GetAllSheetsResponse> GetAllSheetsWithOptionsAsync(string baseId, GetAllSheetsRequest request, GetAllSheetsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetAllSheets",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllSheetsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllSheetsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllSheetsResponse
        /// </returns>
        public GetAllSheetsResponse GetAllSheets(string baseId, GetAllSheetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllSheetsHeaders headers = new GetAllSheetsHeaders();
            return GetAllSheetsWithOptions(baseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取所有数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAllSheetsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAllSheetsResponse
        /// </returns>
        public async Task<GetAllSheetsResponse> GetAllSheetsAsync(string baseId, GetAllSheetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAllSheetsHeaders headers = new GetAllSheetsHeaders();
            return await GetAllSheetsWithOptionsAsync(baseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordRequest
        /// </param>
        /// <param name="headers">
        /// GetRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecordResponse
        /// </returns>
        public GetRecordResponse GetRecordWithOptions(string baseId, string sheetIdOrName, string recordId, GetRecordRequest request, GetRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetRecord",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records/" + recordId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecordResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordRequest
        /// </param>
        /// <param name="headers">
        /// GetRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecordResponse
        /// </returns>
        public async Task<GetRecordResponse> GetRecordWithOptionsAsync(string baseId, string sheetIdOrName, string recordId, GetRecordRequest request, GetRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetRecord",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records/" + recordId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecordResponse
        /// </returns>
        public GetRecordResponse GetRecord(string baseId, string sheetIdOrName, string recordId, GetRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecordHeaders headers = new GetRecordHeaders();
            return GetRecordWithOptions(baseId, sheetIdOrName, recordId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecordResponse
        /// </returns>
        public async Task<GetRecordResponse> GetRecordAsync(string baseId, string sheetIdOrName, string recordId, GetRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecordHeaders headers = new GetRecordHeaders();
            return await GetRecordWithOptionsAsync(baseId, sheetIdOrName, recordId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取多行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordsRequest
        /// </param>
        /// <param name="headers">
        /// GetRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecordsResponse
        /// </returns>
        public GetRecordsResponse GetRecordsWithOptions(string baseId, string sheetIdOrName, GetRecordsRequest request, GetRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetRecords",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecordsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取多行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordsRequest
        /// </param>
        /// <param name="headers">
        /// GetRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRecordsResponse
        /// </returns>
        public async Task<GetRecordsResponse> GetRecordsWithOptionsAsync(string baseId, string sheetIdOrName, GetRecordsRequest request, GetRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetRecords",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取多行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecordsResponse
        /// </returns>
        public GetRecordsResponse GetRecords(string baseId, string sheetIdOrName, GetRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecordsHeaders headers = new GetRecordsHeaders();
            return GetRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取多行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRecordsResponse
        /// </returns>
        public async Task<GetRecordsResponse> GetRecordsAsync(string baseId, string sheetIdOrName, GetRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRecordsHeaders headers = new GetRecordsHeaders();
            return await GetRecordsWithOptionsAsync(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSheetRequest
        /// </param>
        /// <param name="headers">
        /// GetSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSheetResponse
        /// </returns>
        public GetSheetResponse GetSheetWithOptions(string baseId, string sheetIdOrName, GetSheetRequest request, GetSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetSheet",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSheetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSheetRequest
        /// </param>
        /// <param name="headers">
        /// GetSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSheetResponse
        /// </returns>
        public async Task<GetSheetResponse> GetSheetWithOptionsAsync(string baseId, string sheetIdOrName, GetSheetRequest request, GetSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
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
                Action = "GetSheet",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSheetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSheetResponse
        /// </returns>
        public GetSheetResponse GetSheet(string baseId, string sheetIdOrName, GetSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSheetHeaders headers = new GetSheetHeaders();
            return GetSheetWithOptions(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSheetResponse
        /// </returns>
        public async Task<GetSheetResponse> GetSheetAsync(string baseId, string sheetIdOrName, GetSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSheetHeaders headers = new GetSheetHeaders();
            return await GetSheetWithOptionsAsync(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertRecordsRequest
        /// </param>
        /// <param name="headers">
        /// InsertRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertRecordsResponse
        /// </returns>
        public InsertRecordsResponse InsertRecordsWithOptions(string baseId, string sheetIdOrName, InsertRecordsRequest request, InsertRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertRecords",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertRecordsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertRecordsRequest
        /// </param>
        /// <param name="headers">
        /// InsertRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InsertRecordsResponse
        /// </returns>
        public async Task<InsertRecordsResponse> InsertRecordsWithOptionsAsync(string baseId, string sheetIdOrName, InsertRecordsRequest request, InsertRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertRecords",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertRecordsResponse
        /// </returns>
        public InsertRecordsResponse InsertRecords(string baseId, string sheetIdOrName, InsertRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertRecordsHeaders headers = new InsertRecordsHeaders();
            return InsertRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InsertRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// InsertRecordsResponse
        /// </returns>
        public async Task<InsertRecordsResponse> InsertRecordsAsync(string baseId, string sheetIdOrName, InsertRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InsertRecordsHeaders headers = new InsertRecordsHeaders();
            return await InsertRecordsWithOptionsAsync(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>富文本值预处理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrepareSetRichTextRequest
        /// </param>
        /// <param name="headers">
        /// PrepareSetRichTextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrepareSetRichTextResponse
        /// </returns>
        public PrepareSetRichTextResponse PrepareSetRichTextWithOptions(string baseId, PrepareSetRichTextRequest request, PrepareSetRichTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Markdown))
            {
                body["markdown"] = request.Markdown;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrepareSetRichText",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/prepareSetRichText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrepareSetRichTextResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>富文本值预处理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrepareSetRichTextRequest
        /// </param>
        /// <param name="headers">
        /// PrepareSetRichTextHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrepareSetRichTextResponse
        /// </returns>
        public async Task<PrepareSetRichTextResponse> PrepareSetRichTextWithOptionsAsync(string baseId, PrepareSetRichTextRequest request, PrepareSetRichTextHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Markdown))
            {
                body["markdown"] = request.Markdown;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrepareSetRichText",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/prepareSetRichText",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrepareSetRichTextResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>富文本值预处理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrepareSetRichTextRequest
        /// </param>
        /// 
        /// <returns>
        /// PrepareSetRichTextResponse
        /// </returns>
        public PrepareSetRichTextResponse PrepareSetRichText(string baseId, PrepareSetRichTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PrepareSetRichTextHeaders headers = new PrepareSetRichTextHeaders();
            return PrepareSetRichTextWithOptions(baseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>富文本值预处理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrepareSetRichTextRequest
        /// </param>
        /// 
        /// <returns>
        /// PrepareSetRichTextResponse
        /// </returns>
        public async Task<PrepareSetRichTextResponse> PrepareSetRichTextAsync(string baseId, PrepareSetRichTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PrepareSetRichTextHeaders headers = new PrepareSetRichTextHeaders();
            return await PrepareSetRichTextWithOptionsAsync(baseId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFieldRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFieldResponse
        /// </returns>
        public UpdateFieldResponse UpdateFieldWithOptions(string baseId, string sheetIdOrName, string fieldIdOrName, UpdateFieldRequest request, UpdateFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Property))
            {
                body["property"] = request.Property;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateField",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/fields/" + fieldIdOrName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFieldResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFieldRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFieldHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFieldResponse
        /// </returns>
        public async Task<UpdateFieldResponse> UpdateFieldWithOptionsAsync(string baseId, string sheetIdOrName, string fieldIdOrName, UpdateFieldRequest request, UpdateFieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Property))
            {
                body["property"] = request.Property;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateField",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/fields/" + fieldIdOrName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFieldResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFieldResponse
        /// </returns>
        public UpdateFieldResponse UpdateField(string baseId, string sheetIdOrName, string fieldIdOrName, UpdateFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFieldHeaders headers = new UpdateFieldHeaders();
            return UpdateFieldWithOptions(baseId, sheetIdOrName, fieldIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表字段</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFieldResponse
        /// </returns>
        public async Task<UpdateFieldResponse> UpdateFieldAsync(string baseId, string sheetIdOrName, string fieldIdOrName, UpdateFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFieldHeaders headers = new UpdateFieldHeaders();
            return await UpdateFieldWithOptionsAsync(baseId, sheetIdOrName, fieldIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表多行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRecordsRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordsResponse
        /// </returns>
        public UpdateRecordsResponse UpdateRecordsWithOptions(string baseId, string sheetIdOrName, UpdateRecordsRequest request, UpdateRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecords",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecordsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表多行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRecordsRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRecordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordsResponse
        /// </returns>
        public async Task<UpdateRecordsResponse> UpdateRecordsWithOptionsAsync(string baseId, string sheetIdOrName, UpdateRecordsRequest request, UpdateRecordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Records))
            {
                body["records"] = request.Records;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecords",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName + "/records",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表多行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordsResponse
        /// </returns>
        public UpdateRecordsResponse UpdateRecords(string baseId, string sheetIdOrName, UpdateRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRecordsHeaders headers = new UpdateRecordsHeaders();
            return UpdateRecordsWithOptions(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表多行记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRecordsResponse
        /// </returns>
        public async Task<UpdateRecordsResponse> UpdateRecordsAsync(string baseId, string sheetIdOrName, UpdateRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRecordsHeaders headers = new UpdateRecordsHeaders();
            return await UpdateRecordsWithOptionsAsync(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSheetRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSheetResponse
        /// </returns>
        public UpdateSheetResponse UpdateSheetWithOptions(string baseId, string sheetIdOrName, UpdateSheetRequest request, UpdateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSheet",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSheetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSheetRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSheetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSheetResponse
        /// </returns>
        public async Task<UpdateSheetResponse> UpdateSheetWithOptionsAsync(string baseId, string sheetIdOrName, UpdateSheetRequest request, UpdateSheetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSheet",
                Version = "notable_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/notable/bases/" + baseId + "/sheets/" + sheetIdOrName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSheetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSheetResponse
        /// </returns>
        public UpdateSheetResponse UpdateSheet(string baseId, string sheetIdOrName, UpdateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSheetHeaders headers = new UpdateSheetHeaders();
            return UpdateSheetWithOptions(baseId, sheetIdOrName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSheetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSheetResponse
        /// </returns>
        public async Task<UpdateSheetResponse> UpdateSheetAsync(string baseId, string sheetIdOrName, UpdateSheetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSheetHeaders headers = new UpdateSheetHeaders();
            return await UpdateSheetWithOptionsAsync(baseId, sheetIdOrName, request, headers, runtime);
        }

    }
}
