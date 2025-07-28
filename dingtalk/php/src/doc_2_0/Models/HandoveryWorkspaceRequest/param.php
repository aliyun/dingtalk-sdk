<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\HandoveryWorkspaceRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @example unionId
     *
     * @var bool
     */
    public $leave;

    /**
     * @description This parameter is required.
     *
     * @example unionId
     *
     * @var string
     */
    public $receiverUnionId;

    /**
     * @description This parameter is required.
     *
     * @example root_node_uuid
     *
     * @var string
     */
    public $resourceId;
    protected $_name = [
        'leave' => 'leave',
        'receiverUnionId' => 'receiverUnionId',
        'resourceId' => 'resourceId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->leave) {
            $res['leave'] = $this->leave;
        }
        if (null !== $this->receiverUnionId) {
            $res['receiverUnionId'] = $this->receiverUnionId;
        }
        if (null !== $this->resourceId) {
            $res['resourceId'] = $this->resourceId;
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
        if (isset($map['receiverUnionId'])) {
            $model->receiverUnionId = $map['receiverUnionId'];
        }
        if (isset($map['resourceId'])) {
            $model->resourceId = $map['resourceId'];
        }

        return $model;
    }
}
