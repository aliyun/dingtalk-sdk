<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateUnfurlingRegisterRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 123xxxx
     *
     * @var string
     */
    public $apiSecret;

    /**
     * @description This parameter is required.
     *
     * @example 3102xxxxxxx
     *
     * @var string
     */
    public $appId;

    /**
     * @var int
     */
    public $callbackType;

    /**
     * @description This parameter is required.
     *
     * @example https://xxx.xxx.com/api/dingtalk/link_unfurling
     *
     * @var string
     */
    public $callbackUrl;

    /**
     * @description This parameter is required.
     *
     * @example d7b9xxx-xxx-xxxx-xxxx-xxxxxxx.schema
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @description This parameter is required.
     *
     * @example www.dingtalk.com
     *
     * @var string
     */
    public $domain;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example /a
     *
     * @var string
     */
    public $path;

    /**
     * @example 规则描述
     *
     * @var string
     */
    public $ruleDesc;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $ruleMatchType;

    /**
     * @description This parameter is required.
     *
     * @example 37xxxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'apiSecret' => 'apiSecret',
        'appId' => 'appId',
        'callbackType' => 'callbackType',
        'callbackUrl' => 'callbackUrl',
        'cardTemplateId' => 'cardTemplateId',
        'domain' => 'domain',
        'id' => 'id',
        'path' => 'path',
        'ruleDesc' => 'ruleDesc',
        'ruleMatchType' => 'ruleMatchType',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->apiSecret) {
            $res['apiSecret'] = $this->apiSecret;
        }
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->callbackType) {
            $res['callbackType'] = $this->callbackType;
        }
        if (null !== $this->callbackUrl) {
            $res['callbackUrl'] = $this->callbackUrl;
        }
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }
        if (null !== $this->domain) {
            $res['domain'] = $this->domain;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->path) {
            $res['path'] = $this->path;
        }
        if (null !== $this->ruleDesc) {
            $res['ruleDesc'] = $this->ruleDesc;
        }
        if (null !== $this->ruleMatchType) {
            $res['ruleMatchType'] = $this->ruleMatchType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateUnfurlingRegisterRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['apiSecret'])) {
            $model->apiSecret = $map['apiSecret'];
        }
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['callbackType'])) {
            $model->callbackType = $map['callbackType'];
        }
        if (isset($map['callbackUrl'])) {
            $model->callbackUrl = $map['callbackUrl'];
        }
        if (isset($map['cardTemplateId'])) {
            $model->cardTemplateId = $map['cardTemplateId'];
        }
        if (isset($map['domain'])) {
            $model->domain = $map['domain'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['path'])) {
            $model->path = $map['path'];
        }
        if (isset($map['ruleDesc'])) {
            $model->ruleDesc = $map['ruleDesc'];
        }
        if (isset($map['ruleMatchType'])) {
            $model->ruleMatchType = $map['ruleMatchType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
