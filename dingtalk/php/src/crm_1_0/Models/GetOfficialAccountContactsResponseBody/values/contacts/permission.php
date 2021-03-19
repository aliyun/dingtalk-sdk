<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactsResponseBody\values\contacts;

use AlibabaCloud\Tea\Model;

class permission extends Model
{
    /**
     * @description 协同人用户ID列表
     *
     * @var string[]
     */
    public $participantStaffIds;

    /**
     * @description 负责人用户ID列表
     *
     * @var string[]
     */
    public $ownerStaffIds;
    protected $_name = [
        'participantStaffIds' => 'participantStaffIds',
        'ownerStaffIds'       => 'ownerStaffIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->participantStaffIds) {
            $res['participantStaffIds'] = $this->participantStaffIds;
        }
        if (null !== $this->ownerStaffIds) {
            $res['ownerStaffIds'] = $this->ownerStaffIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return permission
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['participantStaffIds'])) {
            if (!empty($map['participantStaffIds'])) {
                $model->participantStaffIds = $map['participantStaffIds'];
            }
        }
        if (isset($map['ownerStaffIds'])) {
            if (!empty($map['ownerStaffIds'])) {
                $model->ownerStaffIds = $map['ownerStaffIds'];
            }
        }

        return $model;
    }
}
