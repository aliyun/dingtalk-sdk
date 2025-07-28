<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrbrainDeleteCustomRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $modelCode;

    /**
     * @description This parameter is required.
     *
     * @var mixed[][]
     */
    public $params;
    protected $_name = [
        'modelCode' => 'modelCode',
        'params' => 'params',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->modelCode) {
            $res['modelCode'] = $this->modelCode;
        }
        if (null !== $this->params) {
            $res['params'] = $this->params;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainDeleteCustomRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['modelCode'])) {
            $model->modelCode = $map['modelCode'];
        }
        if (isset($map['params'])) {
            if (!empty($map['params'])) {
                $model->params = $map['params'];
            }
        }

        return $model;
    }
}
