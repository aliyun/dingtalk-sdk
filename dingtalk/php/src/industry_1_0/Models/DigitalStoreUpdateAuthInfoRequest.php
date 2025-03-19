<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUpdateAuthInfoRequest\updateUserList;
use AlibabaCloud\Tea\Model;

class DigitalStoreUpdateAuthInfoRequest extends Model
{
    /**
     * @var updateUserList[]
     */
    public $updateUserList;
    protected $_name = [
        'updateUserList' => 'updateUserList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->updateUserList) {
            $res['updateUserList'] = [];
            if (null !== $this->updateUserList && \is_array($this->updateUserList)) {
                $n = 0;
                foreach ($this->updateUserList as $item) {
                    $res['updateUserList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreUpdateAuthInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['updateUserList'])) {
            if (!empty($map['updateUserList'])) {
                $model->updateUserList = [];
                $n = 0;
                foreach ($map['updateUserList'] as $item) {
                    $model->updateUserList[$n++] = null !== $item ? updateUserList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
