<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\CreateOrUpdateFormDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\CreateOrUpdateFormDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\CreateOrUpdateFormDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetFormComponentAliasListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetFormComponentAliasListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetFormComponentAliasListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetFormDataByIDHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetFormDataByIDRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetFormDataByIDResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetInstanceByIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetInstanceByIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetInstanceByIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetInstanceIdListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetInstanceIdListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetInstanceIdListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetInstancesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetInstancesRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetInstancesResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SaveFormDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SaveFormDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SaveFormDataResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDataIdListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDataIdListRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDataIdListResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDataSecondGenerationHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDataSecondGenerationRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDataSecondGenerationResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDatasHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDatasRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\SearchFormDatasResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\StartInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\StartInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\StartInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\UpdateFormDataHeaders;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\UpdateFormDataRequest;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\UpdateFormDataResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $gatewayClient       = new Client();
        $this->_spi          = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 新增或更新表单实例
     *  *
     * @param CreateOrUpdateFormDataRequest $request CreateOrUpdateFormDataRequest
     * @param CreateOrUpdateFormDataHeaders $headers CreateOrUpdateFormDataHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateOrUpdateFormDataResponse CreateOrUpdateFormDataResponse
     */
    public function createOrUpdateFormDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            $body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->noExecuteExpression)) {
            $body['noExecuteExpression'] = $request->noExecuteExpression;
        }
        if (!Utils::isUnset($request->searchCondition)) {
            $body['searchCondition'] = $request->searchCondition;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->useAlias)) {
            $body['useAlias'] = $request->useAlias;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'CreateOrUpdateFormData',
            'version'     => 'yida_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/yida/forms/instances/insertOrUpdate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateOrUpdateFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增或更新表单实例
     *  *
     * @param CreateOrUpdateFormDataRequest $request CreateOrUpdateFormDataRequest
     *
     * @return CreateOrUpdateFormDataResponse CreateOrUpdateFormDataResponse
     */
    public function createOrUpdateFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateOrUpdateFormDataHeaders([]);

        return $this->createOrUpdateFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取表单组件别名列表
     *  *
     * @param string                           $appType
     * @param string                           $formUuid
     * @param GetFormComponentAliasListRequest $request  GetFormComponentAliasListRequest
     * @param GetFormComponentAliasListHeaders $headers  GetFormComponentAliasListHeaders
     * @param RuntimeOptions                   $runtime  runtime options for this request RuntimeOptions
     *
     * @return GetFormComponentAliasListResponse GetFormComponentAliasListResponse
     */
    public function getFormComponentAliasListWithOptions($appType, $formUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        if (!Utils::isUnset($request->version)) {
            $query['version'] = $request->version;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetFormComponentAliasList',
            'version'     => 'yida_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/yida/forms/component/alias/' . $appType . '/' . $formUuid . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFormComponentAliasListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取表单组件别名列表
     *  *
     * @param string                           $appType
     * @param string                           $formUuid
     * @param GetFormComponentAliasListRequest $request  GetFormComponentAliasListRequest
     *
     * @return GetFormComponentAliasListResponse GetFormComponentAliasListResponse
     */
    public function getFormComponentAliasList($appType, $formUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFormComponentAliasListHeaders([]);

        return $this->getFormComponentAliasListWithOptions($appType, $formUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 根据表单 ID 查询实例详情
     *  *
     * @param string                 $id
     * @param GetFormDataByIDRequest $request GetFormDataByIDRequest
     * @param GetFormDataByIDHeaders $headers GetFormDataByIDHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetFormDataByIDResponse GetFormDataByIDResponse
     */
    public function getFormDataByIDWithOptions($id, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $query['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->useAlias)) {
            $query['useAlias'] = $request->useAlias;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetFormDataByID',
            'version'     => 'yida_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/yida/forms/instances/' . $id . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetFormDataByIDResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据表单 ID 查询实例详情
     *  *
     * @param string                 $id
     * @param GetFormDataByIDRequest $request GetFormDataByIDRequest
     *
     * @return GetFormDataByIDResponse GetFormDataByIDResponse
     */
    public function getFormDataByID($id, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFormDataByIDHeaders([]);

        return $this->getFormDataByIDWithOptions($id, $request, $headers, $runtime);
    }

    /**
     * @summary 根据实例 ID 获取流程实例详情
     *  *
     * @param string                 $id
     * @param GetInstanceByIdRequest $request GetInstanceByIdRequest
     * @param GetInstanceByIdHeaders $headers GetInstanceByIdHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInstanceByIdResponse GetInstanceByIdResponse
     */
    public function getInstanceByIdWithOptions($id, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appType)) {
            $query['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $query['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            $query['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $query['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->useAlias)) {
            $query['useAlias'] = $request->useAlias;
        }
        if (!Utils::isUnset($request->userId)) {
            $query['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action'      => 'GetInstanceById',
            'version'     => 'yida_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/yida/processes/instancesInfos/' . $id . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetInstanceByIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据实例 ID 获取流程实例详情
     *  *
     * @param string                 $id
     * @param GetInstanceByIdRequest $request GetInstanceByIdRequest
     *
     * @return GetInstanceByIdResponse GetInstanceByIdResponse
     */
    public function getInstanceById($id, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInstanceByIdHeaders([]);

        return $this->getInstanceByIdWithOptions($id, $request, $headers, $runtime);
    }

    /**
     * @summary 根据条件搜索流程实例 ID
     *  *
     * @param GetInstanceIdListRequest $request GetInstanceIdListRequest
     * @param GetInstanceIdListHeaders $headers GetInstanceIdListHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInstanceIdListResponse GetInstanceIdListResponse
     */
    public function getInstanceIdListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->approvedResult)) {
            $body['approvedResult'] = $request->approvedResult;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->instanceStatus)) {
            $body['instanceStatus'] = $request->instanceStatus;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            $body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            $body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->originatorId)) {
            $body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            $body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
        }
        if (!Utils::isUnset($request->useAlias)) {
            $body['useAlias'] = $request->useAlias;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetInstanceIdList',
            'version'     => 'yida_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/yida/processes/instanceIds',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetInstanceIdListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据条件搜索流程实例 ID
     *  *
     * @param GetInstanceIdListRequest $request GetInstanceIdListRequest
     *
     * @return GetInstanceIdListResponse GetInstanceIdListResponse
     */
    public function getInstanceIdList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInstanceIdListHeaders([]);

        return $this->getInstanceIdListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据搜索条件获取流程表单实例详情
     *  *
     * @param GetInstancesRequest $request GetInstancesRequest
     * @param GetInstancesHeaders $headers GetInstancesHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetInstancesResponse GetInstancesResponse
     */
    public function getInstancesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->approvedResult)) {
            $body['approvedResult'] = $request->approvedResult;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->instanceStatus)) {
            $body['instanceStatus'] = $request->instanceStatus;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            $body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            $body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->orderConfigJson)) {
            $body['orderConfigJson'] = $request->orderConfigJson;
        }
        if (!Utils::isUnset($request->originatorId)) {
            $body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            $body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->taskId)) {
            $body['taskId'] = $request->taskId;
        }
        if (!Utils::isUnset($request->useAlias)) {
            $body['useAlias'] = $request->useAlias;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'GetInstances',
            'version'     => 'yida_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/yida/processes/instances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetInstancesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据搜索条件获取流程表单实例详情
     *  *
     * @param GetInstancesRequest $request GetInstancesRequest
     *
     * @return GetInstancesResponse GetInstancesResponse
     */
    public function getInstances($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetInstancesHeaders([]);

        return $this->getInstancesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 新增表单实例
     *  *
     * @param SaveFormDataRequest $request SaveFormDataRequest
     * @param SaveFormDataHeaders $headers SaveFormDataHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveFormDataResponse SaveFormDataResponse
     */
    public function saveFormDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            $body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->useAlias)) {
            $body['useAlias'] = $request->useAlias;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SaveFormData',
            'version'     => 'yida_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/yida/forms/instances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 新增表单实例
     *  *
     * @param SaveFormDataRequest $request SaveFormDataRequest
     *
     * @return SaveFormDataResponse SaveFormDataResponse
     */
    public function saveFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveFormDataHeaders([]);

        return $this->saveFormDataWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据条件搜索表单实例 ID 列表
     *  *
     * @param string                      $appType
     * @param string                      $formUuid
     * @param SearchFormDataIdListRequest $request  SearchFormDataIdListRequest
     * @param SearchFormDataIdListHeaders $headers  SearchFormDataIdListHeaders
     * @param RuntimeOptions              $runtime  runtime options for this request RuntimeOptions
     *
     * @return SearchFormDataIdListResponse SearchFormDataIdListResponse
     */
    public function searchFormDataIdListWithOptions($appType, $formUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->pageNumber)) {
            $query['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $query['pageSize'] = $request->pageSize;
        }
        $body = [];
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            $body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            $body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->originatorId)) {
            $body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            $body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->useAlias)) {
            $body['useAlias'] = $request->useAlias;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SearchFormDataIdList',
            'version'     => 'yida_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/yida/forms/instances/ids/' . $appType . '/' . $formUuid . '',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchFormDataIdListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据条件搜索表单实例 ID 列表
     *  *
     * @param string                      $appType
     * @param string                      $formUuid
     * @param SearchFormDataIdListRequest $request  SearchFormDataIdListRequest
     *
     * @return SearchFormDataIdListResponse SearchFormDataIdListResponse
     */
    public function searchFormDataIdList($appType, $formUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDataIdListHeaders([]);

        return $this->searchFormDataIdListWithOptions($appType, $formUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 通过高级检索条件查询表单实例
     *  *
     * @param SearchFormDataSecondGenerationRequest $request SearchFormDataSecondGenerationRequest
     * @param SearchFormDataSecondGenerationHeaders $headers SearchFormDataSecondGenerationHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchFormDataSecondGenerationResponse SearchFormDataSecondGenerationResponse
     */
    public function searchFormDataSecondGenerationWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            $body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            $body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->orderConfigJson)) {
            $body['orderConfigJson'] = $request->orderConfigJson;
        }
        if (!Utils::isUnset($request->originatorId)) {
            $body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchCondition)) {
            $body['searchCondition'] = $request->searchCondition;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->useAlias)) {
            $body['useAlias'] = $request->useAlias;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SearchFormDataSecondGeneration',
            'version'     => 'yida_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/yida/forms/instances/advances/queryAll',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchFormDataSecondGenerationResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 通过高级检索条件查询表单实例
     *  *
     * @param SearchFormDataSecondGenerationRequest $request SearchFormDataSecondGenerationRequest
     *
     * @return SearchFormDataSecondGenerationResponse SearchFormDataSecondGenerationResponse
     */
    public function searchFormDataSecondGeneration($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDataSecondGenerationHeaders([]);

        return $this->searchFormDataSecondGenerationWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据条件搜索表单实例详情列表
     *  *
     * @param SearchFormDatasRequest $request SearchFormDatasRequest
     * @param SearchFormDatasHeaders $headers SearchFormDatasHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchFormDatasResponse SearchFormDatasResponse
     */
    public function searchFormDatasWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->createFromTimeGMT)) {
            $body['createFromTimeGMT'] = $request->createFromTimeGMT;
        }
        if (!Utils::isUnset($request->createToTimeGMT)) {
            $body['createToTimeGMT'] = $request->createToTimeGMT;
        }
        if (!Utils::isUnset($request->currentPage)) {
            $body['currentPage'] = $request->currentPage;
        }
        if (!Utils::isUnset($request->dynamicOrder)) {
            $body['dynamicOrder'] = $request->dynamicOrder;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->modifiedFromTimeGMT)) {
            $body['modifiedFromTimeGMT'] = $request->modifiedFromTimeGMT;
        }
        if (!Utils::isUnset($request->modifiedToTimeGMT)) {
            $body['modifiedToTimeGMT'] = $request->modifiedToTimeGMT;
        }
        if (!Utils::isUnset($request->originatorId)) {
            $body['originatorId'] = $request->originatorId;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->searchFieldJson)) {
            $body['searchFieldJson'] = $request->searchFieldJson;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->useAlias)) {
            $body['useAlias'] = $request->useAlias;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'SearchFormDatas',
            'version'     => 'yida_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/yida/forms/instances/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchFormDatasResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据条件搜索表单实例详情列表
     *  *
     * @param SearchFormDatasRequest $request SearchFormDatasRequest
     *
     * @return SearchFormDatasResponse SearchFormDatasResponse
     */
    public function searchFormDatas($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchFormDatasHeaders([]);

        return $this->searchFormDatasWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 发起新的流程实例
     *  *
     * @param StartInstanceRequest $request StartInstanceRequest
     * @param StartInstanceHeaders $headers StartInstanceHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return StartInstanceResponse StartInstanceResponse
     */
    public function startInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->departmentId)) {
            $body['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->formDataJson)) {
            $body['formDataJson'] = $request->formDataJson;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->processCode)) {
            $body['processCode'] = $request->processCode;
        }
        if (!Utils::isUnset($request->processData)) {
            $body['processData'] = $request->processData;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->useAlias)) {
            $body['useAlias'] = $request->useAlias;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'StartInstance',
            'version'     => 'yida_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/yida/processes/instances/start',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return StartInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 发起新的流程实例
     *  *
     * @param StartInstanceRequest $request StartInstanceRequest
     *
     * @return StartInstanceResponse StartInstanceResponse
     */
    public function startInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new StartInstanceHeaders([]);

        return $this->startInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 更新表单实例
     *  *
     * @param UpdateFormDataRequest $request UpdateFormDataRequest
     * @param UpdateFormDataHeaders $headers UpdateFormDataHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateFormDataResponse UpdateFormDataResponse
     */
    public function updateFormDataWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->appType)) {
            $body['appType'] = $request->appType;
        }
        if (!Utils::isUnset($request->formInstanceId)) {
            $body['formInstanceId'] = $request->formInstanceId;
        }
        if (!Utils::isUnset($request->formUuid)) {
            $body['formUuid'] = $request->formUuid;
        }
        if (!Utils::isUnset($request->language)) {
            $body['language'] = $request->language;
        }
        if (!Utils::isUnset($request->systemToken)) {
            $body['systemToken'] = $request->systemToken;
        }
        if (!Utils::isUnset($request->updateFormDataJson)) {
            $body['updateFormDataJson'] = $request->updateFormDataJson;
        }
        if (!Utils::isUnset($request->useAlias)) {
            $body['useAlias'] = $request->useAlias;
        }
        if (!Utils::isUnset($request->useLatestVersion)) {
            $body['useLatestVersion'] = $request->useLatestVersion;
        }
        if (!Utils::isUnset($request->userId)) {
            $body['userId'] = $request->userId;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'UpdateFormData',
            'version'     => 'yida_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/yida/forms/instances',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'none',
        ]);

        return UpdateFormDataResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 更新表单实例
     *  *
     * @param UpdateFormDataRequest $request UpdateFormDataRequest
     *
     * @return UpdateFormDataResponse UpdateFormDataResponse
     */
    public function updateFormData($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateFormDataHeaders([]);

        return $this->updateFormDataWithOptions($request, $headers, $runtime);
    }
}
