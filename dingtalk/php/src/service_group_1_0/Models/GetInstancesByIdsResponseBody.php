<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetInstancesByIdsResponseBody\customFormInstanceResponseList;
use AlibabaCloud\Tea\Model;

class GetInstancesByIdsResponseBody extends Model
{
    /**
     * @description Id of the request
     *
     * @var customFormInstanceResponseList[]
     */
    public $customFormInstanceResponseList;
    protected $_name = [
        'customFormInstanceResponseList' => 'customFormInstanceResponseList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customFormInstanceResponseList) {
            $res['customFormInstanceResponseList'] = [];
            if (null !== $this->customFormInstanceResponseList && \is_array($this->customFormInstanceResponseList)) {
                $n = 0;
                foreach ($this->customFormInstanceResponseList as $item) {
                    $res['customFormInstanceResponseList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInstancesByIdsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customFormInstanceResponseList'])) {
            if (!empty($map['customFormInstanceResponseList'])) {
                $model->customFormInstanceResponseList = [];
                $n                                     = 0;
                foreach ($map['customFormInstanceResponseList'] as $item) {
                    $model->customFormInstanceResponseList[$n++] = null !== $item ? customFormInstanceResponseList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
