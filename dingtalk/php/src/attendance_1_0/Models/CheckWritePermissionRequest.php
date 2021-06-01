<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class CheckWritePermissionRequest extends Model
{
    /**
     * @description corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description opUserId
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description category
     *
     * @var string
     */
    public $category;

    /**
     * @description resourceKey
     *
     * @var string
     */
    public $resourceKey;

    /**
     * @description entityIds
     *
     * @var int[]
     */
    public $entityIds;
    protected $_name = [
        'corpId'      => 'corpId',
        'opUserId'    => 'opUserId',
        'category'    => 'category',
        'resourceKey' => 'resourceKey',
        'entityIds'   => 'entityIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->resourceKey) {
            $res['resourceKey'] = $this->resourceKey;
        }
        if (null !== $this->entityIds) {
            $res['entityIds'] = $this->entityIds;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['resourceKey'])) {
            $model->resourceKey = $map['resourceKey'];
        }
        if (isset($map['entityIds'])) {
            if (!empty($map['entityIds'])) {
                $model->entityIds = $map['entityIds'];
            }
        }

        return $model;
    }
}
