<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class TopboxOpenRequest extends Model
{
    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @description 接收卡片的群的openConversationId
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @description 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingOauthAppId;

    /**
     * @description 吊顶的过期时间（绝对时间）
     *
     * @var int
     */
    public $expiredTime;

    /**
     * @description 期望吊顶的端（多个'|'隔开，如："ios|win|"）
     *
     * @var string
     */
    public $platforms;

    /**
     * @description 酷应用编码
     *
     * @var string
     */
    public $coolAppCode;
    protected $_name = [
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'openConversationId' => 'openConversationId',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'outTrackId'         => 'outTrackId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingOrgId'          => 'dingOrgId',
        'dingOauthAppId'     => 'dingOauthAppId',
        'expiredTime'        => 'expiredTime',
        'platforms'          => 'platforms',
        'coolAppCode'        => 'coolAppCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingOauthAppId) {
            $res['dingOauthAppId'] = $this->dingOauthAppId;
        }
        if (null !== $this->expiredTime) {
            $res['expiredTime'] = $this->expiredTime;
        }
        if (null !== $this->platforms) {
            $res['platforms'] = $this->platforms;
        }
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TopboxOpenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingOauthAppId'])) {
            $model->dingOauthAppId = $map['dingOauthAppId'];
        }
        if (isset($map['expiredTime'])) {
            $model->expiredTime = $map['expiredTime'];
        }
        if (isset($map['platforms'])) {
            $model->platforms = $map['platforms'];
        }
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }

        return $model;
    }
}
