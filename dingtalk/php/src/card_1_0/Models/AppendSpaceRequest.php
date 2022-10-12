<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceRequest\coFeedOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceRequest\imGroupOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceRequest\imSingleOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceRequest\topOpenSpaceModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\AppendSpaceRequest\workBenchOpenSpaceModel;
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
     * @description IM单聊场域信息
     *
     * @var imSingleOpenSpaceModel
     */
    public $imSingleOpenSpaceModel;

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

    /**
     * @description 工作台场域信息
     *
     * @var workBenchOpenSpaceModel
     */
    public $workBenchOpenSpaceModel;
    protected $_name = [
        'coFeedOpenSpaceModel'    => 'coFeedOpenSpaceModel',
        'imGroupOpenSpaceModel'   => 'imGroupOpenSpaceModel',
        'imSingleOpenSpaceModel'  => 'imSingleOpenSpaceModel',
        'outTrackId'              => 'outTrackId',
        'topOpenSpaceModel'       => 'topOpenSpaceModel',
        'workBenchOpenSpaceModel' => 'workBenchOpenSpaceModel',
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
        if (null !== $this->imSingleOpenSpaceModel) {
            $res['imSingleOpenSpaceModel'] = null !== $this->imSingleOpenSpaceModel ? $this->imSingleOpenSpaceModel->toMap() : null;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->topOpenSpaceModel) {
            $res['topOpenSpaceModel'] = null !== $this->topOpenSpaceModel ? $this->topOpenSpaceModel->toMap() : null;
        }
        if (null !== $this->workBenchOpenSpaceModel) {
            $res['workBenchOpenSpaceModel'] = null !== $this->workBenchOpenSpaceModel ? $this->workBenchOpenSpaceModel->toMap() : null;
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
        if (isset($map['imSingleOpenSpaceModel'])) {
            $model->imSingleOpenSpaceModel = imSingleOpenSpaceModel::fromMap($map['imSingleOpenSpaceModel']);
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['topOpenSpaceModel'])) {
            $model->topOpenSpaceModel = topOpenSpaceModel::fromMap($map['topOpenSpaceModel']);
        }
        if (isset($map['workBenchOpenSpaceModel'])) {
            $model->workBenchOpenSpaceModel = workBenchOpenSpaceModel::fromMap($map['workBenchOpenSpaceModel']);
        }

        return $model;
    }
}
