<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QuerySingleGroupRequest\groupMembers;
use AlibabaCloud\Tea\Model;

class QuerySingleGroupRequest extends Model
{
    /**
     * @example 1745****8777
     *
     * @var groupMembers[]
     */
    public $groupMembers;

    /**
     * @example 14da****2760
     *
     * @var string
     */
    public $groupTemplateId;
    protected $_name = [
        'groupMembers'    => 'groupMembers',
        'groupTemplateId' => 'groupTemplateId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupMembers) {
            $res['groupMembers'] = [];
            if (null !== $this->groupMembers && \is_array($this->groupMembers)) {
                $n = 0;
                foreach ($this->groupMembers as $item) {
                    $res['groupMembers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->groupTemplateId) {
            $res['groupTemplateId'] = $this->groupTemplateId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySingleGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupMembers'])) {
            if (!empty($map['groupMembers'])) {
                $model->groupMembers = [];
                $n                   = 0;
                foreach ($map['groupMembers'] as $item) {
                    $model->groupMembers[$n++] = null !== $item ? groupMembers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['groupTemplateId'])) {
            $model->groupTemplateId = $map['groupTemplateId'];
        }

        return $model;
    }
}
