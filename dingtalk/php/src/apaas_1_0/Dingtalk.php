<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0;

use AlibabaCloud\OpenApiUtil\OpenApiUtilClient;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchCreateTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchCreateTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchCreateTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchQueryByTemplateKeyHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchQueryByTemplateKeyRequest;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchQueryByTemplateKeyResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchUpdateTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchUpdateTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchUpdateTemplateResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryIndustryTagListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryIndustryTagListResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryRoleTagListHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryRoleTagListResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryTemplateCategorysHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryTemplateCategorysResponse;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\RecallAuditTemplateHeaders;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\RecallAuditTemplateRequest;
use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\RecallAuditTemplateResponse;
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
     * @summary 批量创建模板
     *  *
     * @param BatchCreateTemplateRequest $request BatchCreateTemplateRequest
     * @param BatchCreateTemplateHeaders $headers BatchCreateTemplateHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchCreateTemplateResponse BatchCreateTemplateResponse
     */
    public function batchCreateTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateList)) {
            $body['templateList'] = $request->templateList;
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
            'action'      => 'BatchCreateTemplate',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchCreateTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量创建模板
     *  *
     * @param BatchCreateTemplateRequest $request BatchCreateTemplateRequest
     *
     * @return BatchCreateTemplateResponse BatchCreateTemplateResponse
     */
    public function batchCreateTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchCreateTemplateHeaders([]);

        return $this->batchCreateTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量查询模板
     *  *
     * @param BatchQueryByTemplateKeyRequest $request BatchQueryByTemplateKeyRequest
     * @param BatchQueryByTemplateKeyHeaders $headers BatchQueryByTemplateKeyHeaders
     * @param RuntimeOptions                 $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchQueryByTemplateKeyResponse BatchQueryByTemplateKeyResponse
     */
    public function batchQueryByTemplateKeyWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateKeys)) {
            $body['templateKeys'] = $request->templateKeys;
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
            'action'      => 'BatchQueryByTemplateKey',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates/query',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchQueryByTemplateKeyResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量查询模板
     *  *
     * @param BatchQueryByTemplateKeyRequest $request BatchQueryByTemplateKeyRequest
     *
     * @return BatchQueryByTemplateKeyResponse BatchQueryByTemplateKeyResponse
     */
    public function batchQueryByTemplateKey($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchQueryByTemplateKeyHeaders([]);

        return $this->batchQueryByTemplateKeyWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 批量修改模板
     *  *
     * @param BatchUpdateTemplateRequest $request BatchUpdateTemplateRequest
     * @param BatchUpdateTemplateHeaders $headers BatchUpdateTemplateHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return BatchUpdateTemplateResponse BatchUpdateTemplateResponse
     */
    public function batchUpdateTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateList)) {
            $body['templateList'] = $request->templateList;
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
            'action'      => 'BatchUpdateTemplate',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates',
            'method'      => 'PUT',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return BatchUpdateTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 批量修改模板
     *  *
     * @param BatchUpdateTemplateRequest $request BatchUpdateTemplateRequest
     *
     * @return BatchUpdateTemplateResponse BatchUpdateTemplateResponse
     */
    public function batchUpdateTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new BatchUpdateTemplateHeaders([]);

        return $this->batchUpdateTemplateWithOptions($request, $headers, $runtime);
    }

    /**
     * @summary 查询行业标签
     *  *
     * @param QueryIndustryTagListHeaders $headers QueryIndustryTagListHeaders
     * @param RuntimeOptions              $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryIndustryTagListResponse QueryIndustryTagListResponse
     */
    public function queryIndustryTagListWithOptions($headers, $runtime)
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
            'action'      => 'QueryIndustryTagList',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates/industries',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryIndustryTagListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询行业标签
     *  *
     * @return QueryIndustryTagListResponse QueryIndustryTagListResponse
     */
    public function queryIndustryTagList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryIndustryTagListHeaders([]);

        return $this->queryIndustryTagListWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询角色
     *  *
     * @param QueryRoleTagListHeaders $headers QueryRoleTagListHeaders
     * @param RuntimeOptions          $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryRoleTagListResponse QueryRoleTagListResponse
     */
    public function queryRoleTagListWithOptions($headers, $runtime)
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
            'action'      => 'QueryRoleTagList',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates/roles',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryRoleTagListResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询角色
     *  *
     * @return QueryRoleTagListResponse QueryRoleTagListResponse
     */
    public function queryRoleTagList()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryRoleTagListHeaders([]);

        return $this->queryRoleTagListWithOptions($headers, $runtime);
    }

    /**
     * @summary 查询模板分类
     *  *
     * @param QueryTemplateCategorysHeaders $headers QueryTemplateCategorysHeaders
     * @param RuntimeOptions                $runtime runtime options for this request RuntimeOptions
     *
     * @return QueryTemplateCategorysResponse QueryTemplateCategorysResponse
     */
    public function queryTemplateCategorysWithOptions($headers, $runtime)
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
            'action'      => 'QueryTemplateCategorys',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates/categories',
            'method'      => 'GET',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return QueryTemplateCategorysResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 查询模板分类
     *  *
     * @return QueryTemplateCategorysResponse QueryTemplateCategorysResponse
     */
    public function queryTemplateCategorys()
    {
        $runtime = new RuntimeOptions([]);
        $headers = new QueryTemplateCategorysHeaders([]);

        return $this->queryTemplateCategorysWithOptions($headers, $runtime);
    }

    /**
     * @summary 撤回模板审核
     *  *
     * @param RecallAuditTemplateRequest $request RecallAuditTemplateRequest
     * @param RecallAuditTemplateHeaders $headers RecallAuditTemplateHeaders
     * @param RuntimeOptions             $runtime runtime options for this request RuntimeOptions
     *
     * @return RecallAuditTemplateResponse RecallAuditTemplateResponse
     */
    public function recallAuditTemplateWithOptions($request, $headers, $runtime)
    {
        Utils::validateModel($request);
        $body = [];
        if (!Utils::isUnset($request->templateKeys)) {
            $body['templateKeys'] = $request->templateKeys;
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
            'action'      => 'RecallAuditTemplate',
            'version'     => 'apaas_1.0',
            'protocol'    => 'HTTP',
            'pathname'    => '/v1.0/apaas/templates/audits/recall',
            'method'      => 'POST',
            'authType'    => 'AK',
            'style'       => 'ROA',
            'reqBodyType' => 'none',
            'bodyType'    => 'json',
        ]);

        return RecallAuditTemplateResponse::fromMap($this->execute($params, $req, $runtime));
    }

    /**
     * @summary 撤回模板审核
     *  *
     * @param RecallAuditTemplateRequest $request RecallAuditTemplateRequest
     *
     * @return RecallAuditTemplateResponse RecallAuditTemplateResponse
     */
    public function recallAuditTemplate($request)
    {
        $runtime = new RuntimeOptions([]);
        $headers = new RecallAuditTemplateHeaders([]);

        return $this->recallAuditTemplateWithOptions($request, $headers, $runtime);
    }
}
