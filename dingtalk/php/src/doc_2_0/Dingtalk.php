<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\BatchCreateTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\BatchCreateTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\BatchCreateTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\BatchDeleteRecentsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\BatchDeleteRecentsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\BatchDeleteRecentsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CategoriesTemplatesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CategoriesTemplatesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CategoriesTemplatesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CategoryTemplatesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CategoryTemplatesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CategoryTemplatesResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DocContentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DocContentRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\DocContentResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetDentryIdByUuidHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetDentryIdByUuidRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetDentryIdByUuidResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetDocContentForELMHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetDocContentForELMRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetDocContentForELMResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetDocContentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetDocContentRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetDocContentResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetMySpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetMySpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetMySpaceResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetUuidByDentryIdHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetUuidByDentryIdRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\GetUuidByDentryIdResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\HandoverTeamWithoutAuthHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\HandoverTeamWithoutAuthRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\HandoverTeamWithoutAuthResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListFeedsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListFeedsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListFeedsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListHotDocsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListHotDocsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListHotDocsResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListRecentsHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListRecentsRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListRecentsResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryDocContentHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryDocContentRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\QueryDocContentResponse;
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
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchTemplatesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchTemplatesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchTemplatesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ShareUrlHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ShareUrlRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ShareUrlResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamTemplatesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamTemplatesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamTemplatesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TemplateCategoriesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TemplateCategoriesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TemplateCategoriesResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UnmarkStarHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UnmarkStarRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UnmarkStarResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UnpinSpaceHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UnpinSpaceRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UnpinSpaceResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UpdateTeamHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UpdateTeamRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UpdateTeamResponse;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UserTemplatesHeaders;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UserTemplatesRequest;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\UserTemplatesResponse;
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
     * @summary 批量创建小组
     *  *
     * @param BatchCreateTeamRequest $request BatchCreateTeamRequest
     * @param BatchCreateTeamHeaders $headers BatchCreateTeamHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchCreateTeamResponse BatchCreateTeamResponse
     */
    public function batchCreateTeamWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        $body = [];
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
            'action'      => 'BatchCreateTeam',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams/batch',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchCreateTeamResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量创建小组
     *  *
     * @param BatchCreateTeamRequest $request BatchCreateTeamRequest
     *
     * @return BatchCreateTeamResponse BatchCreateTeamResponse
     */
    public function batchCreateTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchCreateTeamHeaders([]);

        return $this->batchCreateTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量删除文档最近记录
     *  *
     * @param BatchDeleteRecentsRequest $request BatchDeleteRecentsRequest
     * @param BatchDeleteRecentsHeaders $headers BatchDeleteRecentsHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchDeleteRecentsResponse BatchDeleteRecentsResponse
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
     * @summary 批量删除文档最近记录
     *  *
     * @param BatchDeleteRecentsRequest $request BatchDeleteRecentsRequest
     *
     * @return BatchDeleteRecentsResponse BatchDeleteRecentsResponse
     */
    public function batchDeleteRecents($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchDeleteRecentsHeaders([]);

        return $this->batchDeleteRecentsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 按分类列表查询模板列表
     *  *
     * @param CategoriesTemplatesRequest $request CategoriesTemplatesRequest
     * @param CategoriesTemplatesHeaders $headers CategoriesTemplatesHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return CategoriesTemplatesResponse CategoriesTemplatesResponse
     */
    public function categoriesTemplatesWithOptions($request, $headers, $runtime)
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
            'action'      => 'CategoriesTemplates',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/categoryLists/templates/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CategoriesTemplatesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 按分类列表查询模板列表
     *  *
     * @param CategoriesTemplatesRequest $request CategoriesTemplatesRequest
     *
     * @return CategoriesTemplatesResponse CategoriesTemplatesResponse
     */
    public function categoriesTemplates($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CategoriesTemplatesHeaders([]);

        return $this->categoriesTemplatesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 按分类查询模板列表
     *  *
     * @param CategoryTemplatesRequest $request CategoryTemplatesRequest
     * @param CategoryTemplatesHeaders $headers CategoryTemplatesHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return CategoryTemplatesResponse CategoryTemplatesResponse
     */
    public function categoryTemplatesWithOptions($request, $headers, $runtime)
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
            'action'      => 'CategoryTemplates',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/categories/templates/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return CategoryTemplatesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 按分类查询模板列表
     *  *
     * @param CategoryTemplatesRequest $request CategoryTemplatesRequest
     *
     * @return CategoryTemplatesResponse CategoryTemplatesResponse
     */
    public function categoryTemplates($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CategoryTemplatesHeaders([]);

        return $this->categoryTemplatesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 拷贝知识库节点
     *  *
     * @param string            $spaceId
     * @param string            $dentryId
     * @param CopyDentryRequest $request  CopyDentryRequest
     * @param CopyDentryHeaders $headers  CopyDentryHeaders
     * @param RuntimeOptions    $runtime  runtime options for this request RuntimeOptions
     *
     * @return CopyDentryResponse CopyDentryResponse
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
     * @summary 拷贝知识库节点
     *  *
     * @param string            $spaceId
     * @param string            $dentryId
     * @param CopyDentryRequest $request  CopyDentryRequest
     *
     * @return CopyDentryResponse CopyDentryResponse
     */
    public function copyDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CopyDentryHeaders([]);

        return $this->copyDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建知识库节点（包括文档和文件夹）
     *  *
     * @param string              $spaceId
     * @param CreateDentryRequest $request CreateDentryRequest
     * @param CreateDentryHeaders $headers CreateDentryHeaders
     * @param RuntimeOptions      $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateDentryResponse CreateDentryResponse
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
     * @summary 创建知识库节点（包括文档和文件夹）
     *  *
     * @param string              $spaceId
     * @param CreateDentryRequest $request CreateDentryRequest
     *
     * @return CreateDentryResponse CreateDentryResponse
     */
    public function createDentry($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateDentryHeaders([]);

        return $this->createDentryWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @summary 创建知识库
     *  *
     * @param CreateSpaceRequest $request CreateSpaceRequest
     * @param CreateSpaceHeaders $headers CreateSpaceHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateSpaceResponse CreateSpaceResponse
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
     * @summary 创建知识库
     *  *
     * @param CreateSpaceRequest $request CreateSpaceRequest
     *
     * @return CreateSpaceResponse CreateSpaceResponse
     */
    public function createSpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateSpaceHeaders([]);

        return $this->createSpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 创建小组
     *  *
     * @param CreateTeamRequest $request CreateTeamRequest
     * @param CreateTeamHeaders $headers CreateTeamHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return CreateTeamResponse CreateTeamResponse
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
     * @summary 创建小组
     *  *
     * @param CreateTeamRequest $request CreateTeamRequest
     *
     * @return CreateTeamResponse CreateTeamResponse
     */
    public function createTeam($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CreateTeamHeaders([]);

        return $this->createTeamWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 跨组织迁移知识库
     *  *
     * @param CrossOrgMigrateRequest $request CrossOrgMigrateRequest
     * @param CrossOrgMigrateHeaders $headers CrossOrgMigrateHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return CrossOrgMigrateResponse CrossOrgMigrateResponse
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
     * @summary 跨组织迁移知识库
     *  *
     * @param CrossOrgMigrateRequest $request CrossOrgMigrateRequest
     *
     * @return CrossOrgMigrateResponse CrossOrgMigrateResponse
     */
    public function crossOrgMigrate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new CrossOrgMigrateHeaders([]);

        return $this->crossOrgMigrateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 删除小组
     *  *
     * @param string            $teamId
     * @param DeleteTeamRequest $request DeleteTeamRequest
     * @param DeleteTeamHeaders $headers DeleteTeamHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return DeleteTeamResponse DeleteTeamResponse
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
     * @summary 删除小组
     *  *
     * @param string            $teamId
     * @param DeleteTeamRequest $request DeleteTeamRequest
     *
     * @return DeleteTeamResponse DeleteTeamResponse
     */
    public function deleteTeam($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DeleteTeamHeaders([]);

        return $this->deleteTeamWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取文档内容
     *  *
     * @param string            $dentryUuid
     * @param DocContentRequest $request    DocContentRequest
     * @param DocContentHeaders $headers    DocContentHeaders
     * @param RuntimeOptions    $runtime    runtime options for this request RuntimeOptions
     *
     * @return DocContentResponse DocContentResponse
     */
    public function docContentWithOptions($dentryUuid, $request, $headers, $runtime)
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
            'action'      => 'DocContent',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/dentries/' . $dentryUuid . '/contents',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return DocContentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取文档内容
     *  *
     * @param string            $dentryUuid
     * @param DocContentRequest $request    DocContentRequest
     *
     * @return DocContentResponse DocContentResponse
     */
    public function docContent($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new DocContentHeaders([]);

        return $this->docContentWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 根据文件DentryUuid获取文件DentryId
     *  *
     * @param string                   $dentryUuid
     * @param GetDentryIdByUuidRequest $request    GetDentryIdByUuidRequest
     * @param GetDentryIdByUuidHeaders $headers    GetDentryIdByUuidHeaders
     * @param RuntimeOptions           $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetDentryIdByUuidResponse GetDentryIdByUuidResponse
     */
    public function getDentryIdByUuidWithOptions($dentryUuid, $request, $headers, $runtime)
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
            'action'      => 'GetDentryIdByUuid',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/dentries/' . $dentryUuid . '/queryDentryId',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDentryIdByUuidResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据文件DentryUuid获取文件DentryId
     *  *
     * @param string                   $dentryUuid
     * @param GetDentryIdByUuidRequest $request    GetDentryIdByUuidRequest
     *
     * @return GetDentryIdByUuidResponse GetDentryIdByUuidResponse
     */
    public function getDentryIdByUuid($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDentryIdByUuidHeaders([]);

        return $this->getDentryIdByUuidWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 委托权限获取文档内容
     *  *
     * @param string               $dentryUuid
     * @param GetDocContentRequest $request    GetDocContentRequest
     * @param GetDocContentHeaders $headers    GetDocContentHeaders
     * @param RuntimeOptions       $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetDocContentResponse GetDocContentResponse
     */
    public function getDocContentWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->generateCp)) {
            $query['generateCp'] = $request->generateCp;
        }
        if (!Utils::isUnset($request->targetFormat)) {
            $query['targetFormat'] = $request->targetFormat;
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
            'action'      => 'GetDocContent',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/me/query/' . $dentryUuid . '/contents',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDocContentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 委托权限获取文档内容
     *  *
     * @param string               $dentryUuid
     * @param GetDocContentRequest $request    GetDocContentRequest
     *
     * @return GetDocContentResponse GetDocContentResponse
     */
    public function getDocContent($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDocContentHeaders([]);

        return $this->getDocContentWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 委托权限获取文档内容
     *  *
     * @param string                     $dentryUuid
     * @param GetDocContentForELMRequest $request    GetDocContentForELMRequest
     * @param GetDocContentForELMHeaders $headers    GetDocContentForELMHeaders
     * @param RuntimeOptions             $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetDocContentForELMResponse GetDocContentForELMResponse
     */
    public function getDocContentForELMWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->targetFormat)) {
            $query['targetFormat'] = $request->targetFormat;
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
            'action'      => 'GetDocContentForELM',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/elm/me/dentries/' . $dentryUuid . '/contents',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetDocContentForELMResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 委托权限获取文档内容
     *  *
     * @param string                     $dentryUuid
     * @param GetDocContentForELMRequest $request    GetDocContentForELMRequest
     *
     * @return GetDocContentForELMResponse GetDocContentForELMResponse
     */
    public function getDocContentForELM($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetDocContentForELMHeaders([]);

        return $this->getDocContentForELMWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 获取当前企业下钉盘目录我的文件对应的空间信息
     *  *
     * @param GetMySpaceRequest $request GetMySpaceRequest
     * @param GetMySpaceHeaders $headers GetMySpaceHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return GetMySpaceResponse GetMySpaceResponse
     */
    public function getMySpaceWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->isMySpace)) {
            $query['isMySpace'] = $request->isMySpace;
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
            'action'      => 'GetMySpace',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/me/mySpace/infos',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetMySpaceResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取当前企业下钉盘目录我的文件对应的空间信息
     *  *
     * @param GetMySpaceRequest $request GetMySpaceRequest
     *
     * @return GetMySpaceResponse GetMySpaceResponse
     */
    public function getMySpace($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetMySpaceHeaders([]);

        return $this->getMySpaceWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询小组主页schema （包括轮播图、公告、便捷入口）
     *  *
     * @param string           $teamId
     * @param GetSchemaRequest $request GetSchemaRequest
     * @param GetSchemaHeaders $headers GetSchemaHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSchemaResponse GetSchemaResponse
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
     * @summary 查询小组主页schema （包括轮播图、公告、便捷入口）
     *  *
     * @param string           $teamId
     * @param GetSchemaRequest $request GetSchemaRequest
     *
     * @return GetSchemaResponse GetSchemaResponse
     */
    public function getSchema($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSchemaHeaders([]);

        return $this->getSchemaWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询目录树
     *  *
     * @param string                     $spaceId
     * @param GetSpaceDirectoriesRequest $request GetSpaceDirectoriesRequest
     * @param GetSpaceDirectoriesHeaders $headers GetSpaceDirectoriesHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return GetSpaceDirectoriesResponse GetSpaceDirectoriesResponse
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
     * @summary 查询目录树
     *  *
     * @param string                     $spaceId
     * @param GetSpaceDirectoriesRequest $request GetSpaceDirectoriesRequest
     *
     * @return GetSpaceDirectoriesResponse GetSpaceDirectoriesResponse
     */
    public function getSpaceDirectories($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetSpaceDirectoriesHeaders([]);

        return $this->getSpaceDirectoriesWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取星标信息
     *  *
     * @param string             $dentryUuid
     * @param GetStarInfoRequest $request    GetStarInfoRequest
     * @param GetStarInfoHeaders $headers    GetStarInfoHeaders
     * @param RuntimeOptions     $runtime    runtime options for this request RuntimeOptions
     *
     * @return GetStarInfoResponse GetStarInfoResponse
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
     * @summary 获取星标信息
     *  *
     * @param string             $dentryUuid
     * @param GetStarInfoRequest $request    GetStarInfoRequest
     *
     * @return GetStarInfoResponse GetStarInfoResponse
     */
    public function getStarInfo($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetStarInfoHeaders([]);

        return $this->getStarInfoWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 查询小组详情
     *  *
     * @param string         $teamId
     * @param GetTeamRequest $request GetTeamRequest
     * @param GetTeamHeaders $headers GetTeamHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTeamResponse GetTeamResponse
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
     * @summary 查询小组详情
     *  *
     * @param string         $teamId
     * @param GetTeamRequest $request GetTeamRequest
     *
     * @return GetTeamResponse GetTeamResponse
     */
    public function getTeam($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTeamHeaders([]);

        return $this->getTeamWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取知识库下的总节点数
     *  *
     * @param GetTotalNumberOfDentriesRequest $request GetTotalNumberOfDentriesRequest
     * @param GetTotalNumberOfDentriesHeaders $headers GetTotalNumberOfDentriesHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTotalNumberOfDentriesResponse GetTotalNumberOfDentriesResponse
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
     * @summary 获取知识库下的总节点数
     *  *
     * @param GetTotalNumberOfDentriesRequest $request GetTotalNumberOfDentriesRequest
     *
     * @return GetTotalNumberOfDentriesResponse GetTotalNumberOfDentriesResponse
     */
    public function getTotalNumberOfDentries($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTotalNumberOfDentriesHeaders([]);

        return $this->getTotalNumberOfDentriesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取知识库总数
     *  *
     * @param GetTotalNumberOfSpacesRequest $request GetTotalNumberOfSpacesRequest
     * @param GetTotalNumberOfSpacesHeaders $headers GetTotalNumberOfSpacesHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetTotalNumberOfSpacesResponse GetTotalNumberOfSpacesResponse
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
     * @summary 获取知识库总数
     *  *
     * @param GetTotalNumberOfSpacesRequest $request GetTotalNumberOfSpacesRequest
     *
     * @return GetTotalNumberOfSpacesResponse GetTotalNumberOfSpacesResponse
     */
    public function getTotalNumberOfSpaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetTotalNumberOfSpacesHeaders([]);

        return $this->getTotalNumberOfSpacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询文档免登的用户信息
     *  *
     * @param GetUserInfoByOpenTokenRequest $request GetUserInfoByOpenTokenRequest
     * @param GetUserInfoByOpenTokenHeaders $headers GetUserInfoByOpenTokenHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return GetUserInfoByOpenTokenResponse GetUserInfoByOpenTokenResponse
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
     * @summary 查询文档免登的用户信息
     *  *
     * @param GetUserInfoByOpenTokenRequest $request GetUserInfoByOpenTokenRequest
     *
     * @return GetUserInfoByOpenTokenResponse GetUserInfoByOpenTokenResponse
     */
    public function getUserInfoByOpenToken($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUserInfoByOpenTokenHeaders([]);

        return $this->getUserInfoByOpenTokenWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 根据文件DentryId获取文件DentryUuid
     *  *
     * @param string                   $dentryId
     * @param GetUuidByDentryIdRequest $request  GetUuidByDentryIdRequest
     * @param GetUuidByDentryIdHeaders $headers  GetUuidByDentryIdHeaders
     * @param RuntimeOptions           $runtime  runtime options for this request RuntimeOptions
     *
     * @return GetUuidByDentryIdResponse GetUuidByDentryIdResponse
     */
    public function getUuidByDentryIdWithOptions($dentryId, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->spaceId)) {
            $query['spaceId'] = $request->spaceId;
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
            'action'      => 'GetUuidByDentryId',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/dentries/' . $dentryId . '/queryDentryUuid',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return GetUuidByDentryIdResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 根据文件DentryId获取文件DentryUuid
     *  *
     * @param string                   $dentryId
     * @param GetUuidByDentryIdRequest $request  GetUuidByDentryIdRequest
     *
     * @return GetUuidByDentryIdResponse GetUuidByDentryIdResponse
     */
    public function getUuidByDentryId($dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new GetUuidByDentryIdHeaders([]);

        return $this->getUuidByDentryIdWithOptions($dentryId, $request, $headers, $runtime);
    }

    /**
     * @summary 以超级管理员身份转交小组
     *  *
     * @param HandoverTeamWithoutAuthRequest $request HandoverTeamWithoutAuthRequest
     * @param HandoverTeamWithoutAuthHeaders $headers HandoverTeamWithoutAuthHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return HandoverTeamWithoutAuthResponse HandoverTeamWithoutAuthResponse
     */
    public function handoverTeamWithoutAuthWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'HandoverTeamWithoutAuth',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/teams/members/handoverWithoutAuth',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return HandoverTeamWithoutAuthResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 以超级管理员身份转交小组
     *  *
     * @param HandoverTeamWithoutAuthRequest $request HandoverTeamWithoutAuthRequest
     *
     * @return HandoverTeamWithoutAuthResponse HandoverTeamWithoutAuthResponse
     */
    public function handoverTeamWithoutAuth($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new HandoverTeamWithoutAuthHeaders([]);

        return $this->handoverTeamWithoutAuthWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询小组动态
     *  *
     * @param string           $teamId
     * @param ListFeedsRequest $request ListFeedsRequest
     * @param ListFeedsHeaders $headers ListFeedsHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return ListFeedsResponse ListFeedsResponse
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
     * @summary 查询小组动态
     *  *
     * @param string           $teamId
     * @param ListFeedsRequest $request ListFeedsRequest
     *
     * @return ListFeedsResponse ListFeedsResponse
     */
    public function listFeeds($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListFeedsHeaders([]);

        return $this->listFeedsWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询小组热门文档
     *  *
     * @param string             $teamId
     * @param ListHotDocsRequest $request ListHotDocsRequest
     * @param ListHotDocsHeaders $headers ListHotDocsHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return ListHotDocsResponse ListHotDocsResponse
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
     * @summary 查询小组热门文档
     *  *
     * @param string             $teamId
     * @param ListHotDocsRequest $request ListHotDocsRequest
     *
     * @return ListHotDocsResponse ListHotDocsResponse
     */
    public function listHotDocs($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListHotDocsHeaders([]);

        return $this->listHotDocsWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取置顶知识库列表
     *  *
     * @param ListPinSpacesRequest $request ListPinSpacesRequest
     * @param ListPinSpacesHeaders $headers ListPinSpacesHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return ListPinSpacesResponse ListPinSpacesResponse
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
     * @summary 获取置顶知识库列表
     *  *
     * @param ListPinSpacesRequest $request ListPinSpacesRequest
     *
     * @return ListPinSpacesResponse ListPinSpacesResponse
     */
    public function listPinSpaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListPinSpacesHeaders([]);

        return $this->listPinSpacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询文档最近记录列表
     *  *
     * @param ListRecentsRequest $request ListRecentsRequest
     * @param ListRecentsHeaders $headers ListRecentsHeaders
     * @param RuntimeOptions     $runtime runtime options for this request RuntimeOptions
     *
     * @return ListRecentsResponse ListRecentsResponse
     */
    public function listRecentsWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ListRecents',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/dentries/recentRecords/lists/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ListRecentsResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询文档最近记录列表
     *  *
     * @param ListRecentsRequest $request ListRecentsRequest
     *
     * @return ListRecentsResponse ListRecentsResponse
     */
    public function listRecents($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListRecentsHeaders([]);

        return $this->listRecentsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询关联了知识库的团队列表
     *  *
     * @param ListRelatedSpaceTeamsRequest $request ListRelatedSpaceTeamsRequest
     * @param ListRelatedSpaceTeamsHeaders $headers ListRelatedSpaceTeamsHeaders
     * @param RuntimeOptions               $runtime runtime options for this request RuntimeOptions
     *
     * @return ListRelatedSpaceTeamsResponse ListRelatedSpaceTeamsResponse
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
     * @summary 查询关联了知识库的团队列表
     *  *
     * @param ListRelatedSpaceTeamsRequest $request ListRelatedSpaceTeamsRequest
     *
     * @return ListRelatedSpaceTeamsResponse ListRelatedSpaceTeamsResponse
     */
    public function listRelatedSpaceTeams($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListRelatedSpaceTeamsHeaders([]);

        return $this->listRelatedSpaceTeamsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询小组列表
     *  *
     * @param ListRelatedTeamsRequest $request ListRelatedTeamsRequest
     * @param ListRelatedTeamsHeaders $headers ListRelatedTeamsHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return ListRelatedTeamsResponse ListRelatedTeamsResponse
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
     * @summary 查询小组列表
     *  *
     * @param ListRelatedTeamsRequest $request ListRelatedTeamsRequest
     *
     * @return ListRelatedTeamsResponse ListRelatedTeamsResponse
     */
    public function listRelatedTeams($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListRelatedTeamsHeaders([]);

        return $this->listRelatedTeamsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询知识库分组
     *  *
     * @param string                   $teamId
     * @param ListSpaceSectionsRequest $request ListSpaceSectionsRequest
     * @param ListSpaceSectionsHeaders $headers ListSpaceSectionsHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return ListSpaceSectionsResponse ListSpaceSectionsResponse
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
     * @summary 查询知识库分组
     *  *
     * @param string                   $teamId
     * @param ListSpaceSectionsRequest $request ListSpaceSectionsRequest
     *
     * @return ListSpaceSectionsResponse ListSpaceSectionsResponse
     */
    public function listSpaceSections($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListSpaceSectionsHeaders([]);

        return $this->listSpaceSectionsWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取星标列表
     *  *
     * @param ListStarsRequest $request ListStarsRequest
     * @param ListStarsHeaders $headers ListStarsHeaders
     * @param RuntimeOptions   $runtime runtime options for this request RuntimeOptions
     *
     * @return ListStarsResponse ListStarsResponse
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
     * @summary 获取星标列表
     *  *
     * @param ListStarsRequest $request ListStarsRequest
     *
     * @return ListStarsResponse ListStarsResponse
     */
    public function listStars($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListStarsHeaders([]);

        return $this->listStarsWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询小组成员列表
     *  *
     * @param string                 $teamId
     * @param ListTeamMembersRequest $request ListTeamMembersRequest
     * @param ListTeamMembersHeaders $headers ListTeamMembersHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return ListTeamMembersResponse ListTeamMembersResponse
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
     * @summary 查询小组成员列表
     *  *
     * @param string                 $teamId
     * @param ListTeamMembersRequest $request ListTeamMembersRequest
     *
     * @return ListTeamMembersResponse ListTeamMembersResponse
     */
    public function listTeamMembers($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ListTeamMembersHeaders([]);

        return $this->listTeamMembersWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @summary 标记星标
     *  *
     * @param string          $dentryUuid
     * @param MarkStarRequest $request    MarkStarRequest
     * @param MarkStarHeaders $headers    MarkStarHeaders
     * @param RuntimeOptions  $runtime    runtime options for this request RuntimeOptions
     *
     * @return MarkStarResponse MarkStarResponse
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
     * @summary 标记星标
     *  *
     * @param string          $dentryUuid
     * @param MarkStarRequest $request    MarkStarRequest
     *
     * @return MarkStarResponse MarkStarResponse
     */
    public function markStar($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MarkStarHeaders([]);

        return $this->markStarWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 移动知识库节点
     *  *
     * @param string            $spaceId
     * @param string            $dentryId
     * @param MoveDentryRequest $request  MoveDentryRequest
     * @param MoveDentryHeaders $headers  MoveDentryHeaders
     * @param RuntimeOptions    $runtime  runtime options for this request RuntimeOptions
     *
     * @return MoveDentryResponse MoveDentryResponse
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
     * @summary 移动知识库节点
     *  *
     * @param string            $spaceId
     * @param string            $dentryId
     * @param MoveDentryRequest $request  MoveDentryRequest
     *
     * @return MoveDentryResponse MoveDentryResponse
     */
    public function moveDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new MoveDentryHeaders([]);

        return $this->moveDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @summary 置顶知识库
     *  *
     * @param string          $spaceId
     * @param PinSpaceRequest $request PinSpaceRequest
     * @param PinSpaceHeaders $headers PinSpaceHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return PinSpaceResponse PinSpaceResponse
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
     * @summary 置顶知识库
     *  *
     * @param string          $spaceId
     * @param PinSpaceRequest $request PinSpaceRequest
     *
     * @return PinSpaceResponse PinSpaceResponse
     */
    public function pinSpace($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new PinSpaceHeaders([]);

        return $this->pinSpaceWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询知识库节点（包括文档和文件夹）
     *  *
     * @param string             $spaceId
     * @param string             $dentryId
     * @param QueryDentryRequest $request  QueryDentryRequest
     * @param QueryDentryHeaders $headers  QueryDentryHeaders
     * @param RuntimeOptions     $runtime  runtime options for this request RuntimeOptions
     *
     * @return QueryDentryResponse QueryDentryResponse
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
     * @summary 查询知识库节点（包括文档和文件夹）
     *  *
     * @param string             $spaceId
     * @param string             $dentryId
     * @param QueryDentryRequest $request  QueryDentryRequest
     *
     * @return QueryDentryResponse QueryDentryResponse
     */
    public function queryDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDentryHeaders([]);

        return $this->queryDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @summary 获取文档内容
     *  *
     * @param string                 $dentryUuid
     * @param QueryDocContentRequest $request    QueryDocContentRequest
     * @param QueryDocContentHeaders $headers    QueryDocContentHeaders
     * @param RuntimeOptions         $runtime    runtime options for this request RuntimeOptions
     *
     * @return QueryDocContentResponse QueryDocContentResponse
     */
    public function queryDocContentWithOptions($dentryUuid, $request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorId)) {
            $query['operatorId'] = $request->operatorId;
        }
        if (!Utils::isUnset($request->targetFormat)) {
            $query['targetFormat'] = $request->targetFormat;
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
            'action'      => 'QueryDocContent',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/query/' . $dentryUuid . '/contents',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryDocContentResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取文档内容
     *  *
     * @param string                 $dentryUuid
     * @param QueryDocContentRequest $request    QueryDocContentRequest
     *
     * @return QueryDocContentResponse QueryDocContentResponse
     */
    public function queryDocContent($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryDocContentHeaders([]);

        return $this->queryDocContentWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 根据链接查询节点或知识库信息
     *  *
     * @param QueryItemByUrlRequest $request QueryItemByUrlRequest
     * @param QueryItemByUrlHeaders $headers QueryItemByUrlHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryItemByUrlResponse QueryItemByUrlResponse
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
     * @summary 根据链接查询节点或知识库信息
     *  *
     * @param QueryItemByUrlRequest $request QueryItemByUrlRequest
     *
     * @return QueryItemByUrlResponse QueryItemByUrlResponse
     */
    public function queryItemByUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryItemByUrlHeaders([]);

        return $this->queryItemByUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询用户的「我的文档」
     *  *
     * @param string                $unionId
     * @param QueryMineSpaceHeaders $headers QueryMineSpaceHeaders
     * @param RuntimeOptions        $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryMineSpaceResponse QueryMineSpaceResponse
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
     * @summary 查询用户的「我的文档」
     *  *
     * @param string $unionId
     *
     * @return QueryMineSpaceResponse QueryMineSpaceResponse
     */
    public function queryMineSpace($unionId)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryMineSpaceHeaders([]);

        return $this->queryMineSpaceWithOptions($unionId, $headers, $runtime);
    }

    /**
     * @summary 查询最近列表
     *  *
     * @param QueryRecentListRequest $request QueryRecentListRequest
     * @param QueryRecentListHeaders $headers QueryRecentListHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryRecentListResponse QueryRecentListResponse
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
     * @summary 查询最近列表
     *  *
     * @param QueryRecentListRequest $request QueryRecentListRequest
     *
     * @return QueryRecentListResponse QueryRecentListResponse
     */
    public function queryRecentList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRecentListHeaders([]);

        return $this->queryRecentListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询指定知识库信息
     *  *
     * @param string            $spaceId
     * @param QuerySpaceRequest $request QuerySpaceRequest
     * @param QuerySpaceHeaders $headers QuerySpaceHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return QuerySpaceResponse QuerySpaceResponse
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
     * @summary 查询指定知识库信息
     *  *
     * @param string            $spaceId
     * @param QuerySpaceRequest $request QuerySpaceRequest
     *
     * @return QuerySpaceResponse QuerySpaceResponse
     */
    public function querySpace($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QuerySpaceHeaders([]);

        return $this->querySpaceWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @summary 查询与我关联的知识库列表（支持筛选小组）
     *  *
     * @param RelatedSpacesRequest $request RelatedSpacesRequest
     * @param RelatedSpacesHeaders $headers RelatedSpacesHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return RelatedSpacesResponse RelatedSpacesResponse
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
     * @summary 查询与我关联的知识库列表（支持筛选小组）
     *  *
     * @param RelatedSpacesRequest $request RelatedSpacesRequest
     *
     * @return RelatedSpacesResponse RelatedSpacesResponse
     */
    public function relatedSpaces($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RelatedSpacesHeaders([]);

        return $this->relatedSpacesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 移除小组成员
     *  *
     * @param string                   $teamId
     * @param RemoveTeamMembersRequest $request RemoveTeamMembersRequest
     * @param RemoveTeamMembersHeaders $headers RemoveTeamMembersHeaders
     * @param RuntimeOptions           $runtime runtime options for this request RuntimeOptions
     *
     * @return RemoveTeamMembersResponse RemoveTeamMembersResponse
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
     * @summary 移除小组成员
     *  *
     * @param string                   $teamId
     * @param RemoveTeamMembersRequest $request RemoveTeamMembersRequest
     *
     * @return RemoveTeamMembersResponse RemoveTeamMembersResponse
     */
    public function removeTeamMembers($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RemoveTeamMembersHeaders([]);

        return $this->removeTeamMembersWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @summary 知识库节点（包括文档和文件夹）重命名
     *  *
     * @param string              $spaceId
     * @param string              $dentryId
     * @param RenameDentryRequest $request  RenameDentryRequest
     * @param RenameDentryHeaders $headers  RenameDentryHeaders
     * @param RuntimeOptions      $runtime  runtime options for this request RuntimeOptions
     *
     * @return RenameDentryResponse RenameDentryResponse
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
     * @summary 知识库节点（包括文档和文件夹）重命名
     *  *
     * @param string              $spaceId
     * @param string              $dentryId
     * @param RenameDentryRequest $request  RenameDentryRequest
     *
     * @return RenameDentryResponse RenameDentryResponse
     */
    public function renameDentry($spaceId, $dentryId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RenameDentryHeaders([]);

        return $this->renameDentryWithOptions($spaceId, $dentryId, $request, $headers, $runtime);
    }

    /**
     * @summary 添加或修改小组成员
     *  *
     * @param string                 $teamId
     * @param SaveTeamMembersRequest $request SaveTeamMembersRequest
     * @param SaveTeamMembersHeaders $headers SaveTeamMembersHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return SaveTeamMembersResponse SaveTeamMembersResponse
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
     * @summary 添加或修改小组成员
     *  *
     * @param string                 $teamId
     * @param SaveTeamMembersRequest $request SaveTeamMembersRequest
     *
     * @return SaveTeamMembersResponse SaveTeamMembersResponse
     */
    public function saveTeamMembers($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SaveTeamMembersHeaders([]);

        return $this->saveTeamMembersWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @summary 搜索知识库和节点
     *  *
     * @param SearchRequest  $request SearchRequest
     * @param SearchHeaders  $headers SearchHeaders
     * @param RuntimeOptions $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchResponse SearchResponse
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
     * @summary 搜索知识库和节点
     *  *
     * @param SearchRequest $request SearchRequest
     *
     * @return SearchResponse SearchResponse
     */
    public function search($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchHeaders([]);

        return $this->searchWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 搜索模板中心模板
     *  *
     * @param SearchTemplatesRequest $request SearchTemplatesRequest
     * @param SearchTemplatesHeaders $headers SearchTemplatesHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return SearchTemplatesResponse SearchTemplatesResponse
     */
    public function searchTemplatesWithOptions($request, $headers, $runtime)
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
            'action'      => 'SearchTemplates',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/templates/search',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return SearchTemplatesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 搜索模板中心模板
     *  *
     * @param SearchTemplatesRequest $request SearchTemplatesRequest
     *
     * @return SearchTemplatesResponse SearchTemplatesResponse
     */
    public function searchTemplates($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new SearchTemplatesHeaders([]);

        return $this->searchTemplatesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取文件打开链接
     *  *
     * @param ShareUrlRequest $request ShareUrlRequest
     * @param ShareUrlHeaders $headers ShareUrlHeaders
     * @param RuntimeOptions  $runtime runtime options for this request RuntimeOptions
     *
     * @return ShareUrlResponse ShareUrlResponse
     */
    public function shareUrlWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
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
            'body'    => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action'      => 'ShareUrl',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/dentries/shareUrls/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return ShareUrlResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取文件打开链接
     *  *
     * @param ShareUrlRequest $request ShareUrlRequest
     *
     * @return ShareUrlResponse ShareUrlResponse
     */
    public function shareUrl($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new ShareUrlHeaders([]);

        return $this->shareUrlWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取知识库模板列表
     *  *
     * @param TeamTemplatesRequest $request TeamTemplatesRequest
     * @param TeamTemplatesHeaders $headers TeamTemplatesHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return TeamTemplatesResponse TeamTemplatesResponse
     */
    public function teamTemplatesWithOptions($request, $headers, $runtime)
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
            'action'      => 'TeamTemplates',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/workspaces/templates/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return TeamTemplatesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取知识库模板列表
     *  *
     * @param TeamTemplatesRequest $request TeamTemplatesRequest
     *
     * @return TeamTemplatesResponse TeamTemplatesResponse
     */
    public function teamTemplates($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TeamTemplatesHeaders([]);

        return $this->teamTemplatesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 获取模板分类列表
     *  *
     * @param TemplateCategoriesRequest $request TemplateCategoriesRequest
     * @param TemplateCategoriesHeaders $headers TemplateCategoriesHeaders
     * @param RuntimeOptions            $runtime runtime options for this request RuntimeOptions
     *
     * @return TemplateCategoriesResponse TemplateCategoriesResponse
     */
    public function templateCategoriesWithOptions($request, $headers, $runtime)
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
            'action'      => 'TemplateCategories',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/templates/categories/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return TemplateCategoriesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 获取模板分类列表
     *  *
     * @param TemplateCategoriesRequest $request TemplateCategoriesRequest
     *
     * @return TemplateCategoriesResponse TemplateCategoriesResponse
     */
    public function templateCategories($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TemplateCategoriesHeaders([]);

        return $this->templateCategoriesWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 取消标记星标
     *  *
     * @param string            $dentryUuid
     * @param UnmarkStarRequest $request    UnmarkStarRequest
     * @param UnmarkStarHeaders $headers    UnmarkStarHeaders
     * @param RuntimeOptions    $runtime    runtime options for this request RuntimeOptions
     *
     * @return UnmarkStarResponse UnmarkStarResponse
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
     * @summary 取消标记星标
     *  *
     * @param string            $dentryUuid
     * @param UnmarkStarRequest $request    UnmarkStarRequest
     *
     * @return UnmarkStarResponse UnmarkStarResponse
     */
    public function unmarkStar($dentryUuid, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnmarkStarHeaders([]);

        return $this->unmarkStarWithOptions($dentryUuid, $request, $headers, $runtime);
    }

    /**
     * @summary 取消置顶知识库
     *  *
     * @param string            $spaceId
     * @param UnpinSpaceRequest $request UnpinSpaceRequest
     * @param UnpinSpaceHeaders $headers UnpinSpaceHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return UnpinSpaceResponse UnpinSpaceResponse
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
     * @summary 取消置顶知识库
     *  *
     * @param string            $spaceId
     * @param UnpinSpaceRequest $request UnpinSpaceRequest
     *
     * @return UnpinSpaceResponse UnpinSpaceResponse
     */
    public function unpinSpace($spaceId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UnpinSpaceHeaders([]);

        return $this->unpinSpaceWithOptions($spaceId, $request, $headers, $runtime);
    }

    /**
     * @summary 更新小组
     *  *
     * @param string            $teamId
     * @param UpdateTeamRequest $request UpdateTeamRequest
     * @param UpdateTeamHeaders $headers UpdateTeamHeaders
     * @param RuntimeOptions    $runtime runtime options for this request RuntimeOptions
     *
     * @return UpdateTeamResponse UpdateTeamResponse
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
     * @summary 更新小组
     *  *
     * @param string            $teamId
     * @param UpdateTeamRequest $request UpdateTeamRequest
     *
     * @return UpdateTeamResponse UpdateTeamResponse
     */
    public function updateTeam($teamId, $request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UpdateTeamHeaders([]);

        return $this->updateTeamWithOptions($teamId, $request, $headers, $runtime);
    }

    /**
     * @summary 用户模板列表
     *  *
     * @param UserTemplatesRequest $request UserTemplatesRequest
     * @param UserTemplatesHeaders $headers UserTemplatesHeaders
     * @param RuntimeOptions       $runtime runtime options for this request RuntimeOptions
     *
     * @return UserTemplatesResponse UserTemplatesResponse
     */
    public function userTemplatesWithOptions($request, $headers, $runtime)
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
            'action'      => 'UserTemplates',
            'version'     => 'doc_2.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v2.0/doc/users/templates/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return UserTemplatesResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 用户模板列表
     *  *
     * @param UserTemplatesRequest $request UserTemplatesRequest
     *
     * @return UserTemplatesResponse UserTemplatesResponse
     */
    public function userTemplates($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new UserTemplatesHeaders([]);

        return $this->userTemplatesWithOptions($request, $headers, $runtime);
    }
}
