<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateUserOwnnessRequest extends Model
{
    /**
     * @description 状态类型
     *
     * @var int
     */
    public $ownenssType;

    /**
     * @description 业务标志id
     *
     * @var int
     */
    public $id;

    /**
     * @description 开始时间戳（毫秒）
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 结束时间戳（毫秒）
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 删除标记
     *
     * @var int
     */
    public $deletedFlag;
    protected $_name = [
        'ownenssType' => 'ownenssType',
        'id'          => 'id',
        'startTime'   => 'startTime',
        'endTime'     => 'endTime',
        'deletedFlag' => 'deletedFlag',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ownenssType) {
            $res['ownenssType'] = $this->ownenssType;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->deletedFlag) {
            $res['deletedFlag'] = $this->deletedFlag;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateUserOwnnessRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ownenssType'])) {
            $model->ownenssType = $map['ownenssType'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['deletedFlag'])) {
            $model->deletedFlag = $map['deletedFlag'];
        }

        return $model;
    }
}
