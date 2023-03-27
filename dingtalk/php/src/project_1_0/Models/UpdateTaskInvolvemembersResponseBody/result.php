<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateTaskInvolvemembersResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 参与者列表。
     *
     * @var string[]
     */
    public $involveMembers;

    /**
     * @description 更新时间。
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'involveMembers' => 'involveMembers',
        'updated'        => 'updated',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->involveMembers) {
            $res['involveMembers'] = $this->involveMembers;
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
        if (isset($map['involveMembers'])) {
            if (!empty($map['involveMembers'])) {
                $model->involveMembers = $map['involveMembers'];
            }
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
