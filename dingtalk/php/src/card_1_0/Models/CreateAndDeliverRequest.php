<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\cardData;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\coFeedOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\coFeedOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\docOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\imGroupOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\imGroupOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\imRobotOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\imRobotOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\openDynamicDataConfig;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\topOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\topOpenSpaceModel;
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
     * @description 文档投放参数
     *
     * @var docOpenDeliverModel
     */
    public $docOpenDeliverModel;

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
     * @var imRobotOpenDeliverModel
     */
    public $imRobotOpenDeliverModel;

    /**
     * @description IM单聊场域信息
     *
     * @var imRobotOpenSpaceModel
     */
    public $imRobotOpenSpaceModel;

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
    protected $_name = [
        'callbackRouteKey'        => 'callbackRouteKey',
        'cardData'                => 'cardData',
        'cardTemplateId'          => 'cardTemplateId',
        'coFeedOpenDeliverModel'  => 'coFeedOpenDeliverModel',
        'coFeedOpenSpaceModel'    => 'coFeedOpenSpaceModel',
        'docOpenDeliverModel'     => 'docOpenDeliverModel',
        'imGroupOpenDeliverModel' => 'imGroupOpenDeliverModel',
        'imGroupOpenSpaceModel'   => 'imGroupOpenSpaceModel',
        'imRobotOpenDeliverModel' => 'imRobotOpenDeliverModel',
        'imRobotOpenSpaceModel'   => 'imRobotOpenSpaceModel',
        'openDynamicDataConfig'   => 'openDynamicDataConfig',
        'openSpaceId'             => 'openSpaceId',
        'outTrackId'              => 'outTrackId',
        'privateData'             => 'privateData',
        'topOpenDeliverModel'     => 'topOpenDeliverModel',
        'topOpenSpaceModel'       => 'topOpenSpaceModel',
        'userId'                  => 'userId',
        'userIdType'              => 'userIdType',
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
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }
        if (null !== $this->coFeedOpenDeliverModel) {
            $res['coFeedOpenDeliverModel'] = null !== $this->coFeedOpenDeliverModel ? $this->coFeedOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->coFeedOpenSpaceModel) {
            $res['coFeedOpenSpaceModel'] = null !== $this->coFeedOpenSpaceModel ? $this->coFeedOpenSpaceModel->toMap() : null;
        }
        if (null !== $this->docOpenDeliverModel) {
            $res['docOpenDeliverModel'] = null !== $this->docOpenDeliverModel ? $this->docOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->imGroupOpenDeliverModel) {
            $res['imGroupOpenDeliverModel'] = null !== $this->imGroupOpenDeliverModel ? $this->imGroupOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->imGroupOpenSpaceModel) {
            $res['imGroupOpenSpaceModel'] = null !== $this->imGroupOpenSpaceModel ? $this->imGroupOpenSpaceModel->toMap() : null;
        }
        if (null !== $this->imRobotOpenDeliverModel) {
            $res['imRobotOpenDeliverModel'] = null !== $this->imRobotOpenDeliverModel ? $this->imRobotOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->imRobotOpenSpaceModel) {
            $res['imRobotOpenSpaceModel'] = null !== $this->imRobotOpenSpaceModel ? $this->imRobotOpenSpaceModel->toMap() : null;
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
        if (isset($map['docOpenDeliverModel'])) {
            $model->docOpenDeliverModel = docOpenDeliverModel::fromMap($map['docOpenDeliverModel']);
        }
        if (isset($map['imGroupOpenDeliverModel'])) {
            $model->imGroupOpenDeliverModel = imGroupOpenDeliverModel::fromMap($map['imGroupOpenDeliverModel']);
        }
        if (isset($map['imGroupOpenSpaceModel'])) {
            $model->imGroupOpenSpaceModel = imGroupOpenSpaceModel::fromMap($map['imGroupOpenSpaceModel']);
        }
        if (isset($map['imRobotOpenDeliverModel'])) {
            $model->imRobotOpenDeliverModel = imRobotOpenDeliverModel::fromMap($map['imRobotOpenDeliverModel']);
        }
        if (isset($map['imRobotOpenSpaceModel'])) {
            $model->imRobotOpenSpaceModel = imRobotOpenSpaceModel::fromMap($map['imRobotOpenSpaceModel']);
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

        return $model;
    }
}
