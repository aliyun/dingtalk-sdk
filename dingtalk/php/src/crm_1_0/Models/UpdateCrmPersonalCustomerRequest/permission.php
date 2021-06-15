<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateCrmPersonalCustomerRequest;

use AlibabaCloud\Tea\Model;

class permission extends Model
{
    /**
     * @var string[]
     */
    public $ownerStaffIds;

    /**
     * @var string[]
     */
    public $participantStaffIds;
    protected $_name = [
        'ownerStaffIds'       => 'ownerStaffIds',
        'participantStaffIds' => 'participantStaffIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->ownerStaffIds) {
            $res['ownerStaffIds'] = $this->ownerStaffIds;
        }
        if (null !== $this->participantStaffIds) {
            $res['participantStaffIds'] = $this->participantStaffIds;
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
        if (isset($map['ownerStaffIds'])) {
            if (!empty($map['ownerStaffIds'])) {
                $model->ownerStaffIds = $map['ownerStaffIds'];
            }
        }
        if (isset($map['participantStaffIds'])) {
            if (!empty($map['participantStaffIds'])) {
                $model->participantStaffIds = $map['participantStaffIds'];
            }
        }

        return $model;
    }
}
