<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryTasksV3Request extends Model
{
    /**
     * @var string
     */
    public $parentTaskId;

    /**
     * @var string
     */
    public $shortIds;

    /**
     * @var string
     */
    public $taskId;
    protected $_name = [
        'parentTaskId' => 'parentTaskId',
        'shortIds'     => 'shortIds',
        'taskId'       => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->parentTaskId) {
            $res['parentTaskId'] = $this->parentTaskId;
        }
        if (null !== $this->shortIds) {
            $res['shortIds'] = $this->shortIds;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryTasksV3Request
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['parentTaskId'])) {
            $model->parentTaskId = $map['parentTaskId'];
        }
        if (isset($map['shortIds'])) {
            $model->shortIds = $map['shortIds'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
