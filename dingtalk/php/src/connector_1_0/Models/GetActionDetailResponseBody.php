<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\GetActionDetailResponseBody\integrationConfig;
use AlibabaCloud\Tea\Model;

class GetActionDetailResponseBody extends Model
{
    /**
     * @description 连接资产标识
     *
     * @var string
     */
    public $connectAssetUri;

    /**
     * @description 调用时以JsonSchema描述的入参格式
     *
     * @var string
     */
    public $inputSchema;

    /**
     * @description 执行动作集成配置信息
     *
     * @var integrationConfig
     */
    public $integrationConfig;

    /**
     * @description 执行动作的名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 调用时以JsonSchema描述的出参格式
     *
     * @var string
     */
    public $outputSchema;

    /**
     * @description 执行动作的ID
     *
     * @var string
     */
    public $refId;

    /**
     * @description 执行动作提供组织
     *
     * @var string
     */
    public $refProviderCorpId;

    /**
     * @description 连接资产类型
     *
     * @var string
     */
    public $refType;
    protected $_name = [
        'connectAssetUri'   => 'connectAssetUri',
        'inputSchema'       => 'inputSchema',
        'integrationConfig' => 'integrationConfig',
        'name'              => 'name',
        'outputSchema'      => 'outputSchema',
        'refId'             => 'refId',
        'refProviderCorpId' => 'refProviderCorpId',
        'refType'           => 'refType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->connectAssetUri) {
            $res['connectAssetUri'] = $this->connectAssetUri;
        }
        if (null !== $this->inputSchema) {
            $res['inputSchema'] = $this->inputSchema;
        }
        if (null !== $this->integrationConfig) {
            $res['integrationConfig'] = null !== $this->integrationConfig ? $this->integrationConfig->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->outputSchema) {
            $res['outputSchema'] = $this->outputSchema;
        }
        if (null !== $this->refId) {
            $res['refId'] = $this->refId;
        }
        if (null !== $this->refProviderCorpId) {
            $res['refProviderCorpId'] = $this->refProviderCorpId;
        }
        if (null !== $this->refType) {
            $res['refType'] = $this->refType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetActionDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['connectAssetUri'])) {
            $model->connectAssetUri = $map['connectAssetUri'];
        }
        if (isset($map['inputSchema'])) {
            $model->inputSchema = $map['inputSchema'];
        }
        if (isset($map['integrationConfig'])) {
            $model->integrationConfig = integrationConfig::fromMap($map['integrationConfig']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['outputSchema'])) {
            $model->outputSchema = $map['outputSchema'];
        }
        if (isset($map['refId'])) {
            $model->refId = $map['refId'];
        }
        if (isset($map['refProviderCorpId'])) {
            $model->refProviderCorpId = $map['refProviderCorpId'];
        }
        if (isset($map['refType'])) {
            $model->refType = $map['refType'];
        }

        return $model;
    }
}
