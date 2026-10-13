<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverAICardRequest\a2uiAnnotations;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverAICardRequest\imGroupOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverAICardRequest\imGroupOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverAICardRequest\imRobotOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverAICardRequest\imRobotOpenSpaceModel;
use AlibabaCloud\Tea\Model;

class CreateAndDeliverAICardRequest extends Model
{
    /**
     * @var a2uiAnnotations[]
     */
    public $a2uiAnnotations;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $a2uiMessages;

    /**
     * @var bool
     */
    public $atAll;

    /**
     * @var string[]
     */
    public $bizContext;

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
     * @var string[]
     */
    public $cardAtUserIds;

    /**
     * @description This parameter is required.
     *
     * @example PROCESSING
     *
     * @var string
     */
    public $flowStatus;

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
     * @description This parameter is required.
     *
     * @example dtv1.card//im_group.cid_example
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
     * @example 1.0
     *
     * @var string
     */
    public $protocolVersion;

    /**
     * @var string
     */
    public $summary;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var int
     */
    public $userIdType;
    protected $_name = [
        'a2uiAnnotations' => 'a2uiAnnotations',
        'a2uiMessages' => 'a2uiMessages',
        'atAll' => 'atAll',
        'bizContext' => 'bizContext',
        'callbackRouteKey' => 'callbackRouteKey',
        'callbackType' => 'callbackType',
        'cardAtUserIds' => 'cardAtUserIds',
        'flowStatus' => 'flowStatus',
        'imGroupOpenDeliverModel' => 'imGroupOpenDeliverModel',
        'imGroupOpenSpaceModel' => 'imGroupOpenSpaceModel',
        'imRobotOpenDeliverModel' => 'imRobotOpenDeliverModel',
        'imRobotOpenSpaceModel' => 'imRobotOpenSpaceModel',
        'openSpaceId' => 'openSpaceId',
        'outTrackId' => 'outTrackId',
        'protocolVersion' => 'protocolVersion',
        'summary' => 'summary',
        'userId' => 'userId',
        'userIdType' => 'userIdType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->a2uiAnnotations) {
            $res['a2uiAnnotations'] = [];
            if (null !== $this->a2uiAnnotations && \is_array($this->a2uiAnnotations)) {
                $n = 0;
                foreach ($this->a2uiAnnotations as $item) {
                    $res['a2uiAnnotations'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->a2uiMessages) {
            $res['a2uiMessages'] = $this->a2uiMessages;
        }
        if (null !== $this->atAll) {
            $res['atAll'] = $this->atAll;
        }
        if (null !== $this->bizContext) {
            $res['bizContext'] = $this->bizContext;
        }
        if (null !== $this->callbackRouteKey) {
            $res['callbackRouteKey'] = $this->callbackRouteKey;
        }
        if (null !== $this->callbackType) {
            $res['callbackType'] = $this->callbackType;
        }
        if (null !== $this->cardAtUserIds) {
            $res['cardAtUserIds'] = $this->cardAtUserIds;
        }
        if (null !== $this->flowStatus) {
            $res['flowStatus'] = $this->flowStatus;
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
        if (null !== $this->openSpaceId) {
            $res['openSpaceId'] = $this->openSpaceId;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->protocolVersion) {
            $res['protocolVersion'] = $this->protocolVersion;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
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
     * @return CreateAndDeliverAICardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['a2uiAnnotations'])) {
            if (!empty($map['a2uiAnnotations'])) {
                $model->a2uiAnnotations = [];
                $n = 0;
                foreach ($map['a2uiAnnotations'] as $item) {
                    $model->a2uiAnnotations[$n++] = null !== $item ? a2uiAnnotations::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['a2uiMessages'])) {
            if (!empty($map['a2uiMessages'])) {
                $model->a2uiMessages = $map['a2uiMessages'];
            }
        }
        if (isset($map['atAll'])) {
            $model->atAll = $map['atAll'];
        }
        if (isset($map['bizContext'])) {
            $model->bizContext = $map['bizContext'];
        }
        if (isset($map['callbackRouteKey'])) {
            $model->callbackRouteKey = $map['callbackRouteKey'];
        }
        if (isset($map['callbackType'])) {
            $model->callbackType = $map['callbackType'];
        }
        if (isset($map['cardAtUserIds'])) {
            if (!empty($map['cardAtUserIds'])) {
                $model->cardAtUserIds = $map['cardAtUserIds'];
            }
        }
        if (isset($map['flowStatus'])) {
            $model->flowStatus = $map['flowStatus'];
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
        if (isset($map['openSpaceId'])) {
            $model->openSpaceId = $map['openSpaceId'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['protocolVersion'])) {
            $model->protocolVersion = $map['protocolVersion'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
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
