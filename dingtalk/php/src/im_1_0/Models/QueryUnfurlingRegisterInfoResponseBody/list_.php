<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryUnfurlingRegisterInfoResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $apiSecret;

    /**
     * @var string
     */
    public $appId;

    /**
     * @var string
     */
    public $appName;

    /**
     * @var int
     */
    public $callbackType;

    /**
     * @var string
     */
    public $callbackUrl;

    /**
     * @var string
     */
    public $cardTemplateId;

    /**
     * @var string
     */
    public $creatorUserId;

    /**
     * @var string
     */
    public $domain;

    /**
     * @var string[]
     */
    public $grayGroupIdList;

    /**
     * @var string[]
     */
    public $grayUserIdList;

    /**
     * @var string
     */
    public $hsfMethodName;

    /**
     * @var string
     */
    public $hsfServiceName;

    /**
     * @var string
     */
    public $hsfVersion;

    /**
     * @var int
     */
    public $id;

    /**
     * @var string
     */
    public $path;

    /**
     * @var string
     */
    public $ruleDesc;

    /**
     * @var int
     */
    public $ruleMatchType;

    /**
     * @var int
     */
    public $status;
    protected $_name = [
        'apiSecret'       => 'apiSecret',
        'appId'           => 'appId',
        'appName'         => 'appName',
        'callbackType'    => 'callbackType',
        'callbackUrl'     => 'callbackUrl',
        'cardTemplateId'  => 'cardTemplateId',
        'creatorUserId'   => 'creatorUserId',
        'domain'          => 'domain',
        'grayGroupIdList' => 'grayGroupIdList',
        'grayUserIdList'  => 'grayUserIdList',
        'hsfMethodName'   => 'hsfMethodName',
        'hsfServiceName'  => 'hsfServiceName',
        'hsfVersion'      => 'hsfVersion',
        'id'              => 'id',
        'path'            => 'path',
        'ruleDesc'        => 'ruleDesc',
        'ruleMatchType'   => 'ruleMatchType',
        'status'          => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->apiSecret) {
            $res['apiSecret'] = $this->apiSecret;
        }
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
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
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->domain) {
            $res['domain'] = $this->domain;
        }
        if (null !== $this->grayGroupIdList) {
            $res['grayGroupIdList'] = $this->grayGroupIdList;
        }
        if (null !== $this->grayUserIdList) {
            $res['grayUserIdList'] = $this->grayUserIdList;
        }
        if (null !== $this->hsfMethodName) {
            $res['hsfMethodName'] = $this->hsfMethodName;
        }
        if (null !== $this->hsfServiceName) {
            $res['hsfServiceName'] = $this->hsfServiceName;
        }
        if (null !== $this->hsfVersion) {
            $res['hsfVersion'] = $this->hsfVersion;
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
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
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
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
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
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['domain'])) {
            $model->domain = $map['domain'];
        }
        if (isset($map['grayGroupIdList'])) {
            if (!empty($map['grayGroupIdList'])) {
                $model->grayGroupIdList = $map['grayGroupIdList'];
            }
        }
        if (isset($map['grayUserIdList'])) {
            if (!empty($map['grayUserIdList'])) {
                $model->grayUserIdList = $map['grayUserIdList'];
            }
        }
        if (isset($map['hsfMethodName'])) {
            $model->hsfMethodName = $map['hsfMethodName'];
        }
        if (isset($map['hsfServiceName'])) {
            $model->hsfServiceName = $map['hsfServiceName'];
        }
        if (isset($map['hsfVersion'])) {
            $model->hsfVersion = $map['hsfVersion'];
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
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
