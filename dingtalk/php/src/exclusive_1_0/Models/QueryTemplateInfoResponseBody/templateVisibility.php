<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody\templateVisibility\deptIds;
use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryTemplateInfoResponseBody\templateVisibility\userIds;
use AlibabaCloud\Tea\Model;

class templateVisibility extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var deptIds[]
     */
    public $deptIds;

    /**
     * @var string[]
     */
    public $roleIds;

    /**
     * @var userIds[]
     */
    public $userIds;
    protected $_name = [
        'corpId'  => 'corpId',
        'deptIds' => 'deptIds',
        'roleIds' => 'roleIds',
        'userIds' => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deptIds) {
            $res['deptIds'] = [];
            if (null !== $this->deptIds && \is_array($this->deptIds)) {
                $n = 0;
                foreach ($this->deptIds as $item) {
                    $res['deptIds'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->roleIds) {
            $res['roleIds'] = $this->roleIds;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = [];
            if (null !== $this->userIds && \is_array($this->userIds)) {
                $n = 0;
                foreach ($this->userIds as $item) {
                    $res['userIds'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return templateVisibility
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = [];
                $n              = 0;
                foreach ($map['deptIds'] as $item) {
                    $model->deptIds[$n++] = null !== $item ? deptIds::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['roleIds'])) {
            if (!empty($map['roleIds'])) {
                $model->roleIds = $map['roleIds'];
            }
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = [];
                $n              = 0;
                foreach ($map['userIds'] as $item) {
                    $model->userIds[$n++] = null !== $item ? userIds::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
