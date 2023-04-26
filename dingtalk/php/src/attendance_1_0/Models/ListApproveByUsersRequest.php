<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListApproveByUsersRequest extends Model
{
    /**
     * @var int[]
     */
    public $bizTypes;

    /**
     * @example 1678636800000
     *
     * @var int
     */
    public $fromDateTime;

    /**
     * @example 1678636800000
     *
     * @var int
     */
    public $toDateTime;

    /**
     * @example user1,user2
     *
     * @var string
     */
    public $userIds;
    protected $_name = [
        'bizTypes'     => 'bizTypes',
        'fromDateTime' => 'fromDateTime',
        'toDateTime'   => 'toDateTime',
        'userIds'      => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizTypes) {
            $res['bizTypes'] = $this->bizTypes;
        }
        if (null !== $this->fromDateTime) {
            $res['fromDateTime'] = $this->fromDateTime;
        }
        if (null !== $this->toDateTime) {
            $res['toDateTime'] = $this->toDateTime;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListApproveByUsersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizTypes'])) {
            if (!empty($map['bizTypes'])) {
                $model->bizTypes = $map['bizTypes'];
            }
        }
        if (isset($map['fromDateTime'])) {
            $model->fromDateTime = $map['fromDateTime'];
        }
        if (isset($map['toDateTime'])) {
            $model->toDateTime = $map['toDateTime'];
        }
        if (isset($map['userIds'])) {
            $model->userIds = $map['userIds'];
        }

        return $model;
    }
}
