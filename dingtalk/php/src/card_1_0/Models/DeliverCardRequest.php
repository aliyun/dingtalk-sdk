<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest\coFeedOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest\docOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest\imGroupOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest\imRobotOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest\topOpenDeliverModel;
use AlibabaCloud\Tea\Model;

class DeliverCardRequest extends Model
{
    /**
     * @var coFeedOpenDeliverModel
     */
    public $coFeedOpenDeliverModel;

    /**
     * @var docOpenDeliverModel
     */
    public $docOpenDeliverModel;

    /**
     * @var imGroupOpenDeliverModel
     */
    public $imGroupOpenDeliverModel;

    /**
     * @var imRobotOpenDeliverModel
     */
    public $imRobotOpenDeliverModel;

    /**
     * @example dtv1.card//im_group.cidp4Gh*******VCQ==;im_robot.manager****67;co_feed.manager****67;one_box.cidp4Gh*******VCQ==
     *
     * @var string
     */
    public $openSpaceId;

    /**
     * @example out_track_id_123456
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @var topOpenDeliverModel
     */
    public $topOpenDeliverModel;

    /**
     * @example 1
     *
     * @var int
     */
    public $userIdType;
    protected $_name = [
        'coFeedOpenDeliverModel'  => 'coFeedOpenDeliverModel',
        'docOpenDeliverModel'     => 'docOpenDeliverModel',
        'imGroupOpenDeliverModel' => 'imGroupOpenDeliverModel',
        'imRobotOpenDeliverModel' => 'imRobotOpenDeliverModel',
        'openSpaceId'             => 'openSpaceId',
        'outTrackId'              => 'outTrackId',
        'topOpenDeliverModel'     => 'topOpenDeliverModel',
        'userIdType'              => 'userIdType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->coFeedOpenDeliverModel) {
            $res['coFeedOpenDeliverModel'] = null !== $this->coFeedOpenDeliverModel ? $this->coFeedOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->docOpenDeliverModel) {
            $res['docOpenDeliverModel'] = null !== $this->docOpenDeliverModel ? $this->docOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->imGroupOpenDeliverModel) {
            $res['imGroupOpenDeliverModel'] = null !== $this->imGroupOpenDeliverModel ? $this->imGroupOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->imRobotOpenDeliverModel) {
            $res['imRobotOpenDeliverModel'] = null !== $this->imRobotOpenDeliverModel ? $this->imRobotOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->openSpaceId) {
            $res['openSpaceId'] = $this->openSpaceId;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->topOpenDeliverModel) {
            $res['topOpenDeliverModel'] = null !== $this->topOpenDeliverModel ? $this->topOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->userIdType) {
            $res['userIdType'] = $this->userIdType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeliverCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coFeedOpenDeliverModel'])) {
            $model->coFeedOpenDeliverModel = coFeedOpenDeliverModel::fromMap($map['coFeedOpenDeliverModel']);
        }
        if (isset($map['docOpenDeliverModel'])) {
            $model->docOpenDeliverModel = docOpenDeliverModel::fromMap($map['docOpenDeliverModel']);
        }
        if (isset($map['imGroupOpenDeliverModel'])) {
            $model->imGroupOpenDeliverModel = imGroupOpenDeliverModel::fromMap($map['imGroupOpenDeliverModel']);
        }
        if (isset($map['imRobotOpenDeliverModel'])) {
            $model->imRobotOpenDeliverModel = imRobotOpenDeliverModel::fromMap($map['imRobotOpenDeliverModel']);
        }
        if (isset($map['openSpaceId'])) {
            $model->openSpaceId = $map['openSpaceId'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['topOpenDeliverModel'])) {
            $model->topOpenDeliverModel = topOpenDeliverModel::fromMap($map['topOpenDeliverModel']);
        }
        if (isset($map['userIdType'])) {
            $model->userIdType = $map['userIdType'];
        }

        return $model;
    }
}
