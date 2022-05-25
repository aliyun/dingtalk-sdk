<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetSpaceDirectoriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetSpaceDirectoriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetSpaceDirectoriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\MoveDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\MoveDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\MoveDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QuerySpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QuerySpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QuerySpaceResponse;
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
     * @param string              $spaceId
     * @param CreateDentryRequest $request
     *
     * @return CreateDentryResponse
     */
    public function createDentry($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDentryHeaders([]);

        return $this->createDentryWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string              $spaceId
     * @param CreateDentryRequest $request
     * @param CreateDentryHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return CreateDentryResponse
     */
    public function createDentryWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $body    = [];
        if (!Utils::isUnset($request->dentryType)) {
            @$body['dentryType'] = $request->dentryType;
        }
        if (!Utils::isUnset($request->documentType)) {
            @$body['documentType'] = $request->documentType;
        }
        if (!Utils::isUnset($request->name)) {
            @$body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->parentDentryId)) {
            @$body['parentDentryId'] = $request->parentDentryId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return CreateDentryResponse::fromMap($this->doROARequest('CreateDentry', 'doc_2.0', 'HTTP', 'POST', 'AK', '/v2.0/doc/spaces/' . $spaceId . '/dentries', 'json', $req, $runtime));
    }

    /**
     * @param string                     $spaceId
     * @param GetSpaceDirectoriesRequest $request
     *
     * @return GetSpaceDirectoriesResponse
     */
    public function getSpaceDirectories($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSpaceDirectoriesHeaders([]);

        return $this->getSpaceDirectoriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string                     $spaceId
     * @param GetSpaceDirectoriesRequest $request
     * @param GetSpaceDirectoriesHeaders $headers
     * @param RuntimeOptions             $runtime
     *
     * @return GetSpaceDirectoriesResponse
     */
    public function getSpaceDirectoriesWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->dentryId)) {
            @$query['dentryId'] = $request->dentryId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            @$query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            @$query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
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

        return GetSpaceDirectoriesResponse::fromMap($this->doROARequest('GetSpaceDirectories', 'doc_2.0', 'HTTP', 'GET', 'AK', '/v2.0/doc/spaces/' . $spaceId . '/directories', 'json', $req, $runtime));
    }

    /**
     * @param string            $spaceId
     * @param string            $dentryId
     * @param MoveDentryRequest $request
     *
     * @return MoveDentryResponse
     */
    public function moveDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MoveDentryHeaders([]);

        return $this->moveDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string            $spaceId
     * @param string            $dentryId
     * @param MoveDentryRequest $request
     * @param MoveDentryHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return MoveDentryResponse
     */
    public function moveDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $body     = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->targetSpaceId)) {
            @$body['targetSpaceId'] = $request->targetSpaceId;
        }
        if (!Utils::isUnset($request->toNextDentryId)) {
            @$body['toNextDentryId'] = $request->toNextDentryId;
        }
        if (!Utils::isUnset($request->toParentDentryId)) {
            @$body['toParentDentryId'] = $request->toParentDentryId;
        }
        if (!Utils::isUnset($request->toPrevDentryId)) {
            @$body['toPrevDentryId'] = $request->toPrevDentryId;
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);

        return MoveDentryResponse::fromMap($this->doROARequest('MoveDentry', 'doc_2.0', 'HTTP', 'POST', 'AK', '/v2.0/doc/spaces/' . $spaceId . '/dentries/' . $dentryId . '/move', 'json', $req, $runtime));
    }

    /**
     * @param string             $spaceId
     * @param string             $dentryId
     * @param QueryDentryRequest $request
     *
     * @return QueryDentryResponse
     */
    public function queryDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDentryHeaders([]);

        return $this->queryDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string             $spaceId
     * @param string             $dentryId
     * @param QueryDentryRequest $request
     * @param QueryDentryHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return QueryDentryResponse
     */
    public function queryDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId  = OpenApiUtilClient::getEncodeParam($spaceId);
        $dentryId = OpenApiUtilClient::getEncodeParam($dentryId);
        $query    = [];
        if (!Utils::isUnset($request->includeSpace)) {
            @$query['includeSpace'] = $request->includeSpace;
        }
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
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

        return QueryDentryResponse::fromMap($this->doROARequest('QueryDentry', 'doc_2.0', 'HTTP', 'GET', 'AK', '/v2.0/doc/spaces/' . $spaceId . '/dentries/' . $dentryId . '', 'json', $req, $runtime));
    }

    /**
     * @param string            $spaceId
     * @param QuerySpaceRequest $request
     *
     * @return QuerySpaceResponse
     */
    public function querySpace($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySpaceHeaders([]);

        return $this->querySpaceWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string            $spaceId
     * @param QuerySpaceRequest $request
     * @param QuerySpaceHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return QuerySpaceResponse
     */
    public function querySpaceWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $spaceId = OpenApiUtilClient::getEncodeParam($spaceId);
        $query   = [];
        if (!Utils::isUnset($request->operatorId)) {
            @$query['operatorId'] = $request->operatorId;
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

        return QuerySpaceResponse::fromMap($this->doROARequest('QuerySpace', 'doc_2.0', 'HTTP', 'GET', 'AK', '/v2.0/doc/spaces/' . $spaceId . '', 'json', $req, $runtime));
    }
}
