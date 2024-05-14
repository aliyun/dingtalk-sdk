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
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\imSingleOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\imSingleOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\openDynamicDataConfig;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\topOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest\topOpenSpaceModel;
use AlibabaCloud\Tea\Model;

class CreateAndDeliverRequest extends Model
{
    /**
     * @var string
     */
    public $callbackRouteKey;

    /**
     * @example STREAM
     *
     * @var string
     */
    public $callbackType;

    /**
     * @description This parameter is required.
     *
     * @var cardData
     */
    public $cardData;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @var coFeedOpenDeliverModel
     */
    public $coFeedOpenDeliverModel;

    /**
     * @var coFeedOpenSpaceModel
     */
    public $coFeedOpenSpaceModel;

    /**
     * @var docOpenDeliverModel
     */
    public $docOpenDeliverModel;

    /**
     * @var imGroupOpenDeliverModel
     */
    public $imGroupOpenDeliverModel;

    /**
     * @var imGroupOpenSpaceModel
     */
    public $imGroupOpenSpaceModel;

    /**
     * @var imRobotOpenDeliverModel
     */
    public $imRobotOpenDeliverModel;

    /**
     * @var imRobotOpenSpaceModel
     */
    public $imRobotOpenSpaceModel;

    /**
     * @var imSingleOpenDeliverModel
     */
    public $imSingleOpenDeliverModel;

    /**
     * @var imSingleOpenSpaceModel
     */
    public $imSingleOpenSpaceModel;

    /**
     * @var openDynamicDataConfig
     */
    public $openDynamicDataConfig;

    /**
     * @description This parameter is required.
     *
     * @example dtv1.card//im_group.cidp4Gh*******VCQ==;im_robot.manager****67;im_robot.staff****89;co_feed.manager****67;one_box.cidp4Gh*******VCQ==;
     *
     * @var string
     */
    public $openSpaceId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @var PrivateDataValue[]
     */
    public $privateData;

    /**
     * @var topOpenDeliverModel
     */
    public $topOpenDeliverModel;

    /**
     * @var topOpenSpaceModel
     */
    public $topOpenSpaceModel;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var int
     */
    public $userIdType;
    protected $_name = [
        'callbackRouteKey'         => 'callbackRouteKey',
        'callbackType'             => 'callbackType',
        'cardData'                 => 'cardData',
        'cardTemplateId'           => 'cardTemplateId',
        'coFeedOpenDeliverModel'   => 'coFeedOpenDeliverModel',
        'coFeedOpenSpaceModel'     => 'coFeedOpenSpaceModel',
        'docOpenDeliverModel'      => 'docOpenDeliverModel',
        'imGroupOpenDeliverModel'  => 'imGroupOpenDeliverModel',
        'imGroupOpenSpaceModel'    => 'imGroupOpenSpaceModel',
        'imRobotOpenDeliverModel'  => 'imRobotOpenDeliverModel',
        'imRobotOpenSpaceModel'    => 'imRobotOpenSpaceModel',
        'imSingleOpenDeliverModel' => 'imSingleOpenDeliverModel',
        'imSingleOpenSpaceModel'   => 'imSingleOpenSpaceModel',
        'openDynamicDataConfig'    => 'openDynamicDataConfig',
        'openSpaceId'              => 'openSpaceId',
        'outTrackId'               => 'outTrackId',
        'privateData'              => 'privateData',
        'topOpenDeliverModel'      => 'topOpenDeliverModel',
        'topOpenSpaceModel'        => 'topOpenSpaceModel',
        'userId'                   => 'userId',
        'userIdType'               => 'userIdType',
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
        if (null !== $this->callbackType) {
            $res['callbackType'] = $this->callbackType;
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
        if (isset($map['callbackType'])) {
            $model->callbackType = $map['callbackType'];
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

        return $model;
    }
}
