<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models\AmdpEmployeeDataPushRequest\param;
use AlibabaCloud\Tea\Model;

class AmdpEmployeeDataPushRequest extends Model
{
    /**
     * @var param[]
     */
    public $param;
    protected $_name = [
        'param' => 'param',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->param) {
            $res['param'] = [];
            if (null !== $this->param && \is_array($this->param)) {
                $n = 0;
                foreach ($this->param as $item) {
                    $res['param'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AmdpEmployeeDataPushRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['param'])) {
            if (!empty($map['param'])) {
                $model->param = [];
                $n            = 0;
                foreach ($map['param'] as $item) {
                    $model->param[$n++] = null !== $item ? param::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
