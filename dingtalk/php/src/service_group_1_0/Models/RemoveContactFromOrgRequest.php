<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class RemoveContactFromOrgRequest extends Model
{
    /**
     * @description 开放联系人uinionId
     *
     * @var string
     */
    public $contactUnionId;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'contactUnionId' => 'contactUnionId',
        'openTeamId'     => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contactUnionId) {
            $res['contactUnionId'] = $this->contactUnionId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveContactFromOrgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contactUnionId'])) {
            $model->contactUnionId = $map['contactUnionId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }

        return $model;
    }
}
