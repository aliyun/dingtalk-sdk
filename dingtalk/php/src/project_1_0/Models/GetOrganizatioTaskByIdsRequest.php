<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOrganizatioTaskByIdsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 62a010c153c2ef5244xxxx, 62a010c153c2ef524xxxxxx
     *
     * @var string
     */
    public $taskIds;
    protected $_name = [
        'taskIds' => 'taskIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskIds) {
            $res['taskIds'] = $this->taskIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOrganizatioTaskByIdsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['taskIds'])) {
            $model->taskIds = $map['taskIds'];
        }

        return $model;
    }
}
