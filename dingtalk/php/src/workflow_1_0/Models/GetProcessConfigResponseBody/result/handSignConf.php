<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessConfigResponseBody\result;

use AlibabaCloud\Tea\Model;

class handSignConf extends Model
{
    /**
     * @description 开启手写签名
     *
     * @var bool
     */
    public $handSignEnable;

    /**
     * @description 是否使用上次签名
     *
     * @var bool
     */
    public $resignEnable;
    protected $_name = [
        'handSignEnable' => 'handSignEnable',
        'resignEnable'   => 'resignEnable',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->handSignEnable) {
            $res['handSignEnable'] = $this->handSignEnable;
        }
        if (null !== $this->resignEnable) {
            $res['resignEnable'] = $this->resignEnable;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return handSignConf
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['handSignEnable'])) {
            $model->handSignEnable = $map['handSignEnable'];
        }
        if (isset($map['resignEnable'])) {
            $model->resignEnable = $map['resignEnable'];
        }

        return $model;
    }
}
