<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverResponseBody\result;

use AlibabaCloud\Tea\Model;

class deliverResults extends Model
{
    /**
     * @description 错误信息
     *
     * @var string
     */
    public $errorMsg;

    /**
     * @description 场域Id
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 场域类型 (IM: IM类型，包括群聊和单聊，仅供返回结果使用, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
     *
     * @var string
     */
    public $spaceType;

    /**
     * @description 投放成功
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'errorMsg'  => 'errorMsg',
        'spaceId'   => 'spaceId',
        'spaceType' => 'spaceType',
        'success'   => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->spaceType) {
            $res['spaceType'] = $this->spaceType;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deliverResults
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['spaceType'])) {
            $model->spaceType = $map['spaceType'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
