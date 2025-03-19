<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models;

use AlibabaCloud\Tea\Model;

class HandOverWorkspaceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example source_owner_id
     *
     * @var string
     */
    public $sourceOwnerId;

    /**
     * @description This parameter is required.
     *
     * @example source_owner_id
     *
     * @var string
     */
    public $targetOwnerId;

    /**
     * @description This parameter is required.
     *
     * @example workspace_id
     *
     * @var string
     */
    public $workspaceId;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'sourceOwnerId' => 'sourceOwnerId',
        'targetOwnerId' => 'targetOwnerId',
        'workspaceId' => 'workspaceId',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sourceOwnerId) {
            $res['sourceOwnerId'] = $this->sourceOwnerId;
        }
        if (null !== $this->targetOwnerId) {
            $res['targetOwnerId'] = $this->targetOwnerId;
        }
        if (null !== $this->workspaceId) {
            $res['workspaceId'] = $this->workspaceId;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HandOverWorkspaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sourceOwnerId'])) {
            $model->sourceOwnerId = $map['sourceOwnerId'];
        }
        if (isset($map['targetOwnerId'])) {
            $model->targetOwnerId = $map['targetOwnerId'];
        }
        if (isset($map['workspaceId'])) {
            $model->workspaceId = $map['workspaceId'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
