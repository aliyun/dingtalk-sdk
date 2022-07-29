<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vswform_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\GetFormInstanceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\GetFormInstanceRequest;
use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\GetFormInstanceResponse;
use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormInstancesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormInstancesRequest;
use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormInstancesResponse;
use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormSchemasByCreatorHeaders;
use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormSchemasByCreatorRequest;
use AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormSchemasByCreatorResponse;
use AlibabaCloud\Tea\Utils\Utils;
use AlibabaCloud\Tea\Utils\Utils\RuntimeOptions;
use Darabonba\OpenApi\Models\OpenApiRequest;
use Darabonba\OpenApi\OpenApiClient;

class Dingtalk extends OpenApiClient
{
    public function __construct($config)
    {
        parent::__construct($config);
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @param string                 $formInstanceId
     * @param GetFormInstanceRequest $request
     *
     * @return GetFormInstanceResponse
     */
    public function getFormInstance($formInstanceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetFormInstanceHeaders([]);

        return $this->getFormInstanceWithOptions($formInstanceId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $formInstanceId
     * @param GetFormInstanceRequest $request
     * @param GetFormInstanceHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetFormInstanceResponse
     */
    public function getFormInstanceWithOptions($formInstanceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $formInstanceId = OpenApiUtilClient::getEncodeParam($formInstanceId);
        $query          = [];
        if (!Utils::isUnset($request->bizType)) {
            @$query['bizType'] = $request->bizType;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetFormInstanceResponse::fromMap($this->doROARequest('GetFormInstance', 'swform_1.0', 'HTTP', 'GET', 'AK', '/v1.0/swform/instances/' . $formInstanceId . '', 'json', $req, $runtime));
    }

    /**
     * @param string                   $formCode
     * @param ListFormInstancesRequest $request
     *
     * @return ListFormInstancesResponse
     */
    public function listFormInstances($formCode, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListFormInstancesHeaders([]);

        return $this->listFormInstancesWithOptions($formCode, $request, $headers, $runtime);
    }

    /**
     * @param string                   $formCode
     * @param ListFormInstancesRequest $request
     * @param ListFormInstancesHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return ListFormInstancesResponse
     */
    public function listFormInstancesWithOptions($formCode, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $formCode = OpenApiUtilClient::getEncodeParam($formCode);
        $query    = [];
        if (!Utils::isUnset($request->actionDate)) {
            @$query['actionDate'] = $request->actionDate;
        }
        if (!Utils::isUnset($request->bizType)) {
            @$query['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListFormInstancesResponse::fromMap($this->doROARequest('ListFormInstances', 'swform_1.0', 'HTTP', 'GET', 'AK', '/v1.0/swform/forms/' . $formCode . '/instances', 'json', $req, $runtime));
    }

    /**
     * @param ListFormSchemasByCreatorRequest $request
     *
     * @return ListFormSchemasByCreatorResponse
     */
    public function listFormSchemasByCreator($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListFormSchemasByCreatorHeaders([]);

        return $this->listFormSchemasByCreatorWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListFormSchemasByCreatorRequest $request
     * @param ListFormSchemasByCreatorHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return ListFormSchemasByCreatorResponse
     */
    public function listFormSchemasByCreatorWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->bizType)) {
            @$query['bizType'] = $request->bizType;
        }
        if (!Utils::isUnset($request->creator)) {
            @$query['creator'] = $request->creator;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return ListFormSchemasByCreatorResponse::fromMap($this->doROARequest('ListFormSchemasByCreator', 'swform_1.0', 'HTTP', 'GET', 'AK', '/v1.0/swform/users/forms', 'json', $req, $runtime));
    }
}
