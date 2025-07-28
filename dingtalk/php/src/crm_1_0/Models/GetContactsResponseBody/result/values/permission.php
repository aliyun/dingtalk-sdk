<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetContactsResponseBody\result\values;

use AlibabaCloud\Tea\Model;

class permission extends Model
{
    /**
     * @var string[]
     */
    public $ownerUserIds;

    /**
     * @var string[]
     */
    public $participantUserIds;
    protected $_name = [
        'ownerUserIds' => 'ownerUserIds',
        'participantUserIds' => 'participantUserIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->ownerUserIds) {
            $res['ownerUserIds'] = $this->ownerUserIds;
        }
        if (null !== $this->participantUserIds) {
            $res['participantUserIds'] = $this->participantUserIds;
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
        if (isset($map['ownerUserIds'])) {
            if (!empty($map['ownerUserIds'])) {
                $model->ownerUserIds = $map['ownerUserIds'];
            }
        }
        if (isset($map['participantUserIds'])) {
            if (!empty($map['participantUserIds'])) {
                $model->participantUserIds = $map['participantUserIds'];
            }
        }

        return $model;
    }
}
