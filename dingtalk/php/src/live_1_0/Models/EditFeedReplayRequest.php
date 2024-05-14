<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class EditFeedReplayRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1617356058000
     *
     * @var int
     */
    public $editEndTime;

    /**
     * @description This parameter is required.
     *
     * @example 1617336058000
     *
     * @var int
     */
    public $editStartTime;

    /**
     * @description This parameter is required.
     *
     * @example 1206186351746728
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'editEndTime'   => 'editEndTime',
        'editStartTime' => 'editStartTime',
        'userId'        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->editEndTime) {
            $res['editEndTime'] = $this->editEndTime;
        }
        if (null !== $this->editStartTime) {
            $res['editStartTime'] = $this->editStartTime;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EditFeedReplayRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['editEndTime'])) {
            $model->editEndTime = $map['editEndTime'];
        }
        if (isset($map['editStartTime'])) {
            $model->editStartTime = $map['editStartTime'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
