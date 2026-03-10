<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\SetInProgressCustomTabsRequest\customTabList;
use AlibabaCloud\Tea\Model;

class SetInProgressCustomTabsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var customTabList[]
     */
    public $customTabList;

    /**
     * @description This parameter is required.
     *
     * @example lJcRnm39OsU4jlFVmRGXXXXX
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'customTabList' => 'customTabList',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customTabList) {
            $res['customTabList'] = [];
            if (null !== $this->customTabList && \is_array($this->customTabList)) {
                $n = 0;
                foreach ($this->customTabList as $item) {
                    $res['customTabList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetInProgressCustomTabsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customTabList'])) {
            if (!empty($map['customTabList'])) {
                $model->customTabList = [];
                $n = 0;
                foreach ($map['customTabList'] as $item) {
                    $model->customTabList[$n++] = null !== $item ? customTabList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
