<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchAddPermissionResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\BatchAddPermissionResponseBody\data\permissionTree\policyList;
use AlibabaCloud\Tea\Model;

class permissionTree extends Model
{
    /**
     * @var string
     */
    public $id;

    /**
     * @var policyList[]
     */
    public $policyList;

    /**
     * @example public
     *
     * @var string
     */
    public $privacy;

    /**
     * @example period
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'id'         => 'id',
        'policyList' => 'policyList',
        'privacy'    => 'privacy',
        'type'       => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->policyList) {
            $res['policyList'] = [];
            if (null !== $this->policyList && \is_array($this->policyList)) {
                $n = 0;
                foreach ($this->policyList as $item) {
                    $res['policyList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->privacy) {
            $res['privacy'] = $this->privacy;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return permissionTree
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['policyList'])) {
            if (!empty($map['policyList'])) {
                $model->policyList = [];
                $n                 = 0;
                foreach ($map['policyList'] as $item) {
                    $model->policyList[$n++] = null !== $item ? policyList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['privacy'])) {
            $model->privacy = $map['privacy'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
