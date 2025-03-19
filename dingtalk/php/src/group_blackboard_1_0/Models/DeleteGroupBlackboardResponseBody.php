<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgroup_blackboard_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteGroupBlackboardResponseBody extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $isDeleted;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'isDeleted' => 'isDeleted',
        'success' => 'success',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->isDeleted) {
            $res['isDeleted'] = $this->isDeleted;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteGroupBlackboardResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isDeleted'])) {
            $model->isDeleted = $map['isDeleted'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
