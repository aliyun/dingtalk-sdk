<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetDeptsByOrgIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetDeptsByOrgIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetDeptsByOrgIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetEmpsByOrgIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetEmpsByOrgIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetEmpsByOrgIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectGrayHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectGrayRequest;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectGrayResponse;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectSourceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTbProjectSourceResponse;
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
     * @param GetTbProjectGrayRequest $request
     *
     * @return GetTbProjectGrayResponse
     */
    public function getTbProjectGray($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTbProjectGrayHeaders([]);

        return $this->getTbProjectGrayWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTbProjectGrayRequest $request
     * @param GetTbProjectGrayHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return GetTbProjectGrayResponse
     */
    public function getTbProjectGrayWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->label)) {
            @$body['label'] = $request->label;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            @$realHeaders['dingAccessTokenType'] = $headers->dingAccessTokenType;
        }
        if (!Utils::isUnset($headers->dingSuiteKey)) {
            @$realHeaders['dingSuiteKey'] = $headers->dingSuiteKey;
        }
        if (!Utils::isUnset($headers->dingIsvOrgId)) {
            @$realHeaders['dingIsvOrgId'] = $headers->dingIsvOrgId;
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            @$realHeaders['dingOrgId'] = $headers->dingOrgId;
        }
        if (!Utils::isUnset($headers->dingCorpId)) {
            @$realHeaders['dingCorpId'] = $headers->dingCorpId;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return GetTbProjectGrayResponse::fromMap($this->doROARequest('GetTbProjectGray', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/projects/gray', 'json', $req, $runtime));
    }

    /**
     * @param GetDeptsByOrgIdRequest $request
     *
     * @return GetDeptsByOrgIdResponse
     */
    public function getDeptsByOrgId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDeptsByOrgIdHeaders([]);

        return $this->getDeptsByOrgIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetDeptsByOrgIdRequest $request
     * @param GetDeptsByOrgIdHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return GetDeptsByOrgIdResponse
     */
    public function getDeptsByOrgIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            @$realHeaders['dingAccessTokenType'] = $headers->dingAccessTokenType;
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            @$realHeaders['dingOrgId'] = $headers->dingOrgId;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetDeptsByOrgIdResponse::fromMap($this->doROARequest('GetDeptsByOrgId', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/orgs/depts', 'json', $req, $runtime));
    }

    /**
     * @return GetTbProjectSourceResponse
     */
    public function getTbProjectSource()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTbProjectSourceHeaders([]);

        return $this->getTbProjectSourceWithOptions($headers, $runtime);
    }

    /**
     * @param GetTbProjectSourceHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return GetTbProjectSourceResponse
     */
    public function getTbProjectSourceWithOptions($headers, $runtime)
    {
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            @$realHeaders['dingOrgId'] = $headers->dingOrgId;
        }
        if (!Utils::isUnset($headers->dingIsvOrgId)) {
            @$realHeaders['dingIsvOrgId'] = $headers->dingIsvOrgId;
        }
        if (!Utils::isUnset($headers->dingCorpId)) {
            @$realHeaders['dingCorpId'] = $headers->dingCorpId;
        }
        if (!Utils::isUnset($headers->dingSuiteKey)) {
            @$realHeaders['dingSuiteKey'] = $headers->dingSuiteKey;
        }
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            @$realHeaders['dingAccessTokenType'] = $headers->dingAccessTokenType;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
        ]);

        return GetTbProjectSourceResponse::fromMap($this->doROARequest('GetTbProjectSource', 'project_1.0', 'HTTP', 'POST', 'AK', '/v1.0/project/projects/source', 'json', $req, $runtime));
    }

    /**
     * @param GetEmpsByOrgIdRequest $request
     *
     * @return GetEmpsByOrgIdResponse
     */
    public function getEmpsByOrgId($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetEmpsByOrgIdHeaders([]);

        return $this->getEmpsByOrgIdWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetEmpsByOrgIdRequest $request
     * @param GetEmpsByOrgIdHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return GetEmpsByOrgIdResponse
     */
    public function getEmpsByOrgIdWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->needDept)) {
            @$query['needDept'] = $request->needDept;
        }
        $realHeaders = [];
        if (!Utils::isUnset($headers->commonHeaders)) {
            $realHeaders = $headers->commonHeaders;
        }
        if (!Utils::isUnset($headers->dingAccessTokenType)) {
            @$realHeaders['dingAccessTokenType'] = $headers->dingAccessTokenType;
        }
        if (!Utils::isUnset($headers->dingOrgId)) {
            @$realHeaders['dingOrgId'] = $headers->dingOrgId;
        }
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = $headers->xAcsDingtalkAccessToken;
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return GetEmpsByOrgIdResponse::fromMap($this->doROARequest('GetEmpsByOrgId', 'project_1.0', 'HTTP', 'GET', 'AK', '/v1.0/project/orgs/employees', 'json', $req, $runtime));
    }
}
