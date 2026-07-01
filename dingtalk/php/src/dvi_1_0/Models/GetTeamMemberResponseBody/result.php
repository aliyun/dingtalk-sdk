<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTeamMemberResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTeamMemberResponseBody\result\admins;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTeamMemberResponseBody\result\depts;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTeamMemberResponseBody\result\members;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var admins[]
     */
    public $admins;

    /**
     * @var depts[]
     */
    public $depts;

    /**
     * @var members[]
     */
    public $members;
    protected $_name = [
        'admins' => 'admins',
        'depts' => 'depts',
        'members' => 'members',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->admins) {
            $res['admins'] = [];
            if (null !== $this->admins && \is_array($this->admins)) {
                $n = 0;
                foreach ($this->admins as $item) {
                    $res['admins'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->depts) {
            $res['depts'] = [];
            if (null !== $this->depts && \is_array($this->depts)) {
                $n = 0;
                foreach ($this->depts as $item) {
                    $res['depts'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->members) {
            $res['members'] = [];
            if (null !== $this->members && \is_array($this->members)) {
                $n = 0;
                foreach ($this->members as $item) {
                    $res['members'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['admins'])) {
            if (!empty($map['admins'])) {
                $model->admins = [];
                $n = 0;
                foreach ($map['admins'] as $item) {
                    $model->admins[$n++] = null !== $item ? admins::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['depts'])) {
            if (!empty($map['depts'])) {
                $model->depts = [];
                $n = 0;
                foreach ($map['depts'] as $item) {
                    $model->depts[$n++] = null !== $item ? depts::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['members'])) {
            if (!empty($map['members'])) {
                $model->members = [];
                $n = 0;
                foreach ($map['members'] as $item) {
                    $model->members[$n++] = null !== $item ? members::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
