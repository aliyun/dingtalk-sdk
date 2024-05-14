<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CohostsRequest\userList;
use AlibabaCloud\Tea\Model;

class CohostsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example add
     *
     * @var string
     */
    public $action;

    /**
     * @description This parameter is required.
     *
     * @var userList[]
     */
    public $userList;
    protected $_name = [
        'action'   => 'action',
        'userList' => 'userList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->userList) {
            $res['userList'] = [];
            if (null !== $this->userList && \is_array($this->userList)) {
                $n = 0;
                foreach ($this->userList as $item) {
                    $res['userList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CohostsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['userList'])) {
            if (!empty($map['userList'])) {
                $model->userList = [];
                $n               = 0;
                foreach ($map['userList'] as $item) {
                    $model->userList[$n++] = null !== $item ? userList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
