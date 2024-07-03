<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\HandoverTeamWithoutAuthRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @var bool
     */
    public $leave;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $newOwner;

    /**
     * @var bool
     */
    public $notify;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $teamId;
    protected $_name = [
        'leave'    => 'leave',
        'newOwner' => 'newOwner',
        'notify'   => 'notify',
        'teamId'   => 'teamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->leave) {
            $res['leave'] = $this->leave;
        }
        if (null !== $this->newOwner) {
            $res['newOwner'] = $this->newOwner;
        }
        if (null !== $this->notify) {
            $res['notify'] = $this->notify;
        }
        if (null !== $this->teamId) {
            $res['teamId'] = $this->teamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return param
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['leave'])) {
            $model->leave = $map['leave'];
        }
        if (isset($map['newOwner'])) {
            $model->newOwner = $map['newOwner'];
        }
        if (isset($map['notify'])) {
            $model->notify = $map['notify'];
        }
        if (isset($map['teamId'])) {
            $model->teamId = $map['teamId'];
        }

        return $model;
    }
}
