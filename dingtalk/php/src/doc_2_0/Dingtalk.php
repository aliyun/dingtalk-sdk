<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\BatchDeleteRecentsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\BatchDeleteRecentsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\BatchDeleteRecentsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CopyDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CopyDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CopyDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CrossOrgMigrateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CrossOrgMigrateRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CrossOrgMigrateResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DeleteTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DeleteTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DeleteTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetSchemaHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetSchemaRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetSchemaResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetSpaceDirectoriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetSpaceDirectoriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetSpaceDirectoriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetStarInfoHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetStarInfoRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetStarInfoResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetTotalNumberOfDentriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetTotalNumberOfDentriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetTotalNumberOfDentriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetTotalNumberOfSpacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetTotalNumberOfSpacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetTotalNumberOfSpacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetUserInfoByOpenTokenHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetUserInfoByOpenTokenRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetUserInfoByOpenTokenResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListFeedsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListFeedsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListFeedsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListHotDocsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListHotDocsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListHotDocsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListRelatedSpaceTeamsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListRelatedSpaceTeamsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListRelatedSpaceTeamsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListRelatedTeamsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListRelatedTeamsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListRelatedTeamsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListSpaceSectionsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListSpaceSectionsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListSpaceSectionsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListStarsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListStarsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListStarsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListTeamMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListTeamMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListTeamMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\MarkStarHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\MarkStarRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\MarkStarResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\MoveDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\MoveDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\MoveDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\PinSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\PinSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\PinSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryItemByUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryItemByUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryItemByUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryMineSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryMineSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryRecentListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryRecentListRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryRecentListResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QuerySpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QuerySpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QuerySpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\RelatedSpacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\RelatedSpacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\RelatedSpacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\RemoveTeamMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\RemoveTeamMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\RemoveTeamMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\RenameDentryHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\RenameDentryRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\RenameDentryResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SaveTeamMembersHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SaveTeamMembersRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SaveTeamMembersResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UnmarkStarHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UnmarkStarRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UnmarkStarResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UnpinSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UnpinSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UnpinSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UpdateTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UpdateTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UpdateTeamResponse;
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
     * @param BatchDeleteRecentsRequest $request
     * @param BatchDeleteRecentsHeaders $headers
     * @param RuntimeOptions            $runtime
     *
     * @return BatchDeleteRecentsResponse
     */
    public function batchDeleteRecentsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->dentryUuids)) {
            $body['dentryUuids'] = $request->dentryUuids;
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
            'action'      => 'BatchDeleteRecents',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/dentries/recentRecords/batchRemove',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchDeleteRecentsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param BatchDeleteRecentsRequest $request
     *
     * @return BatchDeleteRecentsResponse
     */
    public function batchDeleteRecents($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchDeleteRecentsHeaders([]);

        return $this->batchDeleteRecentsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string            $spaceId
     * @param string            $dentryId
     * @param CopyDentryRequest $request
     * @param CopyDentryHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return CopyDentryResponse
     */
    public function copyDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->targetSpaceId)) {
            $body['targetSpaceId'] = $request->targetSpaceId;
        }
        if (!Utils::isUnset($request->toNextDentryId)) {
            $body['toNextDentryId'] = $request->toNextDentryId;
        }
        if (!Utils::isUnset($request->toParentDentryId)) {
            $body['toParentDentryId'] = $request->toParentDentryId;
        }
        if (!Utils::isUnset($request->toPrevDentryId)) {
            $body['toPrevDentryId'] = $request->toPrevDentryId;
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
            'action'      => 'CopyDentry',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/' . $spaceId . '/dentries/' . $dentryId . '/copy',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CopyDentryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string            $spaceId
     * @param string            $dentryId
     * @param CopyDentryRequest $request
     *
     * @return CopyDentryResponse
     */
    public function copyDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CopyDentryHeaders([]);

        return $this->copyDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
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
        $body = [];
        if (!Utils::isUnset($request->dentryType)) {
            $body['dentryType'] = $request->dentryType;
        }
        if (!Utils::isUnset($request->documentType)) {
            $body['documentType'] = $request->documentType;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->parentDentryId)) {
            $body['parentDentryId'] = $request->parentDentryId;
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
            'action'      => 'CreateDentry',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/' . $spaceId . '/dentries',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateDentryResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param CreateSpaceRequest $request
     * @param CreateSpaceHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return CreateSpaceResponse
     */
    public function createSpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->sectionId)) {
            $body['sectionId'] = $request->sectionId;
        }
        if (!Utils::isUnset($request->shareScope)) {
            $body['shareScope'] = $request->shareScope;
        }
        if (!Utils::isUnset($request->teamId)) {
            $body['teamId'] = $request->teamId;
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
            'action'      => 'CreateSpace',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateSpaceRequest $request
     *
     * @return CreateSpaceResponse
     */
    public function createSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSpaceHeaders([]);

        return $this->createSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CreateTeamRequest $request
     * @param CreateTeamHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return CreateTeamResponse
     */
    public function createTeamWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->cover)) {
            $body['cover'] = $request->cover;
        }
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->icon)) {
            $body['icon'] = $request->icon;
        }
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->teamType)) {
            $body['teamType'] = $request->teamType;
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
            'action'      => 'CreateTeam',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CreateTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CreateTeamRequest $request
     *
     * @return CreateTeamResponse
     */
    public function createTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTeamHeaders([]);

        return $this->createTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @param CrossOrgMigrateRequest $request
     * @param CrossOrgMigrateHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return CrossOrgMigrateResponse
     */
    public function crossOrgMigrateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
        }
        if (!Utils::isUnset($request->param)) {
            $body['param'] = $request->param;
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
            'action'      => 'CrossOrgMigrate',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/crossOrganizations/spaces/migrate',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CrossOrgMigrateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param CrossOrgMigrateRequest $request
     *
     * @return CrossOrgMigrateResponse
     */
    public function crossOrgMigrate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CrossOrgMigrateHeaders([]);

        return $this->crossOrgMigrateWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string            $teamId
     * @param DeleteTeamRequest $request
     * @param DeleteTeamHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return DeleteTeamResponse
     */
    public function deleteTeamWithOptions($teamId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'DeleteTeam',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams/' . $teamId . '',
            'method'      => 'DELETE',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DeleteTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string            $teamId
     * @param DeleteTeamRequest $request
     *
     * @return DeleteTeamResponse
     */
    public function deleteTeam($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTeamHeaders([]);

        return $this->deleteTeamWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @param string           $teamId
     * @param GetSchemaRequest $request
     * @param GetSchemaHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return GetSchemaResponse
     */
    public function getSchemaWithOptions($teamId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetSchema',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams/' . $teamId . '/schemas',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSchemaResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string           $teamId
     * @param GetSchemaRequest $request
     *
     * @return GetSchemaResponse
     */
    public function getSchema($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSchemaHeaders([]);

        return $this->getSchemaWithOptions($teamId, $request, $headers, $runtime);
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
        $query = [];
        if (!Utils::isUnset($request->dentryId)) {
            $query['dentryId'] = $request->dentryId;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetSpaceDirectories',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/' . $spaceId . '/directories',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetSpaceDirectoriesResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param string             $dentryUuid
     * @param GetStarInfoRequest $request
     * @param GetStarInfoHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return GetStarInfoResponse
     */
    public function getStarInfoWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetStarInfo',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/dentries/' . $dentryUuid . '/starInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetStarInfoResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string             $dentryUuid
     * @param GetStarInfoRequest $request
     *
     * @return GetStarInfoResponse
     */
    public function getStarInfo($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetStarInfoHeaders([]);

        return $this->getStarInfoWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @param string         $teamId
     * @param GetTeamRequest $request
     * @param GetTeamHeaders $headers
     * @param RuntimeOptions $runtime
     *
     * @return GetTeamResponse
     */
    public function getTeamWithOptions($teamId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetTeam',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams/' . $teamId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string         $teamId
     * @param GetTeamRequest $request
     *
     * @return GetTeamResponse
     */
    public function getTeam($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTeamHeaders([]);

        return $this->getTeamWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @param GetTotalNumberOfDentriesRequest $request
     * @param GetTotalNumberOfDentriesHeaders $headers
     * @param RuntimeOptions                  $runtime
     *
     * @return GetTotalNumberOfDentriesResponse
     */
    public function getTotalNumberOfDentriesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->includeFolder)) {
            $query['includeFolder'] = $request->includeFolder;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->spaceTypes)) {
            $query['spaceTypes'] = $request->spaceTypes;
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
            'action'      => 'GetTotalNumberOfDentries',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/statistics/dentryCounts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTotalNumberOfDentriesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetTotalNumberOfDentriesRequest $request
     *
     * @return GetTotalNumberOfDentriesResponse
     */
    public function getTotalNumberOfDentries($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTotalNumberOfDentriesHeaders([]);

        return $this->getTotalNumberOfDentriesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetTotalNumberOfSpacesRequest $request
     * @param GetTotalNumberOfSpacesHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetTotalNumberOfSpacesResponse
     */
    public function getTotalNumberOfSpacesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'GetTotalNumberOfSpaces',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/statistics/spaceCounts',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetTotalNumberOfSpacesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetTotalNumberOfSpacesRequest $request
     *
     * @return GetTotalNumberOfSpacesResponse
     */
    public function getTotalNumberOfSpaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTotalNumberOfSpacesHeaders([]);

        return $this->getTotalNumberOfSpacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param GetUserInfoByOpenTokenRequest $request
     * @param GetUserInfoByOpenTokenHeaders $headers
     * @param RuntimeOptions                $runtime
     *
     * @return GetUserInfoByOpenTokenResponse
     */
    public function getUserInfoByOpenTokenWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->docKey)) {
            $query['docKey'] = $request->docKey;
        }
        if (!Utils::isUnset($request->openToken)) {
            $query['openToken'] = $request->openToken;
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
            'action'      => 'GetUserInfoByOpenToken',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/userInfos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUserInfoByOpenTokenResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param GetUserInfoByOpenTokenRequest $request
     *
     * @return GetUserInfoByOpenTokenResponse
     */
    public function getUserInfoByOpenToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserInfoByOpenTokenHeaders([]);

        return $this->getUserInfoByOpenTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string           $teamId
     * @param ListFeedsRequest $request
     * @param ListFeedsHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return ListFeedsResponse
     */
    public function listFeedsWithOptions($teamId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->excludeFile)) {
            $query['excludeFile'] = $request->excludeFile;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'ListFeeds',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams/' . $teamId . '/feeds',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListFeedsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string           $teamId
     * @param ListFeedsRequest $request
     *
     * @return ListFeedsResponse
     */
    public function listFeeds($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListFeedsHeaders([]);

        return $this->listFeedsWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @param string             $teamId
     * @param ListHotDocsRequest $request
     * @param ListHotDocsHeaders $headers
     * @param RuntimeOptions     $runtime
     *
     * @return ListHotDocsResponse
     */
    public function listHotDocsWithOptions($teamId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'ListHotDocs',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams/' . $teamId . '/hotDocs',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListHotDocsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string             $teamId
     * @param ListHotDocsRequest $request
     *
     * @return ListHotDocsResponse
     */
    public function listHotDocs($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListHotDocsHeaders([]);

        return $this->listHotDocsWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @param ListPinSpacesRequest $request
     * @param ListPinSpacesHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return ListPinSpacesResponse
     */
    public function listPinSpacesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
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
            'action'      => 'ListPinSpaces',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/pinLists/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListPinSpacesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListPinSpacesRequest $request
     *
     * @return ListPinSpacesResponse
     */
    public function listPinSpaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListPinSpacesHeaders([]);

        return $this->listPinSpacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListRelatedSpaceTeamsRequest $request
     * @param ListRelatedSpaceTeamsHeaders $headers
     * @param RuntimeOptions               $runtime
     *
     * @return ListRelatedSpaceTeamsResponse
     */
    public function listRelatedSpaceTeamsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
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
            'action'      => 'ListRelatedSpaceTeams',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams/relations/spaceTeams',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListRelatedSpaceTeamsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListRelatedSpaceTeamsRequest $request
     *
     * @return ListRelatedSpaceTeamsResponse
     */
    public function listRelatedSpaceTeams($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListRelatedSpaceTeamsHeaders([]);

        return $this->listRelatedSpaceTeamsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param ListRelatedTeamsRequest $request
     * @param ListRelatedTeamsHeaders $headers
     * @param RuntimeOptions          $runtime
     *
     * @return ListRelatedTeamsResponse
     */
    public function listRelatedTeamsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->type)) {
            $query['type'] = $request->type;
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
            'action'      => 'ListRelatedTeams',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListRelatedTeamsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListRelatedTeamsRequest $request
     *
     * @return ListRelatedTeamsResponse
     */
    public function listRelatedTeams($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListRelatedTeamsHeaders([]);

        return $this->listRelatedTeamsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                   $teamId
     * @param ListSpaceSectionsRequest $request
     * @param ListSpaceSectionsHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return ListSpaceSectionsResponse
     */
    public function listSpaceSectionsWithOptions($teamId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'ListSpaceSections',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams/' . $teamId . '/spaceSections',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListSpaceSectionsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                   $teamId
     * @param ListSpaceSectionsRequest $request
     *
     * @return ListSpaceSectionsResponse
     */
    public function listSpaceSections($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSpaceSectionsHeaders([]);

        return $this->listSpaceSectionsWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @param ListStarsRequest $request
     * @param ListStarsHeaders $headers
     * @param RuntimeOptions   $runtime
     *
     * @return ListStarsResponse
     */
    public function listStarsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
        if (!Utils::isUnset($request->option)) {
            $body['option'] = $request->option;
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
            'action'      => 'ListStars',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/dentries/starLists/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListStarsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param ListStarsRequest $request
     *
     * @return ListStarsResponse
     */
    public function listStars($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListStarsHeaders([]);

        return $this->listStarsWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                 $teamId
     * @param ListTeamMembersRequest $request
     * @param ListTeamMembersHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return ListTeamMembersResponse
     */
    public function listTeamMembersWithOptions($teamId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'ListTeamMembers',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams/' . $teamId . '/members',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListTeamMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                 $teamId
     * @param ListTeamMembersRequest $request
     *
     * @return ListTeamMembersResponse
     */
    public function listTeamMembers($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListTeamMembersHeaders([]);

        return $this->listTeamMembersWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @param string          $dentryUuid
     * @param MarkStarRequest $request
     * @param MarkStarHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return MarkStarResponse
     */
    public function markStarWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'MarkStar',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/dentries/' . $dentryUuid . '/stars/mark',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return MarkStarResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string          $dentryUuid
     * @param MarkStarRequest $request
     *
     * @return MarkStarResponse
     */
    public function markStar($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MarkStarHeaders([]);

        return $this->markStarWithOptions($dentryUuid, $request, $headers, $runtime);
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
        $body = [];
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->targetSpaceId)) {
            $body['targetSpaceId'] = $request->targetSpaceId;
        }
        if (!Utils::isUnset($request->toNextDentryId)) {
            $body['toNextDentryId'] = $request->toNextDentryId;
        }
        if (!Utils::isUnset($request->toParentDentryId)) {
            $body['toParentDentryId'] = $request->toParentDentryId;
        }
        if (!Utils::isUnset($request->toPrevDentryId)) {
            $body['toPrevDentryId'] = $request->toPrevDentryId;
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
            'action'      => 'MoveDentry',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/' . $spaceId . '/dentries/' . $dentryId . '/move',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return MoveDentryResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param string          $spaceId
     * @param PinSpaceRequest $request
     * @param PinSpaceHeaders $headers
     * @param RuntimeOptions  $runtime
     *
     * @return PinSpaceResponse
     */
    public function pinSpaceWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'PinSpace',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/' . $spaceId . '/pin',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return PinSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string          $spaceId
     * @param PinSpaceRequest $request
     *
     * @return PinSpaceResponse
     */
    public function pinSpace($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PinSpaceHeaders([]);

        return $this->pinSpaceWithOptions($spaceId, $request, $headers, $runtime);
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
        $query = [];
        if (!Utils::isUnset($request->includeSpace)) {
            $query['includeSpace'] = $request->includeSpace;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'QueryDentry',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/' . $spaceId . '/dentries/' . $dentryId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDentryResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param QueryItemByUrlRequest $request
     * @param QueryItemByUrlHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryItemByUrlResponse
     */
    public function queryItemByUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->url)) {
            $query['url'] = $request->url;
        }
        if (!Utils::isUnset($request->withStatisticalInfo)) {
            $query['withStatisticalInfo'] = $request->withStatisticalInfo;
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
            'action'      => 'QueryItemByUrl',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/items',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryItemByUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryItemByUrlRequest $request
     *
     * @return QueryItemByUrlResponse
     */
    public function queryItemByUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryItemByUrlHeaders([]);

        return $this->queryItemByUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                $unionId
     * @param QueryMineSpaceHeaders $headers
     * @param RuntimeOptions        $runtime
     *
     * @return QueryMineSpaceResponse
     */
    public function queryMineSpaceWithOptions($unionId, $headers, $runtime)
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
            'action'      => 'QueryMineSpace',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/users/' . $unionId . '/mine',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryMineSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string $unionId
     *
     * @return QueryMineSpaceResponse
     */
    public function queryMineSpace($unionId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMineSpaceHeaders([]);

        return $this->queryMineSpaceWithOptions($unionId, $headers, $runtime);
    }

    /**
     * @param QueryRecentListRequest $request
     * @param QueryRecentListHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return QueryRecentListResponse
     */
    public function queryRecentListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->creatorType)) {
            $query['creatorType'] = $request->creatorType;
        }
        if (!Utils::isUnset($request->fileType)) {
            $query['fileType'] = $request->fileType;
        }
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->recentType)) {
            $query['recentType'] = $request->recentType;
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
            'action'      => 'QueryRecentList',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/docs/recent',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryRecentListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param QueryRecentListRequest $request
     *
     * @return QueryRecentListResponse
     */
    public function queryRecentList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRecentListHeaders([]);

        return $this->queryRecentListWithOptions($request, $headers, $runtime);
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
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'QuerySpace',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/' . $spaceId . '',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QuerySpaceResponse::fromMap($this->execute($params, $req, $runtime));
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
     * @param RelatedSpacesRequest $request
     * @param RelatedSpacesHeaders $headers
     * @param RuntimeOptions       $runtime
     *
     * @return RelatedSpacesResponse
     */
    public function relatedSpacesWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->maxResults)) {
            $query['maxResults'] = $request->maxResults;
        }
        if (!Utils::isUnset($request->nextToken)) {
            $query['nextToken'] = $request->nextToken;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->teamId)) {
            $query['teamId'] = $request->teamId;
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
            'action'      => 'RelatedSpaces',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/relations/spaces',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RelatedSpacesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param RelatedSpacesRequest $request
     *
     * @return RelatedSpacesResponse
     */
    public function relatedSpaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RelatedSpacesHeaders([]);

        return $this->relatedSpacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string                   $teamId
     * @param RemoveTeamMembersRequest $request
     * @param RemoveTeamMembersHeaders $headers
     * @param RuntimeOptions           $runtime
     *
     * @return RemoveTeamMembersResponse
     */
    public function removeTeamMembersWithOptions($teamId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->notify)) {
            $body['notify'] = $request->notify;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'RemoveTeamMembers',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams/' . $teamId . '/members/remove',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RemoveTeamMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                   $teamId
     * @param RemoveTeamMembersRequest $request
     *
     * @return RemoveTeamMembersResponse
     */
    public function removeTeamMembers($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveTeamMembersHeaders([]);

        return $this->removeTeamMembersWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @param string              $spaceId
     * @param string              $dentryId
     * @param RenameDentryRequest $request
     * @param RenameDentryHeaders $headers
     * @param RuntimeOptions      $runtime
     *
     * @return RenameDentryResponse
     */
    public function renameDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->name)) {
            $query['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'RenameDentry',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/' . $spaceId . '/dentries/' . $dentryId . '/rename',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RenameDentryResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string              $spaceId
     * @param string              $dentryId
     * @param RenameDentryRequest $request
     *
     * @return RenameDentryResponse
     */
    public function renameDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RenameDentryHeaders([]);

        return $this->renameDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @param string                 $teamId
     * @param SaveTeamMembersRequest $request
     * @param SaveTeamMembersHeaders $headers
     * @param RuntimeOptions         $runtime
     *
     * @return SaveTeamMembersResponse
     */
    public function saveTeamMembersWithOptions($teamId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->members)) {
            $body['members'] = $request->members;
        }
        if (!Utils::isUnset($request->notify)) {
            $body['notify'] = $request->notify;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'SaveTeamMembers',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams/' . $teamId . '/members',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SaveTeamMembersResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string                 $teamId
     * @param SaveTeamMembersRequest $request
     *
     * @return SaveTeamMembersResponse
     */
    public function saveTeamMembers($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveTeamMembersHeaders([]);

        return $this->saveTeamMembersWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @param SearchRequest  $request
     * @param SearchHeaders  $headers
     * @param RuntimeOptions $runtime
     *
     * @return SearchResponse
     */
    public function searchWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->dentryRequest)) {
            $body['dentryRequest'] = $request->dentryRequest;
        }
        if (!Utils::isUnset($request->keyword)) {
            $body['keyword'] = $request->keyword;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->spaceRequest)) {
            $body['spaceRequest'] = $request->spaceRequest;
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
            'action'      => 'Search',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param SearchRequest $request
     *
     * @return SearchResponse
     */
    public function search($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchHeaders([]);

        return $this->searchWithOptions($request, $headers, $runtime);
    }

    /**
     * @param string            $dentryUuid
     * @param UnmarkStarRequest $request
     * @param UnmarkStarHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return UnmarkStarResponse
     */
    public function unmarkStarWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'UnmarkStar',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/dentries/' . $dentryUuid . '/stars/unmark',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UnmarkStarResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string            $dentryUuid
     * @param UnmarkStarRequest $request
     *
     * @return UnmarkStarResponse
     */
    public function unmarkStar($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnmarkStarHeaders([]);

        return $this->unmarkStarWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @param string            $spaceId
     * @param UnpinSpaceRequest $request
     * @param UnpinSpaceHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return UnpinSpaceResponse
     */
    public function unpinSpaceWithOptions($spaceId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
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
            'action'      => 'UnpinSpace',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/spaces/' . $spaceId . '/unpin',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UnpinSpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string            $spaceId
     * @param UnpinSpaceRequest $request
     *
     * @return UnpinSpaceResponse
     */
    public function unpinSpace($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnpinSpaceHeaders([]);

        return $this->unpinSpaceWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @param string            $teamId
     * @param UpdateTeamRequest $request
     * @param UpdateTeamHeaders $headers
     * @param RuntimeOptions    $runtime
     *
     * @return UpdateTeamResponse
     */
    public function updateTeamWithOptions($teamId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->description)) {
            $body['description'] = $request->description;
        }
        if (!Utils::isUnset($request->name)) {
            $body['name'] = $request->name;
        }
        if (!Utils::isUnset($request->operatorId)) {
            $body['operatorId'] = $request->operatorId;
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
            'action'      => 'UpdateTeam',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams/' . $teamId . '',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UpdateTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @param string            $teamId
     * @param UpdateTeamRequest $request
     *
     * @return UpdateTeamResponse
     */
    public function updateTeam($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTeamHeaders([]);

        return $this->updateTeamWithOptions($teamId, $request, $headers, $runtime);
    }
}
