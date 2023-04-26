<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SaveTeamMembersResponseBody\notInOrgMembers;
use AlibabaCloud\Tea\Model;

class SaveTeamMembersResponseBody extends Model
{
    /**
     * @var notInOrgMembers[]
     */
    public $notInOrgMembers;

    /**
     * @var bool
     */
    public $saveSuccess;
    protected $_name = [
        'notInOrgMembers' => 'notInOrgMembers',
        'saveSuccess'     => 'saveSuccess',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->notInOrgMembers) {
            $res['notInOrgMembers'] = [];
            if (null !== $this->notInOrgMembers && \is_array($this->notInOrgMembers)) {
                $n = 0;
                foreach ($this->notInOrgMembers as $item) {
                    $res['notInOrgMembers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->saveSuccess) {
            $res['saveSuccess'] = $this->saveSuccess;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveTeamMembersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['notInOrgMembers'])) {
            if (!empty($map['notInOrgMembers'])) {
                $model->notInOrgMembers = [];
                $n                      = 0;
                foreach ($map['notInOrgMembers'] as $item) {
                    $model->notInOrgMembers[$n++] = null !== $item ? notInOrgMembers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['saveSuccess'])) {
            $model->saveSuccess = $map['saveSuccess'];
        }

        return $model;
    }
}
