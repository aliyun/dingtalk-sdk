<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class RollbackMiniAppVersionResponseBody extends Model
{
    /**
     * @description 结果码
     *
     * @var int
     */
    public $code;

    /**
     * @description 失败原因
     *
     * @var string
     */
    public $cause;
    protected $_name = [
        'code'  => 'code',
        'cause' => 'cause',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->cause) {
            $res['cause'] = $this->cause;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RollbackMiniAppVersionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['cause'])) {
            $model->cause = $map['cause'];
        }

        return $model;
    }
}
