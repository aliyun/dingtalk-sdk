<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateProjectGroupRequest extends Model
{
    /**
     * @var string[]
     */
    public $addProjectGroupIds;

    /**
     * @var string[]
     */
    public $delProjectGroupIds;
    protected $_name = [
        'addProjectGroupIds' => 'addProjectGroupIds',
        'delProjectGroupIds' => 'delProjectGroupIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->addProjectGroupIds) {
            $res['addProjectGroupIds'] = $this->addProjectGroupIds;
        }
        if (null !== $this->delProjectGroupIds) {
            $res['delProjectGroupIds'] = $this->delProjectGroupIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateProjectGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['addProjectGroupIds'])) {
            if (!empty($map['addProjectGroupIds'])) {
                $model->addProjectGroupIds = $map['addProjectGroupIds'];
            }
        }
        if (isset($map['delProjectGroupIds'])) {
            if (!empty($map['delProjectGroupIds'])) {
                $model->delProjectGroupIds = $map['delProjectGroupIds'];
            }
        }

        return $model;
    }
}
