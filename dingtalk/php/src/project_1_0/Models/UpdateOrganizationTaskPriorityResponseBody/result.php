<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskPriorityResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example -10
     *
     * @var int
     */
    public $priority;

    /**
     * @example 2022-06-13T06:02:44.835Z
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'priority' => 'priority',
        'updated'  => 'updated',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
