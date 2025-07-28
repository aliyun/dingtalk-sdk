<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateUserOwnnessRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1-删除，0-正常
     *
     * @var int
     */
    public $deletedFlag;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $endTime;

    /**
     * @description This parameter is required.
     *
     * @example 123456
     *
     * @var int
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 1-请假，3-出差
     *
     * @var int
     */
    public $ownenssType;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $startTime;
    protected $_name = [
        'deletedFlag' => 'deletedFlag',
        'endTime' => 'endTime',
        'id' => 'id',
        'ownenssType' => 'ownenssType',
        'startTime' => 'startTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deletedFlag) {
            $res['deletedFlag'] = $this->deletedFlag;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->ownenssType) {
            $res['ownenssType'] = $this->ownenssType;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
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
        if (isset($map['deletedFlag'])) {
            $model->deletedFlag = $map['deletedFlag'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['ownenssType'])) {
            $model->ownenssType = $map['ownenssType'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
