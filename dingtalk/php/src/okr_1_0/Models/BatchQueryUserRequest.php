<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryUserRequest extends Model
{
    /**
     * @var string[]
     */
    public $okrUserIds;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'okrUserIds' => 'okrUserIds',
        'userIds' => 'userIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->okrUserIds) {
            $res['okrUserIds'] = $this->okrUserIds;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['okrUserIds'])) {
            if (!empty($map['okrUserIds'])) {
                $model->okrUserIds = $map['okrUserIds'];
            }
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
