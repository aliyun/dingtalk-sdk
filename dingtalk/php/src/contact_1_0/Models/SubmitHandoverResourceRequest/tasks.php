<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\SubmitHandoverResourceRequest;

use AlibabaCloud\Tea\Model;

class tasks extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example handover
     *
     * @var string
     */
    public $actionType;

    /**
     * @example userIdYYY
     *
     * @var string
     */
    public $receiverStaffId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $resourceTypeId;
    protected $_name = [
        'actionType' => 'actionType',
        'receiverStaffId' => 'receiverStaffId',
        'resourceTypeId' => 'resourceTypeId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->receiverStaffId) {
            $res['receiverStaffId'] = $this->receiverStaffId;
        }
        if (null !== $this->resourceTypeId) {
            $res['resourceTypeId'] = $this->resourceTypeId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return tasks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['receiverStaffId'])) {
            $model->receiverStaffId = $map['receiverStaffId'];
        }
        if (isset($map['resourceTypeId'])) {
            $model->resourceTypeId = $map['resourceTypeId'];
        }

        return $model;
    }
}
