<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupUserRoleQueryResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenGroupUserRoleQueryResponseBody\result\groupRoles;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var groupRoles[]
     */
    public $groupRoles;
    protected $_name = [
        'groupRoles' => 'groupRoles',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupRoles) {
            $res['groupRoles'] = [];
            if (null !== $this->groupRoles && \is_array($this->groupRoles)) {
                $n = 0;
                foreach ($this->groupRoles as $item) {
                    $res['groupRoles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['groupRoles'])) {
            if (!empty($map['groupRoles'])) {
                $model->groupRoles = [];
                $n = 0;
                foreach ($map['groupRoles'] as $item) {
                    $model->groupRoles[$n++] = null !== $item ? groupRoles::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
