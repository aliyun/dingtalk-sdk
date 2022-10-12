<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest\coFeedOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest\imGroupOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest\imSingleOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest\topOpenDeliverModel;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest\workBenchOpenDeliverModel;
use AlibabaCloud\Tea\Model;

class DeliverCardRequest extends Model
{
    /**
     * @description 协作投放参数
     *
     * @var coFeedOpenDeliverModel
     */
    public $coFeedOpenDeliverModel;

    /**
     * @description 群聊投放参数
     *
     * @var imGroupOpenDeliverModel
     */
    public $imGroupOpenDeliverModel;

    /**
     * @description 单聊场域投放参数
     *
     * @var imSingleOpenDeliverModel
     */
    public $imSingleOpenDeliverModel;

    /**
     * @description dt.card//spaceType.spaceId;spaceType.spaceId
     *
     * @var string
     */
    public $openSpaceId;

    /**
     * @description 外部卡片实例Id
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @description 吊顶投放参数
     *
     * @var topOpenDeliverModel
     */
    public $topOpenDeliverModel;

    /**
     * @description 工作台投放参数
     *
     * @var workBenchOpenDeliverModel
     */
    public $workBenchOpenDeliverModel;
    protected $_name = [
        'coFeedOpenDeliverModel'    => 'coFeedOpenDeliverModel',
        'imGroupOpenDeliverModel'   => 'imGroupOpenDeliverModel',
        'imSingleOpenDeliverModel'  => 'imSingleOpenDeliverModel',
        'openSpaceId'               => 'openSpaceId',
        'outTrackId'                => 'outTrackId',
        'topOpenDeliverModel'       => 'topOpenDeliverModel',
        'workBenchOpenDeliverModel' => 'workBenchOpenDeliverModel',
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
        if (null !== $this->imGroupOpenDeliverModel) {
            $res['imGroupOpenDeliverModel'] = null !== $this->imGroupOpenDeliverModel ? $this->imGroupOpenDeliverModel->toMap() : null;
        }
        if (null !== $this->imSingleOpenDeliverModel) {
            $res['imSingleOpenDeliverModel'] = null !== $this->imSingleOpenDeliverModel ? $this->imSingleOpenDeliverModel->toMap() : null;
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
        if (null !== $this->workBenchOpenDeliverModel) {
            $res['workBenchOpenDeliverModel'] = null !== $this->workBenchOpenDeliverModel ? $this->workBenchOpenDeliverModel->toMap() : null;
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
        if (isset($map['imGroupOpenDeliverModel'])) {
            $model->imGroupOpenDeliverModel = imGroupOpenDeliverModel::fromMap($map['imGroupOpenDeliverModel']);
        }
        if (isset($map['imSingleOpenDeliverModel'])) {
            $model->imSingleOpenDeliverModel = imSingleOpenDeliverModel::fromMap($map['imSingleOpenDeliverModel']);
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
        if (isset($map['workBenchOpenDeliverModel'])) {
            $model->workBenchOpenDeliverModel = workBenchOpenDeliverModel::fromMap($map['workBenchOpenDeliverModel']);
        }

        return $model;
    }
}
