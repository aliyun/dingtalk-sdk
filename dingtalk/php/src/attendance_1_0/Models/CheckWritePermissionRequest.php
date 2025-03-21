<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CheckWritePermissionRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example GROUP
     *
     * @var string
     */
    public $category;

    /**
     * @description This parameter is required.
     *
     * @var int[]
     */
    public $entityIds;

    /**
     * @description This parameter is required.
     *
     * @example 050728xxx921
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description This parameter is required.
     *
     * @example SCHEDULE
     *
     * @var string
     */
    public $resourceKey;
    protected $_name = [
        'category' => 'category',
        'entityIds' => 'entityIds',
        'opUserId' => 'opUserId',
        'resourceKey' => 'resourceKey',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->entityIds) {
            $res['entityIds'] = $this->entityIds;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->resourceKey) {
            $res['resourceKey'] = $this->resourceKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CheckWritePermissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['entityIds'])) {
            if (!empty($map['entityIds'])) {
                $model->entityIds = $map['entityIds'];
            }
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['resourceKey'])) {
            $model->resourceKey = $map['resourceKey'];
        }

        return $model;
    }
}
