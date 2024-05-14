<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models\GetWorkspacesRequest\option;
use AlibabaCloud\Tea\Model;

class GetWorkspacesRequest extends Model
{
    /**
     * @var option
     */
    public $option;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $workspaceIds;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'option'       => 'option',
        'workspaceIds' => 'workspaceIds',
        'operatorId'   => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->option) {
            $res['option'] = null !== $this->option ? $this->option->toMap() : null;
        }
        if (null !== $this->workspaceIds) {
            $res['workspaceIds'] = $this->workspaceIds;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetWorkspacesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['option'])) {
            $model->option = option::fromMap($map['option']);
        }
        if (isset($map['workspaceIds'])) {
            if (!empty($map['workspaceIds'])) {
                $model->workspaceIds = $map['workspaceIds'];
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
