<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\cardData;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\coFeedOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\coFeedOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\imGroupOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\imGroupOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\imSingleOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\imSingleOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\openDynamicDataConfig;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\topOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\topOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\workBenchOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\workBenchOpenSpaceModel;
use AlibabaCloud\Tea\Model;

class CreateAndDeliverRequest extends Model
{
    /**
     * @description 卡片回调时的路由 key
     *
     * @var string
     */
    public $callbackRouteKey;

    /**
     * @var string[]
     */
    public $cardAtUserIds;

    /**
     * @description 卡片数据
     *
     * @var cardData
     */
    public $cardData;

    /**
     * @description 卡片内容模板ID
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @description 协作投放参数
     *
     * @var coFeedOpenDeliverModel
     */
    public $coFeedOpenDeliverModel;

    /**
     * @description 协作场域信息
     *
     * @var coFeedOpenSpaceModel
     */
    public $coFeedOpenSpaceModel;

    /**
     * @description 群聊投放参数
     *
     * @var imGroupOpenDeliverModel
     */
    public $imGroupOpenDeliverModel;

    /**
     * @description IM群聊场域信息
     *
     * @var imGroupOpenSpaceModel
     */
    public $imGroupOpenSpaceModel;

    /**
     * @description 单聊场域投放参数
     *
     * @var imSingleOpenDeliverModel
     */
    public $imSingleOpenDeliverModel;

    /**
     * @description IM单聊场域信息
     *
     * @var imSingleOpenSpaceModel
     */
    public $imSingleOpenSpaceModel;

    /**
     * @description 动态数据源配置
     *
     * @var openDynamicDataConfig
     */
    public $openDynamicDataConfig;

    /**
     * @description dt.card//spaceType.spaceId;spaceType.spaceId
     *
     * @var string
     */
    public $openSpaceId;

    /**
     * @description 外部业务标识符
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @var PrivateDataValue[]
     */
    public $privateData;

    /**
     * @description 吊顶投放参数
     *
     * @var topOpenDeliverModel
     */
    public $topOpenDeliverModel;

    /**
     * @description 吊顶场域信息
     *
     * @var topOpenSpaceModel
     */
    public $topOpenSpaceModel;

    /**
     * @description 卡片创建者 id
     *
     * @var string
     */
    public $userId;

    /**
     * @var int
     */
    public $userIdType;

    /**
     * @description 工作台投放参数
     *
     * @var workBenchOpenDeliverModel
     */
    public $workBenchOpenDeliverModel;

    /**
     * @description 工作台场域信息
     *
     * @var workBenchOpenSpaceModel
     */
    public $workBenchOpenSpaceModel;
    protected $_name = [
        'callbackRouteKey'          => 'callbackRouteKey',
        'cardAtUserIds'             => 'cardAtUserIds',
        'cardData'                  => 'cardData',
        'cardTemplateId'            => 'cardTemplateId',
        'coFeedOpenDeliverModel'    => 'coFeedOpenDeliverModel',
        'coFeedOpenSpaceModel'      => 'coFeedOpenSpaceModel',
        'imGroupOpenDeliverModel'   => 'imGroupOpenDeliverModel',
        'imGroupOpenSpaceModel'     => 'imGroupOpenSpaceModel',
        'imSingleOpenDeliverModel'  => 'imSingleOpenDeliverModel',
        'imSingleOpenSpaceModel'    => 'imSingleOpenSpaceModel',
        'openDynamicDataConfig'     => 'openDynamicDataConfig',
        'openSpaceId'               => 'openSpaceId',
        'outTrackId'                => 'outTrackId',
        'privateData'               => 'privateData',
        'topOpenDeliverModel'       => 'topOpenDeliverModel',
        'topOpenSpaceModel'         => 'topOpenSpaceModel',
        'userId'                    => 'userId',
        'userIdType'                => 'userIdType',
        'workBenchOpenDeliverModel' => 'workBenchOpenDeliverModel',
        'workBenchOpenSpaceModel'   => 'workBenchOpenSpaceModel',
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
        if (null !== $this->cardAtUserIds) {
            $res['cardAtUserIds'] = $this->cardAtUserIds;
        }
        if (null !== $this->cardData) {
            $res['cardData'] = null !== $this->cardData ? $this->cardData->toMap() : null;
        }
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }
        if (null !== $this->coFeedOpenDeliverModel) {
            $res['coFeedOpenDeliverModel'] = null !== $this->coFeedOpenDeliverModel ? $this->coFeedOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->coFeedOpenSpaceModel) {
            $res['coFeedOpenSpaceModel'] = null !== $this->coFeedOpenSpaceModel ? $this->coFeedOpenSpaceModel->toMap() : null;
        }
        if (null !== $this->imGroupOpenDeliverModel) {
            $res['imGroupOpenDeliverModel'] = null !== $this->imGroupOpenDeliverModel ? $this->imGroupOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->imGroupOpenSpaceModel) {
            $res['imGroupOpenSpaceModel'] = null !== $this->imGroupOpenSpaceModel ? $this->imGroupOpenSpaceModel->toMap() : null;
        }
        if (null !== $this->imSingleOpenDeliverModel) {
            $res['imSingleOpenDeliverModel'] = null !== $this->imSingleOpenDeliverModel ? $this->imSingleOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->imSingleOpenSpaceModel) {
            $res['imSingleOpenSpaceModel'] = null !== $this->imSingleOpenSpaceModel ? $this->imSingleOpenSpaceModel->toMap() : null;
        }
        if (null !== $this->openDynamicDataConfig) {
            $res['openDynamicDataConfig'] = null !== $this->openDynamicDataConfig ? $this->openDynamicDataConfig->toMap() : null;
        }
        if (null !== $this->openSpaceId) {
            $res['openSpaceId'] = $this->openSpaceId;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->privateData) {
            $res['privateData'] = [];
            if (null !== $this->privateData && \is_array($this->privateData)) {
                foreach ($this->privateData as $key => $val) {
                    $res['privateData'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->topOpenDeliverModel) {
            $res['topOpenDeliverModel'] = null !== $this->topOpenDeliverModel ? $this->topOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->topOpenSpaceModel) {
            $res['topOpenSpaceModel'] = null !== $this->topOpenSpaceModel ? $this->topOpenSpaceModel->toMap() : null;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userIdType) {
            $res['userIdType'] = $this->userIdType;
        }
        if (null !== $this->workBenchOpenDeliverModel) {
            $res['workBenchOpenDeliverModel'] = null !== $this->workBenchOpenDeliverModel ? $this->workBenchOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->workBenchOpenSpaceModel) {
            $res['workBenchOpenSpaceModel'] = null !== $this->workBenchOpenSpaceModel ? $this->workBenchOpenSpaceModel->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAndDeliverRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callbackRouteKey'])) {
            $model->callbackRouteKey = $map['callbackRouteKey'];
        }
        if (isset($map['cardAtUserIds'])) {
            if (!empty($map['cardAtUserIds'])) {
                $model->cardAtUserIds = $map['cardAtUserIds'];
            }
        }
        if (isset($map['cardData'])) {
            $model->cardData = cardData::fromMap($map['cardData']);
        }
        if (isset($map['cardTemplateId'])) {
            $model->cardTemplateId = $map['cardTemplateId'];
        }
        if (isset($map['coFeedOpenDeliverModel'])) {
            $model->coFeedOpenDeliverModel = coFeedOpenDeliverModel::fromMap($map['coFeedOpenDeliverModel']);
        }
        if (isset($map['coFeedOpenSpaceModel'])) {
            $model->coFeedOpenSpaceModel = coFeedOpenSpaceModel::fromMap($map['coFeedOpenSpaceModel']);
        }
        if (isset($map['imGroupOpenDeliverModel'])) {
            $model->imGroupOpenDeliverModel = imGroupOpenDeliverModel::fromMap($map['imGroupOpenDeliverModel']);
        }
        if (isset($map['imGroupOpenSpaceModel'])) {
            $model->imGroupOpenSpaceModel = imGroupOpenSpaceModel::fromMap($map['imGroupOpenSpaceModel']);
        }
        if (isset($map['imSingleOpenDeliverModel'])) {
            $model->imSingleOpenDeliverModel = imSingleOpenDeliverModel::fromMap($map['imSingleOpenDeliverModel']);
        }
        if (isset($map['imSingleOpenSpaceModel'])) {
            $model->imSingleOpenSpaceModel = imSingleOpenSpaceModel::fromMap($map['imSingleOpenSpaceModel']);
        }
        if (isset($map['openDynamicDataConfig'])) {
            $model->openDynamicDataConfig = openDynamicDataConfig::fromMap($map['openDynamicDataConfig']);
        }
        if (isset($map['openSpaceId'])) {
            $model->openSpaceId = $map['openSpaceId'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['privateData'])) {
            $model->privateData = $map['privateData'];
        }
        if (isset($map['topOpenDeliverModel'])) {
            $model->topOpenDeliverModel = topOpenDeliverModel::fromMap($map['topOpenDeliverModel']);
        }
        if (isset($map['topOpenSpaceModel'])) {
            $model->topOpenSpaceModel = topOpenSpaceModel::fromMap($map['topOpenSpaceModel']);
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userIdType'])) {
            $model->userIdType = $map['userIdType'];
        }
        if (isset($map['workBenchOpenDeliverModel'])) {
            $model->workBenchOpenDeliverModel = workBenchOpenDeliverModel::fromMap($map['workBenchOpenDeliverModel']);
        }
        if (isset($map['workBenchOpenSpaceModel'])) {
            $model->workBenchOpenSpaceModel = workBenchOpenSpaceModel::fromMap($map['workBenchOpenSpaceModel']);
        }

        return $model;
    }
}
