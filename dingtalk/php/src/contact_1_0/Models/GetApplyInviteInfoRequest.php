<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetApplyInviteInfoRequest extends Model
{
    /**
     * @description 获取部门邀请链接的部门ID
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 邀请者userId
     *
     * @var string
     */
    public $inviterUserId;
    protected $_name = [
        'deptId'        => 'deptId',
        'inviterUserId' => 'inviterUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->inviterUserId) {
            $res['inviterUserId'] = $this->inviterUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetApplyInviteInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['inviterUserId'])) {
            $model->inviterUserId = $map['inviterUserId'];
        }

        return $model;
    }
}
