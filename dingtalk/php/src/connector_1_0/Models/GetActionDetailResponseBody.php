<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconnector_1_0\Models\GetActionDetailResponseBody\integrationConfig;
use AlibabaCloud\Tea\Model;

class GetActionDetailResponseBody extends Model
{
    /**
     * @example dca://ding32fff839a3e0105d.connect.dingtalk.com/ding32fff839a3e0105d/action/G-ACT-101FDEBD3C6E213DB474000P
     *
     * @var string
     */
    public $connectAssetUri;

    /**
     * @example {"title":"A registration form","description":"A simple form example.","type":"object","required":[],"properties":{"password":{"type":"string","title":"Password","minLength":3},"telephone":{"type":"string","title":"Telephone","minLength":10}}}
     *
     * @var string
     */
    public $inputSchema;

    /**
     * @var integrationConfig
     */
    public $integrationConfig;

    /**
     * @example XX执行动作
     *
     * @var string
     */
    public $name;

    /**
     * @example {"title":"A registration form","description":"A simple form example.","type":"object","required":[],"properties":{"password":{"type":"string","title":"Password","minLength":3},"telephone":{"type":"string","title":"Telephone","minLength":10}}}
     *
     * @var string
     */
    public $outputSchema;

    /**
     * @example G-ACT-101FDEBD3C6E213DB474000P
     *
     * @var string
     */
    public $refId;

    /**
     * @example ding32fff839a3e0105d
     *
     * @var string
     */
    public $refProviderCorpId;

    /**
     * @example action
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
