<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2AddCustomTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2AddCustomTagRequest;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2AddCustomTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2AddObjectiveTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2AddObjectiveTagRequest;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2AddObjectiveTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2AddPersonalityTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2AddPersonalityTagRequest;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2AddPersonalityTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2DeleteCustomTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2DeleteCustomTagRequest;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2DeleteCustomTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2DeleteObjectiveTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2DeleteObjectiveTagRequest;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2DeleteObjectiveTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2DeletePersonalityTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2DeletePersonalityTagRequest;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2DeletePersonalityTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2LikeTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2LikeTagRequest;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2LikeTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryCustomTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryCustomTagRequest;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryCustomTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryObjectiveTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryObjectiveTagRequest;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryObjectiveTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryPersonalityTagHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryPersonalityTagResponse;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryTagLikeDetailListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryTagLikeDetailListRequest;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryTagLikeDetailListResponse;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryTagLikeListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryTagLikeListRequest;
use AlibabaCloud\SDK\Dingtalk\Vtalent_tag_1_0\Models\TalentV2QueryTagLikeListResponse;
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
        $gatewayClient = new Client();
        $this->_spi = $gatewayClient;
        $this->_endpointRule = '';
        if (Utils::empty_($this->_endpoint)) {
            $this->_endpoint = 'api.dingtalk.com';
        }
    }

    /**
     * @summary 人才标签：添加员工自定义标签
     *  *
     * @param TalentV2AddCustomTagRequest $request TalentV2AddCustomTagRequest
     * @param TalentV2AddCustomTagHeaders $headers TalentV2AddCustomTagHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return TalentV2AddCustomTagResponse TalentV2AddCustomTagResponse
     */
    public function talentV2AddCustomTagWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->sortOrder)) {
            $body['sortOrder'] = $request->sortOrder;
        }
        if (!Utils::isUnset($request->tagCode)) {
            $body['tagCode'] = $request->tagCode;
        }
        if (!Utils::isUnset($request->tagName)) {
            $body['tagName'] = $request->tagName;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TalentV2AddCustomTag',
            'version' => 'talentTag_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/talentTag/talentTags/addCustomTag',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TalentV2AddCustomTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人才标签：添加员工自定义标签
     *  *
     * @param TalentV2AddCustomTagRequest $request TalentV2AddCustomTagRequest
     *
     * @return TalentV2AddCustomTagResponse TalentV2AddCustomTagResponse
     */
    public function talentV2AddCustomTag($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TalentV2AddCustomTagHeaders([]);

        return $this->talentV2AddCustomTagWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 人才标签：添加员工客观标签
     *  *
     * @param TalentV2AddObjectiveTagRequest $request TalentV2AddObjectiveTagRequest
     * @param TalentV2AddObjectiveTagHeaders $headers TalentV2AddObjectiveTagHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return TalentV2AddObjectiveTagResponse TalentV2AddObjectiveTagResponse
     */
    public function talentV2AddObjectiveTagWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->sortOrder)) {
            $body['sortOrder'] = $request->sortOrder;
        }
        if (!Utils::isUnset($request->tagCode)) {
            $body['tagCode'] = $request->tagCode;
        }
        if (!Utils::isUnset($request->tagName)) {
            $body['tagName'] = $request->tagName;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TalentV2AddObjectiveTag',
            'version' => 'talentTag_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/talentTag/talentTags/addObjectiveTag',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TalentV2AddObjectiveTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人才标签：添加员工客观标签
     *  *
     * @param TalentV2AddObjectiveTagRequest $request TalentV2AddObjectiveTagRequest
     *
     * @return TalentV2AddObjectiveTagResponse TalentV2AddObjectiveTagResponse
     */
    public function talentV2AddObjectiveTag($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TalentV2AddObjectiveTagHeaders([]);

        return $this->talentV2AddObjectiveTagWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 人才标签：添加企业个性标签
     *  *
     * @param TalentV2AddPersonalityTagRequest $request TalentV2AddPersonalityTagRequest
     * @param TalentV2AddPersonalityTagHeaders $headers TalentV2AddPersonalityTagHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return TalentV2AddPersonalityTagResponse TalentV2AddPersonalityTagResponse
     */
    public function talentV2AddPersonalityTagWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->categoryCode)) {
            $body['categoryCode'] = $request->categoryCode;
        }
        if (!Utils::isUnset($request->categoryName)) {
            $body['categoryName'] = $request->categoryName;
        }
        if (!Utils::isUnset($request->categorySortOrder)) {
            $body['categorySortOrder'] = $request->categorySortOrder;
        }
        if (!Utils::isUnset($request->sortOrder)) {
            $body['sortOrder'] = $request->sortOrder;
        }
        if (!Utils::isUnset($request->tagCode)) {
            $body['tagCode'] = $request->tagCode;
        }
        if (!Utils::isUnset($request->tagName)) {
            $body['tagName'] = $request->tagName;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TalentV2AddPersonalityTag',
            'version' => 'talentTag_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/talentTag/talentTags/addPersonalityTag',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TalentV2AddPersonalityTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人才标签：添加企业个性标签
     *  *
     * @param TalentV2AddPersonalityTagRequest $request TalentV2AddPersonalityTagRequest
     *
     * @return TalentV2AddPersonalityTagResponse TalentV2AddPersonalityTagResponse
     */
    public function talentV2AddPersonalityTag($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TalentV2AddPersonalityTagHeaders([]);

        return $this->talentV2AddPersonalityTagWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 人才标签：删除员工自定义标签并清除所有点赞记录
     *  *
     * @param TalentV2DeleteCustomTagRequest $request TalentV2DeleteCustomTagRequest
     * @param TalentV2DeleteCustomTagHeaders $headers TalentV2DeleteCustomTagHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return TalentV2DeleteCustomTagResponse TalentV2DeleteCustomTagResponse
     */
    public function talentV2DeleteCustomTagWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->tagCode)) {
            $body['tagCode'] = $request->tagCode;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TalentV2DeleteCustomTag',
            'version' => 'talentTag_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/talentTag/talentTags/deleteCustomTagWithClearLike',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TalentV2DeleteCustomTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人才标签：删除员工自定义标签并清除所有点赞记录
     *  *
     * @param TalentV2DeleteCustomTagRequest $request TalentV2DeleteCustomTagRequest
     *
     * @return TalentV2DeleteCustomTagResponse TalentV2DeleteCustomTagResponse
     */
    public function talentV2DeleteCustomTag($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TalentV2DeleteCustomTagHeaders([]);

        return $this->talentV2DeleteCustomTagWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 人才标签：删除员工客观标签
     *  *
     * @param TalentV2DeleteObjectiveTagRequest $request TalentV2DeleteObjectiveTagRequest
     * @param TalentV2DeleteObjectiveTagHeaders $headers TalentV2DeleteObjectiveTagHeaders
     * @param RuntimeOptions                    $runtime runtime options for this request RuntimeOptions
     *
     * @return TalentV2DeleteObjectiveTagResponse TalentV2DeleteObjectiveTagResponse
     */
    public function talentV2DeleteObjectiveTagWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->tagCode)) {
            $body['tagCode'] = $request->tagCode;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TalentV2DeleteObjectiveTag',
            'version' => 'talentTag_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/talentTag/talentTags/deleteObjectiveTag',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TalentV2DeleteObjectiveTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人才标签：删除员工客观标签
     *  *
     * @param TalentV2DeleteObjectiveTagRequest $request TalentV2DeleteObjectiveTagRequest
     *
     * @return TalentV2DeleteObjectiveTagResponse TalentV2DeleteObjectiveTagResponse
     */
    public function talentV2DeleteObjectiveTag($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TalentV2DeleteObjectiveTagHeaders([]);

        return $this->talentV2DeleteObjectiveTagWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 人才标签：删除企业个性标签
     *  *
     * @param TalentV2DeletePersonalityTagRequest $request TalentV2DeletePersonalityTagRequest
     * @param TalentV2DeletePersonalityTagHeaders $headers TalentV2DeletePersonalityTagHeaders
     * @param RuntimeOptions                      $runtime runtime options for this request RuntimeOptions
     *
     * @return TalentV2DeletePersonalityTagResponse TalentV2DeletePersonalityTagResponse
     */
    public function talentV2DeletePersonalityTagWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->tagCode)) {
            $body['tagCode'] = $request->tagCode;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TalentV2DeletePersonalityTag',
            'version' => 'talentTag_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/talentTag/talentTags/deletePersonalityTag',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TalentV2DeletePersonalityTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人才标签：删除企业个性标签
     *  *
     * @param TalentV2DeletePersonalityTagRequest $request TalentV2DeletePersonalityTagRequest
     *
     * @return TalentV2DeletePersonalityTagResponse TalentV2DeletePersonalityTagResponse
     */
    public function talentV2DeletePersonalityTag($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TalentV2DeletePersonalityTagHeaders([]);

        return $this->talentV2DeletePersonalityTagWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 人才标签：点赞/取消点赞标签
     *  *
     * @param TalentV2LikeTagRequest $request TalentV2LikeTagRequest
     * @param TalentV2LikeTagHeaders $headers TalentV2LikeTagHeaders
     * @param RuntimeOptions         $runtime runtime options for this request RuntimeOptions
     *
     * @return TalentV2LikeTagResponse TalentV2LikeTagResponse
     */
    public function talentV2LikeTagWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->actionType)) {
            $body['actionType'] = $request->actionType;
        }
        if (!Utils::isUnset($request->operatorUserId)) {
            $body['operatorUserId'] = $request->operatorUserId;
        }
        if (!Utils::isUnset($request->tagCode)) {
            $body['tagCode'] = $request->tagCode;
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
            'body' => OpenApiUtilClient::parseToMap($body),
        ]);
        $params = new Params([
            'action' => 'TalentV2LikeTag',
            'version' => 'talentTag_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/talentTag/talentTags/likeTag',
            'method' => 'POST',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TalentV2LikeTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人才标签：点赞/取消点赞标签
     *  *
     * @param TalentV2LikeTagRequest $request TalentV2LikeTagRequest
     *
     * @return TalentV2LikeTagResponse TalentV2LikeTagResponse
     */
    public function talentV2LikeTag($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TalentV2LikeTagHeaders([]);

        return $this->talentV2LikeTagWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 人才标签：查询员工自定义标签
     *  *
     * @param TalentV2QueryCustomTagRequest $request TalentV2QueryCustomTagRequest
     * @param TalentV2QueryCustomTagHeaders $headers TalentV2QueryCustomTagHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return TalentV2QueryCustomTagResponse TalentV2QueryCustomTagResponse
     */
    public function talentV2QueryCustomTagWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'TalentV2QueryCustomTag',
            'version' => 'talentTag_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/talentTag/talentTags/queryCustomTag',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TalentV2QueryCustomTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人才标签：查询员工自定义标签
     *  *
     * @param TalentV2QueryCustomTagRequest $request TalentV2QueryCustomTagRequest
     *
     * @return TalentV2QueryCustomTagResponse TalentV2QueryCustomTagResponse
     */
    public function talentV2QueryCustomTag($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TalentV2QueryCustomTagHeaders([]);

        return $this->talentV2QueryCustomTagWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 人才标签：查询员工客观标签
     *  *
     * @param TalentV2QueryObjectiveTagRequest $request TalentV2QueryObjectiveTagRequest
     * @param TalentV2QueryObjectiveTagHeaders $headers TalentV2QueryObjectiveTagHeaders
     * @param RuntimeOptions                   $runtime runtime options for this request RuntimeOptions
     *
     * @return TalentV2QueryObjectiveTagResponse TalentV2QueryObjectiveTagResponse
     */
    public function talentV2QueryObjectiveTagWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'TalentV2QueryObjectiveTag',
            'version' => 'talentTag_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/talentTag/talentTags/queryObjectiveTag',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TalentV2QueryObjectiveTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人才标签：查询员工客观标签
     *  *
     * @param TalentV2QueryObjectiveTagRequest $request TalentV2QueryObjectiveTagRequest
     *
     * @return TalentV2QueryObjectiveTagResponse TalentV2QueryObjectiveTagResponse
     */
    public function talentV2QueryObjectiveTag($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TalentV2QueryObjectiveTagHeaders([]);

        return $this->talentV2QueryObjectiveTagWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 人才标签：查询企业个性标签
     *  *
     * @param TalentV2QueryPersonalityTagHeaders $headers TalentV2QueryPersonalityTagHeaders
     * @param RuntimeOptions                     $runtime runtime options for this request RuntimeOptions
     *
     * @return TalentV2QueryPersonalityTagResponse TalentV2QueryPersonalityTagResponse
     */
    public function talentV2QueryPersonalityTagWithOptions($headers, $runtime)
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
            'action' => 'TalentV2QueryPersonalityTag',
            'version' => 'talentTag_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/talentTag/talentTags/queryPersonalityTag',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TalentV2QueryPersonalityTagResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人才标签：查询企业个性标签
     *  *
     * @return TalentV2QueryPersonalityTagResponse TalentV2QueryPersonalityTagResponse
     */
    public function talentV2QueryPersonalityTag()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TalentV2QueryPersonalityTagHeaders([]);

        return $this->talentV2QueryPersonalityTagWithOptions($headers, $runtime);
    }

    /**
     * @summary 人才标签：分页查询指定标签的点赞记录
     *  *
     * @param TalentV2QueryTagLikeDetailListRequest $request TalentV2QueryTagLikeDetailListRequest
     * @param TalentV2QueryTagLikeDetailListHeaders $headers TalentV2QueryTagLikeDetailListHeaders
     * @param RuntimeOptions                        $runtime runtime options for this request RuntimeOptions
     *
     * @return TalentV2QueryTagLikeDetailListResponse TalentV2QueryTagLikeDetailListResponse
     */
    public function talentV2QueryTagLikeDetailListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->cursor)) {
            $query['cursor'] = $request->cursor;
        }
        if (!Utils::isUnset($request->size)) {
            $query['size'] = $request->size;
        }
        if (!Utils::isUnset($request->tagCode)) {
            $query['tagCode'] = $request->tagCode;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'TalentV2QueryTagLikeDetailList',
            'version' => 'talentTag_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/talentTag/talentTags/queryTagLikeDetailList',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TalentV2QueryTagLikeDetailListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人才标签：分页查询指定标签的点赞记录
     *  *
     * @param TalentV2QueryTagLikeDetailListRequest $request TalentV2QueryTagLikeDetailListRequest
     *
     * @return TalentV2QueryTagLikeDetailListResponse TalentV2QueryTagLikeDetailListResponse
     */
    public function talentV2QueryTagLikeDetailList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TalentV2QueryTagLikeDetailListHeaders([]);

        return $this->talentV2QueryTagLikeDetailListWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 人才标签：查询点赞标签列表
     *  *
     * @param TalentV2QueryTagLikeListRequest $request TalentV2QueryTagLikeListRequest
     * @param TalentV2QueryTagLikeListHeaders $headers TalentV2QueryTagLikeListHeaders
     * @param RuntimeOptions                  $runtime runtime options for this request RuntimeOptions
     *
     * @return TalentV2QueryTagLikeListResponse TalentV2QueryTagLikeListResponse
     */
    public function talentV2QueryTagLikeListWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $query = [];
        if (!Utils::isUnset($request->operatorUserId)) {
            $query['operatorUserId'] = $request->operatorUserId;
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
            'query' => OpenApiUtilClient::query($query),
        ]);
        $params = new Params([
            'action' => 'TalentV2QueryTagLikeList',
            'version' => 'talentTag_1.0',
            'protocol' => 'HTTP',
            'pathname' => '/v1.0/talentTag/talentTags/queryTagLikeList',
            'method' => 'GET',
            'authType' => 'AK',
            'style' => 'ROA',
            'reqBodyType' => 'none',
            'bodyType' => 'json',
        ]);

        return TalentV2QueryTagLikeListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 人才标签：查询点赞标签列表
     *  *
     * @param TalentV2QueryTagLikeListRequest $request TalentV2QueryTagLikeListRequest
     *
     * @return TalentV2QueryTagLikeListResponse TalentV2QueryTagLikeListResponse
     */
    public function talentV2QueryTagLikeList($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new TalentV2QueryTagLikeListHeaders([]);

        return $this->talentV2QueryTagLikeListWithOptions($request, $headers, $runtime);
    }
}
