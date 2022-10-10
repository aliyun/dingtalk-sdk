<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class InitVPaasDeviceResponseBody extends Model
{
    /**
     * @description pspk
     *
     * @var string
     */
    public $pspk;
    protected $_name = [
        'pspk' => 'pspk',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pspk) {
            $res['pspk'] = $this->pspk;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InitVPaasDeviceResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pspk'])) {
            $model->pspk = $map['pspk'];
        }

        return $model;
    }
}
