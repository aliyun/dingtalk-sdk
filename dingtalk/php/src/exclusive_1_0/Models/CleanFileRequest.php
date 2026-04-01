<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CleanFileRequest\dentryIds;
use AlibabaCloud\Tea\Model;

class CleanFileRequest extends Model
{
    /**
     * @var dentryIds[]
     */
    public $dentryIds;

    /**
     * @var string
     */
    public $staffId;
    protected $_name = [
        'dentryIds' => 'dentryIds',
        'staffId' => 'staffId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryIds) {
            $res['dentryIds'] = [];
            if (null !== $this->dentryIds && \is_array($this->dentryIds)) {
                $n = 0;
                foreach ($this->dentryIds as $item) {
                    $res['dentryIds'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CleanFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryIds'])) {
            if (!empty($map['dentryIds'])) {
                $model->dentryIds = [];
                $n = 0;
                foreach ($map['dentryIds'] as $item) {
                    $model->dentryIds[$n++] = null !== $item ? dentryIds::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }

        return $model;
    }
}
