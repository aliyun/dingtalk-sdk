<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\GrantHonorHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\GrantHonorRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\GrantHonorResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgHonorsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgHonorsRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryOrgHonorsResponse;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryUserHonorsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryUserHonorsRequest;
use AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryUserHonorsResponse;
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
     * @param string            $honorId
     * @param GrantHonorRequest $request
     *
     * @return GrantHonorResponse
     */
    public function grantHonor($honorId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GrantHonorHeaders([]);

        return $this->grantHonorWithOptions($honorId, $request, $headers, $runtime);
    }

    /**
     * @param string            $honorId
     * @param GrantHonorRequest $request
     * @param GrantHonorHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return GrantHonorResponse
     */
    public function grantHonorWithOptions($honorId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $honorId = OpenApiUtilClient::getEncodeParam($honorId);
        $body    = [];
        if (!Utils::isUnset($request->expirationTime)) {
            @$body['expirationTime'] = $request->expirationTime;
        }
        if (!Utils::isUnset($request->grantReason)) {
            @$body['grantReason'] = $request->grantReason;
        }
        if (!Utils::isUnset($request->granterName)) {
            @$body['granterName'] = $request->granterName;
        }
        if (!Utils::isUnset($request->noticeAnnouncer)) {
            @$body['noticeAnnouncer'] = $request->noticeAnnouncer;
        }
        if (!Utils::isUnset($request->noticeSingle)) {
            @$body['noticeSingle'] = $request->noticeSingle;
        }
        if (!Utils::isUnset($request->receiverUserIds)) {
            @$body['receiverUserIds'] = $request->receiverUserIds;
        }
        if (!Utils::isUnset($request->senderUserId)) {
            @$body['senderUserId'] = $request->senderUserId;
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

        return GrantHonorResponse::fromMap($this->doROARequest('GrantHonor', 'orgCulture_1.0', 'HTTP', 'POST', 'AK', '/v1.0/orgCulture/honors/' . $honorId . '/grant', 'json', $req, $runtime));
    }

    /**
     * @param QueryOrgHonorsRequest $request
     *
     * @return QueryOrgHonorsResponse
     */
    public function queryOrgHonors($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryOrgHonorsHeaders([]);

        return $this->queryOrgHonorsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param QueryOrgHonorsRequest $request
     * @param QueryOrgHonorsHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryOrgHonorsResponse
     */
    public function queryOrgHonorsWithOptions($request, $headers, $runtime)
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
        if (!Utils::isUnset($headers->xAcsDingtalkAccessToken)) {
            @$realHeaders['x-acs-dingtalk-access-token'] = Utils::toJSONString($headers->xAcsDingtalkAccessToken);
        }
        $req = new OpenApiRequest([
            'headers' => $realHeaders,
            'query'   => OpenApiUtilClient::query($query),
        ]);

        return QueryOrgHonorsResponse::fromMap($this->doROARequest('QueryOrgHonors', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', '/v1.0/orgCulture/organizations/honors', 'json', $req, $runtime));
    }

    /**
     * @param string                 $userId
     * @param QueryUserHonorsRequest $request
     *
     * @return QueryUserHonorsResponse
     */
    public function queryUserHonors($userId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryUserHonorsHeaders([]);

        return $this->queryUserHonorsWithOptions($userId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $userId
     * @param QueryUserHonorsRequest $request
     * @param QueryUserHonorsHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryUserHonorsResponse
     */
    public function queryUserHonorsWithOptions($userId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $userId = OpenApiUtilClient::getEncodeParam($userId);
        $query  = [];
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

        return QueryUserHonorsResponse::fromMap($this->doROARequest('QueryUserHonors', 'orgCulture_1.0', 'HTTP', 'GET', 'AK', '/v1.0/orgCulture/honors/users/' . $userId . '', 'json', $req, $runtime));
    }
}
