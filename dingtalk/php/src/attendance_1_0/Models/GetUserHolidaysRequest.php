<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserHolidaysRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIds;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $workDateFrom;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $workDateTo;
    protected $_name = [
        'userIds' => 'userIds',
        'workDateFrom' => 'workDateFrom',
        'workDateTo' => 'workDateTo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }
        if (null !== $this->workDateFrom) {
            $res['workDateFrom'] = $this->workDateFrom;
        }
        if (null !== $this->workDateTo) {
            $res['workDateTo'] = $this->workDateTo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserHolidaysRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }
        if (isset($map['workDateFrom'])) {
            $model->workDateFrom = $map['workDateFrom'];
        }
        if (isset($map['workDateTo'])) {
            $model->workDateTo = $map['workDateTo'];
        }

        return $model;
    }
}
