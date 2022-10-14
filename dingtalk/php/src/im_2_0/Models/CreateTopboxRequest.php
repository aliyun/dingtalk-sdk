<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateTopboxRequest\cardData;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateTopboxRequest\cardSettings;
use AlibabaCloud\Tea\Model;

class CreateTopboxRequest extends Model
{
    /**
     * @description 可控制卡片回调时的路由Key，用于指定特定的callbackUrl。
     *
     * @var string
     */
    public $callbackRouteKey;

    /**
     * @description 卡片数据。
     *
     * @var cardData
     */
    public $cardData;

    /**
     * @description 卡片设置项。
     *
     * @var cardSettings
     */
    public $cardSettings;

    /**
     * @description 互动卡片的消息模板ID
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @description 会话类型。
     *
     * @var int
     */
    public $conversationType;

    /**
     * @description 酷应用编码。
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @description 吊顶的过期时间，绝对时间。
     *
     * @var int
     */
    public $expiredTime;

    /**
     * @description 群模板id。
     *
     * @var string
     */
    public $groupTemplateId;

    /**
     * @description 会话id。
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 唯一标识一张卡片的外部ID。
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @description 期望吊顶的端，如果有多个用“｜”分隔。 例如：ios|mac|android|win表示iOS、MAC、安卓和windows端。
     *
     * @var string
     */
    public $platforms;

    /**
     * @description 吊顶可见者unionId，最多可传100个unionId。
     *
     * @var string[]
     */
    public $receiverUnionIdList;

    /**
     * @description 吊顶可见者userId，最多可传100个userId。
     *
     * @var string[]
     */
    public $receiverUserIdList;

    /**
     * @description 单聊助手会话，机器人编码。
     *
     * @var string
     */
    public $robotCode;

    /**
     * @description 卡片模板unionId差异用户参数。
     *
     * @var UnionIdPrivateDataMapValue[]
     */
    public $unionIdPrivateDataMap;

    /**
     * @description 单聊助手会话，用户unionId。
     *
     * @var string
     */
    public $unoinId;

    /**
     * @description 单聊助手会话，用户userId。
     *
     * @var string
     */
    public $userId;

    /**
     * @description 卡片模板userId差异用户参数。
     *
     * @var UserIdPrivateDataMapValue[]
     */
    public $userIdPrivateDataMap;
    protected $_name = [
        'callbackRouteKey'      => 'callbackRouteKey',
        'cardData'              => 'cardData',
        'cardSettings'          => 'cardSettings',
        'cardTemplateId'        => 'cardTemplateId',
        'conversationType'      => 'conversationType',
        'coolAppCode'           => 'coolAppCode',
        'expiredTime'           => 'expiredTime',
        'groupTemplateId'       => 'groupTemplateId',
        'openConversationId'    => 'openConversationId',
        'outTrackId'            => 'outTrackId',
        'platforms'             => 'platforms',
        'receiverUnionIdList'   => 'receiverUnionIdList',
        'receiverUserIdList'    => 'receiverUserIdList',
        'robotCode'             => 'robotCode',
        'unionIdPrivateDataMap' => 'unionIdPrivateDataMap',
        'unoinId'               => 'unoinId',
        'userId'                => 'userId',
        'userIdPrivateDataMap'  => 'userIdPrivateDataMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->callbackRouteKey) {
            $res['callbackRouteKey'] = $this->callbackRouteKey;
        }
        if (null !== $this->cardData) {
            $res['cardData'] = null !== $this->cardData ? $this->cardData->toMap() : null;
        }
        if (null !== $this->cardSettings) {
            $res['cardSettings'] = null !== $this->cardSettings ? $this->cardSettings->toMap() : null;
        }
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }
        if (null !== $this->conversationType) {
            $res['conversationType'] = $this->conversationType;
        }
        if (null !== $this->coolAppCode) {
            $res['coolAppCode'] = $this->coolAppCode;
        }
        if (null !== $this->expiredTime) {
            $res['expiredTime'] = $this->expiredTime;
        }
        if (null !== $this->groupTemplateId) {
            $res['groupTemplateId'] = $this->groupTemplateId;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->platforms) {
            $res['platforms'] = $this->platforms;
        }
        if (null !== $this->receiverUnionIdList) {
            $res['receiverUnionIdList'] = $this->receiverUnionIdList;
        }
        if (null !== $this->receiverUserIdList) {
            $res['receiverUserIdList'] = $this->receiverUserIdList;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->unionIdPrivateDataMap) {
            $res['unionIdPrivateDataMap'] = [];
            if (null !== $this->unionIdPrivateDataMap && \is_array($this->unionIdPrivateDataMap)) {
                foreach ($this->unionIdPrivateDataMap as $key => $val) {
                    $res['unionIdPrivateDataMap'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->unoinId) {
            $res['unoinId'] = $this->unoinId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userIdPrivateDataMap) {
            $res['userIdPrivateDataMap'] = [];
            if (null !== $this->userIdPrivateDataMap && \is_array($this->userIdPrivateDataMap)) {
                foreach ($this->userIdPrivateDataMap as $key => $val) {
                    $res['userIdPrivateDataMap'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTopboxRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callbackRouteKey'])) {
            $model->callbackRouteKey = $map['callbackRouteKey'];
        }
        if (isset($map['cardData'])) {
            $model->cardData = cardData::fromMap($map['cardData']);
        }
        if (isset($map['cardSettings'])) {
            $model->cardSettings = cardSettings::fromMap($map['cardSettings']);
        }
        if (isset($map['cardTemplateId'])) {
            $model->cardTemplateId = $map['cardTemplateId'];
        }
        if (isset($map['conversationType'])) {
            $model->conversationType = $map['conversationType'];
        }
        if (isset($map['coolAppCode'])) {
            $model->coolAppCode = $map['coolAppCode'];
        }
        if (isset($map['expiredTime'])) {
            $model->expiredTime = $map['expiredTime'];
        }
        if (isset($map['groupTemplateId'])) {
            $model->groupTemplateId = $map['groupTemplateId'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['platforms'])) {
            $model->platforms = $map['platforms'];
        }
        if (isset($map['receiverUnionIdList'])) {
            if (!empty($map['receiverUnionIdList'])) {
                $model->receiverUnionIdList = $map['receiverUnionIdList'];
            }
        }
        if (isset($map['receiverUserIdList'])) {
            if (!empty($map['receiverUserIdList'])) {
                $model->receiverUserIdList = $map['receiverUserIdList'];
            }
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['unionIdPrivateDataMap'])) {
            $model->unionIdPrivateDataMap = $map['unionIdPrivateDataMap'];
        }
        if (isset($map['unoinId'])) {
            $model->unoinId = $map['unoinId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userIdPrivateDataMap'])) {
            $model->userIdPrivateDataMap = $map['userIdPrivateDataMap'];
        }

        return $model;
    }
}
