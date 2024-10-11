<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateTopboxRequest\cardData;
use AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateTopboxRequest\cardSettings;
use AlibabaCloud\Tea\Model;

class CreateTopboxRequest extends Model
{
    /**
     * @example abcxxx
     *
     * @var string
     */
    public $callbackRouteKey;

    /**
     * @description This parameter is required.
     *
     * @var cardData
     */
    public $cardData;

    /**
     * @var cardSettings
     */
    public $cardSettings;

    /**
     * @description This parameter is required.
     *
     * @example 56xxx-xxx
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $conversationType;

    /**
     * @example COOLAPP-x-xxx
     *
     * @var string
     */
    public $coolAppCode;

    /**
     * @example 1850042969000
     *
     * @var int
     */
    public $expiredTime;

    /**
     * @example xxx-xxx-xxx
     *
     * @var string
     */
    public $groupTemplateId;

    /**
     * @example cidxxxxx==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @example 123xxx
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @example ios|win
     *
     * @var string
     */
    public $platforms;

    /**
     * @var string[]
     */
    public $receiverUnionIdList;

    /**
     * @var string[]
     */
    public $receiverUserIdList;

    /**
     * @example dingxxx
     *
     * @var string
     */
    public $robotCode;

    /**
     * @example jHsR7xxx
     *
     * @var string
     */
    public $unionId;

    /**
     * @var UnionIdPrivateDataMapValue[]
     */
    public $unionIdPrivateDataMap;

    /**
     * @example 011xxx
     *
     * @var string
     */
    public $userId;

    /**
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
        'unionId'               => 'unionId',
        'unionIdPrivateDataMap' => 'unionIdPrivateDataMap',
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
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->unionIdPrivateDataMap) {
            $res['unionIdPrivateDataMap'] = [];
            if (null !== $this->unionIdPrivateDataMap && \is_array($this->unionIdPrivateDataMap)) {
                foreach ($this->unionIdPrivateDataMap as $key => $val) {
                    $res['unionIdPrivateDataMap'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
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
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['unionIdPrivateDataMap'])) {
            $model->unionIdPrivateDataMap = $map['unionIdPrivateDataMap'];
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
