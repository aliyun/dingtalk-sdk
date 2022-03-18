<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasRequest\relationList;

use AlibabaCloud\Tea\Model;

class relationPermissionDTO extends Model
{
    /**
     * @description 协同人列表
     *
     * @var string[]
     */
    public $participantUserIds;

    /**
     * @description 负责人列表
     *
     * @var string[]
     */
    public $principalUserIds;
    protected $_name = [
        'participantUserIds' => 'participantUserIds',
        'principalUserIds'   => 'principalUserIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->participantUserIds) {
            $res['participantUserIds'] = $this->participantUserIds;
        }
        if (null !== $this->principalUserIds) {
            $res['principalUserIds'] = $this->principalUserIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return relationPermissionDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['participantUserIds'])) {
            if (!empty($map['participantUserIds'])) {
                $model->participantUserIds = $map['participantUserIds'];
            }
        }
        if (isset($map['principalUserIds'])) {
            if (!empty($map['principalUserIds'])) {
                $model->principalUserIds = $map['principalUserIds'];
            }
        }

        return $model;
    }
}
