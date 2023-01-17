<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceRequest\coFeedOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceRequest\imGroupOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceRequest\imRobotOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceRequest\topOpenSpaceModel;
use AlibabaCloud\Tea\Model;

class AppendSpaceRequest extends Model
{
    /**
     * @description 协作场域信息
     *
     * @var coFeedOpenSpaceModel
     */
    public $coFeedOpenSpaceModel;

    /**
     * @description IM群聊场域信息
     *
     * @var imGroupOpenSpaceModel
     */
    public $imGroupOpenSpaceModel;

    /**
     * @description IM群聊场域信息
     *
     * @var imRobotOpenSpaceModel
     */
    public $imRobotOpenSpaceModel;

    /**
     * @description 唯一标识一张卡片的外部Id
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @description 吊顶场域信息
     *
     * @var topOpenSpaceModel
     */
    public $topOpenSpaceModel;
    protected $_name = [
        'coFeedOpenSpaceModel'  => 'coFeedOpenSpaceModel',
        'imGroupOpenSpaceModel' => 'imGroupOpenSpaceModel',
        'imRobotOpenSpaceModel' => 'imRobotOpenSpaceModel',
        'outTrackId'            => 'outTrackId',
        'topOpenSpaceModel'     => 'topOpenSpaceModel',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->coFeedOpenSpaceModel) {
            $res['coFeedOpenSpaceModel'] = null !== $this->coFeedOpenSpaceModel ? $this->coFeedOpenSpaceModel->toMap() : null;
        }
        if (null !== $this->imGroupOpenSpaceModel) {
            $res['imGroupOpenSpaceModel'] = null !== $this->imGroupOpenSpaceModel ? $this->imGroupOpenSpaceModel->toMap() : null;
        }
        if (null !== $this->imRobotOpenSpaceModel) {
            $res['imRobotOpenSpaceModel'] = null !== $this->imRobotOpenSpaceModel ? $this->imRobotOpenSpaceModel->toMap() : null;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->topOpenSpaceModel) {
            $res['topOpenSpaceModel'] = null !== $this->topOpenSpaceModel ? $this->topOpenSpaceModel->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AppendSpaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coFeedOpenSpaceModel'])) {
            $model->coFeedOpenSpaceModel = coFeedOpenSpaceModel::fromMap($map['coFeedOpenSpaceModel']);
        }
        if (isset($map['imGroupOpenSpaceModel'])) {
            $model->imGroupOpenSpaceModel = imGroupOpenSpaceModel::fromMap($map['imGroupOpenSpaceModel']);
        }
        if (isset($map['imRobotOpenSpaceModel'])) {
            $model->imRobotOpenSpaceModel = imRobotOpenSpaceModel::fromMap($map['imRobotOpenSpaceModel']);
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['topOpenSpaceModel'])) {
            $model->topOpenSpaceModel = topOpenSpaceModel::fromMap($map['topOpenSpaceModel']);
        }

        return $model;
    }
}
