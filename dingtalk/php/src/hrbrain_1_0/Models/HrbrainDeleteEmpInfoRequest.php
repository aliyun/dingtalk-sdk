<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainDeleteEmpInfoRequest\params;
use AlibabaCloud\Tea\Model;

class HrbrainDeleteEmpInfoRequest extends Model
{
    /**
     * @var params[]
     */
    public $params;
    protected $_name = [
        'params' => 'params',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->params) {
            $res['params'] = [];
            if (null !== $this->params && \is_array($this->params)) {
                $n = 0;
                foreach ($this->params as $item) {
                    $res['params'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainDeleteEmpInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['params'])) {
            if (!empty($map['params'])) {
                $model->params = [];
                $n = 0;
                foreach ($map['params'] as $item) {
                    $model->params[$n++] = null !== $item ? params::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
