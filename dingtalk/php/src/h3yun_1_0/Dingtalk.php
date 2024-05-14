<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\BatchInsertBizObjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\BatchInsertBizObjectRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\BatchInsertBizObjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\CancelProcessInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\CancelProcessInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\CancelProcessInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\CreateBizObjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\CreateBizObjectRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\CreateBizObjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\CreateProcessesInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\CreateProcessesInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\CreateProcessesInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\DeleteBizObjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\DeleteBizObjectRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\DeleteBizObjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\DeleteProcessesInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\DeleteProcessesInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\DeleteProcessesInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetAppsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetAppsRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetAppsResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetAttachmentTemporaryUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetAttachmentTemporaryUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetAttachmentTemporaryUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetOrganizationsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetOrganizationsRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetOrganizationsResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetRolesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetRolesResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetRoleUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetRoleUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetRoleUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetUploadUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetUploadUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetUploadUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetUsersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetUsersRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetUsersResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizFieldsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizFieldsRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizFieldsResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizObjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizObjectRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizObjectResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizObjectsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizObjectsRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\LoadBizObjectsResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryAppFunctionNodesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryAppFunctionNodesRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryAppFunctionNodesResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesWorkItemsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesWorkItemsRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\QueryProcessesWorkItemsResponse;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\UpdateBizObjectHeaders;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\UpdateBizObjectRequest;
use AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\UpdateBizObjectResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\GatewayDingTalk\Client as DarabonbaGatewayDingTalkClient;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\Models\Params;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    protected $_client;

    public function __construct($config)
    {
        parent::__construct($config);
        $this->_client       = new DarabonbaGatewayDingTalkClient();
        $this->_spi          = $this->_client;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 批量创建表单业务对象数据
     *  *
     * @param BatchInsertBizObjectRequest $request BatchInsertBizObjectRequest
     * @param BatchInsertBizObjectHeaders $headers BatchInsertBizObjectHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchInsertBizObjectResponse BatchInsertBizObjectResponse
     */
    public function batchInsertBizObjectWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizObjectJsonArray)) {
            $body['bizObjectJsonArray'] = $request->bizObjectJsonArray;
        }
        if (!Utils::isUnset($request->isDraft)) {
            $body['isDraft'] = $request->isDraft;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->schemaCode)) {
            $body['schemaCode'] = $request->schemaCode;
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
            'action'      => 'BatchInsertBizObject',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/forms/instances/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchInsertBizObjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量创建表单业务对象数据
     *  *
     * @param BatchInsertBizObjectRequest $request BatchInsertBizObjectRequest
     *
     * @return BatchInsertBizObjectResponse BatchInsertBizObjectResponse
     */
    public function batchInsertBizObject($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchInsertBizObjectHeaders([]);

        return $this->batchInsertBizObjectWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 取消流程实例
     *  *
     * @param CancelProcessInstanceRequest $request CancelProcessInstanceRequest
     * @param CancelProcessInstanceHeaders $headers CancelProcessInstanceHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return CancelProcessInstanceResponse CancelProcessInstanceResponse
     */
    public function cancelProcessInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->processInstanceId)) {
            $body['processInstanceId'] = $request->processInstanceId;
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
            'action'      => 'CancelProcessInstance',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/processes/instances/cancel',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CancelProcessInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 取消流程实例
     *  *
     * @param CancelProcessInstanceRequest $request CancelProcessInstanceRequest
     *
     * @return CancelProcessInstanceResponse CancelProcessInstanceResponse
     */
    public function cancelProcessInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CancelProcessInstanceHeaders([]);

        return $this->cancelProcessInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建单条表单业务对象实例
     *  *
     * @param CreateBizObjectRequest $request CreateBizObjectRequest
     * @param CreateBizObjectHeaders $headers CreateBizObjectHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateBizObjectResponse CreateBizObjectResponse
     */
    public function createBizObjectWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizObjectJson)) {
            $body['bizObjectJson'] = $request->bizObjectJson;
        }
        if (!Utils::isUnset($request->isDraft)) {
            $body['isDraft'] = $request->isDraft;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->schemaCode)) {
            $body['schemaCode'] = $request->schemaCode;
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
            'action'      => 'CreateBizObject',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/forms/instances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateBizObjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建单条表单业务对象实例
     *  *
     * @param CreateBizObjectRequest $request CreateBizObjectRequest
     *
     * @return CreateBizObjectResponse CreateBizObjectResponse
     */
    public function createBizObject($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateBizObjectHeaders([]);

        return $this->createBizObjectWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建流程实例
     *  *
     * @param CreateProcessesInstanceRequest $request CreateProcessesInstanceRequest
     * @param CreateProcessesInstanceHeaders $headers CreateProcessesInstanceHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateProcessesInstanceResponse CreateProcessesInstanceResponse
     */
    public function createProcessesInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizObjectId)) {
            $body['bizObjectId'] = $request->bizObjectId;
        }
        if (!Utils::isUnset($request->opUserId)) {
            $body['opUserId'] = $request->opUserId;
        }
        if (!Utils::isUnset($request->schemaCode)) {
            $body['schemaCode'] = $request->schemaCode;
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
            'action'      => 'CreateProcessesInstance',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/processes/instances',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateProcessesInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 创建流程实例
     *  *
     * @param CreateProcessesInstanceRequest $request CreateProcessesInstanceRequest
     *
     * @return CreateProcessesInstanceResponse CreateProcessesInstanceResponse
     */
    public function createProcessesInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateProcessesInstanceHeaders([]);

        return $this->createProcessesInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除表单业务对象实例
     *  *
     * @param DeleteBizObjectRequest $request DeleteBizObjectRequest
     * @param DeleteBizObjectHeaders $headers DeleteBizObjectHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteBizObjectResponse DeleteBizObjectResponse
     */
    public function deleteBizObjectWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizObjectId)) {
            $query['bizObjectId'] = $request->bizObjectId;
        }
        if (!Utils::isUnset($request->schemaCode)) {
            $query['schemaCode'] = $request->schemaCode;
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
            'action'      => 'DeleteBizObject',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/forms/instances',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteBizObjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除表单业务对象实例
     *  *
     * @param DeleteBizObjectRequest $request DeleteBizObjectRequest
     *
     * @return DeleteBizObjectResponse DeleteBizObjectResponse
     */
    public function deleteBizObject($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteBizObjectHeaders([]);

        return $this->deleteBizObjectWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除流程实例
     *  *
     * @param DeleteProcessesInstanceRequest $request DeleteProcessesInstanceRequest
     * @param DeleteProcessesInstanceHeaders $headers DeleteProcessesInstanceHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteProcessesInstanceResponse DeleteProcessesInstanceResponse
     */
    public function deleteProcessesInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isAutoUpdateBizObject)) {
            $query['isAutoUpdateBizObject'] = $request->isAutoUpdateBizObject;
        }
        if (!Utils::isUnset($request->processInstanceId)) {
            $query['processInstanceId'] = $request->processInstanceId;
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
            'action'      => 'DeleteProcessesInstance',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/processes/instances',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteProcessesInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 删除流程实例
     *  *
     * @param DeleteProcessesInstanceRequest $request DeleteProcessesInstanceRequest
     *
     * @return DeleteProcessesInstanceResponse DeleteProcessesInstanceResponse
     */
    public function deleteProcessesInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteProcessesInstanceHeaders([]);

        return $this->deleteProcessesInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取应用数据
     *  *
     * @param GetAppsRequest $request GetAppsRequest
     * @param GetAppsHeaders $headers GetAppsHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAppsResponse GetAppsResponse
     */
    public function getAppsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->queryType)) {
            $body['queryType'] = $request->queryType;
        }
        if (!Utils::isUnset($request->values)) {
            $body['values'] = $request->values;
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
            'action'      => 'GetApps',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/apps/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAppsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取应用数据
     *  *
     * @param GetAppsRequest $request GetAppsRequest
     *
     * @return GetAppsResponse GetAppsResponse
     */
    public function getApps($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAppsHeaders([]);

        return $this->getAppsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取附件临时免登地址
     *  *
     * @param GetAttachmentTemporaryUrlRequest $request GetAttachmentTemporaryUrlRequest
     * @param GetAttachmentTemporaryUrlHeaders $headers GetAttachmentTemporaryUrlHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return GetAttachmentTemporaryUrlResponse GetAttachmentTemporaryUrlResponse
     */
    public function getAttachmentTemporaryUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->attachmentId)) {
            $query['attachmentId'] = $request->attachmentId;
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
            'action'      => 'GetAttachmentTemporaryUrl',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/attachments/temporaryUrls',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetAttachmentTemporaryUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取附件临时免登地址
     *  *
     * @param GetAttachmentTemporaryUrlRequest $request GetAttachmentTemporaryUrlRequest
     *
     * @return GetAttachmentTemporaryUrlResponse GetAttachmentTemporaryUrlResponse
     */
    public function getAttachmentTemporaryUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetAttachmentTemporaryUrlHeaders([]);

        return $this->getAttachmentTemporaryUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取组织数据
     *  *
     * @param GetOrganizationsRequest $request GetOrganizationsRequest
     * @param GetOrganizationsHeaders $headers GetOrganizationsHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return GetOrganizationsResponse GetOrganizationsResponse
     */
    public function getOrganizationsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->departmentId)) {
            $query['departmentId'] = $request->departmentId;
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
            'action'      => 'GetOrganizations',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/departments',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetOrganizationsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取组织数据
     *  *
     * @param GetOrganizationsRequest $request GetOrganizationsRequest
     *
     * @return GetOrganizationsResponse GetOrganizationsResponse
     */
    public function getOrganizations($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetOrganizationsHeaders([]);

        return $this->getOrganizationsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取角色用户信息
     *  *
     * @param GetRoleUsersRequest $request GetRoleUsersRequest
     * @param GetRoleUsersHeaders $headers GetRoleUsersHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetRoleUsersResponse GetRoleUsersResponse
     */
    public function getRoleUsersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->roleId)) {
            $query['roleId'] = $request->roleId;
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
            'action'      => 'GetRoleUsers',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/roles/roleUsers',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRoleUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取角色用户信息
     *  *
     * @param GetRoleUsersRequest $request GetRoleUsersRequest
     *
     * @return GetRoleUsersResponse GetRoleUsersResponse
     */
    public function getRoleUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRoleUsersHeaders([]);

        return $this->getRoleUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取角色数据
     *  *
     * @param GetRolesHeaders $headers GetRolesHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetRolesResponse GetRolesResponse
     */
    public function getRolesWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            $realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);
        $params = new Params([
            'action'      => 'GetRoles',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/roles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetRolesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取角色数据
     *  *
     * @return GetRolesResponse GetRolesResponse
     */
    public function getRoles()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetRolesHeaders([]);

        return $this->getRolesWithOptions($headers, $runtime);
    }

    /**
     * @summary 获取文件上传地址
     *  *
     * @param GetUploadUrlRequest $request GetUploadUrlRequest
     * @param GetUploadUrlHeaders $headers GetUploadUrlHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUploadUrlResponse GetUploadUrlResponse
     */
    public function getUploadUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizObjectId)) {
            $query['bizObjectId'] = $request->bizObjectId;
        }
        if (!Utils::isUnset($request->fieldName)) {
            $query['fieldName'] = $request->fieldName;
        }
        if (!Utils::isUnset($request->isOverwrite)) {
            $query['isOverwrite'] = $request->isOverwrite;
        }
        if (!Utils::isUnset($request->schemaCode)) {
            $query['schemaCode'] = $request->schemaCode;
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
            'action'      => 'GetUploadUrl',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/attachments/uploadUrls',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUploadUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取文件上传地址
     *  *
     * @param GetUploadUrlRequest $request GetUploadUrlRequest
     *
     * @return GetUploadUrlResponse GetUploadUrlResponse
     */
    public function getUploadUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUploadUrlHeaders([]);

        return $this->getUploadUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取用户数据
     *  *
     * @param GetUsersRequest $request GetUsersRequest
     * @param GetUsersHeaders $headers GetUsersHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUsersResponse GetUsersResponse
     */
    public function getUsersWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->departmentId)) {
            $query['departmentId'] = $request->departmentId;
        }
        if (!Utils::isUnset($request->isRecursive)) {
            $query['isRecursive'] = $request->isRecursive;
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
            'action'      => 'GetUsers',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/users',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUsersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取用户数据
     *  *
     * @param GetUsersRequest $request GetUsersRequest
     *
     * @return GetUsersResponse GetUsersResponse
     */
    public function getUsers($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUsersHeaders([]);

        return $this->getUsersWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取表单业务字段信息
     *  *
     * @param LoadBizFieldsRequest $request LoadBizFieldsRequest
     * @param LoadBizFieldsHeaders $headers LoadBizFieldsHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return LoadBizFieldsResponse LoadBizFieldsResponse
     */
    public function loadBizFieldsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->schemaCode)) {
            $query['schemaCode'] = $request->schemaCode;
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
            'action'      => 'LoadBizFields',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/forms/loadBizFields',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return LoadBizFieldsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取表单业务字段信息
     *  *
     * @param LoadBizFieldsRequest $request LoadBizFieldsRequest
     *
     * @return LoadBizFieldsResponse LoadBizFieldsResponse
     */
    public function loadBizFields($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LoadBizFieldsHeaders([]);

        return $this->loadBizFieldsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取单条表单业务对象实例
     *  *
     * @param LoadBizObjectRequest $request LoadBizObjectRequest
     * @param LoadBizObjectHeaders $headers LoadBizObjectHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return LoadBizObjectResponse LoadBizObjectResponse
     */
    public function loadBizObjectWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizObjectId)) {
            $query['bizObjectId'] = $request->bizObjectId;
        }
        if (!Utils::isUnset($request->schemaCode)) {
            $query['schemaCode'] = $request->schemaCode;
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
            'action'      => 'LoadBizObject',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/forms/instances/loadInstances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return LoadBizObjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取单条表单业务对象实例
     *  *
     * @param LoadBizObjectRequest $request LoadBizObjectRequest
     *
     * @return LoadBizObjectResponse LoadBizObjectResponse
     */
    public function loadBizObject($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LoadBizObjectHeaders([]);

        return $this->loadBizObjectWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询表单实例列表
     *  *
     * @param LoadBizObjectsRequest $request LoadBizObjectsRequest
     * @param LoadBizObjectsHeaders $headers LoadBizObjectsHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return LoadBizObjectsResponse LoadBizObjectsResponse
     */
    public function loadBizObjectsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->matcherJson)) {
            $body['matcherJson'] = $request->matcherJson;
        }
        if (!Utils::isUnset($request->pageNumber)) {
            $body['pageNumber'] = $request->pageNumber;
        }
        if (!Utils::isUnset($request->pageSize)) {
            $body['pageSize'] = $request->pageSize;
        }
        if (!Utils::isUnset($request->returnFields)) {
            $body['returnFields'] = $request->returnFields;
        }
        if (!Utils::isUnset($request->schemaCode)) {
            $body['schemaCode'] = $request->schemaCode;
        }
        if (!Utils::isUnset($request->sortByFields)) {
            $body['sortByFields'] = $request->sortByFields;
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
            'action'      => 'LoadBizObjects',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/forms/instances/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return LoadBizObjectsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询表单实例列表
     *  *
     * @param LoadBizObjectsRequest $request LoadBizObjectsRequest
     *
     * @return LoadBizObjectsResponse LoadBizObjectsResponse
     */
    public function loadBizObjects($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new LoadBizObjectsHeaders([]);

        return $this->loadBizObjectsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取应用的功能节点信息
     *  *
     * @param QueryAppFunctionNodesRequest $request QueryAppFunctionNodesRequest
     * @param QueryAppFunctionNodesHeaders $headers QueryAppFunctionNodesHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryAppFunctionNodesResponse QueryAppFunctionNodesResponse
     */
    public function queryAppFunctionNodesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->appCode)) {
            $query['appCode'] = $request->appCode;
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
            'action'      => 'QueryAppFunctionNodes',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/apps/functionNodes',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryAppFunctionNodesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取应用的功能节点信息
     *  *
     * @param QueryAppFunctionNodesRequest $request QueryAppFunctionNodesRequest
     *
     * @return QueryAppFunctionNodesResponse QueryAppFunctionNodesResponse
     */
    public function queryAppFunctionNodes($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryAppFunctionNodesHeaders([]);

        return $this->queryAppFunctionNodesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取流程实例
     *  *
     * @param QueryProcessesInstanceRequest $request QueryProcessesInstanceRequest
     * @param QueryProcessesInstanceHeaders $headers QueryProcessesInstanceHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryProcessesInstanceResponse QueryProcessesInstanceResponse
     */
    public function queryProcessesInstanceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizObjectId)) {
            $query['bizObjectId'] = $request->bizObjectId;
        }
        if (!Utils::isUnset($request->schemaCode)) {
            $query['schemaCode'] = $request->schemaCode;
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
            'action'      => 'QueryProcessesInstance',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/processes/instances',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryProcessesInstanceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取流程实例
     *  *
     * @param QueryProcessesInstanceRequest $request QueryProcessesInstanceRequest
     *
     * @return QueryProcessesInstanceResponse QueryProcessesInstanceResponse
     */
    public function queryProcessesInstance($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryProcessesInstanceHeaders([]);

        return $this->queryProcessesInstanceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取流程实例节点工作项
     *  *
     * @param QueryProcessesWorkItemsRequest $request QueryProcessesWorkItemsRequest
     * @param QueryProcessesWorkItemsHeaders $headers QueryProcessesWorkItemsHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryProcessesWorkItemsResponse QueryProcessesWorkItemsResponse
     */
    public function queryProcessesWorkItemsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->processInstanceId)) {
            $query['processInstanceId'] = $request->processInstanceId;
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
            'action'      => 'QueryProcessesWorkItems',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/processes/workItems',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryProcessesWorkItemsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取流程实例节点工作项
     *  *
     * @param QueryProcessesWorkItemsRequest $request QueryProcessesWorkItemsRequest
     *
     * @return QueryProcessesWorkItemsResponse QueryProcessesWorkItemsResponse
     */
    public function queryProcessesWorkItems($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryProcessesWorkItemsHeaders([]);

        return $this->queryProcessesWorkItemsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 修改表单业务对象数据
     *  *
     * @param UpdateBizObjectRequest $request UpdateBizObjectRequest
     * @param UpdateBizObjectHeaders $headers UpdateBizObjectHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateBizObjectResponse UpdateBizObjectResponse
     */
    public function updateBizObjectWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->bizObjectId)) {
            $body['bizObjectId'] = $request->bizObjectId;
        }
        if (!Utils::isUnset($request->bizObjectJson)) {
            $body['bizObjectJson'] = $request->bizObjectJson;
        }
        if (!Utils::isUnset($request->schemaCode)) {
            $body['schemaCode'] = $request->schemaCode;
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
            'action'      => 'UpdateBizObject',
            'version'     => 'h3yun_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/h3yun/forms/instances',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateBizObjectResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 修改表单业务对象数据
     *  *
     * @param UpdateBizObjectRequest $request UpdateBizObjectRequest
     *
     * @return UpdateBizObjectResponse UpdateBizObjectResponse
     */
    public function updateBizObject($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateBizObjectHeaders([]);

        return $this->updateBizObjectWithOptions($request, $headers, $runtime);
    }
}
