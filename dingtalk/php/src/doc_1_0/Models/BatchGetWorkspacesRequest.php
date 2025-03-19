<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchGetWorkspacesRequest extends Model
{
    /**
     * @var bool
     */
    public $includeRecent;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $workspaceIds;
    protected $_name = [
        'includeRecent' => 'includeRecent',
        'operatorId' => 'operatorId',
        'workspaceIds' => 'workspaceIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->includeRecent) {
            $res['includeRecent'] = $this->includeRecent;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->workspaceIds) {
            $res['workspaceIds'] = $this->workspaceIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchGetWorkspacesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['includeRecent'])) {
            $model->includeRecent = $map['includeRecent'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['workspaceIds'])) {
            if (!empty($map['workspaceIds'])) {
                $model->workspaceIds = $map['workspaceIds'];
            }
        }

        return $model;
    }
}
