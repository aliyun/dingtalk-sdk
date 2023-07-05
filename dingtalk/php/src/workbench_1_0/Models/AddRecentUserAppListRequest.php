<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkbench_1_0\Models\AddRecentUserAppListRequest\usedAppDetailList;
use AlibabaCloud\Tea\Model;

class AddRecentUserAppListRequest extends Model
{
    /**
     * @example ding48143d56cd15327624f2f5cc6abecb85
     *
     * @var string
     */
    public $corpId;

    /**
     * @var usedAppDetailList[]
     */
    public $usedAppDetailList;

    /**
     * @example 642325391030949
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'corpId'            => 'corpId',
        'usedAppDetailList' => 'usedAppDetailList',
        'userId'            => 'userId',
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
        if (null !== $this->usedAppDetailList) {
            $res['usedAppDetailList'] = [];
            if (null !== $this->usedAppDetailList && \is_array($this->usedAppDetailList)) {
                $n = 0;
                foreach ($this->usedAppDetailList as $item) {
                    $res['usedAppDetailList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddRecentUserAppListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['usedAppDetailList'])) {
            if (!empty($map['usedAppDetailList'])) {
                $model->usedAppDetailList = [];
                $n                        = 0;
                foreach ($map['usedAppDetailList'] as $item) {
                    $model->usedAppDetailList[$n++] = null !== $item ? usedAppDetailList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
